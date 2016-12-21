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
