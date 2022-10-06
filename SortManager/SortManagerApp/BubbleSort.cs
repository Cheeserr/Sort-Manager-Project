using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortManagerApp
{
    public class BubbleSort : ISortable
    {
        public int[] Sort(int[] array)
        {
            int listSize = array.Length;
            while (listSize > 1)
            {
                int newListSize = 0;
                for (int i = 1; i <= listSize - 1; i++)
                {
                    if (array[i - 1] > array[i])
                    {
                        Swap(ref array[i - 1], ref array[i]);
                        newListSize = i;
                    }
                }
                listSize = newListSize;
            }
            return array;
        }


        private void Swap(ref int number1, ref int number2)
        {
            int temp = number1;
            number1 = number2;
            number2 = temp;
        }


    }
}
