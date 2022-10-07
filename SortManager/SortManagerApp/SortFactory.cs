using SortManagerModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortManagerController
{
    public abstract class SortFactory
    {
        public ISortable ChooseSort(int choosenSort)
        {
            switch (choosenSort)
            {
                case 0: return new BubbleSort();
                case 1: return new MergeSort();
                case 2: return new SelectionSort();
                case 3: return new NetSort();
                case 4: return new InsertionSort();
                default: return new BubbleSort();
            }
        }
    }
}
