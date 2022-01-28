using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace JP4
{
    public partial class Form_janela_cad_operacao : Form
    {
        public Form_janela_cad_operacao()
        {
            InitializeComponent();

            Carregar_grid_cad_operacao();
        }


        //db_cadastro_operacao

        //id_operacao
        //codigo
        //descricao
        //tipo_operacao
        //nome_prog

        //---------------------------------------------------------------------------------------------------------------------
        // Carregar Controles
        private void Carregar_grid_cad_operacao()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_operacao";

                MySqlConnection connection = new MySqlConnection(conecta_string);
                MySqlDataAdapter myadapter = new MySqlDataAdapter(comando_sql, connection);
                DataTable dt = new DataTable("db_cadastro_operacao");

                myadapter.Fill(dt);
                DataView dv = dt.DefaultView;

                //dv.RowFilter = string.Format("descri_pai like '%{0}%'", item_pai);
                grid_cad_operacao.DataSource = dv.ToTable();

                connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Carregar_controles(string id_operacao)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_operacao where id_operacao=" + id_operacao;

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    text_cod_operacao.Text = myreader["codigo"].ToString();
                    text_descri_operacao.Text = myreader["descricao"].ToString();
                    combo_tipo_operacao.Text = myreader["tipo_operacao"].ToString();
                    combo_programa_destino.Text = myreader["nome_prog"].ToString();
                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }


        //---------------------------------------------------------------------------------------------------------------------
        // Salvar / Atualizar / Deleteza / Limpar

        private void limpar_controles()
        {
            text_cod_operacao.Text = string.Empty;
            text_descri_operacao.Text = string.Empty;
            combo_tipo_operacao.Text = string.Empty;
            combo_programa_destino.Text = string.Empty;

        }
        private void Salvar_cod_operacao()
        {
            string codigo = text_cod_operacao.Text;
            string descricao = text_descri_operacao.Text;
            string tipo_operacao = combo_tipo_operacao.Text;
            string nome_prog = combo_programa_destino.Text;

            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                MySqlConnection conexao = new MySqlConnection(conecta_string);
                conexao.Open();

                string comando_sql;

                comando_sql = "INSERT INTO db_cadastro_operacao(codigo, descricao, tipo_operacao, nome_prog) " +
                    "VALUES('" + codigo + "','" + descricao + "','" + tipo_operacao + "','," + nome_prog + "')";

                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }
        }
        private void Atualizar_cod_operacao(string id_operacao)
        {
            string codigo = text_cod_operacao.Text;
            string descricao = text_descri_operacao.Text;
            string tipo_operacao = combo_tipo_operacao.Text;
            string nome_prog = combo_programa_destino.Text;

            try
            {
                string comando_sql;

                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                MySqlConnection conexao = new MySqlConnection(conecta_string);
                conexao.Open();

                comando_sql = "UPDATE db_cadastro_operacao SET " +
                        "codigo='" + codigo +
                        "', descricao='" + descricao +
                        "', tipo_operacao='" + tipo_operacao +
                        "', nome_prog='" + nome_prog +
                        "' WHERE id_operacao=" + id_operacao;

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
        private void Deletar_cod_operacao(string id_operacao)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                MySqlConnection conexao = new MySqlConnection(conecta_string);
                conexao.Open();

                string comando_sql;

                comando_sql = "DELETE FROM db_cadastro_operacao WHERE id_operacao = " + id_operacao;

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

        //---------------------------------------------------------------------------------------------------------------------
        private void button_salvar_Click(object sender, EventArgs e)
        {
            Salvar_cod_operacao();
            Carregar_grid_cad_operacao();
            limpar_controles();
        }

        private void button_atualizar_Click(object sender, EventArgs e)
        {
            Atualizar_cod_operacao(label_id_cad_operacao.Text);
            Carregar_grid_cad_operacao();
            limpar_controles();
        }

        private void button_deletar_Click(object sender, EventArgs e)
        {
            Deletar_cod_operacao(label_id_cad_operacao.Text);
            Carregar_grid_cad_operacao();
            limpar_controles();
        }

        private void button_limpar_controles_Click(object sender, EventArgs e)
        {
            limpar_controles();
        }

        private void grid_cad_operacao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id_operacao = grid_cad_operacao.CurrentRow.Cells[0].Value.ToString();
            label_id_cad_operacao.Text = id_operacao;
            Carregar_controles(id_operacao);
        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
