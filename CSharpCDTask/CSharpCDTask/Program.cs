using System;

namespace CSharpCDTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            int namesCount = 3, n = 0;
            Person[] people = new Person[namesCount];
            string[] digits = { "First", "Second","Third" };

            Console.WriteLine("*******Input*******");
            Console.WriteLine("You can enter the three names:-");
            for (n = 0; n < namesCount; n++)
            {
                Console.Write(String.Format($"Enter {digits[n]} name:"));
                people[n] = new Person(Console.ReadLine());
            }

            Console.WriteLine("*******Output*******");
            for (n = 0; n < namesCount; n++)
            {
                Console.Write(String.Format($"\n{digits[n]} name is : {people[n].ToString()}"));
            }

            Console.WriteLine("\n\n");
        }
    }
    public class Person
    {
        public string name { get; set; }

        public Person(string _name)
        {
            name = _name;
        }

        public override string ToString()
        {
            return String.Format($" {name}");
        }

        ~Person()
        {
            name = string.Empty;
        }
    }
}
