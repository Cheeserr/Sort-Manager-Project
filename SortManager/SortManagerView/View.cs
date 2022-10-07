using SortManagerController;

namespace SortManagerView
{
    internal class View
    {
        public static void Main()
        {
            Controller controller = new Controller();

            controller.GenerateArray(10);

            Console.WriteLine(controller.ArrayToString());

            controller.SortArray(1);

            Console.WriteLine(controller.ArrayToString());

            Console.WriteLine(controller.profiler.ToString()); 
        }
    }
}
