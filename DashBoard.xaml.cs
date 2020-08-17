using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Sistema
{
    /// <summary>
    /// Lógica interna para DashBoard.xaml
    /// </summary>
    public partial class DashBoard : System.Windows.Window
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void Cliente_MouseDown(object sender, MouseButtonEventArgs e)
        {
            CadastroCliente cadastroCliente = new CadastroCliente();
            cadastroCliente.Show();
            Close();
        }

       

        private void Produtos_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Produtos Produtos = new Produtos();
            Produtos.Show();
            Close();
        }

        private void Vendas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Vendas vendas = new Vendas();
            vendas.Show();
            Close();
        }

        private void relatoriovendas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            RelatorioVendas relatoriosVendas = new RelatorioVendas();
            relatoriosVendas.Show();
            Close();
        }

        private void Compras_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Compras compras = new Compras();
            compras.Show();
            Close();
        }

        private void fretes_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frete frete = new frete();
            frete.Show();
            Close();
        }

        private void relatoriosFretes_MouseDown(object sender, MouseButtonEventArgs e)
        {
            relatoriosCompras relatoriosCompras = new relatoriosCompras();
            relatoriosCompras.Show();
            Close();
        }

       

        private void fornecedores_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Fornecedores fornecedores = new Fornecedores();
            fornecedores.Show();
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            thora.Content = DateTime.Now.ToString("HH:mm:ss");
        }

       

        private void ProdutosVendidos_MouseDown(object sender, MouseButtonEventArgs e)
        {

            ProdutosVendidos produtosVendidos = new ProdutosVendidos();
            produtosVendidos.Show();
            Close();

        }

        private void ProdutosComprados_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ProdutosComprados produtosComprados = new ProdutosComprados();
            produtosComprados.Show();
            Close();
        }

        private void btSair_MouseDown(object sender, MouseButtonEventArgs e)
        {
               this.Close();
        }
    }
}
