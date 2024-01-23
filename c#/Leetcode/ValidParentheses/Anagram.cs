using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
     class Anagram
    {
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;
            Dictionary<char, int> sMap = new Dictionary<char, int>();
            Dictionary<char, int> tMap = new Dictionary<char, int>();
            for (int i = 0; i < t.Length; i++)
            {
                if (!sMap.ContainsKey(s[i]))
                {
                    sMap.Add(s[i], 1);
                }
                sMap[s[i]]++;
                if (!tMap.ContainsKey(t[i]))
                {
                    tMap.Add(t[i], 1);
                }
                tMap[t[i]]++;
            }
            foreach (char c in sMap.Keys)
            {
                if (!tMap.ContainsKey(c) || tMap[c] != sMap[c])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
