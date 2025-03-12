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

namespace Lection0510
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Button clearButton = new();
            clearButton.Content = "Clear";
            clearButton.Click += ClearButton_Click; // Tab
            panel.Children.Add(clearButton);
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            numberTextBox.Clear();
        }

        private void Window_Initialized(object sender, EventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //e.Cancel = true;
        }

        private void Window_Closed(object sender, EventArgs e)
        {

        }

        private void Window_Unloaded(object sender, RoutedEventArgs e)
        {

        }

        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {

            var button = e.Source as Button;
            numberTextBox.Text += button.Content;
        }

        private void NumberTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            infoLabel.Content = e.Key.ToString();
            if (e.KeyboardDevice.Modifiers == ModifierKeys.Control)
            {

            }
           
        }

        private void NumberTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void NumberTextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
                e.Handled = true;
            else if (e.Key ==Key.Decimal && numberTextBox.Text.Contains("."))
                e.Handled = true;
        }

        private void NumberTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Int32.TryParse(e.Text, out int number) && numberTextBox.Text.Contains("-"))
                e.Handled = true;
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}