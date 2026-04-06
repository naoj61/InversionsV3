using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Reflection;

namespace Inversions.ClassesEntity
{
    public partial class InversionsBDContext
    {
        private InversionsBDContext(string connectionString) : base(connectionString) { }

        /// <summary>
        /// Creates a new instance of the InversionsBDContext class using the configured connection string.
        /// </summary>
        /// <remarks>Use this method to obtain a properly configured database context for interacting with
        /// the application's data store. The returned context should be disposed of when no longer needed.</remarks>
        /// <returns>A new InversionsBDContext initialized with the application's configured database connection settings.</returns>
        public static InversionsBDContext Create()
        {
            return new InversionsBDContext(ObtenirCadenaConfigurada());
        }


        /// <summary>
        /// Builds and returns the configured Entity Framework connection string for the application's database, using
        /// the appropriate file path based on the current build configuration.Podem afegir una lògica "estàtica" per obtenir la cadena correctament
        /// </summary>
        /// <remarks>The returned connection string is constructed by modifying the base connection string
        /// from the application's configuration to include the correct database file path. The file path is determined
        /// by the build configuration (Debug or Release) and application settings. This method is intended for internal
        /// use when a dynamically constructed connection string is required.</remarks>
        /// <returns>A connection string that can be used to connect to the application's database with Entity Framework. The
        /// string reflects the correct database file path for the current environment.</returns>
        private static string ObtenirCadenaConfigurada()
        {
            string directoriBd;
#if DEBUG
            directoriBd = "DirBdDebug";
#else
            directoriBd = "DirBd";
#endif
            // Trova el valor de la variable a app.config segons el build configuration (Debug o Release).
            directoriBd = ConfigurationManager.AppSettings[directoriBd];
            
            // Expandeix les variables d'entorn en el path, si n'hi ha.
            directoriBd = Environment.ExpandEnvironmentVariables(directoriBd);

            // 1. Obtenim la cadena base de l'App.config
            var configString = ConfigurationManager.ConnectionStrings["InversionsBDContext"].ConnectionString;

            // 2. Utilitzem l'EntityConnectionStringBuilder per modificar NOMÉS el path del fitxer
            var entityBuilder = new System.Data.Entity.Core.EntityClient.EntityConnectionStringBuilder(configString);
            var sqlBuilder = new System.Data.SqlClient.SqlConnectionStringBuilder(entityBuilder.ProviderConnectionString);

            // 3. Injectem el path correcte directament. Substitueix TOKEN_PATH.
            sqlBuilder.AttachDBFilename = System.IO.Path.Combine(directoriBd, ConfigurationManager.AppSettings["NomBd"]);

            // 4. Tornem a muntar la cadena
            entityBuilder.ProviderConnectionString = sqlBuilder.ToString();
            
            return entityBuilder.ToString();
        }

        public virtual DbSet<ProdFons> ProdFons { get; set; }
        public virtual DbSet<ProdAccions> ProdAccions { get; set; }
        public virtual DbSet<Valoracio> Valoracio { get; set; }

        /// <summary>
        ///     Troba l'entity type a partir del nom de la taula. Ex Valoracions --> Valoracio
        /// </summary>
        /// <param name="nomTaula"></param>
        /// <returns></returns>
        private Type GetEntityType(string nomTaula)
        {
            // Si el nom taula conté '_' és que es una taula amb herencia, la part esquerra de '_' s'ha de descartar.
            if (nomTaula.Contains("_"))
                nomTaula = nomTaula.Substring(nomTaula.IndexOf('_') + 1);

            // Busquem la propietat DbSet corresponent al nom del conjunt d'entitats utilitzant reflexió
            PropertyInfo dbSetProperty = GetType().GetProperties()
                .FirstOrDefault(p => p.PropertyType.IsGenericType &&
                                     p.PropertyType.GetGenericTypeDefinition() == typeof (DbSet<>) &&
                                     p.Name == nomTaula);

            // Si no s'ha trobat cap coincidència, retornem null
            return dbSetProperty != null ? dbSetProperty.PropertyType.GetGenericArguments().FirstOrDefault() : null;
        }

