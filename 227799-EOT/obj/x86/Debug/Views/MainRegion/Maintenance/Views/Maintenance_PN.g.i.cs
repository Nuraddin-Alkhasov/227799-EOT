﻿#pragma checksum "..\..\..\..\..\..\..\Views\MainRegion\Maintenance\Views\Maintenance_PN.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CEA2BD4DFA9890E35B14A5F0CEF67F4012A245FA6E2ED4783798D4DB50E0E0B9"
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


namespace HMI.Maintenance {
    
    
    /// <summary>
    /// Maintenance_PN
    /// </summary>
    public partial class Maintenance_PN : VisiWin.Controls.View, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\..\..\..\..\..\Views\MainRegion\Maintenance\Views\Maintenance_PN.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LayoutRoot;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\..\..\..\Views\MainRegion\Maintenance\Views\Maintenance_PN.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.PanoramaNavigation pn_maintenance;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\..\..\..\Views\MainRegion\Maintenance\Views\Maintenance_PN.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.TextBlock header;
        
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
            System.Uri resourceLocater = new System.Uri("/227799-EOT;component/views/mainregion/maintenance/views/maintenance_pn.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\..\Views\MainRegion\Maintenance\Views\Maintenance_PN.xaml"
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
            this.pn_maintenance = ((VisiWin.Controls.PanoramaNavigation)(target));
            
            #line 12 "..\..\..\..\..\..\..\Views\MainRegion\Maintenance\Views\Maintenance_PN.xaml"
            this.pn_maintenance.SelectedPanoramaRegionChanged += new System.EventHandler<VisiWin.Controls.SelectedPanoramaRegionChangedEventArgs>(this.Pn_SelectedPanoramaRegionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.header = ((VisiWin.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

