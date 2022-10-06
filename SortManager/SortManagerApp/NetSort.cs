namespace SortManagerApp
{
    public class NetSort : ISortable
    {
        public int[] Sort(int[] array)
        {
            if (array is null)
                throw new ArgumentNullException();

            Array.Sort(array);
            return array;
        }
    }
}
