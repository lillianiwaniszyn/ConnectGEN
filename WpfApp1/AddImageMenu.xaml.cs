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
    /// Interaction logic for AddImageMenu.xaml
    /// </summary>
    public partial class AddImageMenu : Window
    {
        public AddImageMenu()
        {
            InitializeComponent();
        }

        private void GetConfirmation(object sender, RoutedEventArgs e)
        {
            DisableAllButtons();
            string thisImageName = (sender as Button).Name;
            ConfirmPicture newConfirmation = new ConfirmPicture();
            newConfirmation.DataContext = this;
            newConfirmation.imageName.Content = thisImageName;
            newConfirmation.Show();
        }

        public void DisableAllButtons()
        {
            KarlaJuego.IsEnabled = false;
            selfie.IsEnabled = false;
            simone.IsEnabled = false;
            malikBrown.IsEnabled = false;
            simon.IsEnabled = false;
            kid1.IsEnabled = false;
            kid2.IsEnabled = false;
            kid3.IsEnabled = false;
            coraBrown.IsEnabled = false;
            jazmineBrown.IsEnabled = false;
            joaquinSimmons.IsEnabled = false;
            cimoneSimmons.IsEnabled = false;
        }

        public void EnableAllButtons()
        {
            KarlaJuego.IsEnabled = true;
            selfie.IsEnabled = true;
            simone.IsEnabled = true;
            malikBrown.IsEnabled = true;
            simon.IsEnabled = true;
            kid1.IsEnabled = true;
            kid2.IsEnabled = true;
            kid3.IsEnabled = true;
            coraBrown.IsEnabled = true;
            jazmineBrown.IsEnabled = true;
            joaquinSimmons.IsEnabled = true;
            cimoneSimmons.IsEnabled = true;
        }

        public void AddImagesMenu_Closed(object sender, EventArgs e)
        {
            MessageScreen oldWindow = (MessageScreen)this.DataContext;
            oldWindow.EnableAllButtons();
        }
    }
}
