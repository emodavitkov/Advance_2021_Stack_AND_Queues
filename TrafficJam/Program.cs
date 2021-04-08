using System;
using System.Collections.Generic;
using System.Linq;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int carpassOnGreen = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            Queue<string> cars = new Queue<string>();
            int count = 0;
            while (command!="end")
            {
                if (command=="green")
                {
                    for (int i = 0; i < carpassOnGreen; i++)
                    {
                        if (cars.Count>0)
                        {
                            Console.WriteLine(cars.Dequeue() + " passed!");
                            count++;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
