﻿#pragma checksum "..\..\Table.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A9A0BD39E119907B40D4BF49673A3182E9580B6C8D5A5F5DD4D723DAAA773214"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using UI;


namespace UI {
    
    
    /// <summary>
    /// table
    /// </summary>
    public partial class table : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\Table.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid lvTable;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\Table.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btAddTable;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\Table.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btDeleteTable;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\Table.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btUpgradeTable;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\Table.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btViewTable;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\Table.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btHome;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\Table.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Exit;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\Table.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Minimize;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\Table.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbtID;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\Table.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbtName;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\Table.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbtStatus;
        
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
            System.Uri resourceLocater = new System.Uri("/QLQA;component/table.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Table.xaml"
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
            this.lvTable = ((System.Windows.Controls.DataGrid)(target));
            
            #line 21 "..\..\Table.xaml"
            this.lvTable.Loaded += new System.Windows.RoutedEventHandler(this.lvTable_Loaded);
            
            #line default
            #line hidden
            
            #line 22 "..\..\Table.xaml"
            this.lvTable.SelectedCellsChanged += new System.Windows.Controls.SelectedCellsChangedEventHandler(this.lvTable_SelectedCellsChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btAddTable = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\Table.xaml"
            this.btAddTable.Click += new System.Windows.RoutedEventHandler(this.btAddTable_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btDeleteTable = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\Table.xaml"
            this.btDeleteTable.Click += new System.Windows.RoutedEventHandler(this.btDeleteTable_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btUpgradeTable = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\Table.xaml"
            this.btUpgradeTable.Click += new System.Windows.RoutedEventHandler(this.btUpgradeTable_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btViewTable = ((System.Windows.Controls.Button)(target));
            
            #line 70 "..\..\Table.xaml"
            this.btViewTable.Click += new System.Windows.RoutedEventHandler(this.btViewTable_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btHome = ((System.Windows.Controls.Button)(target));
            
            #line 89 "..\..\Table.xaml"
            this.btHome.Click += new System.Windows.RoutedEventHandler(this.btHome_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Exit = ((System.Windows.Controls.Button)(target));
            
            #line 99 "..\..\Table.xaml"
            this.Exit.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Minimize = ((System.Windows.Controls.Button)(target));
            
            #line 109 "..\..\Table.xaml"
            this.Minimize.Click += new System.Windows.RoutedEventHandler(this.Minimize_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.tbtID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.tbtName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.cbtStatus = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

