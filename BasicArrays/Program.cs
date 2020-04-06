using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string monday = "Monday";
            string[] daysOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            daysOfWeek[5] = "PartyDay";
            foreach (string days in daysOfWeek)
            {
                Console.WriteLine(days);
            }

            Console.WriteLine("Type in index of day to look up :>");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine(daysOfWeek[day]);

            int[] squares = { 1, 4, 9, 16, 25 };


            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < daysOfWeek.Length; i++)
            {
                stringBuilder.Append(daysOfWeek[i]);
                if(i<daysOfWeek.Length-2)
                    stringBuilder.Append(", ");
                else if (i == daysOfWeek.Length - 2)
                    stringBuilder.Append(" and ");
            }
            Console.WriteLine(stringBuilder.ToString());

            MakeDaysPlural(daysOfWeek);
            foreach (string days in daysOfWeek)
            {
                Console.WriteLine(days);
            }

            Person[] people = new[]
            {
                new Person{Name="Bill",Age=7},
                new Person{Name="Ben",Age=8}
            };

            foreach (Person person in people)
            {
                person.Age = 28;
            }

            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }

            Console.ReadKey();
        }

        static void MakeDaysPlural(string[] daysOfWeek)
        {
            for (int i = 0; i < daysOfWeek.Length; i++)
            {
                daysOfWeek[i] = daysOfWeek[i] + "s";
            }
        }

        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public override string ToString()
            {
                return string.Format("{0}, age={1}", Name, Age);
            }
        }
    }
}
