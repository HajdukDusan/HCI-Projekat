﻿#pragma checksum "..\..\..\..\MvM\View\AllEventsView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D0D74E2E1F65CEFD46497740365F86B59D7E2DB65B6CC3D29E03E6BC23F7BE7C"
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
    /// AllEventsView
    /// </summary>
    public partial class AllEventsView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 170 "..\..\..\..\MvM\View\AllEventsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGrid;
        
        #line default
        #line hidden
        
        
        #line 219 "..\..\..\..\MvM\View\AllEventsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel panel1;
        
        #line default
        #line hidden
        
        
        #line 221 "..\..\..\..\MvM\View\AllEventsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label suggestionLabel;
        
        #line default
        #line hidden
        
        
        #line 229 "..\..\..\..\MvM\View\AllEventsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MessageTextBox;
        
        #line default
        #line hidden
        
        
        #line 242 "..\..\..\..\MvM\View\AllEventsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border panel2;
        
        #line default
        #line hidden
        
        
        #line 263 "..\..\..\..\MvM\View\AllEventsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox responce;
        
        #line default
        #line hidden
        
        
        #line 270 "..\..\..\..\MvM\View\AllEventsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AllowButton;
        
        #line default
        #line hidden
        
        
        #line 282 "..\..\..\..\MvM\View\AllEventsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DenyButton;
        
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
            System.Uri resourceLocater = new System.Uri("/HCI-Projekat;component/mvm/view/alleventsview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\MvM\View\AllEventsView.xaml"
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
            this.dataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 170 "..\..\..\..\MvM\View\AllEventsView.xaml"
            this.dataGrid.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.datagrid_CurrentCellChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.panel1 = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.suggestionLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.MessageTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.panel2 = ((System.Windows.Controls.Border)(target));
            return;
            case 6:
            this.responce = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.AllowButton = ((System.Windows.Controls.Button)(target));
            
            #line 271 "..\..\..\..\MvM\View\AllEventsView.xaml"
            this.AllowButton.Click += new System.Windows.RoutedEventHandler(this.AllowButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.DenyButton = ((System.Windows.Controls.Button)(target));
            
            #line 283 "..\..\..\..\MvM\View\AllEventsView.xaml"
            this.DenyButton.Click += new System.Windows.RoutedEventHandler(this.DenyButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
