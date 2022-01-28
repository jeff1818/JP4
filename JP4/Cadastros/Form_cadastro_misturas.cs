using MySql.Data.MySqlClient;
using System;

using System.Drawing;
using System.Windows.Forms;

namespace JP4.Apontamento
{
    public partial class Form_cadastro_misturas : Form
    {
        public Form_cadastro_misturas()
        {
            InitializeComponent();

            Carregar_descri_mp();
            Carregar_tipo_material();
            Carregar_tag_mistura();
        }

        #region Metodos de Calculo

        private double Soma_percentual(string mp01, string mp02, string mp03, string mp04, string mp05, string mp06, string mp07, string mp08, string mp09, string mp10)
        {
            double resultado = 0;

            try
            {
                if (Convert.ToDouble(mp01) > 0)
                {
                    resultado += Convert.ToDouble(mp01);
                }

                if (Convert.ToDouble(mp02) > 0)
                {
                    resultado += Convert.ToDouble(mp02);
                }

                if (Convert.ToDouble(mp03) > 0)
                {
                    resultado += Convert.ToDouble(mp03);
                }

                if (Convert.ToDouble(mp04) > 0)
                {
                    resultado += Convert.ToDouble(mp04);
                }

                if (Convert.ToDouble(mp05) > 0)
                {
                    resultado += Convert.ToDouble(mp05);
                }
                if (Convert.ToDouble(mp06) > 0)
                {
                    resultado += Convert.ToDouble(mp06);
                }

                if (Convert.ToDouble(mp07) > 0)
                {
                    resultado += Convert.ToDouble(mp07);
                }
                if (Convert.ToDouble(mp08) > 0)
                {
                    resultado += Convert.ToDouble(mp08);
                }

                if (Convert.ToDouble(mp09) > 0)
                {
                    resultado += Convert.ToDouble(mp09);
                }
                if (Convert.ToDouble(mp10) > 0)
                {
                    resultado += Convert.ToDouble(mp10);
                }
            }
            catch
            {
                return resultado;
                //MessageBox.Show(erro.Message);
            }
            return resultado;
        }

        #endregion

