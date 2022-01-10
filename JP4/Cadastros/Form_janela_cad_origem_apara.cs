using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace JP4
{
    public partial class Form_janela_cad_origem_apara : Form
    {
        public Form_janela_cad_origem_apara()
        {
            InitializeComponent();

            Carregar_empresa_db();
            Carregar_grid_local_estoque();
        }

        // db_cadastro_local_origem_apara

        // empresa
        // local_estoque
        // observacao


        // -------------------------------------------------------------------------------------------------------
        // Carregar controles

        private void Carregar_empresa_db()
        {
            try
            {

                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_empresas";

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();


                while (myreader.Read())
                {
                    combo_empresa.Items.Add(myreader["descricao"].ToString());
                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }
        private void Carregar_grid_local_estoque()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_local_origem_apara";

                MySqlConnection connection = new MySqlConnection(conecta_string);
                MySqlDataAdapter myadapter = new MySqlDataAdapter(comando_sql, connection);
                DataTable dt = new DataTable("db_cadastro_local_origem_apara");

                myadapter.Fill(dt);
                DataView dv = dt.DefaultView;

                //dv.RowFilter = string.Format("descri_pai like '%{0}%'", item_pai);
                grid_cad_local_estoque_origem.DataSource = dv.ToTable();

                connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Carregar_controles(string id_local)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_local_origem_apara where id_local=" + id_local;

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    combo_empresa.Text = myreader["empresa"].ToString();
                    text_local_estoque.Text = myreader["local_estoque"].ToString();
                    text_observa.Text = myreader["observacao"].ToString();
                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }

        // -------------------------------------------------------------------------------------------------------
        // Salvar // Atualizar // Deletar
        private void limpar_controles()
        {
            combo_empresa.Text = string.Empty;
            text_local_estoque.Text = string.Empty;
            text_observa.Text = string.Empty;
        }
        private void Salvar_local_estoque()
        {
            string empresa = combo_empresa.Text;
            string local_estoque = text_local_estoque.Text;
            string observacao = text_observa.Text;

            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                MySqlConnection conexao = new MySqlConnection(conecta_string);
                conexao.Open();

                string comando_sql;

                comando_sql = "INSERT INTO db_cadastro_local_origem_apara(empresa, local_estoque, observacao) " +
                    "VALUES('" + empresa + "','" + local_estoque + "','" + observacao + "')";

                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }
        }
        private void Atualizar_local_aplica(string id_local)
        {
            string empresa = combo_empresa.Text;
            string local_estoque = text_local_estoque.Text;
            string observacao = text_observa.Text;

            try
            {
                string comando_sql;

                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                MySqlConnection conexao = new MySqlConnection(conecta_string);
                conexao.Open();

                comando_sql = "UPDATE db_cadastro_local_origem_apara SET " +
                        "empresa='" + empresa +
                        "', local_estoque='" + local_estoque +
                        "', observacao='" + observacao +
                        "' WHERE id_local=" + id_local;

                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();

                MessageBox.Show("Atualizado com sucesso!");


            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Deletar_local_estoque(string id_local)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                MySqlConnection conexao = new MySqlConnection(conecta_string);
                conexao.Open();

                string comando_sql;

                comando_sql = "DELETE FROM db_cadastro_local_origem_apara WHERE id_local = " + id_local;

                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();

                MessageBox.Show("Deletado com sucesso!");

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        // -------------------------------------------------------------------------------------------------------

        private void button_salvar_Click(object sender, EventArgs e)
        {
            Salvar_local_estoque();
            Carregar_grid_local_estoque();
            limpar_controles();
        }

        private void button_atualizar_Click(object sender, EventArgs e)
        {
            Atualizar_local_aplica(label_id_local_estoque.Text);
            Carregar_grid_local_estoque();
            limpar_controles();
        }

        private void button_deletar_Click(object sender, EventArgs e)
        {
            Deletar_local_estoque(label_id_local_estoque.Text);
            Carregar_grid_local_estoque();
            limpar_controles();
        }

        private void button_limpar_controles_Click(object sender, EventArgs e)
        {
            limpar_controles();
        }



        private void grid_cad_local_estoque_origem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id_local = grid_cad_local_estoque_origem.CurrentRow.Cells[0].Value.ToString();
            label_id_local_estoque.Text = id_local;
            Carregar_controles(id_local);
        }


    }
}
