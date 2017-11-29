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
    public partial class Home_Screen : Window
    {
        public Home_Screen()
        {
            InitializeComponent();
        }

        private void MiddleContact_Click_1(object sender, RoutedEventArgs e)
        {
            // make the pop-ups visible
            this.Close();
        }

        private void MyProfileButton_Click(object sender, RoutedEventArgs e)
        {
            // move to edit my profile page
            this.Close();
        }

        private void MyProfilePictureButton_Click(object sender, RoutedEventArgs e)
        {
            // move to edit my profile page
            this.Close();
        }

        private void AddContactImageButton_Click(object sender, RoutedEventArgs e)
        {
            // move to search for a contact page 
            this.Close();
        }

        void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            // move to main page when app opened (with profile choices)
            this.Close();

        }

        private void AddContactButton_Click(object sender, RoutedEventArgs e)
        {
            // move to search for a contact page 
            this.Close();
        }

        private void RightContact_Click(object sender, RoutedEventArgs e)
        {
            // move contact to center, then make pop-ups visible
            this.Close();
        }

        private void LeftContact_Click(object sender, RoutedEventArgs e)
        {
            // move contact to center, then make pop-ups visible 
            this.Close();
        }
    }
}
