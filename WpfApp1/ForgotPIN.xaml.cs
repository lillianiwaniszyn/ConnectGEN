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
    /// Interaction logic for Window6.xaml
    /// </summary>
    public partial class ForgotPIN : Window
        
    {
        
        string[] numbers = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        Boolean verified;
        public ForgotPIN()
        {
            
            InitializeComponent();
            verified = false;
        }
        void OnClickRestore(object sender, RoutedEventArgs e)
        {
            Global_Data gd = new Global_Data();
            string username = Uname.Text;
            string lastname = Lname.Text;
            string contactFname = CFname.Text;
            string contactLname = CLname.Text;
            string pin1 = PIN1.Text;
            string pin2 = PIN2.Text;
            string pin3 = PIN3.Text;
            string pin4 = PIN4.Text;
            string PIN = pin1 + pin2 + pin3 + pin4;

            if (gd.existing_Usernames.Contains(Uname.Text) && gd.lastnames.Contains(CLname.Text))
            {
                int index = Array.IndexOf(gd.existing_Usernames, Uname.Text);
                int index2 = Array.IndexOf(gd.lastnames, CLname.Text); //get last name index
                string friendUname = gd.existing_Usernames[index2]; //get index of contact
                if (lastname == gd.lastnames[index])
                {
                    Console.WriteLine("YAY");
                }
                int n = 0;
                int length = gd.contacts.GetLength(1);
                while (n < length)
                {
                    if (gd.contacts[index, n] == friendUname)
                    {
                        verified = true;
                        gd.passwords[index] = PIN; //change PIN here
                    }
                    n++;
                }
            }

                

            if (verified == true) //if contact is verified
            {
                Home_Screen x = new Home_Screen();
                x.Show();
                this.Close();
            }
            else
            {
                Verify.Content = "";
                Verify.Content = "*Cannot Verify\n Account.";
            }
               
        }
        void OnClickFP(object sender, RoutedEventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Close();
        }
        void vPin1(object sender, RoutedEventArgs e)
        {
            PIN2.Focus();
            if (!numbers.Contains(PIN1.Text))
            {
                validPIN.Content = "*PIN must be numerical";
                buttonRA.IsEnabled = false;
            }
            else
            {
                validPIN.Content = "";
                buttonRA.IsEnabled = true;
            }

        }
        void vPin2(object sender, RoutedEventArgs e)
        {
            PIN3.Focus();
            if (!numbers.Contains(PIN2.Text))
            {
                validPIN.Content = "*PIN must be numerical";
                buttonRA.IsEnabled = false;
            }
            else
            {
                validPIN.Content = "";
                buttonRA.IsEnabled = true;
            }

        }
        void vPin3(object sender, RoutedEventArgs e)
        {
            PIN4.Focus();
            if (!numbers.Contains(PIN3.Text))
            {
                validPIN.Content = "*PIN must be numerical";
                buttonRA.IsEnabled = false;
            }
            else
            {
                validPIN.Content = "";
                buttonRA.IsEnabled = true;
            }

        }
        void vPin4(object sender, RoutedEventArgs e)
        {
            if (!numbers.Contains(PIN4.Text))
            {
                validPIN.Content = "*PIN must be numerical";
                buttonRA.IsEnabled = false;
            }
            else
            {
                validPIN.Content = "";
                buttonRA.IsEnabled = true;
            }
        }



    }
}
