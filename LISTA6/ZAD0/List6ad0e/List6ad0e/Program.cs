using System;
using static System.Console;
using System.Text;
using System.Collections;

namespace List6ad0e
{
    class Program
    {
        public static void Main(string[] args)
        {
            OutputEncoding = Encoding.GetEncoding("UTF-8");
            WriteLine("Przykład 'foreach' z tablicą 2D:"); // deklaracja z zainicjowaniem tablicy 2D
            int[,] tab2D = new int[3, 2] { { 1, 11 }, { 2, 22 }, { 3, 33 } };
            foreach (int i in tab2D)
            {
                Write($"{i,-4}");
            }

            WriteLine("\n\nPrzykład 'foreach' z tablicą 1D:");
            int[] tab1D = new int[10];  //tablica zainicjowana zerami 
            for (int i = 0; i < 10; tab1D[i++] = i) ; //zainicjowanie
            foreach (int i in tab1D)
            {
                Write($"{i,4}");
            }


            ArrayList anArrayList = new ArrayList();
            for (int i = 0; i < 10; ++i)
            {
                anArrayList.Add(tab1D[i]);
            }
            anArrayList.Add(100);

            //instancja pustej kolekcji


            //dodawanie elem. w pętli

            //i jeszcze jeden element


            WriteLine("\n\nPrzykład 'foreach' z kolekcją ArrayList:");
            foreach (int number in anArrayList) // number - zm. iteracyjna
            {
                Write($"{number,4}");
            }
            WriteLine("\n");
        }
    }
}

  
