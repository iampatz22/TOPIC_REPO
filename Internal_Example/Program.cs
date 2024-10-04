using Internal_Example_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Can access the internal type in this program.
            Test test = new Test();
            test._a = 1;

            Sample sample = new Sample();
        }
    }

    // Example of internal type.
    internal class Test
    {
        public int _a;
    }

}

namespace Internal_Example_2
{
    internal class Sample
    {
        public int _b;
    }
}

