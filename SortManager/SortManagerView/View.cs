using SortManagerController;

namespace SortManagerView;
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
        Console.WriteLine("\nEnter exit to close the app\n");
        var values = Enum.GetValues(typeof(Controller.Sorts));
        int i = 1;

        foreach (var value in values)
        {
            Console.WriteLine($"[{i}] {value.ToString()}");
            i++;
        }
        var userInput = Console.ReadLine();
        Exit(userInput);
        int result = Controller.Parse(userInput);
        if (result != -1)
        {
            Console.WriteLine("\nPlease, input array size");
            var arraySize = Console.ReadLine();
            Exit(arraySize);
            bool arraySizeParse = Int32.TryParse(arraySize, out int arraySizeInt);
            Thread.Sleep(1000);

            if (arraySizeParse && arraySizeInt >= 0)
            {
                CleanUp();

                ShowResults(result, arraySizeInt);
            }
            else
            {
                Console.WriteLine("\nIncorrect input. \nPress any key to continue");
                Console.ReadKey();
                CleanUp();
            }
        }
        else
        {
            Console.WriteLine("\nIncorrect input. \nPress any key to continue");
            Console.ReadKey();
            CleanUp();
        }

    }

    private static void ShowResults(int result, int arraySize)
    {
        Controller controller = new Controller();

        controller.ArrayGenerator(arraySize);

        Console.WriteLine("Unsorted array: ");
        Console.WriteLine(controller.ShowUnsorted());

        controller.SortArray(result);

        Console.WriteLine("\nSorted array: ");
        Console.WriteLine(controller.ShowSorted());

        Console.WriteLine($"\n Time it took: {controller.GetProfilerResult()} \n");
        Console.WriteLine("\n Press Y to compare to others or anything else to continue.");

        var key = Console.ReadKey();

        if(key.Key == ConsoleKey.Y)
        {
            Console.WriteLine(controller.TestAll(result));

            Console.WriteLine("\n Press any key do continue...");

            Console.ReadKey();

            CleanUp();
        }
        else 
        { 
            CleanUp(); 
        }

        
    }

    private static void CleanUp()
    {
        Console.Clear();
    }

    private static void Exit(string choice)
    {
        if(choice == "exit")
        {
            Console.WriteLine("\nThank you for using our app");
            Console.WriteLine("\nPress any key to continue...");
            Environment.Exit(0);
        }
    }
}
