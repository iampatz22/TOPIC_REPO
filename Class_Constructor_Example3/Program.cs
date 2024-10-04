using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Constructor_Example3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mouse mouse1 = new Mouse();
            Mouse mouse2 = new Mouse(10, "Sam");
        }
    }

    class Mouse
    {
        public Mouse() : this(-1, "")
        {
            // Uses constructor initializer.
        }

        public Mouse(int weight, string name)
        {
            // Constructor implementation.
            Console.WriteLine("Constructor weight = {0}, name = {1}",
                weight,
                name);
        }
    }
}
