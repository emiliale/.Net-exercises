//Emilia Lebiedowska 242473
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Console;

namespace List11bad0a
{
    class Program
    {
        static void Main()
        {
            Write("Podaj liczbę adresów: ");
            int urlsNumber = 0;

            try
            {
                string urlNum = ReadLine();
                urlsNumber = Int32.Parse(urlNum);
                if (urlsNumber < 0)
                {
                    WriteLine("Liczba musi być większa od zera");
                    System.Environment.Exit(1);
                }
                
            }catch(Exception e)
            {
                WriteLine("Błędna liczba");
            }
            
                string[] urls = new string[urlsNumber];
                string[] filenames = new string[urlsNumber];
                string[] letters = new string[urlsNumber];

                for (int i = 0; i < urlsNumber; i++)
                {
                    Write("Podaj adres {0}: ", i + 1);
                    urls[i] = ReadLine();
                }

                for (int i = 0; i < urlsNumber; i++)
                {
                    Write("Podaj nazwę pliku {0} do którego zapisać dane: ", i + 1);
                    filenames[i] = ReadLine();
                }

                for (int i = 0; i < urlsNumber; i++)
                {
                    Write("Podaj słowo {0} do wyszukania: ", i + 1);
                    letters[i] = ReadLine();
                }

                var contents = new List<Task<string>>();
                for (int i = 0; i < urlsNumber; i++)
                {
                    contents.Add(Download(urls[i]));
                }

                WriteLine("Pobieranie...");

                Task.WhenAll(contents).ContinueWith(async contentsTasks =>
                {
                    WriteLine("Pobrano pomyślnie");

                    for (int i = 0; i < urlsNumber; i++)
                    {
                       WriteToFile(filenames[i], contentsTasks.Result[i]).ContinueWith(_ =>
                        {
                            var matches = Regex.Matches(contentsTasks.Result[i], letters[i]).Count;

                            WriteLine("{0}:", urls[i]);
                            WriteLine("\tPobrano {0} bajtów", System.Text.Encoding.Unicode.GetByteCount(contentsTasks.Result[i]));
                            WriteLine("\tZnaleziono {0} wystąpień słowa {1}", matches, letters[i]);
                        }).Wait();
                    }
                }).Wait();
        }

        private static async Task<string> Download(string url)
        {
            WebRequest request = WebRequest.Create(url);
            WebResponse response = await request.GetResponseAsync();

            using (Stream dataStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                return responseFromServer;
            }
        }

        private static async Task WriteToFile(string filename, string content)
        {
            using (StreamWriter sw = new StreamWriter(filename))
            {
                await sw.WriteAsync(content);
                sw.Flush();
                sw.Close();
            }
        }
    }
}
