using System;
using System.Collections.Generic;
using System.Linq;

namespace TheFightForGondor
{
    class Program
    {
        static void Main(string[] args)
        {
            int wavesOfOrcs = int.Parse(Console.ReadLine());

            Queue<int> plates = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Stack<int> orcs = new Stack<int>();

            int currPlateStrength = 0;
            int currOrcStrength = 0;
            bool defeat = false;

            for (int i = 1; i <= wavesOfOrcs; i++)
            {
                orcs = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());

                if (i % 3 == 0)
                {
                    plates.Enqueue(int.Parse(Console.ReadLine()));
                }

                while (plates.Count > 0 && orcs.Count > 0)
                {
                    if (currOrcStrength == 0)
                    {
                        currOrcStrength = orcs.Peek();
                    }

                    if (currPlateStrength == 0)
                    {
                        currPlateStrength = plates.Peek();
                    }

                    if (currOrcStrength > currPlateStrength)
                    {
                        currOrcStrength -= currPlateStrength;
                        plates.Dequeue();
                        currPlateStrength = 0;
                    }
                    else if (currOrcStrength < currPlateStrength)
                    {
                        currPlateStrength -= currOrcStrength;
                        orcs.Pop();
                        currOrcStrength = 0;
                    }
                    else
                    {
                        currPlateStrength = 0;
                        currOrcStrength = 0;

                        plates.Dequeue();
                        orcs.Pop();
                    }
                }

                if (plates.Count == 0)
                {
                    defeat = true;
                    break;
                }
            }

            List<int> result = new List<int>();

            if (defeat)
            {
                if (currOrcStrength != 0)
                {
                    orcs.Pop();
                    result.Add(currOrcStrength);
                }

                while (orcs.Count > 0)
                {
                    result.Add(orcs.Pop());
                }

                Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
                Console.Write($"Orcs left: ");
                Console.WriteLine(string.Join(", ", result));
            }
            else
            {
                if (currPlateStrength != 0)
                {
                    plates.Dequeue();
                    result.Add(currPlateStrength);
                }

                while (plates.Count > 0)
                {
                    result.Add(plates.Dequeue());
                }

                Console.WriteLine("The people successfully repulsed the orc's attack.");
                Console.Write($"Plates left: ");
                Console.WriteLine(string.Join(", ", result));
            }
        }
    }
}