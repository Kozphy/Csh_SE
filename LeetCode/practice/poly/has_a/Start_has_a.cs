using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.practice.poly.has_a
{
    internal class Start_has_a
    {
        public void Start() 
        {
            Car car1 = new BMW(10, "red1", "mobi");
            car1.SetCarIDInfo(0, "Bob");
            car1.GetCarIDInfo();
        }
    }
}
