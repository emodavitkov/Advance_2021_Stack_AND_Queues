using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrInput = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToArray();
           
            Stack<string> stackRepository = new Stack<string>(arrInput);

            while (stackRepository.Count>1)
            {
                int firstDigit = int.Parse(stackRepository.Pop());
                string operand = stackRepository.Pop();
                int secondDigit = int.Parse(stackRepository.Pop());
                int thirdDigit = 0;
                switch (operand)
                {
                    case "+":
                        thirdDigit = firstDigit + secondDigit;
                        break;

                    case "-":
                        thirdDigit = firstDigit - secondDigit;
                        break;

                    default:
                        break;
                }

                stackRepository.Push(thirdDigit.ToString());
            }

            Console.WriteLine(stackRepository.Pop());
        }
    }
}
