﻿#pragma checksum "..\..\..\..\..\..\Main\Regions\HeaderRegion\Header.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AC01F7BBAC33B1DCC0EADE48A98335AF949A19D9B8A7A95D701D4BD2FE69716C"
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


namespace HMI.HeaderRegion.Views {
    
    
    /// <summary>
    /// Header
    /// </summary>
    public partial class Header : VisiWin.Controls.View, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\..\..\..\..\Main\Regions\HeaderRegion\Header.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LayoutRoot;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\..\..\..\..\Main\Regions\HeaderRegion\Header.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.Button barcode;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\..\..\..\..\Main\Regions\HeaderRegion\Header.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.Button barcodex;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\..\..\Main\Regions\HeaderRegion\Header.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.TextBlock AlarmText;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\..\..\Main\Regions\HeaderRegion\Header.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.TextVarOut CPU1;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\..\..\Main\Regions\HeaderRegion\Header.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.TextVarOut CPU2;
        
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
            System.Uri resourceLocater = new System.Uri("/227799-EOT;component/main/regions/headerregion/header.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\Main\Regions\HeaderRegion\Header.xaml"
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
            this.barcode = ((VisiWin.Controls.Button)(target));
            
            #line 8 "..\..\..\..\..\..\Main\Regions\HeaderRegion\Header.xaml"
            this.barcode.Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 3:
            this.barcodex = ((VisiWin.Controls.Button)(target));
            
            #line 9 "..\..\..\..\..\..\Main\Regions\HeaderRegion\Header.xaml"
            this.barcodex.Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 4:
            this.AlarmText = ((VisiWin.Controls.TextBlock)(target));
            return;
            case 5:
            this.CPU1 = ((VisiWin.Controls.TextVarOut)(target));
            
            #line 26 "..\..\..\..\..\..\Main\Regions\HeaderRegion\Header.xaml"
            this.CPU1.Loaded += new System.Windows.RoutedEventHandler(this.CPU1_Loaded);
            
            #line default
            #line hidden
            return;
            case 6:
            this.CPU2 = ((VisiWin.Controls.TextVarOut)(target));
            
            #line 27 "..\..\..\..\..\..\Main\Regions\HeaderRegion\Header.xaml"
            this.CPU2.Loaded += new System.Windows.RoutedEventHandler(this.CPU2_Loaded);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
