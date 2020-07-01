using System;
using static System.Console;

namespace List7ad0g
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int arg1;
            double arg2; 
            bool arg3;

            Write("Podaj arg1 (int): "); 
            str = ReadLine();
            if (int.TryParse(str, out arg1)) WriteLine($"arg1: {arg1}"); else WriteLine("arg1 - to nie jest int!");

            // wprowadź liczbę z przecinkiem
            // czekanie na poprawny arg2
            do
            {
                Write("\nPodaj arg2 (double): ");
                str = ReadLine();
            } while (!double.TryParse(str, out arg2));

            WriteLine($"arg2: {arg2}\n");
            // czekanie na poprawny arg3 
            do
            {
                Write("\nPodaj arg3 (bool): ");
                str = ReadLine();
            } while (!bool.TryParse(str, out arg3)) ;

            WriteLine($"arg3: {arg3}\n");
        }

    }
}
