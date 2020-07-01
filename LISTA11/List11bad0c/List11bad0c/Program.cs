using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace List11bad0c
{
    class Program
    {
        static void Main(string[] args)
        {
            MultipleAsyncMethodsWithWhenAny();
            ReadLine();
        }


        // metoda wywołująca
        private async static void MultipleAsyncMethodsWithWhenAny()
        {
            // stopwatch
            Stopwatch stopwatch = new Stopwatch();
            // start 
            stopwatch.Start();

            Task<string> t1 = GreetingAsync("Ola", 7000);
            Task<string> t2 = GreetingAsync("Jola", 5000);
            Task<string> t3 = GreetingAsync("Karol", 3000);

            string result = await Task.WhenAny(t1, t2, t3).Result; 
            WriteLine($"Koniec metody 'najszybszej'\n Wynik: {result}");  // stop 
            stopwatch.Stop();
            // upływ czasu
            WriteLine($"Upływ czasu: {stopwatch.Elapsed}");
        }

        // zadanie = metoda asynchroniczna
        static Task<string> GreetingAsync(string name, int delay)
        {
            return Task.Run<string>(() =>
            {
                Thread.Sleep(delay);
                return string.Format($"Witaj {name}!");

            });
        }
    }
}
