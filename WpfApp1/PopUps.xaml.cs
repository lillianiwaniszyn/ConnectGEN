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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for PopUps.xaml
    /// </summary>
    public partial class PopUps : UserControl
    {
        public PopUps()
        {
            InitializeComponent();
        }

        private void messageIcon_Click(object sender, RoutedEventArgs e)
        {
            MessageScreen message = new MessageScreen();
            message.Show();
        }

        private void audioIcon_Click(object sender, RoutedEventArgs e)
        {
            AudioCallWaiting audio = new AudioCallWaiting();
            audio.Show();
        }

        private void videoIcon_Click(object sender, RoutedEventArgs e)
        {
            VideoCallWaiting video = new VideoCallWaiting();
            video.Show();
        }

        private void infoIcon_Click(object sender, RoutedEventArgs e)
        {
            // edit profile 
        }
    }
}
