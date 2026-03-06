using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;

namespace Inversions.ClassesEntity
{
    public partial class Moneda
    {
        public static DbSet<Moneda> Tuples
        {
            get { return Program.Sessio.Monedes; }
        }

        public static void RefrescaTaula()
        {
            Program.Sessio.refrescaTaula(typeof (Moneda));

            // Fa que es recarreguin el "ICollection" de la taula.
            List<Moneda> xx = Tuples.ToList();
        }

        #region Overrides

        public override int GetHashCode()
        {
            return Codi?.GetHashCode() ?? 0;
        }

        public static bool operator ==(Moneda a, Moneda b)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(a, b))
            {
                return true;
            }

            // If one is null,return false.
            if ((object) a == null || (object) b == null)
            {
                return false;
            }

            return a.Codi == b.Codi;
        }

        public static bool operator !=(Moneda a, Moneda b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Moneda))
                return false;

            return this == (Moneda) obj;
        }

        public override string ToString()
        {
            return Codi;
        }

        #endregion
    }
}