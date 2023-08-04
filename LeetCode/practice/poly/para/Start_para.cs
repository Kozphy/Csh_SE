using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.practice.poly.para
{
    internal class Start_para
    {
        public static void Start() 
        {
            var cars = new List<Car>
            {
                new Audi(200,"Blue", "A4"),
                new BMW(250, "red", "M3")
            };

            foreach (var car in cars) {
                car.Repair();
            }

            Car bmwZ3 = new BMW(200, "black", "23");
            Car audiA3 = new Audi(100, "green", "A3");

            bmwZ3.ShowDetails();
            audiA3.ShowDetails();

            // active new keyword, overide parent method
            BMW bmwM5 = new BMW(330, "white", "M5");
            bmwM5.ShowDetails();

            Car carB = (Car)bmwM5;

            carB.ShowDetails();

            Console.ReadKey();
        }
    }
}
