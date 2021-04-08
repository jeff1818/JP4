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

        

        private void login_usuario(string user, string senha)
        {
            try
            {

                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from 01db_cadastro_usuarios";// where nome_usuario = '" + user + "'";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();


                while (myreader.Read())
                {
                    if (myreader["nome_usuario"].ToString() != user)
                    {
                        MessageBox.Show("Usiario não existe!");
                    }
                    else if (myreader["nome_usuario"].ToString() == user && myreader["senha"].ToString() == senha)
                    {
                        //Form_tela_inicial janela_inicio = new Form_tela_inicial();
                        //janela_inicio.Show();
                    }
                    else
                    {
                        MessageBox.Show("Senha errada errada");
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
    }
}
