﻿#pragma checksum "..\..\..\..\..\..\..\..\Main\Regions\DialogRegion\Protocol\Views\Protocol_Filter.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C16BF117F7FC2F7E836CC0D90B8D5003497ABFE067E465966ED7296087CDF2DE"
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


namespace HMI.DialogRegion.Protocol.Views {
    
    
    /// <summary>
    /// Protocol_Filter
    /// </summary>
    public partial class Protocol_Filter : VisiWin.Controls.View, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\..\..\..\..\..\Main\Regions\DialogRegion\Protocol\Views\Protocol_Filter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border border;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\..\..\..\..\Main\Regions\DialogRegion\Protocol\Views\Protocol_Filter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.TextBlock HeaderText;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\..\..\..\..\Main\Regions\DialogRegion\Protocol\Views\Protocol_Filter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.Button CancelButton;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\..\..\..\..\Main\Regions\DialogRegion\Protocol\Views\Protocol_Filter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border LayoutRoot;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\..\..\..\..\Main\Regions\DialogRegion\Protocol\Views\Protocol_Filter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem btn1;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\..\..\..\..\Main\Regions\DialogRegion\Protocol\Views\Protocol_Filter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem btn2;
        
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
            System.Uri resourceLocater = new System.Uri("/227799-EOT;component/main/regions/dialogregion/protocol/views/protocol_filter.xa" +
                    "ml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\..\..\Main\Regions\DialogRegion\Protocol\Views\Protocol_Filter.xaml"
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
            
            #line 8 "..\..\..\..\..\..\..\..\Main\Regions\DialogRegion\Protocol\Views\Protocol_Filter.xaml"
            ((VisiWin.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Cancel_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.border = ((System.Windows.Controls.Border)(target));
            
            #line 9 "..\..\..\..\..\..\..\..\Main\Regions\DialogRegion\Protocol\Views\Protocol_Filter.xaml"
            this.border.Loaded += new System.Windows.RoutedEventHandler(this.Border_Loaded);
            
            #line default
            #line hidden
            return;
            case 3:
            this.HeaderText = ((VisiWin.Controls.TextBlock)(target));
            return;
            case 4:
            this.CancelButton = ((VisiWin.Controls.Button)(target));
            
            #line 23 "..\..\..\..\..\..\..\..\Main\Regions\DialogRegion\Protocol\Views\Protocol_Filter.xaml"
            this.CancelButton.Click += new System.Windows.RoutedEventHandler(this.Cancel_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.LayoutRoot = ((System.Windows.Controls.Border)(target));
            return;
            case 6:
            this.btn1 = ((System.Windows.Controls.TabItem)(target));
            return;
            case 7:
            this.btn2 = ((System.Windows.Controls.TabItem)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

