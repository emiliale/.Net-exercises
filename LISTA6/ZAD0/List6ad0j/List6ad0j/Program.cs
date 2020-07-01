using System;
using static System.Console;

namespace List6ad0j
{
    public class Person
    {
        private string v1;
        private string v2;

        public Person(string v1, string v2)	// konstruktor
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public string FirstName
        {
            get
            {
                return v1;
            }
            set
            {
                v1 = value;
            }
        }

        public string LastName
        {
            get
            {
                return v2;
            }
            set
            {
                v2 = value;
            }
        }


        public class Program
        {
            private static void Main(string[] args)
            {
                // klasyczne zastosowanie operatora is 
                int i = 100;
                if (i is object)
                {
                    WriteLine($"i to typ object");
                }

                // C# 7 - demo1
                i = 13;
                if (i is 13)
                {
                    WriteLine($"i ma wartość 13");
                }
                // demo2
                object o = null;
                if (o is null)
                {
                    WriteLine($"o jest null");
                }
                // demo3
                MethodPattMaching(new Person("Adam", "Abacki"));
            }
            public static void MethodPattMaching(object o)
            {
                if (o is Person p)
                {
                    WriteLine($"o to Person o imieniu: {p.FirstName}");
                }

            }
        }
    }
}



