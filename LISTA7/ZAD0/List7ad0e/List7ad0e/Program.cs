using System;
using static System.Console;

namespace List7ad0e
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Wprowadź datę[czas] (dd.mm.rrrr[ hh:mm:ss]): "); 
            string dataStr = ReadLine();

            DateTime data = DateTime.Parse(dataStr);

            WriteLine("\nWprowadziłeś: {0:d}", data); // różne formaty wyprow. 
            WriteLine("Wprowadziłeś: {0:D}", data);
            WriteLine("Wprowadziłeś: {0:F}", data); 
            WriteLine("Wprowadziłeś: {0:G}", data); 
            WriteLine("Wprowadziłeś: {0:R}", data); 
            WriteLine("Wprowadziłeś: {0}", data.ToString());
            data = data.AddDays(2); // modyf. dnia
            data = data.AddYears(1);	// modyf. roku 
            WriteLine("Data zmodyfikowana : {0:G}", data); 
            WriteLine("Data zmodyfikowana : {0:R}", data);

        }
    }
}
