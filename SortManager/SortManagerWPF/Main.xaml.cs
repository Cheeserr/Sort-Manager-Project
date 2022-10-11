using SortManagerController;
using System;
using System.Windows;
using System.Windows.Controls;

namespace SortManagerWPF
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        private void InitAlgorithmComboBox()
        {
            var algorithmNames = Enum.GetValues(typeof(Controller.Sorts));
            foreach (var algorithm in algorithmNames)
            {
                algorithmSelectionBox.Items.Add(algorithm);
            }
            algorithmSelectionBox.SelectedIndex = 0;
        }

        public Main()
        {
            InitializeComponent();
            InitAlgorithmComboBox();
        }

        private void ClearAndSetTextBox(RichTextBox textBox, string value)
        {
            textBox.Document.Blocks.Clear();
            textBox.AppendText(value);
        }

        private void AttemptSort(int arraySize, Controller.Sorts algorithm)
        {
            if (arraySize < 0) throw new ArgumentException("arraySize must be a positive number");

            Controller controller = new Controller();
            controller.MinRange = -1000;
            controller.MinRange = 1000;

            controller.ArrayGenerator(arraySize);
            var unsorted = controller.ShowUnsorted(); // capture the random array pre-sort

            //TODO: Maybe speak with others about refactoring this to an enum value instead of an int
            controller.SortArray(((int)algorithm));

            sortDurationLabel.Content = $"Sorting took {controller.GetProfilerResult()}";
            ClearAndSetTextBox(unsortedArrayTextBox, unsorted);
            ClearAndSetTextBox(sortedArrayTextBox, controller.ShowSorted());
        }

        private void sortArrayButton_Click(object sender, RoutedEventArgs e)
        {
            int arraySize;
            if (!int.TryParse(arraySizeBox.Text, out arraySize))
            {
                MessageBox.Show("Enter a valid number for the array size", "Sort Manager", MessageBoxButton.OK, MessageBoxImage.Error);
                arraySizeBox.Text = "0";
                return;
            }

            var algorithm = ((Controller.Sorts)algorithmSelectionBox.SelectedIndex);
            AttemptSort(arraySize, algorithm);
        }
        private void aboutButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("A Simple WPF GUI for Sort Manager\nBy Adam, Connor, Lewis, Nathan, Sergiusz and Tudor", "Sort Manager");
        }

    }
}
