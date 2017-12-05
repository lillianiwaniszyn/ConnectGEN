﻿using System;
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
    //test comment
    /// Interaction logic for AudioCall.xaml
    /// </summary>
    public partial class AudioCall : Window
    {
        Home_Screen mainScreen = new Home_Screen();
        System.Timers.Timer aTimer;
        public AudioCall()
        {
            InitializeComponent();
            aTimer = new System.Timers.Timer(1000);
            aTimer.Elapsed += new System.Timers.ElapsedEventHandler(OnTimedEvent);
            aTimer.Enabled = true;
            aTimer.Start();
        }


        private void OnTimedEvent(Object sender, System.Timers.ElapsedEventArgs e)
        {
            Timer.Content = e.SignalTime.ToString();

        }
        private void End_Call_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            mainScreen.Show();
        }
    }
}
