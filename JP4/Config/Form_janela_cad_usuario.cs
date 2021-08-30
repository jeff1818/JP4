using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JP4.Config
{
    public partial class Form_janela_cad_usuario : Form
    {
        public Form_janela_cad_usuario()
        {
            InitializeComponent();

            Carregar_grid_usuario();
            Carregar_empresa_db();
        }

        // Cadastrar usuarios
        // Criar senhas 
        // dar permissões em programas especificos - por enquanto só na area de cadastro
        

        #region Carregar controles

        private void Carregar_grid_usuario()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from 01db_cadastro_usuarios";

                OleDbConnection connection = new OleDbConnection(conecta_string);
                OleDbDataAdapter myadapter = new OleDbDataAdapter(comando_sql, connection);
                DataTable dt = new DataTable("01db_cadastro_usuarios");

                myadapter.Fill(dt);
                DataView dv = dt.DefaultView;

                //dv.RowFilter = string.Format("descri_pai like '%{0}%'", item_pai);
                grid_cad_usuario.DataSource = dv.ToTable();

                connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Carregar_empresa_db()
        {
            try
            {

                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;

                string comando_sql = "select * from db_cadastro_empresas";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
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
        private void Carregar_controles(string id_usuario)
        {
            

            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from 01db_cadastro_usuarios where id_usuario=" + id_usuario;

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    combo_empresa.Text = myreader["empresa"].ToString();
                    text_nome_user.Text = myreader["nome_usuario"].ToString();
                    text_senha_user.Text = myreader["senha"].ToString();
                    text_dica_senha.Text = myreader["dica_senha"].ToString();                    
                    combo_tipo_user.Text = myreader["user_type"].ToString();
                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }

        #endregion


        #region Salvar // Atualizar // Deletar // Limpar 

        private void Desbloquear_controles()
        {
            combo_empresa.Enabled = false;
            text_nome_user.Enabled = false;
            text_senha_user.Enabled = false;
            text_dica_senha.Enabled = false;
            combo_tipo_user.Enabled = false;
        }
        private void Bloquear_controles()
        {
            combo_empresa.Enabled = true;
            text_nome_user.Enabled = true;
            text_senha_user.Enabled = true;
            text_dica_senha.Enabled = true;
            combo_tipo_user.Enabled = true;
        }
        private void Limpar_controles()
        {
            combo_empresa.Text = string.Empty;
            text_nome_user.Text = string.Empty;
            text_senha_user.Text = string.Empty;
            text_dica_senha.Text = string.Empty;
            combo_tipo_user.Text = string.Empty;
        }
        private void Salvar_usuer()
        {
            //id_usuario
            string empresa = combo_empresa.Text;
            string nome_usuario = text_nome_user.Text;
            string senha = text_senha_user.Text;
            string dica_senha = text_dica_senha.Text;
            int lembrar_senha = 0;
            DateTime data_cadastro = DateTime.Today;
            int primeiro_login = 0;
            string user_type = combo_tipo_user.Text;


            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                OleDbConnection conexao = new OleDbConnection(conecta_string);
                conexao.Open();

                string comando_sql;

                comando_sql = "INSERT INTO 01db_cadastro_usuarios(empresa, nome_usuario, senha, dica_senha, lembrar_senha, data_cadastro, primeiro_login, user_type) " +
                    "VALUES('" + empresa + "','" + nome_usuario + "','" + senha + "','" + dica_senha+ "','"+ lembrar_senha + "','"+ data_cadastro + "','"+ primeiro_login + "','"+ user_type + "')";

                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();

                MessageBox.Show("Salvo com sucesso!");

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }



        }
        private void Atualizar_usuer(string id_usuario)
        {
            //id_usuario
            string empresa = combo_empresa.Text;
            string nome_usuario = text_nome_user.Text;
            string senha = text_senha_user.Text;
            string dica_senha = text_dica_senha.Text;
            int lembrar_senha = 0;
            DateTime data_cadastro = DateTime.Today;
            int primeiro_login = 0;
            string user_type = combo_tipo_user.Text;


            try
            {
                string comando_sql;

                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                OleDbConnection conexao = new OleDbConnection(conecta_string);
                conexao.Open();

                comando_sql = "UPDATE 01db_cadastro_usuarios SET " +
                        "empresa='" + empresa +
                        "', nome_usuario='" + nome_usuario +
                        "', senha='" + senha +
                        "', dica_senha='" + dica_senha +
                        "', lembrar_senha='" + lembrar_senha +
                        "', data_cadastro='" + data_cadastro +
                        "', primeiro_login='" + primeiro_login +
                        "', user_type='" + user_type +
                        "' WHERE id_usuario=" + id_usuario;

                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();

                MessageBox.Show("Atualizado com sucesso!");


            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Deletar_user(string id_usuario)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                OleDbConnection conexao = new OleDbConnection(conecta_string);
                conexao.Open();

                string comando_sql;

                comando_sql = "DELETE FROM 01db_cadastro_usuarios WHERE id_usuario = " + id_usuario;

                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();

                MessageBox.Show("Deletado com sucesso!");

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }


        #endregion

        #region Permisao de usuarios



        #endregion

        private void button_salvar_Click(object sender, EventArgs e)
        {
            Salvar_usuer();
            Carregar_grid_usuario();            
            Limpar_controles();
        }

        private void button_atualizar_Click(object sender, EventArgs e)
        {
            Atualizar_usuer(label_id_cad_usuario.Text);
            Carregar_grid_usuario();
            Limpar_controles();
        }

        private void button_deletar_Click(object sender, EventArgs e)
        {
            //label_id_cad_usuario
            Deletar_user(label_id_cad_usuario.Text);
            Carregar_grid_usuario();
            Limpar_controles();
        }

        private void button_limpar_controles_Click(object sender, EventArgs e)
        {

        }

        private void button_filtrar_Click(object sender, EventArgs e)
        {

        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grid_cad_usuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id_usuario = grid_cad_usuario.CurrentRow.Cells[0].Value.ToString();
            label_id_cad_usuario.Text = id_usuario;
            Carregar_controles(id_usuario);
        }

        
    }
}
