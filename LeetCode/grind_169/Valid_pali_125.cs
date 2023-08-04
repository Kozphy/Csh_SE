using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp2.grind_169
{
    internal class Valid_pali_125
    {
        string s = "A man, a plan, a canal: Panama";
        string pattern = "[^a-zA-Z0-9]";
        string? reverse_s = null;
        int num = 0;
        public bool GetResult() {
            s = Regex.Replace(s, pattern, String.Empty);
            s = s.ToLower();
            
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[num] == s[i])
                {
                    num++;
                    continue;
                }
                else {
                    return false;
                }
               
            }
            return true;
        }
    }
}
