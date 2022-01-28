using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace JP4.Login_Usuario
{
    public partial class Form_troca_senha : Form
    {
        public Form_troca_senha()
        {
            InitializeComponent();
        }


        private void Salvar_senha(string nome_usuario, string senha)
        {
            try
            {
                string comando_sql;

                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                MySqlConnection conexao = new MySqlConnection(conecta_string);
                conexao.Open();

                comando_sql = "UPDATE 01db_cadastro_usuarios SET senha='" + senha + "' WHERE nome_usuario ='" + nome_usuario + "'";

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


        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_salvar_Click(object sender, EventArgs e)
        {
            if (textBox_senha.Text == textBox_confirma_senha.Text)
            {
                Salvar_senha(label_troca_senha_usuario.Text, textBox_confirma_senha.Text);
            }
            if (textBox_senha.Text != textBox_confirma_senha.Text)
            {
                MessageBox.Show("As senhas não são iguais!");
            }

        }

        private void textBox_confirma_senha_TextChanged(object sender, EventArgs e)
        {
            if (textBox_senha.Text == textBox_confirma_senha.Text)
            {
                textBox_confirma_senha.BackColor = Color.LightGreen;
            }
        }
    }
}
