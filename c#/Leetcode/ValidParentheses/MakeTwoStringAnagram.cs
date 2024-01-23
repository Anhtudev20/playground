using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
     class MakeTwoStringAnagram
    {
        public static int MinSteps(string s, string t)
        {
            Dictionary<char, int> countS = new Dictionary<char, int>();
           for(int i  = 0; i < s.Length; i++)
            {
                if (!countS.ContainsKey(s[i]))
                {
                    countS.Add(s[i], 0);

                }
                countS[s[i]]++;
            }
           foreach(char c in t) {
                if (countS.ContainsKey(c) )
                {
                    countS[c] = countS[c] == 0 ? 0 : countS[c] - 1;                    
                }
                else
                {
                    countS.Add(c, 1);
                }
            }
            int minCount = countS.Values.Sum();
            return minCount;
        }
    }
}
