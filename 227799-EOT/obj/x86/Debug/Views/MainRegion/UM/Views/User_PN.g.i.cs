// Updated by XamlIntelliSenseFileGenerator 26/07/2021 16:05:03
#pragma checksum "..\..\..\..\..\..\..\Views\MainRegion\UM\Views\User_PN.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9913B04A464C7450FFAB7A5720A2923FDB4BAFB559914EA42A2105149E93E5EA"
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


namespace HMI.UM.Views
{


    /// <summary>
    /// User_PN
    /// </summary>
    public partial class User_PN : VisiWin.Controls.View, System.Windows.Markup.IComponentConnector
    {


#line 7 "..\..\..\..\..\..\..\Views\MainRegion\UM\Views\User_PN.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LayoutRoot;

#line default
#line hidden


#line 12 "..\..\..\..\..\..\..\Views\MainRegion\UM\Views\User_PN.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.PanoramaNavigation pn_benutzerverwaltung;

#line default
#line hidden


#line 26 "..\..\..\..\..\..\..\Views\MainRegion\UM\Views\User_PN.xaml"
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
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/227799-EOT;component/views/mainregion/um/views/user_pn.xaml", System.UriKind.Relative);

#line 1 "..\..\..\..\..\..\..\Views\MainRegion\UM\Views\User_PN.xaml"
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
                    this.LayoutRoot = ((System.Windows.Controls.Grid)(target));
                    return;
                case 2:
                    this.pn_benutzerverwaltung = ((VisiWin.Controls.PanoramaNavigation)(target));

#line 12 "..\..\..\..\..\..\..\Views\MainRegion\UM\Views\User_PN.xaml"
                    this.pn_benutzerverwaltung.SelectedPanoramaRegionChanged += new System.EventHandler<VisiWin.Controls.SelectedPanoramaRegionChangedEventArgs>(this.Pn_benutzerverwaltung_SelectedPanoramaRegionChanged);

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

