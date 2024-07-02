﻿#pragma checksum "..\..\..\..\..\..\..\Main\Regions\MessageBoxRegion\Views\MessageBox.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5D8756B87C44DBE073EDC019F4E176A46856B96EB6AAD38201A9132AFAFE8E10"
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


namespace HMI.MessageBoxRegion.Views {
    
    
    /// <summary>
    /// MessageBox
    /// </summary>
    public partial class MessageBox : VisiWin.Controls.View, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\..\..\..\..\Main\Regions\MessageBoxRegion\Views\MessageBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border border;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\..\..\..\Main\Regions\MessageBoxRegion\Views\MessageBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.TextBlock HeaderText;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\..\..\..\Main\Regions\MessageBoxRegion\Views\MessageBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MessageArea;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\..\..\..\Main\Regions\MessageBoxRegion\Views\MessageBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.SymbolPresenter MessageIcon;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\..\..\..\Main\Regions\MessageBoxRegion\Views\MessageBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.TextBlock MessageText;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\..\..\..\Main\Regions\MessageBoxRegion\Views\MessageBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.Button LeftButton;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\..\..\..\Main\Regions\MessageBoxRegion\Views\MessageBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.Button MiddleButton;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\..\..\..\Main\Regions\MessageBoxRegion\Views\MessageBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.Button RightButton;
        
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
            System.Uri resourceLocater = new System.Uri("/227799-EOT;component/main/regions/messageboxregion/views/messagebox.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\..\Main\Regions\MessageBoxRegion\Views\MessageBox.xaml"
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
            this.border = ((System.Windows.Controls.Border)(target));
            
            #line 8 "..\..\..\..\..\..\..\Main\Regions\MessageBoxRegion\Views\MessageBox.xaml"
            this.border.Loaded += new System.Windows.RoutedEventHandler(this.Border_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.HeaderText = ((VisiWin.Controls.TextBlock)(target));
            return;
            case 3:
            this.MessageArea = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.MessageIcon = ((VisiWin.Controls.SymbolPresenter)(target));
            return;
            case 5:
            this.MessageText = ((VisiWin.Controls.TextBlock)(target));
            return;
            case 6:
            this.LeftButton = ((VisiWin.Controls.Button)(target));
            return;
            case 7:
            this.MiddleButton = ((VisiWin.Controls.Button)(target));
            return;
            case 8:
            this.RightButton = ((VisiWin.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
