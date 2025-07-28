using Helper;
namespace Demo
{
    internal class Program
    {

        static void Main(string[] args)
        {

            #region User defined Data Types [Classes]
            /*
             * Blueprint => contain objects
             * Reference Type objects of class stored in stack and values stored in heap
             * compiler will generate empty parameterless constructor
             * if a user defined constructor found , compiler will no longer need parameterless constructor
             *  - Attributes
             *  - Functions
             *  - Properties
             *  - events
             * 
             * 
             *  - 6 Access Modifiers
             *  - default Access Modifier for class members is private
             *  - Default Access Modifier for classes is internal
             */

            //Car c1;
            // Declare for reference type from 'Car' class
            // c1 refer to defult value in heap
            // This reference c1 can refer to an instance of the class Car or any data type that inherits from Car.
            // CLR will allocate 4 byte at stacj for object 'C1'

            //c1 = new Car( 10 , "BMW" , 300 );
            //Console.WriteLine(c1);

            //Car c2 = new Car( 20 , "Mercedes" );
            //Console.WriteLine(c2);

            //Car c3 = new Car( 30 );
            //Console.WriteLine(c3);

            #endregion


            #region Inheritance

            /*
             * Inheritance :-
             *      - one of pillar of OOP
             *      - avoid code duplication
             *      
             *      
             * C# support 3 Categories of inheritance
             *      1. Single Inheritance
             *          - Class inherits from one base class
             *      2. mulitLevel inheritance
             *          - Class inherits from one base class and that base class inherits from another base class
             *      3. Hierarchical Inheritance
             *          - multiple classes inherit from only one base class
             *          
             *          
             *      * C# does not Allow multiple inheritance
             */

            //Parent p1 = new Parent( 10 , 20 );
            //Console.WriteLine(p1);


            //Console.WriteLine(p1.Multiply());
            //p1.MyFunc();
            //Console.WriteLine("=============");

            //Child c1 = new Child( 1 , 2 , 3 );
            //Console.WriteLine(c1);
            //Console.WriteLine(c1.Multiply());
            //c1.MyFunc();
            #endregion

            #region access modifiers

            TypeA
            #endregion

        }
    }
}
