using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.grind_169
{
    internal class TwoSum
    {
        private static int[] nums = { 2, 7, 11, 15 };
        private int target = 9;
        public int length = nums.Length;

        public int[] caculate()
        {
            if (nums == null || nums.Length == 0)
            {
                return new int[2];
            }

            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(i);
                if (dic.ContainsKey(target - nums[i]))
                {
                    return new int[] { i, dic[target - nums[i]] };
                }
                else if (!dic.ContainsKey(nums[i]))
                {
                    dic.Add(nums[i], i);
                }
            }
            return new int[2];
        }
    }
}
