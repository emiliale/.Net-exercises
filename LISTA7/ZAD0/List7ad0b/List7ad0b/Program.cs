using System;
using static System.Console;

namespace List7ad0b
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime teraz = DateTime.Now;
            WriteLine("Teraz: {0}", teraz); // lokalny, domyślny WriteLine($"Teraz: {teraz}");	// format daty i czasu
            WriteLine();

            WriteLine("Teraz: {0:U}", teraz);   // czas UTC
            WriteLine($"Teraz: {teraz:U}");	// czas UTC 
            WriteLine("Teraz: {0:s}", teraz);	// czas lokalny 
            WriteLine($"Teraz: {teraz:s}");	// czas lokalny 
            WriteLine();
            DateTime data = new DateTime(2019, 12, 31, 23, 59, 59, 789); 
            WriteLine("d: {0:d}", data);
            WriteLine("D: {0:D}", data);
            DateTime data2 = data.AddSeconds(1); WriteLine("\nd: {0:d}", data2);
            WriteLine("D: {0:D}", data2);

        }
    }
}
