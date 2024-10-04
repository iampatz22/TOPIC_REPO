using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Property_Example
{
    class Example
    {
        /*
         Number is an int property in the Example class. Number provides get and set implementations.
         
         The get implementation must include a return statement. It can access any member on the class.
         
        The set implementation receives the implicit argument "value." This is the value to which the property is assigned
         */
        int _number;
        public int Number
        {
            get
            {
                return this._number;
            }
            set
            {
                this._number = value;
            }
        }
    }

    class Sample
    {
        /*
         We see automatically implemented property syntax in C#. A hidden field is generated—then the get and set statements are expanded to use that hidden field.
         */
        public int Number
        {
            get;
            set;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Example example = new Example();
            example.Number = 5; // set { }
            Console.WriteLine(example.Number); // get { }
        }
    }
}
