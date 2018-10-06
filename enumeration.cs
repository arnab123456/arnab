using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chapter2
{
    public enum color { red = 1, green, yellow }
    class enumeration
    {
        static void Main()
        {
            Console.WriteLine("Please select 1 for red,2 for green and 3 for yellow");
            //string str = ;
            int conint = Int32.Parse(Console.ReadLine());
           // int conint = Convert.ToInt32(Console.ReadLine());
            color col = (color)conint;//casting
            switch (col)
            {
                case color.red:
                    Console.WriteLine("The selected color is Red");
                    break;
                case color.green:
                    Console.WriteLine("The selected color is Green");
                    break;
                case color.yellow:
                    Console.WriteLine("The selected color is Yellow");

                    break;
                default:
                    Console.WriteLine("this number is not assigned to any color");
                    break;
            }
            Console.ReadLine();
        }
    }
}
