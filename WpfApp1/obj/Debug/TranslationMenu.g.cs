﻿#pragma checksum "..\..\TranslationMenu.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C55BF1CB62843BF775B1C32EDAB106D70D931BD4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// TranslationMenu
    /// </summary>
    public partial class TranslationMenu : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\TranslationMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas TranslationCanvas;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\TranslationMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox initialMessageBox;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\TranslationMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox finalMessageBox;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\TranslationMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button translateButton;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\TranslationMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button copyToTextBoxButton;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\TranslationMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox initialLanguageMenu;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\TranslationMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox finalLanguageMenu;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\TranslationMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label toLabel;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\TranslationMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label errorMessageLabel;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\TranslationMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button reverseButton;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\TranslationMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label translationErrorMessage;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/translationmenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TranslationMenu.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\TranslationMenu.xaml"
            ((WpfApp1.TranslationMenu)(target)).Closed += new System.EventHandler(this.TranslationMenu_Closed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TranslationCanvas = ((System.Windows.Controls.Canvas)(target));
            return;
            case 3:
            this.initialMessageBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 12 "..\..\TranslationMenu.xaml"
            this.initialMessageBox.MouseEnter += new System.Windows.Input.MouseEventHandler(this.InitialMessageBox_MouseEnter);
            
            #line default
            #line hidden
            
            #line 12 "..\..\TranslationMenu.xaml"
            this.initialMessageBox.MouseLeave += new System.Windows.Input.MouseEventHandler(this.InitialMessageBox_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 4:
            this.finalMessageBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.translateButton = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\TranslationMenu.xaml"
            this.translateButton.Click += new System.Windows.RoutedEventHandler(this.TranslateButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.copyToTextBoxButton = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\TranslationMenu.xaml"
            this.copyToTextBoxButton.Click += new System.Windows.RoutedEventHandler(this.CopyToTextBoxButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.initialLanguageMenu = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.finalLanguageMenu = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.toLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.errorMessageLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.reverseButton = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\TranslationMenu.xaml"
            this.reverseButton.Click += new System.Windows.RoutedEventHandler(this.ReverseButton_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.translationErrorMessage = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

