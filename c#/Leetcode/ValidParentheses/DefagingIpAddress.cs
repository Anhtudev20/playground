using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
     class DefagingIpAddress
    {
        public string DefangIPaddr(string address)
        {
            StringBuilder defaged = new StringBuilder();
            for(int i = 0; i < address.Length; i++)
            {
                if (char.IsDigit(address[i]))
                {
                    defaged.Append(address[i]);
                }
                else
                {
                    defaged.Append($"[{address[i]}]");
                }
            }
            return defaged.ToString();
        }
    }
}
