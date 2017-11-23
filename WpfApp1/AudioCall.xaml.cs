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
    /// Interaction logic for AudioCall.xaml
    /// </summary>
    public partial class AudioCall : Window
    {
        Window1 mainScreen = new Window1();
        public AudioCall()
        {
            InitializeComponent();
        }

        private void End_Call_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            mainScreen.Show();
        }
    }
}
