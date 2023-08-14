using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshAlgo.practice.try_parse
{
    internal class tryParse
    {
        private static string numberAsString = "128";

        private static float parsedValue;

        public static void Start()
        {
             bool success = float.TryParse(numberAsString, out parsedValue);

            if(success) {
                Console.WriteLine("Parsing successful - number is {0}", numberAsString);
            }else{
                Console.WriteLine("Parsing failed");
            }
        }


    }
}
