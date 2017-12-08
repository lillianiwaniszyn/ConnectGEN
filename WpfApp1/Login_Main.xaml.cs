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

           
            InitializeComponent();
            Console.WriteLine(Global_Data.LoginScreenButtonVisibility);
            if (Global_Data.LoginScreenButtonVisibility)
            {
                Karla.Visibility = Visibility.Visible;
                KarlaSP.Visibility = Visibility.Visible;
            }
            if (!Global_Data.LoginScreenButtonVisibility)
            {
                Karla.Visibility = Visibility.Collapsed;
                KarlaSP.Visibility = Visibility.Collapsed;

            }
        }
        void OnClickA(object sender, RoutedEventArgs e)
        {


            NewAccount na = new NewAccount();
            na.Show();
            this.Close();

        }
        void OnClickKarla(object sender, RoutedEventArgs e)
        {


            Global_Data.currentUserStatic = "Karla1";
            Home_Screen hs = new Home_Screen();
            //set current user to Cora

            hs.Show();
            this.Close();

        }
        void OnClickB(object sender, RoutedEventArgs e)
        {

            Global_Data.currentUserStatic = "cora";
            Home_Screen hs = new Home_Screen();
            //set current user to Cora
            
            hs.Show();
            this.Close();

        }
        void OnClickC(object sender, RoutedEventArgs e)
        {
            Global_Data.LoginScreenButtonVisibility = true;
            
            Login l = new Login();
            l.Show();
            this.Close();

        }
    }
}
