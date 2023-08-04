using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.practice.Interface_p.Own_F
{
    internal class Chair : Furniture, IDestoryable
    {
        public Chair(string color, string material)
        { 
            this.Color = color;
            this.Material = material;
            this.DestructionSound = "ChairDestructionSound.mp3";
        }

        public string DestructionSound { get ; set; }

        public void Destory()
        {
            Console.WriteLine($"The {Color} chair was destoryed");
            Console.WriteLine("Playing Destruction sound {0}", DestructionSound);
            Console.WriteLine("Spawning chair parts");
        }
    }
}
