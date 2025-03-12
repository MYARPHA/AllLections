using System.Media;
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

using System.Speech;
using System.Speech.Recognition;

namespace Lection0516
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
        }

        private void TestSoundPlayer_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer player = new();
            player.SoundLocation = "forest.wav";
            player.Load();
            player.PlayLooping(); //зациклили
        }

        private void TestSystemSound_Click(object sender, RoutedEventArgs e)
        {
            SystemSounds.Question.Play();
        }

        MediaPlayer player = new();
        private void TestMediaPlayer_Click(object sender, RoutedEventArgs e)
        {
            player.Open(new Uri("sounds\\child.mp3", UriKind.Relative));
            player.Play();
        }

        private void PauseMediaPlayer_Click(object sender, RoutedEventArgs e)
        {
            
            //RenderTargetBitmap bitmap = new(...);
            //bitmap.Render(myMediaElement);
            //image.Source = BitmapFrame.Create(bitmap);

            //myMediaElement.Position = TimeSpan.Zero;
            //myMediaElement.Position = TimeSpan.FromSeconds(60);
            //myMediaElement.Position = new TimeSpan(0, 2, 45);
            //player.Play();

            //myMediaElement.Pause();
        }
    }
}