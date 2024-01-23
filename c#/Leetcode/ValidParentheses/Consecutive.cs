using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
     class Consecutive
    {
        public static int LongestConsecutive(int[] nums)
        {
            int longest = 0;
            int length = 0;
            Array.Sort(nums);
            HashSet<int> set = new HashSet<int>();
            for(int i = 0; i < nums.Length; i++)
            {
                set.Add(nums[i]);
            }
            foreach(int i in set)
            {
                if (!set.Contains(i - 1))
                {
                    length = 0;
                    while(set.Contains(i+length))
                    {
                        length++;
                    }
                }
                longest = Math.Max(longest, length);
            }
            return longest;
        }
    }
}
