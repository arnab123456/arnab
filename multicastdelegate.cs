using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSAdv
{
    public delegate void MultiDelegate(int a, int b);
    public class Sampleclass1
    {
        public static void Add(int x, int y)
        {
            Console.WriteLine("Addition Value: " + (x + y));
        }
        public static void Sub(int x, int y)
        {
            Console.WriteLine("Subtraction Value: " + (x - y));
        }
        public static void Mul(int x, int y)
        {
            Console.WriteLine("Multiply Value: " + (x * y));
        }
    }
    class Program1
    {
        static void Main(string[] args)
        {
            Sampleclass1 sc = new Sampleclass1();
            MultiDelegate del = Sampleclass1.Add;
            del += Sampleclass1.Sub;
            del += Sampleclass1.Mul;
            del(10, 5);
            Console.ReadLine();
        }
    }
}
