﻿#pragma checksum "..\..\RunnersForm.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F44C8B545FF6D2220F80AB801CE8B30E6824D876"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MarathonWpf;
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


namespace MarathonWpf {
    
    
    /// <summary>
    /// RunnersForm
    /// </summary>
    public partial class RunnersForm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\RunnersForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox SortFilterGB;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\RunnersForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox StatusCB;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\RunnersForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox DistanceCB;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\RunnersForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SortCB;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\RunnersForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox ExportGB;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\RunnersForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CSVBtn;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\RunnersForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EmailListBtn;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\RunnersForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChangeBtn;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\RunnersForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid RunnersGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/MarathonWpf;component/runnersform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\RunnersForm.xaml"
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
            this.SortFilterGB = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 2:
            this.StatusCB = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.DistanceCB = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.SortCB = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.ExportGB = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 6:
            this.CSVBtn = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.EmailListBtn = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.ChangeBtn = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\RunnersForm.xaml"
            this.ChangeBtn.Click += new System.Windows.RoutedEventHandler(this.ChangeBtn_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.RunnersGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

