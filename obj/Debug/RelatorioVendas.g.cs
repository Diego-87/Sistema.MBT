﻿#pragma checksum "..\..\RelatorioVendas.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "86D5191E71EADB038D72B4EFB217A6F900D44220427CD3DD64DBBCCE93F0B285"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using Sistema;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Sistema {
    
    
    /// <summary>
    /// RelatorioVendas
    /// </summary>
    public partial class RelatorioVendas : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\RelatorioVendas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridVendas;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\RelatorioVendas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label tdata;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\RelatorioVendas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dtpInicio;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\RelatorioVendas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dtpFim;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\RelatorioVendas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tpesquisa;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\RelatorioVendas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tvaltot;
        
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
            System.Uri resourceLocater = new System.Uri("/Sistema;component/relatoriovendas.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\RelatorioVendas.xaml"
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
            
            #line 8 "..\..\RelatorioVendas.xaml"
            ((Sistema.RelatorioVendas)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dataGridVendas = ((System.Windows.Controls.DataGrid)(target));
            
            #line 10 "..\..\RelatorioVendas.xaml"
            this.dataGridVendas.Initialized += new System.EventHandler(this.DataGridVendas_Initialized);
            
            #line default
            #line hidden
            
            #line 10 "..\..\RelatorioVendas.xaml"
            this.dataGridVendas.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dataGridVendas_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 31 "..\..\RelatorioVendas.xaml"
            ((System.Windows.Controls.Image)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Voltar_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tdata = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.dtpInicio = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.dtpFim = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            
            #line 38 "..\..\RelatorioVendas.xaml"
            ((System.Windows.Controls.Label)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.PESQUISAR_MouseDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.tpesquisa = ((System.Windows.Controls.TextBox)(target));
            
            #line 40 "..\..\RelatorioVendas.xaml"
            this.tpesquisa.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tpesquisa_TextChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 41 "..\..\RelatorioVendas.xaml"
            ((System.Windows.Controls.Label)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.totalvendas_MouseDown);
            
            #line default
            #line hidden
            return;
            case 10:
            this.tvaltot = ((System.Windows.Controls.TextBox)(target));
            
            #line 42 "..\..\RelatorioVendas.xaml"
            this.tvaltot.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.totalvendas_TextChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 43 "..\..\RelatorioVendas.xaml"
            ((System.Windows.Controls.Image)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Image_MouseDown_2);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

