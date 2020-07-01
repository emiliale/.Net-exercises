using System;
using static System.Console;

namespace List5C
{
    class Program
    {
        static void Main(string[] args)
        {

            Decimal ep = 1e-24M;
            WriteLine($"byte\nmin: {Byte.MinValue}\nmax: {Byte.MaxValue} \nrozmiar: { sizeof(Byte)}\ndomyślna wartość: { default(byte)}\n");

            WriteLine($"int\nmin: {Int32.MinValue}\nmax: {Int32.MaxValue}	\nrozmiar:{ sizeof(Int32)}\ndomyślna wartość: { default(Int32)}\n");

            WriteLine($"ulong\nmin: {UInt64.MinValue}\nmax: {UInt64.MaxValue}\nrozmiar: { sizeof(UInt64)}\ndomyślna wartość: { default(UInt64)}\n");

            WriteLine($"float\nepsilon: {Single.Epsilon}\nmin: {Single.MinValue}\nmax: { Single.MaxValue}\nrozmiar: { sizeof(Single)}\ndomyślna wartość: { default(Single)}\n");

            WriteLine($"decimal\nepsilon: {ep}\nmin: {Decimal.MinValue}\nmax:{ Decimal.MaxValue}\nrozmiar: { sizeof(Decimal)}\ndomyślna wartość: { default(Decimal)}\n\n");


        }
    }
}
