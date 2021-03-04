using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JP4
{
    public partial class Form_janela_apont : Form
    {
        public Form_janela_apont()
        {
            InitializeComponent();
        }

        private void Form_janela_apont_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.A)
            {
                button_apontamento.Focus();
            }
        }


        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Metodos Janela Apontamento




        #endregion


        #region Botoões do menu da direita

        private void button_apontamento_Click(object sender, EventArgs e)
        {

        }

        private void button_estornar_Click(object sender, EventArgs e)
        {

        }

        private void button_importar_Click(object sender, EventArgs e)
        {

        }

        private void button_paradas_Click(object sender, EventArgs e)
        {
            Form_janela_parada_mq janela_parada = new Form_janela_parada_mq();
            janela_parada.Show();

        }

        private void button_defeitos_Click(object sender, EventArgs e)
        {

        }

        private void button_obs_Click(object sender, EventArgs e)
        {

        }

        private void button_mistura_mp_Click(object sender, EventArgs e)
        {

        }

        private void button_retrabalho_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
