﻿#pragma checksum "..\..\PanelVisitante.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F33ADBE3965F209D60CF54700B4C607EBDF2525DC06483EBD0AA63BE0802D7B3"
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
using proyectUniversidad;


namespace proyectUniversidad {
    
    
    /// <summary>
    /// PanelVisitante
    /// </summary>
    public partial class PanelVisitante : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\PanelVisitante.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBoxDptos;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\PanelVisitante.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridCarreras;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\PanelVisitante.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBoxCarreras;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\PanelVisitante.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridMaterias;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\PanelVisitante.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBoxMaterias;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\PanelVisitante.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridOpcion;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\PanelVisitante.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnInscribirse;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\PanelVisitante.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSalir;
        
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
            System.Uri resourceLocater = new System.Uri("/proyectUniversidad;component/panelvisitante.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PanelVisitante.xaml"
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
            this.comboBoxDptos = ((System.Windows.Controls.ComboBox)(target));
            
            #line 20 "..\..\PanelVisitante.xaml"
            this.comboBoxDptos.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comboBoxDptos_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.gridCarreras = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.comboBoxCarreras = ((System.Windows.Controls.ComboBox)(target));
            
            #line 33 "..\..\PanelVisitante.xaml"
            this.comboBoxCarreras.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comboBoxCarreras_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.gridMaterias = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.comboBoxMaterias = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.gridOpcion = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            this.btnInscribirse = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\PanelVisitante.xaml"
            this.btnInscribirse.Click += new System.Windows.RoutedEventHandler(this.btnInscribirse_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnSalir = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\PanelVisitante.xaml"
            this.btnSalir.Click += new System.Windows.RoutedEventHandler(this.btnSalir_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

