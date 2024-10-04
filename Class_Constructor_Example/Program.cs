using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Constructor_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part 1: invoke constructor.
            Widget widget1 = new Widget(10);
            Widget widget2 = new Widget(20);
            Console.WriteLine("DONE");
        }
    }
    class Widget
    {
        int _size;
        public Widget(int size)
        {
            // Part 2: execute constructor logic.
            this._size = size;
        }
    }


}
