﻿#pragma checksum "..\..\..\..\..\..\..\..\Main\Resources\User Controls\MO\Station\MV_HZ.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "73301BAE30A246EE1E476F5B1ABF64777C079C7D9C0CAA11041C03E78EE3C859"
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
using System.Windows.Forms.Integration;
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


namespace HMI.Resources.UserControls.MO {
    
    
    /// <summary>
    /// MV_HZ
    /// </summary>
    public partial class MV_HZ : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\..\..\..\..\..\..\Main\Resources\User Controls\MO\Station\MV_HZ.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel A;
        
        #line default
        #line hidden
        
        
        #line 7 "..\..\..\..\..\..\..\..\Main\Resources\User Controls\MO\Station\MV_HZ.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid HZ1;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\..\..\..\..\Main\Resources\User Controls\MO\Station\MV_HZ.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.Button hzNL;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\..\..\..\..\Main\Resources\User Controls\MO\Station\MV_HZ.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.NumericVarOut HZ1F;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\..\..\..\..\Main\Resources\User Controls\MO\Station\MV_HZ.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.NumericVarOut HZ1T;
        
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
            System.Uri resourceLocater = new System.Uri("/227799-EOT;component/main/resources/user%20controls/mo/station/mv_hz.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\..\..\Main\Resources\User Controls\MO\Station\MV_HZ.xaml"
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
            
            #line 4 "..\..\..\..\..\..\..\..\Main\Resources\User Controls\MO\Station\MV_HZ.xaml"
            ((HMI.Resources.UserControls.MO.MV_HZ)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.A = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.HZ1 = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.hzNL = ((VisiWin.Controls.Button)(target));
            return;
            case 5:
            this.HZ1F = ((VisiWin.Controls.NumericVarOut)(target));
            return;
            case 6:
            this.HZ1T = ((VisiWin.Controls.NumericVarOut)(target));
            return;
            case 7:
            
            #line 30 "..\..\..\..\..\..\..\..\Main\Resources\User Controls\MO\Station\MV_HZ.xaml"
            ((VisiWin.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

