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
            //to do.. implement this to go to main screen
            this.Close();

        }
    }
}
