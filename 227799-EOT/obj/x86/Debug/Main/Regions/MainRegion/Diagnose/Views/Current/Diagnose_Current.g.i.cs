﻿#pragma checksum "..\..\..\..\..\..\..\..\..\Main\Regions\MainRegion\Diagnose\Views\Current\Diagnose_Current.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4E80160F4A9F1716685962B198D982285D565737BE285568F9F3D2D33ABDF7BB"
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


namespace HMI.Diagnose {
    
    
    /// <summary>
    /// Diagnose_Current
    /// </summary>
    public partial class Diagnose_Current : VisiWin.Controls.View, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\..\..\..\..\..\Main\Regions\MainRegion\Diagnose\Views\Current\Diagnose_Current.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LayoutRoot;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\..\..\..\..\..\Main\Regions\MainRegion\Diagnose\Views\Current\Diagnose_Current.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.Border SubMenu;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\..\..\..\..\..\Main\Regions\MainRegion\Diagnose\Views\Current\Diagnose_Current.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.Button ButtonQuittieren;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\..\..\..\..\..\Main\Regions\MainRegion\Diagnose\Views\Current\Diagnose_Current.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.Button ButtonCloseMenu;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\..\..\..\..\..\Main\Regions\MainRegion\Diagnose\Views\Current\Diagnose_Current.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.Button ButtonOpenMenu;
        
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
            System.Uri resourceLocater = new System.Uri("/227799-EOT;component/main/regions/mainregion/diagnose/views/current/diagnose_cur" +
                    "rent.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\..\..\..\Main\Regions\MainRegion\Diagnose\Views\Current\Diagnose_Current.xaml"
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
            this.LayoutRoot = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.SubMenu = ((VisiWin.Controls.Border)(target));
            return;
            case 3:
            this.ButtonQuittieren = ((VisiWin.Controls.Button)(target));
            return;
            case 4:
            this.ButtonCloseMenu = ((VisiWin.Controls.Button)(target));
            
            #line 31 "..\..\..\..\..\..\..\..\..\Main\Regions\MainRegion\Diagnose\Views\Current\Diagnose_Current.xaml"
            this.ButtonCloseMenu.Click += new System.Windows.RoutedEventHandler(this.CloseMenu_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ButtonOpenMenu = ((VisiWin.Controls.Button)(target));
            
            #line 32 "..\..\..\..\..\..\..\..\..\Main\Regions\MainRegion\Diagnose\Views\Current\Diagnose_Current.xaml"
            this.ButtonOpenMenu.Click += new System.Windows.RoutedEventHandler(this.OpenMenu_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

