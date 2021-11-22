using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net;
using System.Diagnostics;
using System.Threading;
using System.IO.Compression;
using System.IO;
using JP4.Cadastros;
using JP4.Config;


namespace JP4
{
    public partial class WINSTART : Form
    {
        public WINSTART()
        {
            InitializeComponent();


            label_data_inicial.Text = DateTime.Today.ToString("dddd - dd/MM/yyyy").ToUpper();
            

            label_inicio_versao_prog.Text = Application.ProductVersion;
            label_inicial_ultimo_backup.Text = Properties.Settings.Default.dt_ultimo_backup.ToString();

            label_status.Text = "Ultimo Backup >> ";
            
            
            Check_update();
            

            CONF01 gerar_backup = new CONF01();
            gerar_backup.fazer_backup();


            // ativar para depois de 1 ano
            auto_destruicao();

            // Carregar_imagen();


        }

        private void Carregar_imagen()
        {

            picture_inicial.Load(@"C:\Users\Jarvis\OneDrive\Visual - basic c#\JP4\Cadastro.png");
            
        }
        private void auto_destruicao()
        {
            DateTime dt_hoje = DateTime.Today;

            if(Properties.Settings.Default.apocalipse == dt_hoje)
            {
                MessageBox.Show("Dia de apagar tudo...");
            }
        }


        #region Funções de Auto Updater
        public void Check_update()
        {

            WebClient webClient = new WebClient();

            string link_download = "https://pastebin.com/raw/Hc22rGGZ";
            string versao_update = Application.ProductVersion;

            try
            {
                if (!webClient.DownloadString(link_download).Contains(versao_update))
                {
                    if (MessageBox.Show("Nova atualização disponivel, Deseja baixar?", "Atualização", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        using (var client = new WebClient())
                        {
                            Process.Start(@"C:\JP4\AutoUpdateJP.exe");
                            this.Close();
                        }
                }
            }
            catch
            {

            }
        }

        #endregion
        

        #region Declaração que faz o formulário se mover com o mouse
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")] private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        #endregion

        #region Menu do topo

        private void botao_fechar_Click(object sender, EventArgs e)
        {            
            Application.Exit();
        }

        private void botao_maxm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            botao_maxm.Visible = false;
            botao_restor.Visible = true;
        }

        private void botao_restor_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            botao_maxm.Visible = true;
            botao_restor.Visible = false;
        }

        private void botao_mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        #endregion

        #region Metodos da janela

        private void panel_titulo_menu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

                
        private void abrir_janelas(object formularios)
        {
            if (this.panel_central.Controls.Count > 0)
                this.panel_central.Controls.RemoveAt(0);

            Form janela = formularios as Form;
            janela.TopLevel = false;
            janela.Dock = DockStyle.Fill;
            this.panel_central.Controls.Add(janela);
            this.panel_central.Tag = janela;
            janela.Show();
        }


        #endregion

        #region Menu Vertial

        private void button_apontamento_Click(object sender, EventArgs e)
        {
            abrir_janelas(new AP01());
        }

        private void button_cadastro_material_Click(object sender, EventArgs e)
        {
            abrir_janelas(new CAD01());
        }

        private void button_estrutura_Click(object sender, EventArgs e)
        {
            abrir_janelas(new ST01());
        }

        #endregion

        private void button_abrir_op_Click(object sender, EventArgs e)
        {
            abrir_janelas(new OP001());
        }
        private void button_config_Click(object sender, EventArgs e)
        {
            abrir_janelas(new CONF01());
        }
        private void button_cadastro_defeitos_Click(object sender, EventArgs e)
        {
            abrir_janelas(new Form_janela_cad_defeitos());
        }
        private void button_cad_grupo_estoque_Click(object sender, EventArgs e)
        {
            abrir_janelas(new Form_janela_cad_grupo_estoque());
        }
        private void button_cad_clientes_Click(object sender, EventArgs e)
        {
            abrir_janelas(new Form_janela_cad_clientes());
        }
        private void button_cad_local_aplica_Click(object sender, EventArgs e)
        {
            abrir_janelas(new Form_janela_cad_local_aplicacao());
        }
        private void button_cad_local_estoque_Click(object sender, EventArgs e)
        {
            abrir_janelas(new Form_janela_cad_local_estoque());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            abrir_janelas(new Form_janela_cad_empresas());
        }
        private void button_cad_equipamento_Click(object sender, EventArgs e)
        {
            abrir_janelas(new Form_janela_cad_equipamentos());
        }
        private void button_cad_origem_apara_Click(object sender, EventArgs e)
        {
            abrir_janelas(new Form_janela_cad_origem_apara());
        }
        private void button_cad_operacao_Click(object sender, EventArgs e)
        {
            abrir_janelas(new Form_janela_cad_operacao());
        }
        private void button_cad_operador_Click(object sender, EventArgs e)
        {
            abrir_janelas(new Form_janela_cad_operador());
        }
        private void button_mov_estoque_Click(object sender, EventArgs e)
        {
            abrir_janelas(new STOQ01());
        }
        private void button_area_cadastro_Click(object sender, EventArgs e)
        {
            if (panel_sub_menu_cadastro.Visible == true)
            {
                panel_sub_menu_cadastro.Visible = false;
            }
            else
            {
                panel_sub_menu_cadastro.Visible = true;
            }
        }
        private void panel_menu_vertical_Click(object sender, EventArgs e)
        {
            panel_sub_menu_cadastro.Visible = false;
        }
        private void button_area_cadastro_MouseHover(object sender, EventArgs e)
        {
            panel_sub_menu_cadastro.Visible = true;
        }
        private void button_area_cadastro_MouseLeave(object sender, EventArgs e)
        {
           
        }
        private void label_status_Click(object sender, EventArgs e)
        {
            //DownloadFile();
        }
        private void linkLabel_baixar_nova_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Process.Start(e.Link.LinkData as string);
        }
        private void button_tipo_material_Click(object sender, EventArgs e)
        {
            abrir_janelas(new Form_janela_cad_tipo_material());
        }
        private void button_cad_turno_Click(object sender, EventArgs e)
        {
            abrir_janelas(new Form_janela_cad_turno());
        }
        private void button_cad_paradas_Click(object sender, EventArgs e)
        {
            abrir_janelas(new Form_janela_cad_paradas());
        }
        private void button_cadastro_user_Click(object sender, EventArgs e)
        {
            if(label_nome_usuario.Text == "admin")
            {
                abrir_janelas(new Form_janela_cad_usuario());
            }
            abrir_janelas(new Form_janela_cad_usuario());
        }
        private void button_report_Click(object sender, EventArgs e)
        {
            abrir_janelas(new Form_janela_report01());
        }
        private void timer_digital_Tick(object sender, EventArgs e)
        {
            label_hora_digital.Text = DateTime.Now.ToString("HH:mm");
        }
    }
}
