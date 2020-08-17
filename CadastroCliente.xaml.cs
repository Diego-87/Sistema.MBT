using System;
using System.Collections.Generic;
using System.Data;
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
    /// Lógica interna para CadastroCliente.xaml
    /// </summary>
    public partial class CadastroCliente : Window
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void Tnome_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Inserir_Click_1(object sender, RoutedEventArgs e)
        {

            if (tnome.Text != "" & trazaosocial.Text != "" & tendereco1.Text != "" & tmunicipio1.Text != "" & cbEstado.Text != "" & tbairro1.Text != "" & ttelefone1.Text != "" & tcel1.Text != "" & temail1.Text != "")
            {
                if (MessageBox.Show("CADASTRAR CLIENTE?", "INFORMAÇÃO", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {

                    try
                    {
                        MySqlConnection conn = new MySqlConnection();
                        conn.ConnectionString = "SERVER=127.0.0.1; PORT=3306; USER ID=root; DATABASE=bd_sistema;PASSWORD=;";
                        MySqlCommand dcm = new MySqlCommand();
                        dcm.Connection = conn;



                        dcm.CommandText = "INSERT INTO tb_cliente(nome_fantasia,razao_social,endereco,municipio,uf,bairro,telefone,cel,email) values" +
                            "(@nome_fantasia,@razao_social,@endereco,@municipio,@uf,@bairro,@telefone,@cel,@email)";


                        dcm.Parameters.AddWithValue("@nome_fantasia", tnome.Text);
                        dcm.Parameters.AddWithValue("@razao_social", trazaosocial.Text);
                        dcm.Parameters.AddWithValue("@endereco", tendereco1.Text);
                        dcm.Parameters.AddWithValue("@municipio", tmunicipio1.Text);
                        dcm.Parameters.AddWithValue("@uf", cbEstado.Text);
                        dcm.Parameters.AddWithValue("@bairro", tbairro1.Text);
                        dcm.Parameters.AddWithValue("@telefone", ttelefone1.Text);
                        dcm.Parameters.AddWithValue("@cel", tcel1.Text);
                        dcm.Parameters.AddWithValue("@email", temail1.Text);

                        conn.Open();
                        dcm.ExecuteNonQuery();
                        conn.Close();

                    

                        
                        

                            MessageBox.Show("CLIENTE CADASTRADO COM SUCESSO", "CADASTRO", MessageBoxButton.OK, MessageBoxImage.Information);

                        
                        

                    }

                    catch
                    {
                        MessageBox.Show("ERRO NO CADASTRO", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                        
                    }
                    limparCampos();
                    carregar();
                }
            }
            

        }
        private void Tcpf1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Tcod_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Tcod1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Tnomefantasia_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Tendereco1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Tbairro1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Tuf1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Ttelefone1_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Tcel1_TextChanged(object sender, TextChangedEventArgs e)
        {
            

        }

        private void Temail1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Dtgridcliente_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = (DataGrid)sender;
            DataRowView row = dg.SelectedItem as DataRowView;

            if (row != null)
            {
                tcod1.Text = row["cod"].ToString();
                tnome.Text = row["nome_fantasia"].ToString();
                trazaosocial.Text = row["razao_social"].ToString();
                tendereco1.Text = row["endereco"].ToString();
                tbairro1.Text = row["bairro"].ToString();
                tmunicipio1.Text = row["municipio"].ToString();
                cbEstado.Text = row["uf"].ToString();
                ttelefone1.Text = row["telefone"].ToString();
                tcel1.Text = row["cel"].ToString();
                temail1.Text = row["email"].ToString();
            }
        }

        private void Tmunicipio1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Dtgridcliente_Initialized_1(object sender, EventArgs e)
        {
            carregar();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void atualizar_Click_4(object sender, RoutedEventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = "SERVER=127.0.0.1;port=3306;USER ID=root;DATABASE=bd_sistema;PASSWORD=;";

                MySqlCommand Update = new MySqlCommand("UPDATE tb_cliente SET nome_fantasia ='" + tnome.Text + "',razao_social = '" + trazaosocial.Text + "',endereco = '" + tendereco1.Text + "',municipio ='" + tmunicipio1.Text + "',uf = '" + cbEstado.Text + "',bairro ='" + tbairro1.Text + "',telefone='" + ttelefone1.Text + "',cel = '" + tcel1.Text + "',email = '" + temail1 + "' WHERE cod = '" + tcod1.Text + "'", conn);

                conn.Open();
                Update.ExecuteNonQuery();
                conn.Close();


                if
                    (MessageBox.Show("DESEJA ATUALIZAR?", "INFORMAÇÃO", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes) { 
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

        private void excluir_Click_5(object sender, RoutedEventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = "SERVER = 127.0.0.1;port=3306;USER ID=root;DATABASE=bd_sistema;PASSWORD=;";

                MySqlCommand Deletar = new MySqlCommand("DELETE FROM tb_cliente WHERE cod='" + tcod1.Text + "'", conn);

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

            MySqlCommand SELECT = new MySqlCommand("SELECT * FROM tb_cliente", conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(SELECT);
            DataSet dataSet = new DataSet();
            adp.Fill(dataSet, "Load");
            Dtgridcliente.DataContext = dataSet;
        }

        public void limparCampos()
        {
            tnome.Clear();
            trazaosocial.Clear();
            tendereco1.Clear();
            tmunicipio1.Clear();
            cbEstado.Text="Selecione";
            tbairro1.Clear();
            ttelefone1.Clear();
            tcel1.Clear();
            temail1.Clear();
            tcod1.Clear();
        }

        private void Voltar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DashBoard dashBoard = new DashBoard();
            dashBoard.Show();
            Close();
        }

        private void Trazaosocial_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Dtgridcliente_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }

        private void ComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            cbEstado.Items.Add("AC");
            cbEstado.Items.Add("AL");
            cbEstado.Items.Add("AP");
            cbEstado.Items.Add("AM");
            cbEstado.Items.Add("BA");
            cbEstado.Items.Add("CE");
            cbEstado.Items.Add("DF");
            cbEstado.Items.Add("ES");
            cbEstado.Items.Add("GO");
            cbEstado.Items.Add("MA");
            cbEstado.Items.Add("MT");
            cbEstado.Items.Add("MS");
            cbEstado.Items.Add("MG");
            cbEstado.Items.Add("PA");
            cbEstado.Items.Add("PB");
            cbEstado.Items.Add("PE");
            cbEstado.Items.Add("PI");
            cbEstado.Items.Add("RJ");
            cbEstado.Items.Add("RN");
            cbEstado.Items.Add("RS");
            cbEstado.Items.Add("RO");
            cbEstado.Items.Add("RR");
            cbEstado.Items.Add("SC");
            cbEstado.Items.Add("SP");
            cbEstado.Items.Add("SE");
            cbEstado.Items.Add("TO");

  }

        private void cbEstado_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cbEstado.Text ="Selecione";
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tdata.Content = DateTime.Now.ToString("dd/MM/yyyy");
            thora.Content = DateTime.Now.ToString("HH:mm:yyyy");
           
        }

        private void ttelefone1_Loaded(object sender, RoutedEventArgs e)
        {
           


        }
    }
}
