﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace FlowerWreaths
{
    public class Program
    {
        static void Main()
        {

            Stack<int> lilies = new Stack<int>(Console.ReadLine()
                .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            Queue<int> roses = new Queue<int>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            int wreaths = 0;
            int flowers = 0;

            while (roses.Count>0 && lilies.Count>0)
            {
                int lili = lilies.Pop();
                int rose = roses.Dequeue();
                
                int sum = lili + rose;

                if (sum==15)
                {
                    wreaths++;
                }
                else if (sum<15)
                {
                    flowers += sum;
                }

                else
                {
                    while (true)
                    {
                        sum -= 2;
                       
                        
                        if (sum == 15)
                        {
                            wreaths++;
                            break;
                        }
                        
                        else if (sum < 15)
                        {
                            flowers += sum;
                            break;
                        }
                    }
                }

                //Console.WriteLine($"{lili}-{rose}");
            }

            wreaths += flowers / 15;

            if (wreaths>=5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreaths} wreaths!");
            }

            else
            {
                Console.WriteLine($"You didn't make it, you need {5 - wreaths} wreaths more!");
            }
        }
    }
}
