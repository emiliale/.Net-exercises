//Emilia Lebiedowska 242473
using System;
using System.Collections;
using static System.Console;

namespace List7ad2
{
    class Test
    {
        static void Main(string[] args)
        {
            Informator test = new Informator();
            bool repeat = true;
            string dodaj;
            test.FillLoty();
            WriteLine("Czy chcesz dodać lot?[tak/nie]");
            dodaj = ReadLine();
            if (dodaj == "tak")
            {
                while (test.AddFligth() != true)
                {
                    
                }
            }
                        
            
            while (repeat)
            {
                
                if (test.GetDate())
                {
                    if (test.GetCki().Key == ConsoleKey.Escape)
                    { 
                        repeat = false;
                        break;
                    }
                    else
                    {
                        test.FindFlight();
                    }    
                }

            }
                     

        }
    }
}
