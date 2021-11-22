using JP4.Login_Usuario;
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace JP4
{
    public partial class Form_janela_login : Form
    {
        public Form_janela_login()
        {
            InitializeComponent();
        }

        int contador_senha=0;
        public int sucesso_logim = 1;
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
                    if (user == myreader["nome_usuario"].ToString()  && senha == myreader["senha"].ToString())
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
                
                if(erro_senha == 2)
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
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
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
    }
}
