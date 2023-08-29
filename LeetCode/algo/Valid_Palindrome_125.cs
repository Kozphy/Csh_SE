using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CshAlgo.algo
{
    internal class Valid_Palindrome_125
    {
        public static bool IsPalindrome(string s)
        {
            string pattern = "[^a-zA-Z0-9]";
            int num = 0;

            // replace all non-alphanumeric characters
            s = Regex.Replace(s, pattern, string.Empty);
            // convert to lower case
            s = s.ToLower();

            // compare start and end
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[num] == s[i])
                {
                    num++;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
