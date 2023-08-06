using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab0509
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //howManyUnitOfNumber();
            //P02_有那些數字();
            //P10_discussArray();
            //P11_arrayWithFor();
            //P12_discussNumArray();
            //P13_練習放資料();
            //P14_費式數列();
            P20_二維陣列();
            //P21_平均溫度();
            P22_終極密碼();

            Console.ReadLine();
        }

        static void howManyUnitOfNumber() {
            Console.Write("Please input number:");
            int num = int.Parse(Console.ReadLine());
            int unit = 0;

            while (num > 0) {
                num = num / 10;
                unit+=1; 
            }
            Console.WriteLine($"一共有{ unit }位數");
        }

        static void P02_有那些數字()
        {
            for (int i = 0; i < 999; i++)
            {
                int hundredsDigitNumber = i / 100;
                int tenDigitNumber = i % 100 / 10; 
                int digitNumber = i % 10;

                double total = Math.Pow(hundredsDigitNumber, 3) + Math.Pow(tenDigitNumber, 3) + Math.Pow(digitNumber, 3);
                if (i == total) {
                    Console.WriteLine($"{hundredsDigitNumber},{tenDigitNumber},{digitNumber}");
                    Console.WriteLine(total);
                };
            }
        }

        static void P10_discussArray() {
            string[] a = { "pika", "pondi", "superDream" };
            //Console.WriteLine(a[2]);

            string[] bee = new string[5];

            string[] cat = new string[5] { "app", "bee", "cat", "for" , "for2" };
            Console.WriteLine(cat[3]);

            string[] flower = new string[5] { "app", "bee", "cat", "for" , "for2" };
            Console.WriteLine(flower[3]);
            Console.WriteLine("----");

            string x = string.Join("@@@@", flower);
            Console.WriteLine(x);
        }
        static void P11_arrayWithFor() {
            string[] a = new string[] { "app", "bee", "cat"};
            foreach (var item in a) {
                Console.WriteLine(item);
            }
        }

        static void P12_discussNumArray()
        {
            //int[] nums = new int[] { 1, 2, 3, 4 };

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}

            //foreach (var num in nums) {
            //    Console.WriteLine(num);
            //}

            int[] cats = new int[] { 1, 2, 33, 11, 4, 5, 32, 0 };
            int x = cats.Max();
            int y = cats.Min();

            //Console.WriteLine(x);
            //Console.WriteLine(y);
            int[] res = new int[] { };

            Console.WriteLine(string.Join(",", cats));


            Array.Sort(cats);
            Console.WriteLine(string.Join(",", cats));
        }

        static void P13_練習放資料()
        {
            int[] nums = new int[10];
            int n = 1;

            for (int i = 0; i < nums.Length; i++) {
                nums[i] = n;
                n+=2;
            }
            Console.WriteLine(string.Join(",", nums));

        }
        static void P14_費式數列()
        {
            int[] fib= new int[10] ;
            fib[0] = 1;
            fib[1] = 1;

            for(int i = 2; i < fib.Length; i++)
            {
                fib[i] = fib[i-1] + fib[i-2];
            }
            Console.WriteLine(string.Join(",",fib));
        }
        static void P20_二維陣列()
        {
            int[,] apple = new int[2,5];
            for (int i = 0; i < 13; i++) { 
            }
            apple[0,1] = 1;
            apple[0, 2] = 2;
            apple[0, 2] = 200;

            int[][] bee = new int[2][];
            bee[0] = new int[3];
            bee[1] = new int[13];
        }

        static void P21_平均溫度() {
            // 目前有12個月份的溫度，請於畫面上顯示月份對應的溫度以及平均溫度
            //     溫度：26, 28, 29, 31, 35, 34, 36, 37, 36, 32, 28, 18

            int[] temperature = new int[] { 26, 28, 29, 31, 35, 34, 36, 37, 36, 32, 28, 18 };

            float acumulate = 0;

            string s = String.Empty;
            string s2 = String.Empty;
            string s3 = String.Empty;

            for (int i = 0; i < temperature.Length; i++) {
                //if (i < 9) {
                //    s += $"0{i+1}月\t";
                //}else{
                //    s += $"{i+1}月\t";
                //}
                s += $"{i + 1}月".PadLeft(3, '0') + "\t";
                acumulate += temperature[i];
                s2 += "--------";
                s3 += $"{temperature[i]}度\t";
            }
            Console.WriteLine(s);
            Console.WriteLine(s2);
            Console.WriteLine(s3);

            float avg = acumulate/temperature.Length;
            Console.WriteLine($"平均溫度為 {avg:F2}");
        }

    }
}
