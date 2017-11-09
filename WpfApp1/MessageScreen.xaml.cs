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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TranslateScreens
{
    /// <summary>
    /// Interaction logic for MessageScreen.xaml
    /// </summary>
    public partial class MessageScreen : Window
    {
        public MessageScreen()
        {

            // Next to chat name, put a profile picture section to see who they're talking to each other.
            // Ask Shaheed about his code for the back button.
            InitializeComponent();
            // Need these two lines. Otherwise, default setting will always be hidden. Therefore, clicking on the translate button won't work.
            translationPopUp.Visibility = Visibility.Hidden;
            // Should be set to hidden. But, for the screenshots, will need to have it visible.
            messagePopUp.Visibility = Visibility.Visible;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {

        }

        // In the event that the user clicks on the actual icon, which is covering part of the button.
        private void BackArrowIcon_Click(object sender, RoutedEventArgs e)
        {
            BackButton_Click(sender, e);
        }

        private void LogOutButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SendMessageButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddImageButton_Click(object sender, RoutedEventArgs e)
        {
           
        }

        // In the event that the user clicks on the actual icon, which is covering part of the button.
        private void AddImageIcon_Click(object sender, RoutedEventArgs e)
        {
            AddImageButton_Click(sender, e);
        }

        private void TranslateButton_Click(object sender, RoutedEventArgs e)
        {
            translationPopUp.Visibility = Visibility.Visible;
        }

        // In the event that the user clicks on the actual icon, which is covering part of the button.
        private void TranslateIcon_Click(object sender, RoutedEventArgs e)
        {
            TranslateButton_Click(sender, e);
        }

        private void CloseTranslationPopUpButton_Click(object sender, RoutedEventArgs e)
        {
            translationPopUp.Visibility = Visibility.Hidden;
        }

        private void DoTranslationButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CopyToTextBoxButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CloseMsgPopUpButton_Click(object sender, RoutedEventArgs e)
        {
            messagePopUp.Visibility = Visibility.Hidden;
        }

        private void ChangeChatButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void initialMessageBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void reverseLangButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void reverseLangButtonIcon_Click(object sender, RoutedEventArgs e)
        {
            reverseLangButton_Click(sender, e);
        }
    }
}
