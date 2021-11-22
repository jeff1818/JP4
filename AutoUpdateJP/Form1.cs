using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AltoHttp;


namespace AutoUpdateJP
{
    public partial class AutoUpdate_JP : Form
    {
        public AutoUpdate_JP()
        {
            InitializeComponent();

            Deletar_arquivos();
            Baixar_atualização();
            Descompactar();

        }

        

        public void DownloadFile()
        {
            WebClient webClient = new WebClient();
            var client = new WebClient();

            try
            {
                //System.Threading.Thread.Sleep(5000);

                File.Delete(@".\setup.exe");

                //client.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                //client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                //client.DownloadFile("https://paralelo-erp1.000webhostapp.com/Instalador.zip", @"Instalador.zip");

                Baixar_atualização();

                string zipPath = @".\Instalador.zip";
                string extractPath = @".\";
                ZipFile.ExtractToDirectory(zipPath, extractPath);

                File.Delete(@".\Instalador.zip");
                Process.Start(@".\setup.exe");
                this.Close();
            }
            catch
            {
                Process.Start("setup.exe");
                Close();
            }
        }


        #region Rotinas de Update

        WebClient webClient;               
        Stopwatch sw = new Stopwatch();

        private void Baixar_atualização()
        {
            using (webClient = new WebClient())
            {
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);

                // The variable that will be holding the url address (making sure it starts with http://)
                
                Uri URL = new Uri("https://paralelo-erp1.000webhostapp.com/Instalador.zip");
                

                // Start the stopwatch which we will be using to calculate the download speed
                sw.Start();

                try
                {
                    // Start downloading the file
                    webClient.DownloadFileAsync(URL, "Instalador.zip");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            // Calculate download speed and output it to labelSpeed.
            labelSpeed.Text = string.Format("{0} kb/s", (e.BytesReceived / 1024d / sw.Elapsed.TotalSeconds).ToString("0.00"));

            // Update the progressbar percentage only when the value is not the same.
            progressBar.Value = e.ProgressPercentage;

            // Show the percentage on our label.
            labelPerc.Text = e.ProgressPercentage.ToString() + "%";

            // Update the label with how much data have been downloaded so far and the total size of the file we are currently downloading
            labelDownloaded.Text = string.Format("{0} MB's / {1} MB's",
                (e.BytesReceived / 1024d / 1024d).ToString("0.00"),
                (e.TotalBytesToReceive / 1024d / 1024d).ToString("0.00"));
        }
        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            // Reset the stopwatch.
            sw.Reset();

            if (e.Cancelled == true)
            {
                MessageBox.Show("Download has been canceled.");
            }
            else
            {
                MessageBox.Show("Download completed!");
            }
        }
        private void Descompactar()
        {
            
            try
            {
                System.Threading.Thread.Sleep(5000);

                //File.Delete(@".\setup.exe");

                string zipPath = @".\Instalador.zip";
                string extractPath = @".\";
                ZipFile.ExtractToDirectory(zipPath, extractPath);
                
                // File.Delete(@".\Instalador.zip");
                Process.Start(@".\setup.exe");
                this.Close();
            }
            catch 
            {
                //MessageBox.Show(E.ToString());
                //Process.Start("setup.exe");
                //Close();
            }            
           
        }
        private void Deletar_arquivos()
        {
            try
            {
                File.Delete(@".\setup.exe");
                File.Delete(@".\JP4.application");
                Directory.Delete(@".\Application Files", true);
                File.Delete(@".\Instalador.zip");
            }
            catch (Exception)
            {
                
            }
            
        }

        #endregion
        

        private void button_baixar_Click(object sender, EventArgs e)
        {
            Deletar_arquivos();

            Baixar_atualização();

            Descompactar();

            
            //DownloadFile();

            


        }
    }
}
