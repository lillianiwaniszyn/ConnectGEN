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
    /// Interaction logic for AudioCallWaiting.xaml
    /// </summary>
    public partial class AudioCallWaiting : Window
    {
        Home_Screen homescreen = new Home_Screen();
        System.Timers.Timer aTimer;

        DispatcherTimer _timer;
        TimeSpan _time;
        TimeSpan waitTime;
        int seconds = 0;
        public AudioCallWaiting()
        {
            InitializeComponent();
            //aTimer = new System.Timers.Timer(1000);
            //aTimer.Elapsed += new System.Timers.ElapsedEventHandler(OnTimedEvent);
            //aTimer.Enabled = true;
            //aTimer.SynchronizingObject = this;
            
            _time = TimeSpan.FromSeconds(-10);
            waitTime = TimeSpan.FromSeconds(10);

            _timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                
                if (waitTime <= TimeSpan.Zero) {
                    Timer.Content = _time.ToString("c");
                    this.Timer.Visibility = Visibility.Visible;
                    this.Waiting.Visibility = Visibility.Hidden;
                    
                    //_timer.Stop();
                }
                waitTime = waitTime.Add(TimeSpan.FromSeconds(-1));
                _time = _time.Add(TimeSpan.FromSeconds(1));
            }, Application.Current.Dispatcher);

            _timer.Start();

            //aTimer.Start();
        }

        /*
        private void OnTimedEvent(Object sender, System.Timers.ElapsedEventArgs e)
        {
            seconds++;
            if(seconds >= 10)
            {
                this.Timer.Visibility = Visibility.Visible;
                this.Waiting.Visibility = Visibility.Hidden;
                aTimer.Stop();
                _timer.Start();
            }
            //Timer.Content = e.SignalTime.ToString();

        }
        */


        private void End_Call_Click(object sender, RoutedEventArgs e)
        {
            homescreen.Show();
            this.Close();
        }
    }
}
