using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG.Search
{
    public class MaxNonRepeatCharSubstring
    {
        public static string Find (string s)
        {
            var positions = Enumerable.Repeat(-1, 256).ToArray();

            var startIndex = 0;
            var endIndex = 0;
            var candStart = 0;

            for (int i = 0; i < s.Length; i++)
            {
                var prevDupIndex = positions[s[i]];
                if (prevDupIndex  >= candStart)
                {
                    // found duplicate in ....S...D1...D2
                    // where:
                    // S  - is start of non-dup substring - s[candStart]
                    // D1 - first occurence of duplicate char - s[prevIndex]
                    // D2 - second (current) occurence of dup char - s[i]

                    candStart = prevDupIndex + 1; // set S to D1 + 1 
                }
                else // current char is non-repeated within substring started from candStart
                {
                    if (i - candStart  > endIndex - startIndex)
                    {
                        startIndex = candStart;
                        endIndex = i;
                    }
                }

                positions[s[i]] = i;
            }
            return s.Substring(startIndex, endIndex - startIndex + 1);
        }



        public static long FindMaxCrossSubstring ( string s, int low, int mid, int high)
        {
            var result = 0;

            if (low == mid  && mid == high)
            {
                return 1;
            }

            return result;
        }

        public static string FindMaxRightCrossSubstring(string s, int low, int mid, int high)
        {

            var v = new bool[256];
            var i = mid;
            while (i <= high && v[s[i]] == false)
            {
                v[s[i]] = true;
                i++;
            }

            var j = mid;
            while ( j - 1 >= low && v[s[j - 1]] == false)
            {
                v[s[j - 1]] = true;
                j--;
            }
            return s.Substring(j, i - j);
        }
    }
}
