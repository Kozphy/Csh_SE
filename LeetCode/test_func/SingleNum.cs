using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CshAlgo.test_func
{
    internal class SingleNum
    {
        public static int start(int[] nums)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (d.ContainsKey(nums[i]))
                {
                    d[nums[i]]++;
                }
                else
                {
                    d[nums[i]] = 1;
                }
            }
            GC.Collect();

            foreach (var kv in d)
            {
                if (kv.Value == 1)
                {
                    return kv.Key;
                }
            }
            return -1;
        }
    }
}
