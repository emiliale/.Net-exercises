using System;
using static System.Console;

namespace List6ad0p
{
    class Program
    {
        static void Main(string[] args)
        {
            var zmiennaVar = 10;
            WriteLine(zmiennaVar.GetType()); 
            //zmiennaVar = "to napis";

            object zmiennaObj = 10;
            WriteLine(zmiennaObj.GetType()); 
            zmiennaObj = (int)zmiennaObj + 5; 
            WriteLine(zmiennaObj.GetType());

            zmiennaObj = "to napis";
            WriteLine(zmiennaObj.GetType()); 
           // WriteLine("długość: {0}", zmiennaObj.Length);

            dynamic zmiennaDyn = "to napis";
            WriteLine(zmiennaDyn.GetType());
            WriteLine("długość: {0}", zmiennaDyn.Length);
        }
    }
}
