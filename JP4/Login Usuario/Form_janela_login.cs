using JP4.Config;
using JP4.Login_Usuario;
using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace JP4
{
    public partial class Form_janela_login : Form
    {
        public Form_janela_login()
        {
            InitializeComponent();
            Criar_pasta_sistema();

            check_lembrar_senha_pc(Nome_pc());

            // label_status_banco.Text = "";
            Testar_conexao();

        }

        private void Testar_conexao()
        {
            try
            {
                //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                
                IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                string local_default = @"C:\JP4";
                string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                OleDbConnection connection = new OleDbConnection(conecta_string);
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    label_status_banco.Text = "Conectado com sucesso!";

                }
                else
                {
                    label_status_banco.Text = "Não conectado, verifique o local!";

                }
                connection.Close();

            }
            catch (Exception)
            {
                //MessageBox.Show(erro.Message);
            }
        }

        public void Criar_pasta_sistema()
        {
            string folderName = @"C:\JP4";
            // If directory does not exist, create it
            if (!Directory.Exists(folderName))
            {
                Directory.CreateDirectory(folderName);
            }
        }

        private string Nome_pc()
        {
            var name = Environment.MachineName;
            return name;
        }

        int contador_senha = 0;
        public int sucesso_logim = 1;

        private void check_lembrar_senha_pc(string nome_pc)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from 01db_cadastro_usuarios where nome_pc = '" + nome_pc + "'";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    if (nome_pc == myreader["nome_pc"].ToString())
                    {
                        string nome_usuario = myreader["nome_usuario"].ToString();
                        string senha = myreader["senha"].ToString();

                        check_lembra_senha.Checked = true;
                        text_usuario.Text = nome_usuario;
                        text_senha.Text = senha;

                    }
                }
                conexao.Close();
            }
            catch
            {

            }
        }
        private void Lembrar_senha_pc(string nome_usuario, int marcador)
        {
            if(marcador == 0)
            {
                try
                {
                    string nome_pc = Nome_pc();
                    string comando_sql;

                    string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "UPDATE 01db_cadastro_usuarios SET nome_pc='" + nome_pc + "' WHERE nome_usuario ='" + nome_usuario + "'";

                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();

                }
                catch (Exception)
                {
                    MessageBox.Show("Banco de dados não conectado!");
                    check_lembra_senha.Checked = false;
                }
            }

            if(marcador == 1)
            {
                try
                {
                    string nome_pc = string.Empty;
                    string comando_sql;

                    string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "UPDATE 01db_cadastro_usuarios SET nome_pc='" + nome_pc + "' WHERE nome_usuario ='" + nome_usuario + "'";

                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();

                }
                catch (Exception)
                {
                    MessageBox.Show("Banco de dados não conectado!");
                    check_lembra_senha.Checked = false;
                }
            }
           
        }
        private void Login_usuario(string user, string senha)
        {
            try
            {
                int erro_user = 4;
                int erro_senha = 0;

                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from 01db_cadastro_usuarios";// where nome_usuario = '" + user + "'";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    if (user == myreader["nome_usuario"].ToString() && senha == myreader["senha"].ToString())
                    {
                        erro_user = 0;
                    }

                    if (user != myreader["nome_usuario"].ToString() && senha == myreader["senha"].ToString())
                    {
                        erro_user = 1;
                    }

                    if (user == myreader["nome_usuario"].ToString() && senha != myreader["senha"].ToString())
                    {
                        erro_senha = 2;
                    }
                }

                if (erro_user == 0)
                {
                    sucesso_logim = 0;
                    WINSTART janela_inicio = new WINSTART();
                    janela_inicio.Show();
                    janela_inicio.label_nome_usuario.Text = user;
                    this.Hide();
                }


                if (erro_user == 1)
                {
                    MessageBox.Show("Usuário Não existe!");
                    text_usuario.Focus();
                }

                if (erro_senha == 2)
                {
                    MessageBox.Show("Senha incorreta!");
                    contador_senha += 1;

                    if (contador_senha >= 5)
                    {
                        DialogResult resposta = MessageBox.Show(this, "Muitas tentativas, Deseja mudar a senha!?", "Login", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resposta == DialogResult.Yes)
                        {
                            button_troca_senha.Visible = true;
                        }
                    }
                }

                conexao.Close();
            }
            catch
            {
                MessageBox.Show("Banco de dados não encontrado, faça a configuração!");
            }

        }

        private void button_entrar_Click(object sender, EventArgs e)
        {
            Login_usuario(text_usuario.Text, text_senha.Text);
        }

        private void text_senha_Enter(object sender, EventArgs e)
        {
            text_senha.Text = string.Empty;
        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_troca_senha_Click(object sender, EventArgs e)
        {
            Form_troca_senha janela_troca_senha = new Form_troca_senha();
            janela_troca_senha.label_troca_senha_usuario.Text = text_usuario.Text;
            janela_troca_senha.ShowDialog();
        }

        private void button_config_db_Click(object sender, EventArgs e)
        {
            CONF01 janela_config = new CONF01();
            janela_config.ShowDialog();
        }

        private void check_lembra_senha_CheckedChanged(object sender, EventArgs e)
        {
            if (check_lembra_senha.Checked == true)
            {
                Lembrar_senha_pc(text_usuario.Text, 0);
            }

            if (check_lembra_senha.Checked == false)
            {
                Lembrar_senha_pc(text_usuario.Text, 1);
                text_usuario.Text = string.Empty;
                text_senha.Text = string.Empty;
            }



        }
    }
}
