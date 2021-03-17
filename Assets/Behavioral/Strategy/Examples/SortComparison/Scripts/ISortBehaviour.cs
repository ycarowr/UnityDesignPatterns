using System.Collections.Generic;

namespace Strategy
{
    public interface ISortBehaviour
    {
        void Sort(ref List<int> input);
    }
}