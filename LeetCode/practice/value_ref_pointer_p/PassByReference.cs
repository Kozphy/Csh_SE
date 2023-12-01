using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshAlgo.practice.value_ref_pointer_p
{
    internal class PassByReference
    {
        public static void Start()
        {
            int originValue = 10;

            Console.WriteLine($"originValue: {originValue}");

            PassReference(ref originValue);

            Console.WriteLine($"after pass by reference originValue is: {originValue}");
        }

        private static void PassReference(ref int v)
        {
            v = 30;
            Console.WriteLine($"Value inside method: {v}");
        }
    }
}
