using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace JP4
{
    public partial class Form_janela_cad_local_aplicacao : Form
    {
        public Form_janela_cad_local_aplicacao()
        {
            InitializeComponent();

            Carregar_grid_local_aplicacao();
        }

        private void Carregar_grid_local_aplicacao()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_local_aplicacao";

                MySqlConnection connection = new MySqlConnection(conecta_string);
                MySqlDataAdapter myadapter = new MySqlDataAdapter(comando_sql, connection);
                DataTable dt = new DataTable("db_cadastro_local_aplicacao");

                myadapter.Fill(dt);

                DataView dv = dt.DefaultView;

                //dv.RowFilter = string.Format("descri_pai like '%{0}%'", item_pai);
                grid_cad_local_aplicacao.DataSource = dv.ToTable();



                connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Carregar_controles(string id_local_aplic)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_local_aplicacao where id_local_aplic=" + id_local_aplic;

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    text_local_aplic.Text = myreader["local_aplicao"].ToString();
                    text_descri_local_aplic.Text = myreader["descricao"].ToString();
                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }

        //-------------------------------------------------------------------------------------------------
        // Salvar // Atualizar // Deletar

        private void Salvar_local_aplica()
        {
            string local_aplicao = text_local_aplic.Text;
            string descricao = text_descri_local_aplic.Text;

            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                MySqlConnection conexao = new MySqlConnection(conecta_string);
                conexao.Open();

                string comando_sql;

                comando_sql = "INSERT INTO db_cadastro_local_aplicacao(local_aplicao, descricao) " +
                    "VALUES('" + local_aplicao + "','" + descricao + "')";

                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }
        }
        private void Atualizar_local_aplica(string id_local_aplic)
        {
            string local_aplicao = text_local_aplic.Text;
            string descricao = text_descri_local_aplic.Text;

            try
            {
                string comando_sql;

                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                MySqlConnection conexao = new MySqlConnection(conecta_string);
                conexao.Open();

                comando_sql = "UPDATE db_cadastro_local_aplicacao SET " +
                        "local_aplicao='" + local_aplicao +
                        "', descricao='" + descricao +
                        "' WHERE id_local_aplic=" + id_local_aplic;

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
        private void Deletar_local_aplica(string id_local_aplic)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                MySqlConnection conexao = new MySqlConnection(conecta_string);
                conexao.Open();

                string comando_sql;

                comando_sql = "DELETE FROM db_cadastro_local_aplicacao WHERE id_local_aplic = " + id_local_aplic;

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
        private void Limpar_controles()
        {
            text_local_aplic.Text = string.Empty;
            text_descri_local_aplic.Text = string.Empty;
        }

        //----------------------------------------------------------------------------



        private void button_salvar_Click(object sender, EventArgs e)
        {
            Salvar_local_aplica();
            Carregar_grid_local_aplicacao();
            Limpar_controles();
        }

        private void button_atualizar_Click(object sender, EventArgs e)
        {
            Atualizar_local_aplica(label_id_local_aplica.Text);
            Carregar_grid_local_aplicacao();
            Limpar_controles();
        }

        private void button_deletar_Click(object sender, EventArgs e)
        {
            Deletar_local_aplica(label_id_local_aplica.Text);
            Carregar_grid_local_aplicacao();
            Limpar_controles();
        }

        private void button_limpar_controles_Click(object sender, EventArgs e)
        {
            Limpar_controles();
        }

        private void grid_cad_local_aplicacao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id_local_aplic = grid_cad_local_aplicacao.CurrentRow.Cells[0].Value.ToString();
            label_id_local_aplica.Text = id_local_aplic;
            Carregar_controles(id_local_aplic);
        }
    }
}
