using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab0506
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("use if to caculate clothes");
            //P12_用IF計算衣服();

            Console.WriteLine("P21");
            //P21_年資();
            Console.WriteLine("PlusTo2500----");
            //P31_字串方法();
            //PlusTo2500();
            nineMulNine();
            Console.ReadLine();
        }
        static void P11_用IF計算飲料()
        {
            Console.WriteLine("Please input quantiy you want to purchase.");
            int quantity;
            int unitPrice = 10;
            if (int.TryParse(Console.ReadLine(), out quantity))
            {
                Console.WriteLine("UnitPrice is: {0}", quantity);
                Console.WriteLine("quantiy is: {0}", unitPrice);

                //Console.WriteLine($"{quantity > 10 && quantity <= 20 ? ("Discount 0.95: ": "Discount 0.9: " unitPrice*quantity*0.9)"});
                bool judgeQuantity = quantity >= 10 && quantity <= 20;
                if (judgeQuantity)
                {
                    Console.WriteLine("Discount 0.95");
                    Console.WriteLine($"total: {unitPrice * quantity * 0.95}");
                }
                else
                {
                    Console.WriteLine("Discount 0.9");
                    Console.WriteLine($"total: {unitPrice * quantity * 0.9}");
                }
            }
        }
        static void P12_用IF計算衣服()
        {
            Console.WriteLine("請輸入衣服件數: ");
            int clothes;
            int unitPrice = 399;
            int discountThreshold = 1500;
            double discount = 0.7899749373433584;
            if (int.TryParse(Console.ReadLine(), out clothes))
            {
                int total = clothes * unitPrice;
                string result;
                if (total < discountThreshold)
                {
                    result = $"未達: {discountThreshold}， 還差{(discountThreshold - total):C0}";
                }
                else
                {
                    result = $"超過: {discountThreshold}，折扣後為{(total * discount):C0}";
                }
                Console.WriteLine(result);
                Console.WriteLine($"總金額為: {total:C0}，{result}");
            }
        }

        static void P20_討論switch()
        {
            int x = 100;
            switch (x)
            {
                case 0:
                    Console.WriteLine("pika");
                    break;
                case 100:
                    Console.WriteLine("pondi1");
                    Console.WriteLine("pondi2");
                    break;
                default:
                    Console.WriteLine("kapo");
                    break;

            }
        }

        static void P21_年資()
        {
            Console.WriteLine("請輸入年資:");
            int years = int.Parse(Console.ReadLine());
            Console.WriteLine("請輸入月薪: ");
            int monthPayable = int.Parse(Console.ReadLine());


            //Console.WriteLine(monthPayable.GetType());
            //if (years > 1 && years <= 3)
            //{
            //    Console.WriteLine($"試算年資為 {years}，月薪為{monthPayable:C0}");
            //}
            //else if (years > 3 && years <=6)
            //{
            //    Console.WriteLine($"達三年未滿六年，發放獎金三個月: {(monthPayable * 3):C0}");
            //}
            //else
            //{
            //    Console.WriteLine($"超過六年，發放獎金五個月: {(monthPayable * 5):C0}");
            //}

            int checkYears;


            if (years > 1 && years <= 3)
            {
                checkYears = 0;
            }
            else if (years > 3 && years <= 6)
            {
                checkYears = 1;
            }
            else
            {
                checkYears = 2;
            }


            switch (checkYears)
            {
                case 0:
                    Console.WriteLine($"試算年資為 {years}，月薪為{monthPayable:C0}");
                    break;
                case 1:
                    Console.WriteLine($"達三年未滿六年，發放獎金三個月: {(monthPayable * 3):C0}");
                    break;
                case 2:
                    Console.WriteLine($"超過六年，發放獎金五個月: {(monthPayable * 5):C0}");
                    break;
                default:
                    break;

            }
        }

        static void P30_loop()
        {
            // infinitive loop
            //for (; ; ) {
            //    Console.WriteLine("pondi");
            //}
        }
        static void P31_字串方法()
        {
            string x = "applebeecatdog";
            int start = x.IndexOf("c");
            string res = x.Substring(start, 3);
            Console.WriteLine(x.Contains("b"));
            Console.WriteLine(x.IndexOf("a"));
            Console.WriteLine(x.LastIndexOf("a"));
            //Console.WriteLine(x.Contains("b"));
            Console.WriteLine(res);

        }
        static void PlusTo2500()
        {
            string desc = "";
            int total = 0;
            //for(int i = 1; i<= 99; i+=2){
            //    total += i;
            //    if (i == 99) {
            //        Console.Write($"{i}");
            //        break;
            //    } 
            //    Console.Write($"{i} + ");
            //}
            //Console.WriteLine($" = {total}");

            for (int i = 1; i <= 99; i += 2)
            {
                total += i;
                desc += i.ToString() + " + ";
            }
            desc = desc.Substring(0, desc.LastIndexOf("+"));
            Console.WriteLine($"{desc} = {total}");
        }

        static void nineMulNine()
        {
            //for (int i = 1; i <= 9; i++) { 
            //    for(int z = 1; z<=9 ; z++)
            //    {
            //        Console.Write($"{i} * {z} = {i*z} | ");
            //        if (z == 9) { 
            //            Console.WriteLine();
            //        }
            //    }
            //}
            Console.WriteLine("===九九乘法表===");
            string s = "";
            for (int i = 1; i <= 9 * 9; i++)
            {
                int row = (i - 1) / 9 + 1;
                int col = i % 9 == 0 ? 9 : (i % 9);
                string total = (row * col).ToString();

                if (total.Length == 1)
                {
                    total = total.PadLeft(2);
                }
                string res = $"{row} * {col} = {total}";

                if (col == 9)
                {
                    s += $"{res}\r\n";
                    continue;
                }
                s += $"{res}  ";
            }
            Console.WriteLine(s);
        }

        static void p51_推測ABC()
        {
            int a = 10, b = 20, c;

            do
            {
                c = a + b;
                a -= 1;
            } while (b < 0);

            Console.WriteLine($"A，do while() 迴圈後，a 的值為：{a}、c 的值為：{c}");
        }

        static void p52_推測ABC()
        {
            int a = 10, b = 20, c;
            do
            {
                for (c = 1; c <= 5; c++)
                {
                    a += c;
                }
                b -= 1;
            } while (b <= 0);

            Console.WriteLine($"B，do while() 迴圈後，a 的值為：{a}、b 的值為：{b}、c 的值為：{c}");

        }
    }

}
