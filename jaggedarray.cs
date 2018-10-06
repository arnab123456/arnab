using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chapter2
{
    class jaggedarray
    {
        static void Main()
        {

            string[][] jagged = new string[2][];
            jagged[0] = new string[5] { "VB", "C++", "C#", "J#","F#" };
            jagged[1] = new string[] { "Java", "Struts", "Hibernate", "Springs" };
            foreach (string[] arr1 in jagged)
            {
                Console.WriteLine("The Course Modules are:");
                foreach (string s in arr1)
                    Console.WriteLine("\t " + s);
               
                Console.WriteLine();
          }
            //using for

            for (int i = 0; i < jagged.Length; i++)
            {
                Console.WriteLine("The Course Modules are[using For] :");
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.WriteLine("\t " + jagged[i][j]);
                }
            }
            Console.ReadLine();

        }

    }
}
