using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.practice.Enumerate_p.example_2
{
    internal class Enumerate_2
    {
         public static void CollectionSum(IEnumerable<int> anyCollection)
        {
            int sum = 0;

            foreach(int num in anyCollection)
            {
                sum+= num;
            }
            Console.WriteLine("Sum is {0}", sum);
        }

    }
}
