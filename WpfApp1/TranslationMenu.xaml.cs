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

            // Make sure that the error message is not visible.
            translationErrorMessage.Visibility = Visibility.Hidden;
        }

        private void TranslationMenu_Closed(object sender, EventArgs e)
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

            // Boolean to check if a match was found.
            Boolean matchFound = false;
            // Array of words not matched.
            string[] notFound = new string[100];
            // Make sure that each entry is null.
            int h = 0;
            while (h < 100)
            {
                notFound[h] = "";
                h++;
            }

            // Go through each words in the oldMessageArray.
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
                        matchFound = true;
                        finalMessage = finalMessage + twoLanguages[1] + " ";
                    }
                }
                if (matchFound == false)
                {
                    // Add the word as typed.
                    finalMessage = finalMessage + currentWord + " ";
                    // However, wil add the word to the arrays of words not matched.
                    int k = 0;
                    while (notFound[k] != "")
                    {
                        k++;
                    }
                    notFound[k] = currentWord;
                }
                file.Close();
                // Not sure what this is supposed to do.
                System.Console.ReadLine();
                // Need to re-initialize matchFound as false;
                matchFound = false;
            }

            string missingWords = "";
            string pastWord = "";
            string newWord = "";

            // Create an error message for words that weren't found in the text file.
            int l = 0;
            while (notFound[l] != "")
            {
                pastWord = newWord;
                newWord = notFound[l];
                // Makes sure that the first word doesn't have a comma beforehand.
                if (pastWord != "")
                {
                    missingWords = missingWords + pastWord + ", ";
                }
                l++;
            }
            // Makes sure that the last word doesn't have a random comma after.
            missingWords = missingWords + newWord;
            // If the string was completed, then there must be words not found in the text file.
            if (missingWords != "")
            {
                // Change content of error message.
                translationErrorMessage.Content = "Error: Could not translate the following words: " + missingWords + "." + Environment.NewLine + "Please check if the first language chosen was correct or if you've misspelled any words.";
                // Make error message visible.
                translationErrorMessage.Visibility = Visibility.Visible;
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

            // Boolean to check if a match was found.
            Boolean matchFound = false;
            // Array of words not matched.
            string[] notFound = new string[100];
            // Make sure that each entry is null.
            int h = 0;
            while (h < 100)
            {
                notFound[h] = "";
                h++;
            }

            // Go through each words in the oldMessageArray.
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
                        matchFound = true;
                        finalMessage = finalMessage + twoLanguages[0] + " ";
                    }
                }
                if (matchFound == false)
                {
                    // Add the word as typed.
                    finalMessage = finalMessage + currentWord + " ";
                    // However, wil add the word to the arrays of words not matched.
                    int k = 0;
                    while (notFound[k] != "")
                    {
                        k++;
                    }
                    notFound[k] = currentWord;
                }
                file.Close();
                // Not sure what this is supposed to do.
                System.Console.ReadLine();
                // Need to re-initialize matchFound as false;
                matchFound = false;
            }

            string missingWords = "";
            string pastWord = "";
            string newWord = "";

            // Create an error message for words that weren't found in the text file.
            int l = 0;
            while (notFound[l] != "")
            {
                pastWord = newWord;
                newWord = notFound[l];
                // Makes sure that the first word doesn't have a comma beforehand.
                if (pastWord != "")
                {
                    missingWords = missingWords + pastWord + ", ";
                }
                l++;
            }
            // Makes sure that the last word doesn't have a random comma after.
            missingWords = missingWords + newWord;
            // If the string was completed, then there must be words not found in the text file.
            if (missingWords != "")
            {
                // Change content of error message.
                translationErrorMessage.Content = "Error: Could not translate the following words: " + missingWords + "." + Environment.NewLine + "Please check if the first language chosen was correct or if you've misspelled any words.";
                // Make error message visible.
                translationErrorMessage.Visibility = Visibility.Visible;
            }
            // Return the final message.
            return finalMessage;
        }

        private void ReverseButton_Click(object sender, RoutedEventArgs e)
        {
            object temporaryVar = initialLanguageMenu.SelectedValue;
            initialLanguageMenu.SelectedValue = finalLanguageMenu.SelectedValue;
            finalLanguageMenu.SelectedValue = temporaryVar;
        }

        private void CopyToTextBoxButton_Click(object sender, RoutedEventArgs e)
        {
            MessageScreen oldWindow = (MessageScreen)this.DataContext;
            oldWindow.messageBox.Text = finalMessageBox.Text;
            this.Close();
        }
    }
}
