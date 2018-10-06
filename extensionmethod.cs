using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPS1
{
    public static class myclass
    {


        public static int myextent(this float number1)
        {
            return (int)number1;

           // return Int32.Parse(number1);
        }
        public static int myextensionmethod(this string number)
        {
            return Int32.Parse(number);
        }

        public static string CalculateArea(this int r)
        {
            float area = System.Math.PI * r * r;
            return "The area of circle is " + area;
        
        }
    }
    class extensionmethod
    {
        static void Main(string[] args)
        {
            string number1 = "100";

            int ext = number1.myextensionmethod();
           float wt = 52.35f;
           int wgt = wt.myextent();
            Console.WriteLine("The output from Myextensionmethod()");
           Console.WriteLine(ext);
           Console.WriteLine("The output from Myextent()");
           Console.WriteLine(wgt);
           int total = 100;//+ number;//.myextensionmethod ();
           Console.WriteLine(total );
            Console.Write("\n Press Enter to Quit....");
            Console.ReadLine();


            Console.WriteLine("Enter Radius");
            int rad = Int32.Parse(Console.ReadLine());
            Console.WriteLine(rad.)


        }
    }
}
