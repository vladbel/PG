using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG.Sort
{
    public class BubbleSort
    {
        public static void Sort(int[] array)
        {
            var start = 0;
            var end = array.Length - 1;

            while (start < end)
            {
                for (var i = start; i < end; i++)
                {
                    if (array[i] > array[i+1])
                    {
                        // swap values
                        array[i+1] += array[i];
                        array[i] = array[i + 1] - array[i];
                        array[i + 1] -= array[i];
                    }
                }
                end--;

                for (var i = end; i > start; i--)
                {
                    if (array[i] < array[i - 1])
                    {
                        // swap values
                        array[i - 1] += array[i];
                        array[i] = array[i - 1] - array[i];
                        array[i - 1] -= array[i];
                    }
                }
                start ++;
            }
        }
    }
}
