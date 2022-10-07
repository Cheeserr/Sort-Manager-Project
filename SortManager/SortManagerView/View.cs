namespace SortManagerView
{
    internal class View
    {
        public static void Main()
        {
            ChangeSortingAlgorithm(0, new int[] { 2, 1, -3, -4 });
        }

        public View()
        {

        }

        public static bool ChangeSortingAlgorithm(int option, int[] array)
        {
            switch (option)
            {
                case 0:
                    ViewResultOfBubbleSort(array);
                    return true;
                case 1:

                    return true;
                case 2:

                    return true;
            }
            return false;
        }

        public static void ViewResultOfBubbleSort(int[] array)
        {
            SortManagerModel.BubbleSort bubbleSort = new SortManagerModel.BubbleSort();
            var result = bubbleSort.Sort(array);

            Console.Write($"[");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{result[i]}, ");
            }
            Console.Write($"]");
        }
    }
}
