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
    /// Interaction logic for AVCallUserControl.xaml
    /// </summary>
    public partial class AVCallUserControl : UserControl
    {
        public AVCallUserControl()
        {
            InitializeComponent();

            // Automatically make the icons invisible.
            audioAcceptedIcon.Visibility = Visibility.Hidden;
            audioDeclinedIcon.Visibility = Visibility.Hidden;
            videoAcceptedIcon.Visibility = Visibility.Hidden;
            videoDeclinedIcon.Visibility = Visibility.Hidden;
        }
    }
}
