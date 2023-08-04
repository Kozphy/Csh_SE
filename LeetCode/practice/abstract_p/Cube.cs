using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.practice.abstract_p
{
    internal class Cube : Shape
    {
        public double Length { get; set; }

        public Cube(double length)
        {
            Name = "Cube";
            Length = length;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"The Length of {this.Name} is {this.Length}");
        }

        public override double Volume()
        {
            return Math.Pow(Length, 3);
        }
    }
}
