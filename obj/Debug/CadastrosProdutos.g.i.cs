// Updated by XamlIntelliSenseFileGenerator 17/01/2020 22:03:44
#pragma checksum "..\..\CadastrosProdutos.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1DA4DC0117F85662D1403936E37A85B7C98BF9DB34EABBD5ED6FA8D113CD1CF1"
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


namespace Sistema
{


    /// <summary>
    /// CadastrosProdutos
    /// </summary>
    public partial class CadastrarProdutos : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 27 "..\..\CadastrosProdutos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label tdescricao1;

#line default
#line hidden


#line 28 "..\..\CadastrosProdutos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tvalunitario;

#line default
#line hidden


#line 31 "..\..\CadastrosProdutos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tquantidade;

#line default
#line hidden


#line 34 "..\..\CadastrosProdutos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tdescricao2;

#line default
#line hidden


#line 35 "..\..\CadastrosProdutos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tvaltotal;

#line default
#line hidden


#line 44 "..\..\CadastrosProdutos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DtgridProdutos;

#line default
#line hidden


#line 68 "..\..\CadastrosProdutos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tunidade;

#line default
#line hidden


#line 69 "..\..\CadastrosProdutos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tkilo;

#line default
#line hidden


#line 70 "..\..\CadastrosProdutos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tpacote;

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
            System.Uri resourceLocater = new System.Uri("/Sistema;component/cadastrosprodutos.xaml", System.UriKind.Relative);

#line 1 "..\..\CadastrosProdutos.xaml"
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

#line 15 "..\..\CadastrosProdutos.xaml"
                    ((System.Windows.Controls.Grid)(target)).Initialized += new System.EventHandler(this.Grid_Initialized);

#line default
#line hidden
                    return;
                case 2:
                    this.tdescricao1 = ((System.Windows.Controls.Label)(target));
                    return;
                case 3:
                    this.tvalunitario = ((System.Windows.Controls.TextBox)(target));

#line 28 "..\..\CadastrosProdutos.xaml"
                    this.tvalunitario.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Tvalunitario_TextChanged);

#line default
#line hidden
                    return;
                case 4:
                    this.tquantidade = ((System.Windows.Controls.TextBox)(target));

#line 31 "..\..\CadastrosProdutos.xaml"
                    this.tquantidade.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Tquantidade_TextChanged);

#line default
#line hidden
                    return;
                case 5:

#line 32 "..\..\CadastrosProdutos.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.total_Click);

#line default
#line hidden
                    return;
                case 6:
                    this.tdescricao2 = ((System.Windows.Controls.TextBox)(target));

#line 34 "..\..\CadastrosProdutos.xaml"
                    this.tdescricao2.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Tdescricao_TextChanged);

#line default
#line hidden
                    return;
                case 7:
                    this.tvaltotal = ((System.Windows.Controls.TextBox)(target));

#line 35 "..\..\CadastrosProdutos.xaml"
                    this.tvaltotal.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Tvaltotal_TextChanged_1);

#line default
#line hidden
                    return;
                case 8:

#line 37 "..\..\CadastrosProdutos.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Cadastrar_Click);

#line default
#line hidden
                    return;
                case 9:

#line 39 "..\..\CadastrosProdutos.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Alterar_Click_1);

#line default
#line hidden
                    return;
                case 10:

#line 41 "..\..\CadastrosProdutos.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Excluir_Click_1);

#line default
#line hidden
                    return;
                case 11:
                    this.DtgridProdutos = ((System.Windows.Controls.DataGrid)(target));

#line 44 "..\..\CadastrosProdutos.xaml"
                    this.DtgridProdutos.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DtgridProdutos_SelectionChanged);

#line default
#line hidden

#line 44 "..\..\CadastrosProdutos.xaml"
                    this.DtgridProdutos.Initialized += new System.EventHandler(this.DtgridProdutos_Initialized);

#line default
#line hidden
                    return;
                case 12:
                    this.tcodigo = ((System.Windows.Controls.TextBox)(target));

#line 63 "..\..\CadastrosProdutos.xaml"
                    this.tcodigo.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Tcodigo_TextChanged);

#line default
#line hidden
                    return;
                case 13:

#line 64 "..\..\CadastrosProdutos.xaml"
                    ((System.Windows.Controls.Image)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Voltar_MouseDown);

#line default
#line hidden
                    return;
                case 14:
                    this.tunidade = ((System.Windows.Controls.TextBox)(target));

#line 68 "..\..\CadastrosProdutos.xaml"
                    this.tunidade.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Tunidade_TextChanged);

#line default
#line hidden
                    return;
                case 15:
                    this.tkilo = ((System.Windows.Controls.TextBox)(target));

#line 69 "..\..\CadastrosProdutos.xaml"
                    this.tkilo.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tkilo_TextChanged);

#line default
#line hidden
                    return;
                case 16:
                    this.tpacote = ((System.Windows.Controls.TextBox)(target));

#line 70 "..\..\CadastrosProdutos.xaml"
                    this.tpacote.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tpacote_TextChanged);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.TextBox tcaixa;
        internal System.Windows.Controls.TextBox tcod;
    }
}
