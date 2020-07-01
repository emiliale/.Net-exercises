using System;
using static System.Console;
using System.Text;
using System.Linq;

namespace List9ad0
{
    class Program
    {
        public static object OutputEncoding { get; private set; }

        static void Main(string[] args)
        {
            OutputEncoding = Encoding.GetEncoding("UTF-8");

            // konwersja wyr. lambda na obiekt delegata Func<T, TResult> 
            Func<int, int> Inc = (int n) => n + 1;
            // wywołanie metody poprzez delegata
             WriteLine("Wynik1: " + Inc(1)); 
            WriteLine("Wynik2: " + Inc(10));

            // konwer. wyr. lambda na obiekt delegata Func<T1, T2, TResult>
            Func<double, double, bool> IsEqual = (x, y) => x == y;
            int a = 10;
            int b = 20;
            string xx = "Adam";
            string yy = "Ewa";

            WriteLine(IsEqual(a, b)); 
            WriteLine(IsEqual(a, a));
            WriteLine(IsEqual(xx.Length, yy.Length));

            string[] names = { "Ala", "Gromosław", "Magda", "Wawrzyniec" };

            // wyrażenie lambda w zapytaniu LINQ
            var maxLength = names.Max(el => el.Length);

            // wyrażenie lambda el=>el.Length użyte jako arg. metody Max dla tablicy łańcuchów.
            // Metoda Max wywołuje metodę podaną w arg dla każdego
            // elementu tablicy i zwraca wartość dla tego elementu, dla którego jest ona największa.

            // pisz wynik
            WriteLine($"Najdłuższe imię składa się z {maxLength} znaków");

            // instrukcja lambda konwertowana na obiekt delegata Action<T> 
            Action<string> myGreet = name =>
            {
                string greeting = $"\nHey {name}!\n"; WriteLine(greeting);
            };

            // wywołanie delegata z parametrem 'Joe' 
            myGreet("Joe");

            // wywołanie delegata z parametrem 'Jude'
             myGreet("Jude");

        }
    }
}
