//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Demo
//{
//    class Car
//    {
//        #region attributes

//        //private int id;
//        //private string? model;
//        //private double speed;

//        #endregion

//        #region properties
//        // automatic properties

//        public int id { get; set; }
//        public string? model { get; set; }
//        public double speed { get; set; }


//        #endregion

//        #region constructors
//        public Car(int Id, string? Model, double Speed)
//        {
//            id = Id;
//            model = Model;
//            speed = Speed;
//            Console.WriteLine("1st CTOR");
//        }
//        // CTOR overloading
//        public Car(int Id, string? Model):this(Id , Model , 350)
//        {
//            //id = Id;
//            //model = Model;
//            Console.WriteLine("2nd CTOR");

//        }
//        // CTOR Chaining
//        public Car(int Id) : this(Id, "Audi" ,200)
//        {
//            Console.WriteLine("3rd CTOR");
//        }
//        #endregion

//        #region methods
//        public override string ToString()
//        {
//                return $"Car Id: {id}, Model: {model}, Speed: {speed} km/h";
//        }
//        #endregion
//    }
//}
