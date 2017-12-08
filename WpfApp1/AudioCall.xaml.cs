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
    //test comment
    /// Interaction logic for AudioCall.xaml
    /// </summary>
    public partial class AudioCall : Window
    {
        Home_Screen mainScreen = new Home_Screen();
        


        DispatcherTimer _timer;
        TimeSpan _time;
        public AudioCall()
        {
            InitializeComponent();



            _time = TimeSpan.FromSeconds(0);

            _timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                Timer.Content = _time.ToString("c");
                //if (_time == TimeSpan.Zero) _timer.Stop();
                _time = _time.Add(TimeSpan.FromSeconds(1));
            }, Application.Current.Dispatcher);

            _timer.Start();
        }

        

        private void End_Call_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            mainScreen.Show();
        }

        private void EndCallImage_MouseUp(object sender, MouseButtonEventArgs e)
        {
            mainScreen.Show();
            this.Close();
        }
    }
}
