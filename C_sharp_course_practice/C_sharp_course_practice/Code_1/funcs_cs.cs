using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_sharp_course_practice.Code_1
{
    public class funcs_cs
    {
        //  Functions
        public static void PrintArray(int[] intArray, string mess) {
            foreach (int k in intArray)
            {
                Console.WriteLine("{0}: {1}", mess, k);
            }
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
    }
}