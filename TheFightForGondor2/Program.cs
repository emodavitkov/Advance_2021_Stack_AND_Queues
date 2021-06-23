using System;
using System.Collections.Generic;
using System.Linq;

namespace TheFightForGondorVersion2
{
    public class Program
    {
        static void Main()
        {
            int wavesNumber = int.Parse(Console.ReadLine());

            Queue<int> plates = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            int newPlate = 0;
            int currentPlate = 0;
            int currentOrc = 0;

            int plate = 0;
            int orc = 0;

            Stack<int> orcs = null;


            for (int i = 1; i <= wavesNumber; i++)
            {

                orcs = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());



                if (i % 3 == 0)
                {
                    newPlate = int.Parse(Console.ReadLine());
                    plates.Enqueue(newPlate);
                }



                while (orcs.Count > 0 && plates.Count > 0)
                {
                    plate = plates.Peek();
                    orc = orcs.Peek();

                    if (plate > orc)
                    {
                        currentPlate = plate - orc;
                        plates.Dequeue();
                        List<int> temp = plates.ToList();
                        temp.Insert(0, currentPlate);
                        plates = new Queue<int>(temp);
                        orcs.Pop();
                    }

                    else if (plate == orc)
                    {
                        orcs.Pop();
                        plates.Dequeue();
                    }

                    else if (orc > plate)
                    {
                        plates.Dequeue();
                        currentOrc = orc - plate;
                        orcs.Pop();
                        orcs.Push(currentOrc);
                    }

                }

                if (plates.Count == 0)
                {

                    break;
                }



            }

            if (plates.Count != 0)
            {
                Console.WriteLine("The people successfully repulsed the orc's attack.");
            }
            else
            {
                Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
            }

            if (orcs.Count != 0)
            {
                Console.WriteLine($"Orcs left: {string.Join(", ", orcs)}");
            }

            if (plates.Count != 0)
            {
                Console.WriteLine($"Plates left: {string.Join(", ", plates)}");
            }


        }
    }
}
