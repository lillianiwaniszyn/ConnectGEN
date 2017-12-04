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
        
        public static string[] enteredPIN = new string[4];
        
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
        void Pin1(object sender, RoutedEventArgs e)
        {
            PIN2.Focus();

        }
        void Pin2(object sender, RoutedEventArgs e)
        {
            PIN3.Focus();

        }
        void Pin3(object sender, RoutedEventArgs e)
        {
            PIN4.Focus();

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
            int index = Array.IndexOf(Global_Data.existing_Usernames, Username.Text);
            Console.WriteLine(stringPIN);
            Console.WriteLine(Global_Data.passwords[index]);
            if (stringPIN == Global_Data.passwords[index])
            
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
