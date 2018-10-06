using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSAdv
{
    class valrefout
    {

        static void Addvalue(int val)
        {
            val++;
        }

        static void Main(string[] args)
        {
            int value = 10;
            Addvalue(value);
            Console.WriteLine(value);
            Console.Read();
        }
        static void passvalue(out int val)
        {
            val = 20;
        }
        //static void Main(string[] args)
        //{
        //    int value;
        //    passvalue(out value);
        //    Console.WriteLine(value);
        //    Console.Read();
        //}

        //static void passvalue(ref int val)
        //{
        //    val = 20;
        //}
        //static void Main(string[] args)
        //{
        //    int value = 10;
        //    passvalue(ref value);
        //    Console.WriteLine(value);
        //    Console.Read();
        //}

       /* static void passvalue(out int i, out string s1, out string s2)
        {
            i = 20;
            s1 = "I've been returned";
            s2 = null;

        }

        static void Main(string[] args)
        {
            int v;
            string str1, str2;
            passvalue(out v, out str1, out str2);
            Console.WriteLine(v + " " + str1 + " " + str2);
            Console.Read();
        
        }
        */
    }
}
