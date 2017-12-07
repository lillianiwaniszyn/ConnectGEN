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
    /// Interaction logic for AudioCallNoAnswer.xaml
    /// </summary>
    public partial class AudioCallNoAnswer : Window
    {
        DispatcherTimer _timer;
        TimeSpan _time;
        TimeSpan waitTime;
        Home_Screen homescreen = new Home_Screen();
        public AudioCallNoAnswer()
        {
            InitializeComponent();
        }

        private void End_Call_Click(object sender, RoutedEventArgs e)
        {
            homescreen.Show();
            this.Close();
        }
    }
}
