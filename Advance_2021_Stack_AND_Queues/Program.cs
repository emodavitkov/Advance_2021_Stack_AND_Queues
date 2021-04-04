using System;
using System.Collections.Generic;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> strinngReverse = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                strinngReverse.Push(input[i]);
            }

            while (strinngReverse.Count > 0)
            {
                Console.Write(strinngReverse.Pop());
            }
            
            Console.WriteLine();
            
            //foreach (var item in strinngReverse)
            //{
            //    Console.Write(item);

            //}
        }
    }
}
