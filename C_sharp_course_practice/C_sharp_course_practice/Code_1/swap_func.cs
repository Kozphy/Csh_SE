using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_sharp_course_practice.Code_1
{
    public class swap_func
    {
        // Pass by reference
        public static void Swap(ref int num3, ref int num4) {
            int temp = num3;
            num3 = num4;
            num4 = temp;
        }
    }
}