using System;
using static System.Console;

namespace List8ad0e
{
    struct Fraction
    {
        private int x, y;
        public Fraction(int x, int y) { this.x = x; this.y = y; }

        // operator dodawania ułamków – klasycznie
        public static Fraction operator +(Fraction a, Fraction b)
        {
            return new Fraction(a.x * b.y + b.x * a.y, a.y * b.y);
        }

        // operator dodawania ułamków – nowa składnia, C# 6+ 
        //public static Fraction operator +(Fraction a, Fraction b)
        //=> new Fraction(a.x * b.y + b.x * a.y, a.y * b.y);


        // licznik
        public int FracX => x;  // wyrażenie dla właściwości, C# 6+

        //public int FracX	getter - klasycznie
        //{
        //	get { return x; }
        //}

        // mianowanik
        public int FracY => y;  // wyrażenie dla właściwości

        public void ToString(Fraction f)    // pisz ułamek
        {
            WriteLine($"{f.FracX}/{f.FracY}");
        }

    }

}
