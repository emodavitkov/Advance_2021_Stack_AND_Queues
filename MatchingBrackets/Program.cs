using System;
using System.Collections.Generic;
using System.Linq;

namespace MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<int> bracketIndex = new Stack<int>();
            //1 + (2 - (2 + 3) * 4 / (3 + 1)) * 5
            //0123456789
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]=='(')
                {
                    bracketIndex.Push(i);
                }

                if (input[i]==')')
                {
                    int startIndex = bracketIndex.Pop();
                    Console.WriteLine(input.Substring(startIndex, i - startIndex + 1));
                }

            }
        }
    }
}
