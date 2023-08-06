using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab0505
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string x = "pondin";
            //string y = "pika";
            //System.String z = "disua";

            //System.Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);
            Console.WriteLine("------");
            //Console.WriteLine(x.GetType());
            //Console.WriteLine(y.GetType());
            //Console.WriteLine(z.GetType());
            Console.WriteLine("------");
            //P11_discussNumber();
            Console.WriteLine("------");
            //P12_discussNumber();
            Console.WriteLine("------");
            //P20_四則運算();
            Console.WriteLine("P21_formatString");
            //P21_formatString();
            Console.WriteLine("P22_formatFloat------");
            //P22_formatFloat();
            Console.WriteLine("P30_IO---------");
            //P30_IO();
            //P31_公斤_台斤轉換();
            Console.WriteLine("P40_disuss IF---------");
            //P40_討論IF();
            Console.WriteLine("P41_disuss IF's AND OR()---------");
            //P41_disuss_IF_AND_OR();
            Console.WriteLine("P10_ternary_Oper");
            //P10_ternary_Oper();
            Console.ReadLine();
        }

        static void P10_ternary_Oper() {
            //string s  = 100 < 20 ? "pika" : "pondi";
            //Console.WriteLine($"I'm {s}");


        }


        static void P11_discussNumber() {
            short x = 100;
            int y = 200;
            long z = 300;
            Console.WriteLine(x.GetType());
            Console.WriteLine(y.GetType());
            Console.WriteLine(z.GetType());
        }

        static void P12_discussNumber() 
        {
            int min = int.MinValue;
            int bee = int.MaxValue;
            Console.WriteLine($"int min value: {min}, int max value: {bee}");
            int cat = bee + 1;
            Console.WriteLine($"I'm cat {cat}");
        }

		static void P20_四則運算() {
            int a = 10;
            int b = 20;
            int c = 30;


            double g = 1 / 3;
            Console.WriteLine(g);
        }

        static void P21_formatString() {
            int value = 12345;
            Console.WriteLine(value.ToString("C"));
            Console.WriteLine(value.ToString("C0"));
            Console.WriteLine(value.ToString("C2"));

            Console.WriteLine(value.ToString("D"));
            Console.WriteLine(value.ToString("D8"));

            Console.WriteLine(value.ToString("N"));
            Console.WriteLine(value.ToString("N0"));
            Console.WriteLine(value.ToString("N2"));

            //decimal value = 123.456m;
            //Console.WriteLine(value.ToString("C2"));
            //Console.WriteLine("Your account balance is {0:C2}", value);

            var value2 = String.Format("{0,-10:C}", 126347.89m);
            Console.WriteLine(value2);
        }

        static void P22_formatFloat() 
        {
            Console.WriteLine("formatFloat----");
            float x = 1.0f;
            float y = 6.0f;
            float z = x / y;
            Console.WriteLine(z);

            double apple = 1.0;
            double bee = 6.0;
            double cat = apple / bee;
            Console.WriteLine(cat);

            decimal apple1 = 1.0m;
            decimal bee1 = 6.0m;
            decimal cat1 = apple1 / bee1;
            Console.WriteLine(cat1);
        }

        static void P30_IO() {
            //Console.WriteLine("I'm testing");
            //string a = Console.ReadLine();
            //Console.WriteLine($"get: {a}");
            Console.WriteLine("Please input first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input second number: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"{a} > {b} = {a > b}");
            Console.WriteLine($"{a} < {b} {a < b}");

            //Console.WriteLine($"{a} < {b} = True");
            //if (int.Parse(a) < int.Parse(b))
            //{
            //    Console.WriteLine($"{a} > {b} = False");
            //}

            //if (int.Parse(a) < int.Parse(b)) {
            //    Console.WriteLine($"{a} < {b} = True");
            //}
            
        }
        static void P31_公斤_台斤轉換() {
            Console.WriteLine($"please input 台斤: ");
            string ki = Console.ReadLine();
            Console.WriteLine($"輸入 {ki} 台斤，轉換成公斤後為 { int.Parse(ki) * 0.6 } 公斤");
        }

        static void P40_討論IF() 
        {
            int x = 100;
            if (x + 50 > 80) 
            {
                Console.WriteLine("OKs");
            }
        }
        static void P41_disuss_IF_AND_OR()
        {
            int apple = 50;
            int bee = 20;

            //apple++;
            //++apple;
            //Console.WriteLine(++apple);
            //Console.WriteLine(apple++);

            //if (apple++ > 10 && bee++ > 20)
            //{
            //    Console.WriteLine("pika");
            //    Console.WriteLine(apple);
            //    Console.WriteLine(bee);
            //}
            //else { 
            //    Console.WriteLine("pondin");
            //    Console.WriteLine(apple);
            //    Console.WriteLine(bee);
            //}


            Console.WriteLine($"please input first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"please input second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            var result = $"{(b % a == 0 ? "是倍數" : "不是倍數")}";

            Console.WriteLine($"first number is {a}, second number is {b} ==> {result}");
        }

    }
}
