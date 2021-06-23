using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace WarmWinter
{
    class Program
    {
        static void Main()
        {

            Stack<int> hats = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            Queue<int> scarfs = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            List<int> sets = new List<int>(); 

            int hat = 0;
            int scarf =0;
            int set = 0;
            int hatIncrement = 0;

            while (scarfs.Count>0 && hats.Count>0)
            {

                hat = hats.Peek() + hatIncrement;
                scarf = scarfs.Peek();
                
                if (hat > scarf)
                {
                    set = hat + scarf;

                    sets.Add(set);
                    hats.Pop();
                    scarfs.Dequeue();
                    hatIncrement = 0;
                }

                else if (hat == scarf)
                {
                    hatIncrement++;
                    scarfs.Dequeue();
                }

                else if (scarf > hat)
                {
                    hats.Pop();
                    hatIncrement = 0;
                }
            }

            int mostExpensive = sets.Max();

            Console.WriteLine($"The most expensive set is: {mostExpensive}");
            Console.WriteLine(string.Join(" ", sets));

        }
    }
}
