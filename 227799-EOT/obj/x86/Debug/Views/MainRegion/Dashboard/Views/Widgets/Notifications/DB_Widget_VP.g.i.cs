﻿#pragma checksum "..\..\..\..\..\..\..\..\..\Views\MainRegion\Dashboard\Views\Widgets\Notifications\DB_Widget_VP.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DF224C4DF02F6F0867095BCD6181A3E931FE06516FCD6F19AE8A4BBE8CB02B1D"
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


namespace HMI.Dashboard {
    
    
    /// <summary>
    /// DB_Widget_VP
    /// </summary>
    public partial class DB_Widget_VP : VisiWin.Controls.View, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\..\..\..\..\..\..\..\Views\MainRegion\Dashboard\Views\Widgets\Notifications\DB_Widget_VP.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LayoutRoot;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\..\..\..\..\..\Views\MainRegion\Dashboard\Views\Widgets\Notifications\DB_Widget_VP.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.DateTimeVarIn tbTime;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\..\..\..\..\..\Views\MainRegion\Dashboard\Views\Widgets\Notifications\DB_Widget_VP.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.Button Enable;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\..\..\..\..\..\Views\MainRegion\Dashboard\Views\Widgets\Notifications\DB_Widget_VP.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.Button start;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\..\..\..\..\..\Views\MainRegion\Dashboard\Views\Widgets\Notifications\DB_Widget_VP.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.Button stop;
        
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
            System.Uri resourceLocater = new System.Uri("/227799-EOT;component/views/mainregion/dashboard/views/widgets/notifications/db_w" +
                    "idget_vp.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\..\..\..\Views\MainRegion\Dashboard\Views\Widgets\Notifications\DB_Widget_VP.xaml"
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
            this.tbTime = ((VisiWin.Controls.DateTimeVarIn)(target));
            return;
            case 3:
            this.Enable = ((VisiWin.Controls.Button)(target));
            return;
            case 4:
            this.start = ((VisiWin.Controls.Button)(target));
            
            #line 14 "..\..\..\..\..\..\..\..\..\Views\MainRegion\Dashboard\Views\Widgets\Notifications\DB_Widget_VP.xaml"
            this.start.Click += new System.Windows.RoutedEventHandler(this.Start_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.stop = ((VisiWin.Controls.Button)(target));
            
            #line 15 "..\..\..\..\..\..\..\..\..\Views\MainRegion\Dashboard\Views\Widgets\Notifications\DB_Widget_VP.xaml"
            this.stop.Click += new System.Windows.RoutedEventHandler(this.Stop_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

