﻿#pragma checksum "..\..\AddContacts.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1990B4D7A0BCE1943C5AAAE9573F07B3DA25F9F0"
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
    /// AddContacts
    /// </summary>
    public partial class AddContacts : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\AddContacts.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backArrow;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\AddContacts.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchContact;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\AddContacts.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image searchicon;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\AddContacts.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button scrollUp;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\AddContacts.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button scrollDown;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\AddContacts.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backlbutton;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/addcontacts.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddContacts.xaml"
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
            this.backArrow = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\AddContacts.xaml"
            this.backArrow.Click += new System.Windows.RoutedEventHandler(this.back_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.searchContact = ((System.Windows.Controls.TextBox)(target));
            
            #line 24 "..\..\AddContacts.xaml"
            this.searchContact.TextInput += new System.Windows.Input.TextCompositionEventHandler(this.SearchFor);
            
            #line default
            #line hidden
            return;
            case 3:
            this.searchicon = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.scrollUp = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\AddContacts.xaml"
            this.scrollUp.Click += new System.Windows.RoutedEventHandler(this.list_scrollUp);
            
            #line default
            #line hidden
            return;
            case 5:
            this.scrollDown = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\AddContacts.xaml"
            this.scrollDown.Click += new System.Windows.RoutedEventHandler(this.list_scrollDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.backlbutton = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\AddContacts.xaml"
            this.backlbutton.Click += new System.Windows.RoutedEventHandler(this.back_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

