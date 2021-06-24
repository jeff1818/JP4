using AltoHttp;
using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.ComponentModel;

namespace JP4.Upload_app
{
    public partial class CONFI02_UP : Form
    {
        public CONFI02_UP()
        {
            InitializeComponent();
            Check_update();
        }

        WebClient webClient;               
        Stopwatch sw = new Stopwatch();

        public void Check_update()
        {
            WebClient webClient = new WebClient();
            try
            {
                if (!webClient.DownloadString("https://pastebin.com/raw/Hc22rGGZ").Contains(Application.ProductVersion))
                {
                    //DialogResult resultado = MessageBox.Show("Uma nova versão do sistema esta disponivel, deseja baixar ?","Nova Versão!", MessageBoxButtons.YesNo);                    
                    label_status.Text = "Nova versão disponivel!";
                    button_baixar.Visible = true;
                }
                else
                {
                    label_status.Text = "O JP4 Já esta atualizado!";
                }

            }
            catch
            {

            }
        }

        private void button_baixar_Click(object sender, EventArgs e)
        {
            using (var client = new WebClient())
            {
                // Essa merda ainda não funciona 

                //DownloadFile("https://files.000webhost.com/handler.php?action=download?action=download&path=%2FUpdate%2FUpdate.zip", @"\");

                DownloadFtpFile("ftp://files.000webhost.com/update/Update.zip", @"\\");
            }

        }

        private void button_verifica_atualizacao_Click(object sender, EventArgs e)
        {
            Check_update();
        }


        //---------------------------------------------------------------

        private void DownloadFtpFile(string url, string savePath)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(url);
            request.Method = WebRequestMethods.Ftp.DownloadFile;
            request.Credentials = new NetworkCredential("jm418", "qazwsxedc");
            request.UseBinary = true;

            using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
            {
                using (Stream rs = response.GetResponseStream())
                {
                    using (FileStream ws = new FileStream(savePath, FileMode.Create))
                    {
                        byte[] buffer = new byte[2048];
                        int bytesRead = rs.Read(buffer, 0, buffer.Length);

                        while (bytesRead > 0)
                        {
                            ws.Write(buffer, 0, bytesRead);
                            bytesRead = rs.Read(buffer, 0, buffer.Length);
                        }
                    }
                }
            }
        }


        public void DownloadFile(string urlAddress, string location)
        {
            using (webClient = new WebClient())
            {
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);

                // The variable that will be holding the url address (making sure it starts with http://)
                Uri URL = urlAddress.StartsWith("http://", StringComparison.OrdinalIgnoreCase) ? new Uri(urlAddress) : new Uri("http://" + urlAddress);

                // Start the stopwatch which we will be using to calculate the download speed
                sw.Start();

                try
                {
                    // Start downloading the file
                    webClient.DownloadFileAsync(URL, location);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // The event that will fire whenever the progress of the WebClient is changed
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

        // The event that will trigger when the WebClient is completed
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

    }
}
