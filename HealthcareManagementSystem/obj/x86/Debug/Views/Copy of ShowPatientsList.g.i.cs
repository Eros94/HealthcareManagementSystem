﻿#pragma checksum "..\..\..\..\Views\Copy of ShowPatientsList.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "44317ED71816399BA25D6BEDC6D85905"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Controls;
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


namespace HealthcareManagementSystem.Views {
    
    
    /// <summary>
    /// ShowPatientsList
    /// </summary>
    public partial class ShowPatientsList : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\Views\Copy of ShowPatientsList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid1;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\Views\Copy of ShowPatientsList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid PatientsGrid;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Views\Copy of ShowPatientsList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button1;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Views\Copy of ShowPatientsList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchBox;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Views\Copy of ShowPatientsList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FilterByComboBox;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Views\Copy of ShowPatientsList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Label1;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\Views\Copy of ShowPatientsList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label QueryResult;
        
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
            System.Uri resourceLocater = new System.Uri("/HealthcareManagementSystem;component/views/copy%20of%20showpatientslist.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Copy of ShowPatientsList.xaml"
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
            this.grid1 = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.PatientsGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.button1 = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\..\Views\Copy of ShowPatientsList.xaml"
            this.button1.Click += new System.Windows.RoutedEventHandler(this.button1_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SearchBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.FilterByComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.Label1 = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.QueryResult = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

