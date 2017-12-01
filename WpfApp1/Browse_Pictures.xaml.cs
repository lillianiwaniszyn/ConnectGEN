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
            string s = (sender as Button).Name; //get name of button sending us to this function
            if(s == "jazmineBrown"  )
            {
                s = s + ".png";
            }
            else
            {
                s = s + ".jpg";
            }
            string selectedPicture = "images/" + s;
            Console.WriteLine(s);
            NewAccount n = (NewAccount)this.DataContext;
            Image myImage = new Image();
            myImage.Source = new BitmapImage(new Uri(selectedPicture, UriKind.RelativeOrAbsolute));

            this.Close();
            n.profPic.Source = myImage.Source;
            n.Show();
            
        }
    }
}
