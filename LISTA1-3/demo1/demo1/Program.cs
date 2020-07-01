using System;
using System.Globalization;
using System.Text;


namespace demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            Console.WriteLine("Witaj Świecie!");
            DateTime localDate = DateTime.Now;
            String[] cultureNames = { "en-US", "en-GB", "pl-PL", "th-TH", "en-CA" };
            foreach(var cultureName in cultureNames)
            {
                var culture = new CultureInfo(cultureName);
                string ld = localDate.ToString(culture);
                Console.WriteLine(cultureName + "\t"+ ld);
            }
            Console.Read();
        }
    }
}
