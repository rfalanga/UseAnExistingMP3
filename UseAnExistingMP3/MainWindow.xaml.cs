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
            mediaPlayer.Open(new Uri(Environment.CurrentDirectory + @"\Assets\Doctor_Who_-_Gold_Abridged.mp3", UriKind.RelativeOrAbsolute));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PlayTheSound();
        }

        private void PlayTheSound()
        {
            //This helper function isn't necessary
            mediaPlayer.Play();
        }
    }
}
