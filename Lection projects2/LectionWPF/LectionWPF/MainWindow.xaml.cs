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

namespace LectionWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            StackPanel panel = new();
            Label label = new();
            for (int i = 1; i <= 10; i++)
            {
                label = new();
                label.Content = $"text {i}";
                panel.Children.Add(label);
            }
            //button.Content = panel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1();
            window.Show();
        }
    }
}