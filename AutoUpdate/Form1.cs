using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;



namespace AutoUpdate
{
    public partial class Form_auto_update : Form
    {
        public Form_auto_update()
        {
            InitializeComponent();

            Baixar_atualizacao();

            descompactar_arquivo();

        }


        private void Baixar_atualizacao()
        {
            string urlArquivo = "https://onedrive.live.com/download?cid=37ABC5C967094270&resid=37ABC5C967094270%2143546&authkey=ALBey4pELk566qg";
            string caminhoArquivo = @"C:\JP4\JP4_setup.zip";

            System.Net.WebClient client = new System.Net.WebClient();
            client.DownloadFile(urlArquivo, caminhoArquivo);


        }

        private void descompactar_arquivo()
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


    }
}
