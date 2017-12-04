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
        { //add more later... will be tedious...
            Global_Data.existing_Usernames[0] = "liwanisz";
            Global_Data.existing_Usernames[1] = "Karla1";
            Global_Data.existing_Usernames[2] = "cora";
            Global_Data.existing_Usernames[3] = "Simon22";
            Global_Data.existing_Usernames[4] = "MalikBrown";
            Global_Data.passwords[0] = "1234";
            Global_Data.passwords[1] = "3245";
            Global_Data.passwords[2] = "0000";
            Global_Data.passwords[3] = "1111";
            Global_Data.passwords[4] = "3333";
            Global_Data.firstnames[0] = "Lillian";
            Global_Data.firstnames[1] = "Karla";
            Global_Data.firstnames[2] = "Cora";
            Global_Data.firstnames[3] = "Simon";
            Global_Data.firstnames[4] = "Malik";
            Global_Data.lastnames[0] = "Iwaniszyn";
            Global_Data.lastnames[1] = "Juego";
            Global_Data.lastnames[2] = "Brown";
            Global_Data.lastnames[3] = "Cowell";
            Global_Data.lastnames[4] = "Brown";
            Global_Data.contacts[0,0] = "Karla1"; //this shows us that Karla is in Lillian's contacts
            Global_Data.contacts[0, 1] = "Simon22"; // simon is also Lillian's friend
            Global_Data.contacts[1, 0] = "liwanisz"; // lillian is Karla's friend
            Global_Data.contacts[3, 0] = "liwnaisz"; //lillian is simons friend
            //... and so on and so forth....

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
