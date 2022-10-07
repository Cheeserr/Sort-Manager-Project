using SortManagerController;

namespace SortManagerView
{
    internal class View
    {
        public static void Main()
        {
            var values = Enum.GetValues(typeof(Controller.Sorts));

            foreach (var value in values) Console.WriteLine(value);
        }
    }
}
