using System;
using static System.Console;

namespace List6ad0i
{
    class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                byte a = byte.MaxValue; checked
                {
                    a++;
                }
            }
            catch (OverflowException e)
            {
                WriteLine("Przepełnienie 1!\n" + e.StackTrace);
            }

            try
            {
                byte b = byte.MaxValue; unchecked
                {
                    b++;
                }
            }
            catch (OverflowException e)
            {
                WriteLine("Przepełnienie 1!\n" + e.StackTrace);
            }
            WriteLine("Koniec");
        }

    }
}
