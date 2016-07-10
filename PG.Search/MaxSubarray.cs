using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG.Search
{
    public class MaxSubarray
    {
        public static List<int[]> FindMaxSubarray_N2( int[] array)
        {
            var subArraySums = new int [array.Length];
            var result = new List<int[]>();
            var maxSum = int.MinValue;



            for (var i = 0; i < array.Length; i++)
            {
                // initialize subArraySum with original element value
                subArraySums[i] = array[i];
                // Shall also check if single original element may form maxSubArray
                if (subArraySums[i] > maxSum)
                {
                    maxSum = subArraySums[i];
                    result = new List<int[]>();
                }

                if (subArraySums[i] >= maxSum)
                {
                    var subArray = new int[1];
                    subArray[0] = array[i];
                    result.Add(subArray);
                }

                for (int j = 0; j < i; j ++)
                {
                     subArraySums[j] += array[i];

                    if ( subArraySums[j] > maxSum)
                    {
                        maxSum = subArraySums[j];
                        result = new List<int[]>();
                    }

                    if (subArraySums[j] >= maxSum)
                    {
                        var subArray = new int[i - j + 1];
                        Array.Copy( array, j , subArray, 0, i - j + 1);
                        result.Add(subArray);
                    }
                }
            }
            return result;
        }
    }
}
