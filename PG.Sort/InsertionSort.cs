using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG.Sort
{
    public static class InsertionSort
    {
        public static void Sort( int[] array)
        {
            if (array == null)
            {
                throw new NullReferenceException();
            }
            else if (array.Length < 2)
            {
                return;
            }
            for ( var i = 1; i < array.Length; i++)
            {
                var j = i;
                while ( j > 0 && array[j-1] > array[j])
                {
                    var buffer = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = buffer;
                    j--;
                }
            }
        }
    }
}
