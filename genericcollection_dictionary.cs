using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSAdv
{
    class genericcollection_dictionary
    {
        static void Main(string[] args)
        {


            Dictionary<string,int> animaldictionary = new Dictionary<string,int>();
            animaldictionary.Add("Tiger", 3);
            animaldictionary.Add("Lion", 2);
            animaldictionary.Add("Panda", 1);


            foreach (KeyValuePair<string,int> pair in animaldictionary)
            {
                Console.WriteLine("{0}, {1}", pair.Key, pair.Value);
            }

            Console.WriteLine("\n-------------------------------------------\n");

            foreach (var pair in animaldictionary)
            {
                Console.WriteLine("{0}, {1}", pair.Key, pair.Value);
            }




        }
    }
}
