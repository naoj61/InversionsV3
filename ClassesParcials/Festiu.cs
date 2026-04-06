using Comuns;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;

namespace Inversions.ClassesEntity
{
    public partial class Festiu
    {
        public static DbSet<Festiu> Tuples
        {
            get { return Program.Sessio.Festius; }
        }

        public static void RefrescaTaula()
        {
            Program.Sessio.refrescaTaula(typeof(Festiu));

            // Fa que es recarreguin el "ICollection" de la taula.
            List<Festiu> xx = Tuples.ToList();
        }

        /// <summary>
        /// Creates calendar entries for the specified year and calendar type in the database.
        /// </summary>
        /// <remarks>This method performs database operations within a transaction. If an error occurs,
        /// all changes are rolled back.</remarks>
        /// <param name="any">The year for which to create calendar entries.</param>
        /// <param name="cal">The calendar type indicating which calendar entries to create.</param>
        internal static void CreaCalendari(int any, Calendaris cal)
        {
            using (var conn = InversionsBDContext.Create())
            {
                using (DbContextTransaction dbContextTransaction = conn.Database.BeginTransaction())
                {
                    try
                    {
                        if (cal == Calendaris.CAT)
                        {
                            CreaCalendariCatalunya(conn, any);
                        }

                        if (cal == Calendaris.USA)
                        {
                            CreaCalendariUsa(conn, any);
                        }

                        dbContextTransaction.Commit();
                    }
                    catch (Exception)
                    {
                        dbContextTransaction.Rollback();
                        
                        throw;
                    }
                }
            }
        }

        /// <summary>
        /// Creates and adds U.S. market holiday entries for the specified year to the database.
        /// </summary>
        /// <remarks>This method retrieves the list of holidays for the New York Stock Exchange (NYSE) for
        /// the specified year and adds each as a holiday entry to the database. Each holiday is saved immediately after
        /// being added.</remarks>
        /// <param name="conn">The database context used to add holiday entries. Must not be null.</param>
        /// <param name="any">The year for which to create U.S. market holiday entries.</param>
        private static void CreaCalendariUsa(InversionsBDContext conn, int any)
        {
            var festius = FinancialModelingPrep.FestiusBorses("NYSE", any).Result;
            foreach (var f in festius.OrderBy(o => o.Data))
            {
                Festiu festiu = conn.Festius.Create();

                festiu.Calendari = Calendaris.USA;
                festiu.Any = any;
                festiu.DiaFestiu = f.Data.Date;

                conn.Festius.Add(festiu);
                conn.SaveChanges();
            }
        }

        /// <summary>
        /// Creates and saves holiday entries for Catalonia for the specified year in the provided database context.
        /// </summary>
        /// <remarks>This method retrieves the list of national and regional holidays for Catalonia and
        /// adds them to the database. Each holiday is saved immediately after being added.</remarks>
        /// <param name="conn">The database context used to add holiday entries. Must not be null.</param>
        /// <param name="any">The year for which to create the holiday calendar.</param>
        private static void CreaCalendariCatalunya(InversionsBDContext conn, int any)
        {
            var festius = FestiusCatalunya.EstatalsAutonomics(any).Result;
            foreach (var f in festius.OrderBy(o => o.Data))
            {
                Festiu festiu = conn.Festius.Create();

                festiu.Calendari = Calendaris.CAT;
                festiu.Any = any;
                festiu.DiaFestiu = f.Data.Date;

                conn.Festius.Add(festiu);
                conn.SaveChanges();
            }
        }

        /// <summary>
        /// Returns the most recent working day on or before the specified date, according to the given calendar.
        /// </summary>
        /// <remarks>A working day is defined as a day that is not a Saturday, Sunday, or a holiday in the
        /// specified calendar. If the input date is a non-working day, the method recursively checks previous days
        /// until a working day is found.</remarks>
        /// <param name="data">The date to evaluate. The method searches for the last working day on or before this date.</param>
        /// <param name="cal">The calendar to use for determining holidays and weekends. Defaults to Calendaris.USA if not specified.</param>
        /// <returns>A DateTime representing the last working day on or before the specified date, excluding weekends and
        /// holidays as defined by the selected calendar.</returns>
        internal static DateTime UltimDiaLaborable(DateTime data, Calendaris cal = Calendaris.USA)
        {
            if (data.DayOfWeek == DayOfWeek.Sunday)
            {
                return UltimDiaLaborable(data.AddDays(-2));
            }
            
            if (data.DayOfWeek == DayOfWeek.Saturday)
            {
                return UltimDiaLaborable(data.AddDays(-1));
            }

            if(Festiu.Tuples.Any(a => a.Calendari == cal && a.DiaFestiu == data))
            {
                return UltimDiaLaborable(data.AddDays(-1));
            }

            return data;
        }
    }
}