using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortManagerModel
{
    public class HeapSort : ISortable
    {
        public int[] Sort(int[] array)
        {
            if (array is null)
            {
                throw new ArgumentNullException();
            }
            
            for (int i = array.Length / 2 - 1; i >= 0; i--)
            {
                heapify(array, array.Length, i);
            }
            for (int i = array.Length - 1; i >= 0; i--)
            {
                int temp = array[0];
                array[0] = array[i];
                array[i] = temp;
                heapify(array, i, 0);
            }
            return array;
        }

        public void heapify(int[] array, int n, int i)
        {
            int largestValue = i;
            int leftMostValue = 2 * i + 1;
            int rightMostValue = 2 * i + 2;
            if (leftMostValue < n && array[leftMostValue] > array[largestValue])
            {
                largestValue = leftMostValue;
            }
            if (rightMostValue < n && array[rightMostValue] > array[largestValue])
            {
                largestValue = rightMostValue;
            }
            if (largestValue != i)
            {
                int swap = array[i];
                array[i] = array[largestValue];
                array[largestValue] = swap;
                heapify(array, n, largestValue);
            }
        }
    }
}
