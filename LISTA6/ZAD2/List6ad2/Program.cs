//Emilia Lebiedowska 242473
using System;
using static System.Console;

namespace List6ad2
{
    class Program
    {
        static void Main(string[] args)
        {
            string repeat = "default";


            while (repeat!="")
            {
                bool check = true;
                while (check)
                {
                    check = false;
                    Write("Wpisz liczbę dodatnia : ");

                    repeat = ReadLine();

                    if (repeat == "") break;
                    int number = 0;
                    try
                    {
                        number = int.Parse(repeat);
                    }
                    catch (Exception e)
                    {
                        Error.WriteLine("Zły format\n" + e.ToString());
                        check = true;
                    }

                    if ((number >= 0)&&(check==false))
                    {
                        bool correct = false;
                        do
                        {
                            Write("Wprowadź pozycję: ");
                            if (int.TryParse(ReadLine(), out int i) && i >= 0 && i < 8 * sizeof(int))
                            {
                                correct = true;
                                WriteLine($"Reprezentacja bitowa: {Convert.ToString(number, toBase: 2)}");
                                bool result = ((number >> i) & 1) == 1;
                                WriteLine("Wynik: {0}", result ? "1" : "0");
                            }
                            else
                            {
                                WriteLine("Zły format\n");
                            }
                        } while (!correct);
                    }
                    else
                    {
                        WriteLine("Zły format\n");
                    }
                }
            }
        }
    }
}
