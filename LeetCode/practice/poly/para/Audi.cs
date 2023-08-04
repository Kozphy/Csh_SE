using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.practice.poly.para
{
    internal class Audi : Car
    {
        private string brand = "Audi";
        public string Model { get; set; }
        public Audi(int hp, string color, string model):base(hp, color)
        {
            this.Model = model;
        }

        // new keyword means: if you create new object of me, then override parent function
        public new void ShowDetails()
        {
            Console.WriteLine("Brand: " + brand + "HP: " + HP + "Color: " + Color);
        }
        public override void Repair()
        {
            Console.WriteLine($"Model {Model} was repaired");
        }
    }
}
