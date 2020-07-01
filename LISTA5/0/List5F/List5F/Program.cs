using System;
using System.Text;
using static System.Console;

namespace List5F
{
    class Program
    {
        static void Main(string[] args)
        {
            OutputEncoding = Encoding.GetEncoding("UTF-8"); 
            string message1;
            string message2 = null;
            string message3 = String.Empty;
            string oldPath = "c:\\Dane\\ProjektyNET";
            string newPath = @"c:\Dane\ProjektyNET";            // literał wielowierszowy
            string greeting = @"Hello World! Witaj Świecie! Olá mundo!";

            var temp = "I’m still a strongly-typed System.String!"; 
            const string message4 = "You can’t get rid of me!";
            char[] letters = { 'A', 'B', 'C', '\u03b1', '\u03b2', '\u03b3' }; 
            string alphabet = new string(letters);
            char c;          
            //WriteLine("massage1: " + message1);	oczywisty błąd 
            WriteLine("massage2: " + message2);
            WriteLine("massage3: " + message3); 
            WriteLine("massage4: " + message4); 
            WriteLine("oldPath: " + oldPath); 
            WriteLine("newPath: " + newPath);
            WriteLine("greeting:\n" + greeting);
            WriteLine("temp: " + temp);
            WriteLine("alphabet: " + alphabet); //alphabet[1] = 'ą';
            alphabet = alphabet.Replace('B', 'ą');  // uwaga
            WriteLine("alphabet: " + alphabet);
            alphabet=alphabet.Replace('\u03b3', '\u03a0'); // uwaga
            WriteLine("alphabet: " + alphabet);
            WriteLine();
            WriteLine("Karol".Replace("ol", "olina")); 
            WriteLine("Wydawca".Substring(2, 5));
            WriteLine("Wydawca".Remove(2, 5));
            WriteLine("Dawca".Insert(5, "1A")); 
            WriteLine("dawca".ToUpper());
            c = "Język C# 7.2"[1];  // indekser
            WriteLine(c);
            ReadLine();

        }
    }
}
