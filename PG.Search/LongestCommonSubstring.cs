using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG.Search
{
    public class LongestCommonSubstring
    {
        public static List<string> Find(string s1, string s2)
        {
            var matches = new int[s1.Length, s2.Length];
            int maxLength = 0;
            var result = new List<string>();

            for ( var i = 0; i < s1.Length; i++)
            {
                for (var j = 0; j < s2.Length; j++)
                {
                    if (s1[i] == s2[j])
                    {
                        matches[i, j] = (i > 0 && j > 0) ?
                            matches[i - 1, j - 1] + 1 : 1;

                        if (matches[i, j] > maxLength)
                        {
                            maxLength = matches[i, j];
                            result = new List<string>();
                        }

                        if (matches[i, j] >= maxLength)
                        {
                            result.Add(s2.Substring(j - matches[i, j] + 1, matches[i, j]));
                        }
                    }
                }
            }
            return result;
        }
    }
}
