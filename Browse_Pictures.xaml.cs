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
    public partial class Browse_Pictures : Window
    {
        public Browse_Pictures()
        {
            InitializeComponent();
           
        }
        


        void Set_Profile_Picture(object sender, RoutedEventArgs e)
        {
            NewAccount n = new NewAccount();
            Image myImage = new Image();
            myImage.Source = new BitmapImage(new Uri("images/simon.jpg", UriKind.RelativeOrAbsolute));
            this.Close();
            //return myImage.Source;
            
        }
    }
}
