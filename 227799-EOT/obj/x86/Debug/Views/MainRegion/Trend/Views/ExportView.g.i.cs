﻿#pragma checksum "..\..\..\..\..\..\..\Views\MainRegion\Trend\Views\ExportView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8C331CA203966D024F93BD06DCE0366A14A52321E5EE63CCB3DE0DD804342947"
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


namespace HMI.Views.MainRegion {
    
    
    /// <summary>
    /// ExportView
    /// </summary>
    public partial class ExportView : VisiWin.Controls.View, System.Windows.Markup.IComponentConnector {
        
        
        #line 2 "..\..\..\..\..\..\..\Views\MainRegion\Trend\Views\ExportView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HMI.Views.MainRegion.ExportView exportView_View;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\..\..\..\..\..\Views\MainRegion\Trend\Views\ExportView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LayoutRoot;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\..\..\..\..\Views\MainRegion\Trend\Views\ExportView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.DateTimeVarIn dateTimeVarInStarttime;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\..\..\..\..\Views\MainRegion\Trend\Views\ExportView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.DateTimeVarIn dateTimeVarInStoptime;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\..\..\..\Views\MainRegion\Trend\Views\ExportView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.Button buttonStartExportToFile;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\..\..\..\Views\MainRegion\Trend\Views\ExportView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.NumericVarIn numericVarInTimeSpanSeconds;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\..\..\..\Views\MainRegion\Trend\Views\ExportView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar progressBar;
        
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
            System.Uri resourceLocater = new System.Uri("/227799-EOT;component/views/mainregion/trend/views/exportview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\..\Views\MainRegion\Trend\Views\ExportView.xaml"
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
            this.exportView_View = ((HMI.Views.MainRegion.ExportView)(target));
            
            #line 7 "..\..\..\..\..\..\..\Views\MainRegion\Trend\Views\ExportView.xaml"
            this.exportView_View.IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.ExportView_View_IsVisibleChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LayoutRoot = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.dateTimeVarInStarttime = ((VisiWin.Controls.DateTimeVarIn)(target));
            return;
            case 4:
            this.dateTimeVarInStoptime = ((VisiWin.Controls.DateTimeVarIn)(target));
            return;
            case 5:
            this.buttonStartExportToFile = ((VisiWin.Controls.Button)(target));
            return;
            case 6:
            this.numericVarInTimeSpanSeconds = ((VisiWin.Controls.NumericVarIn)(target));
            return;
            case 7:
            this.progressBar = ((System.Windows.Controls.ProgressBar)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

