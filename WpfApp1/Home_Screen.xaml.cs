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
        private int rightIndex = 3;
        private int middleIndex = 2;
        private int leftIndex = 1;
        private int numContacts = 6;

        public Home_Screen()
        {
            InitializeComponent();
            Console.WriteLine(Global_Data.currentUserStatic);
            // myProfilePictureButton.Source= 
            int index = Array.IndexOf(dataClass.existing_Usernames, Global_Data.currentUserStatic);
            string ppPath = dataClass.profilePicPath[index];
            Console.WriteLine(ppPath);
            Image myImage = new Image();
            myImage.Source = new BitmapImage(new Uri(ppPath, UriKind.RelativeOrAbsolute));
            currentProfPic.Source = myImage.Source;
            string fName = dataClass.firstnames[index];
            string lName = dataClass.lastnames[index];
            string fullName = fName + " " + lName;
            string rightContact = dataClass.homescreenNames[rightIndex];
            string leftContact = dataClass.homescreenNames[leftIndex];
            string middleContact = dataClass.homescreenNames[middleIndex];
            rightContactLabel.Content = rightContact;
            leftContactLabel.Content = leftContact;
            middleContactLabel.Content = middleContact;
            myProfileButton.Content = fullName;

            // Testing unread notifications;
            UnreadNotification unread1 = new UnreadNotification();
            unread1.SetMsg("Jasmine");
            UnreadNotification unread2 = new UnreadNotification();
            unread2.SetAudio("Malik");
            UnreadNotification unread3 = new UnreadNotification();
            unread3.SetVideo("Simone");

            unreadStackPanel.Children.Add(unread1);
            unreadStackPanel.Children.Add(unread2);
            unreadStackPanel.Children.Add(unread3);
            //
            if (Global_Data.addSimone == true)
            {
                numContacts = 7;
                dataClass.homescreenContacts[8] = dataClass.homescreenContacts[7];
                dataClass.homescreenNames[8] = dataClass.homescreenNames[7];
                dataClass.homescreenContacts[7] = "images/cimoneSimmons.jpeg";
                dataClass.homescreenNames[7] = "Simone Simmons";
            }
            else
            {
                dataClass.homescreenContacts[7] = "images/blankpp.png";
                dataClass.homescreenNames[7] = " ";
                numContacts = 6;
            }
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

            Change_Profile_Picture cpp = new Change_Profile_Picture();
            cpp.DataContext = this;
            cpp.ShowDialog();
            this.Close();
        }

        private void AddContactImageButton_Click(object sender, RoutedEventArgs e)
        {
            // move to search for a contact page 
            AddContacts addC = new AddContacts();
            addC.Show();
            this.Close();
        }

        void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            // move to main page when app opened (with profile choices)
            //Global_Data.LoginScreenButtonVisibility = true;
            Login_Main lm = new Login_Main();
            lm.Show();
            this.Close();

        }

        private void AddContactButton_Click(object sender, RoutedEventArgs e)
        {
            // move to search for a contact page 
            AddContacts addC = new AddContacts();
            addC.Show();
            this.Close();
        }

        private void RightContact_Click(object sender, RoutedEventArgs e)
        {
            if (middleImage < numContacts)
            {
                // move contact to center
                middleImage++;
                rightContactLabel.Content = dataClass.homescreenNames[middleImage + 1];
                middleContactLabel.Content = dataClass.homescreenNames[middleImage];
                leftContactLabel.Content = dataClass.homescreenNames[middleImage - 1];
                LeftImage.Source = new BitmapImage(new Uri(dataClass.homescreenContacts[middleImage - 1], UriKind.Relative));
                MiddleImage.Source = new BitmapImage(new Uri(dataClass.homescreenContacts[middleImage], UriKind.Relative));
                RightImage.Source = new BitmapImage(new Uri(dataClass.homescreenContacts[middleImage + 1], UriKind.Relative));
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
                count = 1;
            }
            //this.Close();
        }

        private void LeftContact_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Move the contact to the middle of the screen if you would like to get in touch with them!");
            // move contact to center
            if (middleImage > 1)
            {
                middleImage--;
                rightContactLabel.Content = dataClass.homescreenNames[middleImage + 1];
                middleContactLabel.Content = dataClass.homescreenNames[middleImage];
                leftContactLabel.Content = dataClass.homescreenNames[middleImage - 1];
                LeftImage.Source = new BitmapImage(new Uri(dataClass.homescreenContacts[middleImage - 1], UriKind.Relative));
                MiddleImage.Source = new BitmapImage(new Uri(dataClass.homescreenContacts[middleImage], UriKind.Relative));
                RightImage.Source = new BitmapImage(new Uri(dataClass.homescreenContacts[middleImage + 1], UriKind.Relative));
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
                count = 1;
            }
            //this.Close();
        }

        private void rightArrow_Click(object sender, RoutedEventArgs e)
        {
          
            
            if (middleImage < numContacts)
            {
                middleImage++;
                rightContactLabel.Content = dataClass.homescreenNames[middleImage + 1];
                middleContactLabel.Content = dataClass.homescreenNames[middleImage];
                leftContactLabel.Content = dataClass.homescreenNames[middleImage - 1];
                LeftImage.Source = new BitmapImage(new Uri(dataClass.homescreenContacts[middleImage - 1], UriKind.Relative));
                MiddleImage.Source = new BitmapImage(new Uri(dataClass.homescreenContacts[middleImage], UriKind.Relative));
                RightImage.Source = new BitmapImage(new Uri(dataClass.homescreenContacts[middleImage + 1], UriKind.Relative));
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
                count = 0;
            }
        }

        private void leftArrow_Click(object sender, RoutedEventArgs e)
        {
            
            if (middleImage > 1)
            {
                middleImage--;
                rightContactLabel.Content = dataClass.homescreenNames[middleImage + 1];
                middleContactLabel.Content = dataClass.homescreenNames[middleImage];
                leftContactLabel.Content = dataClass.homescreenNames[middleImage - 1];
                LeftImage.Source = new BitmapImage(new Uri(dataClass.homescreenContacts[middleImage - 1], UriKind.Relative));
                MiddleImage.Source = new BitmapImage(new Uri(dataClass.homescreenContacts[middleImage], UriKind.Relative));
                RightImage.Source = new BitmapImage(new Uri(dataClass.homescreenContacts[middleImage + 1], UriKind.Relative));

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
                count = 0;
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Login_Main lm = new Login_Main();
            lm.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddContacts addC = new AddContacts();
            addC.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            EditProfile editprofile = new EditProfile();
            editprofile.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            // Actual Message Button Called

            // Need to get image clicked on.
            Image selectedImage = (Image)middleContact.Content;
            // Get source.
            string temporaryContent = selectedImage.Source.ToString();
            // Split using '/'.
            string[] splitContent = temporaryContent.Split('/');
            // Find out place of "Images".
            int imageArea = 0;
            while ((splitContent[imageArea] != "Images") && (splitContent[imageArea] != "images"))
                imageArea++;
            // Increase count once more.
            imageArea++;
            // Image Name
            string ImageName = splitContent[imageArea];
            // Create message screen.
            MessageScreen message = null;
            // Since username should be either Jasmine or Malik to continue...
            if (ImageName == "jazmineBrown.png")
            {
                message = new MessageScreen("jazmineBrown");
            }
            else if (ImageName == "malikBrown.jpg")
            {
                message = new MessageScreen("MalikBrown");
            }
            
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
        private void SliderMessage(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This function has not been implemented!");
        }
    }
}
