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

            Action<int, int> checkIfMaxSubArray = (start, length) =>
            {
                if (subArraySums[start] > maxSum)
                {
                    maxSum = subArraySums[start];
                    result = new List<int[]>();
                }

                if (subArraySums[start] >= maxSum)
                {
                    var subArray = new int[length];
                    Array.Copy(array, start, subArray, 0, length);
                    result.Add(subArray);
                }
            };

            for (var i = 0; i < array.Length; i++)
            {
                // initialize subArraySum with original element value
                subArraySums[i] = array[i];
                // Shall also check if single original element may form maxSubArray
                checkIfMaxSubArray(i, 1);

                for (int j = 0; j < i; j ++)
                {
                     subArraySums[j] += array[i];
                    checkIfMaxSubArray(j, i - j + 1);
                }
            }
            return result;
        }


        public static Tuple<int, int> FindMaxCrossSubarray( int[] array,
                                                            int low,
                                                            int mid,
                                                            int high)
        {
            if (low == high)
            {
                return new Tuple<int, int>(low, high);
            }

            int maxLow = mid, maxHigh = mid;
            int maxSum = int.MinValue;
            int currentSum = 0;

            for (int i = mid; i>=low; i--)
            {
                currentSum += array[i];
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    maxLow = i;
                }
            }

            currentSum = maxSum;
            for (int i = mid + 1; i <= high; i++)
            {
                currentSum += array[i];
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    maxHigh = i;
                }
            }
            return new Tuple<int, int>(maxLow, maxHigh);
        }
    }
}
