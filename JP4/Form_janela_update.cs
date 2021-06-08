using System.Windows.Forms;
using System.Net;
using System.Diagnostics;

namespace JP4
{
    public partial class Form_janela_update : Form
    {
        public Form_janela_update()
        {
            InitializeComponent();

            label_versao_app.Text = Application.ProductVersion;
            
            
            check_update();
        }



        //

        private void check_update()
        {
            WebClient webClient = new WebClient();

            try
            {
                if (!webClient.DownloadString("yourpastebinlink").Contains(label_versao_app.Text))
                {
                    if (MessageBox.Show("Nova versão dispinivel! Deseja fazer o download?", "Gestão de produção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        using (var client = new WebClient())
                        {
                            Process.Start("UpdaterDemo.exe");
                            this.Close();
                        }
                }
            }
            catch
            {

            }
        }
        //

    }
}
