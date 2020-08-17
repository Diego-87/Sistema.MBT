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
using DateTimeExtensions.NaturalText;

namespace Sistema
{
    /// <summary>
    /// Lógica interna para RelatorioData.xaml
    /// </summary>
    public partial class AtualizarCompras : Window
    {
        public AtualizarCompras()
        {
            InitializeComponent();
        }

        private void dataGridAtualizarCompras_Initialized(object sender, EventArgs e)
        {
            carregar();
        }

        private void dataGridAtualizarCompras_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = (DataGrid)sender;
            DataRowView row = dg.SelectedItem as DataRowView;

            if (row != null)
            {
                tcod.Text = row["cod"].ToString();
                tdescricao2.Text = row["descricao"].ToString();
                tdata2.Text = row["data"].ToString();
                cbfornecedor.Text = row["fornecedor"].ToString();
                cbUnidade.Text = row["unidade"].ToString();
                tvalunitario.Text = row["valor_unitario"].ToString();
                txtQuantidade.Text = row["quantidade"].ToString();
                ttotal1.Text = row["total"].ToString();
               
            }
        }

        private void Alterar_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = "SERVER=127.0.0.1;port=3306;USER ID=root;DATABASE=bd_sistema;PASSWORD=;";

                MySqlCommand Update = new MySqlCommand("UPDATE tb_compras SET descricao ='" + tdescricao2.Text + "',data = '" + tdata2.Text + "',fornecedor = '" + cbfornecedor.Text + "',unidade ='" + cbUnidade.Text + "',valor_unitario = '" + tvalunitario.Text + "',quantidade ='" + txtQuantidade.Text + "',total ='" + ttotal1.Text +  "' WHERE cod = '" + tcod.Text + "'", conn);

                conn.Open();
                Update.ExecuteNonQuery();
                conn.Close();


                if
                    (MessageBox.Show("DESEJA ATUALIZAR?", "INFORMAÇÃO", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    MessageBox.Show("ATUALIZADO COM SUCESSO", "ATUALIZAR", MessageBoxButton.OK, MessageBoxImage.Information);
                    limparCampos();
                }
                carregar();

            }
            catch
            {
                MessageBox.Show("NÃO FOI POSSIVEL ATUALIZAR");
                limparCampos();
            }
        }

        private void Excluir_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = "SERVER = 127.0.0.1;port=3306;USER ID=root;DATABASE=bd_sistema;PASSWORD=;";

                MySqlCommand Deletar = new MySqlCommand("DELETE FROM tb_compras WHERE cod='" + tcod.Text + "'", conn);

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
            dataGridAtualizarCompras.DataContext = dataSet;
        }

        public void limparCampos()
        {
            tcod.Clear();
            tdescricao2.Clear();
            tdata2.Clear();
            cbfornecedor.Clear();
            cbUnidade.Clear();
            tvalunitario.Clear();
            txtQuantidade.Clear();
            ttotal1.Clear();
           
        }

        private void Voltar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Compras compras = new Compras();
            compras.Show();
            Close();
        }
    }
}
