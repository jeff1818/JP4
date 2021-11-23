using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;
using JP4.Config;

namespace JP4
{
    public partial class CONF01 : Form
    {
        public CONF01()
        {

            InitializeComponent();
            
            

            text_endereco.Text = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
            text_local_arquivo_ordem.Text = Properties.Settings.Default.local_arquivo_excel;
                        
            label_endereco_backup.Text = Properties.Settings.Default.caminho_backup;
            label_origem_backup.Text = Properties.Settings.Default.origem_backup;
            label_dt_ultimo_backup.Text = Properties.Settings.Default.dt_ultimo_backup;

            //gravar_configuracao_ini();

        }

        #region Metodos Configuração INI
        private void gravar_configuracao_ini()
        {
            IniFile config_ini = new IniFile(@"C:\JP4", "config_app");

            config_ini.IniWriteString("STRING_DB", "local_banco", text_endereco.Text);
            config_ini.IniWriteString("RELATORIO", "local_relatorio", text_local_arquivo_ordem.Text);

            config_ini.IniWriteString("LOCAL_ORIGEM_BK", "local_origem_bk", label_origem_backup.Text);
            config_ini.IniWriteString("LOCAL_DESTINO_BK", "local_destino_bk", label_endereco_backup.Text);

            config_ini.IniWriteString("DT_ULTIMO_BK", "data_ultimo_bk", label_dt_ultimo_backup.Text);


        }



        #endregion


        #region Metodos de Atualização



        private void Verifica_update()
        {
            DialogResult resposta = MessageBox.Show(this, "Deseja Verificar Atualização?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(resposta == DialogResult.Yes)
            {
                WINSTART janela_inicio = new WINSTART();
                janela_inicio.Check_update();
            }
        }

        #endregion

        #region Arquivo TXT

        public void Ler_arquivo_config()
        {
            
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Jarvis\OneDrive\Visual - basic c#\banco\config.txt");

            //label_linha01.Text = lines[0];
            //label_linha02.Text = lines[1];
            //label_linha03.Text = lines[2];
            //label_linha04.Text = lines[3];


        }


       

        #endregion


        #region Fazer backup do banco de dados Acess


        public void fazer_backup()
        {
            try
            {
                string dataInicial = Properties.Settings.Default.dt_ultimo_backup;
                string dataFinal = Convert.ToString(DateTime.Today);

                TimeSpan date = Convert.ToDateTime(dataFinal) - Convert.ToDateTime(dataInicial);
                int totalDias = date.Days;
                //MessageBox.Show(totalDias.ToString());

                if (totalDias > 2)
                {
                    backup_db();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao fazer backup!");
            }

            
        }
        private void criar_pasta_backup(string local_db)
        {
            string folderName = local_db + @"\db_backup";
            // If directory does not exist, create it
            if (!Directory.Exists(folderName))
            {
                Directory.CreateDirectory(folderName);
            }
        }
        private void backup_db()
        {

            try
            {
                string fileName = "db_aplicativo_kpi.mdb";
                string sourcePath = label_origem_backup.Text;
                string targetPath = label_endereco_backup.Text;

                // Use Path class to manipulate file and directory paths.
                string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
                string destFile = System.IO.Path.Combine(targetPath, fileName);
                                
                // To copy a file to another location and
                // overwrite the destination file if it already exists.
                System.IO.File.Copy(sourceFile, destFile, true);

                // MessageBox.Show("Backup feito com sucesso!");


                label_dt_ultimo_backup.Text = DateTime.Today.ToString("dd/MM/yyyy");
                Salvar_ultima_data_backup();
                //Reset_aplicativo();


            }
            catch (Exception)
            {
                MessageBox.Show("Source path does not exist!");
            }

        }
        private void Salvar_ultima_data_backup()
        {
            // JP4.Properties.Settings.dt_ultimo_backup
            try
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var connectionString = (ConnectionStringsSection)config.GetSection("connectionStrings");
                connectionString.ConnectionStrings["JP4.Properties.Settings.dt_ultimo_backup"].ConnectionString = label_dt_ultimo_backup.Text;
                config.Save();
                ConfigurationManager.RefreshSection("connectionStrings");

                MessageBox.Show("Salvo com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao salvar origem do banco ! || " + erro.Message);
            }

        }
        private void Salvar_origem_backup()
        {

            try
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var connectionString = (ConnectionStringsSection)config.GetSection("connectionStrings");
                connectionString.ConnectionStrings["JP4.Properties.Settings.origem_backup"].ConnectionString = label_origem_backup.Text;
                config.Save();
                ConfigurationManager.RefreshSection("connectionStrings");                
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao salvar origem do banco ! || " + erro.Message);
            }

        }
        private void Salvar_local_backup()
        {

            try
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var connectionString = (ConnectionStringsSection)config.GetSection("connectionStrings");
                connectionString.ConnectionStrings["JP4.Properties.Settings.caminho_backup"].ConnectionString = label_endereco_backup.Text;
                config.Save();
                ConfigurationManager.RefreshSection("connectionStrings");
                
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao salvar o local do backup! || " + erro.Message);
            }

        }
        private string Procurar_pasta_backup()
        {
            string local_pasta;
            //string nome_arquivo;
            string endereco_completo = string.Empty;
            OpenFileDialog folderBrowser = new OpenFileDialog();

            folderBrowser.ValidateNames = true;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;

            folderBrowser.FileName = "Localizar Arquivo";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                local_pasta = Path.GetDirectoryName(folderBrowser.FileName);
                //nome_arquivo = Path.GetFileName(folderBrowser.FileName);

                // endereco_completo = texto_conecta + @"""" + local_pasta + @"\" + nome_arquivo + @"""";
                endereco_completo = local_pasta; //+ @"\" + nome_arquivo ; //"; providerName =" + '\u0022' + "System.Data.OleDb"+'\u0022';
            }

