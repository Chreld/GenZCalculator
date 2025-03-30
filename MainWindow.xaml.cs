using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MemeCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> equation = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NumberButtonClick(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                DisplayTextBox.Text += button.Content.ToString();
            }
        }

        //private string CalculateEquation(string computation)
        //{

        //}

        private void addition(string number)
        {
            equation.Add(number);
            equation.Add(" + ");
        }

        private void subtraction(string number)
        {
            equation.Add(number);
            equation.Add(" - ");
        }

        private void multiplication(string number)
        {
            equation.Add(number);
            equation.Add(" * ");
        }

        private void division(string number)
        {
            equation.Add(number);
            equation.Add(" / ");
        }

        private void Result (int result)
        {

        }
    }
}