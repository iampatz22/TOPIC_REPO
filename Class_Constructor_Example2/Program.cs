using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Constructor_Example2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parrot parrot = new Parrot(450);
            Console.WriteLine(":::DONE:::");
        }
    }

    public class Bird
    {
        public Bird(int value)
        {
            Console.WriteLine($"Bird() called with {value}");
        }
    }

    public class Parrot : Bird
    {
        public Parrot(int value) : base(value)
        {
            Console.WriteLine($"Parrot called with {value}");
        }
    }
}
