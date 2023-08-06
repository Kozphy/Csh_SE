using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab0512
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string_ref_value();
            //convert_type();
            //P12_ref();
            //P13_out();
            //P14_dynamic();
            DemoCar car = new DemoCar();
            DemoCar.PuiPui();
            //StackTrace st = new StackTrace(true);
            //Console.WriteLine(st.FrameCount);
            //for (int i =0;i < st.FrameCount; i++) {
            //    Console.WriteLine(st.GetFrame(i));
            //}
            //Console.WriteLine(st.GetFrame(0).GetFileName());
            //int line = st.GetFrame(0).GetFileLineNumber();
            //Console.WriteLine(line);
            Book book = new Book();
            Console.WriteLine(book.BookName);
            Console.WriteLine(book.price);

            Car audi = new Car("audi");
            //audi.CarBrand = "red audi";
            audi.CarStart();

            Car kart = new Car("Kart");
            kart.CarStart();
            
            Console.ReadKey();
        }

        static void convert_type() 
        { 
            string apple = "123";

            // method 1
            Console.WriteLine(Convert.ToInt32(apple));

            // method 2
            //Console.WriteLine((int)apple);

            // method 3
            Console.WriteLine(int.Parse(apple));

            // method 4
            int flower;
            bool res = int.TryParse(apple, out flower);
            Console.WriteLine(res);
            Console.WriteLine(flower);
        }

        static int PikaAdd(ref int x, ref int y) { 
            x= 0;
            y=0;
            int result = x +y;
            return result;
        }

        static void P12_ref() { 
            int apple = 100;
            int bee = 200;
            int cat = PikaAdd(ref apple, ref bee);
            Console.WriteLine("my Cat: " + cat);
            Console.WriteLine("my apple: " + apple);
            Console.WriteLine("my bee: " + bee);
        }

        static bool Pokemon(int a, int b, out int c) { 
            c = a + b;
            return true; 
        }

        static void P13_out() {
            int c = 123;
            int d = 456;
            int cat;
            Console.WriteLine(c);
            Console.WriteLine(d);
            bool e = Pokemon(c,d, out cat);
            Console.WriteLine(e);
            Console.WriteLine(cat);
        }

        static void P14_dynamic() { 
            ArrayList a = method_return_boolAndnum1(4,5);
            Console.WriteLine(string.Join(",", a.ToArray()));
        }

        static ArrayList method_return_boolAndnum1(int a, int b) { 
            ArrayList zoo = new ArrayList();
            zoo.Add(true);
            zoo.Add(a+b);
            return zoo;
        }

        static (bool,int) method_return_boolAndnum2(int a, int b) { 
            return (true, 100);
        }


        static void string_ref_value() { 
            string a = "123";
            string b = a;

            Console.WriteLine(ReferenceEquals(a,b));
            Console.WriteLine(Equals(a,b));

            b = "456";

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
