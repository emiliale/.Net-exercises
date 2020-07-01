using System;
using static System.Console;

namespace List7ad0f
{
    class Program
    {
        static void Main(string[] args)
        {
            int i; double d; string str; 
            try
            {
                Write("Wprowadź wartość i (int): ");
                str = ReadLine();
                i = int.Parse(str);
                WriteLine($"Wprowadziłeś: {i}");

                //UWAGA: wprowadź liczbę z przecinkiem 
                Write("\nWprowadź wartość d (double): "); 
                str = ReadLine();
                d = double.Parse(str); 
                WriteLine("Wprowadziłeś: {0}", d);

            }//błąd formatu - wyjątek
            catch (Exception e)
{                WriteLine(e.Message);
            }
        }

    }
}
