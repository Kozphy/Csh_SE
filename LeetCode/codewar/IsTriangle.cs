using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.codewar
{
    internal class IsTriangle
    {
        public static void Start()
        {
            test(5, 7, 10);
        }
        private static void test(int a, int b, int c)
        {
            Console.WriteLine(a + b > c && a + c > b && b + c > a);

        }
    }
}
