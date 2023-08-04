using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.grind_169
{
    internal class Valid_Para_20
    {
        string s = "[";

        public bool get_result()
        {
            Dictionary<char, char> bracketMap = new Dictionary<char, char>
            {
                { '{', '}'},
                { '(', ')'},
                { '[', ']'},
            };

            Stack<char> openBrackets = new Stack<char>();

            foreach (char bracket in s)
            {
                if (bracketMap.ContainsKey(bracket))
                {
                    openBrackets.Push(bracket);
                }
                else 
                {
                    if (openBrackets.Count == 0)
                    {
                        return false;
                    }
                    else if (bracketMap[openBrackets.Peek()] == bracket) 
                    {
                        openBrackets.Pop();
                        continue; 
                    };
                    return false; 
                }
            }
            return openBrackets.Count() == 0;
        }
    }
}
