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
    /// Interaction logic for VideoCallNoAnswer.xaml
    /// </summary>
    public partial class VideoCallNoAnswer : Window
    {
        DispatcherTimer _timer;
        TimeSpan _time;
        TimeSpan waitTime;
        Home_Screen homescreen = new Home_Screen();
        Global_Data dataClass = new Global_Data();

        public VideoCallNoAnswer()
        {
            InitializeComponent();

            _time = TimeSpan.FromSeconds(15);
            waitTime = TimeSpan.FromSeconds(10);

            _timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {

                if (waitTime <= TimeSpan.Zero)
                {
                    //Timer.Content = _time.ToString("c");
                    NoAnswer.Visibility = Visibility.Visible;
                    Waiting.Visibility = Visibility.Hidden;
                    //_timer.Stop();
                }
                if (_time == TimeSpan.Zero)
                {
                    homescreen.Show();
                    this.Close();
                }
                waitTime = waitTime.Add(TimeSpan.FromSeconds(-1));
                _time = _time.Add(TimeSpan.FromSeconds(-1));
            }, Application.Current.Dispatcher);

            _timer.Start();
        }

        public void setImage(int index)
        {
            Receiving.Source = new BitmapImage(new Uri(dataClass.homescreenContacts[index], UriKind.Relative));
        }

        private void End_Call_Click(object sender, RoutedEventArgs e)
        {
            homescreen.Show();
            this.Close();
        }
    }
}
