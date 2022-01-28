using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace JP4
{
    public partial class Form_janela_cad_grupo_estoque : Form
    {
        public Form_janela_cad_grupo_estoque()
        {
            InitializeComponent();

            Carregar_grid_grupo_estoque();
        }

        // db_cadastro_grupo_estoque
        // codigo_grupo
        // nome_grupo
        // descricao


        private void Carregar_grid_grupo_estoque()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_grupo_estoque";

                MySqlConnection connection = new MySqlConnection(conecta_string);
                MySqlDataAdapter myadapter = new MySqlDataAdapter(comando_sql, connection);
                DataTable dt = new DataTable("db_cadastro_grupo_estoque");

                myadapter.Fill(dt);

                DataView dv = dt.DefaultView;

                //dv.RowFilter = string.Format("descri_pai like '%{0}%'", item_pai);
                grid_cad_grupo_estoque.DataSource = dv.ToTable();

                connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Carregar_controles(string id_grupo_estoque)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_grupo_estoque where id_grupo_estoque= " + id_grupo_estoque;

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    text_cod_grupo_estoque.Text = myreader["codigo_grupo"].ToString();
                    text_nome_grupo_estoque.Text = myreader["nome_grupo"].ToString();
                    text_descr_grupo_estoque.Text = myreader["descricao"].ToString();

                }
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        //----------------------------------------------------------------------------------------
        // Salvar / Atualizar / Limpar 
        private void Salvar_defeitos()
        {
            string codigo_grupo = text_cod_grupo_estoque.Text;
            string nome_grupo = text_nome_grupo_estoque.Text;
            string descricao = text_descr_grupo_estoque.Text;


            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                MySqlConnection conexao = new MySqlConnection(conecta_string);
                conexao.Open();

                string comando_sql;

                comando_sql = "INSERT INTO db_cadastro_grupo_estoque(codigo_grupo, nome_grupo, descricao) " +
                    "VALUES('" + codigo_grupo + "','" + nome_grupo + "','" + descricao + "')";

                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }
        }
        private void Atualizar_grupo_estoque(string id_grupo_estoque)
        {
            string codigo_grupo = text_cod_grupo_estoque.Text;
            string nome_grupo = text_nome_grupo_estoque.Text;
            string descricao = text_descr_grupo_estoque.Text;

            try
            {
                string comando_sql;

                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                MySqlConnection conexao = new MySqlConnection(conecta_string);
                conexao.Open();

                comando_sql = "UPDATE db_cadastro_grupo_estoque SET " +
                        "codigo_grupo='" + codigo_grupo +
                        "', nome_grupo='" + nome_grupo +
                        "', descricao='" + descricao +
                        "' WHERE id_grupo_estoque=" + id_grupo_estoque;

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
        private void Deletar_grupo_estoque(string id_grupo_estoque)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                MySqlConnection conexao = new MySqlConnection(conecta_string);
                conexao.Open();

                string comando_sql;

                comando_sql = "DELETE FROM db_cadastro_grupo_estoque WHERE id_grupo_estoque = " + id_grupo_estoque;

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
            text_cod_grupo_estoque.Text = string.Empty;
            text_nome_grupo_estoque.Text = string.Empty;
            text_descr_grupo_estoque.Text = string.Empty;
        }


        // ----------------------------------------------------------------------------------------
        private void grid_cad_grupo_estoque_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id_grupo_estoque = grid_cad_grupo_estoque.CurrentRow.Cells[0].Value.ToString();
            label_id_grupo_estoque.Text = id_grupo_estoque;
            Carregar_controles(id_grupo_estoque);
        }

        //-------------------------------------------------------------------------------------------
        //------------------------     Botões  ------------------------------------------------------
        //-------------------------------------------------------------------------------------------

        private void button_salvar_Click(object sender, EventArgs e)
        {
            Salvar_defeitos();
            Carregar_grid_grupo_estoque();
            Limpar_controles();
        }

        private void button_atualizar_Click(object sender, EventArgs e)
        {
            Atualizar_grupo_estoque(label_id_grupo_estoque.Text);
            Carregar_grid_grupo_estoque();
            Limpar_controles();
        }

        private void button_deletar_Click(object sender, EventArgs e)
        {
            Deletar_grupo_estoque(label_id_grupo_estoque.Text);
            Carregar_grid_grupo_estoque();
            Limpar_controles();
        }

        private void button_limpar_controles_Click(object sender, EventArgs e)
        {
            Limpar_controles();
        }

        //-------------------------------------------------------------------------------------------
    }
}
