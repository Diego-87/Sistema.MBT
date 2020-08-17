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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
namespace Sistema
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class Fornecedores : System.Windows.Window
    {
        public Fornecedores()
        {
            InitializeComponent();
        }

        private void Inserir_Click_1(object sender, RoutedEventArgs e)
        {
            if (tnomefantasia.Text != "" & trazaosocial.Text != "" & tcnpj.Text != "" & tendereco.Text != "" & tmunicipio.Text != "" & cbEstado.Text != "" & tbairro.Text != "" & ttelefone.Text != "" & tcel.Text != "" & temail.Text != "")
            {
                if (MessageBox.Show("CADASTRAR FORNECEDOR?", "INFORMAÇÃO", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    try
                    {
                        MySqlConnection conn = new MySqlConnection();
                        conn.ConnectionString = ("SERVER=127.0.0.1; PORT=3306; USER ID=root; DATABASE=bd_sistema; PASSWORD=;");
                        MySqlCommand dcm = new MySqlCommand();
                        dcm.Connection = conn;



                        dcm.CommandText = "INSERT INTO tb_fornecedores(nome_fantasia,razao_social,CNPJ,endereço,município,uf,bairro,telefone,cel,email) values" +
                            "(@nome_fantasia,@razao_social,@CNPJ,@endereço,@município,@uf,@bairro,@telefone,@cel,@email)";


                        dcm.Parameters.AddWithValue("@nome_fantasia", tnomefantasia.Text);
                        dcm.Parameters.AddWithValue("@razao_social", trazaosocial.Text);
                        dcm.Parameters.AddWithValue("@CNPJ", tcnpj.Text);
                        dcm.Parameters.AddWithValue("@endereço", tendereco.Text);
                        dcm.Parameters.AddWithValue("@município", tmunicipio.Text);
                        dcm.Parameters.AddWithValue("@uf", cbEstado.Text);
                        dcm.Parameters.AddWithValue("@bairro", tbairro.Text);
                        dcm.Parameters.AddWithValue("@telefone", ttelefone.Text);
                        dcm.Parameters.AddWithValue("@cel", tcel.Text);
                        dcm.Parameters.AddWithValue("@email", temail.Text);

                        conn.Open();
                        dcm.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Fornecedor cadastrado com sucesso");
                    }

                    catch
                    {
                        MessageBox.Show("Erro no Cadastro", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("PREENCHER TODOS OS DADOS", "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            limparCampos();
        }



        private void Trazaosocial_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.trazaosocial.IsEnabled = true;
        }

        private void Dtgridfornecedor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = (DataGrid)sender;
            DataRowView row = dg.SelectedItem as DataRowView;

            if (row != null)
            {
                tcod.Text = row["id_fornecedor"].ToString();
                tnomefantasia.Text = row["nome_fantasia"].ToString();
                trazaosocial.Text = row["razao_social"].ToString();
                tcnpj.Text = row["CNPJ"].ToString();
                tendereco.Text = row["endereço"].ToString();
                tbairro.Text = row["bairro"].ToString();
                tmunicipio.Text = row["município"].ToString();
                cbEstado.Text = row["uf"].ToString();
                ttelefone.Text = row["telefone"].ToString();
                tcel.Text = row["cel"].ToString();
                temail.Text = row["email"].ToString();
            }
        }

        public void cadfornecedor_Click_1(object sender, RoutedEventArgs e)

        {
            carregarLista();
        }

        public void carregarLista()
        {
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = ("SERVER=127.0.0.1; PORT=3306; USER ID=root; DATABASE=bd_sistema; PASSWORD=;");
                MySqlCommand dcm = new MySqlCommand();
                dcm.Connection = conn;

                MySqlCommand SELECT = new MySqlCommand("SELECT * FROM tb_fornecedores", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(SELECT);
                DataSet dataSet = new DataSet();
                adp.Fill(dataSet, "Load");
                Dtgridfornecedor.DataContext = dataSet;
            }
        }


        private void DtgridFornecedor_Initialized(object sender, EventArgs e)
        {

        }



        private void Tnomefantasia_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.tnomefantasia.IsEnabled = true;
        }

        private void Tcnpj_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.tcnpj.IsEnabled = true;
        }

        private void Tendereco_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.tendereco.IsEnabled = true;
        }

        private void Tbairro_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.tbairro.IsEnabled = true;
        }

        private void Tmunicipio_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.tmunicipio.IsEnabled = true;

        }

        private void Tuf_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.cbEstado.IsEnabled = true;
        }

        private void Ttelefone_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.ttelefone.IsEnabled = true;

        }

        private void Tcel_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.tcel.IsEnabled = true;

        }

        private void Temail_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.temail.IsEnabled = true;
        }

        private void atualizar_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = "SERVER=127.0.0.1;port=3306;USER ID=root;DATABASE=bd_sistema;PASSWORD=;";

                MySqlCommand Update = new MySqlCommand("UPDATE tb_fornecedores SET nome_fantasia ='" + tnomefantasia.Text + "',razao_social = '" + trazaosocial.Text + "',CNPJ = '" + tcnpj.Text + "',endereço = '" + tendereco.Text + "',município ='" + tmunicipio.Text + "',uf = '" + cbEstado.Text + "',bairro ='" + tbairro.Text + "',telefone='" + ttelefone.Text + "',cel = '" + tcel.Text + "',email = '" + temail + "' WHERE id_fornecedor = '" + tcod.Text + "'", conn);

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

        private void excluir_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = "SERVER=127.0.0.1;port=3306;USER ID=root;DATABASE=bd_sistema;PASSWORD=;";

                MySqlCommand Deletar = new MySqlCommand("DELETE FROM tb_fornecedores WHERE id_fornecedor='" + tcod.Text + "'", conn);

                conn.Open();
                Deletar.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("EXCLUIDO COM SUCESSO");
                carregar();
            }
            catch
            {
                MessageBox.Show("NÃO FOI POSSIVEL EXCLUIR");
            }
            limparCampos();

        }
        public void limparCampos()
        {
            tnomefantasia.Clear();
            trazaosocial.Clear();
            tcnpj.Clear();
            tendereco.Clear();
            tmunicipio.Clear();
           
            tbairro.Clear();
            ttelefone.Clear();
            tcel.Clear();
            temail.Clear();
            tcod.Clear();
        }




        private void Tcod_TextChanged(object sender, TextChangedEventArgs e)
        {


            this.tcod.IsEnabled = true;
        }

        private void Dtgridfornecedor_Initialized_1(object sender, EventArgs e)
        {
            carregar();

        }


        public void carregar()
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "SERVER=127.0.0.1;port=3306;USER ID=root;DATABASE=bd_sistema;PASSWORD=;";
            MySqlCommand dcm = new MySqlCommand();
            dcm.Connection = conn;

            MySqlCommand SELECT = new MySqlCommand("SELECT * FROM tb_fornecedores", conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(SELECT);
            DataSet dataSet = new DataSet();
            adp.Fill(dataSet, "Load");
            Dtgridfornecedor.DataContext = dataSet;
        }

        private void Voltar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DashBoard dashBoard = new DashBoard();
            dashBoard.Show();
            Close();

        }

        private void cbEstado_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cbEstado_Loaded(object sender, RoutedEventArgs e)
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            tdata.Content= DateTime.Now.ToString("dd/MM/yyy");
            thora.Content = DateTime.Now.ToString("HH:mm:ss");
        }

       
    }
}
