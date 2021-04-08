using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> clothes = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int capacityOfRacks = int.Parse(Console.ReadLine());
            int racks = 0;
            while (clothes.Count > 0)
            {
                racks++;
                int currRackCapacity = capacityOfRacks;
                while (clothes.Count > 0)
                {
                    if (clothes.Peek() <= currRackCapacity)
                    {
                        currRackCapacity -= clothes.Pop();
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(racks);
        }
    }
}