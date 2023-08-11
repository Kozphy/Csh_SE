using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshAlgo.practice.Try_parse
{
    internal class try_parse
    {
        public void parse1()
        {
             string numberAsString = "128";
             int parsedValue;
             bool success = int.TryParse(numberAsString, out parsedValue);
             Console.WriteLine(success);
             Console.WriteLine(parsedValue);
        }


}
}
