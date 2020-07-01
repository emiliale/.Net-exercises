using System;
using static System.Console;

namespace List6ad0l
{
    public class Zwierz { }

    public interface ISsak { }

    public class Kot : Zwierz, ISsak { }

    class Program
    {
        static void Main(string[] args)
        {
            object daszek = new Kot();
            Zwierz zwierzak = daszek as Zwierz;
            if (zwierzak != null)
            //if (daszek is Zwierz zwierzak)
            {
                // jakieś działania, gdy rzutowanie udane
                WriteLine("przykład 1 - rzutowanie udane");
            }
            ISsak ssak = daszek as ISsak;       // c 
            if (ssak != null)                                 // d
            //if (daszek is ISsak)	// zamiast c i d
            {
                // jakieś działania, gdy rzutowanie udane
                WriteLine("przykład 2 - rzutowanie udane");
            }
            //demo 2
            object o1 = "Jakiś napis";
            object o2 = 5;
            WriteLine($"{o1.GetType().Name}"); 
            WriteLine($"{o2.GetType().Name}");

            string s1 = o1 as string; // s1 = ??? 
            var s2 = o2 as string;       // s2 = ???

            WriteLine($"{s1.GetType().Name}");
            if (s2 != null)
            {
                WriteLine($"{s2.GetType().Name}");
            }
            else WriteLine($"Wynik: 'null'");
            ReadLine();
        }
    }
}
