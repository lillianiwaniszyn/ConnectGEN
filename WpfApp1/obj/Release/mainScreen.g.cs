﻿#pragma checksum "..\..\mainScreen.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D3B8D2A14F2A353178978A2C719DA09F"
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
    /// MainScreen
    /// </summary>
    public partial class MainScreen : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\mainScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button logoutButton;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\mainScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label unreadLabel;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\mainScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button middleContact;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\mainScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button leftContact;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\mainScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button rightContact;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\mainScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button leftArrow;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\mainScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button rightArrow;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\mainScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addContactImageButton;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\mainScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button myProfilePictureButton;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\mainScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button myProfileButton;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\mainScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addContactButton;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/mainscreen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\mainScreen.xaml"
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
            this.logoutButton = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\mainScreen.xaml"
            this.logoutButton.Click += new System.Windows.RoutedEventHandler(this.logoutButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.unreadLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.middleContact = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\mainScreen.xaml"
            this.middleContact.Click += new System.Windows.RoutedEventHandler(this.middleContact_Click_1);
            
            #line default
            #line hidden
            return;
            case 4:
            this.leftContact = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\mainScreen.xaml"
            this.leftContact.Click += new System.Windows.RoutedEventHandler(this.leftContact_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.rightContact = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\mainScreen.xaml"
            this.rightContact.Click += new System.Windows.RoutedEventHandler(this.rightContact_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.leftArrow = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.rightArrow = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.addContactImageButton = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\mainScreen.xaml"
            this.addContactImageButton.Click += new System.Windows.RoutedEventHandler(this.addContactImageButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.myProfilePictureButton = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\mainScreen.xaml"
            this.myProfilePictureButton.Click += new System.Windows.RoutedEventHandler(this.myProfilePictureButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.myProfileButton = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\mainScreen.xaml"
            this.myProfileButton.Click += new System.Windows.RoutedEventHandler(this.myProfileButton_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.addContactButton = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\mainScreen.xaml"
            this.addContactButton.Click += new System.Windows.RoutedEventHandler(this.addContactButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
