﻿#pragma checksum "..\..\..\GUI\WindowEditShoes.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FB483E5BBDBA7DE6A671B9FEDC805FAFB5BD865FB8431E60707EC289B0BF89E7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ManagerWarehouses.GUI;
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


namespace ManagerWarehouses.GUI {
    
    
    /// <summary>
    /// WindowEditShoes
    /// </summary>
    public partial class WindowEditShoes : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\GUI\WindowEditShoes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        private System.Windows.Controls.TextBox txtNum;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\GUI\WindowEditShoes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        private System.Windows.Controls.Button cmdDown;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\GUI\WindowEditShoes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox _txtNote;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\GUI\WindowEditShoes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button _btnSave;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\GUI\WindowEditShoes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button _btnExit;
        
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
            System.Uri resourceLocater = new System.Uri("/ManagerWarehouses;component/gui/windoweditshoes.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\GUI\WindowEditShoes.xaml"
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
            this.txtNum = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.cmdDown = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\GUI\WindowEditShoes.xaml"
            this.cmdDown.Click += new System.Windows.RoutedEventHandler(this.cmdDown_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this._txtNote = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this._btnSave = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\GUI\WindowEditShoes.xaml"
            this._btnSave.Click += new System.Windows.RoutedEventHandler(this._btnSave_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this._btnExit = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\GUI\WindowEditShoes.xaml"
            this._btnExit.Click += new System.Windows.RoutedEventHandler(this._btnExit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

