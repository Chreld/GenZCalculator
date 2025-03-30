using System.Data;
using System.Linq.Expressions;
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

        private void CalculateEquationClick(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                CalculateMemeResponse(DisplayTextBox.Text);
            }
        }

        private void CalculateMemeResponse(string equation)
        {
            switch (equation)
            {
                case "9+10":
                    DisplayTextBox.Text = "21";
                    break;
                case "LXIX":
                    DisplayTextBox.Text = "Optime, amice ;)";
                    break;
                default:
                    CalculateRealResponse(equation);
                    break;
            }
        }

        private void CalculateRealResponse(string equation)
        {
            var result = new DataTable().Compute(equation, null);
            switch (result)
            {
                case 69:
                    DisplayTextBox.Text = "Nice";
                    break;
                default:
                    DisplayTextBox.Text = "ey yo hold up that didn't make any sense";
                    break;
            }
        }

        private void Addition(string number)
        {
            equation.Add(number);
            equation.Add(" + ");
        }

        private void Subtraction(string number)
        {
            equation.Add(number);
            equation.Add(" - ");
        }

        private void Multiplication(string number)
        {
            equation.Add(number);
            equation.Add(" * ");
        }

        private void Division(string number)
        {
            equation.Add(number);
            equation.Add(" / ");
        }
    }
}