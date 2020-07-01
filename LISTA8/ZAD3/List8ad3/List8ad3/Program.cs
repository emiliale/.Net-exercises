//Emilia Lebiedowska 242473
using static System.Text.Encoding;
using static System.Console;
using System.Collections.Generic;

namespace List8ad3
{
    class Program
    {
        static void Main(string[] args)
        {
            OutputEncoding = GetEncoding("UTF-8");
        
            List<Person> listOfPers = new List<Person>()
            {
                new Person("Adam", 23),
                new Person("Ewa", 20),
                new Person("Jola", 21),
                new Person("Tola", 22),
                new Person("Adam", 18),
                new Person("Tola", 25)
            };

            WriteLine("Lista 1:");
            foreach (Person p in listOfPers)
                WriteLine(p.ToString());
            

            listOfPers.Sort(Person.ComparePersons);

            WriteLine("\nLista 2 - posortowana");
            foreach (Person p in listOfPers)
                WriteLine(p.ToString());
            

            listOfPers.Add(new Person("Ola", 22));
            listOfPers.Insert(2, new Person("Marek", 22));

            WriteLine("\nLista 3 - uzup. o 2 osoby");
            foreach (Person p in listOfPers)
                WriteLine(p.ToString());
            

            Person wit = new Person("Witold", 22);
            listOfPers.Add(wit);

            listOfPers.Sort(Person.MyReverse);

            WriteLine("\nLista 4 - uzup. o 1 osobę i posort. odwrotnie");
            foreach (Person p in listOfPers)
                WriteLine(p.ToString());
            
            WriteLine("\nBinarySearch");
            listOfPers.Sort(Person.ComparePersons);
            WriteLine(listOfPers.BinarySearch(new Person("Jola", 21)));

            WriteLine("\nFind");
            WriteLine(listOfPers.Find(p => p.Name == "Jola"));

            WriteLine("\nInsertRange");
            List<Person> others = new List<Person>(){new Person("Ala", 24), new Person("Iwa", 27)};
            listOfPers.InsertRange(6, others);
            foreach (Person p in listOfPers)
            {
                WriteLine(p.ToString());
            }

            WriteLine($"\nTyp: {listOfPers.GetType()}");
            WriteLine($"\nPojemność: {listOfPers.Capacity}");
            WriteLine($"\nLiczność: {listOfPers.Count}");
        }
    }
}
