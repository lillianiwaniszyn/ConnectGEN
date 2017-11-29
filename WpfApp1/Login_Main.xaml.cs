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
