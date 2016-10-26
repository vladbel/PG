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
        /// 
        /// rearrange array [2,3,200,300] to [2,102,3,103] - alternate items from bottom half and top half
        /// 
        /// Original task:
        /// Given a Data Structure having first n integers and next n chars. 
        /// A = i1 i2 i3 … iN c1 c2 c3 … cN.
        /// Write an in-place algorithm to rearrange the elements of the array ass A = i1 c1 i2 c2 … in cn
        /// /// </summary>
        /// <param name="a"></param>
        public static void ShuffleHalves(int[] a)
        {
            if (a.Length % 2 != 0)
            {
                throw new Exception("Array must have even length");
            }

            var firstPass = true;

            for (var i = 1; i < a.Length / 2; i += 2) // made few errors about incrementing index
            {
                if (firstPass || a[i] < 100)
                {
                    firstPass  = false;
                    Swap(i, a);
                }
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
