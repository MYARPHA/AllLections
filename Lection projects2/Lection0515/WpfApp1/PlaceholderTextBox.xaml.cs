using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для PlaceholderTextBox.xaml
    /// </summary>
    public partial class PlaceholderTextBox : UserControl
    {
        public string Text { get; set; }

        public PlaceholderTextBox()
        {
            InitializeComponent();
        }

        private void ContentTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ContentTextBox.Text.Length > 0)
            {
                HintTextBlock.Visibility = Visibility.Hidden;
            }
            else
            { 
                HintTextBlock.Visibility = Visibility.Visible; 
            }
        }
    }
}
