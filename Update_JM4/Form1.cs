using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.IO.Compression;


namespace Update_JM4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Auto_update();
            
        }


        private void Auto_update()
        {
            WebClient webClient = new WebClient();
            var client = new WebClient();

            try
            {
                System.Threading.Thread.Sleep(10);
                File.Delete(@".\JM4.exe");
                client.DownloadFile("https://br1048.hostgator.com.br:2083/cpsess8499595130/download?skipencode=1&file=%2fhome1%2fcasacr53%2fcasacriativa.top%2faplicatio.db%2fJM4%2fJP4.zip", @"JM4.zip");
                string zipPath = @".\JM4.zip";
                string extractPath = @".\";
                ZipFile.ExtractToDirectory(zipPath, extractPath);
                File.Delete(@".\JM4.zip");
                Process.Start(@".\JM4.exe");
                this.Close();
            }
            catch
            {
                Process.Start("JM4.exe");
                this.Close();
            }
        }





    }
    
}
