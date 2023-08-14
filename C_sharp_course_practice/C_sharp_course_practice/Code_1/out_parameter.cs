using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_sharp_course_practice.Code_1
{
    public class out_parameter
    {
        //  Out Parameter
        // A parameter marked with out must be assigned
        // a value in the method
        public static void DoubleIt(int x, out int solution)
        {
            solution = x * 2;
        }
        
    }
}