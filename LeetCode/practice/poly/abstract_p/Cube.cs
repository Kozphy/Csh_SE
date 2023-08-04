using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.practice.poly.abstract_p
{
    internal class Cube : Shape
    {
        public double Length { get; set; }

        public Cube(string name, double length)
        {
            this.Name = name;
            Length = length;
        }

        public override double Volume()
        {
            throw new NotImplementedException();
        }
    }
}
