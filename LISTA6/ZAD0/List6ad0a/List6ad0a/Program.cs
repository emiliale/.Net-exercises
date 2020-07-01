using System;
using System.Text;
using static System.Console;

namespace List6ad0a
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Wpisz dzień tygodnia"); 
            string dzien;
            OutputEncoding = Encoding.GetEncoding("UTF-16"); 
            InputEncoding = Encoding.GetEncoding("UTF-16"); 
            dzien = ReadLine();
            if ((dzien == "poniedziałek") || (dzien == "środa"))
                WriteLine(".NET-labo\u263A\n"); //\u263A – znak Unikodu
            else if (dzien == "wtorek")
            WriteLine(".NET-wykład, labo\u263A\n");
            else if (dzien == "czwartek")
                WriteLine("Nuda\n");
            else if (dzien == "piątek")
                WriteLine("Prawie weekend \u263A \u263A\n");
            else if (dzien == "sobota")
                WriteLine("Weekend \u263A \u263A \u263A\n");
            else if (dzien == "niedziela\n")
                WriteLine("Weekend");
            else
                WriteLine("Nazwa nieznana!\n");

        }
    }
}
