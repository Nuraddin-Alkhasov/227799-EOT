﻿#pragma checksum "..\..\..\..\..\..\..\..\..\..\Main\Regions\Main\Dashboard\Views\Widgets\Statistic\.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4197EEBC6C88BF361D209B707A42989BB9CDC42A7D115F2C49F4604D0293F23B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LiveCharts.Wpf;
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
    /// DB_Widget_Prod2
    /// </summary>
    public partial class DB_Widget_Prod2 : VisiWin.Controls.View, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\..\..\..\..\..\..\Main\Regions\Main\Dashboard\Views\Widgets\Statistic\.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LiveCharts.Wpf.CartesianChart chart;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\..\..\..\..\..\..\Main\Regions\Main\Dashboard\Views\Widgets\Statistic\.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LiveCharts.Wpf.Separator oxSeparator;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\..\..\..\..\..\..\Main\Regions\Main\Dashboard\Views\Widgets\Statistic\.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LiveCharts.Wpf.Axis oy;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\..\..\..\..\..\..\Main\Regions\Main\Dashboard\Views\Widgets\Statistic\.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LiveCharts.Wpf.Separator oySeparator;
        
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
            System.Uri resourceLocater = new System.Uri("/227799-EOT;component/main/regions/main/dashboard/views/widgets/statistic/.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\..\..\..\..\Main\Regions\Main\Dashboard\Views\Widgets\Statistic\.xaml"
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
            this.chart = ((LiveCharts.Wpf.CartesianChart)(target));
            return;
            case 2:
            this.oxSeparator = ((LiveCharts.Wpf.Separator)(target));
            return;
            case 3:
            this.oy = ((LiveCharts.Wpf.Axis)(target));
            return;
            case 4:
            this.oySeparator = ((LiveCharts.Wpf.Separator)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

