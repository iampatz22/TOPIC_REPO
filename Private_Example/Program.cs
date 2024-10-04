using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create new instance of the Test class.
            // ... You can only call the Compute2 public instance method.
            Test test = new Test();
            Console.WriteLine(test.Compute2());
            // Call the public static method.
            // ... You cannot access the private static method.
            Console.WriteLine(Test.Compute4());
        }
    }

    class Test
    {
        private int Compute1()
        {
            return 1; // Private instance method that computes something.
        }

        public int Compute2()
        {
            return this.Compute1() + 1; // Public instance method.
        }

        private static int Compute3()
        {
            return 3; // Private static method that computes.
        }

        public static int Compute4()
        {
            return Compute3() + 1; // Public static method.
        }
    }
}
