using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.practice.poly.has_a
{
    internal class Audi : Car
    {
        private string brand = "Audi";
        public string Model { get; set; }
        public Audi(int hp, string color, string model)
        {
            HP = hp;
            Color = color;
            Model = model;
        }

        public void ShowDetails()
        {
            Console.WriteLine("Brand: " + brand + "HP: " + HP + "Color: " + Color);
        }
        public void Repair()
        {
            Console.WriteLine($"Model {Model} was repaired");
        }
    }
}
