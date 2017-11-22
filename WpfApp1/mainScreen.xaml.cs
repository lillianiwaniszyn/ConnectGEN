using ConnectGenApp;
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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        PopUps popupIcons = new PopUps();
        Exisitng_Account existingAccount = new Exisitng_Account();

        public Window1()
        {
            InitializeComponent();
        }

        private void middleContact_Click(object sender, RoutedEventArgs e)
        {
            // make the pop-ups visible
            popupIcons.Show();
        }

        private void myProfileButton_Click(object sender, RoutedEventArgs e)
        {
            // move to edit my profile page
            this.Close();
        }

        private void myProfilePictureButton_Click(object sender, RoutedEventArgs e)
        {
            // move to edit my profile page
            this.Close();
        }

        private void addContactImageButton_Click(object sender, RoutedEventArgs e)
        {
            // move to search for a contact page 
            this.Close();
        }

        private void logoutButton_Click(object sender, RoutedEventArgs e)
        {
            // move to main page when app opened (with profile choices)
            this.Close();
            existingAccount.Show();
        }

        private void addContactButton_Click(object sender, RoutedEventArgs e)
        {
            // move to search for a contact page 
            this.Close();
        }

        private void rightContact_Click(object sender, RoutedEventArgs e)
        {
            // move contact to center, then make pop-ups visible
            popupIcons.Show();
        }

        private void leftContact_Click(object sender, RoutedEventArgs e)
        {
            // move contact to center, then make pop-ups visible 
            popupIcons.Show();
        }
    }
}
