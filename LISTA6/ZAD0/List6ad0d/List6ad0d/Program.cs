using System;
using static System.Console;
using System.Text;

namespace List6ad0d
{
    class Program
    {
        static void Main(string[] args)
        {
            const int max = 100; const int kol = 10;

            OutputEncoding = Encoding.GetEncoding("UTF-8"); 
            WriteLine("Przykład zagnieżdżonego 'for'");

            // iteracja po wierszach
            for (int i = 0; i < max; i += kol)
            {
                // iteracja po kolumnach 
                for (int j = i; j < i + kol; j++) {
                     Write($"{j,-4}");   // -4 = szer. pola, wyrównanie do lewej
                }
                     WriteLine();
            }

        }
    }
}
