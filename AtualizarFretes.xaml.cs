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
    /// Lógica interna para AtualizarFretes.xaml
    /// </summary>
    public partial class AtualizarFretes : Window
    {
        public AtualizarFretes()
        {
            InitializeComponent();
        }

        private void dataGridAtualizarFretes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = (DataGrid)sender;
            DataRowView row = dg.SelectedItem as DataRowView;

            if (row != null)
            {
                tcod.Text = row["cod"].ToString();
                tproduto.Text = row["produto"].ToString();
                cbUnidade.Text = row["unidade"].ToString();
                tQuantidade.Text = row["Quantidade"].ToString();
                tdata.Text = row["data"].ToString();
                cbCliente.Text = row["cliente"].ToString();
                tmunicipio1.Text = row["municipio"].ToString();
                tvalor.Text = row["valor"].ToString();
                tvaltot.Text = row["valor_total"].ToString();
                tlocal.Text = row["local_entrega"].ToString();
                tobservacao.Text = row["observacao"].ToString();


            }
        }
        
        private void Alterar_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = "SERVER=127.0.0.1;port=3306;USER ID=root;DATABASE=bd_sistema;PASSWORD=;";

                MySqlCommand Update = new MySqlCommand("UPDATE tb_frete SET produto ='" + tproduto.Text + "',unidade = '" + cbUnidade.Text + "', quantidade = '" + tQuantidade.Text + "',data ='" + tdata.Text + "',cliente = '" + cbCliente.Text + "',municipio ='" + tmunicipio1.Text + "',valor ='" + tvalor.Text + "',valor_total = '" +tvaltot.Text +"',local_entrega = '" + tlocal.Text +"',observacao = '" + tobservacao.Text +"' WHERE cod = '" + tcod.Text + "'", conn);

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

                MySqlCommand Deletar = new MySqlCommand("DELETE FROM tb_frete WHERE cod='" + tcod.Text + "'", conn);

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

            MySqlCommand SELECT = new MySqlCommand("SELECT * FROM tb_frete", conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(SELECT);
            DataSet dataSet = new DataSet();
            adp.Fill(dataSet, "Load");
            dataGridAtualizarFretes.DataContext = dataSet;
        }

        public void limparCampos()
        {
            tcod.Clear();
            tproduto.Clear();
            cbUnidade.Clear();
            tQuantidade.Clear();
            tdata.Clear();
            cbCliente.Clear();
            tmunicipio1.Clear();
            tvalor.Clear();
            tvaltot.Clear();
            tlocal.Clear();
            tobservacao.Clear();

        }

        private void dataGridAtualizarFretes_Initialized(object sender, EventArgs e)
        {
            carregar();
        }

        private void Voltar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frete frete = new frete();
            frete.Show();
            Close();
        }
    }
}

