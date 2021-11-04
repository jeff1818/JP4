using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JP4.Config
{
    public partial class Form_janela_config_txt : Form
    {
        public Form_janela_config_txt()
        {
            InitializeComponent();

            text_endereco.Text = Properties.Settings.Default.arquivo_txt;
            
        }

        // Achar uma forma de usar um aquivo de configuração padrão TXT ou INI
        // Afim de manter a configuração salva mesmo depois de reinstalar

        private string Procurar_pasta()
        {
            string local_pasta;
            string nome_arquivo;
            string endereco_completo = string.Empty;
            // string texto_conecta = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=";


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
                endereco_completo = '\u0022' + local_pasta + @"\" + nome_arquivo + '\u0022'; //"; providerName =" + '\u0022' + "System.Data.OleDb"+'\u0022';
                //label_origem_backup.Text = local_pasta;
                //Salvar_origem_backup();
                //criar_pasta_backup(local_pasta);
            }

            return endereco_completo;
        }
        private void Reset_aplicativo()
        {
            MessageBox.Show("Aplicativo deve ser reiniciado!");
            Application.Restart();
        }
        private void Salvar_local()
        {

            try
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var connectionString = (ConnectionStringsSection)config.GetSection("connectionStrings");
                connectionString.ConnectionStrings["JP4.Properties.Settings.arquivo_txt"].ConnectionString = text_endereco.Text; //"Data Source=NewSource;Initial Catalog=NewCatalog;UID=NewUser;password=NewPassword";
                config.Save();
                ConfigurationManager.RefreshSection("connectionStrings");

                MessageBox.Show("Salvo com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao salvar o local do banco! || " + erro.Message);
            }

        }

        private void button_buscar_local_Click(object sender, EventArgs e)
        {
            text_endereco.Text = Procurar_pasta();
        }

        private void button_salvar_endereco_Click(object sender, EventArgs e)
        {
            Salvar_local();
            //Salvar_origem_backup();
            //Testar_conexao();
            Reset_aplicativo();
        }
    }
}
