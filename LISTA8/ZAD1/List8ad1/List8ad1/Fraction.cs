using System;
using static System.Console;

namespace List8ad1
{
    /// <summary>   A fraction. </summary>
    ///
    /// <remarks>   Emila, 05.12.2019. </remarks>

    public struct Fraction
    {
        private int Numerator;
        private int Denominator;

        /// <summary>   Gets the numerator. </summary>
        ///
        /// <remarks>   Emila, 05.12.2019. </remarks>
        ///
        /// <returns>   The numerator. </returns>

        public int GetNumerator()
        {
            return Numerator;
        }

        /// <summary>   Gets the denominator. </summary>
        ///
        /// <remarks>   Emila, 05.12.2019. </remarks>
        ///
        /// <returns>   The denominator. </returns>

        public int GetDenominator() 
        {
            return Denominator;
        }

        /// <summary>   Sets a numerator. </summary>
        ///
        /// <remarks>   Emila, 05.12.2019. </remarks>
        ///
        /// <param name="numerator">    The numerator. </param>

        public void SetNumerator(int numerator)
        {
            Numerator = numerator;
        }

        /// <summary>   Sets a denominator. </summary>
        ///
        /// <remarks>   Emila, 05.12.2019. </remarks>
        ///
        /// <param name="denominator">  The denominator. </param>

        public void SetDenominator(int denominator)
        {
            Denominator = denominator;
        }

        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Emila, 05.12.2019. </remarks>
        ///
        /// <param name="numerator">    The numerator. </param>
        /// <param name="denominator">  The denominator. </param>

        public Fraction(int numerator, int denominator)
        {
            if (denominator > 0)
            {
                (Numerator, Denominator) = Simplify(numerator, denominator);
            }
            else if (denominator < 0)
            {
                (Numerator, Denominator) = Simplify(numerator * -1, denominator * -1);
            }
            else
            {
                Numerator = 0;
                Denominator = 1;
            }
        }

        /// <summary>   Parses string to object Fraction. </summary>
        ///
        /// <remarks>   Emila, 05.12.2019. </remarks>
        ///
        /// <exception cref="DivideByZeroException">    Thrown when an attempt is made to divide a number
        ///                                             by zero.
        /// </exception>
        /// <exception cref="FormatException">          Thrown when the format of the ? is incorrect.
        /// </exception>
        ///
        /// <param name="s">    The string. </param>
        ///
        /// <returns>   A Fraction. </returns>

        public static Fraction Parse(string s)
        {
            string[] values = s.Split('/');
            int numerator;
            int denominator;

            if (values.Length == 2)
            {
                if (int.TryParse(values[0],out numerator))
                {
                    if (int.TryParse(values[1], out denominator))
                    {
                        if (denominator > 0)
                        {
                            return new Fraction(numerator, denominator);
                        }
                        else if (denominator == 0)
                        {
                            throw new DivideByZeroException("Mianownik jest zerem");
                        }
                        else
                        {
                            throw new FormatException("Mianownik jest ujemny");
                        }
                    }
                    else
                    {
                        throw new FormatException("Mianownik jest w złym formacie");
                    }
                }
                else
                {
                    throw new FormatException("Licznik jest w złym formacie");
                }
            }
            else
            {
                throw new FormatException("Ułamek jest w złym formacie");
            }
        }

        
        /// <summary>   Implicit cast that converts the given int to a Fraction. </summary>
        ///
        /// <remarks>   Emila, 05.12.2019. </remarks>
        ///
        /// <param name="x">    The x coordinate. </param>
        ///
        /// <returns>   The result of the operation. </returns>

        public static implicit operator Fraction(int x) => new Fraction(x, 1);

        /// <summary>   Explicit cast that converts the given Fraction to an int. </summary>
        ///
        /// <remarks>   Emila, 05.12.2019. </remarks>
        ///
        /// <param name="f">    A Fraction to process. </param>
        ///
        /// <returns>   The result of the operation. </returns>

