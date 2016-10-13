using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG.Sort
{
    public class MergeSort
    {
        public static void Sort ( int[] array)
        {
            MergeSort_Recursive(array, 0, array.Length - 1);
        }

        static public void MergeSort_Recursive(int[] numbers, int left, int right)
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                MergeSort_Recursive(numbers, left, mid);
                MergeSort_Recursive(numbers, (mid + 1), right);

                Merge(numbers, left, (mid + 1), right);
            }
        }

        private static void Merge (int[] array, int leftStart, int mid, int rightEnd)
        {

            var buffer = new int[ rightEnd - leftStart + 1];
            var bufferMid = mid - leftStart;

            // copy to buffer
            for (var i = 0; i < buffer.Length; i++)
            {
                buffer[i] = array[leftStart + i];
            }

            int i1 = 0;
            int i2 = 0;
            while (i1 < bufferMid || (bufferMid + i2) < buffer.Length)
            {
                //copy from left subarray
                while ((i1 < bufferMid && bufferMid + i2 < buffer.Length  // if both indexes within the bounds
                                && buffer[i1] <= buffer[bufferMid + i2])  // and current left element is less then current right
                       || (bufferMid + i2 == buffer.Length                // OR right index exausted
                                &&  i1 < bufferMid))
                {
                    array [leftStart + i1 + i2 ] = buffer[i1];
                    i1++;
                }

                // copy from right subarray
                while ((bufferMid + i2 < buffer.Length
                                &&  i1 < bufferMid  && buffer[i1] >= buffer[bufferMid + i2])     // current right lless then current left element
                          || ( i1 == bufferMid && bufferMid + i2 < buffer.Length) )             //Left index exausted
                {
                    array[leftStart + i1 + i2] = buffer[bufferMid + i2];
                    i2++;
                }
            }
        }
    }
}
