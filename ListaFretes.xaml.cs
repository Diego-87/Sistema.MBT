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
    public partial class Frete : System.Windows.Window
    {
        public  Frete()
        {
            InitializeComponent();
            
        }
        public void carregar()
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "SERVER=127.0.0.1;port=3306;USER ID=root;DATABASE=bd_sistema;PASSWORD=;";

            MySqlCommand dcm = new MySqlCommand();
            dcm.Connection = conn;

            MySqlCommand SELECT = new MySqlCommand("SELECT * FROM tb_frete WHERE data BETWEEN @inicio and @fim  order by data", conn);
            SELECT.Parameters.AddWithValue("@inicio", dtpInicio);
            SELECT.Parameters.AddWithValue("@fim", dtpFim);
            MySqlDataAdapter adp = new MySqlDataAdapter(SELECT);
            DataSet dataSet = new DataSet();
            adp.Fill(dataSet, "Load");
            dataGridFretes.DataContext = dataSet;
        }
        private void voltar2_MouseDown(object sender, MouseButtonEventArgs e)
   {
            frete frete = new frete();
            frete.Show();
            Close();
        }

        private void dataGridFretes_Initialized(object sender, EventArgs e)
        {
            carregar();
        }

        private void dataGridFretes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        { 

            tdata.Content = DateTime.Now.ToString("dd/MM/yyyy");
            thora.Content = DateTime.Now.ToString("HH:mm:yyyy");
        }

        private void PESQUISAR_MouseDown(object sender, MouseButtonEventArgs e)
        {
            carregar();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            CarregarPesquisa();
        }

        public void CarregarPesquisa()
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "SERVER=127.0.0.1;port=3306;USER ID=root;DATABASE=bd_sistema;PASSWORD=;";

            MySqlCommand dcm = new MySqlCommand();
            dcm.Connection = conn;

            MySqlCommand SELECT = new MySqlCommand("SELECT cod, produto,unidade,quantidade,data,cliente,municipio,valor,valor_total,local_entrega,observacao FROM tb_frete  WHERE cliente LIKE '%" + tpesquisa.Text + "%'", conn);
            SELECT.Parameters.AddWithValue("@pesquisa", tpesquisa.Text);

            MySqlDataAdapter adp = new MySqlDataAdapter(SELECT);
            DataSet dataSet = new DataSet();
            adp.Fill(dataSet, "Load");
            dataGridFretes.DataContext = dataSet;
        }

        private void totalvendas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "SERVER=127.0.0.1;port=3306;USER ID=root;DATABASE=bd_sistema;PASSWORD=;";

            MySqlCommand dcm = new MySqlCommand();
            dcm.Connection = conn;

            MySqlCommand SELECT = new MySqlCommand("SELECT  cliente, SUM(valor_total) AS total_fretes FROM tb_frete  WHERE cliente LIKE '%" + tvaltot.Text + "%'", conn);
            SELECT.Parameters.AddWithValue("@tvaltot", tvaltot.Text);

            MySqlDataAdapter adp = new MySqlDataAdapter(SELECT);
            DataSet dataSet = new DataSet();
            adp.Fill(dataSet, "Load");
            dataGridFretes.DataContext = dataSet;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
