using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.practice.Interface_p.Own_F
{
    internal class Furniture
    {
        public string Color { get; set; }
        public string Material { get; set; }

        public Furniture()
        {
            this.Color = "White";
            this.Material = "Wood";
        }

        public Furniture(string color, string material)
        {
            this.Color = "White";
            this.Material = "Wood";
        }

    }
}
