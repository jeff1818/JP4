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

namespace JP4
{
    public partial class Form_tela_inicial : Form
    {
        public Form_tela_inicial()
        {
            InitializeComponent();

            label_inicio_versao_prog.Text = Application.ProductVersion;

            //Upload_app.CONFI02_UP janela_up = new Upload_app.CONFI02_UP();
            //janela_up.Show();
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
    }
}
