﻿#pragma checksum "..\..\..\..\..\..\..\Main\Regions\Main\Recipes\Recipes_PN.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "273997DDCA4EAAA3D1F5198AADF3C9CB3FCDECE52B616072ABC1995046CA4F2F"
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


namespace HMI.MainRegion.Recipes.Views {
    
    
    /// <summary>
    /// Recipes_PN
    /// </summary>
    public partial class Recipes_PN : VisiWin.Controls.View, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\..\..\..\Main\Regions\Main\Recipes\Recipes_PN.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.PanoramaNavigation pn_recipe;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\..\..\..\Main\Regions\Main\Recipes\Recipes_PN.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.TextBlock HeaderTxt;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\..\..\..\Main\Regions\Main\Recipes\Recipes_PN.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.TextVarOut Rname;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\..\..\..\Main\Regions\Main\Recipes\Recipes_PN.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.TextVarOut Descr;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\..\..\..\Main\Regions\Main\Recipes\Recipes_PN.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.Button aaa;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\..\..\..\Main\Regions\Main\Recipes\Recipes_PN.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid wait;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\..\..\..\Main\Regions\Main\Recipes\Recipes_PN.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image gif;
        
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
            System.Uri resourceLocater = new System.Uri("/227799-EOT;component/main/regions/main/recipes/recipes_pn.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\..\Main\Regions\Main\Recipes\Recipes_PN.xaml"
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
            this.pn_recipe = ((VisiWin.Controls.PanoramaNavigation)(target));
            return;
            case 2:
            this.HeaderTxt = ((VisiWin.Controls.TextBlock)(target));
            return;
            case 3:
            this.Rname = ((VisiWin.Controls.TextVarOut)(target));
            return;
            case 4:
            this.Descr = ((VisiWin.Controls.TextVarOut)(target));
            return;
            case 5:
            this.aaa = ((VisiWin.Controls.Button)(target));
            return;
            case 6:
            this.wait = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            this.gif = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

