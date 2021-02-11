using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Magic_8_Ball
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

        private MediaPlayer mediaPlayer = new MediaPlayer();

        private void PlayMusic_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Open(new Uri(@"..\..\song.wav", UriKind.Relative));
            mediaPlayer.Volume = 0.6;
            mediaPlayer.Play();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Open(new Uri(@"..\..\cool.wav", UriKind.Relative));
            mediaPlayer.Volume = 0.6;
            mediaPlayer.Play();
        }

        private void StopMusic_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Stop();
        }
    }
}
