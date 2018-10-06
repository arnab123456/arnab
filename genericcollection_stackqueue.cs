using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSAdv
{
    class genericcollection_stackqueue
    {
        static void Main(string[] args)
        {

            //Declaring Stack
            Stack<int> stacknum = new Stack<int>();
            stacknum.Push(1);
            stacknum.Push(2);
            stacknum.Push(3);
            stacknum.Push(5);
            stacknum.Push(6);



            foreach (int numbers in stacknum)
            {
                Console.WriteLine("Stack Numbers {0}", numbers);
            }

            stacknum.Pop(); //It will remove last/recent added element from the collections i.e (6)


            Console.WriteLine("\n-------------------------------------------\n");

            //Declaring Stack
            Stack<string> stacknames = new Stack<string>();
            stacknames.Push("Pradeep Dhuri");
            stacknames.Push("Shiv Prasad");
            stacknames.Push("Khadak");
            stacknames.Push("Shaam");


            foreach (string strnames in stacknames)
            {
                Console.WriteLine("Stack Names {0}", strnames);
            }

            stacknames.Pop(); //It will remove last element/recent added element from the collections i.e. Shaam

            Console.WriteLine("\n-------------------------------------------\n");


            //Declaring Queue
            Queue<int> Queuenum = new Queue<int>();
            Queuenum.Enqueue(1);
            Queuenum.Enqueue(2);
            Queuenum.Enqueue(3);
            Queuenum.Enqueue(5);
            Queuenum.Enqueue(6);



            foreach (int numbers in Queuenum)
            {
                Console.WriteLine("Queue Numbers {0}", numbers);
            }

            Queuenum.Dequeue(); //It will remove first element from the collections i.e (1)


            Console.WriteLine("\n-------------------------------------------\n");


            //Declaring Queues
            Queue<string> Queuenames = new Queue<string>();
            Queuenames.Enqueue("Mohan Aiyer");
            Queuenames.Enqueue("Shiv Prasad");
            Queuenames.Enqueue("Khadak");
            Queuenames.Enqueue("Shaam");


            foreach (string strnames in Queuenames)
            {
                Console.WriteLine("Queue Names {0}", strnames);
            }

            Queuenum.Dequeue(); //It will remove first added element from the collections i.e Mohan Aiyer

            Console.WriteLine("\n-------------------------------------------\n");



        }
    }
}
