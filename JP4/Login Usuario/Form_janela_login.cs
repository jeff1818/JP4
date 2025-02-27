﻿using JP4.Config;
using JP4.Login_Usuario;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Windows.Forms;

namespace JP4
{
    public partial class Form_janela_login : Form
    {
        public static class Usuario
        {
            private static string _login = "";
            public static string Login
            {
                get { return _login; }
                set { _login = value; }
            }
        }

        public Form_janela_login()
        {
            InitializeComponent();
            Criar_pasta_sistema();

            check_lembrar_senha_pc_mysql(Nome_pc());
            Testat_sql();

            Acesso_pc(Nome_pc());

            label_nome_cliente.Text = Carregar_nome_cliente(Nome_pc());
            label_produto_id.Text = Carrega_produto_id(label_nome_cliente.Text);

            //Download_file();
            //Check_update();



        }

        #region Area de Upload



        public void Download_file()
        {
            progressBar_inicial.Visible = true;

            string urlArquivo = "https://onedrive.live.com/download?cid=37ABC5C967094270&resid=37ABC5C967094270%2143546&authkey=ALBey4pELk566qg";
            string caminhoArquivo = @"C:\JP4\JP4_setup.zip";

            WebClient client = new WebClient();
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(barra_status_download);

            client.DownloadFile(urlArquivo, caminhoArquivo);

            Descompactar_arquivo();

        }
        private void barra_status_download(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar_inicial.Value = e.ProgressPercentage;
        }
        private void Descompactar_arquivo()
        {
            try
            {
                System.Threading.Thread.Sleep(5000);
                File.Delete(@"C:\JP4\setup.exe");

                string zipPath = @"C:\JP4\JP4_setup.zip";
                string extractPath = @"C:\JP4\";
                ZipFile.ExtractToDirectory(zipPath, extractPath);
                File.Delete(@"C:\JP4\JP4_setup.zip");

                Process.Start(@"C:\JP4\setup.exe");
                this.Close();
            }
            catch
            {
                Process.Start(@"C:\JP4\setup.exe");
                this.Close();
            }
        }


        #endregion



        // ---------------------------------------------------

        #region Area de licença de sofware

        // Vincular o nome do computador ao usuário que "comprou"
        // Verificar se ele tem permissão de usar
        // Gerar serial number 
        // verificar se esta liberador ou não

        private string Carregar_nome_cliente(string nome_pc)
        {
            // 02db_cadastro_computadores

            string nome_cliente = string.Empty;
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from 02db_cadastro_computadores where nome_pc= '" + nome_pc + "'";

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    nome_cliente = myreader["nome_cliente"].ToString();
                }

                conexao.Close();
            }
            catch { }

