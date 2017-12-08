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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for ContactsUC.xaml
    /// </summary>
    public partial class ContactsUC : UserControl
    {
        Global_Data dataClass = new Global_Data();
        int index;
        public ContactsUC(int input)
        {
            InitializeComponent();
            index = input;
            user_name.Content = dataClass.firstnames[index] + " " + dataClass.lastnames[index];
            Image.Source = new BitmapImage(new Uri(dataClass.profilePicPath[index], UriKind.Relative));
            addplus.Source = new BitmapImage(new Uri(dataClass.checks[index], UriKind.Relative));
        }
    }
}
