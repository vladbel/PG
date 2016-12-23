﻿using System;
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
            var endIndex = -1;
            var candStart = 0;

            for (int i = 0; i < s.Length; i++)
            {
                var prevDupIndex = positions[s[i]];
                if (prevDupIndex  >= candStart)
                {
                    // found duplicate in [....s...d...d
                    if (i - 1 - candStart > endIndex - startIndex)
                    {
                        //longer substring;
                        endIndex = i - 1;
                        startIndex = candStart;
                    }

                    candStart = prevDupIndex + 1;
                }
                else
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
