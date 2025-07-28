//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Demo
//{
//    internal class Child : Parent
//    {

//        #region properties


//        public int Z { get; set; }

//        #endregion

//        #region constructor

//        public Child(int _x, int _y, int _z):base(_x, _y)
//        {
//            Z = _z;
//        }

//        #endregion

//        #region methods

//        public override string ToString()
//        {
//            return $"X = {X} , Y = {Y} , Z = {Z}";
//        }

//        public override int Multiply()
//        {
//            return base.Multiply() * Z;
//        }

//        public new void MyFunc()
//        {
//            Console.WriteLine("Child Class");
//        }



//        #endregion 
//    }
//}
