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
    /// Interaction logic for EditContact.xaml
    /// </summary>
    public partial class EditProfile : Window
    {
        Global_Data dataClass = new Global_Data();
        public EditProfile()
        {
            InitializeComponent();
        }

        void ChangePic(object sender, RoutedEventArgs e)
        {
            Browse_Pictures bp = new Browse_Pictures();
            bp.DataContext = this;
            bp.ShowDialog();

            // this.Close();
        }

        private void ChangeName(object sender, RoutedEventArgs e)
        {
            popup.IsOpen = true;
        }
        private void text_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            popup.IsOpen = true;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            //Do the popup 
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            //Do the popup
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            //Do the popup
        }
    }

}
