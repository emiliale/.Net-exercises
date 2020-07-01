//Emilia Lebiedowska 242473

using System;
using static System.Text.Encoding;
using static System.Console;

namespace demo3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Witaj Emila!");
            Info info = new Info();
            OutputEncoding = GetEncoding("UTF-8");
            WriteLine("Witaj, spytam Cię o imię i wiek!");
            Write("Podaj imię: ");
            string imie = ReadLine();
            if(imie.Length == 0)
            {
                Error.WriteLine("\n\nBłąd: nie podałeś imienia!\n\n");
                info.WyswietlDane("Brak imienia");
                return;
            }
            Write("Podaj nazwisko: ");
            string nazwisko = ReadLine();
            if (nazwisko.Length == 0)
            {
                Error.WriteLine("\n\nBłąd: nie podałeś nazwiska!\n\n");
                info.WyswietlDane("Brak nazwiska");
                return;
            }
            Write("Ile masz lat? ");
            int wiek;
            try
            {
                wiek = System.Convert.ToInt32(ReadLine());
            }
            catch(System.Exception)
            {
                Error.WriteLine("Błąd: nie podałeś liczby całkowitej!");
                info.WyswietlDane("Brak wieku");
                return;
            }
            WriteLine($"\nWitaj {imie}!\nPodałeś, że masz lat: {wiek:D}\n");
            info.WyswietlDane("Koniec");
            Read();
        }
    }
}
