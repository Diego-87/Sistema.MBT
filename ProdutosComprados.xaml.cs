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
    /// Lógica interna para ProdutosComprados.xaml
    /// </summary>
    public partial class ProdutosComprados : Window
    {
        public ProdutosComprados()
        {
            InitializeComponent();
        }

        private void tnomeproduto_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btpesquisa_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = "SERVER=127.0.0.1;port=3306;USER ID=root;DATABASE=bd_sistema;PASSWORD=;";

                MySqlCommand dcm = new MySqlCommand();
                dcm.Connection = conn;

                MySqlCommand SELECT = new MySqlCommand("SELECT descricao,unidade,valor_unitario,quantidade,total,data  FROM tb_compras WHERE descricao LIKE '%" + tnomeproduto.Text + "%'", conn);
                SELECT.Parameters.AddWithValue("@descricao", tnomeproduto.Text);

                MySqlDataAdapter adp = new MySqlDataAdapter(SELECT);
                DataSet dataSet = new DataSet();
                adp.Fill(dataSet, "Load");
                dataGridProdutoCompras.DataContext = dataSet;
            }
            catch
            {
                MessageBox.Show("ERROR!!!!");
            }

        }

        private void BtIr_Click(object sender, RoutedEventArgs e)
        {
            CarregarPeriodoData();
        }

        private void dataGridProdutoCompras_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        public void CarregarPeriodoData()
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "SERVER=127.0.0.1;port=3306;USER ID=root;DATABASE=bd_sistema;PASSWORD=;";

            MySqlCommand dcm = new MySqlCommand();
            dcm.Connection = conn;

            MySqlCommand SELECT = new MySqlCommand("SELECT descricao,unidade, SUM(quantidade) as 'quantidade',SUM(total) as 'total_compras' FROM tb_compras  WHERE data BETWEEN @inicio and @fim group by descricao", conn);
            SELECT.Parameters.AddWithValue("@inicio", tdatInicio);
            SELECT.Parameters.AddWithValue("@fim", tdatFim);
            MySqlDataAdapter adp = new MySqlDataAdapter(SELECT);
            DataSet dataSet = new DataSet();
            adp.Fill(dataSet, "Load");
            dataGridProdutoCompras.DataContext = dataSet;

        }

        private void DataGridProdutoCompras_Initialized(object sender, EventArgs e)
        {

        }

        private void Voltar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DashBoard dashBoard = new DashBoard();
            dashBoard.Show();
            Close();
        }
    }
}
