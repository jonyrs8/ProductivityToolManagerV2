﻿#pragma checksum "..\..\..\ChartsUC\PieChartsUC.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E140C2070341C82412CD27112ADB152C2C75BB2226230CBBBA4C846796F66B4B"
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
using UserInterface.ChartsUC;


namespace UserInterface.ChartsUC {
    
    
    /// <summary>
    /// PieChartsUC
    /// </summary>
    public partial class PieChartsUC : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\ChartsUC\PieChartsUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox filterComboBox;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\ChartsUC\PieChartsUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label topDepartmentLabel;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\ChartsUC\PieChartsUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LiveCharts.Wpf.PieChart ChartUC;
        
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
            System.Uri resourceLocater = new System.Uri("/UserInterface;component/chartsuc/piechartsuc.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ChartsUC\PieChartsUC.xaml"
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
            this.filterComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 19 "..\..\..\ChartsUC\PieChartsUC.xaml"
            this.filterComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ViewType_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.topDepartmentLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.ChartUC = ((LiveCharts.Wpf.PieChart)(target));
            
            #line 35 "..\..\..\ChartsUC\PieChartsUC.xaml"
            this.ChartUC.DataClick += new LiveCharts.Events.DataClickHandler(this.Chart_OnDataClick);
            
            #line default
            #line hidden
            
            #line 43 "..\..\..\ChartsUC\PieChartsUC.xaml"
            this.ChartUC.Loaded += new System.Windows.RoutedEventHandler(this.ChartUC_Loaded);
            
            #line default
            #line hidden
            
            #line 44 "..\..\..\ChartsUC\PieChartsUC.xaml"
            this.ChartUC.Unloaded += new System.Windows.RoutedEventHandler(this.ChartUC_Unloaded);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

