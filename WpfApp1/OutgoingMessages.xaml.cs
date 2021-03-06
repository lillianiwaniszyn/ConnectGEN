﻿using System;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for OutgoingMessages.xaml
    /// </summary>
    public partial class OutgoingMessages : UserControl
    {
        public OutgoingMessages()
        {
            InitializeComponent();
        }

        // WORKS. Method that calls the translationMenu using the message in the text bubble. (Double Click).
        // Enters the entire message, which should be formatted, into the translation menu.
        private void CallTranslation(object sender, RoutedEventArgs e)
        {
            // Converts the content in the message box to string format.
            string oldUntranslatedMsg = (string)TextMsg.Content;
            // String is currently in formatted form. Need to undo.
            string untranslatedMsg = UnformatTextMsg(oldUntranslatedMsg);

            // Create User Control.
            TranslationMenu translationPopUp = new TranslationMenu();
            translationPopUp.DataContext = (this.Parent as Panel).DataContext;
            // Disable buttons on message screen.
            MessageScreen oldestWindow = (MessageScreen)translationPopUp.DataContext;
            oldestWindow.DisableAllButtons();
            // Set the initialMessageBox to contain the untranslatedMsg.
            translationPopUp.initialMessageBox.Text = untranslatedMsg;
            translationPopUp.Show();
            translationPopUp.Topmost = true;
        }

        // WORKS. (With a mild bug. New lines results in double spaces. Can live with)
        // Method that formats the message from the text bubble to a few lines. 
        public string UnformatTextMsg(string oldTextMsg)
        {
            // Starts with an empty string.
            string newTextMsg = "";
            // Splits the message from the text bubble based on empty spaces.
            string[] TextMessageWords = oldTextMsg.Split(null);
            // Start with an index of 0.
            int index = 0;

            // While the index is in bounds of the array,
            while (index < TextMessageWords.Length)
            {
                // Add each new word to the newTextMsg string. Add a space at the end to keep the string from becoming one long word.
                newTextMsg = newTextMsg + TextMessageWords[index] + " ";
                // Move on to the next index.
                index++;
            }

            // Return the new message.
            return newTextMsg;
        }
    }
}