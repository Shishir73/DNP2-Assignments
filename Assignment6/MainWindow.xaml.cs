using System;
using System.IO;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Threading;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Assignment6
{
    public partial class MainWindow : Window
    {
        OpenFileDialog aDialog = new OpenFileDialog();
        TimeSpan _timeSpan;
        DispatcherTimer _dispatchTimer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
            mediaSlider.AddHandler(MouseLeftButtonUpEvent, new MouseButtonEventHandler(Slider_MouseLeftButtonUp), true);
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            aDialog.ShowDialog();
            label_result.Content =  "Opening : " + Path.GetFileName(aDialog.FileName);
            MediaPlayer.Source = new Uri(aDialog.FileName);
            label_result.Content = "Playing : " + Path.GetFileName(aDialog.FileName);
            MediaPlayer.Play();
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            label_result.Content = "Playing : " + Path.GetFileName(aDialog.FileName);
            MediaPlayer.Play();
        }

        private void Pause_Click(object sender, RoutedEventArgs e)
        {
            label_result.Content = "Plausing : " + Path.GetFileName(aDialog.FileName);
            MediaPlayer.Pause();
            label_result.Content = "Plaused : " + Path.GetFileName(aDialog.FileName);

        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            label_result.Content = "Stopping : " + Path.GetFileName(aDialog.FileName);
            MediaPlayer.Stop();
            label_result.Content = "Stopped : " + Path.GetFileName(aDialog.FileName);
        }

        private void MediaElement1_MediaFailed(object sender, ExceptionRoutedEventArgs e)
        {
            MessageBox.Show("Media loading unsuccessful. " + e.ErrorException.Message);
        }

        private void MediaOpened(object sender, RoutedEventArgs e)
        {
            _timeSpan = MediaPlayer.NaturalDuration.TimeSpan;

            _dispatchTimer.Interval = TimeSpan.FromMilliseconds(1);
            _dispatchTimer.Tick += new EventHandler(Ticktimer);
            _dispatchTimer.Start();
        }

        private void Ticktimer(object sender, EventArgs e)
        {
            if (MediaPlayer.NaturalDuration.TimeSpan.TotalSeconds > 0)
            {
                if (_timeSpan.TotalSeconds > 0)
                {
                    mediaSlider.Value = MediaPlayer.Position.TotalSeconds / _timeSpan.TotalSeconds;
                }
            }
        }

        private void Slider_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (_timeSpan.TotalSeconds > 0)
            {
                MediaPlayer.Position = TimeSpan.FromSeconds(mediaSlider.Value * _timeSpan.TotalSeconds);
            }
        }
    }
}
