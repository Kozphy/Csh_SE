using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.codewar
{
    internal class BouncingBall
    {
        public static void  Start() {
            double h = 3;
            double bounce = 0.66;
            double window = 1.5;
            start_test(h,bounce,window);
        }

        private static void start_test(double h, double bounce, double window) 
        {
            if (h <= 0 || bounce <=0 || bounce >= 1 || window >= h) {
                Console.WriteLine(-1);
                return;
            }
            int mother_see = -1;
            
            while (h > window) 
            {
                h = h* bounce;
                mother_see += 2;
            }
            Console.WriteLine(mother_see);
        }
    }
}
