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
using MySql.Data.MySqlClient;
using System.Data;

namespace Sistema
{
    /// <summary>
    /// Lógica interna para relatoriosVendas.xaml
    /// </summary>
    public partial class RelatorioVendas : System.Windows.Window
    {
        public RelatorioVendas()
        {
            InitializeComponent();
        }
        public void carregar()
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "SERVER=127.0.0.1;port=3306;USER ID=root;DATABASE=bd_sistema;PASSWORD=;";

            MySqlCommand dcm = new MySqlCommand();
            dcm.Connection = conn;

            MySqlCommand SELECT = new MySqlCommand("SELECT nome_cliente,nome_produto,unidade,data,valorunitario,quantidade,preco,pagamento,observacao, (quantidade*valorunitario) as total_vendas from tb_vendas WHERE data BETWEEN @inicio and @fim order by data", conn);
            SELECT.Parameters.AddWithValue("@inicio", dtpInicio);
            SELECT.Parameters.AddWithValue("@fim", dtpFim);
            MySqlDataAdapter adp = new MySqlDataAdapter(SELECT);
            DataSet dataSet = new DataSet();
            adp.Fill(dataSet, "Load");
            dataGridVendas.DataContext = dataSet;
        }

        public void CarregarPesquisa()
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "SERVER=127.0.0.1;port=3306;USER ID=root;DATABASE=bd_sistema;PASSWORD=;";

            MySqlCommand dcm = new MySqlCommand();
            dcm.Connection = conn;

            MySqlCommand SELECT = new MySqlCommand("SELECT  nome_cliente,nome_produto,unidade,data,valorunitario,quantidade,preco,pagamento,observacao  FROM tb_vendas  WHERE nome_cliente LIKE '%" + tpesquisa.Text + "%'", conn);
            SELECT.Parameters.AddWithValue("@pesquisa", tpesquisa.Text);

            MySqlDataAdapter adp = new MySqlDataAdapter(SELECT);
            DataSet dataSet = new DataSet();
            adp.Fill(dataSet, "Load");
            dataGridVendas.DataContext = dataSet;
        }


        private void DataGridVendas_Initialized(object sender, EventArgs e)
        {
            
        }



        private void Voltar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DashBoard dashBoard = new DashBoard();
            dashBoard.Show();
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            tdata.Content = DateTime.Now.ToString("dd/MM/yyyy");

        }

        private void Window_Initialized(object sender, EventArgs e)
        {

        }

        private void dataGridVendas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void PESQUISAR_MouseDown(object sender, MouseButtonEventArgs e)
        {
            carregar();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
           
        }

        private void tpesquisa_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void totalvendas_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
           
        }

        private void totalvendas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "SERVER=127.0.0.1;port=3306;USER ID=root;DATABASE=bd_sistema;PASSWORD=;";

            MySqlCommand dcm = new MySqlCommand();
            dcm.Connection = conn;

            MySqlCommand SELECT = new MySqlCommand("SELECT  nome_cliente, SUM(preco) AS total_vendas FROM tb_vendas  WHERE nome_cliente LIKE '%" + tvaltot.Text + "%'", conn);
            SELECT.Parameters.AddWithValue("@valtot", tvaltot.Text);

            MySqlDataAdapter adp = new MySqlDataAdapter(SELECT);
            DataSet dataSet = new DataSet();
            adp.Fill(dataSet, "Load");
            dataGridVendas.DataContext = dataSet;
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Image_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            CarregarPesquisa();
        }

        private void tvaltot_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
