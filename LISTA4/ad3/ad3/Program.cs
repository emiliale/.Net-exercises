using System;
using System.IO;

namespace ad3
{
    class Program
    {
        static int count;
        static StreamReader sr;
        const string name = @"C:\Users\emila\source\repos\LISTA4\ad3\ad3\plik.txt";
        static void Main(string[] args)
        {
            count = 0;
            try
            {
                sr = new StreamReader(name);
                //string path = args[0];
                //sr = new StreamReader(GetPath());
                //sr = new StreamReader(path);
                ReadLines();
                sr.Close();
                Console.WriteLine($"\n Liczba linii: {count}\n");
                Console.Read();

            }
            catch (Exception e)
            {
                Console.WriteLine("Komunikat systemowy: " + e.Message + "\n");
            }
        }

        static void ReadLines()
        {
            String textLine = sr.ReadLine();
            if (textLine != null)
            {
                Console.WriteLine("\n" + textLine);
                count++;
                ReadLines();
            }
        }

        static string GetPath()
        {
            string path = "";
            Console.WriteLine("\n Podaj nazwę pliku wraz ze ścieżką \n");
            try
            {
                path = Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine("Komunikat systemowy: " + e.Message + "\n");
            }
            return path;
        }
    }
}
