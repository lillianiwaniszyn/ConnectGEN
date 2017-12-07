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
    /// Interaction logic for MessageNotification.xaml
    /// </summary>
    public partial class MessageNotification : UserControl
    {
        public MessageNotification()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);

            // If there aren't anymore notifications. Need to show message history of current contact.
        }

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Clear();

            // Need to add message history of the desired contact.
        }
    }
}
