using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Public_Example
{
    public class Example
    {
        static int _fieldStatic = 1; //Private Static field
        int _fieldInstance = 2; //Private instance field

        public static void DoStatic()
        {
            //public static method body
            Console.WriteLine("DoAll called");
        }

        public static int SelectStatic()
        {
            //public static method bidy with return value.
            return _fieldStatic * 2;
        }

        public void DoInstance()
        {
            //public instance method body.
            Console.WriteLine("SelectAll called");
        }

        public int SelectInstance() 
        {
            //public instance method body with return value.
            return _fieldInstance * 2;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //First run the public static method on the type.
            Example.DoStatic();
            Console.WriteLine(Example.SelectStatic());

            //Instantiate the type as an instance.
            //...then invoke the public instance methods
            Example example = new Example();
            example.DoInstance();
            Console.WriteLine(example.SelectInstance());
        }
    }
}
