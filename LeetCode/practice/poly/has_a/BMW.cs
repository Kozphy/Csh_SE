using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.practice.poly.has_a
{
    internal class BMW : Car
    {
        private string brand = "BMW";
        public string Model { get; set; }
        public BMW(int hp, string color, string model)
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
