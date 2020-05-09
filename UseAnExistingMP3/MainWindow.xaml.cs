using System;
using System.Windows;
using System.Windows.Media;

namespace UseAnExistingMP3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MediaPlayer mediaPlayer;

        public MainWindow()
        {
            InitializeComponent();

            mediaPlayer = new MediaPlayer();
            mediaPlayer.Open(new Uri(@"../../Assets/Doctor_Who_-_Gold_Abridged.mp3", UriKind.RelativeOrAbsolute));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Play();
        }
    }
}
