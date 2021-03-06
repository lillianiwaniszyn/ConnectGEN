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
    /// Interaction logic for UnreadNotification.xaml
    /// </summary>
    public partial class UnreadNotification : UserControl
    {
        public UnreadNotification()
        {
            InitializeComponent();

            // Initially make all icons invisible.
            messagePicture.Visibility = Visibility.Hidden;
            audioPicture.Visibility = Visibility.Hidden;
            videoPicture.Visibility = Visibility.Hidden;
        }

        // Call if the user control is meant to be a message notification.
        public void SetMsg(string username)
        {
            typeOfUnread.Content = "Unread Message";
            contactName.Content = username;
            messagePicture.Visibility = Visibility.Visible;
        }

        // Call if the user control is meant to be an audio call notification.
        public void SetAudio(string username)
        {
            typeOfUnread.Content = "Missed Audio Call";
            contactName.Content = username;
            audioPicture.Visibility = Visibility.Visible;
        }

        // Call if the user control is meant to be a video call notification.
        public void SetVideo(string username)
        {
            typeOfUnread.Content = "Missed Video Call";
            contactName.Content = username;
            videoPicture.Visibility = Visibility.Visible;
        }

        private void CloseNotification_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
        }
    }
}