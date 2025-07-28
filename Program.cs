namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 
            Employee emp = new Employee();

            emp.ID = 1;

            Console.Write("enter Employee Name:");
            emp.Name = Console.ReadLine();

            Gender genderInput;
            while (true)
            {
                Console.Write("Enter Employee Gender (M/F): ");
                string input = Console.ReadLine().ToUpper();

                if (input == "M")
                {
                    genderInput = Gender.Male;
                    break;
                }
                else if (input == "F")
                {
                    genderInput = Gender.Female;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'M' or 'F'.");
                }
            }

            emp.Gender = genderInput;
            Console.Write("Enter Employee Salary: ");
            emp.Salary = double.Parse(Console.ReadLine());

            Console.Write("Enter Employee Hire Date (any format): ");
            emp.HireDate = Console.ReadLine();

            emp.Security = SecurityLevel.Developer;


            Console.WriteLine("\nEmployee Information:\n");
            Console.WriteLine(emp);

            #endregion
        }
    }
}
