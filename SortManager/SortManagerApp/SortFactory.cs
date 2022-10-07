using SortManagerModel;

namespace SortManagerController
{
    public static class SortFactory
    {
        public static ISortable ChooseSort(int choosenSort)
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
