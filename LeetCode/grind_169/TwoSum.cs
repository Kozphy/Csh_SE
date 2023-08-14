using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.grind_169
{
    internal class TwoSum
    {
        private static int[] nums = { 2, 5, 5, 11 };
        private static int target = 10;
        public static int length = nums.Length;

        public static int[] brute()
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return new int[]{};
        }

        public static int[] hashTable()
        {
            if (nums == null || nums.Length == 0)
            {
                return new int[]{};
            }

            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int currentValue = nums[i];
                int want = target - currentValue;
                if (dic.TryGetValue(want, out int value))
                {
                    return new int[] { value, i };
                }
                dic[currentValue] = i;
            }
            return new int[]{};
        }
    }
}
