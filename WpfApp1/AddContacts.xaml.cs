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
    /// Interaction logic for AddContacts.xaml
    /// </summary>
    public partial class AddContacts : Window
    {
        public AddContacts()
        {
            InitializeComponent();
            AddContactList contactlist = new AddContactList();

        }
        public void MakeList()
        {

        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); 
            //newWindowShow 
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void List_scrollUp(object sender, RoutedEventArgs e)
        {
        
        }

        private void List_scrollDown(object sender, RoutedEventArgs e)
        {

        }

        private void SearchFor(object sender, TextCompositionEventArgs e)
        {

    }
}
