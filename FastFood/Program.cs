using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> ordersQueue = new Queue<int>(orders);

            int deltaFood = 0;
            bool allServered = true;

            if (orders.Length > 0)
            {
                Console.WriteLine(orders.Max());
            }

            for (int i = 0; i < orders.Length; i++)
            {
                deltaFood = foodQuantity - orders[i];

                if (deltaFood>=0)
                {
                    ordersQueue.Dequeue();
                    foodQuantity -= orders[i];

                }

                if (deltaFood<0)
                {
                    allServered = false;
                    break;
                }
               
            }

            if (allServered)
            {
                Console.WriteLine("Orders complete");
            }

            else
            {
                Console.WriteLine("Orders left: " + string.Join(" ",ordersQueue));
            }
            

        }
    }
}
