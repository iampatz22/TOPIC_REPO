using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLass_Destructor_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Example x = new Example();
        }
    }

    class Example
    {
        public Example()
        {
            Console.WriteLine("Constructor");
        }

        ~Example()
        {
            Console.WriteLine("Destructor");
        }
    }
}
