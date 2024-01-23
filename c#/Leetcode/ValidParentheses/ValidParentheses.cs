using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
     class ValidParentheses
    {
        public static bool IsValid(string s)
        {
            HashSet<string> valid = new HashSet<string>();
            bool check = true;
            for (int i = 0; i < s.Length - 1; i++)
            {
                for(int j = i+1; j < s.Length; j++)
                {
                    if (s[i] == '(')
                    {
                        if (s[j] == ')')
                        {
                            s.Remove(j,1);
                            s.Remove(i, 1);
                            break;
                        }
                        if (s[j] == '(')
                        {
                            return false;
                        }
                        if (s[j] ==s.Length - 1)
                        {
                            return false;
                        }
                    }

                    if (s[i] == '[')
                    {
                        if (s[j] == ']')
                        {
                            s.Remove(j, 1);
                            s.Remove(i, 1);
                            break;
                        }
                        if (s[j] == '[')
                        {
                            return false;
                        }
                        if (s[j] == s.Length - 1)
                        {
                            return false;
                        }
                    }
                    if (s[i] == '{')
                    {
                        if (s[j] == '}')
                        {
                            s.Remove(j, 1);
                            s.Remove(i, 1);
                            break;
                        }
                        if (s[j] == '{')
                        {
                            return false;
                        }
                        if (s[j] == s.Length - 1)
                        {
                            return false;
                        }
                    }
                }
            }
            Console.WriteLine(check);
            return check;
        }
    }
}
