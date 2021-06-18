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
using Dropbox.Api;

namespace Update_JM4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Auto_update();

            //Download();
        }

        //Funciona muito bem com o servidor 00host
        // Testar com o servidor HostGator 
        // Criar setup do programa
        //Finalizar testes


        private void Auto_update()
        {
            WebClient webClient = new WebClient();
            var client = new WebClient();

            try
            {
                System.Threading.Thread.Sleep(5000);
                File.Delete(@".\setup.zip");
                client.DownloadFile(new Uri("https://jm418.000webhostapp.com/Aplicativo/JM4/setup.zip"), @"setup.zip");
                string zipPath = @".\setup.zip";
                string extractPath = @".\";
                ZipFile.ExtractToDirectory(zipPath, extractPath);
                File.Delete(@".\setup.zip");
                Process.Start(@".\setup.zip");
                this.Close();

            }
            catch
            {
                Process.Start("setup.exe");
                this.Close();
            }
        }      


    }
    
}
