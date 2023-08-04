using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.practice
{
    internal class Yield
    {
        public static void Start() 
        {
            foreach (int i in ProduceEvenNumbers(9)) {
                Console.WriteLine(i);
            }
        }

        public static IEnumerable<int> ProduceEvenNumbers(int upto) { 
           for (int  i = 0; i < upto; i+=2) { 
                yield return i;
            } 
        }
    }
}
