using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace List6ad0c
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 2, 4, 6, 8, 10 };
            ShowCollectionInformation(values);

            var names = new List<string>(); // w dokumentacji zobacz opis List<T> 
            names.AddRange(new string[] {"Adam","Agata","Miłosz","Magda" }); 
            ShowCollectionInformation(names);

            List<int> numbers1 = null; 
            ShowCollectionInformation(numbers1);

            var numbers2 = new List<double>();
            ShowCollectionInformation(numbers2);
            numbers2.Add(1.123); 
            numbers2.Add(2.234); 
            ShowCollectionInformation(numbers2);
            // w dokumentacji zobacz opis IEnumerable<T>
            IEnumerable<int> result = from value in Enumerable.Range(0, 5)
                                      select value; 
            ShowCollectionInformation(result);

            // konwersja IEnumerable<int> za pomocą metod rozszerzających
            int[] array1 = result.ToArray();
            List<int> list1 = result.ToList(); 
            ShowCollectionInformation(array1); // case – spr. pod debugerem
            ShowCollectionInformation(list1);   // case – spr. pod debugerem

            dynamic myObject = ".NET"; 
            ShowCollectionInformation(myObject); 
            myObject = 123.456; 
            ShowCollectionInformation(myObject);
        }

        private static void ShowCollectionInformation(object coll)
        {
            switch (coll)
            {
                case Array arr:
                    WriteLine($"Tablica zawiera {arr.Length} elementów.");
                    break;
                case IEnumerable<int> ieInt: 
                    WriteLine($"Średnia: {ieInt.Average(s => s)}"); 
                    break;
                case IList list:
                    WriteLine($"Lista zawiera {list.Count} elementów"); 
                    break;
                case null: WriteLine($"To 'null'"); 
                    break;
                default:
                    WriteLine($"Instancja typu {coll.GetType().Name}"); break;
            }
        }

    }
}
