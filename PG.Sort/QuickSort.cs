using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG.Sort
{
    public class QuickSort
    {
        public static void Sort (int[] array)
        {
            Sort(array, 0, array.Length- 1);
        }

        private static void Sort (int[] array, int start, int end)
        {
            if ( start == end )
            {
                // exit
                return;
            }
            else 
            {
                var pivotPosition = start;
                
            }
        }
    }
}
