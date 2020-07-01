using System;
using System.Collections.Generic;
using System.Text;

namespace List9ad2
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

        public Student(string name, string surname, int album_nr, DateTime registrationDate)
        {
            Name = name;
            Surname = surname;
            AlbumNr = album_nr;
            Date = registrationDate;
        }

        public Student()
        {
        }

        public static int CompareByName(Student s1, Student s2)=>s1.Name.CompareTo(s2.Name);
        

        public static int CompareBySurame(Student s1, Student s2)=>s1.Surname.CompareTo(s2.Surname);
        

        public static int CompareByAlbumNr(Student s1, Student s2)=>s1.AlbumNr.CompareTo(s2.AlbumNr);
        

        public static int CompareByRegistrationDate(Student s1, Student s2)=> s1.Date.CompareTo(s2.Date);


        public static int CompareBySurnameNameAlbumNr(Student s1, Student s2)
        {
            int surnameCompare = s1.Surname.CompareTo(s2.Surname);
            if (surnameCompare == 0)
            {
                int nameCompare = s1.Name.CompareTo(s2.Name);
                if (nameCompare == 0)
                {
                    int registrationDateCompare = s1.Date.CompareTo(s2.Date);
                    return registrationDateCompare;
                }
                return nameCompare;
            }
            return surnameCompare;
        }


        public override string ToString()
        {
            return Name + " " + Surname + ", " + AlbumNr + " (" + Date + ")";
        }
    }
}
