using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.algo
{
    internal class fib_dpa
    {
        static int[] output = new int[1000];

        public static int fib(int n) 
        {
            int result;
            result = output[n];
            if (result == 0) 
            {
                if (n == 0) {
                    return 0;
                }
                if (n == 1)
                {
                    return 1;
                }
                else
                {
                    // input 3: f(2) = [1,0], f(1) = 1
                    return (fib(n - 1) + fib(n - 2));
                }
            }
            output[n] = result;
            return result;
        }
    }
}
