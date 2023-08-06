using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab0523_NewKeyword
{
    internal class Demo
    {
        public class Car
        {
            public Car() { }
            public void Apple()
            {
                Console.WriteLine("我是Car爸爸的蘋果");
            }
        }

        class Window { 
            int count = 0;
        }

        public class Bus : Car
        {
            public Bus() { }
            public new void Apple()
            {
                Console.WriteLine("我是Bus兒子的蘋果");
            }
        }

        // interface
        // interface only do definition
        // student(class) = study(interface) + exam(interface)
        interface IStudy
        {
            void startStudy();
        };
        interface IExam
        {
            void startExam();
        }

        class Student : IStudy, IExam
        {
            public void startStudy() { }
            public void startExam() { }
        }

    }
}