        /// <summary>
        ///     Refresca només una taula a partir del nom.
        /// </summary>
        /// <param name="nomTaula"></param>
        public void refrescaTaula(string nomTaula)
        {
            Type entityType = GetEntityType(nomTaula);

            if (entityType == null)
                throw new InvalidExpressionException("La taula: " + nomTaula + " no existeix");

            refrescaTaula(entityType);
        }

        /// <summary>
        ///     Refresca només una taula a partir del Type.
        /// </summary>
        /// <param name="entityType"></param>
        public void refrescaTaula(Type entityType)
        {
            ObjectContext context = ((IObjectContextAdapter) this).ObjectContext;

            IEnumerable<object> objects = context.ObjectStateManager.GetObjectStateEntries(
                EntityState.Added |
                EntityState.Deleted |
                EntityState.Modified |
                EntityState.Unchanged)
                .Where(x => x.EntityKey != null && ObjectContext.GetObjectType(x.Entity.GetType()) == entityType)
                .Select(e => e.Entity);

            context.Refresh(RefreshMode.StoreWins, objects);
        }


        /// <summary>
        ///     Desfà els canvis pendents de "entity"
        /// </summary>
        /// <param name="entity"></param>
        internal void UndoingChangesDbEntityPropertyLevel(object entity)
        {
            DbEntityEntry entry = Entry(entity);
            if (entry.State == EntityState.Added || entry.State == EntityState.Detached)
            {
                entry.State = EntityState.Detached;
            }
            else
            {
                entry.State = EntityState.Unchanged;
            }
        }


        protected override DbEntityValidationResult ValidateEntity(DbEntityEntry entityEntry, IDictionary<object, object> items)
        {
            var list = new List<DbValidationError>();

            if (entityEntry.Entity is Empresa)
            {
                var entity = entityEntry.Entity as Empresa;

                if (entity.Nom == "")
                    list.Add(new DbValidationError("Nom", "El Nom és obligatori"));

                //if (entityEntry.State == EntityState.Added
                //    && dbSet.SingleOrDefault(f => f.Id == entity.Id) != null)
                //    list.Add(new DbValidationError("Id", "Duplicate key"));

                if (Empreses.Any(f => f.Nom == entity.Nom && f.Id != entity.Id))
                    list.Add(new DbValidationError("Nom", "Clau duplicada"));
            }
            else if (entityEntry.Entity is Gestor)
            {
                var entity = entityEntry.Entity as Gestor;

                if (entity.Nom == "")
                    list.Add(new DbValidationError("Nom", "Nom is required"));

                if (Gestors.Any(f => f.Nom == entity.Nom && f.Id != entity.Id))
                    list.Add(new DbValidationError("Nom", "Duplicate key"));
            }
            else if (entityEntry.Entity is ProdFons)
            {
                var entity = entityEntry.Entity as ProdFons;

                if (entity.Nom == "")
                    list.Add(new DbValidationError("Nom", "Nom is required"));

                if (ProdFons.Any(f => f.Nom == entity.Nom && f.Id != entity.Id))
                    list.Add(new DbValidationError("Nom", "Duplicate key"));


                if (entity.Gestors.Count > 0)
                {
                    // Valida que tots els gestors siguin de la mateixa empresa.
                    if (entity.Gestors.GroupBy(s => s.EmpresaId).Count() > 1)
                        list.Add(new DbValidationError("Gestor", "Tots els gestors han de pertanyer a la mateixa empresa."));

                    // Valida que l'empresa del gestor i la del producte, siguin la mateixa.
                    if (entity.EmpresaId != entity.Gestors.First().EmpresaId)
                        list.Add(new DbValidationError("Empresa", "No coincideix empresa gestor i empresa producte."));
                }
            }

            if (list.Count > 0)
                return new DbEntityValidationResult(entityEntry, list);
            return base.ValidateEntity(entityEntry, items);
        }
    }
}