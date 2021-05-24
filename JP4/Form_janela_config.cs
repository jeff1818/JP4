using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JP4
{
    public partial class CONF01 : Form
    {
        public CONF01()
        {
            InitializeComponent();
        }

        //01 - definir o caminho do banco de dados padrão
        //02 - Definir o caminho dos arquivo exportados do sistema AC4
        //03 - SAlvar os caminhos no campo de configuração do aplicativo
        //04 - puxar os caminhos assim que abrir a aba de config >> CONF01

        //Extra
        //05 - Local pra mostrar a versão do arquivo
        //06 - Criar e mostrar a documentação de uso de cada tela do programa
        //07 - Criar um botão de buscar atualização e baixar quando estiver disponivel ( ainda nao resolvido o servidor FTP )

        // link util >> http://www.macoratti.net/15/03/c_locarq1.htm

        private void button_procurar_pasta_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    //string[] files = Directory.GetFiles(fbd.SelectedPath);

                    //MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                    MessageBox.Show("Files found: " + fbd.SelectedPath);

                }
            }
        }
    }
}
