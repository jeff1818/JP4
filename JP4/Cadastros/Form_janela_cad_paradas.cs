using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace JP4.Cadastros
{
    public partial class Form_janela_cad_paradas : Form
    {
        public Form_janela_cad_paradas()
        {
            InitializeComponent();
            Carregar_grid_parada();
            Carregar_origem_maquina();
        }


        #region Carregar controles 
        private void Carregar_controles(string id_paradas)
        {

            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_paradas where id_paradas=" + id_paradas;

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    text_cod_paradas.Text = myreader["codigo_parada"].ToString();
                    text_descri_parada.Text = myreader["descricao_parada"].ToString();
                    rich_observacao.Text = myreader["observacao"].ToString();
                    combo_origem_parada.Text = myreader["origem_apara"].ToString();
                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }

        }
        private void Carregar_origem_maquina()
        {
            //db_cadastro_local_origem_apara
            //local_estoque;

            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_local_origem_apara";

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    combo_origem_parada.Items.Add(myreader["local_estoque"].ToString());

                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }



        }
        private void Carregar_grid_parada()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_paradas";

                MySqlConnection connection = new MySqlConnection(conecta_string);
                MySqlDataAdapter myadapter = new MySqlDataAdapter(comando_sql, connection);
                DataTable dt = new DataTable("db_cadastro_paradas");

                myadapter.Fill(dt);
                DataView dv = dt.DefaultView;

                //dv.RowFilter = string.Format("descri_pai like '%{0}%'", item_pai);
                grid_cad_paradas.DataSource = dv.ToTable();

                connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }


        }

        #endregion


        #region Salvar // Atualizar // Deletar // Limpar

        private void Salvar_parada_mq()
        {
            string codigo_parada = text_cod_paradas.Text;
            string descricao_parada = text_descri_parada.Text;
            string observacao = rich_observacao.Text;
            string origem_apara = combo_origem_parada.Text;

            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                MySqlConnection conexao = new MySqlConnection(conecta_string);
                conexao.Open();

                string comando_sql;

                comando_sql = "INSERT INTO db_cadastro_paradas(codigo_parada, descricao_parada, observacao, origem_apara) " +
                    "VALUES('" + codigo_parada + "','" + descricao_parada + "','" + observacao + "','" + origem_apara + "')";

                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();

                MessageBox.Show("Salvo com sucesso!");

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }

        }
        private void Atualizar_parada_mq(string id_paradas)
        {
            string codigo_parada = text_cod_paradas.Text;
            string descricao_parada = text_descri_parada.Text;
            string observacao = rich_observacao.Text;
            string origem_apara = combo_origem_parada.Text;

            //db_cadastro_paradas

            try
            {
                string comando_sql;

                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                MySqlConnection conexao = new MySqlConnection(conecta_string);
                conexao.Open();

                comando_sql = "UPDATE db_cadastro_paradas SET " +
                        "codigo_parada='" + codigo_parada +
                        "', descricao_parada='" + descricao_parada +
                        "', observacao='" + observacao +
                        "', origem_apara='" + origem_apara +
                        "' WHERE id_paradas=" + id_paradas;

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

        private void Deletar_parada_mq(string id_paradas)
        {
            // db_cadastro_paradas
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                MySqlConnection conexao = new MySqlConnection(conecta_string);
                conexao.Open();

                string comando_sql;

                comando_sql = "DELETE FROM db_cadastro_paradas WHERE id_paradas = " + id_paradas;

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
            text_cod_paradas.Text = string.Empty;
            text_descri_parada.Text = string.Empty;
            rich_observacao.Text = string.Empty;
            combo_origem_parada.Text = string.Empty;
            label_id_cad_parada.Text = string.Empty;


        }


        #endregion

        private void button_salvar_Click(object sender, EventArgs e)
        {
            Salvar_parada_mq();
            Carregar_grid_parada();
            Limpar_controles();
        }

        private void button_atualizar_Click(object sender, EventArgs e)
        {
            Atualizar_parada_mq(label_id_cad_parada.Text);
            Carregar_grid_parada();
            Limpar_controles();
        }

        private void button_deletar_Click(object sender, EventArgs e)
        {
            Deletar_parada_mq(label_id_cad_parada.Text);
            Carregar_grid_parada();
            Limpar_controles();
        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grid_cad_paradas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id_paradas = grid_cad_paradas.CurrentRow.Cells[0].Value.ToString();
            label_id_cad_parada.Text = id_paradas;
            Carregar_controles(id_paradas);
        }
    }
}
