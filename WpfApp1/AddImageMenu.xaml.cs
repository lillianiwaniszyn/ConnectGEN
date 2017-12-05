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
    /// Interaction logic for AddImageMenu.xaml
    /// </summary>
    public partial class AddImageMenu : Window
    {
        Button selectedImageButton = null;

        public AddImageMenu()
        {
            InitializeComponent();

            // Make sure that no actions can be taken. 
            DisableActionButtons();

            // Will not use the button below for now.
            addToMessageButton.Visibility = Visibility.Hidden;

        }

        private void GetActions(object sender, RoutedEventArgs e)
        {
            // Can't pick another image.
            DisableAllButtons();

            // Change Title of Window as one method of feedback.
            Title = (sender as Button).Name + " was selected.";

            // Re-enable the button, such that the button can appear highlighted. 
            // Pressing again on the button won't have any effect, making it seem disabled.
            (sender as Button).IsEnabled = true;
            (sender as Button).Background = Brushes.SteelBlue;

            // Put into attribute.
            selectedImageButton = (sender as Button);

            // Enable action buttons.
            EnableActionButtons();
        }

        public void DisableActionButtons()
        {
            sendNowButton.IsEnabled = false;
            addToMessageButton.IsEnabled = false;
            cancelButton.IsEnabled = false;
        }

        public void EnableActionButtons()
        {
            sendNowButton.IsEnabled = true;
            addToMessageButton.IsEnabled = true;
            cancelButton.IsEnabled = true;
        }

        public void DisableAllButtons()
        {
            KarlaJuego.IsEnabled = false;
            selfie.IsEnabled = false;
            simone.IsEnabled = false;
            malikBrown.IsEnabled = false;
            simon.IsEnabled = false;
            kid1.IsEnabled = false;
            kid2.IsEnabled = false;
            kid3.IsEnabled = false;
            coraBrown.IsEnabled = false;
            jazmineBrown.IsEnabled = false;
            joaquinSimmons.IsEnabled = false;
            cimoneSimmons.IsEnabled = false;
        }

        public void EnableAllButtons()
        {
            KarlaJuego.IsEnabled = true;
            selfie.IsEnabled = true;
            simone.IsEnabled = true;
            malikBrown.IsEnabled = true;
            simon.IsEnabled = true;
            kid1.IsEnabled = true;
            kid2.IsEnabled = true;
            kid3.IsEnabled = true;
            coraBrown.IsEnabled = true;
            jazmineBrown.IsEnabled = true;
            joaquinSimmons.IsEnabled = true;
            cimoneSimmons.IsEnabled = true;
        }

        private void SendNowButton_Click(object sender, RoutedEventArgs e)
        {
            // Create ImageMessage User Control.
            OutgoingMessages newImageMessage = new OutgoingMessages();
            
            // Remove text message.
            newImageMessage.TextMsg.Visibility = Visibility.Hidden;
            
            // Get selected button's name to call the correct image.
            string imageName = selectedImageButton.Name;

            if (imageName == "cimoneSimmons")
            {
                string stringPath = "C:/Users/karla/source/repos/ConnectGenApp/ConnectGenApp/AddedImages/" + imageName + ".jpeg";
                Uri imageUri = new Uri(stringPath, UriKind.RelativeOrAbsolute);
                BitmapImage imageBitmap = new BitmapImage(imageUri);
                newImageMessage.imageSent.Source = imageBitmap;
            }
            else if ((imageName == "jazmineBrown") || (imageName == "kid1") || (imageName == "kid2") || (imageName == "kid3"))
            {
                string stringPath = "C:/Users/karla/source/repos/ConnectGenApp/ConnectGenApp/AddedImages/" + imageName + ".png";
                Uri imageUri = new Uri(stringPath, UriKind.RelativeOrAbsolute);
                BitmapImage imageBitmap = new BitmapImage(imageUri);
                newImageMessage.imageSent.Source = imageBitmap;
            }
            else
            {
                string stringPath = "C:/Users/karla/source/repos/ConnectGenApp/ConnectGenApp/AddedImages/" + imageName + ".jpg";
                Uri imageUri = new Uri(stringPath, UriKind.RelativeOrAbsolute);
                BitmapImage imageBitmap = new BitmapImage(imageUri);
                newImageMessage.imageSent.Source = imageBitmap;
            }

            // Get message screen.
            MessageScreen oldWindow = (MessageScreen)this.DataContext;
            // Get time. Format using method from message screen.
            string timeCreated = oldWindow.GetTimefromVar(DateTime.Now);
            newImageMessage.TimeStamp.Content = timeCreated;
            // Add user control to msgDisplay.
            oldWindow.msgDisplay.Children.Add(newImageMessage);
            
            // Close menu.
            this.Close();
        }

        // Not completely implemented.
        private void AddToMessageButton_Click(object sender, RoutedEventArgs e)
        {
            /*
            // Get information of past window.
            MessageScreen oldWindow = (MessageScreen)this.DataContext;
            
            // Add to imageStackPanel using a button.
            Button imageNameButton = new Button();
            
            // Get image name.
            string imageName = selectedImageButton.Name;
            string newName = imageName;

            if (imageName == "cimoneSimmons")
            {
                newName = imageName + ".jpeg";
            }
            else if ((imageName == "jazmineBrown") || (imageName == "kid1") || (imageName == "kid2") || (imageName == "kid3"))
            {
                newName = imageName + ".png";
            }
            else
            {
                newName = imageName + ".jpg";
            }
           
            // Add this name to the button.
            imageNameButton.Content = newName;
            
            // Add button to stackPanel.
            oldWindow.imageStackPanel.Children.Add(imageNameButton);
            this.Close();
            */
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            // Change Title Back
            Title = "Select Picture";

            // Disable action buttons again.
            DisableActionButtons();

            // Enable image clicking.
            EnableAllButtons();
            
            // Make the selected image's background transparent again.
            selectedImageButton.Background = Brushes.Transparent;
        }

        public void AddImagesMenu_Closed(object sender, EventArgs e)
        {
            MessageScreen oldWindow = (MessageScreen)this.DataContext;
            oldWindow.EnableAllButtons();
        }
    }
}
