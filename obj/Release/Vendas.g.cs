﻿#pragma checksum "..\..\Vendas.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8DF1B70B0D9CA7D10CA61FD022AD1CDED50092D04C86C968053DD8B756EBF037"
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
    /// Vendas
    /// </summary>
    public partial class Vendas : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\Vendas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbProduto;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Vendas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbCliente;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\Vendas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtQuantidade;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\Vendas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtValorUnitario;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\Vendas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPreço;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\Vendas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbUnidade;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\Vendas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbpagamento;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\Vendas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtObservacao;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\Vendas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label thora;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\Vendas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label tdata;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\Vendas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label tdata1;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\Vendas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tdata3;
        
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
            System.Uri resourceLocater = new System.Uri("/Sistema;component/vendas.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Vendas.xaml"
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
            
            #line 8 "..\..\Vendas.xaml"
            ((Sistema.Vendas)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cbProduto = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.cbCliente = ((System.Windows.Controls.ComboBox)(target));
            
            #line 32 "..\..\Vendas.xaml"
            this.cbCliente.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbCliente_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtQuantidade = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\Vendas.xaml"
            this.txtQuantidade.LostFocus += new System.Windows.RoutedEventHandler(this.TxtQuantidade_LostFocus_1);
            
            #line default
            #line hidden
            
            #line 33 "..\..\Vendas.xaml"
            this.txtQuantidade.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtQuantidade_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtValorUnitario = ((System.Windows.Controls.TextBox)(target));
            
            #line 35 "..\..\Vendas.xaml"
            this.txtValorUnitario.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtValorUnitario_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtPreço = ((System.Windows.Controls.TextBox)(target));
            
            #line 36 "..\..\Vendas.xaml"
            this.txtPreço.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtPreço_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 38 "..\..\Vendas.xaml"
            ((System.Windows.Controls.Image)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Voltar4_MouseDown);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 39 "..\..\Vendas.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Comprar_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.cbUnidade = ((System.Windows.Controls.ComboBox)(target));
            
            #line 41 "..\..\Vendas.xaml"
            this.cbUnidade.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbunidade_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.cbpagamento = ((System.Windows.Controls.ComboBox)(target));
            
            #line 45 "..\..\Vendas.xaml"
            this.cbpagamento.Loaded += new System.Windows.RoutedEventHandler(this.cbpagamento_Loaded);
            
            #line default
            #line hidden
            return;
            case 11:
            this.txtObservacao = ((System.Windows.Controls.TextBox)(target));
            
            #line 47 "..\..\Vendas.xaml"
            this.txtObservacao.LostFocus += new System.Windows.RoutedEventHandler(this.TxtQuantidade_LostFocus_1);
            
            #line default
            #line hidden
            
            #line 47 "..\..\Vendas.xaml"
            this.txtObservacao.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtQuantidade_TextChanged);
            
            #line default
            #line hidden
            return;
            case 12:
            this.thora = ((System.Windows.Controls.Label)(target));
            return;
            case 13:
            this.tdata = ((System.Windows.Controls.Label)(target));
            return;
            case 14:
            this.tdata1 = ((System.Windows.Controls.Label)(target));
            return;
            case 15:
            this.tdata3 = ((System.Windows.Controls.TextBox)(target));
            
            #line 51 "..\..\Vendas.xaml"
            this.tdata3.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tdata3_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

