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
    /// Lógica interna para Produtos.xaml
    /// </summary>
    public partial class Produtos : System.Windows.Window
    {
        public Produtos()
        {
            InitializeComponent();
        }

        private void Tdescricao_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Tcodigo_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void DtgridProdutos1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = (DataGrid)sender;
            DataRowView row = dg.SelectedItem as DataRowView;

            if (row != null)
            {
                tcodigo.Text = row["cod"].ToString();
                tdescricao.Text = row["descricao"].ToString();
            }
            
        }

        private void Cadastrar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = ("SERVER=127.0.0.1; PORT=3306; USER ID=root; DATABASE=bd_sistema; PASSWORD=;");
                MySqlCommand dcm = new MySqlCommand();
                dcm.Connection = conn;



                dcm.CommandText = "INSERT INTO tb_produto(descricao) values" +
                    "(@descricao)";


                
                dcm.Parameters.AddWithValue("@descricao", tdescricao.Text);


                conn.Open();
                dcm.ExecuteNonQuery();
                conn.Close();

                if
                     (MessageBox.Show("DESEJA CADASTRAR?", "INFORMAÇÃO", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    MessageBox.Show("CADASTRADO COM SUCESSO", "CADASTRAR", MessageBoxButton.OK, MessageBoxImage.Information);
                    limparCampos();
                    carregar();                }

                

            }
            catch
            {
                MessageBox.Show("NAO FOI POSSIVEL CADASTRAR");
                limparCampos();
            }
        }

            private void Alterar_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = "SERVER=127.0.0.1;port=3306;USER ID=root;DATABASE=bd_sistema;PASSWORD=;";

                MySqlCommand Update = new MySqlCommand("UPDATE tb_produto SET descricao = '" + tdescricao.Text + "'", conn);

                conn.Open();
                Update.ExecuteNonQuery();
                conn.Close();


                if
                    (MessageBox.Show("DESEJA ATUALIZAR?", "INFORMAÇÃO", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    MessageBox.Show("ATUALIZADO COM SUCESSO", "ATUALIZAR", MessageBoxButton.OK, MessageBoxImage.Information);
                    limparCampos();
                    carregar();
                }
               

            }
            catch
            {
                MessageBox.Show("Não Foi Possivel Atualizar");
                limparCampos();
            }
        }

        private void Grid_Initialized(object sender, EventArgs e)
        {
            carregar();
        }

        

        private void voltar_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            DashBoard dashboard = new DashBoard();
            dashboard.Show();
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Excluir_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = "SERVER = 127.0.0.1;port=3306;USER ID=root;DATABASE=bd_sistema;PASSWORD=;";

                MySqlCommand Deletar = new MySqlCommand("DELETE FROM tb_produto WHERE cod='" + tcodigo.Text + "'", conn);

                conn.Open();
                Deletar.ExecuteNonQuery();
                conn.Close();


                if
                    (MessageBox.Show("DESEJA EXCLUIR?", "INFORMAÇÃO", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    MessageBox.Show("EXCLUIDO COM SUCESSO", "EXCLUIR", MessageBoxButton.OK, MessageBoxImage.Information);
                    limparCampos();
                }


                carregar();
            }
            catch
            {
                MessageBox.Show("NÃO FOI POSSIVEL EXCLUIR");
            }
        }

        private void limparCampos()
        {
            tcodigo.Clear();
            tdescricao.Clear();
        }

        public void carregar()
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "SERVER=127.0.0.1;port=3306;USER ID=root;DATABASE=bd_sistema;PASSWORD=;";
            MySqlCommand dcm = new MySqlCommand();
            dcm.Connection = conn;

            MySqlCommand SELECT = new MySqlCommand("SELECT * FROM tb_produto", conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(SELECT);
            DataSet dataSet = new DataSet();
            adp.Fill(dataSet, "Load");
            DtgridProdutos1.DataContext = dataSet;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tdata.Content = DateTime.Now.ToString("dd/MM/yyyy");
            thora.Content = DateTime.Now.ToString("HH:mm:ss");
        }
    }

}

