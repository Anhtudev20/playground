using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
     class GroupAnagram
    {
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var groups = new Dictionary<string, List<string>>();

            foreach (var str in strs)
            {
                char[] chars = str.ToCharArray();
                Array.Sort(chars);
                string key = new string(chars);

                if (!groups.ContainsKey(key))
                    groups[key] = new List<string>();

                groups[key].Add(str);
            }

            return groups.Values.Cast<IList<string>>().ToList();
        }
    }
}
