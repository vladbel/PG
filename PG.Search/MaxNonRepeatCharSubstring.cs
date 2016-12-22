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

            for (int i = 0; i < s.Length; i++)
            {
                if ( positions[s[i]] >= startIndex)
                {

                    if (i - positions[s[i]] > endIndex - startIndex)
                    {
                        //longer substring;
                        endIndex = i - 1;
                        startIndex = positions[s[i]];
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
