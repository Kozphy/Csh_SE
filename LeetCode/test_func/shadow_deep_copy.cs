using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Cache;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.test_func
{
    public class shadow_deep_copy
    {

        public static void Start()
        {
            Person ps1 = new Person(25, "david", 0);

            // Perform a shallow copy of p1 and assign it to p2
            Person ps2 = ps1.ShallowCopy();

            // Display values of p1, p2
            Console.WriteLine("Original values of p1 and p2:");
            Console.WriteLine(" p1 instance value: ");
            Person.DisplayValues(ps1);
            Console.WriteLine(" p2 instance value: ");
            Person.DisplayValues(ps2);

            Console.WriteLine("Change ps1 property for shallow copy");
            ps1.Age = 30;
            ps1.Name = "fdsajkl";
            ps1.IdInfo.Idnumber = 9999;
            Console.WriteLine(" p1 instance value: ");
            Person.DisplayValues(ps1);
            Console.WriteLine(" p2 instance value: ");
            Person.DisplayValues(ps2);

            Console.WriteLine("Make a deep copy of p1 and assign it to p3");
            Person p3 = ps1.DeepCopy();
            ps1.Age = 40;
            ps1.Name = "aaaaaa";
            ps1.IdInfo.Idnumber = 111111111;
            Console.WriteLine(" p1 instance value: ");
            Person.DisplayValues(ps1);
            Console.WriteLine(" p3 instance value: ");
            Person.DisplayValues(p3);
            
        }

    }
    public class IdInfo
    {
        private int IdNumber;

        public int Idnumber{
            get => this.IdNumber;
            set => this.IdNumber = value;
        }

        public IdInfo(int IdNumber)
        {
            this.IdNumber = IdNumber;
        }
    }

    public class Person
    {
        private int age;
        private string name;
        private IdInfo idInfo;

        public int Age
        {
            get { return this.age; }
            set =>  this.age = value; 
        }

        public string Name
        {
            get { return this.name; }
            set => this.name = value;
        }

        public IdInfo IdInfo
        {
            get { return this.idInfo; }
            set => this.idInfo = value;
        }

        public Person(int age, string name, int idinfo)
        {
            this.age = age;
            this.name = name;
            this.idInfo = new IdInfo(idinfo);
        }

        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person other = (Person)this.MemberwiseClone();
            other.idInfo = new IdInfo(idInfo.Idnumber);
            other.name = String.Copy(name);
            return other;
        }
        public static void DisplayValues(Person p)
        {
            Console.WriteLine("      Name: {0:s}, Age: {1:d}", p.name, p.age);
            Console.WriteLine("      Value: {0:d}", p.idInfo.Idnumber);
        }

    }

}
