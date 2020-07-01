//Emilia Lebiedowska 242473
using System;
using System.Linq;
using static System.Console;

namespace List8ad1
{
    /// <summary>   A test class. </summary>
    ///
    /// <remarks>   Emila, 05.12.2019. </remarks>

    class Test
    {
        /// <summary>   Main entry-point for this application. Menu which operates operations on fractions. </summary>
        ///
        /// <remarks>   Emila, 05.12.2019. </remarks>
        ///
        /// <param name="args"> An array of command-line argument strings. </param>

        static void Main(string[] args)
        {
            string[] validOperations = { "1", "2", "3", "4"};
            while (true)
            {
                Write("MENU:\n 1. Dodawanie \n 2. Odejmowanie \n 3. Mnożenie \n 4. Dzielenie \n") ;
                string operation = ReadLine().Trim();

                if (validOperations.Contains(operation))
                {
                    try
                    {
                        Write("Podaj a: ");
                        Fraction a = Fraction.Parse(ReadLine());

                        Write("Podaj b: ");
                        Fraction b = Fraction.Parse(ReadLine());

                        switch (operation)
                        {
                            case "1":
                                Fraction res1 = new Fraction();
                                res1 = a + b;
                                res1.PrintProper();
                                break;
                            case "2":
                                Fraction res2 = new Fraction();
                                res2 = a - b;
                                res2.PrintProper();
                     
                                break;
                            case "3":
                                Fraction res3 = new Fraction();
                                res3 = a * b;
                                res3.PrintProper();
                                break;
                            case "4":
                                Fraction res4 = new Fraction();
                                res4 = a / b;
                                res4.PrintProper();
                                break;
                            default:
                                WriteLine("Błąd");
                                break;
                        }
                    }
                    catch (Exception e)
                    {
                        WriteLine("Błąd: " + e.Message);
                    }
                }
                else
                {
                    WriteLine("Błąd. Niepoprawna operacja");
                }
            }
        }
    }
}
