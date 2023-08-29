using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.grind_169
{
    internal class Best_Time_121
    {
        public int GetResult()
        {
            int[] prices = new int[] { 7, 1, 5, 3, 6, 4 };
            int max_profit = 0;
            int windowStart = 0;

            for (int windowEnd = 0; windowEnd < prices.Length; windowEnd++)
            {
                int l = prices[windowStart];
                int r = prices[windowEnd];

                if (l < r)
                {
                    max_profit = Math.Max(r - l, max_profit);
                }
                else {
                    windowStart = windowEnd;
                }
            }

            return max_profit;
        }

    }
}
