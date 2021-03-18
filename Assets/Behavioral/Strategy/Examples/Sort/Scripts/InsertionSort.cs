using System.Collections.Generic;

namespace Strategy
{
    public class InsertionSort : ISortBehaviour
    {
        public void Sort(ref List<int> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                var item = input[i];
                var currentIndex = i;

                while (currentIndex > 0 && input[currentIndex - 1] > item)
                {
                    input[currentIndex] = input[currentIndex - 1];
                    currentIndex--;
                }

                input[currentIndex] = item;
            }
        }
    }
}