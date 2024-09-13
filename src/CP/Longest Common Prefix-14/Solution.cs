using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Common_Prefix_14
{
    public class Solution
    {

        public string LongestCommonPrefix(string[] ss)
        {
            string shortest = ss.OrderBy(s => s.Length).First();

            for (int i = 0; i < shortest.Length; i++)
            {
                if (ss.Select(s => s[i]).Distinct().Count() > 1)
                    return shortest[..i];
            }

            return shortest;
        }
    }
}
