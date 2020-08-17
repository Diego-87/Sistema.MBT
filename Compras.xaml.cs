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
    /// Lógica interna para Compras.xaml
    /// </summary>
    public partial class Compras : System.Windows.Window
    {
        public Compras()
        {
            InitializeComponent();
            CarregarSala();


        }



        private void Cadastrar_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = ("SERVER=127.0.0.1; PORT=3306; USER ID=root; DATABASE=bd_sistema; PASSWORD=;");
                MySqlCommand dcm = new MySqlCommand();
                dcm.Connection = conn;



                dcm.CommandText = "INSERT INTO tb_compras(descricao,data,fornecedor,unidade,valor_unitario,quantidade,total) values" +
                    "(@descricao,@data,@fornecedor,@unidade,@valor_unitario,@quantidade,@total)";



                dcm.Parameters.AddWithValue("@descricao", tdescricao2.Text);
                dcm.Parameters.AddWithValue("@data", tdata2.Text);
                dcm.Parameters.AddWithValue("@fornecedor", cbfornecedor.Text);
                dcm.Parameters.AddWithValue("@unidade", cbUnidade.Text);
                dcm.Parameters.AddWithValue("@valor_unitario", tvalunitario.Text);
                dcm.Parameters.AddWithValue("@quantidade", txtquantidade.Text);
                dcm.Parameters.AddWithValue("@total", ttotal1.Text);
                

                conn.Open();
                dcm.ExecuteNonQuery();
                conn.Close();

                if ((tdescricao2.Text == "") && (tdata2.Text == "") && (cbfornecedor.Text == "") && (cbUnidade.Text == "") && (tvalunitario.Text == "") && (txtquantidade.Text == "") && (ttotal1.Text == ""))
                {
                    MessageBox.Show("PREENCHER CAMPOS", "CADASTRO", MessageBoxButton.OK, MessageBoxImage.Information);
                }

                else
                {
                    MessageBox.Show("DESEJA CADASTRAR?", "INFORMAÇÃO", MessageBoxButton.YesNo, MessageBoxImage.Question);
                
                    MessageBox.Show("CADASTRADO COM SUCESSO", "CADASTRAR", MessageBoxButton.OK, MessageBoxImage.Information);
                    limparCampos();
                }
                limparCampos();
                carregar();

            }

            catch
            {

                MessageBox.Show("Erro no Cadastro", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

            }

        }




        private void Tdescricao_TextChanged(object sender, TextChangedEventArgs e)
        {
            tdescricao2.IsEnabled = true;
        }



        private void Tvalunitario_TextChanged(object sender, TextChangedEventArgs e)
        {
            tvalunitario.IsEnabled = true;
           
        }





        public void carregar()
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "SERVER=127.0.0.1;port=3306;USER ID=root;DATABASE=bd_sistema;PASSWORD=;";
            MySqlCommand dcm = new MySqlCommand();
            dcm.Connection = conn;

        }


        private void Tcodigo_TextChanged(object sender, TextChangedEventArgs e)
        {
            tcod.IsEnabled = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Alterar_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = "SERVER=127.0.0.1;port=3306;USER ID=root;DATABASE=bd_sistema;PASSWORD=;";

                MySqlCommand Update = new MySqlCommand("UPDATE tb_compras SET descricao ='" + tdescricao2.Text + "',data = '" + tdata2.Text + "',fornecedor = '" + cbfornecedor.Text + "',unidade = '" + cbUnidade.Text +"', valor_unitario ='" + tvalunitario.Text + "',quantidade = '" + txtquantidade.Text + "', total = '" + ttotal1.Text + "' WHERE descricao = '" + tdescricao2.Text + "'", conn);

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
                MessageBox.Show("ERRO!!!");
                limparCampos();
            }
        }
        public void limparCampos()
        {

            tdescricao2.Clear();

            tvalunitario.Clear();
            ttotal1.Clear();
            txtquantidade.Clear();
            ttotal1.Clear();
            tdata2.Clear();
           



        }

        private void Excluir_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = "SERVER=127.0.0.1;port=3306;USER ID=root;DATABASE=bd_sistema;PASSWORD=;";

                MySqlCommand Deletar = new MySqlCommand("DELETE FROM tb_compras WHERE data ='" + tdata2.Text + "'", conn);

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


        private void Voltar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DashBoard dashBoard = new DashBoard();
            dashBoard.Show();
            Close();
        }

        private void tdescricao2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tcaixa_TextChanged(object sender, TextChangedEventArgs e)
        {

        }



        private void tpacote_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tkilo_TextChanged(object sender, TextChangedEventArgs e)
        {

        }



        private void DtgridCompras_Initialized(object sender, EventArgs e)
        {

        }

        private void Grid_Initialized(object sender, EventArgs e)
        {

        }



        private void Total1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Total1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            decimal a, b, c;

            a = Convert.ToDecimal(tvalunitario.Text);
            b = Convert.ToDecimal(txtquantidade.Text);

            c = a * b;


            ttotal1.Text = c.ToString().Replace(',', '.');


        }

        private void Tdata_TextChanged(object sender, TextChangedEventArgs e)
        {

          

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

           

        }



        private void CarregarSala()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "SERVER=127.0.0.1;port=3306;USER ID=root;DATABASE=bd_sistema;PASSWORD=;";
            MySqlCommand dcm = new MySqlCommand();
            dcm.Connection = con;


            cbfornecedor.Items.Clear();
            con.Open();
            try
            {
                MySqlCommand Select = new MySqlCommand("SELECT nome_fantasia FROM tb_fornecedores", con);
                MySqlDataReader dr = Select.ExecuteReader();

                while (dr.Read())
                {
                    cbfornecedor.Items.Add(dr["nome_fantasia"].ToString());
                }
                con.Close();
            }
            catch
            {
                MessageBox.Show("erro 1", "ERRO!", MessageBoxButton.OK);
                con.Close();
            }
        }

        private void listaCadastro_MouseDown(object sender, MouseButtonEventArgs e)
        {
            cadcompras cadastrocompras = new cadcompras();
            cadastrocompras.Show();
            Close();
        }


        private void cbUnidade_Loaded(object sender, RoutedEventArgs e)
        {
            cbUnidade.Items.Add("KG");
            cbUnidade.Items.Add("CX");
            cbUnidade.Items.Add("PCT");
            cbUnidade.Items.Add("SC");
            cbUnidade.Items.Add("MC");
            cbUnidade.Items.Add("UN");
        }

        private void thora_Loaded(object sender, RoutedEventArgs e)
        {
            tdata.Content = DateTime.Now.ToString("dd/MM/yyy");
            thora.Content = DateTime.Now.ToString("HH:mm:ss");
        }

        private void cbUnidade_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void pesquisa_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "SERVER=127.0.0.1;port=3306;USER ID=root;DATABASE=bd_sistema;PASSWORD=;";
            MySqlCommand dcm = new MySqlCommand();
            dcm.Connection = con;


          
            con.Open();


            try
            {
                MySqlCommand Select = new MySqlCommand("SELECT descricao,data,fornecedor,unidade,valor_unitario,quantidade,total  FROM tb_compras", con);
                MySqlDataReader dr = Select.ExecuteReader();

                while (dr.Read())
                {

                    
                    tdescricao2.Text = dr["descricao"].ToString();
                    tdata2.Text = dr["data"].ToString();
                    cbfornecedor.Text =  dr["fornecedor"].ToString();
                    cbUnidade.Text = dr["unidade"].ToString();
                    tvalunitario.Text = dr["valor_unitario"].ToString();
                    txtquantidade.Text = dr["quantidade"].ToString();
                    ttotal1.Text = dr["total"].ToString();
                }
                con.Close();
            }
            catch
            {
                MessageBox.Show("erro 1", "ERRO!", MessageBoxButton.OK);
                con.Close();
            }
            }

        private void AtualizarCompras_MouseDown(object sender, MouseButtonEventArgs e)
        {
            AtualizarCompras atualizarCompras = new AtualizarCompras();
            atualizarCompras.Show();
            Close();
        }

        private void tdata2_Loaded(object sender, RoutedEventArgs e)
        {
            tdata2.Text = DateTime.Now.ToString("dd/MM/yyy");
        }

        private void tdata2_Loaded_1(object sender, RoutedEventArgs e)
        {
            tdata2.Text = DateTime.Now.ToString("dd/MM/yyy");
        }
    }
    }













