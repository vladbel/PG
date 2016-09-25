using PG.BT;

namespace PG.Sort
{
    public static class HeapSort
    {
        public static void Sort (int[] array)
        {
            Heap.HeapifyArray(array);

            for (var i = array.Length -1; i > 1; i--)
            {
                // swap the last unsorted and 0
                var temp = array[0];
                array[0] = array[i];
                array[i] = temp;

                Heap.SetMaxHeapProperty(array, 0, i - 1);
            }
        }
    }
}
