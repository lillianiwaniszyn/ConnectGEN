using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for VideoCallWaiting.xaml
    /// </summary>
    public partial class VideoCallWaiting : Window
    {
        Home_Screen homescreen = new Home_Screen();
        DispatcherTimer _timer;
        TimeSpan _time;
        TimeSpan waitTime;
        public VideoCallWaiting()
        {
            InitializeComponent();

            _time = TimeSpan.FromSeconds(-10);
            waitTime = TimeSpan.FromSeconds(10);

            _timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {

                if (waitTime <= TimeSpan.Zero)
                {
                    Timer.Content = _time.ToString("c");
                    this.Timer.Visibility = Visibility.Visible;
                    this.Waiting.Visibility = Visibility.Hidden;

                    //_timer.Stop();
                }
                if(waitTime == TimeSpan.Zero)
                {
                    this.Video.Visibility = Visibility.Visible;
                    Video.Play();
                }
                waitTime = waitTime.Add(TimeSpan.FromSeconds(-1));
                _time = _time.Add(TimeSpan.FromSeconds(1));
            }, Application.Current.Dispatcher);

            _timer.Start();
        }

        private void End_Call_Click(object sender, RoutedEventArgs e)
        {
            homescreen.Show();
            this.Close();
        }
    }
}
