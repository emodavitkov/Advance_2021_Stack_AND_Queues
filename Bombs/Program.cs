using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace Bombs
{
    public class Program
    {
        static void Main()
        {

            Queue<int> bombEffects = new Queue<int>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList());

            Stack<int> bombCasings = new Stack<int>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList());



            int daturaBombs = 0;
            int cherryBombs = 0;
            int smokeDecoyBombs = 0;

            while (bombEffects.Count > 0 && bombCasings.Count > 0)
            {
                int effect = bombEffects.Dequeue();
                int casing = bombCasings.Pop();

                int sum = effect + casing;

                if (sum == 40)
                {
                    daturaBombs++;

                    if (daturaBombs >= 3 && cherryBombs >= 3 && smokeDecoyBombs >= 3)
                    {

                        break;
                    }

                    continue;
                }

                else if (sum == 60)
                {
                    cherryBombs++;

                    if (daturaBombs >= 3 && cherryBombs >= 3 && smokeDecoyBombs >= 3)
                    {

                        break;
                    }

                    continue;
                }
                else if (sum == 120)
                {
                    smokeDecoyBombs++;

                    if (daturaBombs >= 3 && cherryBombs >= 3 && smokeDecoyBombs >= 3)
                    {
                        break;
                    }

                    continue;
                }

                else
                {
                    while (true)
                    {
                        effect -= 5;
                        sum = effect + casing;

                        if (sum == 40)
                        {
                            daturaBombs++;

                            if (daturaBombs >= 3 && cherryBombs >= 3 && smokeDecoyBombs >= 3)
                            {

                                break;
                            }

                            break;
                        }

                        else if (sum == 60)
                        {
                            cherryBombs++;

                            if (daturaBombs >= 3 && cherryBombs >= 3 && smokeDecoyBombs >= 3)
                            {
                                break;
                            }

                            break;
                        }
                        else if (sum == 120)
                        {
                            smokeDecoyBombs++;

                            if (daturaBombs >= 3 && cherryBombs >= 3 && smokeDecoyBombs >= 3)
                            {
                                break;
                            }

                            break;
                        }

                    }
                }



            }

            if (daturaBombs >= 3 && cherryBombs >= 3 && smokeDecoyBombs >= 3)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            if (bombEffects.Count == 0)
            {
                Console.WriteLine("Bomb Effects: empty");
            }

            else
            {

                Console.WriteLine("Bomb Effects: " + string.Join(", ", bombEffects));
            }


            if (bombCasings.Count == 0)
            {
                Console.WriteLine("Bomb Casings: empty");
            }

            else
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", bombCasings)}");
            }

            Console.WriteLine($"Cherry Bombs: {cherryBombs}");
            Console.WriteLine($"Datura Bombs: {daturaBombs}");
            Console.WriteLine($"Smoke Decoy Bombs: {smokeDecoyBombs}");

        }


    }

}
