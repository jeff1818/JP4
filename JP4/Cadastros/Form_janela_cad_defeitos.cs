using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace JP4
{
    public partial class Form_janela_cad_defeitos : Form
    {
        public Form_janela_cad_defeitos()
        {
            InitializeComponent();

            Carregar_grid_defeitos();
            Carregar_origem_defeitos();

        }

        private void Carregar_origem_defeitos()
        {
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

                    combo_origem_apara.Items.Add(myreader["local_estoque"].ToString());
                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }
        private void Carregar_origem_defeitos_descri(string local_origem)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_local_origem_apara where local_estoque='" + local_origem + "'";

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {

                    label_desc_origem_apara.Text = myreader["observacao"].ToString();
                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }
        private void Carregar_controles_defeitos(string id_aparas)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_apara where id_aparas=" + id_aparas;

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    text_cod_defeito.Text = myreader["codigo_apara"].ToString();
                    combo_origem_apara.Text = myreader["origem_apara"].ToString();
                    text_descri_apara.Text = myreader["descricao_apara"].ToString();
                    text_observacao.Text = myreader["observacao"].ToString();
                    label_id_defeitos.Text = myreader["id_aparas"].ToString();
                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }
        private void Carregar_grid_defeitos()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_apara";

                MySqlConnection connection = new MySqlConnection(conecta_string);
                MySqlDataAdapter myadapter = new MySqlDataAdapter(comando_sql, connection);
                DataTable dt = new DataTable("db_cadastro_apara");

                myadapter.Fill(dt);

                DataView dv = dt.DefaultView;

                //dv.RowFilter = string.Format("descri_pai like '%{0}%'", item_pai);
                grid_cad_defeitos.DataSource = dv.ToTable();



                connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Filtrar_grid_pesquisar(string codigo_apara, string origem_apara, string descri_apara)
        {

            try
            {

                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_apara";

                MySqlConnection connection = new MySqlConnection(conecta_string);
                MySqlDataAdapter myadapter = new MySqlDataAdapter(comando_sql, connection);
                DataTable dt = new DataTable("estoque_trans");
                myadapter.Fill(dt);
                DataView dv = dt.DefaultView;

                if (codigo_apara != string.Empty)
                {
                    dv.RowFilter = string.Format("CONVERT(num_docum, 'System.String') like '%{0}%'", codigo_apara);
                    grid_cad_defeitos.DataSource = dv.ToTable();
                }

                if (origem_apara != string.Empty)
                {
                    dv.RowFilter = string.Format("CONVERT(data_operac, 'System.String') like '%{0}%'", origem_apara.ToString());
                    grid_cad_defeitos.DataSource = dv.ToTable();
                }

                if (descri_apara != string.Empty)
                {
                    dv.RowFilter = string.Format("operador like '%{0}%'", descri_apara);
                    grid_cad_defeitos.DataSource = dv.ToTable();
                }


                //dv.RowFilter = string.Format("codigo_item like '%{0}%', status_item like '%{1}%', grupo like '%{2}%', descricao_completa like '%{3}%' ", codigo_item, status_item, grupo_item, descri_completa);
                //grid_cadastro.DataSource = dv.ToTable();


                connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }



        }

        //--------------------------------------------------------------------------------
        // Salvar Atualizar

        private void Salvar_defeitos()
        {
            string codigo_apara = text_cod_defeito.Text;
            string descricao_apara = text_descri_apara.Text;
            string origem_apara = combo_origem_apara.Text;
            string observacao = text_observacao.Text;

            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                MySqlConnection conexao = new MySqlConnection(conecta_string);
                conexao.Open();

                string comando_sql;

                comando_sql = "INSERT INTO db_cadastro_apara(codigo_apara, descricao_apara, origem_apara, observacao) " +
                    "VALUES('" + codigo_apara + "','" + descricao_apara + "','" + origem_apara + "','" + observacao + "')";

                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }
        }
        private void Atualizar_defeitos(string id_aparas)
        {
            string codigo_apara = text_cod_defeito.Text;
            string descricao_apara = text_descri_apara.Text;
            string origem_apara = combo_origem_apara.Text;
            string observacao = text_observacao.Text;

            try
            {
                string comando_sql;

                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                MySqlConnection conexao = new MySqlConnection(conecta_string);
                conexao.Open();

                comando_sql = "UPDATE db_cadastro_apara SET " +
                        "codigo_apara='" + codigo_apara +
                        "', descricao_apara='" + descricao_apara +
                        "', origem_apara='" + origem_apara +
                        "', observacao='" + observacao +
                        "' WHERE id_aparas=" + id_aparas;

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
        private void Deletar_defeitos(string id_aparas)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                MySqlConnection conexao = new MySqlConnection(conecta_string);
                conexao.Open();

                string comando_sql;

                comando_sql = "DELETE FROM db_cadastro_apara WHERE id_aparas = " + id_aparas;

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
            text_cod_defeito.Text = string.Empty;
            text_descri_apara.Text = string.Empty;
            combo_origem_apara.Text = string.Empty;
            text_observacao.Text = string.Empty;
        }

        //----------------------------------------------------------------------------

        private void combo_origem_apara_SelectedIndexChanged(object sender, EventArgs e)
        {
            Carregar_origem_defeitos_descri(combo_origem_apara.Text);
        }

        private void button_salvar_Click(object sender, EventArgs e)
        {
            Salvar_defeitos();
            Carregar_grid_defeitos();
            Limpar_controles();
        }

        private void button_deletar_Click(object sender, EventArgs e)
        {
            Deletar_defeitos(label_id_defeitos.Text);
            Carregar_grid_defeitos();
            Limpar_controles();
        }

        private void button_atualizar_Click(object sender, EventArgs e)
        {
            Atualizar_defeitos(label_id_defeitos.Text);
            Carregar_grid_defeitos();
            Limpar_controles();
        }

        private void button_limpar_controles_Click(object sender, EventArgs e)
        {
            Limpar_controles();
        }

        private void button_filtrar_Click(object sender, EventArgs e)
        {

        }
        private void grid_cad_defeitos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id_defeitos = grid_cad_defeitos.CurrentRow.Cells[0].Value.ToString();
            Carregar_controles_defeitos(id_defeitos);

        }


    }
}
