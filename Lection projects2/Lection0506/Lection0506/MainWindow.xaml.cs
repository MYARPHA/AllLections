using System.Windows;

namespace Lection0506
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            /*OpenFileDialog dialog = new();
            dialog.Filter = "растровые|*.png;*.jpg;*.jpeg|векторные|*.svg|все файлы|*.*";
            dialog.InitialDirectory = Environment.CurrentDirectory; //любой путь к папке
            dialog.Title = "Выбор изображения";

            dialog.Multiselect = true; //несколко файлов

            if (dialog.ShowDialog().Value != true)
                return;*/
            //Title = String.Join(";", dialog.FileName); 

            /*SaveFileDialog dialog = new();
            if (dialog.ShowDialog().Value != true)
                return;
            Title = dialog.SafeFileName;*/

            // System.Windows.Forms
            //FontDialog / ColorDialog / FolderBrowserDialog

            /*MessageBox.Show("текст сообщения",
                "заголовок",
                MessageBoxButton.Кнопки,
                MessageBoxImage.Пиктограмма);*/

            /*PrintDialog dialog = new();
            if (dialog.ShowDialog() != true)
                return; //печатает в режиме контейнера
            dialog.PrintVisual(grid, "описание");*/


        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Hide();

            MyDialog window = new();

            //window.Owner = this;
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            //window.WindowState = WindowState.Maximized;
            //window.ShowInTaskbar = false;
            window.ResizeMode = ResizeMode.NoResize;

            if (window.ShowDialog().Value != true)
                return;
            MessageBox.Show(window.Data);

            //MainWindow window1 = new();
            Show();

            e.Cancel = true;
            /*if (MessageBox.Show("Вы уверены, что хотите закрыть окно??",
                "Закрытые",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question) != MessageBoxResult.Yes)
                e.Cancel = true;*/
        }
    }
}