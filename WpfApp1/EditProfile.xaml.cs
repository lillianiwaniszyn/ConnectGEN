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
            Global_Data gd = new Global_Data();
            int index = Array.IndexOf(gd.existing_Usernames, Global_Data.currentUserStatic);
            string lastName = gd.lastnames[index];
            string firstName = gd.firstnames[index];
            string fullName = firstName + " " + lastName;
            userName.Content = fullName;
        }

        void ChangePic(object sender, RoutedEventArgs e)
        {
            //Browse_Pictures bp = new Browse_Pictures();
            //bp.DataContext = this;
            //bp.ShowDialog();
            MessageBox.Show("This function has not been implemented yet!");
            // this.Close();
        }

        private void ChangeName(object sender, RoutedEventArgs e)
        {
            //popup.IsOpen = true;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Home_Screen home = new Home_Screen();
            home.Show();
            this.Close();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This function has not been implemented yet!");
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This function has not been implemented yet!");
        }
    }

}
