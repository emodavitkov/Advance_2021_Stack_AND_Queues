using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            int dequeue = commands[1];
            int numberToFind = commands[2];

            int[] elements = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                //.Reverse()
                .ToArray();
            Queue<int> numbers = new Queue<int>(elements);



            for (int i = 0; i < dequeue; i++)
            {
                numbers.Dequeue();
            }

            if (numbers.Count == 0)
            {
                Console.WriteLine("0");
                return;
            }

            if (numbers.Contains(numberToFind))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(numbers.Min());
            }

    }
    }
}
