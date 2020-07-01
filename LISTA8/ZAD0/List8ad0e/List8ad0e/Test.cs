using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace List8ad0e
{
    class Test
    {
        public static void Main()
        {
            Fraction a = new Fraction(1, 2);
            WriteLine($"({a.FracX}, {a.FracY})");

            Fraction b = new Fraction(3, 4);
            WriteLine($"({b.FracX}, {b.FracY})");

            Fraction c = a + b; // c.x == 10, c.y == 8
            WriteLine($"({c.FracX}, {c.FracY})"); Write("a + b = ");
            c.ToString(a + b);
        }

    }
}
