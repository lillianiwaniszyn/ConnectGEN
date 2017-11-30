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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Login_Main : Window
    {
        public Login_Main()
        {
            Global_Data.existing_Usernames[0] = "liwanisz";
            Global_Data.existing_Usernames[1] = "Lillian";
            Global_Data.existing_Usernames[2] = "cora";
            Global_Data.existing_Usernames[3] = "Cora";
            Global_Data.existing_Usernames[4] = "Cora1";
            Global_Data.passwords[0] = "1234";
            Global_Data.passwords[1] = "3245";
            Global_Data.passwords[2] = "0000";
            Global_Data.passwords[3] = "1111";
            Global_Data.passwords[4] = "3333";
            InitializeComponent();
        }
        void OnClickA(object sender, RoutedEventArgs e)
        {


            NewAccount na = new NewAccount();
            na.Show();
            this.Close();

        }
        void OnClickB(object sender, RoutedEventArgs e)
        {


            Home_Screen hs =  new Home_Screen();
            hs.Show();
            this.Close();

        }
        void OnClickC(object sender, RoutedEventArgs e)
        {

            Login l = new Login();
            l.Show();
            this.Close();

        }
    }
}
