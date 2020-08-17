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

namespace Sistema
{
    /// <summary>
    /// Lógica interna para Vendas.xaml
    /// </summary>
    public partial class Vendas : Window
    {
       
        public Vendas()
        {
            InitializeComponent();
            CarregarSala();
            ComboBoxCliente();
            comboBoxUnidade();
           
            
        }
    

        private void CarregarSala()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "SERVER=127.0.0.1;port=3306;USER ID=root;DATABASE=bd_sistema;PASSWORD=;";
            MySqlCommand dcm = new MySqlCommand();
            dcm.Connection = con;


            cbProduto.Items.Clear();
            con.Open();
            try
            {
                MySqlCommand Select = new MySqlCommand("SELECT descricao FROM tb_compras", con);
                MySqlDataReader dr = Select.ExecuteReader();

                while (dr.Read())
                {
                    cbProduto.Items.Add(dr["descricao"].ToString());
                }
                con.Close();
            }
            catch
            {
                MessageBox.Show("erro 1", "ERRO!", MessageBoxButton.OK);
                con.Close();
            }
        }


        public void ComboBoxCliente()
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        public void limparCampos()
        {
           
            
            txtValorUnitario.Clear();
            txtQuantidade.Clear();
            
            txtPreço.Clear();

                    }


       
        



        private void TxtQuantidade_LostFocus_1(object sender, RoutedEventArgs e)
        {
            try
            {
                decimal a, b, c;

                a = Convert.ToDecimal(txtValorUnitario.Text);
                b = Convert.ToDecimal(txtQuantidade.Text);

                c = a * b;



                txtPreço.Text = c.ToString().Replace(',', '.');

                
            }
            catch
            {
                MessageBox.Show("PRENCHER CAMPOS", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

    private void Comprar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = "SERVER=127.0.0.1;port=3306;USER ID=root;DATABASE=bd_sistema;PASSWORD=;";
                MySqlCommand dcm = new MySqlCommand();
                MySqlCommand dcm1 = new MySqlCommand();


               

                dcm.Connection = conn;
                // dcm1.Connection = conn;

                dcm.CommandText = "INSERT INTO tb_vendas(nome_cliente,nome_produto,unidade,data,valorunitario,quantidade,preco,pagamento,observacao) values" +
                    "(@nome_cliente,@nome_produto,@unidade,@data,@valorunitario,@quantidade,@preco,@pagamento,@observacao)"; //realizando venda

               
                dcm.Parameters.AddWithValue("@nome_cliente", cbCliente.Text);
                dcm.Parameters.AddWithValue("@nome_produto", cbProduto.Text);
                dcm.Parameters.AddWithValue("@unidade", cbUnidade.Text);
                dcm.Parameters.AddWithValue("@data", tdata3.Text);
                dcm.Parameters.AddWithValue("@valorunitario", txtValorUnitario.Text.Replace(',', '.'));
                dcm.Parameters.AddWithValue("@quantidade", txtQuantidade.Text);
                dcm.Parameters.AddWithValue("@preco", txtPreço.Text.Replace(',', '.'));
                dcm.Parameters.AddWithValue("@pagamento", cbpagamento.Text);
                dcm.Parameters.AddWithValue("@observacao", txtObservacao.Text);

                conn.Open();
                dcm.ExecuteNonQuery();


                conn.Close();
                

                MessageBox.Show("Realizado Venda com  Sucesso", "Vendas", MessageBoxButton.OK, MessageBoxImage.Information);
               
            }

            catch (MySqlException a)
            {
                MessageBox.Show(a.ToString(), "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            limparCampos();
        }

        private void voltar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void lista_vendas(object sender, RoutedEventArgs e)
        {

        }

        private void Voltar4_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DashBoard dashBoard = new DashBoard();
            dashBoard.Show();
            Close();
        }

        private void TxtQnt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtPreço_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }
        
        private void cbCliente_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }

        private void txtQuantidade_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void txtValorUnitario_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void comboBoxUnidade()
        {
            

        }

        private void cbunidade_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cbUnidade.Items.Add("KG");
            cbUnidade.Items.Add("CX");
            cbUnidade.Items.Add("PCT");
            cbUnidade.Items.Add("SC");
            cbUnidade.Items.Add("MC");
            cbUnidade.Items.Add("UN");

            tdata.Content = DateTime.Now.ToString("dd/MM/yyyy");
            thora.Content = DateTime.Now.ToString("HH:mm:ss");


        }

        private void cbpagamento_Loaded(object sender, RoutedEventArgs e)
        {
            cbpagamento.Items.Add("À VISTA");
            cbpagamento.Items.Add("À PRAZO");
        }

        private void tdata2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tdata3_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void tdata3_Loaded(object sender, RoutedEventArgs e)
        {
            tdata3.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void AtualizarVendas_MouseDown(object sender, MouseButtonEventArgs e)
        {

            atualizar_produtos_vendidos atualizar_produtos_vendidos = new atualizar_produtos_vendidos();
            atualizar_produtos_vendidos.Show();
            Close();
        }
    }
    }

       
    