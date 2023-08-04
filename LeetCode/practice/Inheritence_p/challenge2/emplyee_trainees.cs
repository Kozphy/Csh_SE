using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.practice.Inheritence_p.challenge2
{
    internal class emplyee_trainees:Employee
    {
        public int WorkingHours { get; set; }
        public int SchoolHours { get; set; }
        public emplyee_trainees() { }

        public emplyee_trainees(string name, string firstName, string salary, int workinghours, int schoolhours) { 
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
            this.WorkingHours = workinghours;
            this.SchoolHours = schoolhours;
        }

        public void Learn() { 
        }

        public override void Work()
        {
            Console.WriteLine($"WorkingHours:{WorkingHours}");
        }

    }
}
