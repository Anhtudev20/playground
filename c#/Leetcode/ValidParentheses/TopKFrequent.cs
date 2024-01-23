using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
     class TopKFrequent
    {
        public static int[] GetTopKFrequent(int[] nums, int k)
        {
                Dictionary<int, int> frequentNumbers = new Dictionary<int, int>();   
                for(int i = 0; i < nums.Length; i++)
                {
                    if (!frequentNumbers.ContainsKey(nums[i]))
                    {
                    frequentNumbers.Add(nums[i], 1);

                    }
                    frequentNumbers[nums[i]]++;

                }
            var freqList = new List<KeyValuePair<int, int>>();

            foreach (var entry in frequentNumbers)
            {
                freqList.Add(entry);
            }

            freqList.Sort((a, b) => b.Value.CompareTo(a.Value));

            var topFrequent = new int[k];
            for (int i = 0; i < k; i++)
            {
                topFrequent[i] = freqList[i].Key;
            }
            return topFrequent;
        }
    }
}
