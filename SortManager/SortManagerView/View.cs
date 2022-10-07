using SortManagerController;

namespace SortManagerView
{
    internal class View
    {
        public static void Main()
        {
            ViewMenu();
        }

        private static bool ViewMenu()
        {
            Controller controller = new Controller();

            string menuOptions = $"[Option][1]\n[Option][2]\n[Option][3][Option][4][Option][5][Option][6]\n\nOption: ";
            Console.Write(menuOptions);
            
            var userInput = Console.ReadLine();
            bool result = Int32.TryParse(userInput, out int intResult);
            
            while (result)
            {
                if (!result) break;
                Console.WriteLine($"\n[SelectedOption][{userInput}]");

                //controller sort
                Console.WriteLine($"[IsAvailable][{Sort(intResult)}]\n");

                ViewMenu();
                return true;
            }
            return false;
        }

        public static bool Sort(int chosenOption)
        {
            switch (chosenOption)
            {
                case 1:
                    return true;
                case 2:
                    return true;
                case 3:
                    return true;
                case 4:
                    return true;
                case 5:
                    return true;
                case 6:
                    return true;
                case 7:
                    return true;
            }
            return false;
        }
    }
}
