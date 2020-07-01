using System;
using static System.Console;

namespace List5B
{
    class Punkt // klasa to typ referencyjny
    {
        public int X, Y;
    }

    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Klasa to typ referencyjny\n"); 
            Punkt p1 = new Punkt();
            p1.X = 0x17;

            Punkt p2 = new Punkt();
            p2 = p1;    // przypisanie referencji

            // Punkt p2 = p1;	-- alternatywnie
            WriteLine(p1.X);
            WriteLine(p2.X);

            p1.X = 0x33;    // zmiana wartości p1.X
            WriteLine(p1.X);
            WriteLine(p2.X);

            WriteLine(p1.Y);
            WriteLine(p2.Y);
        }
    }
}


