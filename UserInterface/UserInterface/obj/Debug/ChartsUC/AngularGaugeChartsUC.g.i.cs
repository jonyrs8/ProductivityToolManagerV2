﻿#pragma checksum "..\..\..\ChartsUC\AngularGaugeChartsUC.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AE31DAE3A0E0444FB4C209B6857B35A0F9295C54BDAC3F73810EC4EB411B74C9"
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
    /// AngularGaugeChartsUC
    /// </summary>
    public partial class AngularGaugeChartsUC : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\ChartsUC\AngularGaugeChartsUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboYearObjectives;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\ChartsUC\AngularGaugeChartsUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LiveCharts.Wpf.AngularGauge angularGauge;
        
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
            System.Uri resourceLocater = new System.Uri("/UserInterface;component/chartsuc/angulargaugechartsuc.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ChartsUC\AngularGaugeChartsUC.xaml"
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
            this.comboYearObjectives = ((System.Windows.Controls.ComboBox)(target));
            
            #line 17 "..\..\..\ChartsUC\AngularGaugeChartsUC.xaml"
            this.comboYearObjectives.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comboYearObjectives_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.angularGauge = ((LiveCharts.Wpf.AngularGauge)(target));
            
            #line 21 "..\..\..\ChartsUC\AngularGaugeChartsUC.xaml"
            this.angularGauge.Loaded += new System.Windows.RoutedEventHandler(this.angularGauge_Loaded);
            
            #line default
            #line hidden
            
            #line 22 "..\..\..\ChartsUC\AngularGaugeChartsUC.xaml"
            this.angularGauge.Unloaded += new System.Windows.RoutedEventHandler(this.angularGauge_Unloaded);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
