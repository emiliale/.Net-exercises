using System;
using System.Diagnostics;
using static System.Console;


namespace Lis6ad0r
{
    class Program
    {
        private static void TestDynamicznych(int par)
        {
            var sw = Stopwatch.StartNew();  // zobacz dok. klasy Stopwatch 
            dynamic a = 100.1;
            dynamic b = 200.2; 
            dynamic c = 300.3; 
            dynamic d = 400.4; 
            dynamic e = 500.5;
            dynamic f = 600.6;
            dynamic g = 700.7; 
            dynamic h = 800.8; 
            dynamic i = 900.9;
            dynamic wyn = ++a + ++b + ++c + ++d + ++e + ++f + ++g + ++h + ++i + (dynamic)par;
            sw.Stop();
            WriteLine($"Czas zm. dynamicznych: {sw.ElapsedTicks}");
        }

        private static void TestStatycznych(int par)
        {
            var sw = Stopwatch.StartNew(); 
            double a = 100.1;
            double b = 200.2;
            double c = 300.3; 
            double d = 400.4;
            double e = 500.5; 
            double f = 600.6; 
            double g = 700.7; 
            double h = 800.8;
            double i = 900.9;
            double wyn = ++a + ++b + ++c + ++d + ++e + ++f + ++g + ++h + ++i + par; 
            sw.Stop();
            WriteLine($"Czas zm. statycznych: {sw.ElapsedTicks}");
        }
        private static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                TestDynamicznych(i);
            }
            for (int i = 0; i < 10; i++)
            {
                TestStatycznych(i);
            }
            ReadLine();
        }

    }
}
