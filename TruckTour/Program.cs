using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int[]> pomps = new Queue<int[]>();
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                int[] currPomp = Console.ReadLine().Split().Select(int.Parse).ToArray();
                pomps.Enqueue(currPomp);
            }
            int start = 0;
            int petrol = 0;
            int distance = 0;
            int count = 0;
            while (count != number)
            {
                Queue<int[]> pompsFromCurrStart = new Queue<int[]>(pomps);
                for (int i = 0; i < start; i++)
                {
                    pompsFromCurrStart.Enqueue(pompsFromCurrStart.Dequeue());
                }
                while (pompsFromCurrStart.Count > 0)
                {
                    int[] currPomp = pompsFromCurrStart.Dequeue();
                    petrol += currPomp[0];
                    distance = currPomp[1];
                    if (petrol < distance)
                    {
                        petrol = 0;
                        count = 0;
                        start++;
                        break;
                    }
                    else
                    {
                        petrol -= distance;
                        count++;
                    }
                }
            }
            Console.WriteLine(start);
        }
    }
}