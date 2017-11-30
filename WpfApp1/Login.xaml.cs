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
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Login : Window
    {
        string[] existing_Usernames = new string[] { "liwanisz", "Lillian", "cora", "Cora", "Cora1" };
        string[] passwords = new string[] { "1234", "3245", "0000", "1111", "3333" };
        string[] enteredPIN = new string[4];
        public Login()
        {

            InitializeComponent();
        }
        void OnClickFP(object sender, RoutedEventArgs e)
        {


            ForgotPIN fp = new ForgotPIN();
            fp.Show();
            this.Close();

        }
        void OnClickBack(object sender, RoutedEventArgs e)
        {
            Login_Main log = new Login_Main();
            log.Show();
            this.Close();

        }
        void OnClickLogin(object sender, RoutedEventArgs e)
        {
            //to do.. implement this to go to main screen if username and password are correct
            Home_Screen hs = new Home_Screen();
            string Pin1 = PIN1.Text;
            enteredPIN[0] = Pin1;
            string Pin2 = PIN2.Text;
            enteredPIN[1] = Pin2;
            string Pin3 = PIN3.Text;
            enteredPIN[2] = Pin3;
            string Pin4 = PIN4.Text;
            enteredPIN[3] = Pin4;
            string stringPIN = string.Join("", enteredPIN);
            int index = Array.IndexOf(existing_Usernames, Username.Text);
            if (stringPIN == passwords[index])
            {
                //authenticate the user here
                hs.Show();
                this.Close();
            }
            else
            {
                invalidCreds.Content = "*Invalid password and/or\n username. Please try again.";
            }

            

        }
    }
}
