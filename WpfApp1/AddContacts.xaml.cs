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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for AddContacts.xaml
    /// </summary>
    public partial class AddContacts : Window
    {
        Global_Data dataClass = new Global_Data();
        ContactsUC contact1 = new ContactsUC(3);
        ContactsUC contact2 = new ContactsUC(5);
        ContactsUC contact3 = new ContactsUC(6);
        ContactsUC contact4 = new ContactsUC(7);
        //ContactsUC contact = new ContactsUC();

        public AddContacts()
        {
            InitializeComponent();
        }


        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Home_Screen home = new Home_Screen();
            home.Show();
            this.Close();
        }


        private void SearchingFor(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (searchContact.Text == "        SEARCH")
            {
                searchContact.Text = String.Empty;
                searchicon.Visibility = Visibility.Collapsed;
                searchContact.Foreground = Brushes.Black;
            }

        }

        private void SearchFor(object sender, TextChangedEventArgs e)
        {

            string searchFor = searchContact.Text;
            if (searchFor.Equals("s"))
            {
                if (!listOfContacts.Children.Contains(contact1))
                {
                    if (listOfContacts.Children.Contains(contact4))
                        listOfContacts.Children.Remove(contact4);
                    listOfContacts.Children.Add(contact1);
                    listOfContacts.Children.Add(contact2);
                    listOfContacts.Children.Add(contact3);
                }
            }
            else if (searchFor.Equals("si"))
            {
                if (!listOfContacts.Children.Contains(contact1))
                {
                    if (listOfContacts.Children.Contains(contact4))
                        listOfContacts.Children.Remove(contact4);
                    listOfContacts.Children.Remove(contact2);
                    listOfContacts.Children.Remove(contact3);
                    listOfContacts.Children.Add(contact1);
                    listOfContacts.Children.Add(contact2);
                    listOfContacts.Children.Add(contact3);
                }
            }
            else if (searchFor.Equals("sim"))
            {
                if (!listOfContacts.Children.Contains(contact1))
                {
                    if (listOfContacts.Children.Contains(contact4))
                        listOfContacts.Children.Remove(contact4);
                    listOfContacts.Children.Remove(contact2);
                    listOfContacts.Children.Remove(contact3);
                    listOfContacts.Children.Add(contact1);
                    listOfContacts.Children.Add(contact2);
                    listOfContacts.Children.Add(contact3);
                }
            }
            else if (searchFor.Equals("simo"))
            {
                if (!listOfContacts.Children.Contains(contact1))
                {
                    if (listOfContacts.Children.Contains(contact4))
                        listOfContacts.Children.Remove(contact4);
                    listOfContacts.Children.Remove(contact2);
                    listOfContacts.Children.Remove(contact3);
                    listOfContacts.Children.Add(contact1);
                    listOfContacts.Children.Add(contact2);
                    listOfContacts.Children.Add(contact3);
                }
            }
            else if (searchFor.Equals("simon"))
            {
                if (!listOfContacts.Children.Contains(contact1))
                {
                    if (listOfContacts.Children.Contains(contact4))
                        listOfContacts.Children.Remove(contact4);
                    listOfContacts.Children.Remove(contact2);
                    listOfContacts.Children.Remove(contact3);
                    listOfContacts.Children.Add(contact1);
                    listOfContacts.Children.Add(contact2);
                    listOfContacts.Children.Add(contact3);
                }
            }
            else if (searchFor.Equals("simone"))
            {
                listOfContacts.Children.Remove(contact1);
                if (!listOfContacts.Children.Contains(contact4))
                    listOfContacts.Children.Add(contact4);
            }
            else
            {
                if (listOfContacts.Children.Contains(contact4))
                    listOfContacts.Children.Remove(contact4);
                listOfContacts.Children.Remove(contact1);
                listOfContacts.Children.Remove(contact2);
                listOfContacts.Children.Remove(contact3);
            }

        }

        private void scrollUp_Click(object sender, RoutedEventArgs e)
        {
            if (listOfContacts.Children.Contains(contact1) && !listOfContacts.Children.Contains(contact4))
            {
                //Do nothing
            }
            else if (searchContact.Text != "simone" && !listOfContacts.Children.Contains(contact1) && listOfContacts.Children.Contains(contact4))
            {
                listOfContacts.Children.Remove(contact2);
                listOfContacts.Children.Remove(contact3);
                listOfContacts.Children.Remove(contact4);
                listOfContacts.Children.Add(contact1);
                listOfContacts.Children.Add(contact2);
                listOfContacts.Children.Add(contact3);
            }
            else
            {
                //Do nothing
            }

        }

        private void returnToNormal(object sender, RoutedEventArgs e)
        {
            if (searchContact.Text == "")
            {
                searchContact.Foreground = Brushes.Gray;
                searchContact.Text = "        SEARCH";
                searchicon.Visibility = Visibility.Visible;
            }
        }

        private void Scroll_Down(object sender, RoutedEventArgs e)
        {
            if (listOfContacts.Children.Contains(contact1) && !listOfContacts.Children.Contains(contact4))
            {
                listOfContacts.Children.Remove(contact1);
                listOfContacts.Children.Remove(contact2);
                listOfContacts.Children.Remove(contact3);
                listOfContacts.Children.Add(contact2);
                listOfContacts.Children.Add(contact3);
                listOfContacts.Children.Add(contact4);
            }
            else
            {
                //Do nothing
            }
        }
    }
}
