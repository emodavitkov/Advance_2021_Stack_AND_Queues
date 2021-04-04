using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrNumbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            Stack<int> stackNumbers = new Stack<int>(arrNumbers);

            while (true)
            {
                string input = Console.ReadLine().ToLower();

                if (input == "end")
                {
                    break;
                }

                string[] commands = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = commands[0];

                switch (command)
                {
                    case "add":
                        int numberOne = int.Parse(commands[1]);
                        int numberTwo = int.Parse(commands[2]);
                        stackNumbers.Push(numberOne);
                        stackNumbers.Push(numberTwo);
                        break;

                    case "remove":
                        int countRemove = int.Parse(commands[1]);

                        if (countRemove>stackNumbers.Count)
                        {
                            continue;
                        }

                        for (int i = 0; i < countRemove; i++)
                        {
                            stackNumbers.Pop();
                        }

                        break;

                    default:
                        break;
                }
                

            }
            

            Console.WriteLine($"Sum: {stackNumbers.Sum()}");
        }
    }
}
