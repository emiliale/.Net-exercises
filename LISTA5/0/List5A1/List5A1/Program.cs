using System;
using static System.Console;

namespace List5A1
{

    class Program
    {
        //struktura = typ wartości/wartościowy
        public struct Punkt{
            public int X, Y;
        }

    static void Main(string[] args)
        {
            Punkt p1 = new Punkt(); // składowe=pola struct zaincjowane wart. domyślnymi
                                    //Punkt p1;	// j.w ale składowe struct niezainicjowane 
            p1.X = 0x17;
            Punkt p2 = p1;  // przypisanie powoduje utworzenie kopii
            WriteLine(p1.X); WriteLine(p2.X);   //???

            p1.X = 0x23;    //zmiana wartości p1.X NIE wpływa na p2.X 
            WriteLine(p1.X);
            WriteLine(p2.X);

            WriteLine(p1.Y);    //???
            WriteLine(p2.Y);	//???

        }
    }
}
