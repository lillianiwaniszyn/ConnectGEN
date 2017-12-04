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
    /// Interaction logic for ConfirmPicture.xaml
    /// </summary>
    public partial class ConfirmPicture : Window
    {
        public ConfirmPicture()
        {
            InitializeComponent();
        }

        private void SendNowButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddToMessageButton_Click(object sender, RoutedEventArgs e)
        {
            AddImages previousWindow = (AddImages)this.DataContext;
            MessageScreen firstWindow = (MessageScreen)previousWindow.DataContext;
            // Add to MessageScreen textbox somehow.
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            AddImages previousWindow = (AddImages)this.DataContext;
            previousWindow.EnableAllButtons();
            this.Close();
        }
    }
}
