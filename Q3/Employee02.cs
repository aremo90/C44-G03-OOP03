using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Q3
{
    internal class Employee02
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Role EmployeeRole { get; set; }
        public Permission Permissions { get; set; }



        #region Constructor
        public Employee02(int id, string name, Role role, Permission permissions)
        {
            ID = id;
            Name = name;
            EmployeeRole = role;
            Permissions = permissions;
        }
        #endregion


        #region methods
        // Display Method
        public void Display()
        {
            Console.WriteLine($"ID: {ID}, \nName: {Name}, \nRole: {EmployeeRole}, \nPermissions: {Permissions}");
        }

        // ToString Method
        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Role: {EmployeeRole}, Permissions: {Permissions}";
        }
        #endregion 
    }
}
