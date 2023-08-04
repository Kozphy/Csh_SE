using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.practice.abstract_p
{
    internal class abstract_demo
    {
        public static void Start()
        {
            abstract_demo Abs_demo = new abstract_demo();
            Abs_demo.Get_AbstractShape();
        }

        private void Get_AbstractShape()
        {

            Shape[] shapes = new Shape[] {
                new Sphere(4),
                new Cube(3)
            };

            foreach (Shape shape in shapes)
            {
                shape.GetInfo();
                Console.WriteLine("{0} has a volume of {1}", shape.Name, shape.Volume());
            }
        }

    }
}
