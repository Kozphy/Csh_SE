using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.practice.Inheritence_p.challenge2
{
    internal class Employee
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string Salary { get; set; }

        public Employee() { }
        public Employee(string name, string firstName, string salary) { 
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
        }
        public virtual void Work() { }
        public void Pause() { }


    }
}
