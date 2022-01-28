using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace JP4
{
    public partial class STOQ01 : Form
    {
        public STOQ01()
        {
            InitializeComponent();

            Bloquear_controles();
            Carregar_empresa_db();
            Carrega_secao_maquina();
            Carrega_locais();
            Carrega_grid();

            Carrega_descr_completa();
            Carrega_iten();

            Carrega_operacao(this.Name);

            text_tipo_mov.Text = "N";
            combo_local_orig.Text = "ALMOXARIF";
            combo_local_destino.Text = "PRODUCAO";

            textBox_ano_filtro.Text = Convert.ToString(0);
            comboBox_mes_filtro.Text = Convert.ToString(0);

        }



        #region Metodos de busca
        private string Busca_descricao_operacao(string codigo)
        {
            string resultado_descri_operacao = string.Empty;

            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                //IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                //string local_default = @"C:\JP4";
                //string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select * from db_cadastro_operacao where codigo = '" + codigo + "'";

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    resultado_descri_operacao = myreader["descricao"].ToString();
                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }

            return resultado_descri_operacao;

        }
        private string Buscar_item(string descricao_completa)
        {
            string resultado_item = string.Empty;

            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                //IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                //string local_default = @"C:\JP4";
                //string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select * from db_cadastro_material where descricao_completa ='" + descricao_completa + "'";

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    resultado_item = myreader["codigo_item"].ToString();
                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }

            return resultado_item;
        }
        private string Buscar_descri(string codigo_item)
        {

            string resultado_descri = string.Empty;

            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                //IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                //string local_default = @"C:\JP4";
                //string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select * from db_cadastro_material where codigo_item ='" + codigo_item + "'";

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    resultado_descri = myreader["descricao_completa"].ToString();
                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }

            return resultado_descri;
        }
        private string Buscar_tipo_material(string cod_descri_completa)
        {
            string tipo_material = "";
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                //IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                //string local_default = @"C:\JP4";
                //string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select tipo_material from db_cadastro_material where descricao_completa='" + cod_descri_completa + "'";

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    tipo_material = myreader["tipo_material"].ToString();
                }

                conexao.Close();


            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

            return tipo_material;

        }
        private string Gerar_num_transac(double num_docum, DateTime hr_atual)
        {
            string resultado;

            resultado = Convert.ToString(num_docum) + hr_atual.Hour + hr_atual.Minute + hr_atual.Second;
            return resultado;

        }
        private string Busca_tipo_baixa(string operacao)
        {
            string resultado_tipo = string.Empty;

            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                //IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                //string local_default = @"C:\JP4";
                //string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select * from db_cadastro_operacao where codigo = '" + operacao + "'";

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    resultado_tipo = (myreader["tipo_operacao"].ToString());
                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }

            return resultado_tipo;
        }
        private void Filtrar_grid_mes_ano(int mes_movto, int ano_movto)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                //IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                //string local_default = @"C:\JP4";
                //string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select id_estoque_trans, cod_descri_completa, cod_operacao, num_docum, qtd_movto, secao_nome, data_operac, observacao, mes_movto, ano_movto, cod_local_est_orig, cod_local_est_dest from estoque_trans";

                MySqlConnection connection = new MySqlConnection(conecta_string);
                MySqlDataAdapter myadapter = new MySqlDataAdapter(comando_sql, connection);
                DataTable dt = new DataTable("estoque_trans");
                myadapter.Fill(dt);
                DataView dv = dt.DefaultView;

                if (mes_movto != 0)
                {
                    //dv.RowFilter = string.Format("mes_movto like '%{0}%'", mes_movto);
                    dv.RowFilter = string.Format("CONVERT(mes_movto, 'System.String') like '%{0}%'", mes_movto.ToString());
                    grid_mov_estoque.DataSource = dv.ToTable();
                }
                if (ano_movto != 0)
                {
                    //dv.RowFilter = string.Format("ano_movto like '%{0}%'", ano_movto);
                    dv.RowFilter = string.Format("CONVERT(ano_movto, 'System.String') like '%{0}%'", ano_movto.ToString());
                    grid_mov_estoque.DataSource = dv.ToTable();
                }


                connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }
        private void Filtrar_grid_pesquisar(string cod_descri_completa, string cod_operacao, string cod_local_est_orig, string cod_local_est_dest)
        {

            try
            {

                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                //IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                //string local_default = @"C:\JP4";
                //string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select id_estoque_trans, cod_descri_completa, cod_operacao, num_docum, qtd_movto, secao_nome, data_operac, observacao, mes_movto, ano_movto, cod_local_est_orig, cod_local_est_dest from estoque_trans";

                MySqlConnection connection = new MySqlConnection(conecta_string);
                MySqlDataAdapter myadapter = new MySqlDataAdapter(comando_sql, connection);
                DataTable dt = new DataTable("estoque_trans");
                myadapter.Fill(dt);
                DataView dv = dt.DefaultView;

                //if (dat_movto != string.Empty)
                //dv.RowFilter = string.Format("CONVERT(dat_movto, 'System.String') like '%{0}%'", dat_movto.ToString());
                //grid_mov_estoque.DataSource = dv.ToTable();

                //if (dat_proces != string.Empty)
                //dv.RowFilter = string.Format("CONVERT(dat_proces, 'System.String') like '%{0}%'", dat_proces.ToString());
                //grid_mov_estoque.DataSource = dv.ToTable();

                //if (mes_movto != 0)
                //{
                //    //dv.RowFilter = string.Format("mes_movto like '%{0}%'", mes_movto);
                //    dv.RowFilter = string.Format("CONVERT(mes_movto, 'System.String') like '%{0}%'", mes_movto.ToString());
                //    grid_mov_estoque.DataSource = dv.ToTable();
                //}
                //if (ano_movto != 0)
                //{
                //    //dv.RowFilter = string.Format("ano_movto like '%{0}%'", ano_movto);
                //    dv.RowFilter = string.Format("CONVERT(ano_movto, 'System.String') like '%{0}%'", ano_movto.ToString());
                //    grid_mov_estoque.DataSource = dv.ToTable();
                //}

                if (cod_descri_completa != string.Empty)
                {
                    dv.RowFilter = string.Format("cod_descri_completa like '%{0}%'", cod_descri_completa);
                    grid_mov_estoque.DataSource = dv.ToTable();
                }
                if (cod_operacao != string.Empty)
                {
                    dv.RowFilter = string.Format("cod_operacao like '%{0}%'", cod_operacao);
                    grid_mov_estoque.DataSource = dv.ToTable();
                }

                if (cod_local_est_orig != string.Empty)
                {
                    dv.RowFilter = string.Format("cod_local_est_orig like '%{0}%'", cod_local_est_orig);
                    grid_mov_estoque.DataSource = dv.ToTable();
                }

                if (cod_local_est_dest != string.Empty)
                {
                    dv.RowFilter = string.Format("cod_local_est_dest like '%{0}%'", cod_local_est_dest);
                    grid_mov_estoque.DataSource = dv.ToTable();
                }

                //dv.RowFilter = string.Format("codigo_item like '%{0}%', status_item like '%{1}%', grupo like '%{2}%', descricao_completa like '%{3}%' ", codigo_item, status_item, grupo_item, descri_completa);
                //grid_cadastro.DataSource = dv.ToTable();


                connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }


        #endregion

        #region Metodos Limpeza // bloqueio
        private void Desbloquear_controles()
        {
            combo_cod_item.Enabled = true;
            combo_descri_completa.Enabled = true;
            combo_operacao.Enabled = true;
            text_num_documento.Enabled = true;
            combo_secao_maquina.Enabled = true;
            text_qtd_movt.Enabled = true;
            combo_local_orig.Enabled = true;
            combo_local_destino.Enabled = true;
            rich_observa.Enabled = true;
        }
        private void Bloquear_controles()
        {
            combo_cod_item.Enabled = false;
            combo_descri_completa.Enabled = false;
            combo_operacao.Enabled = false;
            text_num_documento.Enabled = false;
            combo_secao_maquina.Enabled = false;
            text_qtd_movt.Enabled = false;
            combo_local_orig.Enabled = false;
            combo_local_destino.Enabled = false;
            rich_observa.Enabled = false;
        }
        private void Limpar_controles()
        {
            combo_cod_item.Text = string.Empty;
            combo_descri_completa.Text = string.Empty;
            combo_operacao.Text = string.Empty;
            text_num_documento.Text = string.Empty;
            combo_secao_maquina.Text = string.Empty;
            text_qtd_movt.Text = string.Empty;
            combo_local_orig.Text = string.Empty;
            combo_local_destino.Text = string.Empty;
            rich_observa.Text = string.Empty;

            textBox_ano_filtro.Text = "0";
            comboBox_mes_filtro.Text = "0";


        }


        #endregion

        #region Carregar controles
        private void Carregar_empresa_db()
        {
            try
            {

                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                //IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                //string local_default = @"C:\JP4";
                //string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select * from db_cadastro_empresas";

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();


                while (myreader.Read())
                {
                    combo_empresa.Items.Add(myreader["descricao"].ToString());
                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }
        private void Carregar_controles(string id_estoque_trans)
        {

            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                //IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                //string local_default = @"C:\JP4";
                //string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select * from estoque_trans where id_estoque_trans=" + id_estoque_trans;

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    combo_cod_item.Text = myreader["cod_item"].ToString();
                    combo_descri_completa.Text = myreader["cod_descri_completa"].ToString();
                    combo_operacao.Text = myreader["cod_operacao"].ToString();
                    text_num_documento.Text = myreader["num_docum"].ToString();
                    combo_secao_maquina.Text = myreader["num_secao_requis"].ToString();
                    text_qtd_movt.Text = Convert.ToString(Convert.ToDouble(myreader["qtd_movto"]) / Fator_conversao(combo_descri_completa.Text));
                    combo_local_orig.Text = myreader["cod_local_est_orig"].ToString();
                    combo_local_destino.Text = myreader["cod_local_est_dest"].ToString();
                    rich_observa.Text = myreader["observacao"].ToString();
                    dt_lancamento.Value = Convert.ToDateTime(myreader["dat_proces"].ToString());
                    dt_movt.Value = Convert.ToDateTime(myreader["dat_movto"].ToString());
                    combo_empresa.Text = myreader["cod_empresa"].ToString();
                    label_id_stoque_trans.Text = myreader["id_estoque_trans"].ToString();

                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }
        private void Carrega_iten()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                //IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                //string local_default = @"C:\JP4";
                //string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select * from db_cadastro_material where grupo <> '01'";

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    combo_cod_item.Items.Add(myreader["codigo_item"].ToString());
                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }
        private void Carrega_descr_completa()
        {
            // db_cadastro_material
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                //IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                //string local_default = @"C:\JP4";
                //string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select descricao_completa from db_cadastro_material where grupo <> '01'";

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    combo_descri_completa.Items.Add(myreader["descricao_completa"].ToString());
                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }

        }
        private void Carrega_operacao(string nome_programa)
        {

            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                //IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                //string local_default = @"C:\JP4";
                //string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select * from db_cadastro_operacao where nome_prog = '" + nome_programa + "'";

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    combo_operacao.Items.Add(myreader["codigo"].ToString());
                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }

        }
        private void Carrega_secao_maquina()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                //IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                //string local_default = @"C:\JP4";
                //string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select * from db_cadastro_equipamento";

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();


                while (myreader.Read())
                {
                    combo_secao_maquina.Items.Add(myreader["descricao_equipamento"].ToString());
                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }
        private void Carrega_locais()
        {

            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                //IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                //string local_default = @"C:\JP4";
                //string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select * from db_cadastro_local_estoque";

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {

                    combo_local_orig.Items.Add(myreader["local_estoque"].ToString());
                    combo_local_destino.Items.Add(myreader["local_estoque"].ToString());
                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }

        }
        private void Carrega_grid()
        {
            try
            {
                string cod_operacao = "APON";
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select id_estoque_trans, cod_descri_completa, cod_operacao, num_docum, qtd_movto, secao_nome, data_operac, observacao, mes_movto, ano_movto, cod_local_est_orig, cod_local_est_dest from estoque_trans " +
                    "where (cod_operacao <>'" + cod_operacao + "') AND (qtd_movto >= 0 AND status_estorno = 0)";

                // Verificar se ordem e qtd é igual 
                // se for igual não puxar
                //select cod_descri_completa, cod_operacao, cod_local_est_orig, cod_local_est_dest, mes_movto, ano_movto, dat_movto from estoque_trans

                MySqlConnection connection = new MySqlConnection(conecta_string);
                MySqlDataAdapter myadapter = new MySqlDataAdapter(comando_sql, connection);
                DataTable dt = new DataTable("estoque_trans");
                myadapter.Fill(dt);
                DataView dv = dt.DefaultView;
                grid_mov_estoque.DataSource = dt;
                connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        #endregion

        #region Metodos  Salvar // Estornar // Buscar

        private double Fator_conversao(string cod_descri_completa)
        {


            try
            {
                double resultado = 1;
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                //IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                //string local_default = @"C:\JP4";
                //string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select * from db_cadastro_material where descricao_completa = '" + cod_descri_completa + "'";

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    resultado = Convert.ToDouble(myreader["fator_multi"]);

                    if (resultado == 0)
                        resultado = 1;

                }

                conexao.Close();
                return resultado;

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }

            return 1;

        }
        private void Salvar_lancamento()
        {
            string cod_item = this.combo_cod_item.Text;
            string cod_descri_completa = combo_descri_completa.Text;
            string cod_operacao = combo_operacao.Text;
            double num_docum = Convert.ToDouble(text_num_documento.Text);
            string secao_nome = combo_secao_maquina.Text;
            string ies_tip_movto = text_tipo_mov.Text;

            // Como fazer insert valores mysql

            string qtd_movto = Convert.ToString(Convert.ToDouble(text_qtd_movt.Text) * Fator_conversao(cod_descri_completa)).Replace(',', '.');

            string qtd_real = string.Empty;
            if (Busca_tipo_baixa(combo_operacao.Text) == "Saida")
            {
                qtd_real = Convert.ToString(Convert.ToDouble(qtd_movto) * (-1));
            }
            if (Busca_tipo_baixa(combo_operacao.Text) == "Entrada")
            {
                qtd_real = Convert.ToString(qtd_movto);// * (-1);
            }

            //double qtd_real = qtd_movto;// * (-1);

            string cod_local_est_orig = combo_local_orig.Text;
            string cod_local_est_dest = combo_local_destino.Text;

            string observacao = rich_observa.Text;

            int mes_proces = DateTime.Now.Month;
            int mes_movto = DateTime.Now.Month;
            int ano_movto = DateTime.Now.Year;
            string dat_proces = DateTime.Today.ToString("yyyy-MM-dd");
            string dat_movto = dt_movt.Value.ToString("yyyy/MM/dd");

            string cod_empresa = combo_empresa.Text;
            string num_transac;

            // Não aproveita 

            string cod_descri_reduzida = "";
            double fardos = 0;
            double num_secao_requis = 1;
            string operador = "";
            string num_lote_orig = "";
            string num_lote_dest = "";
            string ies_sit_est_orig = "L";
            string ies_sit_est_dest = "L";
            string cod_turno = "";
            string nom_usuario = "";
            string num_prog = this.Name;
            double largura_material = 0;
            double n_bobina_inical = 0;
            double n_bobina_final = 0;
            double velocidade = 0;
            double contador_fardos = 0;
            double peso_medio_bobina = 0; // Fazer metodo pra calcular o peso
            double peso_total_fardo = 0; // Fazer metodos pra calcular
            string hora_inical = DateTime.Now.ToString("HH:mm:ss");
            string hora_final = DateTime.Now.ToString("HH:mm:ss");
            string data_operac = dt_lancamento.Value.ToString("yyyy/mm/dd");
            string hor_operac = DateTime.Now.ToString("HH:mm:ss");
            string Tipo_material = Buscar_tipo_material(combo_descri_completa.Text);
            int status_estorno = 0;
            string cliente_apon = "";

            num_transac = Gerar_num_transac(num_docum, Convert.ToDateTime(hor_operac));

            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                //IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                //string local_default = @"C:\JP4";
                //string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                conexao.Open();

                string comando_sql;

                comando_sql = "INSERT INTO estoque_trans(cod_empresa, num_transac, cod_item, cod_descri_completa, cod_descri_reduzida, mes_proces, mes_movto, ano_movto, dat_proces, dat_movto, cod_operacao, num_docum, ies_tip_movto, qtd_real, qtd_movto, num_secao_requis, operador, secao_nome, cod_local_est_orig, cod_local_est_dest, num_lote_orig, num_lote_dest, ies_sit_est_orig, ies_sit_est_dest, cod_turno, nom_usuario, num_prog, largura_material, n_bobina_inical, n_bobina_final, velocidade, contador, fardos, peso_medio_bobina, peso_total_fardo, hora_inical, hora_final, data_operac, hor_operac, Tipo_material, observacao, status_estorno, cliente_apon) " +
                    "VALUES('" + cod_empresa + "','" + num_transac + "','" + cod_item + "','" + cod_descri_completa + "','" + cod_descri_reduzida + "','" + mes_proces + "','" + mes_movto + "','" + ano_movto + "','" + dat_proces + "','" + dat_movto + "','" + cod_operacao + "','" + num_docum + "','" + ies_tip_movto + "','" + qtd_real + "','" + qtd_movto + "','" + num_secao_requis + "','" + operador + "','" + secao_nome + "','" + cod_local_est_orig + "','" + cod_local_est_dest + "','" + num_lote_orig + "','" + num_lote_dest + "','" + ies_sit_est_orig + "','" + ies_sit_est_dest + "','" + cod_turno + "','" + nom_usuario + "','" + num_prog + "','" + largura_material + "','" + n_bobina_inical + "','" + n_bobina_final + "','" + velocidade + "','" + contador_fardos + "','" + fardos + "','" + peso_medio_bobina + "','" + peso_total_fardo + "','" + hora_inical + "','" + hora_final + "','" + data_operac + "','" + hor_operac + "','" + Tipo_material + "','" + observacao + "','" + status_estorno + "','" + cliente_apon + "')";

                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }
        private void Atualizar_lancamento(string id_apontamento)
        {

            string cod_item = this.combo_cod_item.Text;
            string cod_descri_completa = combo_descri_completa.Text;
            string cod_operacao = combo_operacao.Text;
            double num_docum = Convert.ToDouble(text_num_documento.Text);
            string secao_nome = combo_secao_maquina.Text;
            string ies_tip_movto = text_tipo_mov.Text;

            string qtd_movto = text_qtd_movt.Text.Replace(',', '.');
            string qtd_real = qtd_movto;

            string cod_local_est_orig = combo_local_orig.Text;
            string cod_local_est_dest = combo_local_destino.Text;

            string observacao = rich_observa.Text;

            int mes_proces = DateTime.Now.Month;
            int mes_movto = DateTime.Now.Month;
            int ano_movto = DateTime.Now.Year;
            string dat_proces = DateTime.Today.ToString("yyyy/MM/dd");
            string dat_movto = dt_movt.Value.ToString("yyyy/MM/dd");

            string cod_empresa = combo_empresa.Text;
            string num_transac;

            // Não aproveita 

            //string cod_descri_reduzida;
            double fardos = 0;
            double num_secao_requis = 1;
            string operador = "";
            string num_lote_orig = "";
            string num_lote_dest = "";
            string ies_sit_est_orig = "L";
            string ies_sit_est_dest = "L";
            string cod_turno = "";
            string nom_usuario = "";
            string num_prog = this.Name;
            double largura_material = 0;
            double n_bobina_inical = 0;
            double n_bobina_final = 0;
            double velocidade = 0;
            double contador_fardos = 0;
            double peso_medio_bobina = 0; // Fazer metodo pra calcular o peso
            double peso_total_fardo = 0; // Fazer metodos pra calcular

            string hora_inical = DateTime.Now.ToString("HH:mm:ss");
            string hora_final = DateTime.Now.ToString("HH:mm:ss");
            string data_operac = dt_lancamento.Value.ToString("yyyy/mm/dd");
            string hor_operac = DateTime.Now.ToString("HH:mm:ss");
            string Tipo_material = Buscar_tipo_material(combo_descri_completa.Text);
            //int status_estorno;
            //string cliente_apon;

            num_transac = Gerar_num_transac(num_docum, Convert.ToDateTime(hor_operac));


            try
            {
                string comando_sql;

                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                //IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                //string local_default = @"C:\JP4";
                //string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                conexao.Open();


                comando_sql = "UPDATE estoque_trans SET " +
                        "cod_empresa='" + cod_empresa +
                        "', num_transac='" + num_transac +
                        "', cod_item='" + cod_item +
                        "', cod_descri_completa='" + cod_descri_completa +
                        "', mes_proces='" + mes_proces +
                        "', mes_movto='" + mes_movto +
                        "', ano_movto='" + ano_movto +
                        "', dat_proces='" + dat_proces +
                        "', dat_movto='" + dat_movto +
                        "', cod_operacao='" + cod_operacao +
                        "', num_docum='" + num_docum +
                        "', ies_tip_movto='" + ies_tip_movto +
                        "', qtd_real='" + qtd_real +
                        "', qtd_movto='" + qtd_movto +
                        "', num_secao_requis='" + num_secao_requis +
                        "', operador='" + operador +
                        "', secao_nome='" + secao_nome +
                        "', cod_local_est_orig='" + cod_local_est_orig +
                        "', cod_local_est_dest='" + cod_local_est_dest +
                        "', num_lote_orig='" + num_lote_orig +
                        "', num_lote_dest='" + num_lote_dest +
                        "', ies_sit_est_orig='" + ies_sit_est_orig +
                        "', ies_sit_est_dest='" + ies_sit_est_dest +
                        "', cod_turno='" + cod_turno +
                        "', nom_usuario='" + nom_usuario +
                        "', num_prog='" + num_prog +
                        "', largura_material='" + largura_material +
                        "', n_bobina_inical='" + n_bobina_inical +
                        "', n_bobina_final='" + n_bobina_final +
                        "', velocidade='" + velocidade +
                        "', contador='" + contador_fardos +
                        "', fardos='" + fardos +
                        "', peso_medio_bobina='" + peso_medio_bobina +
                        "', peso_total_fardo='" + peso_total_fardo +
                        "', hora_inical='" + hora_inical +
                        "', hora_final='" + hora_final +
                        "', data_operac='" + data_operac +
                        "', hor_operac='" + hor_operac +
                        "', Tipo_material='" + Tipo_material +
                        "', observacao='" + observacao +
                        "' WHERE id_estoque_trans=" + Convert.ToInt32(id_apontamento) + "";

                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();

                MessageBox.Show("Atualizado com sucesso");

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }
        private void Deletar_movimento(string id_apontamento)
        {

            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                //IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                //string local_default = @"C:\JP4";
                //string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                conexao.Open();

                string comando_sql;

                comando_sql = "DELETE FROM estoque_trans WHERE id_estoque_trans=" + Convert.ToInt32(id_apontamento);

                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();

                MessageBox.Show("Estornado com sucesso!");

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        #endregion


        #region Metodos de alimentação de estoque

        // Inventário Inicial (mais recente)
        // Entradas (NF + Ajustes )
        // Saidas (Vendas + Ajustes ) 
        // Saldo = (Iventario + entrada) - Saida
        // Salvar tudo isso em um banco separado

        #region Metodos de busca
        private string Buscar_tipo_oper(string codigo)
        {
            string tipo_operacao = string.Empty;

            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                //IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                //string local_default = @"C:\JP4";
                //string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select * from db_cadastro_operacao where codigo = '" + codigo + "'";

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    tipo_operacao = myreader["tipo_operacao"].ToString();
                }

                conexao.Close();

                return tipo_operacao;

            }
            catch
            {
                return string.Empty;
            }

        }
        #endregion

        #region Metodos Carregar
        private void Carregar_grid_estoque()
        {
            string tipo_operacao = Buscar_tipo_oper("APON");

            // todos os calculos devera s

        }
        #endregion


        public void Salvar_movto_estoque()
        {
            // data_movt, dia_movt, mes_movt, ano_movt, cod_item, den_item, qtd_invent_inicial, qtd_entradas, qtd_saidas, qtd_saldo, cod_local_destino, situa_qtd, cod_empresa, cod_barra, num_lote

            //DateTime data_movt;
            //int dia_movt = data_movt.Day;
            //int mes_movt = data_movt.Month;
            //int ano_movt = data_movt.Year;
            //string cod_item;
            //string den_item;
            //double qtd_invent_inicial;
            //double qtd_entradas;
            //double qtd_saidas;
            //double qtd_saldo; // Calculado
            //string cod_local_destino;
            //string situa_qtd;
            //string cod_empresa;
            //string cod_barra;
            //string num_lote;









        }

        public void Atualizar_movto_estoque()
        {

        }

        public void Deletar_movto_estoque()
        {

        }






        #endregion



        private void grid_mov_estoque_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id_estoque_trans = grid_mov_estoque.CurrentRow.Cells[0].Value.ToString();
            label_id_stoque_trans.Text = id_estoque_trans;
            Carregar_controles(id_estoque_trans);

        }



        private void text_num_documento_MouseHover(object sender, EventArgs e)
        {
            ToolTip myToolTip = new ToolTip();
            string aviso = "Somente numeros";
            myToolTip.Show(aviso, text_num_documento);
        }

        private void combo_cod_item_Leave(object sender, EventArgs e)
        {
            combo_descri_completa.Text = Buscar_descri(combo_cod_item.Text);
        }

        private void combo_descri_completa_Leave(object sender, EventArgs e)
        {
            combo_cod_item.Text = Buscar_item(combo_descri_completa.Text);
        }

        private void combo_operacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_descricao_operacao.Text = Busca_descricao_operacao(combo_operacao.Text);

        }

        private void comboBox_mes_filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtrar_grid_mes_ano(Convert.ToInt32(comboBox_mes_filtro.Text), Convert.ToInt32(textBox_ano_filtro.Text));
        }

        private void inventárioMensalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_janela_inven_geral janela_inventario_geral = new Form_janela_inven_geral();
            janela_inventario_geral.ShowDialog();
        }

        private void button_iniciar_Click_1(object sender, EventArgs e)
        {
            Limpar_controles();
            Desbloquear_controles();
        }

        private void button_salvar_Click_1(object sender, EventArgs e)
        {
            Salvar_lancamento();
            Limpar_controles();
            Carrega_grid();
        }

        private void button_atualizar_Click(object sender, EventArgs e)
        {
            Atualizar_lancamento(label_id_stoque_trans.Text);
            Limpar_controles();
            Carrega_grid();
        }

        private void button_estornar_Click_1(object sender, EventArgs e)
        {
            Deletar_movimento(label_id_stoque_trans.Text);
            Limpar_controles();
            Carrega_grid();
        }

        private void button_buscar_Click_1(object sender, EventArgs e)
        {
            Filtrar_grid_pesquisar(combo_descri_completa.Text, combo_operacao.Text, combo_local_orig.Text, combo_local_destino.Text);
        }

        private void button_limpar_filtro_Click_1(object sender, EventArgs e)
        {
            Limpar_controles();
            Carrega_grid();
        }

        private void relatorioEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_janela_estoque relatorio_estoque = new Form_janela_estoque();
            relatorio_estoque.ShowDialog();
        }
    }
}
