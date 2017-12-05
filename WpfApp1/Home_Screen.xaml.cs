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
    public partial class Home_Screen : Window
    {
        Global_Data dataClass = new Global_Data();
        int middleImage = 1;
        /*
        MessageScreen message = new MessageScreen();
        EditProfile editprofile = new EditProfile();
        EditContact editcontact = new EditContact();
        AudioCallWaiting audio = new AudioCallWaiting();
        VideoCallWaiting video = new VideoCallWaiting();
        */
        public Home_Screen()
        {
            InitializeComponent();
        }

        private void MiddleContact_Click_1(object sender, RoutedEventArgs e)
        {
            // make the pop-ups visible
            infoIcon.Visibility = System.Windows.Visibility.Visible;
            messageIcon.Visibility = System.Windows.Visibility.Visible;
            audioIcon.Visibility = System.Windows.Visibility.Visible;
            videoIcon.Visibility = System.Windows.Visibility.Visible;
            infoLabel.Visibility = System.Windows.Visibility.Visible;
            messageLabel.Visibility = System.Windows.Visibility.Visible;
            audioLabel.Visibility = System.Windows.Visibility.Visible;
            videoLabel.Visibility = System.Windows.Visibility.Visible;

        }

        void MyProfileButton_Click(object sender, RoutedEventArgs e)
        {
            EditProfile editprofile = new EditProfile();
            editprofile.Show();
            this.Close();
        }

        private void MyProfilePictureButton_Click(object sender, RoutedEventArgs e)
        {

            //Change_Profile_Picture cpp = new Change_Profile_Picture();
            //cpp.DataContext = this;
            //cpp.ShowDialog();
           // this.Close();
        }

        private void AddContactImageButton_Click(object sender, RoutedEventArgs e)
        {
            // move to search for a contact page 
            this.Close();
        }

        void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            // move to main page when app opened (with profile choices)
            Login_Main lm = new Login_Main();
            lm.Show();
            this.Close();

        }

        private void AddContactButton_Click(object sender, RoutedEventArgs e)
        {
            // move to search for a contact page 
            this.Close();
        }

        private void RightContact_Click(object sender, RoutedEventArgs e)
        {
            // move contact to center, then make pop-ups visible
            this.Close();
        }

        private void LeftContact_Click(object sender, RoutedEventArgs e)
        {
            // move contact to center, then make pop-ups visible 
            this.Close();
        }

        private void rightArrow_Click(object sender, RoutedEventArgs e)
        {
            if(middleImage < 3)
            {

                middleImage++;
                LeftImage.Source = new BitmapImage(new Uri(dataClass.profilePicPath[middleImage - 1], UriKind.Relative));
                MiddleImage.Source = new BitmapImage(new Uri(dataClass.profilePicPath[middleImage], UriKind.Relative));
                RightImage.Source = new BitmapImage(new Uri(dataClass.profilePicPath[middleImage + 1], UriKind.Relative));
            }
            
        }

        private void leftArrow_Click(object sender, RoutedEventArgs e)
        {
            if(middleImage > 1)
            {
                middleImage--;
                LeftImage.Source = new BitmapImage(new Uri(dataClass.profilePicPath[middleImage - 1], UriKind.Relative));
                MiddleImage.Source = new BitmapImage(new Uri(dataClass.profilePicPath[middleImage], UriKind.Relative));
                RightImage.Source = new BitmapImage(new Uri(dataClass.profilePicPath[middleImage + 1], UriKind.Relative));

            }
            
        }
        private void infoIcon_Click(object sender, RoutedEventArgs e)
        {
            // move to edit contact page 
            EditContact editcontact = new EditContact();
            editcontact.Show();
            this.Close();
        }

        private void messageIcon_Click(object sender, RoutedEventArgs e)
        {
            MessageScreen message = new MessageScreen();
            message.Show();
            this.Close();
        }

        private void audioIcon_Click(object sender, RoutedEventArgs e)
        {
            AudioCallWaiting audio = new AudioCallWaiting();
            audio.Show();
            this.Close();
        }

        private void videoIcon_Click(object sender, RoutedEventArgs e)
        {
            VideoCallWaiting video = new VideoCallWaiting();
            video.Show();
            this.Close();
        }

        private void messageLabel_Click(object sender, RoutedEventArgs e)
        {
            MessageScreen message = new MessageScreen();
            message.Show();
            this.Close();
        }

        private void audioLabel_Click(object sender, RoutedEventArgs e)
        {
            AudioCallWaiting audio = new AudioCallWaiting();
            audio.Show();
            this.Close();
        }

        private void videoLabel_Click(object sender, RoutedEventArgs e)
        {
            VideoCallWaiting video = new VideoCallWaiting();
            video.Show();
            this.Close();
        }

        private void infoLabel_Click(object sender, RoutedEventArgs e)
        {
            // move to edit contact page 
            EditContact editcontact = new EditContact();
            editcontact.Show();
            this.Close();
        }

        private void logOutLabel_Click(object sender, RoutedEventArgs e)
        {
            Login_Main lm = new Login_Main();
            lm.Show();
            this.Close();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            middleImage++;
            LeftImage.Source = new BitmapImage(new Uri(dataClass.profilePicPath[middleImage - 1]));
            MiddleImage.Source = new BitmapImage(new Uri(dataClass.profilePicPath[middleImage]));
            RightImage.Source = new BitmapImage(new Uri(dataClass.profilePicPath[middleImage + 1]));

        }
    }
}
