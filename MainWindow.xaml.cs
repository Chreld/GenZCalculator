using System.Data;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MemeCalculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClearDisplayCurrent(object sender, RoutedEventArgs e)
        {
            DisplayTextBox.Text = string.Empty;
        }

        private void ClearDisplayEverything(object sender, RoutedEventArgs e)
        {
            DisplayTextBox.Text = string.Empty;
            DisplayTextHistory.Text = string.Empty;
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
            if (sender is Button || (e is KeyEventArgs keyEventArgs && keyEventArgs.Key == Key.Enter))
            {
                var userInput = DisplayTextBox.Text;

                CalculateMemeResponse(DisplayTextBox.Text);

                DisplayTextHistory.Text = $"{userInput} = {DisplayTextBox.Text}";
                DisplayTextBox.Focus();
            }
        }

        private void TerminateSession()
        {
            MessageBox.Show("OH WE ARE NOT DESTROYING THE UNIVERSE TODAY, SESSION TERMINATED", "THE HELL YOU DOING???", MessageBoxButton.OK, MessageBoxImage.Warning);
            Application.Current.Shutdown();
        }

        private void CalculateMemeResponse(string equation)
        {
            string equationTrimmedLowered = Regex.Replace(equation, @"[^a-zA-Z0-9/*+\-(),.]", "").Trim().ToLower();
            
            switch (equationTrimmedLowered)
            {
                case "0/0":
                    DisplayTextBox.Text = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
                    TerminateSession();
                    break;
                case "1":
                    DisplayTextBox.Text = "You're my number 1 ♥";
                    break;
                case "1+1":
                    DisplayTextBox.Text = "11";
                    break;
                case "2+2":
                    DisplayTextBox.Text = "Oh we are taking it safe today, aren't we?";
                    break;
                case "4+4":
                    DisplayTextBox.Text = "Double checking everything today?";
                    break;
                case "6+7":
                    DisplayTextBox.Text = "If 7+7 is 14, then one lower would be 13";
                    break;
                case "9+10":
                    DisplayTextBox.Text = "21";
                    break;
                case "lxix":
                    DisplayTextBox.Text = "Optime, amice ;)";
                    break;
                case "7+(-1/2+5)*20":
                    DisplayTextBox.Text = "Seven-and-a-half-fives. Or 97 if you don't have a potato in your mouth";
                    break;
                case "77+33":
                    DisplayTextBox.Text = "100";
                    break;
                case "fuckyou":
                    DisplayTextBox.Text = "Look at the maidenless, who got beef with a calculator. Touch grass";
                    break;
                case "shrek":
                    DisplayTextBox.Text = "Shrek is love, Shrek is life";
                    break;
                case "whyis6afraidof7":
                    DisplayTextBox.Text = "Because 7 8 9";
                    break;
                case "whoneedtheynumbussyate":
                    DisplayTextBox.Text = "Omg me";
                    break;
                default:
                    CalculateRealResponse(equation);
                    break;
            }
        }

        private void CalculateRealResponse(string equation)
        {
            try
            {
                var result = new DataTable().Compute(equation, null);
                switch (result)
                {
                    case 13:
                        DisplayTextBox.Text = "Ouch, unlucky";
                        break;
                    case 42:
                        DisplayTextBox.Text = "The answer to life, the universe, and everything";
                        break;
                    case 69:
                        DisplayTextBox.Text = "Nice";
                        break;
                    case 333:
                        DisplayTextBox.Text = "Only half as scary as 666";
                        break;
                    case 360:
                        DisplayTextBox.Text = "360 NO SCOPE!";
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
                    case 1111:
                        DisplayTextBox.Text = "Eleventeenth eleventy one";
                        break;
                    case 1337:
                        DisplayTextBox.Text = "Leet";
                        break;
                    case 80085:
                        DisplayTextBox.Text = "Focus on your homework!!!";
                        break;
                    case 8008135:
                        DisplayTextBox.Text = "Oh you need to focus on your homework";
                        break;
                    default:
                        DisplayTextBox.Text = "I need to hear that one more time";
                        break;
                }
            }
            catch
            {
                DisplayTextBox.Text = "ey yo hold up that didn't make any sense. Try again.";
            }
        }
    }
}