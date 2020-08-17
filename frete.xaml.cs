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
    /// Lógica interna para frete.xaml
    /// </summary>
    public partial class frete : System.Windows.Window
    {
        public frete()
        {
            InitializeComponent();
            ComboboxCliente();
        }

        private void Tcodigo_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Tquantidade1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Tdata_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void tcliente_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Tmunicipio1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Tobservacao_TextChanged(object sender, TextChangedEventArgs e)
        {

        }



        private void voltar1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DashBoard dashBoard = new DashBoard();
            dashBoard.Show();
            Close();
        }

        private void Excluir_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = "SERVER = 127.0.0.1;port=3306;USER ID=root;DATABASE=bd_sistema;PASSWORD=;";

                MySqlCommand Deletar = new MySqlCommand("DELETE FROM tb_frete WHERE  produto='" + tproduto.Text + "'", conn);

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


        private void Alterar_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = "SERVER=127.0.0.1;port=3306;USER ID=root;DATABASE=bd_sistema;PASSWORD=;";

                MySqlCommand Update = new MySqlCommand("UPDATE tb_frete SET produto ='" + tproduto.Text + "',unidade = '" + cbUnidade.Text + "',quantidade = '" + tQuantidade.Text +"' ,data = '" + tdata.Text + "',cliente ='" + cbCliente.Text + "',municipio = '" + tmunicipio1.Text + "',valor ='" + tvalor.Text + "',observacao='" + tobservacao.Text + "' WHERE produto = '" + tproduto.Text + "'", conn);

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
                MessageBox.Show("DEU ERRADO");
                limparCampos();
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



                dcm.CommandText = "INSERT INTO tb_frete(produto,unidade,quantidade,data,cliente,municipio,valor,valor_total,local_entrega,observacao) values" +
                    "(@produto,@unidade,@quantidade,@data,@cliente,@municipio,@valor,@valor_total,@local_entrega,@observacao)";


                dcm.Parameters.AddWithValue("@produto", tproduto.Text);
                dcm.Parameters.AddWithValue("@unidade", cbUnidade.Text);
                dcm.Parameters.AddWithValue("@quantidade", tQuantidade.Text);
                dcm.Parameters.AddWithValue("@data", tdata.Text);
                dcm.Parameters.AddWithValue("@cliente", cbCliente.Text);
                dcm.Parameters.AddWithValue("@municipio", tmunicipio1.Text);
                dcm.Parameters.AddWithValue("@valor", tvalor.Text);
                dcm.Parameters.AddWithValue("@valor_total", tvaltot.Text);
                dcm.Parameters.AddWithValue("@local_entrega", tlocal.Text);
                dcm.Parameters.AddWithValue("@observacao", tobservacao.Text);





                conn.Open();
                dcm.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Frete cadastrado com sucesso", "Cadastro", MessageBoxButton.OK, MessageBoxImage.Information);

                limparCampos();
                carregar();

            }

            catch
            {
                MessageBox.Show("Erro no Cadastro", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }
        public void carregar()
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "SERVER=127.0.0.1;port=3306;USER ID=root;DATABASE=bd_sistema;PASSWORD=;";
            MySqlCommand dcm = new MySqlCommand();
            dcm.Connection = conn;

        }

        public void limparCampos()
        {
            tproduto.Clear();
            cbUnidade.Items.Clear();
            
            
            tmunicipio1.Clear();
            tvalor.Clear();
            tobservacao.Clear();
            tQuantidade.Clear();
            tlocal.Clear();
            tvaltot.Clear();
        }

        private void tobservacao_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void lista_fretes_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Frete listafretes = new Frete();
            listafretes.Show();
            Close();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tdata1.Content = DateTime.Now.ToString("dd/MM/yyyy");
            thora.Content = DateTime.Now.ToString("HH:mm:ss");

            
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        public void ComboboxCliente()
        {

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "SERVER=127.0.0.1;port=3306;USER ID=root;DATABASE=bd_sistema;PASSWORD=;";
            MySqlCommand dcm = new MySqlCommand();
            dcm.Connection = con;


            cbCliente.Items.Clear();
            con.Open();
            try
            {
                MySqlCommand Select = new MySqlCommand("SELECT nome_fantasia FROM tb_cliente", con);
                MySqlDataReader dr = Select.ExecuteReader();

                while (dr.Read())
                {
                    cbCliente.Items.Add(dr["nome_fantasia"].ToString());
                }
                con.Close();
            }
            catch
            {
                MessageBox.Show("erro 1", "ERRO!", MessageBoxButton.OK);
                con.Close();
            }
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {


        }

        private void ComboBox_Loaded(object sender, RoutedEventArgs e)
        {

            cbUnidade.Items.Add("KG");
            cbUnidade.Items.Add("CX");
            cbUnidade.Items.Add("PCT");
            cbUnidade.Items.Add("SC");
            cbUnidade.Items.Add("MC");
            cbUnidade.Items.Add("UN");

        }

       
          

        private void tvaltot_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void valtot_MouseDown(object sender, MouseButtonEventArgs e)
        {
            decimal a, b, c;

            a = Convert.ToDecimal(tvalor.Text);
            b = Convert.ToDecimal(tQuantidade.Text);

            c = a * b;

            tvaltot.Text = c.ToString().Replace(',', '.');

        }

        private void Tlocal_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tdata_Loaded(object sender, RoutedEventArgs e)
        {
            tdata.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void Atualizar_fretes_MouseDown(object sender, MouseButtonEventArgs e)
        {
            AtualizarFretes atualizarFretes = new AtualizarFretes();
            atualizarFretes.Show();
        }
    }
}


    
    
