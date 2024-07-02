// Updated by XamlIntelliSenseFileGenerator 04/08/2021 16:11:20
#pragma checksum "..\..\..\..\..\..\Main\Regions\MessageBoxRegion\MessageBoxView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FEA8F98516BFFEC8495EB04974DF2F792ACF136E573DFCC0652E3FDB3C8DEF5E"
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


namespace HMI.Views.MessageBoxRegion
{


    /// <summary>
    /// MessageBoxView
    /// </summary>
    public partial class MessageBoxView : VisiWin.Controls.View, System.Windows.Markup.IComponentConnector
    {


#line 26 "..\..\..\..\..\..\Main\Regions\MessageBoxRegion\MessageBoxView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.TextBlock HeaderText;

#line default
#line hidden


#line 28 "..\..\..\..\..\..\Main\Regions\MessageBoxRegion\MessageBoxView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MessageArea;

#line default
#line hidden


#line 29 "..\..\..\..\..\..\Main\Regions\MessageBoxRegion\MessageBoxView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.SymbolPresenter MessageIcon;

#line default
#line hidden


#line 30 "..\..\..\..\..\..\Main\Regions\MessageBoxRegion\MessageBoxView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.TextBlock MessageText;

#line default
#line hidden


#line 33 "..\..\..\..\..\..\Main\Regions\MessageBoxRegion\MessageBoxView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.Button LeftButton;

#line default
#line hidden


#line 34 "..\..\..\..\..\..\Main\Regions\MessageBoxRegion\MessageBoxView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.Button MiddleButton;

#line default
#line hidden


#line 35 "..\..\..\..\..\..\Main\Regions\MessageBoxRegion\MessageBoxView.xaml"
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
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/227799-EOT;component/main/regions/messageboxregion/messageboxview.xaml", System.UriKind.Relative);

#line 1 "..\..\..\..\..\..\Main\Regions\MessageBoxRegion\MessageBoxView.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.HeaderText = ((VisiWin.Controls.TextBlock)(target));
                    return;
                case 2:
                    this.MessageArea = ((System.Windows.Controls.Grid)(target));
                    return;
                case 3:
                    this.MessageIcon = ((VisiWin.Controls.SymbolPresenter)(target));
                    return;
                case 4:
                    this.MessageText = ((VisiWin.Controls.TextBlock)(target));
                    return;
                case 5:
                    this.LeftButton = ((VisiWin.Controls.Button)(target));
                    return;
                case 6:
                    this.MiddleButton = ((VisiWin.Controls.Button)(target));
                    return;
                case 7:
                    this.RightButton = ((VisiWin.Controls.Button)(target));
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.Border border;
        internal VisiWin.Controls.Button CancelButton;
        internal System.Windows.Controls.Border LayoutRoot;
        internal VisiWin.Controls.Button aocb;
    }
}

