using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshAlgo.grind_169
{
    internal class Longest_SubString_3
    {
        public static void Start()
        {
            string s = "pwwkew";

            int l = 0;
            int r = 0;
            int maxLength = 0;
            HashSet<char> hs = new HashSet<char>();

            // maxlength = 2
            // set =  k, e, w
            // p w w [k e w] 
            while (r < s.Length)
            {
                if (!hs.Contains(s[r]))
                {
                    hs.Add(s[r]);
                    r++;
                    maxLength = Math.Max(maxLength, hs.Count);
                }
                else {
                    hs.Remove(s[l]);
                    l++;
                }
            }
            Console.WriteLine(maxLength);
        }
    }
}
