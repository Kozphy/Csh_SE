using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshAlgo.practice.value_ref_pointer_p
{
    internal class PassByPointer
    {
        public unsafe static void Start()
        {
            int originValue = 10;
            int* originPointer = &originValue;

            Console.WriteLine($"originValue: {originValue}");

            PassPointer(originPointer);

            Console.WriteLine($"after pass by pointer originValue is: {originValue}");
        }

        private unsafe static void PassPointer(int* v)
        {
            *v = 30; // dereference and assign
            Console.WriteLine($"Value inside method: {*v}");
        }
    }
}
