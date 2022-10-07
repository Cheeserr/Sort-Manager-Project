using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortManagerModel
{
    public class SelectionSort : ISortable
    {
        public int[] Sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                var min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[min] > array[j])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    int newMin = array[min];
                    array[min] = array[i];
                    array[i] = newMin;
                }

            }
            return array;

        }
    }
}
