using System;
using System.Collections.Generic;
using System.Text;

namespace List8ad3
{
    class Person : IComparable<Person>
    {
        public string Name
        {
            get; set;
        }

        public int Age
        {
            get; set;
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public static int ComparePersons(Person p1, Person p2)
        {
            if (p1.Name == p2.Name)
            {
                return p1.Age.CompareTo(p2.Age);
            }
            else
            {
                return p1.Name.CompareTo(p2.Name);
            }
        }

        public static int MyReverse(Person p1, Person p2)
        {
            return ComparePersons(p2, p1);
        }

        public override string ToString()
        {
            return Name.ToString() + ",\t" + Age.ToString();
        }

        public int CompareTo(Person other)
        {
            return ComparePersons(this, other);
        }
    }
}
