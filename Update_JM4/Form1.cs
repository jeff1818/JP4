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
                File.Delete(@".\JP4.exe");
                client.DownloadFile("https://jm418.000webhostapp.com/JP4.zip", @"JP4.zip"); // https://br1048.hostgator.com.br:2083/cpsess9498766292/download?skipencode=1&file=%2fhome1%2fcasacr53%2fpublic_html%2fAplicativo%2fJM4%2fJP4.zip
                string zipPath = @".\JP4.zip";
                string extractPath = @".\";
                ZipFile.ExtractToDirectory(zipPath, extractPath);
                File.Delete(@".\JP4.zip");
                Process.Start(@".\JP4.exe");
                this.Close();
            }
            catch
            {
                Process.Start("JP4.exe");
                this.Close();
            }


        }





    }
    
}
