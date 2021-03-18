using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Strategy
{
    /*
     * The class provides to different algorithms a list to be sorted and
     * it logs the time spent to sort the list. This way, for the same set
     * of elements we can compare how fast each sorting algorithm performs.
     */
    public class SortClient : MonoBehaviour
    {
        private enum SortType
        {
            Bubble, Insertion, Selection, Quick, Shell,
            Merge
        }
     
        private readonly BubbleSort _bubbleSort = new BubbleSort();
        private readonly InsertionSort _insertion = new InsertionSort();
        private readonly SelectionSort _selection = new SelectionSort();
        private readonly QuickSort _quick = new QuickSort();
        private readonly ShellSort _shell = new ShellSort();
        private readonly MergeSort _merge = new MergeSort();
        
        [SerializeField] private SortType current = SortType.Bubble;
        [SerializeField] private List<int> elements;
        [SerializeField] private int amount;

        private DateTime _startTime;
        
        [Button]
        public void SetupElements()
        {
            var count = amount;
            var list = new List<int>();
            while (count > 0)
            {
                --count;
                list.Add(count);
            }

            elements = list;
        }
        
        [Button]
        public void Clear()
        {
            elements.Clear();    
        }
        
        [Button]
        public void ExecuteSorting()
        {
            StartWatch();
            switch (current)
            {
                case SortType.Bubble:
                    _bubbleSort.Sort(ref elements);
                    break;
                case SortType.Insertion:
                    _insertion.Sort(ref elements);
                    break;
                case SortType.Selection:
                    _selection.Sort(ref elements);
                    break;
                case SortType.Quick:
                    _quick.Sort(ref elements);
                    break;
                case SortType.Shell:
                    _shell.Sort(ref elements);
                    break;
                case SortType.Merge:
                    _merge.Sort(ref elements);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }   
            StopWatch();
        }

        private void StartWatch()
        {
            _startTime = DateTime.Now;
        }

        private void StopWatch()
        {
            var delta = _startTime - DateTime.Now;
            var seconds = delta.TotalSeconds;
            Debug.Log(Mathf.Abs((float)seconds));   
        }
    }
}