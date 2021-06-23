using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace Scheduling
{
    public class Program
    {
        static void Main()
        {
            Stack<int> tasks = new Stack<int>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            Queue<int> threads = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            int taskToKill = int.Parse(Console.ReadLine());


            int task = 0;
            int thread = 0;

            while (task!=taskToKill)
            {

                if (task==taskToKill)
                {
                    break;
                }
                task = tasks.Peek();
                thread = threads.Peek();

                if (task > thread)
                {
                    threads.Dequeue();
                }
                else if (thread >= task)
                {
                    threads.Dequeue();
                    tasks.Pop();
                }

                task = tasks.Peek();
                thread = threads.Peek();
            }

            Console.WriteLine($"Thread with value {thread} killed task {taskToKill}");
            Console.WriteLine(string.Join(" ",threads));

        }
    }
}
