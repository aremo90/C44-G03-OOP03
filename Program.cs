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
        }
    }
}
