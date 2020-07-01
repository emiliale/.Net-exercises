//Emilia Lebiedowska 242473
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System;

namespace List6ad4
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            bool repeat=true;
            int result;

           
                while (repeat)
                {

                try
                {
                    repeat = false;
                    Write("Wpisz wyrażenie: ");

                    char[] statement = ReadLine().ToCharArray().Where(c => !char.IsWhiteSpace(c)).ToArray();

                    foreach (char i in statement)
                    {
                        if (Char.IsDigit(i))
                        {
                            stack.Push(int.Parse(i.ToString()));
                        }
                        else
                        {
                            switch (i)
                            {
                                case '+':
                                    int b = stack.Pop();
                                    int a = stack.Pop();
                                    stack.Push(a + b);
                                    break;
                                case '-':
                                    int b1 = stack.Pop();
                                    int a1 = stack.Pop();
                                    stack.Push(a1 - b1);
                                    break;
                                case '*':
                                    int b2 = stack.Pop();
                                    int a2 = stack.Pop();
                                    stack.Push(a2 * b2);
                                    break;
                                case '/':
                                    int b3 = stack.Pop();
                                    int a3 = stack.Pop();
                                    if (b3 != 0)
                                    {
                                        stack.Push(a3 / b3);
                                    }
                                    else
                                    {
                                        WriteLine("Nie można dzielić przez 0!");
                                        stack.Clear();
                                        repeat = true;
                                    }
                                    break;
                                case '=':
                                    result = stack.Pop();
                                    WriteLine(result);
                                    stack.Clear();
                                    repeat = true;
                                    break;
                                default:
                                    throw new InvalidOperationException("Błąd wyrażenia\n");
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    WriteLine("Błąd!\n");
                    repeat = true;
                }
            }                
        }
    }
}
