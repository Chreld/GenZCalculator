using System.Data;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

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
            string equationTrimmedLowered = equation.Replace(" ", "").Trim().ToLower();
            switch (equationTrimmedLowered)
            {
                case "1+1":
                    DisplayTextBox.Text = "11";
                    break;
                case "2+2":
                    DisplayTextBox.Text = "Oh we are taking it safe today, aren't we?";
                    break;
                case "6+7":
                    DisplayTextBox.Text = "If 7+7 is 14, then one lower would be 13";
                    break;
                case "9+10":
                    DisplayTextBox.Text = "21";
                    break;
                case "LXIX":
                    DisplayTextBox.Text = "Optime, amice ;)";
                    break;
                case "7+(-1/2+5)*20":
                    DisplayTextBox.Text = "Seven-and-a-half-fives. Or 97 if you don't have a potato in your mouth";
                    break;
                case "fuckyou":
                    DisplayTextBox.Text = "Look at the maidenless, who got beef with a calculator. Touch grass";
                    break;
                case "Whyis6afraidof7"
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
                case 13:
                    DisplayTextBox.Text = "Unlucky 13";
                    break;
                case 69:
                    DisplayTextBox.Text = "Nice";
                    break;
                case 420:
                    DisplayTextBox.Text = "Grow up";
                    break;
                case 666:
                    DisplayTextBox.Text = "Hello demons, it's me, ya boy";
                    break;
                case 911:
                    DisplayTextBox.Text = "911, what's your emergency?";
                    break;
                default:
                    DisplayTextBox.Text = "ey yo hold up that didn't make any sense. Try again.";
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