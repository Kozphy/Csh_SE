using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.codewar
{
    internal class Unique_in_order
    {
        public static void Start()
        {
            string data1 = "AAAABBBCCDAABBB";
            int[] data2 = new int[] { 1, 1, 1, 2, 3 };
            test(data2);
        }


        public static void test<T>(IEnumerable<T> iterable)
        {
            List<T> res = new List<T>();
            //your code here...
            foreach (var i in iterable)
            {
                if (!i.Equals(res.LastOrDefault()))
                {
                    res.Add(i);
                }
            }

            foreach (var i in res)
            {
                Console.WriteLine(i);
            }
        }
    }
}
