﻿#pragma checksum "..\..\..\..\MvM\View\UserProfileView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DBFA15513BD717C5DB3C37B710A3AFB5629B97CBB0DE9A83135F70CB0CC4D6B0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HCI_Projekat.MvM.View;
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


namespace HCI_Projekat.MvM.View {
    
    
    /// <summary>
    /// UserProfileView
    /// </summary>
    public partial class UserProfileView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 135 "..\..\..\..\MvM\View\UserProfileView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock UsernameTextField;
        
        #line default
        #line hidden
        
        
        #line 148 "..\..\..\..\MvM\View\UserProfileView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock EmailTextField;
        
        #line default
        #line hidden
        
        
        #line 176 "..\..\..\..\MvM\View\UserProfileView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas canvasImages;
        
        #line default
        #line hidden
        
        
        #line 221 "..\..\..\..\MvM\View\UserProfileView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PhoneTextBox;
        
        #line default
        #line hidden
        
        
        #line 228 "..\..\..\..\MvM\View\UserProfileView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveEmail;
        
        #line default
        #line hidden
        
        
        #line 279 "..\..\..\..\MvM\View\UserProfileView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PasswordTextBox;
        
        #line default
        #line hidden
        
        
        #line 286 "..\..\..\..\MvM\View\UserProfileView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SavePassword;
        
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
            System.Uri resourceLocater = new System.Uri("/HCI-Projekat;component/mvm/view/userprofileview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\MvM\View\UserProfileView.xaml"
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
            this.UsernameTextField = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.EmailTextField = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.canvasImages = ((System.Windows.Controls.Canvas)(target));
            
            #line 180 "..\..\..\..\MvM\View\UserProfileView.xaml"
            this.canvasImages.PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.CanvasImages_PreviewMouseLeftButtonUp);
            
            #line default
            #line hidden
            
            #line 181 "..\..\..\..\MvM\View\UserProfileView.xaml"
            this.canvasImages.PreviewMouseMove += new System.Windows.Input.MouseEventHandler(this.CanvasImages_PreviewMouseMove);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 183 "..\..\..\..\MvM\View\UserProfileView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddButtonClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.PhoneTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.SaveEmail = ((System.Windows.Controls.Button)(target));
            
            #line 229 "..\..\..\..\MvM\View\UserProfileView.xaml"
            this.SaveEmail.Click += new System.Windows.RoutedEventHandler(this.SaveEmail_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.PasswordTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.SavePassword = ((System.Windows.Controls.Button)(target));
            
            #line 287 "..\..\..\..\MvM\View\UserProfileView.xaml"
            this.SavePassword.Click += new System.Windows.RoutedEventHandler(this.SavePassword_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

