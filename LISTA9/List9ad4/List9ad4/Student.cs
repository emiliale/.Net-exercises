using System;
using System.Collections.Generic;
using System.Text;

namespace List9ad4
{
    class Student
    {
        private String imie;
        private String nazwisko;
        private int nrAlbumu;



        public Student(String imie, String nazwisko, int nrAlbumu)
        {
            this.imie = imie; 
            this.nazwisko = nazwisko;
            this.nrAlbumu = nrAlbumu;

        }

        public override string ToString()
        {
            return $"{imie} {nazwisko} {nrAlbumu}";
        }


    }
}
