using System;
using System.Numerics;
using static System.Console;

namespace List5D
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Arytmetyka dużych liczb - nowość platformy .NET 4.0\n");
            // utworzenie i zainicjowanie wart. domyślną
            BigInteger bi1;
            WriteLine($"Wartość bi1: {default(BigInteger)}");

            // utworzenie i zainicjowanie wartością całkowitą (ulong)
            BigInteger bi2 = 12345678901234567890;
            WriteLine($"Wartość bi2: {bi2}");

            // parsowanie i knwersja napisu na BigInteger 
            bi1=BigInteger.Parse("999999999999999999999999999999999999999999999999999999999");

            WriteLine($"Wartość bi1: {bi1}");
            WriteLine($"Parzystość bi1: {bi1.IsEven}");
            WriteLine($"bi1 potęga dwójki?: {bi1.IsPowerOfTwo}"); 
            BigInteger bi3 = BigInteger.Multiply(bi1, bi2); 
            WriteLine($"Iloczyn bi1xbi2: {bi3}");

        }
    }
}
