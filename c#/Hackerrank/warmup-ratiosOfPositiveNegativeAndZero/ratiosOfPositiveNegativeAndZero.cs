using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warmup_ratiosOfPositiveNegativeAndZero
{
   class rationOfPositiveNegativeAndZero
    {
        public static void plusMinus(List<int> arr)
        {
            Dictionary<string, int> result = new Dictionary<string, int>() { { "positive", 0 }, { "negative", 0 }, { "zero", 0 } };
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] > 0)
                {
                    result["positive"] += 1;
                }
                if (arr[i] < 0)
                {
                    result["negative"] += 1;
                }
                if (arr[i] == 0)
                {
                    result["zero"] += 1;
                }
            }
            decimal ratio = 0.000000M;
            foreach (int value in result.Values)
            {
                ratio = (decimal)value / arr.Count;
                Console.WriteLine(Math.Round(ratio, 6).ToString("0.000000"));
            }
        }
        public void solution()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            plusMinus(arr);

        }
    }
}





