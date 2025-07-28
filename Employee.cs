using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Employee
    {
        #region properties
        public int ID { get; set; }
        public string? Name { get; set; }
        public Gender Gender { get; set; }
        public double Salary { get; set; }
        public string? HireDate { get; set; } 
        public SecurityLevel Security { get; set; }
        #endregion



        #region methods

        public override string ToString()
        {
            return $"ID: {ID}, \nName: {Name} , \nGenger: {Gender}, \nSalary: {Salary.ToString("C", CultureInfo.CurrentCulture)}, \nHireDate: {HireDate}, \nSecurity: {Security}";

        }

        #endregion


    }
}
