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
    public partial class Change_Profile_Picture : Window
    {
        public Change_Profile_Picture()
        {
            InitializeComponent();
        }
        void HighLight(object sender, RoutedEventArgs e)
        //only highlight one picture at a time
        {
            SelectImage.IsEnabled = true;
            simon.Background = Brushes.Transparent;
            simone.Background = Brushes.Transparent;
            malikBrown.Background = Brushes.Transparent;
            joaquinSimmons.Background = Brushes.Transparent;
            jazmineBrown.Background = Brushes.Transparent;
            kid1.Background = Brushes.Transparent;
            coraBrown.Background = Brushes.Transparent;
            selfie.Background = Brushes.Transparent;

            (sender as Button).Background = Brushes.SteelBlue;

        }
        void Set_Image(object sender, RoutedEventArgs e)
        //bad code... i know :(
        {
            string selectedPic = null;
            if (simon.Background == Brushes.SteelBlue)
            {
                selectedPic = "images/simon.jpg";
            }
            if (simone.Background == Brushes.SteelBlue)
            {
                selectedPic = "images/simone.jpg";
            }
            if (malikBrown.Background == Brushes.SteelBlue)
            {
                selectedPic = "images/malikBrown.jpg";
            }
            if (joaquinSimmons.Background == Brushes.SteelBlue)
            {
                selectedPic = "images/joaquinSimmons.jpg";
            }
            if (jazmineBrown.Background == Brushes.SteelBlue)
            {
                selectedPic = "images/jazmineBrown.png";
            }
            if (kid1.Background == Brushes.SteelBlue)
            {
                selectedPic = "images/kid1.png";
            }
            if (coraBrown.Background == Brushes.SteelBlue)
            {
                selectedPic = "images/coraBrown.jpg";
            }
            if (selfie.Background == Brushes.SteelBlue)
            {
                selectedPic = "images/selfie.jpg";
            }
            Home_Screen hs = (Home_Screen)this.DataContext;
            Image myImage = new Image();
            Global_Data gd = new Global_Data();
            gd.currentProfilePic = selectedPic;
            myImage.Source = new BitmapImage(new Uri(selectedPic, UriKind.RelativeOrAbsolute));

            this.Close();
            hs.currentProfPic.Source = myImage.Source;
            hs.Show();
        }




        void Set_Profile_Picture(object sender, RoutedEventArgs e)
        {
            string s = (sender as Button).Name; //get name of button sending us to this function
            if (s == "jazmineBrown" || s == "kid1")
            {
                s = s + ".png";
            }
            else
            {
                s = s + ".jpg";
            }
            string selectedPicture = "images/" + s;
            Home_Screen hs = (Home_Screen)this.DataContext;
            Image myImage = new Image();
            Global_Data gd = new Global_Data();
            gd.currentProfilePic = selectedPicture;
            myImage.Source = new BitmapImage(new Uri(selectedPicture, UriKind.RelativeOrAbsolute));

            this.Close();
            hs.currentProfPic.Source = myImage.Source;
            hs.Show();

        }
    }

}
