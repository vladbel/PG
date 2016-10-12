using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG.DP
{
    public class RepeatingElementMaxCount
    {
        /// <summary>
        /// assums all elements are 
        /// 1) positive
        /// 2) much less then int.MaxValue ( no overflow )
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static Tuple<int, int> Count(int[] array)
        {
            // Find element cieling - O(n)
            int cieling = 0;
            for (var i = 0; i < array.Length; i++)
            {
                if ( array[i] > cieling)
                {
                    cieling = array[i];
                }
            }
            cieling += 1;

            //cieling shall not be greater than array length

            // count repetitions
            for (var i = 0; i < array.Length; i++)
            {
                array[array[i] % cieling] += cieling;
            }


            // read results O(n) - could be combined with prev step
            int maxCount = 0;
            int elementValue = 0;

            for (var i = 0; i < array.Length; i++)
            {
                var curCount = array[i] / cieling;
                var curVal = i;

                if ( curCount > maxCount)
                {
                    maxCount = curCount;
                    elementValue = curVal;
                }
            }

            // restore
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = array[i] % cieling;
            }

            return new Tuple<int, int>(elementValue, maxCount);
        }
    }
}
