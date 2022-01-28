using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace JP4
{
    public partial class Form_janela_retrabalho : Form
    {


        public Form_janela_retrabalho()
        {
            InitializeComponent();

            origem_combo_mes.Text = Convert.ToString(DateTime.Now.Month);

            Carregar_grid(Convert.ToInt32(origem_combo_mes.Text));
            Carregar_controle_ordem();

        }

        // Janela de retrabalho esta dando muito trabalho
        // ainda precisa melhorar a logica dos filtros e busca no banco de dados
        // Pensar numa forma de transformar os fardos "errados" sem precisar estornar

        #region Metodos para filtrar

        private void Filtrar_gird_ordem_prod(double num_docum)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                //IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                //string local_default = @"C:\JP4";
                //string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select id_estoque_trans, select dat_movto, num_docum, cod_descri_completa, secao_nome, operador, cod_local_est_dest, fardos from estoque_trans where ordem_prod = " + num_docum;

                MySqlConnection connection = new MySqlConnection(conecta_string);
                MySqlDataAdapter myadapter = new MySqlDataAdapter(comando_sql, connection);
                DataTable dt = new DataTable("estoque_trans");
                myadapter.Fill(dt);
                DataView dv = dt.DefaultView;
                grid_retrabalho.DataSource = dt;
                connection.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void Filtrar_gird_data(DateTime data_movt)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                //IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                //string local_default = @"C:\JP4";
                //string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select id_estoque_trans, select dat_movto, num_docum, cod_descri_completa, secao_nome, operador, cod_local_est_dest, fardos from estoque_trans where date(dat_movto) = " + data_movt;

                MySqlConnection connection = new MySqlConnection(conecta_string);
                MySqlDataAdapter myadapter = new MySqlDataAdapter(comando_sql, connection);
                DataTable dt = new DataTable("estoque_trans");
                myadapter.Fill(dt);
                DataView dv = dt.DefaultView;
                grid_retrabalho.DataSource = dt;
                connection.Close();


            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        #endregion

        #region Metodos Carregar controles
        private void Carregar_controle_ordem()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                //IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                //string local_default = @"C:\JP4";
                //string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select distinct num_docum from estoque_trans";

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    origem_combo_ordem_prod.Items.Add(myreader["num_docum"].ToString());
                }

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Carregar_grid(int mes_movto)
        {
            try
            {
                // Mudei para aceitar o cliente

                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                //IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                //string local_default = @"C:\JP4";
                //string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select id_estoque_trans, dat_movto, num_docum, cod_descri_completa, secao_nome, operador, cod_local_est_dest, fardos from estoque_trans where mes_movto=" + mes_movto;

                MySqlConnection connection = new MySqlConnection(conecta_string);
                MySqlDataAdapter myadapter = new MySqlDataAdapter(comando_sql, connection);
                DataTable dt = new DataTable("estoque_trans");
                myadapter.Fill(dt);
                DataView dv = dt.DefaultView;
                grid_retrabalho.DataSource = dt;
                connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }



        #endregion

        #region Metodos de busca

        private void Busca_apon_ordem(DateTime data_apontamento)
        {
            // alimenta o campo de ordem de produção

            int dia = data_apontamento.Day;
            int mes = data_apontamento.Month;
            int ano = data_apontamento.Year;



            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                //IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                //string local_default = @"C:\JP4";
                //string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select * from estoque_trans where cod_operacao = 'APON'";

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    int dia_db = Convert.ToDateTime(myreader["dat_movto"]).Day;
                    int mes_db = Convert.ToDateTime(myreader["dat_movto"]).Month;
                    int ano_db = Convert.ToDateTime(myreader["dat_movto"]).Year;

                    if (dia == dia_db && mes == mes_db && ano == ano_db)
                    {
                        origem_combo_ordem_prod.Items.Add(myreader["num_docum"].ToString());
                    }

                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }

        }
        private void Busca_apon_maquina(double ordem_prod)
        {
            // alimenta o campo de maquina
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                //IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                //string local_default = @"C:\JP4";
                //string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select * from estoque_trans where cod_operacao = 'APON' AND num_docum = " + ordem_prod;

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    origem_text_descri_item.Text = myreader["cod_descri_completa"].ToString();
                    origem_combo_maquina.Items.Add(myreader["secao_nome"].ToString());

                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }

        }
        private void Busca_maquina(double ordem_prod)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                //IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                //string local_default = @"C:\JP4";
                //string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select distinct secao_nome from estoque_trans where cod_operacao = 'APON' AND num_docum = " + ordem_prod;

                //SELECT DISTINCT Names FROM MstNames
                // TEm que achar um jeito de fazer isso aqui retornar somente itens distintos

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    origem_combo_maquina.Items.Add(myreader["secao_nome"].ToString());

                }

                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void Busca_operador_afins(double ordem_prod, string maquina)
        {
            // operador
            // Local destino
            // qtd fardo

            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                //IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                //string local_default = @"C:\JP4";
                //string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select * from estoque_trans where cod_operacao = 'APON' AND num_docum = " + ordem_prod + " AND secao_nome = '" + maquina + "'";

                //SELECT DISTINCT Names FROM MstNames
                // TEm que achar um jeito de fazer isso aqui retornar somente itens distintos

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    origem_combo_operador.Items.Add(myreader["operador"].ToString()); // tem que ser distinto
                    origem_combo_local_destino.Items.Add(myreader["cod_local_est_dest"].ToString());
                    origem_text_qtd_fardo.Text = myreader["fardos"].ToString();

                }

                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }


        }

        #endregion

        private void origem_dt_apontameno_ValueChanged(object sender, EventArgs e)
        {
            Filtrar_gird_data(origem_dt_apontameno.Value);
        }
        private void origem_combo_ordem_prod_SelectedIndexChanged(object sender, EventArgs e) { }
        private void origem_combo_maquina_SelectedIndexChanged(object sender, EventArgs e) { }

        private void origem_combo_mes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Carregar_grid(Convert.ToInt32(origem_combo_mes.Text));
        }
    }
}
