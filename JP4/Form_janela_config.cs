using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace JP4
{
    public partial class CONF01 : Form
    {
        public CONF01()
        {
            InitializeComponent();

            text_endereco.Text = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
            text_local_arquivo_ordem.Text = Properties.Settings.Default.local_arquivo_excel;

        }

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

        private void Verificar_padrao_arquivo()
        {

        }


        // Busca local do Banco de dados
        private string Procurar_pasta()
        {
            string local_pasta = string.Empty;
            string nome_arquivo = string.Empty;
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

                endereco_completo = texto_conecta + @"""" + local_pasta + @"\" + nome_arquivo + @"""";
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
                MessageBox.Show(erro.Message);
            }

        }
        

        // Buscar local de import de ordem de produção
        private string Procurar_pasta_os()
        {
            string local_pasta = string.Empty;
            string nome_arquivo = string.Empty;
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

                endereco_completo = @"""" + local_pasta + @"\" + nome_arquivo + @"""";
            }

            return endereco_completo;
        }
        private void Salvar_local_os()
        {

            try
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var connectionString = (ConnectionStringsSection)config.GetSection("connectionStrings");
                connectionString.ConnectionStrings["JP4.Properties.Settings.local_arquivo_excel"].ConnectionString = text_endereco.Text; //"Data Source=NewSource;Initial Catalog=NewCatalog;UID=NewUser;password=NewPassword";
                config.Save();
                ConfigurationManager.RefreshSection("connectionStrings");

                MessageBox.Show("Salvo com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }





        private void Reset_aplicativo()
        {
            MessageBox.Show("Aplicativo deve ser reiniciado!");
            Application.Exit();
        }



        // Area de botão 

        private void button_procurar_pasta_Click(object sender, EventArgs e)
        {
            text_endereco.Text = Procurar_pasta();
        }

        private void button_salvar_endereco_Click(object sender, EventArgs e)
        {
            Salvar_local();
            Testar_conexao();
            Reset_aplicativo();
        }



        private void button_janela_update_Click(object sender, EventArgs e)
        {
            //Auto_update_form janela_update = new Auto_update_form();
            //janela_update.Show();
        }

        private void button_busca_loca_arquivo_os_Click(object sender, EventArgs e)
        {
            text_local_arquivo_ordem.Text = Procurar_pasta_os();
        }

        private void button_salva_local_os_Click(object sender, EventArgs e)
        {
            Salvar_local_os();
            Reset_aplicativo();
        }
    }
}


