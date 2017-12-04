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
        }

        private void TranslationPopUp_Closed(object sender, EventArgs e)
        {
            // Get DataContext.
            MessageScreen oldWindow = (MessageScreen)this.DataContext;
            // Use the MessageScreen to enable buttons.
            oldWindow.EnableAllButtons();
        }
    }
}
