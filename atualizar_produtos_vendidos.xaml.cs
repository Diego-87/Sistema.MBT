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
    /// Lógica interna para atualizar_produtos_vendidos.xaml
    /// </summary>
    public partial class atualizar_produtos_vendidos : Window
    {
        public atualizar_produtos_vendidos()
        {
            InitializeComponent();
            carregar();
        }

        private void Alterar_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = "SERVER=127.0.0.1;port=3306;USER ID=root;DATABASE=bd_sistema;PASSWORD=;";

                MySqlCommand Update = new MySqlCommand("UPDATE tb_vendas SET nome_produto ='" + cbproduto.Text + "',data = '" + tdata3.Text + "',nome_cliente = '" + cbCliente.Text + "',unidade ='" + cbunidade.Text + "',valorunitario = '" + txtValorUnitario.Text + "',quantidade ='" + txtQuantidade.Text + "',preco ='" + txtPreço.Text + "',pagamento = '" + cbpagamento.Text + "',observacao = '" + txtObservacao.Text + "' WHERE nome_produto = '" + cbproduto.Text + "'", conn);

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

        private void dataGridAtualizarVendas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = (DataGrid)sender;
            DataRowView row = dg.SelectedItem as DataRowView;

            if (row != null)
            {
                cbproduto.Text = row["nome_produto"].ToString();
                cbunidade.Text = row["unidade"].ToString();
                tdata3.Text = row["data"].ToString();
                cbCliente.Text = row["nome_cliente"].ToString();
                txtValorUnitario.Text = row["valorunitario"].ToString();
                txtQuantidade.Text = row["quantidade"].ToString();
                txtPreço.Text = row["preco"].ToString();
                cbpagamento.Text = row["pagamento"].ToString();
                txtObservacao.Text = row["observacao"].ToString();

            }
        }

        private void cbproduto_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void cbunidade_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tdata3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void cbCliente_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtValorUnitario_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtQuantidade_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtPreço_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void cbpagamento_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtObservacao_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Excluir_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = "SERVER = 127.0.0.1;port=3306;USER ID=root;DATABASE=bd_sistema;PASSWORD=;";

                MySqlCommand Deletar = new MySqlCommand("DELETE FROM tb_vendas WHERE nome_produto='" + cbproduto.Text + "'", conn);

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





        private void dataGridAtualizarVendas_Initialized(object sender, EventArgs e)
        {

        }


        public void carregar()
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "SERVER=127.0.0.1;port=3306;USER ID=root;DATABASE=bd_sistema;PASSWORD=;";
            MySqlCommand dcm = new MySqlCommand();
            dcm.Connection = conn;

            MySqlCommand SELECT = new MySqlCommand("SELECT * FROM tb_vendas", conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(SELECT);
            DataSet dataSet = new DataSet();
            adp.Fill(dataSet, "Load");
            dataGridAtualizarVendas.DataContext = dataSet;
        }

        public void limparCampos()
        {
            cbproduto.Clear();
            cbunidade.Clear();
            tdata3.Clear();
            cbCliente.Clear();
            txtValorUnitario.Clear();
            txtQuantidade.Clear();
            txtPreço.Clear();
            cbpagamento.Clear();
            txtObservacao.Clear();

        }

        private void Voltar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Vendas vendas = new Vendas();
            vendas.Show();
            Close();
        }


    }
}