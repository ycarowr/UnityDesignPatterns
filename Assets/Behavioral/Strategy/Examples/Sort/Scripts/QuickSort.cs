using System.Collections.Generic;
using System.Linq;

namespace Strategy
{
    public class QuickSort : ISortBehaviour
    {
        private void Swap(ref int x, ref int y)
        {
            var t = x;
            x = y;
            y = t;
        }
        
        private int Partition(int[] array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }

            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }
        
        private int[] DoQuickSort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            var pivotIndex = Partition(array, minIndex, maxIndex);
            DoQuickSort(array, minIndex, pivotIndex - 1);
            DoQuickSort(array, pivotIndex + 1, maxIndex);

            return array;
        }
        
        public void Sort(ref List<int> input)
        {
            var array = input.ToArray();
            input = DoQuickSort(array, 0, array.Length - 1).ToList();
        }
    }
}