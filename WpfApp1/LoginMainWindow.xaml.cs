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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NewAccount newAccount1 = new NewAccount();

        public MainWindow()
        {
            InitializeComponent();

        }
        void OnClick1(object sender, RoutedEventArgs e)
        {


            newAccount1.Show();
            this.Close();
        
        }
    }
}
