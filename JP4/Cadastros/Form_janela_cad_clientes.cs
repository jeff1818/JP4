using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace JP4
{
    public partial class Form_janela_cad_clientes : Form
    {
        public Form_janela_cad_clientes()
        {
            InitializeComponent();

            Carregar_grid_clientes();
            Carregar_local_destino();

            date_modificacao.Value = DateTime.Today;
        }


        #region Metodos Carregar

        private void Carregar_status()
        {
            //combo_status_cliente.Items.Add = "{Ativado, Desativado}";
        }

        private void Carregar_grid_clientes()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_clientes";

                MySqlConnection connection = new MySqlConnection(conecta_string);
                MySqlDataAdapter myadapter = new MySqlDataAdapter(comando_sql, connection);
                DataTable dt = new DataTable("db_cadastro_clientes");

                myadapter.Fill(dt);

                DataView dv = dt.DefaultView;

                //dv.RowFilter = string.Format("descri_pai like '%{0}%'", item_pai);
                grid_cad_clientes.DataSource = dv.ToTable();

                connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Carregar_controles(string cliente_id)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_clientes where cliente_id= " + cliente_id;

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    combo_status_cliente.Text = myreader["status"].ToString();
                    text_cod_cliente.Text = myreader["codigo_cliente"].ToString();
                    text_nome_reduzido.Text = myreader["cliente_nome"].ToString();
                    text_razao_social.Text = myreader["razao_social"].ToString();
                    text_nome_fantasia.Text = myreader["nome_fantasia"].ToString();
                    date_cadastro.Value = Convert.ToDateTime(myreader["data_cadastro"].ToString());
                    date_modificacao.Value = Convert.ToDateTime(myreader["ultima_modificao"].ToString());
                    richText_observacao.Text = myreader["observacao"].ToString();


                }
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void Carregar_local_destino()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_local_estoque";

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {

                    this.combo_local_destino.Items.Add(myreader["local_estoque"].ToString());
                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }

        #endregion


        //----------------------------------------------------------------------------------------
        #region Salvar / Atualizar / Deletar

        private void Salvar_clientes()
        {
            string status = combo_status_cliente.Text;
            string codigo_cliente = text_cod_cliente.Text;
            string cliente_nome = text_nome_reduzido.Text;
            string razao_social = text_razao_social.Text;
            string nome_fantasia = text_nome_fantasia.Text;
            string data_cadastro = date_cadastro.Value.ToString("yyyy/MM/dd");
            string ultima_modificao = date_modificacao.Value.ToString("yyyy/MM/dd");
            string observacao = richText_observacao.Text;
            string local_destino_cliente = combo_local_destino.Text;

            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                MySqlConnection conexao = new MySqlConnection(conecta_string);
                conexao.Open();

                string comando_sql;

                comando_sql = "INSERT INTO db_cadastro_clientes(status, codigo_cliente, cliente_nome, razao_social,nome_fantasia, data_cadastro , ultima_modificao, observacao, local_destino_cliente) " +
                    "VALUES('" + status + "','" + codigo_cliente + "','" + cliente_nome + "','" + razao_social + "','" + nome_fantasia + "','" + data_cadastro + "','" + ultima_modificao + "','" + observacao + "','" + local_destino_cliente + "')";

                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }
        }
        private void Atualizar_cliente(string cliente_id)
        {
            string status = combo_status_cliente.Text;
            string codigo_cliente = text_cod_cliente.Text;
            string cliente_nome = text_nome_reduzido.Text;
            string razao_social = text_razao_social.Text;
            string nome_fantasia = text_nome_fantasia.Text;

            string data_cadastro = date_cadastro.Value.ToString("yyyy/MM/dd");
            string ultima_modificao = date_modificacao.Value.ToString("yyyy/MM/dd");

            string observacao = richText_observacao.Text;
            string local_destino_cliente = combo_local_destino.Text;

            try
            {
                string comando_sql;

                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                MySqlConnection conexao = new MySqlConnection(conecta_string);
                conexao.Open();

                comando_sql = "UPDATE db_cadastro_clientes SET " +
                        "status='" + status +
                        "', codigo_cliente='" + codigo_cliente +
                        "', cliente_nome='" + cliente_nome +
                        "', razao_social='" + razao_social +
                        "', nome_fantasia='" + nome_fantasia +
                        "', data_cadastro='" + data_cadastro +
                        "', ultima_modificao='" + ultima_modificao +
                        "', observacao='" + observacao +
                        "', local_destino_cliente='" + local_destino_cliente +
                        "' WHERE cliente_id=" + cliente_id;

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
        private void Deletar_cliente(string cliente_id)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                MySqlConnection conexao = new MySqlConnection(conecta_string);
                conexao.Open();

                string comando_sql;

                comando_sql = "DELETE FROM db_cadastro_clientes WHERE cliente_id = " + cliente_id;

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
            combo_status_cliente.Text = string.Empty;
            text_cod_cliente.Text = string.Empty;
            text_nome_reduzido.Text = string.Empty;
            text_razao_social.Text = string.Empty;
            text_nome_fantasia.Text = string.Empty;
            //date_cadastro.Value;
            //date_modificacao.Value;
            richText_observacao.Text = string.Empty;
            combo_local_destino.Text = string.Empty;
        }


        #endregion


        #region Botões de comando

        private void button_salvar_Click(object sender, EventArgs e)
        {
            Salvar_clientes();
            Limpar_controles();
            Carregar_grid_clientes();

        }

        private void button_atualizar_Click(object sender, EventArgs e)
        {
            Atualizar_cliente(label_id_clientes.Text);
            Limpar_controles();
            Carregar_grid_clientes();
        }

        private void button_deletar_Click(object sender, EventArgs e)
        {
            Deletar_cliente(label_id_clientes.Text);
            Limpar_controles();
            Carregar_grid_clientes();
        }

        private void button_limpar_controles_Click(object sender, EventArgs e)
        {
            Limpar_controles();
        }
        #endregion

        private void grid_cad_clientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string cliente_id = grid_cad_clientes.CurrentRow.Cells[0].Value.ToString();
            label_id_clientes.Text = cliente_id;
            Carregar_controles(cliente_id);
        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
