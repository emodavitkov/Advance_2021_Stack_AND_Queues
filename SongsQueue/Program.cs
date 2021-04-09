using System;
using System.Collections.Generic;
using System.Linq;

namespace SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue<string> songsQueue = new Queue<string>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries));

            while (songsQueue.Count > 0)
            {

                string commands = Console.ReadLine();

               
                switch (commands)
                {
                    case "Play":
                        songsQueue.Dequeue();
                        break;

                   

                    case "Show":
                        Console.WriteLine(string.Join(", ",songsQueue));
                        break;

                    default:

                       
                        string addSond = commands.Substring(4, commands.Length-4);
                        if (!songsQueue.Contains(addSond))
                        {
                            songsQueue.Enqueue(addSond);
                        }
                        else
                        {
                            Console.WriteLine($"{addSond} is already contained!");
                        }

                        break;
                }


            }
            Console.WriteLine("No more songs!");
        }
    }
}
