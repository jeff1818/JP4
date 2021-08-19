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
        private void login_usuario(string user, string senha)
        {
            try
            {
                int erro_user = 1;
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


                    if (user == myreader["nome_usuario"].ToString() && senha != myreader["senha"].ToString())                    
                    {
                        
                        erro_senha = 2;
                    }
                    
                }


                if(erro_user == 1)
                {
                    MessageBox.Show("Usuário Não existe!");
                }

                if(erro_user == 0)
                {

                    sucesso_logim = 0;
                    Form_tela_inicial janela_inicio = new Form_tela_inicial();
                    janela_inicio.Show();
                    janela_inicio.label_nome_usuario.Text = user;
                    this.Hide();
                }

                if(erro_senha == 2)
                {
                    MessageBox.Show("Senha incorreta!");

                    contador_senha += 1;


                    if (contador_senha >= 5)
                    {
                        MessageBox.Show("");
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

            login_usuario(text_usuario.Text, text_senha.Text);

        }

        private void text_senha_Enter(object sender, EventArgs e)
        {
            text_senha.Text = string.Empty;
        }
    }
}
