using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortManagerModel
{
    internal class Insertion : ISortable
    {
        public int[] Sort(int[] array)
        {
            if (array is null)
            {
                throw new ArgumentNullException();
            }
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        int temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }
    }
}
