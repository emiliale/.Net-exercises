using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace List6ad0m
{
    class Program
    {
        static void Main(string[] args)
        {
            int? nullableInt = 10;
            double? nullableDouble = 3.14;
            bool? nullableBool = null;
            char? nullableChar = 'a';
            int?[] arrayOfNullableInts = new int?[10];
            // string? s = "oops"; typ łańuchowy jest typem referencyjnym!

            if (nullableInt.HasValue)
                WriteLine($"{nullableInt.Value}");
            if (arrayOfNullableInts[0].HasValue)
                WriteLine($"{arrayOfNullableInts[0].Value}");
            arrayOfNullableInts[9] = 123;
            if (arrayOfNullableInts[9].HasValue)
                WriteLine($"{arrayOfNullableInts[9].Value}");

            // inne rozwiązanie: System.Nullable<T> 
            Nullable<int> nullableInt1 = 10;
            Nullable<double> nullableDouble1 = 3.14;
            Nullable<bool> nullableBool1 = null;
            Nullable<char> nullableChar1 = 'a';
            Nullable<int>[] arrayOfNullableInts1 = new int?[10];

            int? x = null;
            int y = x ?? -1;
            int? z = null;
            int? u = x ?? z;
            if (u.HasValue)
                WriteLine($"Wartość u: {u.Value}");
            else WriteLine("u nie ma jeszcze wartości");
            WriteLine("y: {0}, u: {1}", y, u.HasValue);

            arrayOfNullableInts1[0] = x;
            arrayOfNullableInts1[1] = y;
            arrayOfNullableInts1[2] = 2 * x ?? 5;
            for (int i = 0; i < 10; i++)
            {
                if (arrayOfNullableInts1[i].HasValue)
                    WriteLine($"[{i}]: {arrayOfNullableInts1[i].Value}");
                else WriteLine($"[{i}] nie ma jeszcze wartości");
            }

            // demo operatorów: ?[] , ?. , ??
            // i lista generyczna + met. rozszerzejąca tech. LINQ – uwagi: - patrz wykład!
            double SumNumbers(List<double[]> setsOfNumbers, int indexOfSetToSum)
            {
                return setsOfNumbers?[indexOfSetToSum]?.Sum() ?? double.NaN;
            }
            var sum1 = SumNumbers(null, 0);
            WriteLine(sum1);	// wynik: NaN
            var numberSets = new List<double[]>
            {
            new[] { 1.0, 2.0, 3.0 }, null, new[] {4, 5.0, 6}
            };
            var sum2 = SumNumbers(numberSets, 0);
            WriteLine(sum2);  // wynik: 6
            var sum3 = SumNumbers(numberSets, 1);
            WriteLine(sum3);  // wynik: NaN
            var sum4 = SumNumbers(numberSets, 2);
            WriteLine(sum4);    // wynik: 15
        }
    }
}
