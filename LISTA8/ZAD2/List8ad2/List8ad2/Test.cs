//Emilia Lebiedowska 242473
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using static System.Console;

namespace List8ad2
{
    class Test
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            try
            {
                using (StreamReader sr = new StreamReader("students.txt"))
                {
                    foreach (string line in sr.ReadToEnd().Split('\n'))
                    {
                        if (line != "")
                        {
                            string[] values = line.Split(';');
                            students.Add(new Student(
                                values[0].Trim(),
                                values[1].Trim(),
                                int.Parse(values[2].Trim()),
                                DateTime.ParseExact(values[3].Trim(), "yyyy-MM-dd HH:mm", new CultureInfo("pl-PL")
                            )));
                        }
                    }
                }

                WriteLine("Wczytano studentów");

                while (true)
                {
                    Write("1. Rejestracja studenta\n2. Wyśweitlenie studenta\n");
                    string command = ReadLine();

                    if (command == "1")
                    {
                        Write("Imię: ");
                        string name = ReadLine();

                        Write("Nazwisko: ");
                        string surname = ReadLine();

                        int album_nr;
                        bool loop = true;

                        do
                        {
                            Write("Nr albumu: ");

                            if (int.TryParse(ReadLine(), out album_nr))
                            {
                                loop = false;
                            }
                            else
                            {
                                WriteLine("błąd: Nieprawidłowy nr albumu");
                            }
                        } while (loop);

                        loop = true;

                        DateTime registrationDate = DateTime.Now;

                        students.Add(new Student(name, surname, album_nr, registrationDate));
                    }
                    else if (command == "2")
                    {
                        bool write = true;

                        do
                        {
                            Write("Sortowanie według:\n1. Imienia\n2. Nazwiska\n3. Albumu\n4. Daty\n ");

                            string sorting = ReadLine();

                            switch (sorting)
                            {
                                case "1":
                                    students.Sort(Student.CompareByName);
                                    break;
                                case "2":
                                    students.Sort(Student.CompareBySurame);
                                    break;
                                case "3":
                                    students.Sort(Student.CompareByAlbumNo);
                                    break;
                                case "4":
                                    students.Sort(Student.CompareByRegistrationDate);
                                    break;
                                default:
                                    WriteLine("Błąd: nieprawidłowa komenda");
                                    write = false;
                                    break;
                            }

                            if (write)
                            {
                                foreach (Student s in students)
                                {
                                    WriteLine(s);
                                }
                            }
                        } while (!write);
                    }
                    else
                    {
                        WriteLine("Błąd: nieprawidłowa komenda");
                    }
                }
            }
            catch (IOException e)
            {
                WriteLine("Błąd: " + e.Message);
            }
        }
    }
}
