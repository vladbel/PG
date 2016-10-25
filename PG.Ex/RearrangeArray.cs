using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG.Ex
{
    public class RearrangeArray
    {
        /// <summary>
        /// rearrange array [0,1,2,3] to [0,2,1,3] - alternate items from bottom half and top half
        /// /// </summary>
        /// <param name="a"></param>
        public static void ShuffleHalves(int[] a)
        {
            if (a.Length % 2 != 0)
            {
                throw new Exception("Array must have even length");
            }

        }

        public static int NewIndex(int oldIndex, int[] a)
        {
            var ni = 0;
            if (oldIndex < a.Length / 2)
            {
                ni = oldIndex * 2;
            }
            else
            {
                ni = (oldIndex * 2 - a.Length) + 1;
            }
            return ni;
        }

        public static int Swap(int i, int[] a)
        {
            var curIndex = NewIndex(i, a);
            int forwardedValue = a[i];
            var result = 0;

            while (curIndex != i)
            {
                result++;
                var tmp = a[curIndex];
                a[curIndex] = forwardedValue;
                forwardedValue = tmp;
                curIndex = NewIndex(curIndex, a);
            }

            a[curIndex] = forwardedValue;

            return result;
        }

    }


}
