using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using static System.Console;

namespace List9ad1
{
    public class Student 
    {
   

        public string Name
        {
            get;
            set;
        }

        public string Surname
        {
            get;
            set;
        }

        public int AlbumNr
        {
            get;
            set;
        }

        public DateTime Date
        {
            get;
            set;
        }

        public Student(string name, string surname, int album_nr, DateTime date)
        {
            Name = name;
            Surname = surname;
            AlbumNr = album_nr;
            Date = date;
        }



        public static int CompareByName(Student s1, Student s2)
        {
            return s1.Name.CompareTo(s2.Name);
        }

        public static int CompareBySurame(Student s1, Student s2)
        {
            return s1.Surname.CompareTo(s2.Surname);
        }

        public static int CompareByAlbumNo(Student s1, Student s2)
        {
            return s1.AlbumNr.CompareTo(s2.AlbumNr);
        }

        public static int CompareByRegistrationDate(Student s1, Student s2)
        {
            return s1.Date.CompareTo(s2.Date);
        }

       
        public static void PrintArray<T>(IEnumerable<T> inputArray)
        {
            foreach (var item in inputArray)
                WriteLine(item);
        }


        public override string ToString()
        {
            return Name + " " + Surname + ", " + AlbumNr + " (" + Date + ")";
        }

      
    }
}
