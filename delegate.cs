using System;
namespace CSAdv
{
    // this is the delegate declaration
    public delegate int DelegatSample(int a, int b);
    public class Sampleclass
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Sub(int x, int y)
        {
            return x - y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sampleclass sc = new Sampleclass();

            DelegatSample delgate1 = sc.Add;
            int i = delgate1(10, 20);
            Console.WriteLine(i);
            DelegatSample delgate2 = sc.Sub;
            int j = delgate2(20, 10);
            Console.WriteLine(j);
        }
    }
}