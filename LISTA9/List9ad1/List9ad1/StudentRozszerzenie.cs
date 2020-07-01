using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace List9ad1
{
    public static class StudentExtension
    {
        public static int CountSur(this Student student, List<Student> students)
        {
            int result = 0;

            foreach (Student s in students)
            {
                if (s.Surname == student.Surname)
                {
                    result++;
                }
            }

            return result;
        }

        public static int CountDates(this Student student, List<Student> students)
        {
            int result = 0;

            foreach (Student s in students)
            {
                string d = s.Date.ToString("yyyy-MM-dd HH:mm");
                DateTime date = DateTime.ParseExact(d, "yyyy-MM-dd HH:mm",
                                   CultureInfo.InvariantCulture);
                string d2 = student.Date.ToString("yyyy-MM-dd HH:mm");
                DateTime date2 = DateTime.ParseExact(d2, "yyyy-MM-dd HH:mm",
                                   CultureInfo.InvariantCulture);
                if (d == d2)
                {
                    result++;
                }
            }

            return result;
        }
    }
}
