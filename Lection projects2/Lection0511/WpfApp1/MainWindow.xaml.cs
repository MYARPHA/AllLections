using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            label2.AllowDrop = true;

            ListBox1.Items.Add("qwe");
            ListBox1.Items.Add("asd");
            ListBox1.Items.Add("zxc");
            ListBox1.Items.Add("12345");
        }

        private void Label1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var element = sender as Label;
            DragDrop.DoDragDrop(element, element.Content, DragDropEffects.Copy);
        }

        private void Label2_Drop(object sender, DragEventArgs e)
        {
            var element = sender as Label;
            element.Content = e.Data.GetData(DataFormats.Text);
        }

        private void ValuesListBox_Drop(object sender, DragEventArgs e)
        {
            var element = sender as ListBox;
            element.Items.Add(e.Data.GetData(DataFormats.Text));
        }

        private void ListBox1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var selected = ListBox1.SelectedItem;
            DragDrop.DoDragDrop(ListBox1, selected, DragDropEffects.Copy);
        }

        private void ListBox2_Drop(object sender, DragEventArgs e)
        {
            ListBox2.Items.Add(e.Data.GetData(DataFormats.Text));
        }

        private void ListBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        { 
            DragDrop.DoDragDrop(ListBox1, ListBox1.SelectedItem, DragDropEffects.Copy);
        }
    }
}