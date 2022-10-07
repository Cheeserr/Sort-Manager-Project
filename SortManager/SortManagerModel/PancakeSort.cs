namespace SortManagerModel
{
    public class PancakeSort : ISortable
    {
        private int[] FlipRange(int[] array, int max)
        {
            int start = 0;
            int tmp;
            while (start < max)
            {
                tmp = array[start];
                array[start] = array[max];
                array[max] = tmp;
                start++;
                max--;
            }
            return array;
        }

        private int GetLargestInRange(int[] array, int limit)
        {
            int index = 0;
            for (int i = 0; i < limit; i++)
            {
                if (array[i] > array[index])
                {
                    index = i;
                }
            }
            return index;
        }

        public int[] Sort(int[] array)
        {
            int arrayLength = array.Length;

            // reverse-iterate the array
            for (int i = arrayLength; i > 1; --i)
            {
                int maxIndex = GetLargestInRange(array, i);
                if (maxIndex != i - 1)
                {
                    FlipRange(array, maxIndex);
                    FlipRange(array, i - 1);
                }
            }
            return array;
        }
    }
}
