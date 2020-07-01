// Emilia Lebiedowska 242473
using System;
using System.Text;
using static System.Console;

namespace List5ad3
{
    class Program
    {

        static void Main(string[] args)
        {

            OutputEncoding = Encoding.UTF8;
            // Create a UTF-8 encoding that supports a BOM.
           // Encoding utf8 = new UTF8Encoding(true);

            // Create a UTF-16 encoding that supports a BOM
             Encoding unicode = new UnicodeEncoding();

            String unicodeString = "\u0105, \u0107, \u0119, \u0142, \u0144, \u00F3, \u015B, \u017A, \u017C, \u0104, \u0106, \u0118 ,\u0141, \u0143, \u00D3, \u015A, \u0179, \u017B, \u0283, \u263A";

            WriteLine(unicodeString);

        }
    }
}
