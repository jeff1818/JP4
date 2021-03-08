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
namespace JP4
{
    public partial class Form_tela_inicial : Form
    {
        public Form_tela_inicial()
        {
            InitializeComponent();
        }

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
            abrir_janelas(new Form_janela_apont());
        }

        private void button_cadastro_material_Click(object sender, EventArgs e)
        {
            abrir_janelas(new Form_janela_cadastro_material());
        }



        #endregion

        private void button_abrir_op_Click(object sender, EventArgs e)
        {

        }
    }
}
