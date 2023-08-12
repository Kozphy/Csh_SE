using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_course_practice.Code_1
{
    internal class Arrays
    {
        private static string[]? customers = null;

        public static void defineArray()
        {
            // Define an array which holds 3 values
            int[] favNums = new int[3];

            // add a value to the array
            favNums[0] = 23;

            Console.WriteLine("favNim 0: {0}", favNums[0]);
        }

        public static void CreateArray()
        {
            // Create and fill array
            customers = new string[] { "Bob", "Sally", "Sue" };

            // implicitly typed arrays.
            var employees = new[] { "Mike", "Sally", "Sue" };
        }

        public static void RetrieveArrayValue()
        {
            
        }
    }
}
