using System;
using static System.Console;

namespace List6ad0k
{
    public class Zwierz { }

    public interface ISsak { }

     public class Kot : Zwierz, ISsak { }    // dziedziczy Zwierz, impl. ISaak

    class Program
    {
        static void Main(string[] args)
        {

            object daszek = new Kot();

            if (daszek is Zwierz)
            {
                Zwierz zwierzak = (Zwierz)daszek;
                // jakieś działania: daszek to też klasa Zwierz 
                WriteLine("Test 2 Ok");
            }

            if (daszek is ISsak)
            {
                ISsak saak = (ISsak)daszek;
                // jakieś działania: daszek implementuje interfejs ISsak 
                WriteLine("Test 2 Ok");
            }

            ReadLine();
        }
    }

}
