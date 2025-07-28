using System.Data;

using Demo.Q1;
using Demo.Q2;
using Demo.Q3;
using Demo.Q5;


namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 
            //Employee emp = new Employee();

            //emp.ID = 1;

            //Console.Write("enter Employee Name:");
            //emp.Name = Console.ReadLine();

            //Gender genderInput;
            //while (true)
            //{
            //    Console.Write("Enter Employee Gender (M/F): ");
            //    string input = Console.ReadLine().ToUpper();

            //    if (input == "M")
            //    {
            //        genderInput = Gender.Male;
            //        break;
            //    }
            //    else if (input == "F")
            //    {
            //        genderInput = Gender.Female;
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input. Please enter 'M' or 'F'.");
            //    }
            //}

            //emp.Gender = genderInput;
            //Console.Write("Enter Employee Salary: ");
            //emp.Salary = double.Parse(Console.ReadLine());

            //Console.Write("Enter Employee Hire Date (any format): ");
            //emp.HireDate = Console.ReadLine();

            //emp.Security = SecurityLevel.Developer;


            //Console.WriteLine("\nEmployee Information:\n");
            //Console.WriteLine(emp);

            #endregion
            #region Q2
            //Console.Write("Enter Day: ");
            //int day = int.Parse(Console.ReadLine());

            //Console.Write("Enter Month: ");
            //int month = int.Parse(Console.ReadLine());

            //Console.Write("Enter Year: ");
            //int year = int.Parse(Console.ReadLine());

            //HireDate hiringDate = new HireDate(day, month, year);

            //Console.WriteLine("Hiring Date: " + hiringDate);


            #endregion
            #region Q3
            //Employee02 Emp01 = new Employee02(1, "Ali", Role.DBA, Permission.Read | Permission.Write);
            //Employee02 Emp02 = new Employee02(2, "Sara", Role.Guest, Permission.Read);
            //Employee02 Emp03 = new Employee02(3, "Omar", Role.SecurityOfficer, Permission.Execute);

            //Console.WriteLine("Employee List:");
            //Console.WriteLine("=======================");
            //Emp01.Display();
            //Console.WriteLine("=======================");
            //Emp02.Display();
            //Console.WriteLine("=======================");
            //Emp03.Display();
            //Console.WriteLine("=======================");


            #endregion
            #region Q4

            #endregion
            #region Q5
            /*
             * 01.
             *  -There is no reapted code since the Book class is used as a base class for both EBook and PrintedBook.
             *  -this helps us to avoid code duplication and maintain a clean and organized code structure.
             * 
             * 02.
             *  -The EBook class and PrintedBook class inherits from the Book class, which means they have access to all the properties and methods defined in the Book class.
             * 
             */

            #endregion
        }
    }
}
