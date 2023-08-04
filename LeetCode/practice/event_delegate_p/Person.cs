using System;

namespace ConsoleApp2.practice.event_delegate_p
{

    // defining a delegate type called FilterDelegate that take person object 
    // and return bool.
    public delegate bool FilterDelegate(Person p);

    public class Person
    {
        // name property
        private string? _name;
        private int _age;

         static Person p1 = new Person() { Name = "Aiden", Age = 41 };
         static Person p2 = new Person() { Name = "Sif", Age = 69 };
         static Person p3 = new Person() { Name = "Walter", Age = 12 };
         static Person p4 = new Person() { Name = "Anatoli", Age = 25 };
         List<Person>? people;


        public string Name
        {
            get => _name;
            set => _name = value;
        }

        // age property
        public int Age
        {
            get => _age;
            set => _age = value;
        }
        public static void Person_delegate()
        {

            List<Person> people = new List<Person> { p1, p2, p3, p4 };
            DisplayPeople("Kids",   people, IsMinor);
            DisplayPeople("Adult", people, IsAdult);
            DisplayPeople("Senior", people, IsSenior);

        }

        public static void Anonymous_method()
        {

            List<Person> people = new List<Person> { p1, p2, p3, p4 };
            FilterDelegate filter = (Person p) =>
            {
                return p.Age >=20 && p.Age <=30;   
            };
            DisplayPeople("Between 20 and 30", people, filter);
            System.Console.WriteLine();
            DisplayPeople("All: ", people, (Person p) => {return true;});
        }

        static void DisplayPeople(string title,  List<Person> people, FilterDelegate filter)
        {
            System.Console.WriteLine(title);

            foreach (Person p in people)
            {
                if (filter(p))
                {
                    System.Console.WriteLine($"{p.Name},{p.Age} years old.");
                }
            }
        }

        // ====Filter====
        static bool IsMinor(Person p)
        {
            return p.Age < 18;
        }

        static bool IsAdult(Person p)
        {
            return p.Age >= 18;
        }

        static bool IsSenior(Person p)
        {
            return p.Age >= 65;
        }
    }


}