            return nome_cliente;
        }
        private string Carrega_produto_id(string nome_cliente)
        {

            string produto_hash = string.Empty;

            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from 02db_cadastro_computadores where nome_cliente= '" + nome_cliente + "'";

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    if (myreader["produto_hash"].ToString() == CalculaHash(Nome_pc()))
                    {
                        produto_hash = myreader["produto_hash"].ToString();
                    }

                }

                conexao.Close();
            }
            catch { }

            if (produto_hash == string.Empty)
            {
                label_nome_cliente.Text = "Sem acesso!";
            }

            return produto_hash;
        }
        private string Verificar_pc_cadastrado(string nome_pc)
        {
            string check_pc = "N";
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from 02db_cadastro_computadores where nome_pc= '" + nome_pc + "'";

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    if (myreader["produto_hash"].ToString() == CalculaHash(Nome_pc()) & myreader["controle_acesso"].ToString() == "S")
                    {
                        check_pc = "S";
                    }
                }

                conexao.Close();
            }
            catch { }

            return check_pc;

        }
        public string CalculaHash(string Senha)
        {
            try
            {
                System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(Senha);
                byte[] hash = md5.ComputeHash(inputBytes);
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("X2"));
                }
                return sb.ToString(); // Retorna senha criptografada 
            }
            catch (Exception)
            {
                return null; // Caso encontre erro retorna nulo
            }
        }
        private void Acesso_pc(string pc_name)
        {
            string data_entrada = DateTime.Today.ToString("yyyy/MM/dd");
            string hora_entrada = DateTime.Now.ToString("HH:mm:ss");
            string maquina_md5 = CalculaHash(pc_name);
            string user_name_pc = Environment.UserName;

            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                MySqlConnection conexao = new MySqlConnection(conecta_string);
                conexao.Open();

                string comando_sql;

                comando_sql = "INSERT INTO 03db_controle_acesso(nome_pc, data_entrada, hora_entrada, maquina_md5, user_name_pc) " +
                    "VALUES('" + pc_name + "','" + data_entrada + "','" + hora_entrada + "','" + maquina_md5 + "','" + user_name_pc + "')";

                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }

        }

        #endregion



        // -----------------------------------------------------------------------
        private void check_lembrar_senha_pc_mysql(string nome_pc)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from 01db_cadastro_usuarios where nome_pc = '" + nome_pc + "'";

                MySqlConnection conexao = new MySqlConnection(conecta_string);

                //OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);

                //OleDbDataReader myreader;
                MySqlDataReader myreader;
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
        private void Testat_sql()
        {
            try
            {
                //var connString = @"Server=db-gestao-prod.mysql.uhserver.com;Database=db_gestao_prod;Uid=jefersondev;Pwd='h4ck3rtcho!@';Connect Timeout=30;";
                var connString = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                var connection = new MySqlConnection(connString);
                var command = connection.CreateCommand();
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

            }


            /*
                        try
                        {
                            connection.Open();
                            command.CommandText = "INSERT INTO db_teste (nome, idade) VALUES ('Carol', '31')";
                            command.ExecuteNonQuery();
                        }
                        finally
                        {
                            if (connection.State == ConnectionState.Open)
                                connection.Close();
                        }
            */

        }
        private void Lembrar_senha_pc_mysql(string nome_usuario, int marcador)
        {
            if (marcador == 0)
            {
                try
                {
                    string nome_pc = Nome_pc();
                    string comando_sql;

                    string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    MySqlConnection conexao = new MySqlConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "UPDATE 01db_cadastro_usuarios SET nome_pc='" + nome_pc + "' WHERE nome_usuario ='" + nome_usuario + "'";

                    MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();

                }
                catch (Exception)
                {
                    MessageBox.Show("Banco de dados não conectado!");
                    check_lembra_senha.Checked = false;
                }
            }

            if (marcador == 1)
            {
                try
                {
                    string nome_pc = string.Empty;
                    string comando_sql;

                    string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    MySqlConnection conexao = new MySqlConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "UPDATE 01db_cadastro_usuarios SET nome_pc='" + nome_pc + "' WHERE nome_usuario ='" + nome_usuario + "'";

                    MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
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
        private void Login_usuario_mysql(string user, string senha)
        {
            try
            {
                int erro_user = 4;
                int erro_senha = 0;

                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from 01db_cadastro_usuarios";// where nome_usuario = '" + user + "'";

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
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

                    Usuario.Login = user;

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

        // -----------------------------------------------------------------------

        private void Testar_conexao()
        {
            try
            {

                //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;

                //
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
            if (marcador == 0)
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

            if (marcador == 1)
            {
                try
                {
                    string nome_pc = string.Empty;
                    string comando_sql;

                    //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                    string local_default = @"C:\JP4";
                    string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

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

                //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;

                IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                string local_default = @"C:\JP4";
                string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

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

                    Usuario.Login = user;

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
            if (Verificar_pc_cadastrado(Nome_pc()) == "S")
            {



                Login_usuario_mysql(text_usuario.Text, text_senha.Text);


            }
            else
            {
                MessageBox.Show("Computador sem permissão de uso!");
            }

            //Login_usuario_mysql(text_usuario.Text, text_senha.Text);

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
                //Lembrar_senha_pc(text_usuario.Text, 0);
                Lembrar_senha_pc_mysql(text_usuario.Text, 0);
            }

            if (check_lembra_senha.Checked == false)
            {
                //Lembrar_senha_pc(text_usuario.Text, 1);
                Lembrar_senha_pc_mysql(text_usuario.Text, 1);
                text_usuario.Text = string.Empty;
                text_senha.Text = string.Empty;
            }



        }
    }
}
