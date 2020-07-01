//Emilia Lebiedowska 242473
using System;
using System.Collections.Generic;
using static System.Console;

namespace List9ad4
{
    class Program
    {

        public static void PrintArray<T>(IEnumerable<T> inputArray)
        {
            foreach (var item in inputArray)
                WriteLine(item); 
        }
 
        
        static void Main(string[] args)
        {
            // przykładowe tablice
            Double[] dblArray = { 1.1, 2.2, 3.3, 4.4 }; 
            Char[] charArray = { 'W', 'i', 't', 'a', 'j', '!' }; 
            String[] strArray = { "Adam", "Ewa", "Jaś" };
            Student[] studArray = new Student[2];
            studArray[0] = new Student("Jan", "Janowski", 123); 
            studArray[1] = new Student("Ola", "Olowska", 456);

            WriteLine("\nTablica dblArray zawiera:"); 
            PrintArray(dblArray);	// Double 
            WriteLine("\nTablica charArray zawiera:"); 
            WriteLine(charArray);	// Character
            WriteLine("\nTablica strArray zawiera:"); 
            PrintArray(strArray);	// String 
            WriteLine("\nTablica studArray zawiera:"); 
            PrintArray(studArray);	// Student

        }
    }
}
