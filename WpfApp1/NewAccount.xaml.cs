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
    public partial class NewAccount : Window
    {
        string[] existing_Usernames = new string[] { "liwanisz", "Lillian", "cora", "Cora", "Cora1"};

        public NewAccount()
        {
            InitializeComponent();
        }
        void OnClick2(object sender, RoutedEventArgs e)
        {
            Login_Main mw = new Login_Main();
            mw.Show();
            this.Close();

        }
        void OnClick3(object sender, RoutedEventArgs e)
        {
            Home_Screen hs = new Home_Screen();
            hs.Show();
            this.Close();

        }
        void Validate_Username(object sender, TextChangedEventArgs e)
        {

            
            if (existing_Usernames.Contains(Fname.Text))
                {
                    validUsername.Content = "*Username already taken";
                }
            else
            {
                validUsername.Content = "";
            }


            
        }


    }
}
