using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace LootBox
{
    class Program
    {
        static void Main()
        {

            Queue<int> lootBoxOne = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList());

            Stack<int> lootBoxTwo = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList());

            int sum = 0;
            int itemBoxOne = 0;
            int itemBoxTwo = 0;
            List<int> claimedItems = new List<int>();

            while (lootBoxOne.Count>0 && lootBoxTwo.Count>0)
            {
                itemBoxOne = lootBoxOne.Peek();
                itemBoxTwo = lootBoxTwo.Peek();

                sum = itemBoxTwo + itemBoxOne;
                

                if (sum%2==0)
                {
                    claimedItems.Add(sum);
                    lootBoxOne.Dequeue();
                    lootBoxTwo.Pop();

                }

                else
                {
                    lootBoxOne.Enqueue(lootBoxTwo.Pop());
                }

            }

            int claimedItemsSum = claimedItems.Sum();

            if (lootBoxOne.Count==0)
            {
                Console.WriteLine("First lootbox is empty");
            }

            if (lootBoxTwo.Count==0)
            {
                Console.WriteLine("Second lootbox is empty");
            }

            if (claimedItemsSum>=100)
            {
                Console.WriteLine($"Your loot was epic! Value: {claimedItemsSum}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {claimedItemsSum}");
            }
        }
    }
}
