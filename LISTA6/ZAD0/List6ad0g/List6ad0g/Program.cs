using System;
using static System.Console;

namespace List6ad0g
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ile = 5; int a = 5;
            int b = 10, c;
            for (int i = 0; i < ile; i++)
            {
                c = a++ + b;    // jak to jest obliczane?
                WriteLine($"iteracja: {i}, c: {c}, a: {a}, b: {b}");	};
            }

        }
    }

