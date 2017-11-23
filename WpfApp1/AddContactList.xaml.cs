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
    /// Interaction logic for AddContactList.xaml
    /// </summary>
    public partial class AddContactList : UserControl
    {
        public AddContactList()
        {
            InitializeComponent();
            ContactList(); 

        }
        public void ContactList()
        {
            Contacts carol = new Contacts("Carol Brown", "carol_brownie", "images/coraBrown.jpg", ["jazmine","malik","joaquin", "leroy", "simone"]);
            Contacts malik = new Contacts("Malik Brown", "malikb", "images/malikBrown.jpg", ["jazmine", "carol", "joaquin", "leroy", "colonel", "edna", "simone"]);
            Contacts jazmine = new Contacts("Jazmine Brown", "jazzy", "images/jazmineBrown.jpg", ["malik", "carol", "joaquin", "leroy", "colonel", "edna", "simone"]);
            Contacts joaquin = new Contacts("Joaquin Simmons", "ujoaquintome", "images/joaquinSimmons", ["malik", "jazmine", "carol", "leroy", "marcus", "sasha", "simone"]);
            Contacts leroy = new Contacts("Leroy Brown", "leroybrown", "images/headshot.jpg", ["jazmine", "malik", "joaquin", "carol", "simone"]);
            Contacts simone = new Contacts("Simone Simmons", "simmysim", "images/cimoneSimmons.jpeg", ["malik", "jazmine", "carol", "leroy", "marcus", "sasha", "joaquin"]);
            Contacts colonel = new Contacts("Colonel Sanders", "colonel", "images/headshot.jpg", ["jazmine", "malik", "edna"]);
            Contacts edna = new Contacts("Edna Sanders", "ednasanders", "images/headshot.jpg", ["jazmine", "malik", "colonel"]);
        }
    }
}
