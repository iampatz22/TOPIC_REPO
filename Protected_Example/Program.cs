using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
        }
    }

    class A
    {
        protected int _a;
        private int _b;
    }

    class B : A
    {
        public B()
        {
            // Can access protected int but not private int!
            Console.WriteLine(this._a);
        }
    }
}
