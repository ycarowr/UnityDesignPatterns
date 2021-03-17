using System.Collections.Generic;
using System.Linq;

namespace Strategy
{
    public class ShellSort : ISortBehaviour
    {
        private void Swap(ref int a, ref int b)
        {
            var t = a;
            a = b;
            b = t;
        }

        private int[] DoShellSort(int[] array)
        {
            var d = array.Length / 2;
            while (d >= 1)
            {
                for (var i = d; i < array.Length; i++)
                {
                    var j = i;
                    while ((j >= d) && (array[j - d] > array[j]))
                    {
                        Swap(ref array[j], ref array[j - d]);
                        j = j - d;
                    }
                }

                d = d / 2;
            }

            return array;
        }
        
        public void Sort(ref List<int> input)
        {
            var array = input.ToArray();
            input = DoShellSort(array).ToList();
        }
    }
}