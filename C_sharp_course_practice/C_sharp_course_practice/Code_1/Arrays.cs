using System;
using System.Collections.Generic;
using System.Dynamic;
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

        public static void RetrieveArrayType()
        {
            object[] randomArray = { "Paul", 45, 1.234 };
            Console.WriteLine(randomArray[0].GetType());
        }

        public static void RetrieveArraySize()
        {
            object[] randomArray = { "Paul", 45, 1.234 };
            Console.WriteLine("Array Size: {0}", randomArray.Length);
        }

        public static void LoopArray()
        {

            object[] randomArray = { "Paul", 45, 1.234 };
            for (int i = 0; i < randomArray.Length; i++)
            {
                Console.WriteLine(randomArray[i]);
            }

            foreach (var i in randomArray)
            {
                Console.WriteLine(i);
            }
        }

        public static void MultiDimensionalArray()
        {
            // create
            string[,] custNames = new string[2, 2]
            {
                {
                    "Bob",
                    "Smith"
                },
                {
                    "Sally",
                    "Smith"
                }
            };

            // GetValue
            Console.WriteLine("MD Value: {0}", custNames.GetValue(1,1));

            // Get dimensional length
            Console.WriteLine("first dimensional length {0}", custNames.GetLength(0));
            Console.WriteLine("second dimensional length {0}", custNames.GetLength(1));

            // cycle through
            // Get first dimensional
            for (int i = 0; i < custNames.GetLength(0); i++)
            {
                // Get second dimensional
                for (int j = 0; j < custNames.GetLength(1); j++)
                {
                    Console.WriteLine("{0} ", custNames[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
