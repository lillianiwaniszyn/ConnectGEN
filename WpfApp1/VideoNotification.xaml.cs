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
    /// Interaction logic for VideoNotification.xaml
    /// </summary>
    public partial class VideoNotification : UserControl
    {
        public VideoNotification()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);

            // If there aren't anymore notifications. Need to show message history of current contact.
        }

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            // Remove this from the notification window.
            (this.Parent as Panel).Children.Remove(this);
            // Close the notification window.
            NotificationWindow oldWindow = (NotificationWindow)this.DataContext;
            oldWindow.Close();

            // Start a video call.
            VideoCall newVideoCall = new VideoCall();
            // Get contact.
            string newContact = (string)senderName.Content;
            if (newContact == "Malik")
            {
                // Default VideoCall is Malik.
                // Therefore, do nothing.
            }

            // Close the messageScreen.
            // In case of errors, might want to make it invisible instead.
            MessageScreen messageWindow = (MessageScreen)oldWindow.DataContext;
            messageWindow.Close();

            // Show the new video call.
            newVideoCall.Show();
        }
    }
}
