using SortManagerController;

namespace SortManagerView
{
    internal class View
    {
        public static void Main()
        {
            Controller controller = new Controller(10);

            int[] array;
            controller.ChooseSort(1);
            array = controller.SortArray();

            Console.WriteLine(controller.ArrayToString());
            Console.WriteLine($"{controller.profiler.Milliseconds} milliseconds");

        }
    }
}
