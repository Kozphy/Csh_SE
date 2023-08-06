using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab0511
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //P01_終極密碼_可重複玩();
            //P10_List();
            //P21_ArrayList();
            //pokemon(1, 2);
            //pokemon("dfs", "fda");
            //pokemon<char, char>('1', '2');
            P30_ref();

            Console.ReadKey();
        }

        static void P10_List()
        {
            List<string> bee = new List<string>();
            bee.Add("高麗菜鍋貼");
            bee.Add("1234");
            bee.Add("pika");
            Console.WriteLine(bee[0]);
            Console.WriteLine(bee[1]);

            // Add 後才有空間
            //bee[3] = "4";

            Console.Clear();
            Console.WriteLine(string.Join(",", bee));

            Console.WriteLine(bee.Count());

            bee.IndexOf("1234");
            IEnumerable<string> q = bee.Where((s) =>
            {
                return s.Length == 4;
            });

            Console.WriteLine(string.Join(",", q));

            // remove list item
            bee.Remove("1234");
            Console.WriteLine(string.Join(",", bee));

        }
        static void P21_ArrayList() {
            /*
                ArrayList: 內容可以混合型別
            */
            ArrayList a = new ArrayList();
            a.Add("pika");
            a.Add(999);
            Console.WriteLine(string.Join(",", a.ToArray()));
            
            // <> 泛型 = 廣泛的型別
            Dictionary<string,string> b = new Dictionary<string, string>();
            b.Add("L", "Large");
            b.Add("M", "Medium");
            b.Add("S", "Small");

            //foreach(var item in b)
            //{
            //    Console.WriteLine(item);
            //    Console.WriteLine(item.Key);
            //    Console.WriteLine(item.Value);
            //}
            foreach (KeyValuePair<string, string> item in b) {
                Console.WriteLine(item.Value);
            }
        }

        static void pokemon(int x, int y) {
            Console.WriteLine("數字版的交換");
        }

        static void pokemon(string x, string y) {
            Console.WriteLine("字串版的交換");
        }

        static void pokemon<T, K>(T x, T y) {
            Console.WriteLine("Generic swap");
        }

        static void P30_ref() {
            int a = 100;
            int b = a;
            bool flag = object.ReferenceEquals(a, b);
            Console.WriteLine(flag);

            bool flag2 = object.Equals(a, b);
            Console.WriteLine(flag2);

            Console.Clear();
            // string by reference
            string x = "apple";
            string y = x;
            y = "bee";
            Console.WriteLine(x);
            flag = object.ReferenceEquals(x, y);
            flag2 = object.Equals(x, y);
            Console.WriteLine(flag);
            Console.WriteLine(flag2);


        }
        static void P01_終極密碼_可重複玩()
        {
            Random rnd = new Random();
            int ans = rnd.Next(1, 101);
            int round = 0;
            int round_upper = 3;
            Console.WriteLine(ans);
            int start = 1;
            int end = 100;
            int input;

            do
            {
                Console.WriteLine($"請輸入，{start}~{end}之間的數值");
                bool inputCheck = int.TryParse(Console.ReadLine(), out input);

                // 檢查是否輸入為數字
                while (!inputCheck)
                {
                    Console.WriteLine("請輸入數字");
                    inputCheck = int.TryParse(Console.ReadLine(), out input);
                }

                // 檢查輸入是否在範圍之間
                if (input <= start || input >= end)
                {
                    continue;
                }

                if (ans > input)
                {
                    start = input;
                }
                else if (ans < input)
                {
                    end = input;
                }

                Console.WriteLine($"介於 {start} 和 {end}");
                round += 1;

                // 大於三次時
                if (round >= round_upper)
                {
                    Console.WriteLine("是否要具續玩遊戲? (Y/N)");
                    if (Console.ReadLine().ToUpper() == "Y")
                    {
                        round = 0;
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }

            } while (ans != input);

            if (ans == input)
            {
                Console.WriteLine($"答案為 {ans}，恭喜答對(猜了 {round} 次)");
            }
            else
            {
                Console.WriteLine($"正確答案是: {ans}");
            }

        }

    }
}
