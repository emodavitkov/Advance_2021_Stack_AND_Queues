using System;
using System.Collections.Generic;
using System.Linq;

namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] children = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());

            Queue<string> potatoQueue = new Queue<string>(children);
            int potatoTosses = 0;

            while (potatoQueue.Count>1)
            {
                //Console.WriteLine(String.Join(" ",potatoQueue.ToArray()));
                //Console.WriteLine(potatoTosses);
                potatoTosses++;
                string kid = potatoQueue.Dequeue();

                if (potatoTosses==n)
                {
                    potatoTosses = 0;
                    Console.WriteLine("Removed " + kid);
                }
                else
                {
                    potatoQueue.Enqueue(kid);
                }

                //infinite loop 
                //string kid = potatoQueue.Dequeue();
                //Console.WriteLine(kid);
                //potatoQueue.Enqueue(kid);
            }

            Console.WriteLine("Last is " + potatoQueue.Dequeue());
        }
        
    }
}
