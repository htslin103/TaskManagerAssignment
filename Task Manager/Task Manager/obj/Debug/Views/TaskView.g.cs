﻿#pragma checksum "..\..\..\Views\TaskView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "787B398C70C2F84BD4B81DC75E4826D8BC23C5A60CAD7556C229E42082FA8822"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ReactiveUI;
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
using TaskManager.ViewModels;


namespace TaskManager.Views {
    
    
    /// <summary>
    /// TaskView
    /// </summary>
    public partial class TaskView : ReactiveUI.ReactiveWindow<TaskManager.ViewModels.TaskViewModel>, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\..\Views\TaskView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddNewTaskbtn;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Views\TaskView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteTaskbtn;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Views\TaskView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker taskDatePicker;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Views\TaskView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameTextBox;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Views\TaskView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock currentDateTxtBlock;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Views\TaskView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid tasksDataGrid;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\Views\TaskView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn NameDataGridText;
        
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
            System.Uri resourceLocater = new System.Uri("/TaskManager;component/views/taskview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\TaskView.xaml"
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
            this.AddNewTaskbtn = ((System.Windows.Controls.Button)(target));
            return;
            case 2:
            this.DeleteTaskbtn = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.taskDatePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.NameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.currentDateTxtBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.tasksDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.NameDataGridText = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

