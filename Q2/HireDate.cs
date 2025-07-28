using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Q2
{
    internal class HireDate
    {
        #region properties
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        #endregion

        #region constructors

        public HireDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        #endregion

        #region methods
        public override string ToString()
        {
            return $"{Day:D2}/{Month:D2}/{Year}";
        }

        #endregion

    }
}
