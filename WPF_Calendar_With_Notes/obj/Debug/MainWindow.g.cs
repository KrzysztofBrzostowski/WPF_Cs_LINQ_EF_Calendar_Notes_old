﻿#pragma checksum "..\..\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "197695C31716C7F9ECC17D34E4CA72A7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
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
using WPF_Calendar_With_Notes.Utilities.Converters;
using WPF_Calendar_With_Notes.ViewModel;


namespace WPF_Calendar_With_Notes {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu menu1;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.StatusBar statusBar1;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DateTextBlock;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock1;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock2;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Calendar MainCalendar;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lDataGridDescription;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGrid1;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bEditSelected;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bDeleteSelectedNote;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bAddNote;
        
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
            System.Uri resourceLocater = new System.Uri("/WPF_Calendar_With_Notes;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.menu1 = ((System.Windows.Controls.Menu)(target));
            return;
            case 2:
            
            #line 24 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.bQuit_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.statusBar1 = ((System.Windows.Controls.Primitives.StatusBar)(target));
            return;
            case 4:
            this.DateTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.textBlock1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.textBlock2 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.MainCalendar = ((System.Windows.Controls.Calendar)(target));
            
            #line 69 "..\..\MainWindow.xaml"
            this.MainCalendar.SelectedDatesChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.MainCalendar_SelectedDatesChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.label1 = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.lDataGridDescription = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.dataGrid1 = ((System.Windows.Controls.DataGrid)(target));
            
            #line 81 "..\..\MainWindow.xaml"
            this.dataGrid1.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.dataGrid1_PreviewKeyDown);
            
            #line default
            #line hidden
            
            #line 81 "..\..\MainWindow.xaml"
            this.dataGrid1.RowEditEnding += new System.EventHandler<System.Windows.Controls.DataGridRowEditEndingEventArgs>(this.dataGrid1_RowEditEnding);
            
            #line default
            #line hidden
            
            #line 83 "..\..\MainWindow.xaml"
            this.dataGrid1.SelectedCellsChanged += new System.Windows.Controls.SelectedCellsChangedEventHandler(this.dataGrid1_SelectedCellsChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.bEditSelected = ((System.Windows.Controls.Button)(target));
            return;
            case 12:
            this.bDeleteSelectedNote = ((System.Windows.Controls.Button)(target));
            return;
            case 13:
            this.bAddNote = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

