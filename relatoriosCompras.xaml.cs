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
using System.Globalization;
using System.Data.SqlClient;
using System.Activities;

namespace Sistema
{
    /// <summary>
    /// Lógica interna para relatoriosCompras.xaml
    /// </summary>
    public partial class relatoriosCompras : System.Windows.Window
    {
        
            

        

        public relatoriosCompras()
        {
            InitializeComponent();
            


        }

        public void carregar()
        {

            

            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "SERVER=127.0.0.1;port=3306;USER ID=root;DATABASE=bd_sistema;PASSWORD=;";

            MySqlCommand dcm = new MySqlCommand();
            dcm.Connection = conn;


          

                MySqlCommand SELECT = new MySqlCommand("SELECT * from  tb_compras WHERE data between @inicio and @fim order by data ", conn);
                SELECT.Parameters.AddWithValue("@inicio", dtpInicio);
                SELECT.Parameters.AddWithValue("@fim", dtpFim);
                MySqlDataAdapter adp = new MySqlDataAdapter(SELECT);
                DataSet dataSet = new DataSet();
                adp.Fill(dataSet, "Load");
                dataGridCompras.DataContext = dataSet;

            


        }
        public void CarregarPesquisa()
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "SERVER=127.0.0.1;port=3306;USER ID=root;DATABASE=bd_sistema;PASSWORD=;";

            MySqlCommand dcm = new MySqlCommand();
            dcm.Connection = conn;
   
            MySqlCommand SELECT = new MySqlCommand("SELECT  cod,descricao,data,fornecedor,unidade,valor_unitario,quantidade,total  FROM tb_compras  WHERE fornecedor LIKE '%" + tpesquisa.Text+"%'" , conn);
            SELECT.Parameters.AddWithValue("@pesquisa", tpesquisa.Text);

            MySqlDataAdapter adp = new MySqlDataAdapter(SELECT);
            DataSet dataSet = new DataSet();
            adp.Fill(dataSet, "Load");
            dataGridCompras.DataContext = dataSet;
        }

        public void Pesquisa()

        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "SERVER=127.0.0.1;port=3306;USER ID=root;DATABASE=bd_sistema;PASSWORD=;";

            MySqlCommand dcm = new MySqlCommand();
            dcm.Connection = conn;

            MySqlCommand SELECT = new MySqlCommand("SELECT * FROM " +
                " ", conn);
           // SELECT.Parameters.AddWithValue("@inicio", dtpInicio);
             SELECT.Parameters.AddWithValue("@fim", dtpFim);
            MySqlDataAdapter adp = new MySqlDataAdapter(SELECT);
            DataSet dataSet = new DataSet();
            adp.Fill(dataSet, "Load");
            dataGridCompras.DataContext = dataSet;

        }


            private void DataGridCompras_Initialized(object sender, EventArgs e)
        {
            
            
        }
        

       private void voltar3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DashBoard dashBoard = new DashBoard();
            dashBoard.Show();
            Close();
        }

        private void dataGridCompras_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

       // private void Window_Loaded(object sender, RoutedEventArgs e)
       // {

       //     tdata.Content = DateTime.Now.ToString("dd/MM/yyyy");
           
        //}

        private void PESQUISAR_MouseDown(object sender, MouseButtonEventArgs e)
        {
            carregar();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            CarregarPesquisa();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void totalvendas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "SERVER=127.0.0.1;port=3306;USER ID=root;DATABASE=bd_sistema;PASSWORD=;";

            MySqlCommand dcm = new MySqlCommand();
            dcm.Connection = conn;

            MySqlCommand SELECT = new MySqlCommand("SELECT  fornecedor, SUM(total) AS total_compras FROM tb_compras  WHERE fornecedor LIKE '%" + tvaltot.Text + "%'", conn);
            SELECT.Parameters.AddWithValue("@tvaltot", tvaltot.Text);

            MySqlDataAdapter adp = new MySqlDataAdapter(SELECT);
            DataSet dataSet = new DataSet();
            adp.Fill(dataSet, "Load");
            dataGridCompras.DataContext = dataSet;
        }

        private void dtpFim_Initialized(object sender, EventArgs e)
        {
            dtpFim.IsEnabled = true;
        }

        private void dtpInicio_Initialized(object sender, EventArgs e)
        {
            dtpInicio.IsEnabled = true;
        }
    }
           
            }
        
    

