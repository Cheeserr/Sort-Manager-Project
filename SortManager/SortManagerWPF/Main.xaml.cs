using SortManagerController;
using System;
using System.Linq;
using System.Windows;

namespace SortManagerWPF
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        private void InitAlgorithmComboBox()
        {
            var algorithmNames = Enum.GetValues(typeof(Controller.Sorts)).Cast<Controller.Sorts>();
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

        private void sortArrayButton_Click(object sender, RoutedEventArgs e)
        {
            Controller controller = new Controller();
            controller.ArrayGenerator(Convert.ToInt32(arraySizeBox.Text));
            controller.SortArray(algorithmSelectionBox.SelectedIndex);
            MessageBox.Show($"Sort took {controller.GetProfilerResult()}", "Sort Manager Results");
        }
    }
}
