using System;
using System.Text.RegularExpressions;

namespace TaskFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Egor", 18);
            Console.WriteLine($"Person : {person.IsValid()}");

            Person person1 = new Person("egor", 17);
            Console.WriteLine($"Person1 : {person1.IsValid()}");

            Person person2 = new Person("Егор", 18);
            Console.WriteLine($"Person2 : {person2.IsValid()}");

            Person person3 = new Person("Egor", 0);
            Console.WriteLine($"Person3 : {person3.IsValid()}");
        }


    }

    public class MyAttribute : System.Attribute
    {
        public string AgePattern { get; set; }
        public string NamePattern { get; set; }

        public MyAttribute(string agePattern, string namePattern)
        {
            AgePattern = agePattern;
            NamePattern = namePattern;
        }
    }

    [MyAttribute(@"^[1-9]\d*$", @"^[A-Z][A-Za-z].*")]
    public class Person
    {
        private string Name { get; set; }
        private int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public bool IsValid()
        {
            Type type = this.GetType();
            
            object[] attrs = type.GetCustomAttributes(false);
            foreach (MyAttribute attr in attrs)
            {
                if(Regex.IsMatch(this.Age.ToString(), attr.AgePattern) && Regex.IsMatch(this.Name, attr.NamePattern))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
