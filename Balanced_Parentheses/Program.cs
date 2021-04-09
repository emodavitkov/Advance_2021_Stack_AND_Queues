using System;
using System.Collections.Generic;

namespace BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            const string openParentheses = "([{";
            const string closedParentheses = ")]}";
            bool isBalanced = true;

            string input = Console.ReadLine();

            Stack<char> parentheses = new Stack<char>();
            
            for (int i = 0; i < input.Length; i++)
            {
                if (openParentheses.Contains(input[i]))
                {
                    parentheses.Push(input[i]);
                }
                else //if closedParentheses
                {
                    if (parentheses.Count > 0
                        && closedParentheses.IndexOf(input[i])
                        == openParentheses.IndexOf(parentheses.Peek()))
                    {
                        parentheses.Pop();
                    }
                    else
                    {
                        isBalanced = false;
                        break;
                    }
                }
            }

            if (isBalanced && parentheses.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}