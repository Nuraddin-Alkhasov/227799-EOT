﻿#pragma checksum "..\..\..\..\..\..\..\..\..\Views\MainRegion\Protocol\Views\Charges\SetValues\Protocol_SetValues.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E7FD7F2350B569B08A82C8FC6A69202EE3C0041F6297E2C0EC7005EFA732C246"
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


namespace HMI.Views.MainRegion.Protocol {
    
    
    /// <summary>
    /// Protocol_SetValues
    /// </summary>
    public partial class Protocol_SetValues : VisiWin.Controls.View, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\..\..\..\..\..\..\Views\MainRegion\Protocol\Views\Charges\SetValues\Protocol_SetValues.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.TextBlock HeaderText;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\..\..\..\..\..\Views\MainRegion\Protocol\Views\Charges\SetValues\Protocol_SetValues.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.Button CancelButton;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\..\..\..\..\..\Views\MainRegion\Protocol\Views\Charges\SetValues\Protocol_SetValues.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox SV;
        
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
            System.Uri resourceLocater = new System.Uri("/227799-EOT;component/views/mainregion/protocol/views/charges/setvalues/protocol_" +
                    "setvalues.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\..\..\..\Views\MainRegion\Protocol\Views\Charges\SetValues\Protocol_SetValues.xaml"
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
            
            #line 6 "..\..\..\..\..\..\..\..\..\Views\MainRegion\Protocol\Views\Charges\SetValues\Protocol_SetValues.xaml"
            ((HMI.Views.MainRegion.Protocol.Protocol_SetValues)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.View_IsVisibleChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 11 "..\..\..\..\..\..\..\..\..\Views\MainRegion\Protocol\Views\Charges\SetValues\Protocol_SetValues.xaml"
            ((VisiWin.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.HeaderText = ((VisiWin.Controls.TextBlock)(target));
            return;
            case 4:
            this.CancelButton = ((VisiWin.Controls.Button)(target));
            
            #line 23 "..\..\..\..\..\..\..\..\..\Views\MainRegion\Protocol\Views\Charges\SetValues\Protocol_SetValues.xaml"
            this.CancelButton.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.SV = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

