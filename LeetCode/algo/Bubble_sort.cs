using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.algo
{
    internal class Bubble_sort
    {
        public static int[] Start(string order)
        {
            int[] arr = {
                6,3,0,5
            };

            for (int i = 0; i < arr.Length - 1; i++)
            {
                //swap
                for (int j = 0; j < arr.Length - i - 1;j++)
                {
                    if (order == "asc")
                    {
                        Asc(ref arr, j);
                    }else if (order == "desc")
                    {
                        Desc(ref arr, j);
                    }
                }
            }

            Bubble_sort.Print(order, arr);
            return arr;
        }

        public static void Print(string order, int[] arr)
        {
            Console.WriteLine("------" + order + "--------");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            };
        }

        // small to big
        public static void Asc(ref int[] arr, int j)
        {
            if (arr[j] > arr[j + 1])
            {
                int temp = arr[j + 1];
                arr[j + 1] = arr[j];
                arr[j] = temp;
            }
        }

        // big to small
        public static void Desc(ref int[]  arr, int j)
        {
            if (arr[j] < arr[j + 1])
            {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[ j + 1] = temp;
            }
        }
    }
}
