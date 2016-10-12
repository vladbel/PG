using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG.DP
{
    public class LongestSubarray
    {
        public static int LongestSubArrayThatAddsToTheGivenSum( int[] array, int sum)
        {
            var result = 0;
            var subResults = new int[array.Length];

            for (var i = 0; i < array.Length; i++)
            {
                for (var j = 0; j<= i; j++)
                {
                    subResults[j] += array[i];

                    if (subResults[j] == sum && (i - j + 1) > result)
                    {
                        result = i - j + 1;
                    }
                }
            }

            return result;
        }
    }
}
