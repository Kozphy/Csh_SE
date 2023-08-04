using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_course.Code_1
{
    internal class test1
    {
        //  Functions
        public static void PrintArray(int[] intArray, string mess) {
            foreach (int k in intArray)
            {
                Console.WriteLine("{0}: {1}", mess, k);
            }
        }

        public  static bool GT10(int val)
        {
            return val > 10;
        }

        public static double DoDivision(double x, double y)
        {
            if (y == 0) 
            {
                throw new System.DivideByZeroException();
            }
            return x / y;
        }

        public static void SayHello()
        {
            string name = "";
            Console.WriteLine("What is your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);
        }

        public static double GetSum(double x = 1, double y = 1) 
        {
            double temp = x;
            x = y;
            y = temp;
            return x + y;
        }

        //  Out Parameter
        // A parameter marked with out must be assigned
        // a value in the method
        public static void DoubleIt(int x, out int solution)
        {
            solution = x * 2;
        }

        // Pass by reference
        public static void Swap(ref int num3, ref int num4) {
            int temp = num3;
            num3 = num4;
            num4 = temp;
        }

        // Params
        public static double GetSumMore(params double[] nums)
        {
            double sum = 0;
            foreach (int i in nums)
            {
                sum += i;
            }
            return sum;
        }

    }
}
