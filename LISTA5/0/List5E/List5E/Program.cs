using System;
using static System.Console;

namespace List5E
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine(1.0.GetType());               // Double (double)
            WriteLine(1E06.GetType());              // Double (double)
            WriteLine(1.GetType());                 // Int32 (int)
            WriteLine(0xF0000000.GetType());        // UInt32 (uint)
            WriteLine(1.0F.GetType());              // Single (float)
            WriteLine(1D.GetType());                // Double (double )
            WriteLine(1.0M.GetType());              // Decimal (decimal)
            WriteLine(1U.GetType());                // UInt32 (uint)
            WriteLine(1UL.GetType());               // UInt64 (ulong)
            WriteLine(1L.GetType());                // Int64 (long)
            WriteLine('A'.GetType());               // Char
            WriteLine('\u0041'.GetType());          // Char
            WriteLine('\x0041'.GetType());          // Char
            WriteLine("Aa".GetType());              // String
                                                                           
            WriteLine(); 
            var i = 123;
            var s = "demo"; 
            var z1 = 'a';
            var z2 = 'a' + 5;               // ???

            WriteLine(i.GetType());         // ?
            WriteLine(s.GetType());         // ?
            WriteLine(z1.GetType());        // ?
            WriteLine(z2.GetType());        // ?
                                  
            WriteLine();
            Object o = new Object(); 
            WriteLine(o.GetType());         // ?

            object o1 = new object(); 
            WriteLine(o1.GetType());        // ?	

        }
    }
}
