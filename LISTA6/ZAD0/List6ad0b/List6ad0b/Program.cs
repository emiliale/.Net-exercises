using System;
using static System.Console;
using System.Text;

namespace List6ad0b
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Wpisz dzień tygodnia"); string dzien;
            OutputEncoding = Encoding.GetEncoding("UTF-16"); 
            InputEncoding = Encoding.GetEncoding("UTF-16"); dzien = ReadLine();
            switch (dzien)
            {
                case "poniedziałek": WriteLine(".NET - labo"); break;
                case "wtorek":
                    WriteLine(".NET - wykład, labo"); break;
                case "środa":
                    WriteLine(".NET - labo"); goto case "piątek";
                case "czwartek":
                    WriteLine("Jakieś wykłady…"); break;
                case "piątek":
                    WriteLine("Prawie weekend\u263A"); break;
                case "sobota":
                case "niedziela": WriteLine("Weekend"); break;
                default:
                    WriteLine("Nieznana nazwa!\n"); break;
            }

            WriteLine("\nDemo nullable");
            int? demo = null;
            switch (demo)
            {
                case 1: WriteLine("jeden"); break;
                case null: WriteLine("brak wartości"); break;
                default: WriteLine("inna wartość"); break;
            }

        }
    }
}
