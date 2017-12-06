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
       // string[] existing_Usernames = new string[] { "liwanisz", "Lillian", "cora", "Cora", "Cora1"};
        //this is very bad... sorry :(
        string[] numbers = new string[] { "0", "1", "2", "3", "4","5","6","7","8","9" };
        //set flags to change colour of button
        Boolean checkUsername;
        Boolean checkPIN1;
        Boolean checkPIN2;
        Boolean checkPIN3;
        Boolean checkPIN4;


        public NewAccount()
        {
            InitializeComponent();
            checkUsername = false;
            checkPIN1 = false;
            checkPIN2 = false;
            checkPIN3 = false;
            checkPIN4 = false;
            createAccountBtn.IsEnabled = false;
        }

        void OnClick2(object sender, RoutedEventArgs e)
        {
            Login_Main mw = new Login_Main();
            mw.Show();
            this.Close();

        }
        void ChangePic(object sender, RoutedEventArgs e)
        {
            Browse_Pictures bp = new Browse_Pictures();
            bp.DataContext = this;
            bp.ShowDialog();

            // this.Close();

        }
        void CreateAccount(object sender, RoutedEventArgs e)
        {
            Home_Screen hs = new Home_Screen();
            String s = languageMenu.Text;
            Global_Data.languageChosen = s;
            hs.Show();
            this.Close();

        }
        void Validate_Username(object sender, TextChangedEventArgs e)
        {
            Global_Data gd = new Global_Data();

            
            if (gd.existing_Usernames.Contains(Fname.Text))
                {
                    validUsername.Content = "*Username already taken";
                createAccountBtn.IsEnabled = false;
                checkUsername = false;
            }
            else
            {
                validUsername.Content = "";
                checkUsername = true;
                changebuttonColor();

            }


            
        }
        void Validate_PIN1(object sender, TextChangedEventArgs e)
        {
            if (!numbers.Contains(PIN1.Text))
            {
                validPIN.Content = "*PIN must be numerical";
                createAccountBtn.IsEnabled = false;
                checkPIN1 = false;
            }
            else
            {
                validPIN.Content = "";
                checkPIN1 = true;
                changebuttonColor();
            }
        }
        void Validate_PIN2(object sender, TextChangedEventArgs e)
        {
            if (!numbers.Contains(PIN2.Text))
            {
                validPIN.Content = "*PIN must be numerical";
                createAccountBtn.IsEnabled = false;
                checkPIN2 = false;
                changebuttonColor();

            }
            else
            {
                validPIN.Content = "";
                checkPIN2 = true;
                changebuttonColor();
            }
        }
        void Validate_PIN3(object sender, TextChangedEventArgs e)
        {
            if (!numbers.Contains(PIN3.Text))
            {
                validPIN.Content = "*PIN must be numerical";
                createAccountBtn.IsEnabled = false;
                checkPIN3 = false;

            }
            else
            {
                validPIN.Content = "";
                checkPIN3 = true;
                changebuttonColor();
            }
        }
        void Validate_PIN4(object sender, TextChangedEventArgs e)
        {
            if (!numbers.Contains(PIN4.Text))
            {
                validPIN.Content = "*PIN must be numerical";
                createAccountBtn.IsEnabled = false;
                checkPIN4 = false;

            }
            else
            {
                validPIN.Content = "";
                checkPIN4 = true;
                changebuttonColor();
            }
        }
        void changebuttonColor()
        {
            if(checkUsername && checkPIN1 && checkPIN2 && checkPIN3 && checkPIN4)
            {
                createAccountBtn.IsEnabled = true;
            }
        }


    }
}
