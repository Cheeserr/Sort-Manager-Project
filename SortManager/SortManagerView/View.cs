using SortManagerController;

namespace SortManagerView
{
    internal class View
    {

        public static void Main()
        {
            // -- Starts here
            // -- Selection of algorithms
            // -- Start with bubble
            // -- MainView
            ViewMenu();
        }

        private static void ViewMenu()
        {
            Controller controller = new Controller();
            var userInput = Console.ReadLine();

            while (userInput[0] != 'n')
            {
                Console.WriteLine($"[Option][{userInput}]");
                userInput = Console.ReadLine();
            }

            switch (userInput[0])
            {
                case '1':
                    //controller.ChooseSort(0, array.Length);
                    
                    break;
                case '2':
                    
                    break;
                case '3':

                    break;
            }
        }
    }
}
