#pragma checksum "..\..\Home_Screen.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5628FC3C264DB20923719C38E40E75E5"
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


namespace WpfApp1
{


    /// <summary>
    /// Home_Screen
    /// </summary>
    public partial class Home_Screen : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 26 "..\..\Home_Screen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button logoutButton;

#line default
#line hidden


#line 29 "..\..\Home_Screen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label unreadLabel;

#line default
#line hidden


#line 30 "..\..\Home_Screen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button middleContact;

#line default
#line hidden


#line 33 "..\..\Home_Screen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button leftContact;

#line default
#line hidden


#line 36 "..\..\Home_Screen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button rightContact;

#line default
#line hidden


#line 39 "..\..\Home_Screen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button leftArrow;

#line default
#line hidden


#line 42 "..\..\Home_Screen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button rightArrow;

#line default
#line hidden


#line 62 "..\..\Home_Screen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addContactImageButton;

#line default
#line hidden


#line 65 "..\..\Home_Screen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button myProfilePictureButton;

#line default
#line hidden


#line 68 "..\..\Home_Screen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button myProfileButton;

#line default
#line hidden


#line 69 "..\..\Home_Screen.xaml"
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
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/home_screen.xaml", System.UriKind.Relative);

#line 1 "..\..\Home_Screen.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.logoutButton = ((System.Windows.Controls.Button)(target));

#line 26 "..\..\Home_Screen.xaml"
                    this.logoutButton.Click += new System.Windows.RoutedEventHandler(this.LogoutButton_Click);

#line default
#line hidden
                    return;
                case 2:
                    this.unreadLabel = ((System.Windows.Controls.Label)(target));
                    return;
                case 3:
                    this.middleContact = ((System.Windows.Controls.Button)(target));

#line 30 "..\..\Home_Screen.xaml"
                    this.middleContact.Click += new System.Windows.RoutedEventHandler(this.MiddleContact_Click_1);

#line default
#line hidden
                    return;
                case 4:
                    this.leftContact = ((System.Windows.Controls.Button)(target));

#line 33 "..\..\Home_Screen.xaml"
                    this.leftContact.Click += new System.Windows.RoutedEventHandler(this.LeftContact_Click);

#line default
#line hidden
                    return;
                case 5:
                    this.rightContact = ((System.Windows.Controls.Button)(target));

#line 36 "..\..\Home_Screen.xaml"
                    this.rightContact.Click += new System.Windows.RoutedEventHandler(this.RightContact_Click);

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

#line 62 "..\..\Home_Screen.xaml"
                    this.addContactImageButton.Click += new System.Windows.RoutedEventHandler(this.AddContactImageButton_Click);

#line default
#line hidden
                    return;
                case 9:
                    this.myProfilePictureButton = ((System.Windows.Controls.Button)(target));

#line 65 "..\..\Home_Screen.xaml"
                    this.myProfilePictureButton.Click += new System.Windows.RoutedEventHandler(this.MyProfilePictureButton_Click);

#line default
#line hidden
                    return;
                case 10:
                    this.myProfileButton = ((System.Windows.Controls.Button)(target));

#line 68 "..\..\Home_Screen.xaml"
                    this.myProfileButton.Click += new System.Windows.RoutedEventHandler(this.MyProfileButton_Click);

#line default
#line hidden
                    return;
                case 11:
                    this.addContactButton = ((System.Windows.Controls.Button)(target));

#line 69 "..\..\Home_Screen.xaml"
                    this.addContactButton.Click += new System.Windows.RoutedEventHandler(this.AddContactButton_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.Image MiddleImage;
        internal System.Windows.Controls.Image LeftImage;
        internal System.Windows.Controls.Image RightImage;
    }
}

