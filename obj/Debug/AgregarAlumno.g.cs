﻿#pragma checksum "..\..\AgregarAlumno.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3A30E55E724543A8A0A457755E4B49DD47184296A8FF862D2D9232F4D625A48A"
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
    /// AgregarAlumno
    /// </summary>
    public partial class AgregarAlumno : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\AgregarAlumno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBoxGenero;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\AgregarAlumno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker fechaNacimientoCalendario;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\AgregarAlumno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAgregarAlumno;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\AgregarAlumno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancelarAlumno;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\AgregarAlumno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNombreAlumno;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\AgregarAlumno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtApellidoAlumno;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\AgregarAlumno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDniAlumno;
        
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
            System.Uri resourceLocater = new System.Uri("/proyectUniversidad;component/agregaralumno.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AgregarAlumno.xaml"
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
            this.comboBoxGenero = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.fechaNacimientoCalendario = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 3:
            this.btnAgregarAlumno = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\AgregarAlumno.xaml"
            this.btnAgregarAlumno.Click += new System.Windows.RoutedEventHandler(this.btnAgregarAlumno_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnCancelarAlumno = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\AgregarAlumno.xaml"
            this.btnCancelarAlumno.Click += new System.Windows.RoutedEventHandler(this.btnCancelarAlumno_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtNombreAlumno = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtApellidoAlumno = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtDniAlumno = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

