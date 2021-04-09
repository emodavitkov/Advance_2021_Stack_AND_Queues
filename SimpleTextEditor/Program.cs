using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> textState = new Stack<string>();

            StringBuilder text = new StringBuilder();

            int numberOfOperations = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < numberOfOperations; i++)
            {
                string command = Console.ReadLine();
                switch (command[0])
                {
                    case '1':
                        string someString = command.Split()[1];
                        text.Append(someString);
                        textState.Push(text.ToString());
                        break;
                    case '2':
                        int numOfElementsToDelete = int.Parse(command.Split()[1]);
                        if (numOfElementsToDelete <= text.Length)
                        {
                            text = text.Remove(text.Length - numOfElementsToDelete, numOfElementsToDelete);
                            textState.Push(text.ToString());
                        }
                        break;
                    case '3':
                        int index = int.Parse(command.Split()[1]) - 1;
                        Console.WriteLine(text[index]);
                        break;
                    case '4':
                        if (textState.Count > 0)
                        {
                            textState.Pop();
                            if (textState.Count > 0)
                            {
                                text = new StringBuilder(textState.Peek());
                            }
                            else
                            {
                                text.Clear();
                            }

                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}