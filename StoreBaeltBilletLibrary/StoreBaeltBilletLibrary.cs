using System;
using BilletLibrary;
namespace StoreBaeltBilletLibrary
{
    public class StoreBaeltBilletLibrary
    {
        Bil bil = new Bil("AB72131");

        DayOfWeek dag = DateTime.Now.DayOfWeek;
        /// <summary>   
        /// Weekend pris tjekker om det er weekend og giver 20% rabat.
        /// </summary>
        public decimal WeekendPris(bool broBizz)
        {
            if (dag == DayOfWeek.Saturday || dag == DayOfWeek.Sunday)
            {
                if (broBizz)
                    return bil.Pris(true) * (decimal)0.80;
                return bil.Pris(false) * (decimal)0.80;
            }
            if (broBizz)
                return bil.Pris(true);
            return bil.Pris(false);
        }
    }
}
