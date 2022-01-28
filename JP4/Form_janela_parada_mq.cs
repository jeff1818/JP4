using JP4.Config;
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace JP4
{
    public partial class OP01 : Form
    {
        public OP01()
        {
            InitializeComponent();
        }

        public OP01(string ordem_producao, string local_aplicacao) : this()
        {
            this.label_numero_op.Text = ordem_producao;
            this.label_local_aplicacao.Text = local_aplicacao;
            carregar_tipos_parada(this.label_local_aplicacao.Text);
        }

        #region Metodos carregando informação

        private void carregar_tipos_parada(string origem_apara)
        {
            try
            {
                //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                string local_default = @"C:\JP4";
                string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select * from db_cadastro_paradas where origem_apara ='" + origem_apara + "'";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    this.combo_parada01.Items.Add(myreader["descricao_parada"].ToString());
                    this.combo_parada02.Items.Add(myreader["descricao_parada"].ToString());
                    this.combo_parada03.Items.Add(myreader["descricao_parada"].ToString());
                    this.combo_parada04.Items.Add(myreader["descricao_parada"].ToString());
                    this.combo_parada05.Items.Add(myreader["descricao_parada"].ToString());
                    this.combo_parada06.Items.Add(myreader["descricao_parada"].ToString());
                    this.combo_parada07.Items.Add(myreader["descricao_parada"].ToString());
                    this.combo_parada08.Items.Add(myreader["descricao_parada"].ToString());
                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }

        #endregion

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
