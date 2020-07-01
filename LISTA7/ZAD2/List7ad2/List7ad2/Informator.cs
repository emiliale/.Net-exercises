//Emilia Lebiedowska 242473
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace List7ad2
{
    class Informator
    {
        
        DateTime now = DateTime.Now;
        DateTime wprowadzona;
        ConsoleKeyInfo cki;
        List<List<DateTime>> loty = new List<List<DateTime>> ();
        List<DateTime> przyloty = new List<DateTime>();
        List<DateTime> wyloty = new List<DateTime>();


        public ConsoleKeyInfo GetCki()
        {
            return cki;
        }

        public void SetCki(ConsoleKeyInfo cki)
        {
            this.cki = cki;
        }

        public DateTime GetWprowadzona()
        {
            return wprowadzona;
        }

        public void SetWprowadzona(DateTime wprowadzona)
        {
            this.wprowadzona = wprowadzona;
        }

        public void FillLoty()
        {
            przyloty.Add(new DateTime(now.Year, now.Month, now.Day, 8, 15, 0));
            przyloty.Add(new DateTime(now.Year, now.Month, now.Day, 9, 43, 0));
            przyloty.Add(new DateTime(now.Year, now.Month, now.Day, 11, 19, 0));
            przyloty.Add(new DateTime(now.Year, now.Month, now.Day, 12, 47, 0));
            przyloty.Add(new DateTime(now.Year, now.Month, now.Day, 14, 0, 0));
            przyloty.Add(new DateTime(now.Year, now.Month, now.Day, 15, 45, 0));
            przyloty.Add(new DateTime(now.Year, now.Month, now.Day, 19, 00, 0));
            przyloty.Add(new DateTime(now.Year, now.Month, now.Day, 21, 45, 0));
            przyloty.Add(new DateTime(now.Year, now.Month, now.Day, 22, 50, 0));
            przyloty.Add(new DateTime(now.Year, now.Month, now.Day, 23, 45, 0));
            wyloty.Add(new DateTime(now.Year, now.Month, now.Day, 10, 16, 0));
            wyloty.Add(new DateTime(now.Year, now.Month, now.Day, 11, 52, 0));
            wyloty.Add(new DateTime(now.Year, now.Month, now.Day, 13, 31, 0));
            wyloty.Add(new DateTime(now.Year, now.Month, now.Day, 15, 00, 0));
            wyloty.Add(new DateTime(now.Year, now.Month, now.Day, 16, 08, 0));
            wyloty.Add(new DateTime(now.Year, now.Month, now.Day, 17, 55, 0));
            wyloty.Add(new DateTime(now.Year, now.Month, now.Day, 21, 27, 0));
            wyloty.Add(new DateTime(now.Year, now.Month, now.Day, 23, 58, 0));
            wyloty.Add(new DateTime(now.Year, now.Month, now.Day + 1, 1, 55, 0));
            wyloty.Add(new DateTime(now.Year, now.Month, now.Day + 1, 2, 50, 0));
            loty.Add(przyloty);
            loty.Add(wyloty);
        }

        public bool AddFligth()
        {
            bool ok = true;
            DateTime wy = DateTime.Now;
            DateTime przy = DateTime.Now;
            try
            {

                Write("Wylot: ");
                string dataStr = ReadLine();
                string wpr = now.Year.ToString() + "." + now.Month.ToString() + "." + now.Day.ToString() + " " + dataStr + ":00";
                string format = "yyyy.MM.d HH:mm:ss";
                wy = (DateTime.ParseExact(wpr,format, null));
            }
            catch (Exception e)
            {
                WriteLine("Zły format daty");
                ok = false;
            }
            try
            {

                Write("Przylot: ");
                string dataStr = ReadLine();
                string wpr = now.Year.ToString() + "." + now.Month.ToString() + "." + now.Day.ToString() + " " + dataStr + ":00";
                string format = "yyyy.MM.dd HH:mm:ss";
                przy = (DateTime.ParseExact(wpr, format, null));
            }
            catch (Exception e)
            {
                WriteLine("Zły format daty");
                ok = false;
            }
            przyloty.Add(wy);
            wyloty.Add(przy);
            loty.Clear();
            loty.Add(przyloty);
            loty.Add(wyloty);
         
            return ok;
         }


        public bool GetDate()
        {
            bool ok=true;
            try
            {
                
                Write("Początek podróży(hh:mm): ");
                SetCki(ReadKey());
                if (GetCki().Key != ConsoleKey.Escape)
                {
                    char x = GetCki().KeyChar;
                    string dataStr = ReadLine();
                    string wpr = now.Year.ToString() + "." + now.Month.ToString() + "." + now.Day.ToString() + " " + x + dataStr + ":00";
                    string format = "yyyy.MM.dd HH:mm:ss";
                    SetWprowadzona(DateTime.ParseExact(wpr, format, null));
                }
                
            }
            catch(Exception e)
            {
                ok = false;
                WriteLine("Zły format daty");
            }
            return ok;
        }

        public void FindFlight()
        {

            TimeSpan min = new DateTime(now.Year + 1, now.Month, now.Day, 8, 15, 0) - now;



            if (loty[0][0]> wprowadzona)
            {
                min = loty[0][0] - wprowadzona;

            }

            int imin = 0;
            TimeSpan roznica = min;

            for (int i = 0; i < loty[0].Count; i++)
            {

                if (loty[0][i] > wprowadzona)
                {
                    roznica = loty[0][i] - wprowadzona;

                }

                if (roznica < min)
                {
                    min = roznica;
                    imin = i;
                }
            }

            if (loty[0][imin].Hour < wprowadzona.Hour)
            {
                loty[0][imin] = loty[0][imin].AddDays(1);
                loty[1][imin] = loty[1][imin].AddDays(1);
                string wylot = "Wylot:" + loty[0][imin].ToString("HH:mm") + "(" + loty[0][imin].ToString("dd.MM") + ")";
                string przylot = "Przylot:" + loty[1][imin].ToString("HH:mm") + "(" + loty[1][imin].ToString("dd.MM") + ")";
                WriteLine("{0, 5} {1,20}\n", wylot, przylot);
            }
            else
            {
                string wylot = "Wylot:" + loty[0][imin].ToString("HH:mm");
                string przylot = "Przylot:" + loty[1][imin].ToString("HH:mm");
                WriteLine("{0, -5} {1,20}\n", wylot, przylot);
            }

        }






    }
}
