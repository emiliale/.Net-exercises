using System;
using System.Text;
using static System.Console;


namespace List7ad0c
{
    class Program
    {
        static void Main(string[] args)
        {
            OutputEncoding = Encoding.GetEncoding("UTF-8");
            InputEncoding = Encoding.GetEncoding("UTF-8");
            // dwie daty
            DateTime dt1 = new DateTime(2010, 1, 1, 0, 0, 0);
            DateTime dt2 = DateTime.Now;
            // interwał czasu
            TimeSpan interval = dt2 - dt1; 
            WriteLine("demo 1:");
            WriteLine("{0} - {1} = {2}", dt2, dt1, interval.ToString());

            // właściwości wynikowego obiektu/struktury TimeSpan
            WriteLine("   {0,-35} {1,20}", "Value of Days Component:", interval.Days);
            WriteLine("  {0,-35} {1,20}", "Total Number of Days:", interval.TotalDays);
            WriteLine(" {0,-35} {1,20}", "Value of Hours Component:", interval.Hours); 
            WriteLine(" {0,-35} {1,20}", "Total Number of Hours:", interval.TotalHours);
            WriteLine(" {0,-35} {1,20}", "Value of Minutes Component:", interval.Minutes);
            WriteLine(" {0,-35} {1,20}", "Total Number of Minutes:", interval.TotalMinutes);
            WriteLine(" {0,-35} {1,20:N0}", "Value of Seconds Component:", interval.Seconds); 
            WriteLine(" {0,-35} {1,20:N0}", "Total Number of Seconds:", interval.TotalSeconds);
            WriteLine(" {0,-35} {1,20:N0}", "Value of Milliseconds Component:", interval.Milliseconds);
            WriteLine(" {0,-35} {1,20:N0}", "Total Number of Milliseconds:", interval.TotalMilliseconds);
            WriteLine(" {0,-35} {1,20:N0}", "Ticks:", interval.Ticks);

            WriteLine("demo 2:");
            decimal liczM = decimal.MaxValue, licz; 
            licz = liczM;
            int iteracje = int.MaxValue / 2; WriteLine("Start testu... czekaj... "); 
            DateTime start = DateTime.Now;
            for (int i = 0; i < iteracje; i++)  // ile
            {   // to
                licz--; // trwa?
            }
            DateTime stop = DateTime.Now;
            TimeSpan interwal2 = stop - start;
            Write($"liczM:\t {liczM}\n");
            Write($"licz:\t {licz}\n\n");
            Write($"Czas trwania testu: {interwal2}\n");
            Write($"Czas trwania testu(ms): {interwal2.TotalMilliseconds}\n");
            Write($"Czas trwania testu(tiki): {interwal2.Ticks}\n");
        }

    }
}
