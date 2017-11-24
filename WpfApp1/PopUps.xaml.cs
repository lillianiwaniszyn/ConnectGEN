using CPCS481Project;
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
    /// Interaction logic for PopUps.xaml
    /// </summary>
    public partial class PopUps : Window
    {
        MessageScreen message = new MessageScreen();
        MainWindow video = new MainWindow(); // video screen??? 
        AudioCallWaiting audio = new AudioCallWaiting();

        public PopUps()
        {
            InitializeComponent();
        }

        private void infoIcon_Click(object sender, RoutedEventArgs e)
        {
            // move to the contact information/edit contact page 
            this.Close(); // this will only close the popups, not the main screen.. so is it also necessary to close the main screen before moving to another screen?
        }
        private void infoIconLabel_Click(object sender, RoutedEventArgs e)
        {
            // move to the contact information/edit contact page 
            this.Close();
        }

        private void messageIcon_Click(object sender, RoutedEventArgs e)
        {
            // move to the message screen 
            this.Close(); 
            message.Show();
        }
        private void messageIconLabel_Click(object sender, RoutedEventArgs e)
        {
            // move to the message screen 
            this.Close();
            message.Show();
        }

        private void audioIcon_Click(object sender, RoutedEventArgs e)
        {
            // move to the audio call screen 
            this.Close();
            audio.Show();
        }
        private void audioIconLabel_Click(object sender, RoutedEventArgs e)
        {
            // move to the audio call screen
            this.Close();
            audio.Show();
        }

        private void videoIcon_Click(object sender, RoutedEventArgs e)
        {
            // move to the video call screen 
            this.Close();
            video.Show();
        }

        private void videoIconLabel_Click(object sender, RoutedEventArgs e)
        {
            // move to the video call screen 
            this.Close();
            video.Show();
        }
    }
}
