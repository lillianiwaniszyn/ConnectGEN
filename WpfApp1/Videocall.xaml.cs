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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class VideoCall : Window
    {
        Home_Screen homescreen = new Home_Screen();
        DispatcherTimer _timer;
        TimeSpan _time;
        Global_Data dataClass = new Global_Data();
        public VideoCall()
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

        public void setImage(int index)
        {
            Receiving.Source = new BitmapImage(new Uri(dataClass.homescreenContacts[index], UriKind.Relative));
        }

        private void End_Call_Click(object sender, RoutedEventArgs e)
        {
            homescreen.Show();
            this.Close();
        }

        private void EndCall_Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            homescreen.Show();
            this.Close();
        }
    }
}
