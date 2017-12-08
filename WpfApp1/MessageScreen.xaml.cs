using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net;
using System.IO;
using System.Windows.Controls;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MessageScreen.xaml
    /// </summary>
    public partial class MessageScreen : Window
    {
        // Windows; Need these variables in order to switch windows.
        Login_Main restartWindow = new Login_Main();
        // Might want to change below to mainScreen after the file has been fixed.
        Home_Screen contactScreen = new Home_Screen();
        // Notifications Window
        NotificationWindow allNotifications = new NotificationWindow();
        // Contact Attribute
        string specificContact;

        // Old Constructor
        // Will hopefully not call on this.
        public MessageScreen()
        {
            InitializeComponent();

            // Need this.
            msgDisplay.DataContext = this;

            // Get the message history.
            specificContact = "jazmineBrown";
            SetUpScreen(specificContact);
        }

        // Official Constructor
        public MessageScreen(string contactUserName)
        {
            InitializeComponent();

            // Need this.
            msgDisplay.DataContext = this;

            specificContact = contactUserName;

            SetUpScreen(specificContact);

            // Test Video
            SimulateMsgNotification("Malik");
        }

        public void SetUpScreen(string userName)
        {
            // Set DataContext of Notification Window.
            allNotifications.DataContext = this;
            // Get image and contact picture.
            string picturePath = "";
            if (specificContact == "cora")
            {
                picturePath = "images/coraBrown.jpg";
                chatNameLabel.Content = "Cora";
            }
            else if (specificContact == "Karla1")
            {
                picturePath = "images/KarlaJuego.jpg";
                chatNameLabel.Content = "Karla";
            }
            else if (specificContact == "MalikBrown")
            {
                picturePath = "images/malikBrown.jpg";
                chatNameLabel.Content = "Malik";
            }
            else if (specificContact == "Simon22")
            {
                picturePath = "images/simon.jpg";
                chatNameLabel.Content = "Simon";
            }
            else if (specificContact == "jazmineBrown")
            {
                picturePath = "images/jazmineBrown.png";
                chatNameLabel.Content = "Jazmine";
            }
            Image myImage = new Image();
            myImage.Source = new BitmapImage(new Uri(picturePath, UriKind.RelativeOrAbsolute));
            contactPicture.Source = myImage.Source;

            // Local Variables
            string line = "";
            string[] commStates;
            char[] splitLine = { '|' };

            // Get file online.
            WebClient client = new WebClient();
            Stream stream = client.OpenRead("https://raw.githubusercontent.com/lillianiwaniszyn/ConnectGEN/master/WpfApp1/Communication/" + userName + ".txt");

            // Read the file.
            System.IO.StreamReader file = new System.IO.StreamReader(stream);
            while ((line = file.ReadLine()) != null)
            {
                commStates = line.Split(splitLine);

                // Check for messages.
                if (commStates[1] == "M")
                {
                    // Find out if the message is incoming or outgoing.
                    if (commStates[2] == "I")
                    {
                        // Call simulateIncomingMessages.
                        // Do I really need to pass the username as a parameter?
                        SimulateIncomingMessage(userName, commStates[3].ToString(), commStates[4].ToString());
                    }
                    else if (commStates[2] == "O")
                    {
                        // Call simulateOutgoingMessages.
                        SimulateOutgoingMessage(commStates[3].ToString(), commStates[4].ToString());
                    }
                }
                // Check for audio calls.
                else if (commStates[1] == "A")
                {
                    AVCallUserControl oldMessage = new AVCallUserControl();

                    if (commStates[4] == "A")
                    {
                        if (commStates[2] == "I")
                        {
                            string tempTime = commStates[5].ToString();
                            string lengthOfCall = "";
                            lengthOfCall = tempTime[0] + "" + tempTime[1] + " minutes and " + tempTime[3] + "" + tempTime[4] + " seconds.";
                            oldMessage.callMessageLabel.Content = userName + " audiocalled you at " + commStates[3] + " for " + lengthOfCall;
                        }
                        else if (commStates[2] == "O")
                        {
                            string tempTime = commStates[5].ToString();
                            string lengthOfCall = "";
                            lengthOfCall = tempTime[0] + "" + tempTime[1] + " minutes and " + tempTime[3] + "" + tempTime[4] + " seconds.";
                            oldMessage.callMessageLabel.Content = "You audiocalled " + userName + " at " + commStates[3] + " for " + lengthOfCall;
                        }
                        oldMessage.audioAcceptedIcon.Visibility = Visibility.Visible;
                    }
                    else if (commStates[4] == "D")
                    {
                        if (commStates[2] == "I")
                        {
                            oldMessage.callMessageLabel.Content = "You missed an audio call with " + userName + " at " + commStates[3];
                        }
                        else if (commStates[2] == "O")
                        {
                            oldMessage.callMessageLabel.Content = userName + " missed an audio call with you at " + commStates[3];
                        }
                        oldMessage.audioDeclinedIcon.Visibility = Visibility.Visible;
                    }
                    msgDisplay.Children.Add(oldMessage);
                }
                // Check for video calls.
                else if (commStates[1] == "V")
                {
                    AVCallUserControl oldMessage = new AVCallUserControl();
                    if (commStates[4] == "A")
                    {
                        if (commStates[2] == "I")
                        {
                            string tempTime = commStates[5].ToString();
                            string lengthOfCall = "";
                            lengthOfCall = tempTime[0] + "" + tempTime[1] + " minutes and " + tempTime[3] + "" + tempTime[4] + " seconds.";
                            oldMessage.callMessageLabel.Content = userName + " videocalled you at " + commStates[3] + " for " + lengthOfCall;
                        }
                        else if (commStates[2] == "O")
                        {
                            string tempTime = commStates[5].ToString();
                            string lengthOfCall = "";
                            lengthOfCall = tempTime[0] + "" + tempTime[1] + " minutes and " + tempTime[3] + "" + tempTime[4] + " seconds.";
                            oldMessage.callMessageLabel.Content = "You videocalled " + userName + " at " + commStates[3] + " for " + lengthOfCall;
                        }
                        oldMessage.videoAcceptedIcon.Visibility = Visibility.Visible;
                    }
                    else if (commStates[4] == "D")
                    {
                        if (commStates[2] == "I")
                        {
                            oldMessage.callMessageLabel.Content = "You missed a video call with " + userName + " at " + commStates[3];
                        }
                        else if (commStates[2] == "O")
                        {
                            oldMessage.callMessageLabel.Content = userName + " missed a video call with you at " + commStates[3];
                        }
                        oldMessage.videoDeclinedIcon.Visibility = Visibility.Visible;
                    }
                    msgDisplay.Children.Add(oldMessage);
                }
            }
            file.Close();
            // Not sure what this is supposed to do.
            System.Console.ReadLine();

            // Check if the addedMessages is set to true. If so, will have to read debugging file.
            Boolean addedMessages = true;

            if (specificContact == "cora")
            {
                addedMessages = Global_Data.sentCora;
            }
            else if (specificContact == "Karla1")
            {
                addedMessages = Global_Data.sentKarla1;
            }
            else if (specificContact == "liwanisz")
            {
                addedMessages = Global_Data.sentLiwanisz;
            }
            else if (specificContact == "MalikBrown")
            {
                addedMessages = Global_Data.sentMalikBrown;
            }
            else if (specificContact == "Simon22")
            {
                addedMessages = Global_Data.sentSimon22;
            }
            else if (specificContact == "jazmineBrown")
            {
                addedMessages = Global_Data.sentJazmine;
            }
            
            if (addedMessages == true)
            {
                // Read the file.
                System.IO.StreamReader secondFile = new System.IO.StreamReader(userName + ".txt");
                // Remove the single line.
                line = secondFile.ReadLine();
                while ((line = secondFile.ReadLine()) != null)
                {
                    commStates = line.Split(splitLine);

                    // Check for messages.
                    if (commStates[1] == "M")
                    {
                        // Find out if the message is incoming or outgoing.
                        if (commStates[2] == "I")
                        {
                            // Call simulateIncomingMessages.
                            // Do I really need to pass the username as a parameter?
                            SimulateIncomingMessage(userName, commStates[3].ToString(), commStates[4].ToString());
                        }
                        else if (commStates[2] == "O")
                        {
                            // Call simulateOutgoingMessages.
                            SimulateOutgoingMessage(commStates[3].ToString(), commStates[4].ToString());
                        }
                    }
                    // Check for audio calls.
                    else if (commStates[1] == "A")
                    {
                        AVCallUserControl oldMessage = new AVCallUserControl();

                        if (commStates[4] == "A")
                        {
                            if (commStates[2] == "I")
                            {
                                string tempTime = commStates[5].ToString();
                                string lengthOfCall = "";
                                lengthOfCall = tempTime[0] + "" + tempTime[1] + " minutes and " + tempTime[3] + "" + tempTime[4] + " seconds.";
                                oldMessage.callMessageLabel.Content = userName + " audiocalled you at " + commStates[3] + " for " + lengthOfCall;
                            }
                            else if (commStates[2] == "O")
                            {
                                string tempTime = commStates[5].ToString();
                                string lengthOfCall = "";
                                lengthOfCall = tempTime[0] + "" + tempTime[1] + " minutes and " + tempTime[3] + "" + tempTime[4] + " seconds.";
                                oldMessage.callMessageLabel.Content = "You audiocalled " + userName + " at " + commStates[3] + " for " + lengthOfCall;
                            }
                            oldMessage.audioAcceptedIcon.Visibility = Visibility.Visible;
                        }
                        else if (commStates[4] == "D")
                        {
                            if (commStates[2] == "I")
                            {
                                oldMessage.callMessageLabel.Content = "You missed an audio call with " + userName + " at " + commStates[3];
                            }
                            else if (commStates[2] == "O")
                            {
                                oldMessage.callMessageLabel.Content = userName + " missed an audio call with you at " + commStates[3];
                            }
                            oldMessage.audioDeclinedIcon.Visibility = Visibility.Visible;
                        }
                        msgDisplay.Children.Add(oldMessage);
                    }
                    // Check for video calls.
                    else if (commStates[1] == "V")
                    {
                        AVCallUserControl oldMessage = new AVCallUserControl();
                        if (commStates[4] == "A")
                        {
                            if (commStates[2] == "I")
                            {
                                string tempTime = commStates[5].ToString();
                                string lengthOfCall = "";
                                lengthOfCall = tempTime[0] + "" + tempTime[1] + " minutes and " + tempTime[3] + "" + tempTime[4] + " seconds.";
                                oldMessage.callMessageLabel.Content = userName + " videocalled you at " + commStates[3] + " for " + lengthOfCall;
                            }
                            else if (commStates[2] == "O")
                            {
                                string tempTime = commStates[5].ToString();
                                string lengthOfCall = "";
                                lengthOfCall = tempTime[0] + "" + tempTime[1] + " minutes and " + tempTime[3] + "" + tempTime[4] + " seconds.";
                                oldMessage.callMessageLabel.Content = "You videocalled " + userName + " at " + commStates[3] + " for " + lengthOfCall;
                            }
                            oldMessage.videoAcceptedIcon.Visibility = Visibility.Visible;
                        }
                        else if (commStates[4] == "D")
                        {
                            if (commStates[2] == "I")
                            {
                                oldMessage.callMessageLabel.Content = "You missed a video call with " + userName + " at " + commStates[3];
                            }
                            else if (commStates[2] == "O")
                            {
                                oldMessage.callMessageLabel.Content = userName + " missed a video call with you at " + commStates[3];
                            }
                            oldMessage.videoDeclinedIcon.Visibility = Visibility.Visible;
                        }
                        msgDisplay.Children.Add(oldMessage);
                    }
                }
                file.Close();
                // Not sure what this is supposed to do.
                System.Console.ReadLine();
            }
        }

        // WORKS. Method for exiting the chat. Opens unto the contacts screen.
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            contactScreen.Show();
        }

        // WORKS. Method for logging out of the chat. Opens onto the login page.
        private void LogOutButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            restartWindow.Show();
        }

        // NOT CREATED YET. Messages are cleared from the screen and are replaced with the picture pop-up window.
        // Need to get Sabrina's code for this. (Currently moves to a user control: AddImageMenu)
        private void AddImageButton_Click(object sender, RoutedEventArgs e)
        {
            DisableAllButtons();
            AddImageMenu newImageMenu = new AddImageMenu();
            newImageMenu.DataContext = this;
            newImageMenu.Show();
        }

        // NOT CREATED YET. Messages are cleared from the screen and replaced with the translate menu.
        // Need to create a similar function on incoming messages. (IncomingMessages.xaml.cs --> TextBubble OnClick)
        // Need to find a way to access translations (Google Translate?).
        private void TranslateButton_Click(object sender, RoutedEventArgs e)
        {
            // Create a translate menu that contains this screen as a parameter. (In order to re-enable buttons when it has been deleted.)
            TranslationMenu currentTranslationMenu = new TranslationMenu();
            // Add DataContext to the translation menu.
            currentTranslationMenu.DataContext = this;
            // Replace the text in the translation menu with the text written in the chat's text box.
            currentTranslationMenu.initialMessageBox.Text = messageBox.Text;
            // Make sure that no other activity can take place by disabling all other buttons.
            DisableAllButtons();
            // Show the new window.
            currentTranslationMenu.Show();
        }

        // Works. Method that removes the prompt text as long as the mouse is over the textbox.
        private void DeletePromptText(object sender, MouseEventArgs e)
        {
            // Make that the error label isn't there.
            noMessageErrorLabel.Visibility = Visibility.Hidden;
            // Makes sure that there isn't a message typed into the text box. 
            if (messageBox.Text == "Click here to type your message.")
            {
                // Removes text, such that user can enter a new message.
                messageBox.Text = "";
            }
        }

        // Works. Method that creates the prompt text as long as mouse stays away from the textbox.
        private void CreatePromptText(object sender, MouseEventArgs e)
        {
            // Makes sure that there isn't a message typed into the text box. (Since mouse has to leave the textbox in order to send the message.)
            if (messageBox.Text == "")
                // Sets the contents of the text box to the standard prompt.
                messageBox.Text = "Click here to type your message.";
        }

        /// WORKS. Method for extracting the message from the text box and calling the SimulateOutgoingMessage function.
        // Need to create: Method that makes sure that the content in the box is not the standard message. Will have to create an error message/notification.
        private void SendMessageButton_Click(object sender, RoutedEventArgs e)
        {
            // Obtain the text message written in the messageBox.
            string textMessage = messageBox.Text;
            // Recreates the prompt, such that user knows they can write something new.
            messageBox.Text = "Click here to type your message.";

            // Error Check: If the standard message is still in the text box...
            // Will assume that user will not enter in a message that consists only of spaces.
            if (textMessage == "Click here to type your message.")
            {
                // Make error message visible.
                noMessageErrorLabel.Visibility = Visibility.Visible;
                // Make sure that prompt is back.
                messageBox.Text = "Click here to type your message.";
            }
            else
            {
                // Call the SimulateOutgoingMessage function to put the message into the chat.
                SimulateOutgoingMessage(null, textMessage);
            }

            string timeStamp = GetTimefromVar(DateTime.Now);

            // Need to write to text file.
            string fileName = specificContact + "" + ".txt";
            string toBeInserted = "R|M|O|" + timeStamp + "|" + textMessage;
            File.AppendAllText(fileName, Environment.NewLine);
            File.AppendAllText(fileName, toBeInserted);
            // Change boolean in global data.
            if (specificContact == "cora")
            {
                Global_Data.sentCora = true;
            }
            else if (specificContact == "Karla1")
            {
                Global_Data.sentKarla1 = true;
            }
            else if (specificContact == "liwanisz")
            {
                Global_Data.sentLiwanisz = true;
            }
            else if (specificContact == "MalikBrown")
            {
                Global_Data.sentMalikBrown = true;
            }
            else if (specificContact == "Simon22")
            {
                Global_Data.sentSimon22 = true;
            }
        }

        // NOT COMPLETELY IMPLEMENTED.
        // Need to Complete: Figure out if the user is on the chat of the sender.
        // Need to Complete: Call SimulateMsgNotification function if not.
        // Able to obtain the time that the message was sent. Calls the GetTimefromVar method to change the format.
        // Creates a user control for IncomingMessages, which will contain the time stamp and the message formatted using the ChangeTextFormat function.
        public void SimulateIncomingMessage(string senderName, string timeSent, string textMessage)
        {
            // If not on the chat of the sender,
            // Call the SimulateMsgNotification function. User senderName as parameter.

            // Otherwise,
            // Get the date and time that the message was sent. Format it, such that only time is shown.
            string timeStamp = timeSent;
            if (timeStamp == null)
            {
                DateTime currentDateAndTime = DateTime.Now;
                timeStamp = GetTimefromVar(currentDateAndTime);
            }
            // Format the textMessage parameter, such that the message doesn't exceed the size of the text bubble.
            string finalTextMessage = ChangeTextFormat(textMessage);

            // Create the user control for IncomingMessages.
            IncomingMessages newMessage = new IncomingMessages();
            // Fill in user control using the formatted time stamp and text message.
            newMessage.TimeStamp.Content = timeStamp;
            newMessage.TextMsg.Content = finalTextMessage;
            // Add userControl to stackPanel.
            msgDisplay.Children.Add(newMessage);
            // Recreate prompt text.
            messageBox.Text = "Click here to type your message.";
        }

        // WORKS. Method that changes the format of the DateTime variable to only contain the time.
        public string GetTimefromVar(DateTime currentDateAndTime)
        {
            // Converts the DateTime variable into a string variable.
            string dateAndTime = currentDateAndTime.ToString();
            // Set the currentTime to an empty string.
            string currentTime = "";
            // Knowing that indexes 0 to 10 contains the date, the index starts at 11.
            int index = 11;

            // While the end of the string hasn't been reached 'M' (Spaces already in String),
            while (dateAndTime[index] != 'M')
            {
                // Add the character to the string containing the currentTime.
                currentTime = currentTime + dateAndTime[index];
                // Move into the next index.
                index++;
            }

            // Since 'M' wasn't included in the while loop, 'M' needs to be added.
            currentTime = currentTime + "M";

            // Return the newly formatted time stamp.
            return currentTime;
        }

        // WORKS. Limit for Text Bubble: 19 Characters per Row, 6 Rows
        // Method that changes the format of the text message to fit into the text bubble.
        public string ChangeTextFormat(string textMessage)
        {
            // Start with an empty string for the final text message.
            string finalTextMessage = "";
            // Split the text message, such that each index is a word.
            string[] TextMessageWords = textMessage.Split(null);

            // Start with an empty line, index of 0, and a character count of 0.
            string currentLine = "";
            int index = 0;
            int charCount = currentLine.Length;

            // While the index is not out of bounds,
            while (index < TextMessageWords.Length)
            {
                // Create a temporary line that contains the current line and the new word.
                string tempLine = currentLine + " " + TextMessageWords[index];
                // Create a variable that counts the number of characters in this new line.
                int temp = tempLine.Length;
                // If the temporary line has less characters than the maximum allowed for each row,
                if (temp < 20)
                {
                    // Set the current line to contain the new word. 
                    currentLine = tempLine;
                    // Count the new character count, which now contains the new word.
                    charCount = currentLine.Length;
                }
                // But if the new word causes the line to exceed the maximum number of characters,
                else
                {
                    // The previous line, from before the word was added, is a part of the final message.
                    // As well, a new line is created. 
                    finalTextMessage = finalTextMessage + currentLine + Environment.NewLine;
                    // The current line will now contain only the new word.
                    currentLine = "" + TextMessageWords[index];
                    // The amount of characters of this line depends on the length of the new word.
                    charCount = currentLine.Length;
                }

                // Move on to the new word of the array.
                index++;
            }

            // Add last line created to the final message.
            finalTextMessage = finalTextMessage + currentLine;

            // Return this final message to be later added to the user control. 
            return finalTextMessage;
        }

        // WORKS. 
        // Able to obtain the time that the message was sent. Calls the GetTimefromVar method to change the format.
        // Creates a user control for OutgoingMessages, which will contain the time stamp and the message formatted using the ChangeTextFormat function.
        public void SimulateOutgoingMessage(string timeSent, string textMessage)
        {
            // Get the date and time that the message was sent. Format it, such that only time is shown.
            string timeStamp = timeSent;
            if (timeStamp == null)
            {
                DateTime currentDateAndTime = DateTime.Now;
                timeStamp = GetTimefromVar(currentDateAndTime);
            }
            // Format the textMessage parameter, such that the message doesn't exceed the size of the text bubble.
            string finalTextMessage = ChangeTextFormat(textMessage);

            // Create the user control for OutgoingMessages.
            OutgoingMessages newMessage = new OutgoingMessages();
            // Fill in user control using the formatted time stamp and text message.
            newMessage.TimeStamp.Content = timeStamp;
            newMessage.TextMsg.Content = finalTextMessage;
            // Add userControl to stackPanel.
            msgDisplay.Children.Add(newMessage);
            // Recreate prompt text.
            messageBox.Text = "Click here to type your message.";
        }

        // NOT CREATED YET. Will need to display the notification, or multiple. (Can receive multiple messages.)
        // Current Idea: Might want to create a user control for notification, which will replace the message display.
        public void SimulateMsgNotification(string senderName)
        {
            MessageNotification newMessage = new MessageNotification();
            newMessage.DataContext = allNotifications;
            newMessage.senderName.Content = senderName;

            allNotifications.notificationDisplay.Children.Add(newMessage);
            //this.Visibility = Visibility.Hidden;
            allNotifications.Show();
        }

        // NOT CREATED YET. Will need to display the notification, or multiple. (Can receive multiple messages.)
        // Current Idea: Might want to create a user control for notification, which will replace the message display.
        public void SimulateAudioNotification(string senderName)
        {
            AudioNotification newMessage = new AudioNotification();
            newMessage.DataContext = allNotifications;
            newMessage.senderName.Content = senderName;

            allNotifications.notificationDisplay.Children.Add(newMessage);
            this.Visibility = Visibility.Hidden;
            allNotifications.Show();
        }

        // NOT CREATED YET. Will need to display the notification, or multiple. (Can receive multiple messages.)
        // Current Idea: Might want to create a user control for notification, which will replace the message display.
        public void SimulateVideoNotification(string senderName)
        {
            VideoNotification newMessage = new VideoNotification();
            newMessage.DataContext = allNotifications;
            newMessage.senderName.Content = senderName;

            allNotifications.notificationDisplay.Children.Add(newMessage);
            this.Visibility = Visibility.Hidden;
            allNotifications.Show();
        }

        // In the event that an action that demands all attention has stopped taking place, all buttons must be enabled again.
        public void EnableAllButtons()
        {
            // Back Button
            backButton.IsEnabled = true;
            // Log Out Button
            logOutButton.IsEnabled = true;
            // Send Button
            sendMessageButton.IsEnabled = true;
            // Add Image Button
            addImageButton.IsEnabled = true;
            // Translate Button
            translateButton.IsEnabled = true;
        }

        // Works.
        // In the event that an action is taking place that demands all attention, all buttons must be disabled.
        public void DisableAllButtons()
        {
            // Back Button
            backButton.IsEnabled = false;
            // Log Out Button
            logOutButton.IsEnabled = false;
            // Send Button
            sendMessageButton.IsEnabled = false;
            // Add Image Button
            addImageButton.IsEnabled = false;
            // Translate Button
            translateButton.IsEnabled = false;
        }
    }
}