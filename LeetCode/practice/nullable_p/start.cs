using System;

namespace ConsoleApp2.practice.nullable_p
{
   internal class nullable_start{
        public  static void Start()
        {
            int? num1 = null;
            int? num2 = 1337;
            int num5;

            double? num3 = new Double();
            double? num4 = 3.14157;

            bool? boolval = new bool?();
            System.Console.WriteLine($"Our nullable numbers are: {num1}, {num2}, {num3}, {num4}");
            System.Console.WriteLine($"The nullable boolean value is {boolval}");

            bool? isMale = null;
            if (isMale == true)
            {
                Console.WriteLine("User is male");
            }
            else if (isMale == false)
            {
                Console.WriteLine("User is female");
            }
            else
            {
                Console.WriteLine("No gender chosen");
            }

            double? num6 = 13.1;
            double? num7 = null;
            double num8;

            if (num6 == null)
            {
                num8 = 0.0;
            }
            else
            {
                num8 = (double)num6;
            }

            Console.WriteLine($"Value of num8 is {num8}");

            num8 = num6 ?? 8.53;
            Console.WriteLine($"Value of num8 is {num8}");
            num8 = num7 ?? 8.53;
            Console.WriteLine($"Value of num8 is {num8}");
        }
   } 
}