using JP4.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JP4.Apontamento
{
    public partial class Form_cadastro_misturas : Form
    {
        public Form_cadastro_misturas()
        {
            InitializeComponent();

            Carregar_tipo();

        }

        #region Metodos Carregar controles
        private void Carregar_tipo()
        {
            try
            {
                //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                string local_default = @"C:\JP4";
                string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select * from db_cadastro_material where grupo = '05'";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                combo_mp_01.Items.Clear();
                combo_mp_02.Items.Clear();
                combo_mp_03.Items.Clear();
                combo_mp_04.Items.Clear();
                combo_mp_05.Items.Clear();
                combo_mp_06.Items.Clear();
                combo_mp_07.Items.Clear();
                combo_mp_08.Items.Clear();
                combo_mp_09.Items.Clear();
                combo_mp_10.Items.Clear();

                while (myreader.Read())
                {
                    this.combo_mp_01.Items.Add(myreader["descricao_completa"].ToString());
                    this.combo_mp_02.Items.Add(myreader["descricao_completa"].ToString());
                    this.combo_mp_03.Items.Add(myreader["descricao_completa"].ToString());
                    this.combo_mp_04.Items.Add(myreader["descricao_completa"].ToString());
                    this.combo_mp_05.Items.Add(myreader["descricao_completa"].ToString());
                    this.combo_mp_06.Items.Add(myreader["descricao_completa"].ToString());
                    this.combo_mp_07.Items.Add(myreader["descricao_completa"].ToString());
                    this.combo_mp_08.Items.Add(myreader["descricao_completa"].ToString());
                    this.combo_mp_09.Items.Add(myreader["descricao_completa"].ToString());
                    this.combo_mp_10.Items.Add(myreader["descricao_completa"].ToString());

                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }

        private void Carregar_material_mistura()
        {
            
        }

        #endregion

        #region Filtros Controle




        #endregion

        #region Salvar // Atualizar // Deletar // Limpar campos // Gerar Numero transação //
        private string Gerar_num_transac(DateTime dia_atual, DateTime hr_atual)
        {
            string resultado = Convert.ToString(dia_atual.Day) + hr_atual.Hour + hr_atual.Minute + hr_atual.Second;
            return resultado;

        }

        private void limpar_campos()
        {
            text_tag_cod_mistura.Text = string.Empty;
            combo_tipo_mistura.Text = string.Empty;


            combo_mp_01.Text = string.Empty;
            text_porcentagem_01.Text = string.Empty;

            combo_mp_02.Text = string.Empty;
            text_porcentagem_02.Text = string.Empty;

            combo_mp_03.Text = string.Empty;
            text_porcentagem_03.Text = string.Empty;

            combo_mp_04.Text = string.Empty;
            text_porcentagem_04.Text = string.Empty;

            combo_mp_05.Text = string.Empty;
            text_porcentagem_05.Text = string.Empty;

            combo_mp_06.Text = string.Empty;
            text_porcentagem_06.Text = string.Empty;

            combo_mp_07.Text = string.Empty;
            text_porcentagem_07.Text = string.Empty;

            combo_mp_08.Text = string.Empty;
            text_porcentagem_08.Text = string.Empty;

            combo_mp_09.Text = string.Empty;
            text_porcentagem_09.Text = string.Empty;

            combo_mp_10.Text = string.Empty;
            text_porcentagem_10.Text = string.Empty;
        }

        private void Salvar_tag_mistura()
        {
            

            if (combo_mp_01.Text != string.Empty)
            {
                string num_transac = Gerar_num_transac(DateTime.Now, DateTime.Now);

                DateTime data_lanc = DateTime.Now;
                int dia_lanc = data_lanc.Day;
                int mes_lanc = data_lanc.Month;
                int ano_lanc = data_lanc.Year;

                string marcador_mistura = text_tag_cod_mistura.Text;
                string tipo_mistura = combo_tipo_mistura.Text;

                string descr_mp = combo_mp_01.Text;
                double percentual_mistura = Convert.ToDouble(text_porcentagem_01.Text);
                string marcador_campo = combo_mp_01.Name;

                try
                {
                    string comando_sql;
                    //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                    string local_default = @"C:\JP4";
                    string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "INSERT INTO db_cadastro_misturas(num_transac, data_lanc, dia_lanc, mes_lanc, ano_lanc, marcador_mistura, tipo_mistura, descr_mp, percentual_mistura, marcador_campo) " +
                    "VALUES('" + num_transac + "','" + data_lanc + "','" + dia_lanc + "','" + mes_lanc + "','" + ano_lanc + "','" + marcador_mistura + "','" + tipo_mistura + "','" + descr_mp + "','" + percentual_mistura + "','" + marcador_campo + "')";

                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            if (combo_mp_02.Text != string.Empty)
            {
                string num_transac = Gerar_num_transac(DateTime.Now, DateTime.Now);

                DateTime data_lanc = DateTime.Now;
                int dia_lanc = data_lanc.Day;
                int mes_lanc = data_lanc.Month;
                int ano_lanc = data_lanc.Year;

                string marcador_mistura = text_tag_cod_mistura.Text;
                string tipo_mistura = combo_tipo_mistura.Text;

                string descr_mp = combo_mp_02.Text;
                double percentual_mistura = Convert.ToDouble(text_porcentagem_02.Text);
                string marcador_campo = combo_mp_02.Name;

                try
                {
                    string comando_sql;
                    //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                    string local_default = @"C:\JP4";
                    string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "INSERT INTO db_cadastro_misturas(num_transac, data_lanc, dia_lanc, mes_lanc, ano_lanc, marcador_mistura, tipo_mistura, descr_mp, percentual_mistura, marcador_campo) " +
                    "VALUES('" + num_transac + "','" + data_lanc + "','" + dia_lanc + "','" + mes_lanc + "','" + ano_lanc + "','" + marcador_mistura + "','" + tipo_mistura + "','" + descr_mp + "','" + percentual_mistura + "','" + marcador_campo + "')";

                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            if (combo_mp_03.Text != string.Empty)
            {
                string num_transac = Gerar_num_transac(DateTime.Now, DateTime.Now);

                DateTime data_lanc = DateTime.Now;
                int dia_lanc = data_lanc.Day;
                int mes_lanc = data_lanc.Month;
                int ano_lanc = data_lanc.Year;

                string marcador_mistura = text_tag_cod_mistura.Text;
                string tipo_mistura = combo_tipo_mistura.Text;

                string descr_mp = combo_mp_03.Text;
                double percentual_mistura = Convert.ToDouble(text_porcentagem_03.Text);
                string marcador_campo = combo_mp_03.Name;

                try
                {
                    string comando_sql;
                    //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                    string local_default = @"C:\JP4";
                    string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "INSERT INTO db_cadastro_misturas(num_transac, data_lanc, dia_lanc, mes_lanc, ano_lanc, marcador_mistura, tipo_mistura, descr_mp, percentual_mistura, marcador_campo) " +
                    "VALUES('" + num_transac + "','" + data_lanc + "','" + dia_lanc + "','" + mes_lanc + "','" + ano_lanc + "','" + marcador_mistura + "','" + tipo_mistura + "','" + descr_mp + "','" + percentual_mistura + "','" + marcador_campo + "')";

                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            if (combo_mp_04.Text != string.Empty)
            {
                string num_transac = Gerar_num_transac(DateTime.Now, DateTime.Now);

                DateTime data_lanc = DateTime.Now;
                int dia_lanc = data_lanc.Day;
                int mes_lanc = data_lanc.Month;
                int ano_lanc = data_lanc.Year;

                string marcador_mistura = text_tag_cod_mistura.Text;
                string tipo_mistura = combo_tipo_mistura.Text;

                string descr_mp = combo_mp_04.Text;
                double percentual_mistura = Convert.ToDouble(text_porcentagem_04.Text);
                string marcador_campo = combo_mp_04.Name;

                try
                {
                    string comando_sql;
                    //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                    string local_default = @"C:\JP4";
                    string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "INSERT INTO db_cadastro_misturas(num_transac, data_lanc, dia_lanc, mes_lanc, ano_lanc, marcador_mistura, tipo_mistura, descr_mp, percentual_mistura, marcador_campo) " +
                    "VALUES('" + num_transac + "','" + data_lanc + "','" + dia_lanc + "','" + mes_lanc + "','" + ano_lanc + "','" + marcador_mistura + "','" + tipo_mistura + "','" + descr_mp + "','" + percentual_mistura + "','" + marcador_campo + "')";

                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            if (combo_mp_05.Text != string.Empty)
            {
                string num_transac = Gerar_num_transac(DateTime.Now, DateTime.Now);

                DateTime data_lanc = DateTime.Now;
                int dia_lanc = data_lanc.Day;
                int mes_lanc = data_lanc.Month;
                int ano_lanc = data_lanc.Year;

                string marcador_mistura = text_tag_cod_mistura.Text;
                string tipo_mistura = combo_tipo_mistura.Text;

                string descr_mp = combo_mp_05.Text;
                double percentual_mistura = Convert.ToDouble(text_porcentagem_05.Text);
                string marcador_campo = combo_mp_05.Name;

                try
                {
                    string comando_sql;
                    //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                    string local_default = @"C:\JP4";
                    string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "INSERT INTO db_cadastro_misturas(num_transac, data_lanc, dia_lanc, mes_lanc, ano_lanc, marcador_mistura, tipo_mistura, descr_mp, percentual_mistura, marcador_campo) " +
                    "VALUES('" + num_transac + "','" + data_lanc + "','" + dia_lanc + "','" + mes_lanc + "','" + ano_lanc + "','" + marcador_mistura + "','" + tipo_mistura + "','" + descr_mp + "','" + percentual_mistura + "','" + marcador_campo + "')";

                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            if (combo_mp_06.Text != string.Empty)
            {
                string num_transac = Gerar_num_transac(DateTime.Now, DateTime.Now);

                DateTime data_lanc = DateTime.Now;
                int dia_lanc = data_lanc.Day;
                int mes_lanc = data_lanc.Month;
                int ano_lanc = data_lanc.Year;

                string marcador_mistura = text_tag_cod_mistura.Text;
                string tipo_mistura = combo_tipo_mistura.Text;

                string descr_mp = combo_mp_06.Text;
                double percentual_mistura = Convert.ToDouble(text_porcentagem_06.Text);
                string marcador_campo = combo_mp_06.Name;

                try
                {
                    string comando_sql;
                    //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                    string local_default = @"C:\JP4";
                    string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "INSERT INTO db_cadastro_misturas(num_transac, data_lanc, dia_lanc, mes_lanc, ano_lanc, marcador_mistura, tipo_mistura, descr_mp, percentual_mistura, marcador_campo) " +
                    "VALUES('" + num_transac + "','" + data_lanc + "','" + dia_lanc + "','" + mes_lanc + "','" + ano_lanc + "','" + marcador_mistura + "','" + tipo_mistura + "','" + descr_mp + "','" + percentual_mistura + "','" + marcador_campo + "')";

                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            if (combo_mp_07.Text != string.Empty)
            {
                string num_transac = Gerar_num_transac(DateTime.Now, DateTime.Now);

                DateTime data_lanc = DateTime.Now;
                int dia_lanc = data_lanc.Day;
                int mes_lanc = data_lanc.Month;
                int ano_lanc = data_lanc.Year;

                string marcador_mistura = text_tag_cod_mistura.Text;
                string tipo_mistura = combo_tipo_mistura.Text;

                string descr_mp = combo_mp_07.Text;
                double percentual_mistura = Convert.ToDouble(text_porcentagem_07.Text);
                string marcador_campo = combo_mp_07.Name;

                try
                {
                    string comando_sql;
                    //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                    string local_default = @"C:\JP4";
                    string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "INSERT INTO db_cadastro_misturas(num_transac, data_lanc, dia_lanc, mes_lanc, ano_lanc, marcador_mistura, tipo_mistura, descr_mp, percentual_mistura, marcador_campo) " +
                    "VALUES('" + num_transac + "','" + data_lanc + "','" + dia_lanc + "','" + mes_lanc + "','" + ano_lanc + "','" + marcador_mistura + "','" + tipo_mistura + "','" + descr_mp + "','" + percentual_mistura + "','" + marcador_campo + "')";

                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            if (combo_mp_08.Text != string.Empty)
            {
                string num_transac = Gerar_num_transac(DateTime.Now, DateTime.Now);

                DateTime data_lanc = DateTime.Now;
                int dia_lanc = data_lanc.Day;
                int mes_lanc = data_lanc.Month;
                int ano_lanc = data_lanc.Year;

                string marcador_mistura = text_tag_cod_mistura.Text;
                string tipo_mistura = combo_tipo_mistura.Text;

                string descr_mp = combo_mp_08.Text;
                double percentual_mistura = Convert.ToDouble(text_porcentagem_08.Text);
                string marcador_campo = combo_mp_08.Name;

                try
                {
                    string comando_sql;
                    //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                    string local_default = @"C:\JP4";
                    string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "INSERT INTO db_cadastro_misturas(num_transac, data_lanc, dia_lanc, mes_lanc, ano_lanc, marcador_mistura, tipo_mistura, descr_mp, percentual_mistura, marcador_campo) " +
                    "VALUES('" + num_transac + "','" + data_lanc + "','" + dia_lanc + "','" + mes_lanc + "','" + ano_lanc + "','" + marcador_mistura + "','" + tipo_mistura + "','" + descr_mp + "','" + percentual_mistura + "','" + marcador_campo + "')";

                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            if (combo_mp_09.Text != string.Empty)
            {
                string num_transac = Gerar_num_transac(DateTime.Now, DateTime.Now);

                DateTime data_lanc = DateTime.Now;
                int dia_lanc = data_lanc.Day;
                int mes_lanc = data_lanc.Month;
                int ano_lanc = data_lanc.Year;

                string marcador_mistura = text_tag_cod_mistura.Text;
                string tipo_mistura = combo_tipo_mistura.Text;

                string descr_mp = combo_mp_09.Text;
                double percentual_mistura = Convert.ToDouble(text_porcentagem_09.Text);
                string marcador_campo = combo_mp_09.Name;

                try
                {
                    string comando_sql;
                    //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                    string local_default = @"C:\JP4";
                    string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "INSERT INTO db_cadastro_misturas(num_transac, data_lanc, dia_lanc, mes_lanc, ano_lanc, marcador_mistura, tipo_mistura, descr_mp, percentual_mistura, marcador_campo) " +
                    "VALUES('" + num_transac + "','" + data_lanc + "','" + dia_lanc + "','" + mes_lanc + "','" + ano_lanc + "','" + marcador_mistura + "','" + tipo_mistura + "','" + descr_mp + "','" + percentual_mistura + "','" + marcador_campo + "')";

                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            if (combo_mp_10.Text != string.Empty)
            {
                string num_transac = Gerar_num_transac(DateTime.Now, DateTime.Now);

                DateTime data_lanc = DateTime.Now;
                int dia_lanc = data_lanc.Day;
                int mes_lanc = data_lanc.Month;
                int ano_lanc = data_lanc.Year;

                string marcador_mistura = text_tag_cod_mistura.Text;
                string tipo_mistura = combo_tipo_mistura.Text;

                string descr_mp = combo_mp_10.Text;
                double percentual_mistura = Convert.ToDouble(text_porcentagem_10.Text);
                string marcador_campo = combo_mp_10.Name;

                try
                {
                    string comando_sql;
                    //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                    string local_default = @"C:\JP4";
                    string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "INSERT INTO db_cadastro_misturas(num_transac, data_lanc, dia_lanc, mes_lanc, ano_lanc, marcador_mistura, tipo_mistura, descr_mp, percentual_mistura, marcador_campo) " +
                    "VALUES('" + num_transac + "','" + data_lanc + "','" + dia_lanc + "','" + mes_lanc + "','" + ano_lanc + "','" + marcador_mistura + "','" + tipo_mistura + "','" + descr_mp + "','" + percentual_mistura + "','" + marcador_campo + "')";

                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }




        }

        private void Atualizar_tags_mistura()
        {

        }

        private void Deletar_targ_mistura(string status_tag)
        {

        }

        #endregion

        private void button_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                Salvar_tag_mistura();
                MessageBox.Show("Salvo com sucesso!");
                limpar_campos();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao salvar!");
            }
            
        }
    }
}
