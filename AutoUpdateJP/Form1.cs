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

namespace AutoUpdateJP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DownloadFile();
        }


        public void DownloadFile()
        {
            WebClient webClient = new WebClient();
            var client = new WebClient();

            MessageBox.Show("Atualizando...");

            try
            {
                System.Threading.Thread.Sleep(5000);
                File.Delete(@".\setup.exe");
                client.DownloadFile("https://paralelo-erp1.000webhostapp.com/Instalador.zip", @"Instalador.zip");

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
    }
}
