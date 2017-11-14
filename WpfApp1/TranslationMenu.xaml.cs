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

namespace ConnectGenApp
{
    /// <summary>
    /// Interaction logic for TranslationMenu.xaml
    /// </summary>
    public partial class TranslationMenu : UserControl
    {
        public TranslationMenu()
        {
            InitializeComponent();
        }

        private void closeTranslationPopUp_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Clear();
        }
    }
}