        public static explicit operator int(Fraction f) => f.Numerator / f.Denominator;

        /// <summary>   Explicit cast that converts the given Fraction to a double. </summary>
        ///
        /// <remarks>   Emila, 05.12.2019. </remarks>
        ///
        /// <param name="f">    A Fraction to process. </param>
        ///
        /// <returns>   The result of the operation. </returns>

        public static explicit operator double(Fraction f) => Convert.ToDouble(f.Numerator) / Convert.ToDouble(f.Denominator);

        /// <summary>   Addition operator which adds two fractions.  </summary>
        ///
        /// <remarks>   Emila, 05.12.2019. </remarks>
        ///
        /// <param name="left">     The first value. </param>
        /// <param name="right">    A value to add to it. </param>
        ///
        /// <returns>   The result of the operation. </returns>

        public static Fraction operator +(Fraction left, Fraction right)
        {
            return new Fraction(
                left.GetNumerator() * right.GetDenominator() + right.GetNumerator() * left.GetDenominator(),
                left.GetDenominator() * right.GetDenominator()
            );
        }

        /// <summary>   Subtraction operator which substracts two fractions. </summary>
        ///
        /// <remarks>   Emila, 05.12.2019. </remarks>
        ///
        /// <param name="left">     The first value. </param>
        /// <param name="right">    A value to subtract from it. </param>
        ///
        /// <returns>   The result of the operation. </returns>

        public static Fraction operator -(Fraction left, Fraction right)
        {
            return new Fraction(
                left.GetNumerator() * right.GetDenominator() - right.GetNumerator() * left.GetDenominator(),
                left.GetDenominator() * right.GetDenominator()
            );
        }

        /// <summary>   Multiplication operator which multiplies two fractions. </summary>
        ///
        /// <remarks>   Emila, 05.12.2019. </remarks>
        ///
        /// <param name="left">     The first value to multiply. </param>
        /// <param name="right">    The second value to multiply. </param>
        ///
        /// <returns>   The result of the operation. </returns>

        public static Fraction operator *(Fraction left, Fraction right)
        {
            return new Fraction(
                left.GetNumerator() * right.GetNumerator(),
                left.GetDenominator() * right.GetDenominator()
            );
        }

        /// <summary>   Division operator which divides two fractions. </summary>
        ///
        /// <remarks>   Emila, 05.12.2019. </remarks>
        ///
        /// <param name="left">     The numerator. </param>
        /// <param name="right">    The denominator. </param>
        ///
        /// <returns>   The result of the operation. </returns>

        public static Fraction operator /(Fraction left, Fraction right)
        {
            return new Fraction(
                left.GetNumerator() * right.GetDenominator(),
                left.GetDenominator() * right.GetNumerator()
            );
        }


        /// <summary>   Simplifies fraction. </summary>
        ///
        /// <remarks>   Emila, 05.12.2019. </remarks>
        ///
        /// <param name="numerator">    The numerator. </param>
        /// <param name="denominator">  The denominator. </param>
        ///
        /// <returns>   A numerator and  a denominator  after simplifying. </returns>

        private static (int, int) Simplify(int numerator, int denominator)
        {
            int a = Math.Abs(numerator);
            int b = Math.Abs(denominator);

            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }
            }

            int gcd = a == 0 ? b : a;

            return (numerator / gcd, denominator / gcd);
        }

        /// <summary>   Print proper fraction. </summary>
        ///
        /// <remarks>   Emila, 05.12.2019. </remarks>

        public void PrintProper()
        {
            int whole = GetNumerator() / GetDenominator();
            int rest = GetNumerator() % GetDenominator();
            if (rest == 0)
            {
                WriteLine(whole);
            }
            else
            {
                if (whole == 0)
                {
                    WriteLine(new Fraction(rest, Denominator));
                }
                else
                {
                    WriteLine(whole + " " + new Fraction(rest, Denominator));
                }
               
            }            
        }
     
        public override string ToString()
        {
            return $"{GetNumerator()}/{GetDenominator()}";
        }
          
    }
}
