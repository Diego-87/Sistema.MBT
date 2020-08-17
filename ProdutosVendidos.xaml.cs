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
using System.Data;
using MySql.Data.MySqlClient;

namespace Sistema
{
    /// <summary>
    /// Lógica interna para ProdutosVendidos.xaml
    /// </summary>
    public partial class ProdutosVendidos : Window
    {
        public ProdutosVendidos()
        {
            InitializeComponent();
        }

        private void dataGridProdutoVendas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnpesquisa_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = "SERVER=127.0.0.1;port=3306;USER ID=root;DATABASE=bd_sistema;PASSWORD=;";

                MySqlCommand dcm = new MySqlCommand();
                dcm.Connection = conn;

                MySqlCommand SELECT = new MySqlCommand("SELECT nome_produto,unidade,valorunitario,quantidade,preco,data  FROM tb_vendas WHERE nome_produto LIKE '%" + txtnomeproduto.Text + "%'" , conn);
                SELECT.Parameters.AddWithValue("@nome_produto", txtnomeproduto.Text);

                MySqlDataAdapter adp = new MySqlDataAdapter(SELECT);
                DataSet dataSet = new DataSet();
                adp.Fill(dataSet, "Load");
                dataGridProdutoVendas.DataContext = dataSet;
            }
            catch
            {
                MessageBox.Show("ERROR!!!!");
            }
           
        }

        public void CarregarPeriodoData()
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "SERVER=127.0.0.1;port=3306;USER ID=root;DATABASE=bd_sistema;PASSWORD=;";

            MySqlCommand dcm = new MySqlCommand();
            dcm.Connection = conn;

            MySqlCommand SELECT = new MySqlCommand("SELECT nome_produto,unidade, SUM(quantidade) as 'quantidade',SUM(preco) as 'total_vendas' FROM tb_vendas  WHERE data BETWEEN @inicio and @fim group by nome_produto ", conn);
            SELECT.Parameters.AddWithValue("@inicio", txtdatInicio);
            SELECT.Parameters.AddWithValue("@fim", txtdatFim);
            MySqlDataAdapter adp = new MySqlDataAdapter(SELECT);
            DataSet dataSet = new DataSet();
            adp.Fill(dataSet, "Load");
            dataGridProdutoVendas.DataContext = dataSet;

        }

        private void DataGridProdutoVendas_Initialized(object sender, EventArgs e)
        {

        }

        private void BtnIr_Click(object sender, RoutedEventArgs e)
        {
            CarregarPeriodoData();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DashBoard dashBoard = new DashBoard();
            dashBoard.Show();
            Close();
        }
    }

  
    }

