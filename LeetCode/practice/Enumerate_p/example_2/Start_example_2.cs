using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.practice.Enumerate_p.example_2
{
    internal class Start_example_2
    {

        public static void Start()
        {
            List<int> numberList = new List<int>() { 8, 6, 2 };


            int[] numberArray = new int[] { 1, 7, 1, 3 };
            Enumerate_2.CollectionSum(numberList);
            Console.WriteLine(" ");
            Enumerate_2.CollectionSum(numberArray);
        }

    }
}
