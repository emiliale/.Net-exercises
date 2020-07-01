//Emilia Lebiedowska 242473
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System;

namespace List7ad1
{
    /// <summary>   A test class. A class which include main and is using for testing AnalizatorONP.   </summary>
    ///
    /// <remarks>   Emila, 23.11.2019. </remarks>

    class Test
    {
        /// <summary>
        /// Main entry-point for this application. Runs AnalizatorONP functions
        ///  and calculates the expression written in Reverse Polish notation.
        /// </summary>
        ///
        /// <remarks>   Emila, 23.11.2019. </remarks>
        ///
        /// <param name="args"> An array of command-line argument strings. </param>

        static void Main(string[] args)
        {
            AnalizatorONP test = new AnalizatorONP();
            bool repeat = true;
            int result;

            while (repeat)
            {
                repeat = false;
                if (test.GetFromUser() == true)
                {
                    foreach (char i in test.GetStatement())
                    {
                        if (Char.IsDigit(i))
                        {
                            test.Number(i);
                        }
                        else
                        {
                            switch (i)
                            {
                                case '+':
                                    if (test.Add() == false)
                                    {
                                        repeat = true;
                                        break;
                                    }
                                    break;
                                case '-':
                                    if (test.Sub() == false)
                                    {
                                        repeat = true;
                                        break;
                                    }
                                    break;

                                case '*':
                                    if(test.Mult() == false)
                                    {
                                        repeat = true;
                                        break;
                                    }
                                    break;
                                case '/':
                                    if (test.Div() == false)
                                    {
                                        repeat = true;
                                        break;
                                    }
                                    break;
                                case '=':
                                    WriteLine(test.Eql());
                                    repeat = true;
                                    break;
                                default:
                                    WriteLine("Błąd wyrażenia\n");
                                    repeat = true;
                                    break;
                            }
                        }
                    }

                }
                else
                {
                    WriteLine("Błędne wyrażenie\n");
                    repeat = true;
                }


            }

        }
    }
}
