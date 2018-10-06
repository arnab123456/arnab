using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSAdv
{
    class genericcollection
    {

         


        static void Main(string[] args)
        {

            List<int> list = new List<int>();

            list.Add(1);
            list.Add(2);
            list.Add(9);

            foreach (int numbers in list) 
            {
                Console.WriteLine(numbers);
            }

            Console.WriteLine("Count -> {0}",list.Count); 
            Console.WriteLine("\n-------------------------------------------\n");

            List<bool> list1 = new List<bool>();

            list1.Add(false);
            list1.Add(true);
            list1.Add(true);
            list1.Add(false);

            foreach (bool booleans in list1)
            {
                Console.WriteLine(booleans);
            }

            Console.WriteLine("Count -> {0}", list1.Count); 
            Console.WriteLine("\n-------------------------------------------\n");

            List<string> list2 = new List<string>();

            list2.Add("Khadak");
            list2.Add("Shiv");
            list2.Add("Shaam");
            list2.Add("Pradeep Dhuri");

            foreach (string stringnames in list2)
            {
                Console.WriteLine(stringnames);
            }

            Console.WriteLine("Count -> {0}", list2.Count); 

            Console.WriteLine("\n-------------------------------------------\n");
        }
    }
}

   