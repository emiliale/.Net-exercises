using System;
using static System.Console;

namespace List6ad0n
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 123;
            object oi = new object();

            WriteLine($"typy:\ni - {i.GetType()}\noi - {oi.GetType()}");


            oi = i; // boxing
         
            int j = (int)oi;   // unboxing

            WriteLine($"\ni: {0}, oi: {oi}, j: {j}\n\n" +
                $"typy:\ni - { i.GetType()}\noi - { oi.GetType()}\nj - { j.GetType()}\n");
            
            i = 12;
            oi = 20.1;    // boxing

            var x = (double)oi; // unboxing

            WriteLine("i: {0}, oi: {1}\ntyp oi: {2}", i, oi, oi.GetType());
        }

    }
}
