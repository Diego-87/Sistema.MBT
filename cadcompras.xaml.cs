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
    /// Lógica interna para cadcompras.xaml
    /// </summary>
    public partial class cadcompras : Window
    {
        public cadcompras()
        {
            InitializeComponent();
        }

        public void carregar()
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "SERVER=127.0.0.1;port=3306;USER ID=root;DATABASE=bd_sistema;PASSWORD=;";

            MySqlCommand dcm = new MySqlCommand();
            dcm.Connection = conn;

            MySqlCommand SELECT = new MySqlCommand("SELECT * FROM tb_compras", conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(SELECT);
            DataSet dataSet = new DataSet();
            adp.Fill(dataSet, "Load");
            DtgridCompras.DataContext = dataSet;
        }
        
       
        private void DtgridCompras_Initialized_1(object sender, EventArgs e)
        {
            carregar();
        }

        private void voltar2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Compras compras = new Compras();
            compras.Show();
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            tdata.Content = DateTime.Now.ToString("dd/MM/yyyy");
            
        }
    }
}