        #region Metodos Carregar controles
        private void Carregar_descri_mp()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_material where grupo = '05'";

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
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
        private void Carregar_tipo_material()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_tipo_material";

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    combo_tipo_mistura.Items.Add(myreader["tipo_material"].ToString());
                }

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }
        private void Carregar_tag_mistura()
        {
            combo_tag_mistura.Items.Clear();

            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select distinct marcador_mistura from db_cadastro_misturas";
                // marcador_mistura
                // SELECT DISTINCT
                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    combo_tag_mistura.Items.Add(myreader["marcador_mistura"].ToString());
                }

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }


        }
        private void Carregar_misturas_tag(string marcador_mistura)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "SELECT * FROM db_cadastro_misturas WHERE marcador_mistura = '" + marcador_mistura + "'";

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    label_tipo_mistura.Text = myreader["tipo_mistura"].ToString();

                    if (combo_mp_01.Name == myreader["marcador_campo"].ToString())
                    {
                        combo_mp_01.Text = myreader["descr_mp"].ToString();
                        text_porcentagem_01.Text = myreader["percentual_mistura"].ToString();
                        label_status_01.Text = myreader["id_misturas"].ToString();
                        label_num_transa.Text = myreader["num_transac"].ToString(); // Testando só com uma opção
                    }

                    if (combo_mp_02.Name == myreader["marcador_campo"].ToString())
                    {
                        combo_mp_02.Text = myreader["descr_mp"].ToString();
                        text_porcentagem_02.Text = myreader["percentual_mistura"].ToString();
                        label_status_02.Text = myreader["id_misturas"].ToString();
                    }

                    if (combo_mp_03.Name == myreader["marcador_campo"].ToString())
                    {
                        combo_mp_03.Text = myreader["descr_mp"].ToString();
                        text_porcentagem_03.Text = myreader["percentual_mistura"].ToString();
                        label_status_03.Text = myreader["id_misturas"].ToString();
                    }

                    if (combo_mp_04.Name == myreader["marcador_campo"].ToString())
                    {
                        combo_mp_04.Text = myreader["descr_mp"].ToString();
                        text_porcentagem_04.Text = myreader["percentual_mistura"].ToString();
                        label_status_04.Text = myreader["id_misturas"].ToString();
                    }

                    if (combo_mp_05.Name == myreader["marcador_campo"].ToString())
                    {
                        combo_mp_05.Text = myreader["descr_mp"].ToString();
                        text_porcentagem_05.Text = myreader["percentual_mistura"].ToString();
                        label_status_05.Text = myreader["id_misturas"].ToString();
                    }

                    if (combo_mp_06.Name == myreader["marcador_campo"].ToString())
                    {
                        combo_mp_06.Text = myreader["descr_mp"].ToString();
                        text_porcentagem_06.Text = myreader["percentual_mistura"].ToString();
                        label_status_06.Text = myreader["id_misturas"].ToString();
                    }

                    if (combo_mp_07.Name == myreader["marcador_campo"].ToString())
                    {
                        combo_mp_07.Text = myreader["descr_mp"].ToString();
                        text_porcentagem_07.Text = myreader["percentual_mistura"].ToString();
                        label_status_07.Text = myreader["id_misturas"].ToString();
                    }

                    if (combo_mp_08.Name == myreader["marcador_campo"].ToString())
                    {
                        combo_mp_08.Text = myreader["descr_mp"].ToString();
                        text_porcentagem_08.Text = myreader["percentual_mistura"].ToString();
                        label_status_08.Text = myreader["id_misturas"].ToString();
                    }

                    if (combo_mp_09.Name == myreader["marcador_campo"].ToString())
                    {
                        combo_mp_09.Text = myreader["descr_mp"].ToString();
                        text_porcentagem_09.Text = myreader["percentual_mistura"].ToString();
                        label_status_09.Text = myreader["id_misturas"].ToString();
                    }

                    if (combo_mp_10.Name == myreader["marcador_campo"].ToString())
                    {
                        combo_mp_10.Text = myreader["descr_mp"].ToString();
                        text_porcentagem_10.Text = myreader["percentual_mistura"].ToString();
                        label_status_10.Text = myreader["id_misturas"].ToString();
                    }



                }

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
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

                string data_lanc = DateTime.Now.ToString("yyyy/MM/dd");
                int dia_lanc = DateTime.Today.Day;
                int mes_lanc = DateTime.Today.Month;
                int ano_lanc = DateTime.Today.Year;

                string marcador_mistura = text_tag_cod_mistura.Text;
                string tipo_mistura = combo_tipo_mistura.Text;

                string descr_mp = combo_mp_01.Text;
                double percentual_mistura = Convert.ToDouble(text_porcentagem_01.Text);
                string marcador_campo = combo_mp_01.Name;

                try
                {
                    string comando_sql;
                    string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    MySqlConnection conexao = new MySqlConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "INSERT INTO db_cadastro_misturas(num_transac, data_lanc, dia_lanc, mes_lanc, ano_lanc, marcador_mistura, tipo_mistura, descr_mp, percentual_mistura, marcador_campo) " +
                    "VALUES('" + num_transac + "','" + data_lanc + "','" + dia_lanc + "','" + mes_lanc + "','" + ano_lanc + "','" + marcador_mistura + "','" + tipo_mistura + "','" + descr_mp + "','" + percentual_mistura + "','" + marcador_campo + "')";

                    MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
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

                string data_lanc = DateTime.Now.ToString("yyyy/MM/dd");
                int dia_lanc = DateTime.Today.Day;
                int mes_lanc = DateTime.Today.Month;
                int ano_lanc = DateTime.Today.Year;

                string marcador_mistura = text_tag_cod_mistura.Text;
                string tipo_mistura = combo_tipo_mistura.Text;

                string descr_mp = combo_mp_02.Text;
                double percentual_mistura = Convert.ToDouble(text_porcentagem_02.Text);
                string marcador_campo = combo_mp_02.Name;

                try
                {
                    string comando_sql;
                    string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    MySqlConnection conexao = new MySqlConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "INSERT INTO db_cadastro_misturas(num_transac, data_lanc, dia_lanc, mes_lanc, ano_lanc, marcador_mistura, tipo_mistura, descr_mp, percentual_mistura, marcador_campo) " +
                    "VALUES('" + num_transac + "','" + data_lanc + "','" + dia_lanc + "','" + mes_lanc + "','" + ano_lanc + "','" + marcador_mistura + "','" + tipo_mistura + "','" + descr_mp + "','" + percentual_mistura + "','" + marcador_campo + "')";

                    MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
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

                string data_lanc = DateTime.Now.ToString("yyyy/MM/dd");
                int dia_lanc = DateTime.Today.Day;
                int mes_lanc = DateTime.Today.Month;
                int ano_lanc = DateTime.Today.Year;

                string marcador_mistura = text_tag_cod_mistura.Text;
                string tipo_mistura = combo_tipo_mistura.Text;

                string descr_mp = combo_mp_03.Text;
                double percentual_mistura = Convert.ToDouble(text_porcentagem_03.Text);
                string marcador_campo = combo_mp_03.Name;

                try
                {
                    string comando_sql;
                    string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    MySqlConnection conexao = new MySqlConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "INSERT INTO db_cadastro_misturas(num_transac, data_lanc, dia_lanc, mes_lanc, ano_lanc, marcador_mistura, tipo_mistura, descr_mp, percentual_mistura, marcador_campo) " +
                    "VALUES('" + num_transac + "','" + data_lanc + "','" + dia_lanc + "','" + mes_lanc + "','" + ano_lanc + "','" + marcador_mistura + "','" + tipo_mistura + "','" + descr_mp + "','" + percentual_mistura + "','" + marcador_campo + "')";

                    MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
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

                string data_lanc = DateTime.Now.ToString("yyyy/MM/dd");
                int dia_lanc = DateTime.Today.Day;
                int mes_lanc = DateTime.Today.Month;
                int ano_lanc = DateTime.Today.Year;

                string marcador_mistura = text_tag_cod_mistura.Text;
                string tipo_mistura = combo_tipo_mistura.Text;

                string descr_mp = combo_mp_04.Text;
                double percentual_mistura = Convert.ToDouble(text_porcentagem_04.Text);
                string marcador_campo = combo_mp_04.Name;

                try
                {
                    string comando_sql;
                    string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    MySqlConnection conexao = new MySqlConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "INSERT INTO db_cadastro_misturas(num_transac, data_lanc, dia_lanc, mes_lanc, ano_lanc, marcador_mistura, tipo_mistura, descr_mp, percentual_mistura, marcador_campo) " +
                    "VALUES('" + num_transac + "','" + data_lanc + "','" + dia_lanc + "','" + mes_lanc + "','" + ano_lanc + "','" + marcador_mistura + "','" + tipo_mistura + "','" + descr_mp + "','" + percentual_mistura + "','" + marcador_campo + "')";

                    MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
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

                string data_lanc = DateTime.Now.ToString("yyyy/MM/dd");
                int dia_lanc = DateTime.Today.Day;
                int mes_lanc = DateTime.Today.Month;
                int ano_lanc = DateTime.Today.Year;

                string marcador_mistura = text_tag_cod_mistura.Text;
                string tipo_mistura = combo_tipo_mistura.Text;

                string descr_mp = combo_mp_05.Text;
                double percentual_mistura = Convert.ToDouble(text_porcentagem_05.Text);
                string marcador_campo = combo_mp_05.Name;

                try
                {
                    string comando_sql;
                    string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    MySqlConnection conexao = new MySqlConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "INSERT INTO db_cadastro_misturas(num_transac, data_lanc, dia_lanc, mes_lanc, ano_lanc, marcador_mistura, tipo_mistura, descr_mp, percentual_mistura, marcador_campo) " +
                    "VALUES('" + num_transac + "','" + data_lanc + "','" + dia_lanc + "','" + mes_lanc + "','" + ano_lanc + "','" + marcador_mistura + "','" + tipo_mistura + "','" + descr_mp + "','" + percentual_mistura + "','" + marcador_campo + "')";

                    MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
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

                string data_lanc = DateTime.Now.ToString("yyyy/MM/dd");
                int dia_lanc = DateTime.Today.Day;
                int mes_lanc = DateTime.Today.Month;
                int ano_lanc = DateTime.Today.Year;

                string marcador_mistura = text_tag_cod_mistura.Text;
                string tipo_mistura = combo_tipo_mistura.Text;

                string descr_mp = combo_mp_06.Text;
                double percentual_mistura = Convert.ToDouble(text_porcentagem_06.Text);
                string marcador_campo = combo_mp_06.Name;

                try
                {
                    string comando_sql;
                    string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    MySqlConnection conexao = new MySqlConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "INSERT INTO db_cadastro_misturas(num_transac, data_lanc, dia_lanc, mes_lanc, ano_lanc, marcador_mistura, tipo_mistura, descr_mp, percentual_mistura, marcador_campo) " +
                    "VALUES('" + num_transac + "','" + data_lanc + "','" + dia_lanc + "','" + mes_lanc + "','" + ano_lanc + "','" + marcador_mistura + "','" + tipo_mistura + "','" + descr_mp + "','" + percentual_mistura + "','" + marcador_campo + "')";

                    MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
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

                string data_lanc = DateTime.Now.ToString("yyyy/MM/dd");
                int dia_lanc = DateTime.Today.Day;
                int mes_lanc = DateTime.Today.Month;
                int ano_lanc = DateTime.Today.Year;

                string marcador_mistura = text_tag_cod_mistura.Text;
                string tipo_mistura = combo_tipo_mistura.Text;

                string descr_mp = combo_mp_07.Text;
                double percentual_mistura = Convert.ToDouble(text_porcentagem_07.Text);
                string marcador_campo = combo_mp_07.Name;

                try
                {
                    string comando_sql;
                    string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    MySqlConnection conexao = new MySqlConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "INSERT INTO db_cadastro_misturas(num_transac, data_lanc, dia_lanc, mes_lanc, ano_lanc, marcador_mistura, tipo_mistura, descr_mp, percentual_mistura, marcador_campo) " +
                    "VALUES('" + num_transac + "','" + data_lanc + "','" + dia_lanc + "','" + mes_lanc + "','" + ano_lanc + "','" + marcador_mistura + "','" + tipo_mistura + "','" + descr_mp + "','" + percentual_mistura + "','" + marcador_campo + "')";

                    MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
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

                string data_lanc = DateTime.Now.ToString("yyyy/MM/dd");
                int dia_lanc = DateTime.Today.Day;
                int mes_lanc = DateTime.Today.Month;
                int ano_lanc = DateTime.Today.Year;

                string marcador_mistura = text_tag_cod_mistura.Text;
                string tipo_mistura = combo_tipo_mistura.Text;

                string descr_mp = combo_mp_08.Text;
                double percentual_mistura = Convert.ToDouble(text_porcentagem_08.Text);
                string marcador_campo = combo_mp_08.Name;

                try
                {
                    string comando_sql;
                    string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    MySqlConnection conexao = new MySqlConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "INSERT INTO db_cadastro_misturas(num_transac, data_lanc, dia_lanc, mes_lanc, ano_lanc, marcador_mistura, tipo_mistura, descr_mp, percentual_mistura, marcador_campo) " +
                    "VALUES('" + num_transac + "','" + data_lanc + "','" + dia_lanc + "','" + mes_lanc + "','" + ano_lanc + "','" + marcador_mistura + "','" + tipo_mistura + "','" + descr_mp + "','" + percentual_mistura + "','" + marcador_campo + "')";

                    MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
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

                string data_lanc = DateTime.Now.ToString("yyyy/MM/dd");
                int dia_lanc = DateTime.Today.Day;
                int mes_lanc = DateTime.Today.Month;
                int ano_lanc = DateTime.Today.Year;

                string marcador_mistura = text_tag_cod_mistura.Text;
                string tipo_mistura = combo_tipo_mistura.Text;

                string descr_mp = combo_mp_09.Text;
                double percentual_mistura = Convert.ToDouble(text_porcentagem_09.Text);
                string marcador_campo = combo_mp_09.Name;

                try
                {
                    string comando_sql;
                    string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    MySqlConnection conexao = new MySqlConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "INSERT INTO db_cadastro_misturas(num_transac, data_lanc, dia_lanc, mes_lanc, ano_lanc, marcador_mistura, tipo_mistura, descr_mp, percentual_mistura, marcador_campo) " +
                    "VALUES('" + num_transac + "','" + data_lanc + "','" + dia_lanc + "','" + mes_lanc + "','" + ano_lanc + "','" + marcador_mistura + "','" + tipo_mistura + "','" + descr_mp + "','" + percentual_mistura + "','" + marcador_campo + "')";

                    MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
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

                string data_lanc = DateTime.Now.ToString("yyyy/MM/dd");
                int dia_lanc = DateTime.Today.Day;
                int mes_lanc = DateTime.Today.Month;
                int ano_lanc = DateTime.Today.Year;

                string marcador_mistura = text_tag_cod_mistura.Text;
                string tipo_mistura = combo_tipo_mistura.Text;

                string descr_mp = combo_mp_10.Text;
                double percentual_mistura = Convert.ToDouble(text_porcentagem_10.Text);
                string marcador_campo = combo_mp_10.Name;

                try
                {
                    string comando_sql;
                    string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    MySqlConnection conexao = new MySqlConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "INSERT INTO db_cadastro_misturas(num_transac, data_lanc, dia_lanc, mes_lanc, ano_lanc, marcador_mistura, tipo_mistura, descr_mp, percentual_mistura, marcador_campo) " +
                    "VALUES('" + num_transac + "','" + data_lanc + "','" + dia_lanc + "','" + mes_lanc + "','" + ano_lanc + "','" + marcador_mistura + "','" + tipo_mistura + "','" + descr_mp + "','" + percentual_mistura + "','" + marcador_campo + "')";

                    MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
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
            if (label_status_01.Text != "id")
            {
                string data_lanc = DateTime.Now.ToString("yyyy/MM/dd");
                int dia_lanc = DateTime.Today.Day;
                int mes_lanc = DateTime.Today.Month;
                int ano_lanc = DateTime.Today.Year;

                string marcador_mistura = text_tag_cod_mistura.Text;
                string tipo_mistura = combo_tipo_mistura.Text;

                string descr_mp = combo_mp_01.Text;
                double percentual_mistura = Convert.ToDouble(text_porcentagem_01.Text);
                string marcador_campo = combo_mp_01.Name;

                try
                {
                    string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    MySqlConnection conexao = new MySqlConnection(conecta_string);
                    conexao.Open();
                    string comando_sql;

                    comando_sql = "UPDATE db_cadastro_misturas SET " +
                        "data_lanc='" + data_lanc +
                        "', dia_lanc='" + dia_lanc +
                        "', mes_lanc='" + mes_lanc +
                        "', ano_lanc='" + ano_lanc +
                        "', marcador_mistura='" + marcador_mistura +
                        "', tipo_mistura='" + tipo_mistura +
                        "', descr_mp='" + descr_mp +
                        "', percentual_mistura='" + Convert.ToDouble(percentual_mistura) +
                        "', marcador_campo='" + marcador_campo +
                        "' WHERE id_estrutura=" + Convert.ToInt64(label_status_01.Text) + "";


                    MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            if (label_status_02.Text != "id")
            {
                string data_lanc = DateTime.Now.ToString("yyyy/MM/dd");
                int dia_lanc = DateTime.Today.Day;
                int mes_lanc = DateTime.Today.Month;
                int ano_lanc = DateTime.Today.Year;

                string marcador_mistura = text_tag_cod_mistura.Text;
                string tipo_mistura = combo_tipo_mistura.Text;

                string descr_mp = combo_mp_02.Text;
                double percentual_mistura = Convert.ToDouble(text_porcentagem_02.Text);
                string marcador_campo = combo_mp_02.Name;

                try
                {
                    string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    MySqlConnection conexao = new MySqlConnection(conecta_string);
                    conexao.Open();
                    string comando_sql;

                    comando_sql = "UPDATE db_cadastro_misturas SET " +
                        "data_lanc='" + data_lanc +
                        "', dia_lanc='" + dia_lanc +
                        "', mes_lanc='" + mes_lanc +
                        "', ano_lanc='" + ano_lanc +
                        "', marcador_mistura='" + marcador_mistura +
                        "', tipo_mistura='" + tipo_mistura +
                        "', descr_mp='" + descr_mp +
                        "', percentual_mistura='" + Convert.ToDouble(percentual_mistura) +
                        "', marcador_campo='" + marcador_campo +
                        "' WHERE id_estrutura=" + Convert.ToInt64(label_status_02.Text) + "";


                    MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            if (label_status_03.Text != "id")
            {
                string data_lanc = DateTime.Now.ToString("yyyy/MM/dd");
                int dia_lanc = DateTime.Today.Day;
                int mes_lanc = DateTime.Today.Month;
                int ano_lanc = DateTime.Today.Year;

                string marcador_mistura = text_tag_cod_mistura.Text;
                string tipo_mistura = combo_tipo_mistura.Text;

                string descr_mp = combo_mp_03.Text;
                double percentual_mistura = Convert.ToDouble(text_porcentagem_03.Text);
                string marcador_campo = combo_mp_03.Name;

                try
                {
                    string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    MySqlConnection conexao = new MySqlConnection(conecta_string);
                    conexao.Open();
                    string comando_sql;

                    comando_sql = "UPDATE db_cadastro_misturas SET " +
                        "data_lanc='" + data_lanc +
                        "', dia_lanc='" + dia_lanc +
                        "', mes_lanc='" + mes_lanc +
                        "', ano_lanc='" + ano_lanc +
                        "', marcador_mistura='" + marcador_mistura +
                        "', tipo_mistura='" + tipo_mistura +
                        "', descr_mp='" + descr_mp +
                        "', percentual_mistura='" + Convert.ToDouble(percentual_mistura) +
                        "', marcador_campo='" + marcador_campo +
                        "' WHERE id_estrutura=" + Convert.ToInt64(label_status_03.Text) + "";


                    MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            if (label_status_04.Text != "id")
            {
                string data_lanc = DateTime.Now.ToString("yyyy/MM/dd");
                int dia_lanc = DateTime.Today.Day;
                int mes_lanc = DateTime.Today.Month;
                int ano_lanc = DateTime.Today.Year;

                string marcador_mistura = text_tag_cod_mistura.Text;
                string tipo_mistura = combo_tipo_mistura.Text;

                string descr_mp = combo_mp_04.Text;
                double percentual_mistura = Convert.ToDouble(text_porcentagem_04.Text);
                string marcador_campo = combo_mp_04.Name;

                try
                {
                    string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    MySqlConnection conexao = new MySqlConnection(conecta_string);
                    conexao.Open();
                    string comando_sql;

                    comando_sql = "UPDATE db_cadastro_misturas SET " +
                        "data_lanc='" + data_lanc +
                        "', dia_lanc='" + dia_lanc +
                        "', mes_lanc='" + mes_lanc +
                        "', ano_lanc='" + ano_lanc +
                        "', marcador_mistura='" + marcador_mistura +
                        "', tipo_mistura='" + tipo_mistura +
                        "', descr_mp='" + descr_mp +
                        "', percentual_mistura='" + Convert.ToDouble(percentual_mistura) +
                        "', marcador_campo='" + marcador_campo +
                        "' WHERE id_estrutura=" + Convert.ToInt64(label_status_04.Text) + "";


                    MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            if (label_status_05.Text != "id")
            {
                string data_lanc = DateTime.Now.ToString("yyyy/MM/dd");
                int dia_lanc = DateTime.Today.Day;
                int mes_lanc = DateTime.Today.Month;
                int ano_lanc = DateTime.Today.Year;

                string marcador_mistura = text_tag_cod_mistura.Text;
                string tipo_mistura = combo_tipo_mistura.Text;

                string descr_mp = combo_mp_05.Text;
                double percentual_mistura = Convert.ToDouble(text_porcentagem_05.Text);
                string marcador_campo = combo_mp_05.Name;

                try
                {
                    string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    MySqlConnection conexao = new MySqlConnection(conecta_string);
                    conexao.Open();
                    string comando_sql;

                    comando_sql = "UPDATE db_cadastro_misturas SET " +
                        "data_lanc='" + data_lanc +
                        "', dia_lanc='" + dia_lanc +
                        "', mes_lanc='" + mes_lanc +
                        "', ano_lanc='" + ano_lanc +
                        "', marcador_mistura='" + marcador_mistura +
                        "', tipo_mistura='" + tipo_mistura +
                        "', descr_mp='" + descr_mp +
                        "', percentual_mistura='" + Convert.ToDouble(percentual_mistura) +
                        "', marcador_campo='" + marcador_campo +
                        "' WHERE id_estrutura=" + Convert.ToInt64(label_status_05.Text) + "";


                    MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            if (label_status_06.Text != "id")
            {
                string data_lanc = DateTime.Now.ToString("yyyy/MM/dd");
                int dia_lanc = DateTime.Today.Day;
                int mes_lanc = DateTime.Today.Month;
                int ano_lanc = DateTime.Today.Year;

                string marcador_mistura = text_tag_cod_mistura.Text;
                string tipo_mistura = combo_tipo_mistura.Text;

                string descr_mp = combo_mp_06.Text;
                double percentual_mistura = Convert.ToDouble(text_porcentagem_06.Text);
                string marcador_campo = combo_mp_06.Name;

                try
                {
                    string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    MySqlConnection conexao = new MySqlConnection(conecta_string);
                    conexao.Open();
                    string comando_sql;

                    comando_sql = "UPDATE db_cadastro_misturas SET " +
                        "data_lanc='" + data_lanc +
                        "', dia_lanc='" + dia_lanc +
                        "', mes_lanc='" + mes_lanc +
                        "', ano_lanc='" + ano_lanc +
                        "', marcador_mistura='" + marcador_mistura +
                        "', tipo_mistura='" + tipo_mistura +
                        "', descr_mp='" + descr_mp +
                        "', percentual_mistura='" + Convert.ToDouble(percentual_mistura) +
                        "', marcador_campo='" + marcador_campo +
                        "' WHERE id_estrutura=" + Convert.ToInt64(label_status_06.Text) + "";


                    MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            if (label_status_07.Text != "id")
            {
                string data_lanc = DateTime.Now.ToString("yyyy/MM/dd");
                int dia_lanc = DateTime.Today.Day;
                int mes_lanc = DateTime.Today.Month;
                int ano_lanc = DateTime.Today.Year;

                string marcador_mistura = text_tag_cod_mistura.Text;
                string tipo_mistura = combo_tipo_mistura.Text;

                string descr_mp = combo_mp_07.Text;
                double percentual_mistura = Convert.ToDouble(text_porcentagem_07.Text);
                string marcador_campo = combo_mp_07.Name;

                try
                {
                    string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    MySqlConnection conexao = new MySqlConnection(conecta_string);
                    conexao.Open();
                    string comando_sql;

                    comando_sql = "UPDATE db_cadastro_misturas SET " +
                        "data_lanc='" + data_lanc +
                        "', dia_lanc='" + dia_lanc +
                        "', mes_lanc='" + mes_lanc +
                        "', ano_lanc='" + ano_lanc +
                        "', marcador_mistura='" + marcador_mistura +
                        "', tipo_mistura='" + tipo_mistura +
                        "', descr_mp='" + descr_mp +
                        "', percentual_mistura='" + Convert.ToDouble(percentual_mistura) +
                        "', marcador_campo='" + marcador_campo +
                        "' WHERE id_estrutura=" + Convert.ToInt64(label_status_07.Text) + "";


                    MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            if (label_status_08.Text != "id")
            {
                string data_lanc = DateTime.Now.ToString("yyyy/MM/dd");
                int dia_lanc = DateTime.Today.Day;
                int mes_lanc = DateTime.Today.Month;
                int ano_lanc = DateTime.Today.Year;

                string marcador_mistura = text_tag_cod_mistura.Text;
                string tipo_mistura = combo_tipo_mistura.Text;

                string descr_mp = combo_mp_08.Text;
                double percentual_mistura = Convert.ToDouble(text_porcentagem_08.Text);
                string marcador_campo = combo_mp_08.Name;

                try
                {
                    string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    MySqlConnection conexao = new MySqlConnection(conecta_string);
                    conexao.Open();
                    string comando_sql;

                    comando_sql = "UPDATE db_cadastro_misturas SET " +
                        "data_lanc='" + data_lanc +
                        "', dia_lanc='" + dia_lanc +
                        "', mes_lanc='" + mes_lanc +
                        "', ano_lanc='" + ano_lanc +
                        "', marcador_mistura='" + marcador_mistura +
                        "', tipo_mistura='" + tipo_mistura +
                        "', descr_mp='" + descr_mp +
                        "', percentual_mistura='" + Convert.ToDouble(percentual_mistura) +
                        "', marcador_campo='" + marcador_campo +
                        "' WHERE id_estrutura=" + Convert.ToInt64(label_status_08.Text) + "";


                    MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            if (label_status_09.Text != "id")
            {
                string data_lanc = DateTime.Now.ToString("yyyy/MM/dd");
                int dia_lanc = DateTime.Today.Day;
                int mes_lanc = DateTime.Today.Month;
                int ano_lanc = DateTime.Today.Year;

                string marcador_mistura = text_tag_cod_mistura.Text;
                string tipo_mistura = combo_tipo_mistura.Text;

                string descr_mp = combo_mp_09.Text;
                double percentual_mistura = Convert.ToDouble(text_porcentagem_09.Text);
                string marcador_campo = combo_mp_09.Name;

                try
                {
                    string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    MySqlConnection conexao = new MySqlConnection(conecta_string);
                    conexao.Open();
                    string comando_sql;

                    comando_sql = "UPDATE db_cadastro_misturas SET " +
                        "data_lanc='" + data_lanc +
                        "', dia_lanc='" + dia_lanc +
                        "', mes_lanc='" + mes_lanc +
                        "', ano_lanc='" + ano_lanc +
                        "', marcador_mistura='" + marcador_mistura +
                        "', tipo_mistura='" + tipo_mistura +
                        "', descr_mp='" + descr_mp +
                        "', percentual_mistura='" + Convert.ToDouble(percentual_mistura) +
                        "', marcador_campo='" + marcador_campo +
                        "' WHERE id_estrutura=" + Convert.ToInt64(label_status_09.Text) + "";


                    MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            if (label_status_10.Text != "id")
            {
                string data_lanc = DateTime.Now.ToString("yyyy/MM/dd");
                int dia_lanc = DateTime.Today.Day;
                int mes_lanc = DateTime.Today.Month;
                int ano_lanc = DateTime.Today.Year;

                string marcador_mistura = text_tag_cod_mistura.Text;
                string tipo_mistura = combo_tipo_mistura.Text;

                string descr_mp = combo_mp_10.Text;
                double percentual_mistura = Convert.ToDouble(text_porcentagem_10.Text);
                string marcador_campo = combo_mp_10.Name;

                try
                {
                    string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    MySqlConnection conexao = new MySqlConnection(conecta_string);
                    conexao.Open();
                    string comando_sql;

                    comando_sql = "UPDATE db_cadastro_misturas SET " +
                        "data_lanc='" + data_lanc +
                        "', dia_lanc='" + dia_lanc +
                        "', mes_lanc='" + mes_lanc +
                        "', ano_lanc='" + ano_lanc +
                        "', marcador_mistura='" + marcador_mistura +
                        "', tipo_mistura='" + tipo_mistura +
                        "', descr_mp='" + descr_mp +
                        "', percentual_mistura='" + Convert.ToDouble(percentual_mistura) +
                        "', marcador_campo='" + marcador_campo +
                        "' WHERE id_estrutura=" + Convert.ToInt64(label_status_10.Text) + "";


                    MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
        }
        private void Deletar_targ_mistura(string num_transac)
        {
            string comando_sql;
            string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
            MySqlConnection conexao = new MySqlConnection(conecta_string);
            conexao.Open();
            try
            {
                comando_sql = "DELETE FROM db_cadastro_misturas WHERE num_transac ='" + num_transac + "'";

                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }


        }

        #endregion

        #region Contrle de Botões // Combos // textbox

        private void button_salvar_Click(object sender, EventArgs e)
        {

            try
            {
                if (Convert.ToDouble(label_total_percet.Text) != 100)
                {
                    MessageBox.Show("Mistura Diferente de 100%!");

                }
                else if (text_tag_cod_mistura.Text == string.Empty)
                {
                    MessageBox.Show("Campo [Cod. Mistura] não pode ficar em branco!");
                }
                else
                {
                    Salvar_tag_mistura();
                    MessageBox.Show("Salvo com sucesso!");
                    limpar_campos();
                    Carregar_tag_mistura();
                }
            }
            catch (Exception)
            {

            }



        }
        private void button_atualizar_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(label_total_percet.Text) != 100)
            {
                MessageBox.Show("Mistura Diferente de 100%!");
            }
            else
            {
                Atualizar_tags_mistura();
                MessageBox.Show("Atualizado com sucesso!");
                //limpar_campos();
                Carregar_tag_mistura();

            }
        }
        private void button_delete_Click(object sender, EventArgs e)
        {

            DialogResult resposta = MessageBox.Show(this, "Deseja excluir a mistura ??", "Misturas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                Deletar_targ_mistura(label_num_transa.Text);
                limpar_campos();
                Carregar_tag_mistura();
            }


        }
        private void combo_tag_mistura_SelectedIndexChanged(object sender, EventArgs e)
        {
            Carregar_misturas_tag(combo_tag_mistura.Text);
        }
        private void text_porcentagem_01_TextChanged(object sender, EventArgs e)
        {
            double resultado = 0;
            resultado = Soma_percentual(text_porcentagem_01.Text, text_porcentagem_02.Text, text_porcentagem_03.Text, text_porcentagem_04.Text, text_porcentagem_05.Text, text_porcentagem_06.Text, text_porcentagem_07.Text, text_porcentagem_08.Text, text_porcentagem_09.Text, text_porcentagem_10.Text);
            label_total_percet.Text = Convert.ToString(resultado);

            //Configuração de cor se ficar acima de 100%
            if (Convert.ToDouble(label_total_percet.Text) == 100)
            {
                label_total_percet.BackColor = Color.LightGreen;
            }

            if (Convert.ToDouble(label_total_percet.Text) > 100)
            {
                label_total_percet.BackColor = Color.OrangeRed;
            }

            if (Convert.ToDouble(label_total_percet.Text) < 100)
            {
                label_total_percet.BackColor = Color.Transparent;
            }

        }
        private void text_porcentagem_02_TextChanged(object sender, EventArgs e)
        {
            double resultado = 0;
            resultado = Soma_percentual(text_porcentagem_01.Text, text_porcentagem_02.Text, text_porcentagem_03.Text, text_porcentagem_04.Text, text_porcentagem_05.Text, text_porcentagem_06.Text, text_porcentagem_07.Text, text_porcentagem_08.Text, text_porcentagem_09.Text, text_porcentagem_10.Text);
            label_total_percet.Text = Convert.ToString(resultado);

            //Configuração de cor se ficar acima de 100%
            if (Convert.ToDouble(label_total_percet.Text) == 100)
            {
                label_total_percet.BackColor = Color.LightGreen;
            }

            if (Convert.ToDouble(label_total_percet.Text) > 100)
            {
                label_total_percet.BackColor = Color.OrangeRed;
            }

            if (Convert.ToDouble(label_total_percet.Text) < 100)
            {
                label_total_percet.BackColor = Color.Transparent;
            }


        }
        private void text_porcentagem_03_TextChanged(object sender, EventArgs e)
        {
            double resultado = 0;
            resultado = Soma_percentual(text_porcentagem_01.Text, text_porcentagem_02.Text, text_porcentagem_03.Text, text_porcentagem_04.Text, text_porcentagem_05.Text, text_porcentagem_06.Text, text_porcentagem_07.Text, text_porcentagem_08.Text, text_porcentagem_09.Text, text_porcentagem_10.Text);
            label_total_percet.Text = Convert.ToString(resultado);

            //Configuração de cor se ficar acima de 100%
            if (Convert.ToDouble(label_total_percet.Text) == 100)
            {
                label_total_percet.BackColor = Color.LightGreen;
            }

            if (Convert.ToDouble(label_total_percet.Text) > 100)
            {
                label_total_percet.BackColor = Color.OrangeRed;
            }

            if (Convert.ToDouble(label_total_percet.Text) < 100)
            {
                label_total_percet.BackColor = Color.Transparent;
            }

        }
        private void text_porcentagem_04_TextChanged(object sender, EventArgs e)
        {
            double resultado = 0;
            resultado = Soma_percentual(text_porcentagem_01.Text, text_porcentagem_02.Text, text_porcentagem_03.Text, text_porcentagem_04.Text, text_porcentagem_05.Text, text_porcentagem_06.Text, text_porcentagem_07.Text, text_porcentagem_08.Text, text_porcentagem_09.Text, text_porcentagem_10.Text);
            label_total_percet.Text = Convert.ToString(resultado);

            //Configuração de cor se ficar acima de 100%
            if (Convert.ToDouble(label_total_percet.Text) == 100)
            {
                label_total_percet.BackColor = Color.LightGreen;
            }

            if (Convert.ToDouble(label_total_percet.Text) > 100)
            {
                label_total_percet.BackColor = Color.OrangeRed;
            }

            if (Convert.ToDouble(label_total_percet.Text) < 100)
            {
                label_total_percet.BackColor = Color.Transparent;
            }

        }
        private void text_porcentagem_05_TextChanged(object sender, EventArgs e)
        {
            double resultado = 0;
            resultado = Soma_percentual(text_porcentagem_01.Text, text_porcentagem_02.Text, text_porcentagem_03.Text, text_porcentagem_04.Text, text_porcentagem_05.Text, text_porcentagem_06.Text, text_porcentagem_07.Text, text_porcentagem_08.Text, text_porcentagem_09.Text, text_porcentagem_10.Text);
            label_total_percet.Text = Convert.ToString(resultado);

            //Configuração de cor se ficar acima de 100%
            if (Convert.ToDouble(label_total_percet.Text) == 100)
            {
                label_total_percet.BackColor = Color.LightGreen;
            }

            if (Convert.ToDouble(label_total_percet.Text) > 100)
            {
                label_total_percet.BackColor = Color.OrangeRed;
            }

            if (Convert.ToDouble(label_total_percet.Text) < 100)
            {
                label_total_percet.BackColor = Color.Transparent;
            }

        }
        private void text_porcentagem_06_TextChanged(object sender, EventArgs e)
        {
            double resultado = 0;
            resultado = Soma_percentual(text_porcentagem_01.Text, text_porcentagem_02.Text, text_porcentagem_03.Text, text_porcentagem_04.Text, text_porcentagem_05.Text, text_porcentagem_06.Text, text_porcentagem_07.Text, text_porcentagem_08.Text, text_porcentagem_09.Text, text_porcentagem_10.Text);
            label_total_percet.Text = Convert.ToString(resultado);

            //Configuração de cor se ficar acima de 100%
            if (Convert.ToDouble(label_total_percet.Text) == 100)
            {
                label_total_percet.BackColor = Color.LightGreen;
            }

            if (Convert.ToDouble(label_total_percet.Text) > 100)
            {
                label_total_percet.BackColor = Color.OrangeRed;
            }

            if (Convert.ToDouble(label_total_percet.Text) < 100)
            {
                label_total_percet.BackColor = Color.Transparent;
            }

        }
        private void text_porcentagem_07_TextChanged(object sender, EventArgs e)
        {
            double resultado = 0;
            resultado = Soma_percentual(text_porcentagem_01.Text, text_porcentagem_02.Text, text_porcentagem_03.Text, text_porcentagem_04.Text, text_porcentagem_05.Text, text_porcentagem_06.Text, text_porcentagem_07.Text, text_porcentagem_08.Text, text_porcentagem_09.Text, text_porcentagem_10.Text);
            label_total_percet.Text = Convert.ToString(resultado);

            //Configuração de cor se ficar acima de 100%
            if (Convert.ToDouble(label_total_percet.Text) == 100)
            {
                label_total_percet.BackColor = Color.LightGreen;
            }

            if (Convert.ToDouble(label_total_percet.Text) > 100)
            {
                label_total_percet.BackColor = Color.OrangeRed;
            }

            if (Convert.ToDouble(label_total_percet.Text) < 100)
            {
                label_total_percet.BackColor = Color.Transparent;
            }

        }
        private void text_porcentagem_08_TextChanged(object sender, EventArgs e)
        {
            double resultado = 0;
            resultado = Soma_percentual(text_porcentagem_01.Text, text_porcentagem_02.Text, text_porcentagem_03.Text, text_porcentagem_04.Text, text_porcentagem_05.Text, text_porcentagem_06.Text, text_porcentagem_07.Text, text_porcentagem_08.Text, text_porcentagem_09.Text, text_porcentagem_10.Text);
            label_total_percet.Text = Convert.ToString(resultado);

            //Configuração de cor se ficar acima de 100%
            if (Convert.ToDouble(label_total_percet.Text) == 100)
            {
                label_total_percet.BackColor = Color.LightGreen;
            }

            if (Convert.ToDouble(label_total_percet.Text) > 100)
            {
                label_total_percet.BackColor = Color.OrangeRed;
            }

            if (Convert.ToDouble(label_total_percet.Text) < 100)
            {
                label_total_percet.BackColor = Color.Transparent;
            }
        }
        private void text_porcentagem_09_TextChanged(object sender, EventArgs e)
        {
            double resultado = 0;
            resultado = Soma_percentual(text_porcentagem_01.Text, text_porcentagem_02.Text, text_porcentagem_03.Text, text_porcentagem_04.Text, text_porcentagem_05.Text, text_porcentagem_06.Text, text_porcentagem_07.Text, text_porcentagem_08.Text, text_porcentagem_09.Text, text_porcentagem_10.Text);
            label_total_percet.Text = Convert.ToString(resultado);

            //Configuração de cor se ficar acima de 100%
            if (Convert.ToDouble(label_total_percet.Text) == 100)
            {
                label_total_percet.BackColor = Color.LightGreen;
            }

            if (Convert.ToDouble(label_total_percet.Text) > 100)
            {
                label_total_percet.BackColor = Color.OrangeRed;
            }

            if (Convert.ToDouble(label_total_percet.Text) < 100)
            {
                label_total_percet.BackColor = Color.Transparent;
            }
        }
        private void text_porcentagem_10_TextChanged(object sender, EventArgs e)
        {
            double resultado = 0;
            resultado = Soma_percentual(text_porcentagem_01.Text, text_porcentagem_02.Text, text_porcentagem_03.Text, text_porcentagem_04.Text, text_porcentagem_05.Text, text_porcentagem_06.Text, text_porcentagem_07.Text, text_porcentagem_08.Text, text_porcentagem_09.Text, text_porcentagem_10.Text);
            label_total_percet.Text = Convert.ToString(resultado);

            //Configuração de cor se ficar acima de 100%
            if (Convert.ToDouble(label_total_percet.Text) == 100)
            {
                label_total_percet.BackColor = Color.LightGreen;
            }

            if (Convert.ToDouble(label_total_percet.Text) > 100)
            {
                label_total_percet.BackColor = Color.OrangeRed;
            }

            if (Convert.ToDouble(label_total_percet.Text) < 100)
            {
                label_total_percet.BackColor = Color.Transparent;
            }
        }

        #endregion
    }
}
