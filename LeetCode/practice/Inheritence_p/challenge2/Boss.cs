using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.practice.Inheritence_p.challenge2
{
    internal class Boss:Employee
    {
        public string CompanyCar { get; set; }

        public Boss() { }

        public Boss(string name, string firstName, string salary,string companyCar) { 
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
            this.CompanyCar = companyCar;
        }
        public void Lead() {
            Console.WriteLine("Boss leading.");
        }
    }
}
