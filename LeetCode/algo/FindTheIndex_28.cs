using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshAlgo.algo
{
    internal class FindTheIndex_28 
    {
        private static string haystack = "sadbutsad";
        private static string needle = "sad";

        public  static int test()
        {
            if (haystack.Contains(needle))
            {
                return haystack.IndexOf(needle);
            }
            return -1;
        }
    }
}
