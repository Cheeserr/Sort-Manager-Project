using SortManagerController;

namespace SortManagerView
{
    internal class View
    {
        public static void Main()
        {
            while (true)
            {
                ViewMenu();
            }
        }

        private static void ViewMenu()
        {
            var values = Enum.GetValues(typeof(Controller.Sorts));
            int i = 1;

            foreach(var value in values)
            {
                Console.WriteLine($"[{i}] {value.ToString()}");
                i++;
            }
            var userInput = Console.ReadLine();
            int result = Controller.Parse(userInput);

            Console.WriteLine("\nPlease, input array size");
            int arraySize = Console.Read();

            Thread.Sleep(1000);

            CleanUp();

            ShowResults(result, arraySize);
        }

        private static void ShowResults(int result, int arraySize)
        {
            Controller controller = new Controller();

            controller.ArrayGenerator(arraySize);

            Console.WriteLine("Unsorted array: ");
            Console.WriteLine(controller.ArrayToString());

            controller.SortArray(result);

            Console.WriteLine("\nSorted array: ");
            Console.WriteLine(controller.ArrayToString());

            Console.WriteLine($"\n Time it took: {controller.profiler.ToString()} \n");
            Console.WriteLine("\n Press any key do continue...");


            Console.ReadKey();

            CleanUp();
        }

        private static void CleanUp()
        {
            Console.Clear();
        }

        private void ExitForm(Object sender, FormClosedEventArgs e)
        {

        }
    }
}
