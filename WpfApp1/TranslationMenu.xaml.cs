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
    /// Interaction logic for TranslationMenu.xaml
    /// </summary>
    public partial class TranslationMenu : Window
    {
        public TranslationMenu()
        {
            InitializeComponent();
        }

        private void TranslationPopUp_Closed(object sender, EventArgs e)
        {
            // Get DataContext.
            MessageScreen oldWindow = (MessageScreen)this.DataContext;
            // Use the MessageScreen to enable buttons.
            oldWindow.EnableAllButtons();
        }

        private void InitialMessageBox_MouseEnter(object sender, MouseEventArgs e)
        {
            // Makes sure that there isn't a message typed into the text box.
            if ((initialMessageBox.Text == "Click here to type your message.") || (initialMessageBox.Text == "Click here to type your message..."))
            {
                // Removes the prompt text, such that the user can enter a new message.
                initialMessageBox.Text = "";
            }
        }

        private void InitialMessageBox_MouseLeave(object sender, MouseEventArgs e)
        {
            // Makes sure that there wasn't a message typed into the text box.
            if (initialMessageBox.Text == "")
            {
                // Recreates the prompt text.
                initialMessageBox.Text = "Click here to type your message...";
            }
        }

        private void ReverseButton_Click(object sender, RoutedEventArgs e)
        {
            object temporaryVar = initialLanguageMenu.SelectedValue;
            initialLanguageMenu.SelectedValue = finalLanguageMenu.SelectedValue;
            finalLanguageMenu.SelectedValue = temporaryVar;
        }

        private void TranslateButton_Click(object sender, RoutedEventArgs e)
        {
            // Get languages from the menus.
            string initialLanguage = initialLanguageMenu.SelectedValue.ToString();
            string finalLanguage = finalLanguageMenu.SelectedValue.ToString();
            // Get message that needs to be translated.
            string toBeTranslated = initialMessageBox.Text;
            string translatedMessage = "";

            if (initialLanguage == finalLanguage)
            {
                translatedMessage = toBeTranslated;
            }
            else if (initialLanguage == "English")
            {
                // If so, call the final language's text file.
                // Use the English translation to get the translation.

                translatedMessage = FromEnglishTranslation(toBeTranslated, finalLanguage);
            }
            else if (finalLanguage == "English")
            {
                // Need to call the initial language's text file.
                translatedMessage = ToEnglishTranslation(toBeTranslated, initialLanguage);
            }
            else
            {
                // Otherwise, need to call the initial language's text file to obtain the English translation.
                // Call the final language's text file.
                // Use the English translation to get the translation.
                string midTranslation = ToEnglishTranslation(toBeTranslated, initialLanguage);
                translatedMessage = FromEnglishTranslation(midTranslation, finalLanguage);
            }

            finalMessageBox.Text = translatedMessage;
        }

        // Cannot be used for screen initialization using language. Will be creating a method specific for phrases.
        public string FromEnglishTranslation(string oldMessage, string newLanguage)
        {
            // Initialize final message.
            string finalMessage = "";

            // Split the old message into separate words in an array.
            string[] oldMessageArray = oldMessage.Split();
            int arrayLength = oldMessageArray.Length;

            // Variables to the read the final language's text file.
            string currentWord;
            string line;
            string[] twoLanguages;
            char[] splitLine = { '|' };

            // Go through each words in the oldMessageArray/.
            for (int i = 0; i < arrayLength; i++)
            {
                currentWord = oldMessageArray[i].ToLower();

                // Read the file.
                System.IO.StreamReader file = new System.IO.StreamReader("Translation/" + newLanguage + ".txt");
                while ((line = file.ReadLine()) != null)
                {
                    twoLanguages = line.Split(splitLine);

                    if (twoLanguages[0] == currentWord)
                    {
                        finalMessage = finalMessage + twoLanguages[1] + " ";
                    }
                }
                file.Close();
                // Not sure what this is supposed to do.
                System.Console.ReadLine();
            }

            // Return the final message.
            return finalMessage;
        }

        public string ToEnglishTranslation(string oldMessage, string oldLanguage)
        {
            // Initialize final message.
            string finalMessage = "";

            // Split the old message into separate words in an array.
            string[] oldMessageArray = oldMessage.Split();
            int arrayLength = oldMessageArray.Length;

            // Variables to the read the final language's text file.
            string currentWord;
            string line;
            string[] twoLanguages;
            char[] splitLine = { '|' };

            // Go through each words in the oldMessageArray/.
            for (int i = 0; i < arrayLength; i++)
            {
                currentWord = oldMessageArray[i].ToLower();

                // Read the file.
                System.IO.StreamReader file = new System.IO.StreamReader("Translation/" + oldLanguage + ".txt");
                while ((line = file.ReadLine()) != null)
                {
                    twoLanguages = line.Split(splitLine);

                    if (twoLanguages[1] == currentWord)
                    {
                        finalMessage = finalMessage + twoLanguages[0] + " ";
                    }
                }
                file.Close();
                // Not sure what this is supposed to do.
                System.Console.ReadLine();
            }

            // Return the final message.
            return finalMessage;
        }
    }
}
