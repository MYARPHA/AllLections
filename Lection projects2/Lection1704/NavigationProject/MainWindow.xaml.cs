using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Resources;
using System.Windows.Shapes;
using NavigationProject.Pages;

namespace NavigationProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            App.CurrentFrame = MainFrame;
            App.CurrentFrame.Navigate(new MenuPage());

            //var cursorUri = new Uri("working.ani", UriKind.Relative);
            //StreamResourceInfo streamResourceInfo = Application.GetResourceStream(cursorUri);
            //Cursor = new(streamResourceInfo.Stream);

            var imagePath = new Uri(@"pack://application:,,,/Images/galaxy.jpg");
            var bitmapImage = new BitmapImage(imagePath);
            image1.Source = bitmapImage;
            //ellipse.Fill = new ImageBrush(bitmapImage);
            ellipse.Width = 100;

            //SolidColorBrush brush = new(Colors.CadetBlue);
            //ellipse.Fill = brush;

            // LinearGradientBrush
            // RadialGradientBrush

            var imagePath2 = new Uri(@"X:\МДК.01.01\Images\background.jpg");
            var bitmapImage2 = new BitmapImage(imagePath2);
            image2.Source = bitmapImage2;

            var imagePath3 = new Uri(@"\Resources\plant.png", UriKind.Relative);
            var bitmapImage3 = new BitmapImage(imagePath3);
            image3.Source = bitmapImage3;
            image3.Width = 100;
            image3.Source = bitmapImage3;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.GoBack();
        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            //BackButton.IsEnabled = MainFrame.CanGoBack; //CanGoForward
            if (MainFrame.CanGoBack)
                BackButton.Visibility = Visibility.Visible;
            else
                BackButton.Visibility = Visibility.Hidden;

        }

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}