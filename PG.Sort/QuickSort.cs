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
            if ( start >= end )
            {
                // exit
                return;
            }
            else 
            {
                var pivotPosition = start;
                for ( var i = start+1; i<= end; i++)
                {
                    if (array[i] < array[pivotPosition])
                    {
                        // move
                        if ( i == pivotPosition + 1)
                        {
                            var buffer = array[i];
                            array[i] = array[pivotPosition];
                            array[pivotPosition] = buffer;
                        }
                        else
                        {
                            var buffer = array[i];
                            array[i] = array[pivotPosition + 1];
                            array[pivotPosition + 1] = array[pivotPosition];
                            array[pivotPosition] = buffer;
                        }
                        pivotPosition++;
                    }
                }
                Sort(array, start, pivotPosition);
                Sort(array, pivotPosition + 1, end);
            }

        }
    }
}
