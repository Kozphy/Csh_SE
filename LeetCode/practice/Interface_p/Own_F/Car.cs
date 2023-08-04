using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.practice.Interface_p.Own_F
{
    internal class Car: IDestoryable
    {
        public float Speed { get; set; }
        public string Color { get; set; }
        public string DestructionSound{ get; set;}

        // creating a new property to store the destroyable object nearby
        // when a car gets destoryed it should also destory the nearby object
        // this list is of type IDestoryable which means it can store any object
        // that implements this interface and we can only access the properties and
        // methods in this interface.
        public List<IDestoryable> DestoryablesNearby;
        public Car(float speed, string color) 
        { 
            this.Speed = speed;
            this.Color = color;
            this.DestructionSound = "CarExplosionSound.mp3";
            this.DestoryablesNearby = new List<IDestoryable>();
        }

        public void Destory() {
            Console.WriteLine("Playing destruction sound {0}", DestructionSound);
            Console.WriteLine("Create Fire.");
            foreach(IDestoryable destoryable in DestoryablesNearby)
            {
                destoryable.Destory();
            }
        }
    }
}
