﻿#pragma checksum "..\..\..\..\..\UserControls\Attack\MSSQL\FrmTaskManager.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4F54517409BE04862D95A19330662BD5"
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
using WarSQLiv2.UserControls.Attack.MSSQL;


namespace WarSQLiv2.UserControls.Attack.MSSQL {
    
    
    /// <summary>
    /// FrmTaskManager
    /// </summary>
    public partial class FrmTaskManager : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\..\UserControls\Attack\MSSQL\FrmTaskManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstLooted;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\..\UserControls\Attack\MSSQL\FrmTaskManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox txtStatus;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\..\UserControls\Attack\MSSQL\FrmTaskManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstTaskList;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\..\UserControls\Attack\MSSQL\FrmTaskManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGet;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\..\UserControls\Attack\MSSQL\FrmTaskManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblStrip;
        
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
            System.Uri resourceLocater = new System.Uri("/WarSQLiv2;component/usercontrols/attack/mssql/frmtaskmanager.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\UserControls\Attack\MSSQL\FrmTaskManager.xaml"
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
            
            #line 8 "..\..\..\..\..\UserControls\Attack\MSSQL\FrmTaskManager.xaml"
            ((WarSQLiv2.UserControls.Attack.MSSQL.FrmTaskManager)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lstLooted = ((System.Windows.Controls.ListBox)(target));
            
            #line 11 "..\..\..\..\..\UserControls\Attack\MSSQL\FrmTaskManager.xaml"
            this.lstLooted.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lstLooted_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtStatus = ((System.Windows.Controls.RichTextBox)(target));
            return;
            case 4:
            this.lstTaskList = ((System.Windows.Controls.ListBox)(target));
            
            #line 19 "..\..\..\..\..\UserControls\Attack\MSSQL\FrmTaskManager.xaml"
            this.lstTaskList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lstTaskList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnGet = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\..\..\UserControls\Attack\MSSQL\FrmTaskManager.xaml"
            this.btnGet.Click += new System.Windows.RoutedEventHandler(this.btnGet_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lblStrip = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

