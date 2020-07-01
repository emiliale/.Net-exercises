using System;
using static System.Console;

namespace List6ad0h
{
    class Program
    {
        private static void Main(string[] args)
        {
            int a = default(int);   //uwaga
            int b = default(int);
            string s;
            WriteLine(a);
            try
            {
                Write("a: ");
                s = ReadLine();
                a = int.Parse(s); 
                Write("b: ");
                s = ReadLine();
                b = int.Parse(s);
                var max = a > b ? a : b; 
                WriteLine($"Maksimum z ({a},{b}) to {max}");

                WriteLine("Maksimum z ({0},{1}) to {2}", a, b, a > b ? a : b);
            }//błąd formatu - wyjątek 
            catch (Exception e)
{                WriteLine(e.Message);
            }
        }

    }
}
