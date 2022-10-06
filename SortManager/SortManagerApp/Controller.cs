using System.Drawing;

namespace SortManagerApp
{
    internal class Controller
    {
        void ChooseSort(int value, int sizeOfArray)
        {
            int[] array = GenerateArray(sizeOfArray);
            switch (value)
            {
                case 0: array = BubbleSort.Sort(array);
                    break;
                case 1: array = MergeSort.Sort(array);
                    break;
                default:
                    break;
            }
        }

        int[] GenerateArray(int arraySize)
        {
            return new int[arraySize];
        }
    }
}