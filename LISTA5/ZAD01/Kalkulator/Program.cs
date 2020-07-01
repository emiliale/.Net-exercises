// Emilia Lebiedowska 242473
using System;
using static System.Text.Encoding;
using static System.Console;
using System.Numerics;

namespace Kalkulator
{
    /// <summary>   A calculator program. </summary>
    ///
    /// <remarks>   Emila, 16.11.2019. </remarks>

    class Program
    {
        /// <summary>
        /// Main entry-point for this application. Provides a menu with calculator functions.
        /// </summary>
        ///
        /// <remarks>   Emila, 16.11.2019. </remarks>
        ///
        /// <param name="args"> An array of command-line argument strings. </param>

        static void Main(string[] args)
        {
            int menu = 0;

            while (menu != 7) {


                WriteLine("\nMenu\n 1. Dodawanie\n 2. Odejmowanie\n 3. Mnożenie\n 4. Dzielenie\n 5. Reszta z dzielenia\n 6. Potęga\n 7. Zakończ\n");

                try
                {
                    menu = int.Parse(ReadLine());
                }
                catch(Exception e)
                {
                    Error.WriteLine("Zły format\n" + e.ToString());
                }

                Kalk k = new Kalk();


                switch (menu)
                {
                    case 1:
                        WriteLine("Wpisz a: ");
                        BigInteger a = ReadNumber();
                        WriteLine("Wpisz b: ");
                        BigInteger b = ReadNumber();
                        WriteLine($"\n{a} + {b} = {k.Add(a, b)}");
                        break;
                    case 2:
                        WriteLine("Wpisz a: ");
                        a = ReadNumber();
                        WriteLine("Wpisz b: ");
                        b = ReadNumber();
                        WriteLine($"\n{a} - {b} = {k.Sub(a, b)}");
                        break;
                    case 3:
                        WriteLine("Wpisz a: ");
                        a = ReadNumber();
                        WriteLine("Wpisz b: ");
                        b = ReadNumber();
                        WriteLine($"\n{a} * {b} = {k.Mul(a, b)}");
                        break;
                    case 4:
                        WriteLine("Wpisz a: ");
                        a = ReadNumber();
                        WriteLine("Wpisz b: ");
                        b = ReadNumber();
                        if(b==0)
                        {
                            WriteLine("Nie można dzielić przez 0!");
                        }
                        else
                        {
                            WriteLine($"\n{a} / {b} = {k.Div(a, b)}");
                        }                        
                        break;
                    case 5:
                        WriteLine("Wpisz a: ");
                        a = ReadNumber();
                        WriteLine("Wpisz b: ");
                        b = ReadNumber();
                        WriteLine($"\n{a} % {b} = {k.Rem(a, b)}");
                        break;
                    case 6:
                        WriteLine("Wpisz a: ");
                        a = ReadNumber();
                        WriteLine("Wpisz b: ");
                        b = ReadNumber();
                        WriteLine($"\n{a} ^ {b} = {k.Pow(a, b)}");
                        break;
                    case 7:
                        WriteLine("Koniec");
                        break;
                    default:
                        Console.WriteLine("Wybierz liczbę dostępną w menu");
                        break;
                }                
            }
         }

        /// <summary>   Reads the number from user. </summary>
        ///
        /// <remarks>   Emila, 16.11.2019. </remarks>
        ///
        /// <returns>   The number. </returns>

        static public BigInteger ReadNumber()
        {
            BigInteger x = 0;

            try
            {
                x = BigInteger.Parse(ReadLine());
             }
            catch (OverflowException oe)
            {
                Error.WriteLine("Arytmetyczny nadmiar!\n" + oe.StackTrace + "\n");
            }
            catch (FormatException fe)
            {
                Error.WriteLine("Niepoprawny format" + fe.StackTrace + "\n");
            }
            catch (Exception e)
            {
                Error.WriteLine("Nieoczekiwany wyjątek\n" + e.ToString());
            }

            return x;
        }

        /// <summary>   A kalkulator class. </summary>
        ///
        /// <remarks>   Emila, 16.11.2019. </remarks>

        public  class Kalk
        {
            /// <summary>   Adds x and y. </summary>
            ///
            /// <remarks>   Emila, 16.11.2019. </remarks>
            ///
            /// <param name="x">    A BigInteger to process. </param>
            /// <param name="y">    A BigInteger to process. </param>
            ///
            /// <returns>   A BigInteger. </returns>

            public BigInteger Add(BigInteger x, BigInteger y) => x + y;

            /// <summary>   Subtracts x and y. </summary>
            ///
            /// <remarks>   Emila, 16.11.2019. </remarks>
            ///
            /// <param name="x">    A BigInteger to process. </param>
            /// <param name="y">    A BigInteger to process. </param>
            ///
            /// <returns>   A BigInteger. </returns>

            public BigInteger Sub(BigInteger x, BigInteger y) => x - y;

            /// <summary>   Multiplies x and y </summary>
            ///
            /// <remarks>   Emila, 16.11.2019. </remarks>
            ///
            /// <param name="x">    A BigInteger to process. </param>
            /// <param name="y">    A BigInteger to process. </param>
            ///
            /// <returns>   A BigInteger. </returns>

            public BigInteger Mul(BigInteger x, BigInteger y) => x * y;

            /// <summary>   Divides x and y. </summary>
            ///
            /// <remarks>   Emila, 16.11.2019. </remarks>
            ///
            /// <param name="x">    A BigInteger to process. </param>
            /// <param name="y">    A BigInteger to process. </param>
            ///
            /// <returns>   A BigInteger. </returns>

            public BigInteger Div(BigInteger x, BigInteger y) => x / y;

            /// <summary>   Returns the remainder of x and y. </summary>
            ///
            /// <remarks>   Emila, 16.11.2019. </remarks>
            ///
            /// <param name="x">    A BigInteger to process. </param>
            /// <param name="y">    A BigInteger to process. </param>
            ///
            /// <returns>   A BigInteger. </returns>

            public BigInteger Rem(BigInteger x, BigInteger y) => x % y;

            /// <summary>   Raises x to the power of y. </summary>
            ///
            /// <remarks>   Emila, 16.11.2019. </remarks>
            ///
            /// <param name="x">    A BigInteger to process. </param>
            /// <param name="y">    A BigInteger to process. </param>
            ///
            /// <returns>   A BigInteger. </returns>

            public BigInteger Pow(BigInteger x, BigInteger y)
            {
                BigInteger tmp = 1;
                for (int i = 0; i < y; i++)
                    tmp *= x;
                return tmp;
            }

        }
                   
    }

// End of Program.cs.
}

    
