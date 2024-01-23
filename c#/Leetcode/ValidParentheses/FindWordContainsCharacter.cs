using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
     class FindWordContainsCharacter
    {
        public IList<int> FindWordsContaining(string[] words, char x)
        {
            List<int> wordContainer = new List<int>();
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains(x))
                {
                    wordContainer.Add(i);
                }
            }
            return wordContainer;
        }
    }
}
