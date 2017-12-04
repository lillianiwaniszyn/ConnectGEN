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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for AudioCallWaiting.xaml
    /// </summary>
    public partial class AudioCallWaiting : Window
    {
        private System.Timers.Timer aTimer;
        private int setUpTime;
        private int elapsedTime;
        public AudioCallWaiting()
        {
            InitializeComponent();
            aTimer = new System.Timers.Timer();
            aTimer.Interval = 1000;
            aTimer.Elapsed += TimeElasped;
            aTimer.AutoReset = true;
            aTimer.Start();
        }


        private void TimeElasped(Object sender, System.Timers.ElapsedEventArgs e)
        {
            //if(setUpTime > 10)
            //{

            //}


            //setUpTime++;
            

        }

        private void End_Call_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
