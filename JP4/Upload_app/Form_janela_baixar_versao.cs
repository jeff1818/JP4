using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Net;
using AltoHttp;

namespace JP4.Upload_app
{
    public partial class CONFI02_UP : Form
    {
        public CONFI02_UP()
        {
            InitializeComponent();
            
        }

        public void Check_update()
        {
            WebClient webClient = new WebClient();
            try
            {
                if (!webClient.DownloadString("https://pastebin.com/raw/Hc22rGGZ").Contains(Application.ProductVersion))
                {
                    DialogResult resultado = MessageBox.Show("Uma nova versão do sistema esta disponivel, deseja baixar ?","Nova Versão!", MessageBoxButtons.YesNo);

                    if (resultado == DialogResult.Yes)
                    {
                        using (var client = new WebClient())
                        {
                            label_status.Text = "Nova versão disponivel!";
                            //downloadFile();
                            baixar_versao();
                        }
                    }
                }
                else
                {
                    label_status.Text = "Essa é a versão mais recente!";
                }

            }
            catch
            {

            }
        }



        HttpDownloader httpDownloader;

        private void baixar_versao()
        {
            string url = "https://1drv.ms/u/s!AnBCCWfJxas3gdojdmgdz4Rky-0wyw?e=WrwDgf";
            httpDownloader = new HttpDownloader(url, $"{Application.StartupPath }\\{Path.GetFileName(url)}");
            httpDownloader.DownloadCompleted += httpDownloader_donloadcompleted;
            httpDownloader.ProgressChanged += httpDownloader_progressbar;


        }

        private void httpDownloader_progressbar(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = (int)e.Progress;
        }

        private void httpDownloader_donloadcompleted(object sender, EventArgs e)
        {

        }

       

        private void downloadFile()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            // Change the url by the value you want (a textbox or something else)
            string url = "https://1drv.ms/u/s!AnBCCWfJxas3gdojdmgdz4Rky-0wyw?e=WrwDgf";
            // Get filename from URL
            string filename = getFilename(url);

            using (var client = new WebClient())
            {
                client.DownloadFile(url, @"\" + filename);
            }

            MessageBox.Show("Download ok!");
        }

        private string getFilename(string hreflink)
        {
            Uri uri = new Uri(hreflink);
            string filename = System.IO.Path.GetFileName(uri.LocalPath);
            return filename;
        }

        private void button_verifica_atualizacao_Click(object sender, EventArgs e)
        {
            Check_update();
        }
    }
}
