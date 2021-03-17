using System.Collections.Generic;

namespace Strategy
{
    public class SelectionSort : ISortBehaviour
    {
        public void Sort(ref List<int> input)
        {
            for (var i = 0; i < input.Count; i++)
            {
                var min = i;
                for(var j = i + 1; j < input.Count; j++) { 
                    if(input[min] > input[j])
                    {
                        min = j;
                    }
                }

                if(min != i)
                {
                    var lowerValue = input[min];
                    input[min] = input[i];
                    input[i] = lowerValue;
                }
            }
        }
    }
}