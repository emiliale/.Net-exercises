//Emilia Lebiedowska 242473
using System;
using static System.Console;

namespace List6ad3
{
    class Program
    {
        static void Main(string[] args)
        {
            string menu= "default";

            while (menu != "")
            {
                WriteLine("Wpisz liczbę całkowitą dwucyfrową: ");

                menu = ReadLine();
                                
                if(menu != "")
                {
                    int number = 0;
                    try
                    {
                        number = int.Parse(menu);
                    }catch(Exception e)
                    {
                        Error.WriteLine("Zły format\n" + e.ToString());
                    }

                    if (number.ToString().Length != 2)
                    {
                        WriteLine("Liczba musi być dwucyfrowa");
                    }
                    else
                    {
                        string num="";
                        int wholeNumber = number;
                        int second = number % 10;
                        int first = number / 10;
                        switch (first)
                        {
                            case 1:
                                second = 0;
                                switch (wholeNumber)
                                {
                                    case 10:
                                        num += "dziesięć";
                                        break;
                                    case 11:
                                        num += "jedenaście";
                                        break;
                                    case 12:
                                        num += "dwanaście";
                                        break;
                                    case 13:
                                        num += "trzynaście";
                                        break;
                                    case 14:
                                        num += "czternaście";
                                        break;
                                    case 15:
                                        num += "piętnaście";
                                        break;
                                    case 16:
                                        num += "szesnaście";
                                        break;
                                    case 17:
                                        num += "siedamnaście";
                                        break;
                                    case 18:
                                        num += "osiemnaście";
                                        break;
                                    case 19:
                                        num += "dziewiętnajście";
                                        break;
                                }
                                break;
                            case 2:
                                num += "dwadzieścia";
                                break;
                            case 3:
                                num += "trzydzieści";
                                break;
                            case 4:
                                num += "czterdzieści";
                                break;
                            case 5:
                                num += "pięćdziesiąt";
                                break;
                            case 6:
                                num += "sześćdziesiąt";
                                break;
                            case 7:
                                num += "siedemdziesiąt";
                                break;
                            case 8:
                                num += "osiemdziesiąt";
                                break;
                            case 9:
                                num += "dziewięćdziesiąt";
                                break;
                        }
                        switch (second)
                        {
                            case 1:
                                num += " jeden";
                                break;
                            case 2:
                                num += " dwa";
                                break;
                            case 3:
                                num += " trzy";
                                break;
                            case 4:
                                num += " cztery";
                                break;
                            case 5:
                                num += " pięć";
                                break;
                            case 6:
                                num += " sześć";
                                break;
                            case 7:
                                num += " siedem";
                                break;
                            case 8:
                                num += " osiem";
                                break;
                            case 9:
                                num += " dziewięć";
                                break;
                        }
                        WriteLine(num + "\n");
                    }
                 } 
                else
                {
                    break;
                }
            }
        }
    }
}
