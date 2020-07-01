using System;
using System.Collections.Generic;
using System.Text;

namespace List8ad2
{
    class Student
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

        public DateTime RegistrationDate
        {
            get;
            set;
        }

        public Student(string name, string surname, int album_no, DateTime registrationDate)
        {
            Name = name;
            Surname = surname;
            AlbumNr = album_no;
            RegistrationDate = registrationDate;
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
            return s1.RegistrationDate.CompareTo(s2.RegistrationDate);
        }

        public override string ToString()
        {
            return Name + " " + Surname + ", " + AlbumNr + " (" + RegistrationDate + ")";
        }
    }
}
