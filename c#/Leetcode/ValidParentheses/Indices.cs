using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
     class Indices
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> indices = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (indices.ContainsKey(nums[i]) )
                {
                    return new int[] { indices[nums[i]], i };
                }
                else if (!indices.ContainsKey(target - nums[i]) )
                {
                    indices.Add(target - nums[i], i);
                }
            }
            return new int[] { 0, 0 };
        }
    }
}
