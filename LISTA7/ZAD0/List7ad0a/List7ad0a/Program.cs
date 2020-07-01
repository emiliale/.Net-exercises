using System;
using static System.Text.Encoding;
using static System.Console;


namespace List7ad0a
{
    class Program
    {
        static void Main(string[] args)
        {
            OutputEncoding = GetEncoding("UTF-8"); 
            InputEncoding = GetEncoding("UTF-8");

            Write("p1- tylko indeks parametru\n"); 
            int i = 10;
            int j = 20;
            WriteLine("{0} {1} + {2} = {3}", "Działanie: ", i, j, i + j);

            Write("\n\np2- indeks parametru, szerokość pola\n"); i = 940;
            j = 73;
            WriteLine(" {0,4}\n+{1,4}\n	\n {2,4}", i, j, i + j);

            Write("\n\np3 - indeks parametru, szer. pola, łańcuch formatu\n");
            decimal k = 940.23m;
            decimal n = 73.7m;
            WriteLine(" {0,12:C1}\n+{1,12:C1}\n	\n {2,12:C1}", i, j, i + j);

            Write("\n\np3$ - parametr, szerokość pola, łańcuch formatu\n");
            // interpolacja string - od C# 6
            WriteLine($" {k,12:C1}\n+{n,12:C1}\n	\n {k + n,12:C1}");

            // sterowanie wyrównaniem, szer. pola
            WriteLine("Do prawej:{0, 10}|\nDo lewej :{1,-10}|", 99, 99);
            WriteLine($"\nDo prawej:{99.123,10}|\nDo lewej :{99.123,-10}|");

            WriteLine("wynik: {0:C2}", 1234.567);

            WriteLine("wynik: {0:D5}", 123);
            WriteLine("wynik: {0:d5}", -123);

            WriteLine("wynik:{0,15:E2}", 123.4567);
            WriteLine("wynik:{0,15:e4}", -9876.5);

            WriteLine("wynik: {0,10:F0}", 1234.567);
            WriteLine("wynik: {0,10:f2}", -9876.5);

            WriteLine("wynik:{0,10:G}", .0000099);
            WriteLine("wynik:{0,10:G2}", 455.89);
            WriteLine("wynik:{0,10:G3}", 455.89);
            WriteLine("wynik:{0,10:G}", 987654.32);

            WriteLine("wynik: {0,10:N}", 1234.56);
            WriteLine("wynik: {0,10:N1}", -98.67);
            WriteLine("wynik: {0,10:N3}", 1234.56);

            WriteLine("wynik: {0,10:P}", 0.12);
            WriteLine("wynik: {0,10:P3}", 0.1234);

            WriteLine("wynik: {0,10:R}", 12.3456789);

            WriteLine("wynik: {0,10:X}", 31);
            WriteLine("wynik: {0,10:X4}", 31);





        }

    }
}
