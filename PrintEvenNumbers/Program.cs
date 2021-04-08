using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numbers = new Queue<int>();

            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            foreach (var item in input)
            {
                numbers.Enqueue(item);
            }

            List<int> result = new List<int>();

            while (numbers.Count>0)
            {
                if (numbers.Peek()%2==0)
                {
                    result.Add(numbers.Dequeue());
                }

                else
                {
                    numbers.Dequeue();
                }
            }


            Console.WriteLine(string.Join(", ", result));
          
               
            
        }
    }
}
