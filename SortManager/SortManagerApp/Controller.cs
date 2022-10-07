using System.Drawing;

namespace SortManagerApp
{
    public class Controller
    {
        ISortable? sortMethod = null;
        int[] array;

        void ChooseSort(int value, int sizeOfArray)
        {
            switch (value)
            {
                case 0: sortMethod = new BubbleSort();
                    break;
                case 1:
                    sortMethod = new MergeSort();
                    break;
                case 2:
                    sortMethod = new SelectionSort();
                    break;
                default:
                    break;
            }
        }

        int[] GenerateArray(int arraySize)
        {
            Random random = new Random();
            int[] output = new int[arraySize];

            for(int i = 0; i < arraySize; i++)
            {
                output[i] = random.Next(1, 100);
            }

            return output;
        }
    }
}