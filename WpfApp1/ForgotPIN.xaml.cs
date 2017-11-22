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
        public ForgotPIN()
        {
            InitializeComponent();
        }
        void OnClickRestore(object sender, RoutedEventArgs e)
        {
            //to do... figure out what we want to do when we restore account
            this.Close();
        }
        void OnClickFP(object sender, RoutedEventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Close();
        }



    }
}
