using System.Collections.Generic;
using System.IO;

namespace List9ad2
{
    public class OutputTarget
    {
    

        public bool SendToFile(string filename, List<Student> students)
        {

            try
            {
                StreamWriter sw = new StreamWriter(filename);
                using (sw)
                {
                    foreach (Student student in students)
                    {
                        sw.WriteLine(student.Name + ";" + student.Surname + ";" + student.AlbumNr + ";" + student.Date.ToString("yyyy-MM-dd HH:mm:ss"));
                    }
                    sw.Flush();
                    sw.Close();
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
            