            return endereco_completo;
        }

        #endregion

        private void Testar_conexao()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                OleDbConnection connection = new OleDbConnection(conecta_string);
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    label_status_con.Text = "Conectado com sucesso!";

                }
                else
                {
                    label_status_con.Text = "Não conectado, verifique o local!";

                }
                connection.Close();

            }
            catch (Exception)
            {
                //MessageBox.Show(erro.Message);
            }
        }

        // Busca local do Banco de dados
        private string Procurar_pasta()
        {
            string local_pasta;
            string nome_arquivo;
            string endereco_completo = string.Empty;
            string texto_conecta = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=";


            OpenFileDialog folderBrowser = new OpenFileDialog();

            folderBrowser.ValidateNames = true;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;

            folderBrowser.FileName = "Localizar Arquivo";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                local_pasta = Path.GetDirectoryName(folderBrowser.FileName);
                nome_arquivo = Path.GetFileName(folderBrowser.FileName);

                // endereco_completo = texto_conecta + @"""" + local_pasta + @"\" + nome_arquivo + @"""";
                endereco_completo = texto_conecta + '\u0022' + local_pasta + @"\" + nome_arquivo + '\u0022'; //"; providerName =" + '\u0022' + "System.Data.OleDb"+'\u0022';
                label_origem_backup.Text = local_pasta;
                //Salvar_origem_backup();
                criar_pasta_backup(local_pasta);
            }

            return endereco_completo;
        }
        private void Salvar_local()
        {

            try
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var connectionString = (ConnectionStringsSection)config.GetSection("connectionStrings");
                connectionString.ConnectionStrings["JP4.Properties.Settings.db_aplicativo_kpiConnectionString"].ConnectionString = text_endereco.Text; //"Data Source=NewSource;Initial Catalog=NewCatalog;UID=NewUser;password=NewPassword";
                config.Save();
                ConfigurationManager.RefreshSection("connectionStrings");

                MessageBox.Show("Salvo com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao salvar o local do banco! || " + erro.Message);
            }

        }


        // Buscar local de import de ordem de produção
        private string Procurar_pasta_os()
        {
            string local_pasta;
            string nome_arquivo;
            string endereco_completo = string.Empty;



            OpenFileDialog folderBrowser = new OpenFileDialog();

            folderBrowser.ValidateNames = true;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;

            folderBrowser.FileName = "Localizar Arquivo";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                local_pasta = Path.GetDirectoryName(folderBrowser.FileName);
                nome_arquivo = Path.GetFileName(folderBrowser.FileName);

                endereco_completo = local_pasta + @"\" + nome_arquivo;
            }

            return endereco_completo;
        }
        private void Salvar_local_os()
        {

            try
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var connectionString = (ConnectionStringsSection)config.GetSection("connectionStrings");
                connectionString.ConnectionStrings["JP4.Properties.Settings.local_arquivo_excel"].ConnectionString = text_local_arquivo_ordem.Text;
                config.Save();
                ConfigurationManager.RefreshSection("connectionStrings");

                MessageBox.Show("Salvo com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao salvar o dados importados! || " + erro.Message);
            }

        }
        private void Reset_aplicativo()
        {
            MessageBox.Show("Aplicativo deve ser reiniciado!");
            Application.Restart();
        }


        // Area de botão 

        private void button_procurar_pasta_Click(object sender, EventArgs e)
        {
            text_endereco.Text = Procurar_pasta();
        }
        private void button_salvar_endereco_Click(object sender, EventArgs e)
        {
            if(text_endereco.Text != string.Empty)
            {
                IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                config_ini.IniWriteString("STRING_DB", "local_banco", text_endereco.Text);
                
                label_endereco_backup.Text = Procurar_pasta_backup();
                
                config_ini.IniWriteString("LOCAL_ORIGEM_BK", "local_origem_bk", label_origem_backup.Text);
                criar_pasta_backup(label_origem_backup.Text);

                config_ini.IniWriteString("LOCAL_DESTINO_BK", "local_destino_bk", label_endereco_backup.Text + @"\db_backup");
                
                MessageBox.Show("Salvo com sucesso!");

            }
            else
            {
                MessageBox.Show("Campo de endereço não pode ficar em branco!");
            }
            
            //Salvar_local();
            //Salvar_origem_backup();
            //Testar_conexao();
            //Reset_aplicativo();
        }
        private void button_janela_update_Click(object sender, EventArgs e)
        {
            //Form_janela_update janela_update = new Form_janela_update();
            //janela_update.Show();           

        }
        private void button_busca_loca_arquivo_os_Click(object sender, EventArgs e)
        {
            text_local_arquivo_ordem.Text = Procurar_pasta_os();
        }
        private void button_salva_local_os_Click(object sender, EventArgs e)
        {
            try
            {
                if (text_local_arquivo_ordem.Text != string.Empty)
                {
                    IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                    config_ini.IniWriteString("RELATORIO", "local_relatorio", text_local_arquivo_ordem.Text);
                    MessageBox.Show("Salvo com sucesso!");
                }
                else
                {
                    MessageBox.Show("Campo de endereço não pode ficar em branco!");
                }
            }
            catch (Exception)
            {

            }
            
            //Salvar_local_os();
            // Reset_aplicativo();
        }
        private void verificarAtualizaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Upload_app.CONFI02_UP janela_up = new Upload_app.CONFI02_UP();
            // janela_up.ShowDialog();
        }

        private void button_config_bakcup_Click(object sender, EventArgs e)
        {
            //label_endereco_backup.Text = Procurar_pasta_backup();
            //Salvar_origem_backup();
            //Salvar_local_backup();
            //Reset_aplicativo();
        }

        private void button1_Click(object sender, EventArgs e){}

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


