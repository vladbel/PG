using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG.BT
{
    public class Heap
    {
        public static int Parent(int i)
        {
            return (i + 1) / 2 - 1; //floor
        }

        public static int Left (int i)
        {
            return 2 * (i + 1) - 1;
        }

        public static int Right (int i)
        {
            return 2 * (i + 1);
        }

        public static void SetMaxHeapProperty( int[] array, 
                                              int index,
                                              int heapSize = -1)
        {
            var leftChild = Left(index);
            var rightChild = Right(index);
            int largest;
            if (heapSize < 0)
            {
                heapSize = array.Length;
            }

            if (leftChild < heapSize && array[leftChild] > array[index])
            {
                largest = leftChild;
            }
            else
            {
                largest = index;
            }

            if (rightChild < heapSize && array[rightChild] > array[largest])
            {
                largest = rightChild;
            }

            if (largest != index)
            {
                var a = array[index];
                array[index] = array[largest];
                array[largest] = a;
                SetMaxHeapProperty(array, largest, heapSize);
            }
        }

        public static void HeapifyArray ( int[] array)
        {
            for ( var i = array.Length/2; i >=0; i--)
            {
                SetMaxHeapProperty(array, i);
            }
        }
    }
}
