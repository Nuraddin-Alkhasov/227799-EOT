﻿#pragma checksum "..\..\..\..\..\..\..\Main\TouchpadRegion\TouchPads\Views\NumericTouchpadView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CC0CAB6481468DA4FA92E37D046F8D98B6DB2AFE991E4B4C16C15459A67E330B"
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
using System.Windows.Interactivity;
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


namespace HMI {
    
    
    /// <summary>
    /// NumericTouchpadView
    /// </summary>
    public partial class NumericTouchpadView : VisiWin.Controls.View, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\..\..\..\..\Main\TouchpadRegion\TouchPads\Views\NumericTouchpadView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.Button CancelButton;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\..\..\..\Main\TouchpadRegion\TouchPads\Views\NumericTouchpadView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblNumericPadDescription;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\..\..\..\Main\TouchpadRegion\TouchPads\Views\NumericTouchpadView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.NumericVarIn numericVarIn;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\..\..\..\Main\TouchpadRegion\TouchPads\Views\NumericTouchpadView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblUnitText;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\..\..\..\Main\TouchpadRegion\TouchPads\Views\NumericTouchpadView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.TextVarOut lblLimitMaxString;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\..\..\..\Main\TouchpadRegion\TouchPads\Views\NumericTouchpadView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.TextVarOut lblLimitMinString;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\..\..\..\Main\TouchpadRegion\TouchPads\Views\NumericTouchpadView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.TouchKeyboard touchkeyboard1;
        
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
            System.Uri resourceLocater = new System.Uri("/227799-EOT;component/main/touchpadregion/touchpads/views/numerictouchpadview.xam" +
                    "l", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\..\Main\TouchpadRegion\TouchPads\Views\NumericTouchpadView.xaml"
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
            this.CancelButton = ((VisiWin.Controls.Button)(target));
            
            #line 21 "..\..\..\..\..\..\..\Main\TouchpadRegion\TouchPads\Views\NumericTouchpadView.xaml"
            this.CancelButton.Click += new System.Windows.RoutedEventHandler(this.CancelButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lblNumericPadDescription = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.numericVarIn = ((VisiWin.Controls.NumericVarIn)(target));
            
            #line 25 "..\..\..\..\..\..\..\Main\TouchpadRegion\TouchPads\Views\NumericTouchpadView.xaml"
            this.numericVarIn.WriteValueCompleted += new System.Windows.RoutedEventHandler(this.NumericVarIn_WriteValueCompleted);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lblUnitText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.lblLimitMaxString = ((VisiWin.Controls.TextVarOut)(target));
            return;
            case 6:
            this.lblLimitMinString = ((VisiWin.Controls.TextVarOut)(target));
            return;
            case 7:
            this.touchkeyboard1 = ((VisiWin.Controls.TouchKeyboard)(target));
            
            #line 29 "..\..\..\..\..\..\..\Main\TouchpadRegion\TouchPads\Views\NumericTouchpadView.xaml"
            this.touchkeyboard1.EscapeKeyPressed += new System.Windows.RoutedEventHandler(this.Touchkeyboard1_EscapeKeyPressed);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

