﻿#pragma checksum "..\..\..\..\..\..\..\..\Views\MainRegion\User\Views\User\User_AddChangeUser.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "036E0041CD646A4FAA3C23173A604CA66FA9976400D52C44EC7229E1EC4CFF73"
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
using VisiWin.Adapter;
using VisiWin.ApplicationFramework;
using VisiWin.Controls;
using VisiWin.Extensions;
using VisiWin.Shapes;


namespace HMI.User {
    
    
    /// <summary>
    /// User_AddChangeUser
    /// </summary>
    public partial class User_AddChangeUser : VisiWin.Controls.View, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\..\..\..\..\..\Views\MainRegion\User\Views\User\User_AddChangeUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel LayoutRoot;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\..\..\..\..\Views\MainRegion\User\Views\User\User_AddChangeUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.CheckBox CheckBoxCodeEnabled;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\..\..\..\..\Views\MainRegion\User\Views\User\User_AddChangeUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.CheckBox CheckBoxPasswordEnabled;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\..\..\..\..\Views\MainRegion\User\Views\User\User_AddChangeUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.TextBlock VWLabel0;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\..\..\..\..\Views\MainRegion\User\Views\User\User_AddChangeUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.RadioButton DeackNever;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\..\..\..\..\Views\MainRegion\User\Views\User\User_AddChangeUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.RadioButton DeackDate;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\..\..\..\..\Views\MainRegion\User\Views\User\User_AddChangeUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.RadioButton DeackTime;
        
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
            System.Uri resourceLocater = new System.Uri("/227799-EOT;component/views/mainregion/user/views/user/user_addchangeuser.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\..\..\Views\MainRegion\User\Views\User\User_AddChangeUser.xaml"
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
            this.LayoutRoot = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.CheckBoxCodeEnabled = ((VisiWin.Controls.CheckBox)(target));
            return;
            case 3:
            this.CheckBoxPasswordEnabled = ((VisiWin.Controls.CheckBox)(target));
            return;
            case 4:
            this.VWLabel0 = ((VisiWin.Controls.TextBlock)(target));
            return;
            case 5:
            this.DeackNever = ((VisiWin.Controls.RadioButton)(target));
            return;
            case 6:
            this.DeackDate = ((VisiWin.Controls.RadioButton)(target));
            return;
            case 7:
            this.DeackTime = ((VisiWin.Controls.RadioButton)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
