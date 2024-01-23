using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
     class ProductOfArrayExceptSelf
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] productOfArrExcepSelf = new int[nums.Length];
            int[] temp = new int[nums.Length - 1];
            for(int i = 0; i < nums.Length; i++)
            {
                productOfArrExcepSelf[i] = nums.Where(val => val != nums[i]).Aggregate((x, y) => x * y);
              
            }
            return productOfArrExcepSelf;
        }
    }
}

