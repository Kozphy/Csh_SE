using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshAlgo.practice.value_ref_pointer_p
{
    internal class PassByValue
    {
        public static void Start() {
            int originValue = 10;

            Console.WriteLine($"originValue: {originValue}");
            PassByValue pbv = new PassByValue();
            pbv.PassValue(originValue);

            Console.WriteLine($"after pass by value originValue is: {originValue}");
        }

        private void PassValue(int v) {
            v = 30;
            Console.WriteLine($"Value inside method: {v}");
        }
    }
}
