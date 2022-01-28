using JP4.Config;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace JP4
{
    public partial class Form_consumo_estrutura : Form
    {
        public Form_consumo_estrutura()
        {
            InitializeComponent();
            //MessageBox.Show(this.text_descri_item.Text);
            //carregar_grid(this.text_descri_item.Text);

        }

        public Form_consumo_estrutura(string cod_item, string descri_completa, double qtd_total) : this()
        {
            this.text__cod_item.Text = cod_item;
            this.text_descri_item.Text = descri_completa;
            this.text_qtd_saldo.Text = Convert.ToString(qtd_total);
            carregar_grid(this.text_descri_item.Text);
        }

        public void carregar_grid(string item_pai)
        {
            try
            {
                //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                string local_default = @"C:\JP4";
                string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select descri_pai, descri_filho, qtd_necessaria, Qt_total from db_estrutura";

                OleDbConnection connection = new OleDbConnection(conecta_string);
                OleDbDataAdapter myadapter = new OleDbDataAdapter(comando_sql, connection);
                DataTable dt = new DataTable("db_estrutura");

                myadapter.Fill(dt);

                DataView dv = dt.DefaultView;

                dv.RowFilter = string.Format("descri_pai like '%{0}%'", item_pai);
                Grid_estrutura_item.DataSource = dv.ToTable();

                calcular_qtd_total_grid();

                connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void calcular_qtd_total_grid()
        {
            double total = Convert.ToDouble(this.text_qtd_saldo.Text);


            for (int i = 0; i < Grid_estrutura_item.RowCount - 1; i++)
            {
                DataGridViewRow row = Grid_estrutura_item.Rows[i];
                string valueA = row.Cells["qtd_necessaria"].Value.ToString();
                row.Cells["Qt_total"].Value = (Convert.ToDouble(valueA) * total).ToString("0.00");
            }

        }

        private void text_descri_item_KeyPress(object sender, KeyPressEventArgs e)
        {
            //DataTable dt = new DataTable("db_estrutura");
            //DataView dv = dt.DefaultView;
            //dv.RowFilter = string.Format("descri_pai like '%{0}%'", this.text_descri_item.Text);
            //Grid_estrutura_item.DataSource = dv.ToTable();
        }

        private void Form_consumo_estrutura_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
