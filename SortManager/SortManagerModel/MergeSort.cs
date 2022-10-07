using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortManagerModel
{
    public class MergeSort : ISortable
    {
        public int[] Sort(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException();
            }
            if (array.Length <= 1) return array;

            int midpoint = array.Length / 2;

            int[] leftSide = new int[midpoint];
            int[] rightSide = new int[array.Length - midpoint];

            for (int i = 0; i < midpoint; i++)
            {
                leftSide[i] = array[i];
            }
            for (int i = 0; i < rightSide.Length; i++)
            {
                rightSide[i] = array[midpoint + i];
            }

            return Merge(Sort(leftSide), Sort(rightSide));
        }

        private int[] Merge(int[] left, int[] right)
        {
            if (left == null || right == null) throw new ArgumentNullException();

            int[] output = new int[left.Length + right.Length];

            int size1 = 0;
            int size2 = 0;

            for (int i = 0; i < output.Length; i++)
            {
                // Comparing next elements of the arrays which haven't been sorted yet
                if (size1 < left.Length && size2 < right.Length)
                {
                    if (left[size1] < right[size2])
                    {
                        output[i] = left[size1];
                        size1++;
                    }
                    else
                    {
                        output[i] = right[size2];
                        size2++;
                    }
                }
                else //If any of the arrays has been fully sorted
                {
                    if (size1 < left.Length)
                    {
                        output[i] = left[size1];
                        size1++;
                    }
                    else
                    {
                        output[i] = right[size2];
                        size2++;
                    }
                }

            }
            return output;
        }
    }
}
