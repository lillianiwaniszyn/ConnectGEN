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
        int count = 0;

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
            Console.WriteLine("!!!!");
            Console.WriteLine(Global_Data.currentUserStatic);
            int index = Array.IndexOf(dataClass.existing_Usernames, Global_Data.currentUserStatic);
            string fName = dataClass.firstnames[index];
            string lName = dataClass.lastnames[index];
            string fullName = fName + " " + lName;
            myProfileButton.Content = fullName;
        }

        private void MiddleContact_Click_1(object sender, RoutedEventArgs e)
        {
            if (count == 0)
            {
                // make the pop-ups visible
                infoIcon.Visibility = System.Windows.Visibility.Visible;
                infobutton.IsEnabled = true;
                messageIcon.Visibility = System.Windows.Visibility.Visible;
                messagebutton.IsEnabled = true;
                audioIcon.Visibility = System.Windows.Visibility.Visible;
                audiobutton.IsEnabled = true;
                videoIcon.Visibility = System.Windows.Visibility.Visible;
                videobutton.IsEnabled = true;
                infoLabel.Visibility = System.Windows.Visibility.Visible;
                messageLabel.Visibility = System.Windows.Visibility.Visible;
                audioLabel.Visibility = System.Windows.Visibility.Visible;
                videoLabel.Visibility = System.Windows.Visibility.Visible;
                infobutton.Visibility = System.Windows.Visibility.Visible;
                messagebutton.Visibility = System.Windows.Visibility.Visible;
                audiobutton.Visibility = System.Windows.Visibility.Visible;
                videobutton.Visibility = System.Windows.Visibility.Visible;
                count++;
            }
            else if (count == 1)
            {
                infoIcon.Visibility = System.Windows.Visibility.Hidden;
                infobutton.IsEnabled = false;
                messageIcon.Visibility = System.Windows.Visibility.Hidden;
                messagebutton.IsEnabled = false;
                audioIcon.Visibility = System.Windows.Visibility.Hidden;
                audiobutton.IsEnabled = false;
                videoIcon.Visibility = System.Windows.Visibility.Hidden;
                videobutton.IsEnabled = false;
                infoLabel.Visibility = System.Windows.Visibility.Hidden;
                messageLabel.Visibility = System.Windows.Visibility.Hidden;
                audioLabel.Visibility = System.Windows.Visibility.Hidden;
                videoLabel.Visibility = System.Windows.Visibility.Hidden;
                infobutton.Visibility = System.Windows.Visibility.Hidden;
                messagebutton.Visibility = System.Windows.Visibility.Hidden;
                audiobutton.Visibility = System.Windows.Visibility.Hidden;
                videobutton.Visibility = System.Windows.Visibility.Hidden;
                count--;
            }


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
            // move contact to center
            // make popups visible
            infoIcon.Visibility = System.Windows.Visibility.Visible;
            infobutton.IsEnabled = true;
            messageIcon.Visibility = System.Windows.Visibility.Visible;
            messagebutton.IsEnabled = true;
            audioIcon.Visibility = System.Windows.Visibility.Visible;
            audiobutton.IsEnabled = true;
            videoIcon.Visibility = System.Windows.Visibility.Visible;
            videobutton.IsEnabled = true;
            infoLabel.Visibility = System.Windows.Visibility.Visible;
            messageLabel.Visibility = System.Windows.Visibility.Visible;
            audioLabel.Visibility = System.Windows.Visibility.Visible;
            videoLabel.Visibility = System.Windows.Visibility.Visible;
            infobutton.Visibility = System.Windows.Visibility.Visible;
            messagebutton.Visibility = System.Windows.Visibility.Visible;
            audiobutton.Visibility = System.Windows.Visibility.Visible;
            videobutton.Visibility = System.Windows.Visibility.Visible;
            count++;
            this.Close();
        }

        private void LeftContact_Click(object sender, RoutedEventArgs e)
        {
            // move contact to center
            // make popups visible
            infoIcon.Visibility = System.Windows.Visibility.Visible;
            infobutton.IsEnabled = true;
            messageIcon.Visibility = System.Windows.Visibility.Visible;
            messagebutton.IsEnabled = true;
            audioIcon.Visibility = System.Windows.Visibility.Visible;
            audiobutton.IsEnabled = true;
            videoIcon.Visibility = System.Windows.Visibility.Visible;
            videobutton.IsEnabled = true;
            infoLabel.Visibility = System.Windows.Visibility.Visible;
            messageLabel.Visibility = System.Windows.Visibility.Visible;
            audioLabel.Visibility = System.Windows.Visibility.Visible;
            videoLabel.Visibility = System.Windows.Visibility.Visible;
            infobutton.Visibility = System.Windows.Visibility.Visible;
            messagebutton.Visibility = System.Windows.Visibility.Visible;
            audiobutton.Visibility = System.Windows.Visibility.Visible;
            videobutton.Visibility = System.Windows.Visibility.Visible;
            count++;
            this.Close();
        }

        private void rightArrow_Click(object sender, RoutedEventArgs e)
        {
            if(middleImage < 6)
            {

                middleImage++;
                LeftImage.Source = new BitmapImage(new Uri(dataClass.profilePicPath[middleImage - 1], UriKind.Relative));
                MiddleImage.Source = new BitmapImage(new Uri(dataClass.profilePicPath[middleImage], UriKind.Relative));
                RightImage.Source = new BitmapImage(new Uri(dataClass.profilePicPath[middleImage + 1], UriKind.Relative));
            }
            if (count == 1)
            {
                infoIcon.Visibility = System.Windows.Visibility.Hidden;
                infobutton.IsEnabled = false;
                messageIcon.Visibility = System.Windows.Visibility.Hidden;
                messagebutton.IsEnabled = false;
                audioIcon.Visibility = System.Windows.Visibility.Hidden;
                audiobutton.IsEnabled = false;
                videoIcon.Visibility = System.Windows.Visibility.Hidden;
                videobutton.IsEnabled = false;
                infoLabel.Visibility = System.Windows.Visibility.Hidden;
                messageLabel.Visibility = System.Windows.Visibility.Hidden;
                audioLabel.Visibility = System.Windows.Visibility.Hidden;
                videoLabel.Visibility = System.Windows.Visibility.Hidden;
                infobutton.Visibility = System.Windows.Visibility.Hidden;
                messagebutton.Visibility = System.Windows.Visibility.Hidden;
                audiobutton.Visibility = System.Windows.Visibility.Hidden;
                videobutton.Visibility = System.Windows.Visibility.Hidden;
                count--;
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
            if (count == 1)
            {
                infoIcon.Visibility = System.Windows.Visibility.Hidden;
                infobutton.IsEnabled = false;
                messageIcon.Visibility = System.Windows.Visibility.Hidden;
                messagebutton.IsEnabled = false;
                audioIcon.Visibility = System.Windows.Visibility.Hidden;
                audiobutton.IsEnabled = false;
                videoIcon.Visibility = System.Windows.Visibility.Hidden;
                videobutton.IsEnabled = false;
                infoLabel.Visibility = System.Windows.Visibility.Hidden;
                messageLabel.Visibility = System.Windows.Visibility.Hidden;
                audioLabel.Visibility = System.Windows.Visibility.Hidden;
                videoLabel.Visibility = System.Windows.Visibility.Hidden;
                infobutton.Visibility = System.Windows.Visibility.Hidden;
                messagebutton.Visibility = System.Windows.Visibility.Hidden;
                audiobutton.Visibility = System.Windows.Visibility.Hidden;
                videobutton.Visibility = System.Windows.Visibility.Hidden;
                count--;
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Login_Main lm = new Login_Main();
            lm.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // move to search for a contact page
            //this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            EditProfile editprofile = new EditProfile();
            editprofile.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageScreen message = new MessageScreen();
            message.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            AudioCallWaiting audio = new AudioCallWaiting();
            audio.Show();
            this.Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            VideoCallWaiting video = new VideoCallWaiting();
            video.Show();
            this.Close();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            EditContact editcontact = new EditContact();
            editcontact.Show();
            this.Close();
        }
    }
}
