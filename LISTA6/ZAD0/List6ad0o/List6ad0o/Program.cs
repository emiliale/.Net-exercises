using System;
using static System.Console;
using System.Text;

namespace List6ad0o
{
    class Program
    {
        private static void Main(string[] args)
        {
            OutputEncoding = Encoding.GetEncoding("UTF-8");
            InputEncoding = Encoding.GetEncoding("UTF-8");
            dynamic d = 5;
            WriteLine($"Aktualny typ zmiennej d: {d.GetType().FullName}");
            d++;
            WriteLine($"Bieżąca wartość zmiennej d: {d}\n");
            d = 5.5;
            WriteLine($"Aktualny typ zmiennej d: {d.GetType().FullName}");
            d++; // ???
            WriteLine($"Bieżąca wartość zmiennej d: {d}\n");
            d = 'A';
            WriteLine($"Aktualny typ zmiennej d: {d.GetType().FullName}");
            d++; // ???
            WriteLine($"Bieżąca wartość zmiennej d: {d}\n");

            d = "ąćęłńóżź";
            WriteLine($"Aktualny typ zmiennej d: {d.GetType().FullName}");
            WriteLine($"Bieżąca wartość zmiennej d: {d}\n");

            WriteLine("Naciśnij Enter, aby spowodować wyjątek"); 
            ReadLine();
            try
            {
                d++;    // ???
                WriteLine($"Bieżąca wartość zmiennej d: {d}\n");

            }
            catch (Exception e)
            {
                WriteLine("Zmienna dynamiczna/wyjątek: " + e.Message);
            }
            WriteLine(); d = 7;
            d++;
            WriteLine($"Aktualna wartość: {d} i typ zmiennej d: {d.GetType()}");
        }
    }
}
