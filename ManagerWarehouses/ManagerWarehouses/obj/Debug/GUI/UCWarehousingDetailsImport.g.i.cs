﻿#pragma checksum "..\..\..\GUI\UCWarehousingDetailsImport.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A3DD42F78089BF2861ED40C092E331BFDBA3217529823A88F5A3424BF0A5C463"
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
    /// UCWarehousingDetails
    /// </summary>
    public partial class UCWarehousingDetails : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\GUI\UCWarehousingDetailsImport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox _txtEmployee_id;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\GUI\UCWarehousingDetailsImport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox _txtFullName;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\GUI\UCWarehousingDetailsImport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox _txtDate;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\GUI\UCWarehousingDetailsImport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox _txtNote;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\GUI\UCWarehousingDetailsImport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid _dataGridListShoes;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\GUI\UCWarehousingDetailsImport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox _txtNoteDelete;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\GUI\UCWarehousingDetailsImport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button _btnDelete;
        
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
            System.Uri resourceLocater = new System.Uri("/ManagerWarehouses;component/gui/ucwarehousingdetailsimport.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\GUI\UCWarehousingDetailsImport.xaml"
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
            this._txtEmployee_id = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this._txtFullName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this._txtDate = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this._txtNote = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this._dataGridListShoes = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this._txtNoteDelete = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this._btnDelete = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\GUI\UCWarehousingDetailsImport.xaml"
            this._btnDelete.Click += new System.Windows.RoutedEventHandler(this._btnDelete_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

