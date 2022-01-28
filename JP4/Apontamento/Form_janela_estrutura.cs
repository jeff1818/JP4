using JP4.Config;
using System;
using System.Data.OleDb;
using System.Windows.Forms;


namespace JP4
{
    public partial class ST01 : Form
    {
        public ST01()
        {
            InitializeComponent();
            Carregar_descricao_completa();
            Carregar_descricao_componente();
            Carregar_empresa();
            Bloquear_controles();
            Carregar_clientes();
            Carregar_maquinas();

            combo_empresa.Text = "Picoflex";

        }
        /*
         
        private bool TextBoxVazias()
        {
            foreach (Control c in this.Controls)
                if (c is System.Windows.Forms.TextBox)
                {
                    System.Windows.Forms.TextBox textBox = c as System.Windows.Forms.TextBox;
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                        return true;
                }
            return false;
        }
        */

        private void Limpar_campos()
        {

            combo_componente01.Text = string.Empty;
            text_qtd_necess01.Text = "0";
            text_percentual_refugo01.Text = "0";
            //text_dt_inicio01.Text = string.Empty;
            text_dt_validade01.Text = string.Empty;

            combo_componente02.Text = string.Empty;
            text_qtd_necess02.Text = "0";
            text_percentual_refugo02.Text = "0";
            //text_dt_inicio02.Text = string.Empty;
            text_dt_validade02.Text = string.Empty;

            combo_componente03.Text = string.Empty;
            text_qtd_necess03.Text = "0";
            text_percentual_refugo03.Text = "0";
            //text_dt_inicio03.Text = string.Empty;
            text_dt_validade03.Text = string.Empty;

            combo_componente04.Text = string.Empty;
            text_qtd_necess04.Text = "0";
            text_percentual_refugo04.Text = "0";
            //text_dt_inicio04.Text = string.Empty;
            text_dt_validade04.Text = string.Empty;

            combo_componente05.Text = string.Empty;
            text_qtd_necess05.Text = "0";
            text_percentual_refugo05.Text = "0";
            //text_dt_inicio05.Text = string.Empty;
            text_dt_validade05.Text = string.Empty;

            combo_componente06.Text = string.Empty;
            text_qtd_necess06.Text = "0";
            text_percentual_refugo06.Text = "0";
            //text_dt_inicio06.Text = string.Empty;
            text_dt_validade06.Text = string.Empty;

            combo_componente07.Text = string.Empty;
            text_qtd_necess07.Text = "0";
            text_percentual_refugo07.Text = "0";
            //text_dt_inicio07.Text = string.Empty;
            text_dt_validade07.Text = string.Empty;

            combo_componente08.Text = string.Empty;
            text_qtd_necess08.Text = "0";
            text_percentual_refugo08.Text = "0";
            //text_dt_inicio08.Text = string.Empty;
            text_dt_validade08.Text = string.Empty;

            combo_componente09.Text = string.Empty;
            text_qtd_necess09.Text = "0";
            text_percentual_refugo09.Text = "0";
            //text_dt_inicio09.Text = string.Empty;
            text_dt_validade09.Text = string.Empty;

            combo_componente10.Text = string.Empty;
            text_qtd_necess10.Text = "0";
            text_percentual_refugo10.Text = "0";
            //text_dt_inicio10.Text = string.Empty;
            text_dt_validade10.Text = string.Empty;

            this.id01.Text = "id";
            this.id02.Text = "id";
            this.id03.Text = "id";
            this.id04.Text = "id";
            this.id05.Text = "id";
            this.id06.Text = "id";
            this.id07.Text = "id";
            this.id08.Text = "id";
            this.id09.Text = "id";
            this.id10.Text = "id";

            this.delete01.Checked = false;
            this.delete02.Checked = false;
            this.delete03.Checked = false;
            this.delete04.Checked = false;
            this.delete05.Checked = false;
            this.delete06.Checked = false;
            this.delete07.Checked = false;
            this.delete08.Checked = false;
            this.delete09.Checked = false;
            this.delete10.Checked = false;



        }
        private void Carregar_maquinas()
        {
            try
            {
                //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                string local_default = @"C:\JP4";
                string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select * from db_cadastro_equipamento";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();


                while (myreader.Read())
                {
                    combo_maquina_destino.Items.Add(myreader["descricao_equipamento"].ToString());
                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }
        public void Carregar_estrutura(string item_pai, string cliente, string maquina_destino)
        {
            try
            {
                //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                string local_default = @"C:\JP4";
                string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "SELECT * FROM db_estrutura WHERE descri_pai = '" + item_pai + "' AND cliente = '" + cliente + "' AND maquina_destino ='" + maquina_destino + "'";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    combo_cliente.Text = myreader["cliente"].ToString();

                    if (combo_componente01.Name == myreader["marcador_campo"].ToString())
                    {
                        combo_componente01.Text = myreader["descri_filho"].ToString();
                        text_qtd_necess01.Text = myreader["qtd_necessaria"].ToString();
                        text_percentual_refugo01.Text = myreader["pct_refug"].ToString();
                        dt_inicio01.Value = Convert.ToDateTime(myreader["dat_validade_ini"]);
                        //text_dt_validade01.Text = Convert.ToDateTime(myreader["dat_validade_fim"]).ToString("dd/MM/yyyy");
                        id01.Text = myreader["id_estrutura"].ToString();
                    }
                    if (combo_componente02.Name == myreader["marcador_campo"].ToString())
                    {
                        combo_componente02.Text = myreader["descri_filho"].ToString();
                        text_qtd_necess02.Text = myreader["qtd_necessaria"].ToString();
                        text_percentual_refugo02.Text = myreader["pct_refug"].ToString();
                        dt_inicio02.Value = Convert.ToDateTime(myreader["dat_validade_ini"]);
                        //text_dt_validade02.Text = Convert.ToDateTime(myreader["dat_validade_fim"]).ToString("dd/MM/yyyy");
                        id02.Text = myreader["id_estrutura"].ToString();
                    }
                    if (combo_componente03.Name == myreader["marcador_campo"].ToString())
                    {
                        combo_componente03.Text = myreader["descri_filho"].ToString();
                        text_qtd_necess03.Text = myreader["qtd_necessaria"].ToString();
                        text_percentual_refugo03.Text = myreader["pct_refug"].ToString();
                        dt_inicio03.Value = Convert.ToDateTime(myreader["dat_validade_ini"]);
                        //text_dt_validade03.Text = Convert.ToDateTime(myreader["dat_validade_fim"]).ToString("dd/MM/yyyy");
                        id03.Text = myreader["id_estrutura"].ToString();
                    }
                    if (combo_componente04.Name == myreader["marcador_campo"].ToString())
                    {
                        combo_componente04.Text = myreader["descri_filho"].ToString();
                        text_qtd_necess04.Text = myreader["qtd_necessaria"].ToString();
                        text_percentual_refugo04.Text = myreader["pct_refug"].ToString();
                        dt_inicio04.Value = Convert.ToDateTime(myreader["dat_validade_ini"]);
                        //text_dt_validade04.Text = Convert.ToDateTime(myreader["dat_validade_fim"]).ToString("dd/MM/yyyy");
                        id04.Text = myreader["id_estrutura"].ToString();
                    }
                    if (combo_componente05.Name == myreader["marcador_campo"].ToString())
                    {
                        combo_componente05.Text = myreader["descri_filho"].ToString();
                        text_qtd_necess05.Text = myreader["qtd_necessaria"].ToString();
                        text_percentual_refugo05.Text = myreader["pct_refug"].ToString();
                        dt_inicio05.Value = Convert.ToDateTime(myreader["dat_validade_ini"]);
                        //text_dt_validade05.Text = Convert.ToDateTime(myreader["dat_validade_fim"]).ToString("dd/MM/yyyy");
                        id05.Text = myreader["id_estrutura"].ToString();
                    }
                    if (combo_componente06.Name == myreader["marcador_campo"].ToString())
                    {
                        combo_componente06.Text = myreader["descri_filho"].ToString();
                        text_qtd_necess06.Text = myreader["qtd_necessaria"].ToString();
                        text_percentual_refugo06.Text = myreader["pct_refug"].ToString();
                        dt_inicio06.Value = Convert.ToDateTime(myreader["dat_validade_ini"]);
                        //text_dt_validade06.Text = Convert.ToDateTime(myreader["dat_validade_fim"]).ToString("dd/MM/yyyy");
                        id06.Text = myreader["id_estrutura"].ToString();
                    }
                    if (combo_componente07.Name == myreader["marcador_campo"].ToString())
                    {
                        combo_componente07.Text = myreader["descri_filho"].ToString();
                        text_qtd_necess07.Text = myreader["qtd_necessaria"].ToString();
                        text_percentual_refugo07.Text = myreader["pct_refug"].ToString();
                        dt_inicio07.Value = Convert.ToDateTime(myreader["dat_validade_ini"]);
                        //text_dt_validade07.Text = Convert.ToDateTime(myreader["dat_validade_fim"]).ToString("dd/MM/yyyy");
                        id07.Text = myreader["id_estrutura"].ToString();
                    }
                    if (combo_componente08.Name == myreader["marcador_campo"].ToString())
                    {
                        combo_componente08.Text = myreader["descri_filho"].ToString();
                        text_qtd_necess08.Text = myreader["qtd_necessaria"].ToString();
                        text_percentual_refugo08.Text = myreader["pct_refug"].ToString();
                        dt_inicio08.Value = Convert.ToDateTime(myreader["dat_validade_ini"]);
                        //text_dt_validade08.Text = Convert.ToDateTime(myreader["dat_validade_fim"]).ToString("dd/MM/yyyy");
                        id08.Text = myreader["id_estrutura"].ToString();
                    }
                    if (combo_componente09.Name == myreader["marcador_campo"].ToString())
                    {
                        combo_componente09.Text = myreader["descri_filho"].ToString();
                        text_qtd_necess09.Text = myreader["qtd_necessaria"].ToString();
                        text_percentual_refugo09.Text = myreader["pct_refug"].ToString();
                        dt_inicio09.Value = Convert.ToDateTime(myreader["dat_validade_ini"]);
                        //text_dt_validade09.Text = Convert.ToDateTime(myreader["dat_validade_fim"]).ToString("dd/MM/yyyy");
                        id09.Text = myreader["id_estrutura"].ToString();
                    }
                    if (combo_componente10.Name == myreader["marcador_campo"].ToString())
                    {
                        combo_componente10.Text = myreader["descri_filho"].ToString();
                        text_qtd_necess10.Text = myreader["qtd_necessaria"].ToString();
                        text_percentual_refugo10.Text = myreader["pct_refug"].ToString();
                        dt_inicio10.Value = Convert.ToDateTime(myreader["dat_validade_ini"]);
                        //text_dt_validade10.Text = Convert.ToDateTime(myreader["dat_validade_fim"]).ToString("dd/MM/yyyy");
                        id10.Text = myreader["id_estrutura"].ToString();
                    }



                    //MessageBox.Show(contagem.ToString());

                }

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Carregar_descricao_componente()
        {
            try
            {
                //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                string local_default = @"C:\JP4";
                string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select descricao_completa from db_cadastro_material where tem_estrutura = 0";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    this.combo_componente01.Items.Add(myreader["descricao_completa"].ToString());
                    this.combo_componente02.Items.Add(myreader["descricao_completa"].ToString());
                    this.combo_componente03.Items.Add(myreader["descricao_completa"].ToString());
                    this.combo_componente04.Items.Add(myreader["descricao_completa"].ToString());
                    this.combo_componente05.Items.Add(myreader["descricao_completa"].ToString());
                    this.combo_componente06.Items.Add(myreader["descricao_completa"].ToString());
                    this.combo_componente07.Items.Add(myreader["descricao_completa"].ToString());
                    this.combo_componente08.Items.Add(myreader["descricao_completa"].ToString());
                    this.combo_componente09.Items.Add(myreader["descricao_completa"].ToString());
                    this.combo_componente10.Items.Add(myreader["descricao_completa"].ToString());
                }

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }


        }
        private void Carregar_descricao_completa()
        {
            try
            {
                //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                string local_default = @"C:\JP4";
                string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select * from db_cadastro_material where tem_estrutura = 1";


                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    this.text_cod_item.Text = myreader["codigo_item"].ToString();
                    this.combo_descricao_item.Items.Add(myreader["descricao_completa"].ToString());
                }

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Carregar_empresa()
        {
            try
            {
                //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                string local_default = @"C:\JP4";
                string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select * from db_cadastro_empresas";// where tem_estrutura = 1";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    this.combo_empresa.Items.Add(myreader["descricao"].ToString());
                }

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Carregar_clientes()
        {
            try
            {
                //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                string local_default = @"C:\JP4";
                string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select * from db_cadastro_clientes";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();


                while (myreader.Read())
                {
                    combo_cliente.Items.Add(myreader["cliente_nome"].ToString());
                }
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Bloquear_controles()
        {
            this.combo_componente01.Enabled = false;
            this.text_qtd_necess01.Enabled = false;
            this.text_percentual_refugo01.Enabled = false;
            this.dt_inicio01.Enabled = false;
            this.text_dt_validade01.Enabled = false;

            this.combo_componente02.Enabled = false;
            this.text_qtd_necess02.Enabled = false;
            this.text_percentual_refugo02.Enabled = false;
            this.dt_inicio02.Enabled = false;
            this.text_dt_validade02.Enabled = false;

            this.combo_componente03.Enabled = false;
            this.text_qtd_necess03.Enabled = false;
            this.text_percentual_refugo03.Enabled = false;
            this.dt_inicio03.Enabled = false;
            this.text_dt_validade03.Enabled = false;

            this.combo_componente04.Enabled = false;
            this.text_qtd_necess04.Enabled = false;
            this.text_percentual_refugo04.Enabled = false;
            this.dt_inicio04.Enabled = false;
            this.text_dt_validade04.Enabled = false;

            this.combo_componente05.Enabled = false;
            this.text_qtd_necess05.Enabled = false;
            this.text_percentual_refugo05.Enabled = false;
            this.dt_inicio05.Enabled = false;
            this.text_dt_validade05.Enabled = false;

            this.combo_componente06.Enabled = false;
            this.text_qtd_necess06.Enabled = false;
            this.text_percentual_refugo06.Enabled = false;
            this.dt_inicio06.Enabled = false;
            this.text_dt_validade06.Enabled = false;

            this.combo_componente07.Enabled = false;
            this.text_qtd_necess07.Enabled = false;
            this.text_percentual_refugo07.Enabled = false;
            this.dt_inicio07.Enabled = false;
            this.text_dt_validade07.Enabled = false;

            this.combo_componente08.Enabled = false;
            this.text_qtd_necess08.Enabled = false;
            this.text_percentual_refugo08.Enabled = false;
            this.dt_inicio08.Enabled = false;
            this.text_dt_validade08.Enabled = false;

            this.combo_componente09.Enabled = false;
            this.text_qtd_necess09.Enabled = false;
            this.text_percentual_refugo09.Enabled = false;
            this.dt_inicio09.Enabled = false;
            this.text_dt_validade09.Enabled = false;

            this.combo_componente10.Enabled = false;
            this.text_qtd_necess10.Enabled = false;
            this.text_percentual_refugo10.Enabled = false;
            this.dt_inicio10.Enabled = false;
            this.text_dt_validade10.Enabled = false;

            this.delete01.Enabled = false;
            this.delete02.Enabled = false;
            this.delete03.Enabled = false;
            this.delete04.Enabled = false;
            this.delete05.Enabled = false;
            this.delete06.Enabled = false;
            this.delete07.Enabled = false;
            this.delete08.Enabled = false;
            this.delete09.Enabled = false;
            this.delete10.Enabled = false;



        }
        private void Desbloquear_controles()
        {
            this.combo_componente01.Enabled = true;
            this.text_qtd_necess01.Enabled = true;
            this.text_percentual_refugo01.Enabled = true;
            this.dt_inicio01.Enabled = true;
            this.text_dt_validade01.Enabled = true;

            this.combo_componente02.Enabled = true;
            this.text_qtd_necess02.Enabled = true;
            this.text_percentual_refugo02.Enabled = true;
            this.dt_inicio02.Enabled = true;
            this.text_dt_validade02.Enabled = true;

            this.combo_componente03.Enabled = true;
            this.text_qtd_necess03.Enabled = true;
            this.text_percentual_refugo03.Enabled = true;
            this.dt_inicio03.Enabled = true;
            this.text_dt_validade03.Enabled = true;

            this.combo_componente04.Enabled = true;
            this.text_qtd_necess04.Enabled = true;
            this.text_percentual_refugo04.Enabled = true;
            this.dt_inicio04.Enabled = true;
            this.text_dt_validade04.Enabled = true;

            this.combo_componente05.Enabled = true;
            this.text_qtd_necess05.Enabled = true;
            this.text_percentual_refugo05.Enabled = true;
            this.dt_inicio05.Enabled = true;
            this.text_dt_validade05.Enabled = true;

            this.combo_componente06.Enabled = true;
            this.text_qtd_necess06.Enabled = true;
            this.text_percentual_refugo06.Enabled = true;
            this.dt_inicio06.Enabled = true;
            this.text_dt_validade06.Enabled = true;

            this.combo_componente07.Enabled = true;
            this.text_qtd_necess07.Enabled = true;
            this.text_percentual_refugo07.Enabled = true;
            this.dt_inicio07.Enabled = true;
            this.text_dt_validade07.Enabled = true;

            this.combo_componente08.Enabled = true;
            this.text_qtd_necess08.Enabled = true;
            this.text_percentual_refugo08.Enabled = true;
            this.dt_inicio08.Enabled = true;
            this.text_dt_validade08.Enabled = true;

            this.combo_componente09.Enabled = true;
            this.text_qtd_necess09.Enabled = true;
            this.text_percentual_refugo09.Enabled = true;
            this.dt_inicio09.Enabled = true;
            this.text_dt_validade09.Enabled = true;

            this.combo_componente10.Enabled = true;
            this.text_qtd_necess10.Enabled = true;
            this.text_percentual_refugo10.Enabled = true;
            this.dt_inicio10.Enabled = true;
            this.text_dt_validade10.Enabled = true;

            this.delete01.Enabled = true;
            this.delete02.Enabled = true;
            this.delete03.Enabled = true;
            this.delete04.Enabled = true;
            this.delete05.Enabled = true;
            this.delete06.Enabled = true;
            this.delete07.Enabled = true;
            this.delete08.Enabled = true;
            this.delete09.Enabled = true;
            this.delete10.Enabled = true;



        }
        private void Atualizar_estrutura()
        {
            if (id01.Text != "id")
            {
                string empresa = combo_empresa.Text;
                string item_pai = text_cod_item.Text;
                string descri_pai = combo_descricao_item.Text;
                string cod_item_compon = string.Empty;
                string cliente = combo_cliente.Text;
                string num_transac = Gerar_num_transac(DateTime.Now, DateTime.Now);
                double Qt_total = 0;
                DateTime dat_validade_fim = DateTime.Now.AddDays(1826);
                int cod_posicao = 0;

                int pct_refug = Convert.ToInt32(text_percentual_refugo01.Text);
                DateTime dat_validade_ini = dt_inicio01.Value;
                string descri_filho = combo_componente01.Text;
                double qtd_necessaria = Convert.ToDouble(text_qtd_necess01.Text);
                string marcador_campo = combo_componente01.Name;

                string maquina_destino = combo_maquina_destino.Text;

                try
                {
                    //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                    string local_default = @"C:\JP4";
                    string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();
                    string comando_sql;

                    comando_sql = "UPDATE db_estrutura SET " +
                        "empresa='" + empresa +
                        "', item_pai='" + item_pai +
                        "', descri_pai='" + descri_pai +
                        "', cod_item_compon='" + cod_item_compon +
                        "', descri_filho='" + descri_filho +
                        "', qtd_necessaria='" + qtd_necessaria +
                        "', Qt_total='" + Qt_total +
                        "', pct_refug='" + pct_refug +
                        "', dat_validade_ini='" + Convert.ToDateTime(dat_validade_ini) +
                        "', dat_validade_fim='" + Convert.ToDateTime(dat_validade_fim) +
                        "', cod_posicao='" + cod_posicao +
                        "', num_transac='" + num_transac +
                        "', cliente='" + cliente +
                        "', marcador_campo='" + marcador_campo +
                        "', maquina_destino='" + maquina_destino +
                        "' WHERE id_estrutura=" + Convert.ToInt64(id01.Text) + "";


                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            else if (combo_componente01.Text != string.Empty)
            {
                string empresa = combo_empresa.Text;
                string item_pai = text_cod_item.Text;
                string descri_pai = combo_descricao_item.Text;

                string cod_item_compon = string.Empty;

                string cliente = combo_cliente.Text;
                string num_transac = Gerar_num_transac(DateTime.Now, DateTime.Now);

                double Qt_total = 0;
                DateTime dat_validade_fim = DateTime.Now.AddDays(1860);

                int cod_posicao = 0;

                int pct_refug = Convert.ToInt32(text_percentual_refugo01.Text);
                DateTime dat_validade_ini = dt_inicio01.Value;
                string descri_filho = combo_componente01.Text;
                double qtd_necessaria = Convert.ToDouble(text_qtd_necess01.Text);
                string marcador_campo = combo_componente01.Name;

                string maquina_destino = combo_maquina_destino.Text;

                try
                {

                    string comando_sql;
                    //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                    string local_default = @"C:\JP4";
                    string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "INSERT INTO db_estrutura(empresa, item_pai, descri_pai, cod_item_compon, descri_filho, qtd_necessaria, Qt_total, pct_refug, dat_validade_ini, dat_validade_fim, cod_posicao, num_transac, cliente, marcador_campo, maquina_destino) " +
                    "VALUES('" + empresa + "','" + item_pai + "','" + descri_pai + "','" + cod_item_compon + "','" + descri_filho + "','" + qtd_necessaria + "','" + Qt_total + "','" + pct_refug + "','" + dat_validade_ini + "','" + dat_validade_fim + "','" + cod_posicao + "','" + num_transac + "','" + cliente + "','" + marcador_campo + "','" + maquina_destino + "')";


                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.Message);

                }

            }

            if (id02.Text != "id")
            {
                string empresa = combo_empresa.Text;
                string item_pai = text_cod_item.Text;
                string descri_pai = combo_descricao_item.Text;
                string cod_item_compon = string.Empty;
                string cliente = combo_cliente.Text;
                string num_transac = Gerar_num_transac(DateTime.Now, DateTime.Now);
                double Qt_total = 0;
                DateTime dat_validade_fim = DateTime.Now.AddDays(1826);
                int cod_posicao = 0;

                int pct_refug = Convert.ToInt32(text_percentual_refugo02.Text);
                DateTime dat_validade_ini = dt_inicio02.Value;
                string descri_filho = combo_componente02.Text;
                double qtd_necessaria = Convert.ToDouble(text_qtd_necess02.Text);
                string marcador_campo = combo_componente02.Name;

                string maquina_destino = combo_maquina_destino.Text;

                try
                {
                    //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                    string local_default = @"C:\JP4";
                    string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();
                    string comando_sql;

                    comando_sql = "UPDATE db_estrutura SET " +
                        "empresa='" + empresa +
                        "', item_pai='" + item_pai +
                        "', descri_pai='" + descri_pai +
                        "', cod_item_compon='" + cod_item_compon +
                        "', descri_filho='" + descri_filho +
                        "', qtd_necessaria='" + qtd_necessaria +
                        "', Qt_total='" + Qt_total +
                        "', pct_refug='" + pct_refug +
                        "', dat_validade_ini='" + Convert.ToDateTime(dat_validade_ini) +
                        "', dat_validade_fim='" + Convert.ToDateTime(dat_validade_fim) +
                        "', cod_posicao='" + cod_posicao +
                        "', num_transac='" + num_transac +
                        "', cliente='" + cliente +
                        "', marcador_campo='" + marcador_campo +
                        "', maquina_destino='" + maquina_destino +
                        "' WHERE id_estrutura=" + Convert.ToInt64(id01.Text) + "";


                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }

            }
            else if (combo_componente02.Text != string.Empty)
            {
                string empresa = combo_empresa.Text;
                string item_pai = text_cod_item.Text;
                string descri_pai = combo_descricao_item.Text;

                string cod_item_compon = string.Empty;

                string cliente = combo_cliente.Text;
                string num_transac = Gerar_num_transac(DateTime.Now, DateTime.Now);

                double Qt_total = 0;
                DateTime dat_validade_fim = DateTime.Now.AddDays(1860);

                int cod_posicao = 0;

                int pct_refug = Convert.ToInt32(text_percentual_refugo02.Text);
                DateTime dat_validade_ini = dt_inicio02.Value;
                string descri_filho = combo_componente02.Text;
                double qtd_necessaria = Convert.ToDouble(text_qtd_necess02.Text);
                string marcador_campo = combo_componente02.Name;

                string maquina_destino = combo_maquina_destino.Text;

                try
                {

                    string comando_sql;
                    //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                    string local_default = @"C:\JP4";
                    string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "INSERT INTO db_estrutura(empresa, item_pai, descri_pai, cod_item_compon, descri_filho, qtd_necessaria, Qt_total, pct_refug, dat_validade_ini, dat_validade_fim, cod_posicao, num_transac, cliente, marcador_campo, maquina_destino) " +
                    "VALUES('" + empresa + "','" + item_pai + "','" + descri_pai + "','" + cod_item_compon + "','" + descri_filho + "','" + qtd_necessaria + "','" + Qt_total + "','" + pct_refug + "','" + dat_validade_ini + "','" + dat_validade_fim + "','" + cod_posicao + "','" + num_transac + "','" + cliente + "','" + marcador_campo + "','" + maquina_destino + "')";


                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.Message);

                }
            }

            if (id03.Text != "id")
            {

                string empresa = combo_empresa.Text;
                string item_pai = text_cod_item.Text;
                string descri_pai = combo_descricao_item.Text;
                string cod_item_compon = string.Empty;
                string cliente = combo_cliente.Text;
                string num_transac = Gerar_num_transac(DateTime.Now, DateTime.Now);
                double Qt_total = 0;
                DateTime dat_validade_fim = DateTime.Now.AddDays(1826);
                int cod_posicao = 0;

                int pct_refug = Convert.ToInt32(text_percentual_refugo03.Text);
                DateTime dat_validade_ini = dt_inicio03.Value;
                string descri_filho = combo_componente03.Text;
                double qtd_necessaria = Convert.ToDouble(text_qtd_necess03.Text);
                string marcador_campo = combo_componente03.Name;

                string maquina_destino = combo_maquina_destino.Text;

                try
                {
                    //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                    string local_default = @"C:\JP4";
                    string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();
                    string comando_sql;

                    comando_sql = "UPDATE db_estrutura SET " +
                        "empresa='" + empresa +
                        "', item_pai='" + item_pai +
                        "', descri_pai='" + descri_pai +
                        "', cod_item_compon='" + cod_item_compon +
                        "', descri_filho='" + descri_filho +
                        "', qtd_necessaria='" + qtd_necessaria +
                        "', Qt_total='" + Qt_total +
                        "', pct_refug='" + pct_refug +
                        "', dat_validade_ini='" + Convert.ToDateTime(dat_validade_ini) +
                        "', dat_validade_fim='" + Convert.ToDateTime(dat_validade_fim) +
                        "', cod_posicao='" + cod_posicao +
                        "', num_transac='" + num_transac +
                        "', cliente='" + cliente +
                        "', marcador_campo='" + marcador_campo +
                        "', maquina_destino='" + maquina_destino +
                        "' WHERE id_estrutura=" + Convert.ToInt64(id01.Text) + "";


                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }

            }
            else if (combo_componente03.Text != string.Empty)
            {
                string empresa = combo_empresa.Text;
                string item_pai = text_cod_item.Text;
                string descri_pai = combo_descricao_item.Text;

                string cod_item_compon = string.Empty;

                string cliente = combo_cliente.Text;
                string num_transac = Gerar_num_transac(DateTime.Now, DateTime.Now);

                double Qt_total = 0;
                DateTime dat_validade_fim = DateTime.Now.AddDays(1860);

                int cod_posicao = 0;

                int pct_refug = Convert.ToInt32(text_percentual_refugo03.Text);
                DateTime dat_validade_ini = dt_inicio03.Value;
                string descri_filho = combo_componente03.Text;
                double qtd_necessaria = Convert.ToDouble(text_qtd_necess03.Text);
                string marcador_campo = combo_componente03.Name;
                string maquina_destino = combo_maquina_destino.Text;

                try
                {

                    string comando_sql;
                    //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                    string local_default = @"C:\JP4";
                    string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "INSERT INTO db_estrutura(empresa, item_pai, descri_pai, cod_item_compon, descri_filho, qtd_necessaria, Qt_total, pct_refug, dat_validade_ini, dat_validade_fim, cod_posicao, num_transac, cliente, marcador_campo, maquina_destino) " +
                    "VALUES('" + empresa + "','" + item_pai + "','" + descri_pai + "','" + cod_item_compon + "','" + descri_filho + "','" + qtd_necessaria + "','" + Qt_total + "','" + pct_refug + "','" + dat_validade_ini + "','" + dat_validade_fim + "','" + cod_posicao + "','" + num_transac + "','" + cliente + "','" + marcador_campo + "','" + maquina_destino + "')";


                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.Message);

                }

            }

            if (id04.Text != "id")
            {
                string empresa = combo_empresa.Text;
                string item_pai = text_cod_item.Text;
                string descri_pai = combo_descricao_item.Text;
                string cod_item_compon = string.Empty;
                string cliente = combo_cliente.Text;
                string num_transac = Gerar_num_transac(DateTime.Now, DateTime.Now);
                double Qt_total = 0;
                DateTime dat_validade_fim = DateTime.Now.AddDays(1826);
                int cod_posicao = 0;

                int pct_refug = Convert.ToInt32(text_percentual_refugo04.Text);
                DateTime dat_validade_ini = dt_inicio04.Value;
                string descri_filho = combo_componente04.Text;
                double qtd_necessaria = Convert.ToDouble(text_qtd_necess04.Text);
                string marcador_campo = combo_componente04.Name;

                string maquina_destino = combo_maquina_destino.Text;

                try
                {
                    //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                    string local_default = @"C:\JP4";
                    string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();
                    string comando_sql;

                    comando_sql = "UPDATE db_estrutura SET " +
                        "empresa='" + empresa +
                        "', item_pai='" + item_pai +
                        "', descri_pai='" + descri_pai +
                        "', cod_item_compon='" + cod_item_compon +
                        "', descri_filho='" + descri_filho +
                        "', qtd_necessaria='" + qtd_necessaria +
                        "', Qt_total='" + Qt_total +
                        "', pct_refug='" + pct_refug +
                        "', dat_validade_ini='" + Convert.ToDateTime(dat_validade_ini) +
                        "', dat_validade_fim='" + Convert.ToDateTime(dat_validade_fim) +
                        "', cod_posicao='" + cod_posicao +
                        "', num_transac='" + num_transac +
                        "', cliente='" + cliente +
                        "', marcador_campo='" + marcador_campo +
                        "', maquina_destino='" + maquina_destino +
                        "' WHERE id_estrutura=" + Convert.ToInt64(id01.Text) + "";


                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            else if (combo_componente04.Text != string.Empty)
            {
                string empresa = combo_empresa.Text;
                string item_pai = text_cod_item.Text;
                string descri_pai = combo_descricao_item.Text;

                string cod_item_compon = string.Empty;

                string cliente = combo_cliente.Text;
                string num_transac = Gerar_num_transac(DateTime.Now, DateTime.Now);

                double Qt_total = 0;
                DateTime dat_validade_fim = DateTime.Now.AddDays(1860);

                int cod_posicao = 0;

                int pct_refug = Convert.ToInt32(text_percentual_refugo04.Text);
                DateTime dat_validade_ini = dt_inicio04.Value;
                string descri_filho = combo_componente04.Text;
                double qtd_necessaria = Convert.ToDouble(text_qtd_necess04.Text);
                string marcador_campo = combo_componente04.Name;
                string maquina_destino = combo_maquina_destino.Text;

                try
                {

                    string comando_sql;
                    //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                    string local_default = @"C:\JP4";
                    string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "INSERT INTO db_estrutura(empresa, item_pai, descri_pai, cod_item_compon, descri_filho, qtd_necessaria, Qt_total, pct_refug, dat_validade_ini, dat_validade_fim, cod_posicao, num_transac, cliente, marcador_campo, maquina_destino) " +
                    "VALUES('" + empresa + "','" + item_pai + "','" + descri_pai + "','" + cod_item_compon + "','" + descri_filho + "','" + qtd_necessaria + "','" + Qt_total + "','" + pct_refug + "','" + dat_validade_ini + "','" + dat_validade_fim + "','" + cod_posicao + "','" + num_transac + "','" + cliente + "','" + marcador_campo + "','" + maquina_destino + "')";


                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.Message);

                }

            }

            if (id05.Text != "id")
            {
                string empresa = combo_empresa.Text;
                string item_pai = text_cod_item.Text;
                string descri_pai = combo_descricao_item.Text;
                string cod_item_compon = string.Empty;
                string cliente = combo_cliente.Text;
                string num_transac = Gerar_num_transac(DateTime.Now, DateTime.Now);
                double Qt_total = 0;
                DateTime dat_validade_fim = DateTime.Now.AddDays(1826);
                int cod_posicao = 0;

                int pct_refug = Convert.ToInt32(text_percentual_refugo05.Text);
                DateTime dat_validade_ini = dt_inicio05.Value;
                string descri_filho = combo_componente05.Text;
                double qtd_necessaria = Convert.ToDouble(text_qtd_necess05.Text);
                string marcador_campo = combo_componente05.Name;

                string maquina_destino = combo_maquina_destino.Text;

                try
                {
                    //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                    string local_default = @"C:\JP4";
                    string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();
                    string comando_sql;

                    comando_sql = "UPDATE db_estrutura SET " +
                        "empresa='" + empresa +
                        "', item_pai='" + item_pai +
                        "', descri_pai='" + descri_pai +
                        "', cod_item_compon='" + cod_item_compon +
                        "', descri_filho='" + descri_filho +
                        "', qtd_necessaria='" + qtd_necessaria +
                        "', Qt_total='" + Qt_total +
                        "', pct_refug='" + pct_refug +
                        "', dat_validade_ini='" + Convert.ToDateTime(dat_validade_ini) +
                        "', dat_validade_fim='" + Convert.ToDateTime(dat_validade_fim) +
                        "', cod_posicao='" + cod_posicao +
                        "', num_transac='" + num_transac +
                        "', cliente='" + cliente +
                        "', marcador_campo='" + marcador_campo +
                        "', maquina_destino='" + maquina_destino +
                        "' WHERE id_estrutura=" + Convert.ToInt64(id01.Text) + "";


                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            else if (combo_componente05.Text != string.Empty)
            {
                string empresa = combo_empresa.Text;
                string item_pai = text_cod_item.Text;
                string descri_pai = combo_descricao_item.Text;

                string cod_item_compon = string.Empty;

                string cliente = combo_cliente.Text;
                string num_transac = Gerar_num_transac(DateTime.Now, DateTime.Now);

                double Qt_total = 0;
                DateTime dat_validade_fim = DateTime.Now.AddDays(1860);

                int cod_posicao = 0;

                int pct_refug = Convert.ToInt32(text_percentual_refugo05.Text);
                DateTime dat_validade_ini = dt_inicio05.Value;
                string descri_filho = combo_componente05.Text;
                double qtd_necessaria = Convert.ToDouble(text_qtd_necess05.Text);
                string marcador_campo = combo_componente05.Name;
                string maquina_destino = combo_maquina_destino.Text;

                try
                {

                    string comando_sql;
                    //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                    string local_default = @"C:\JP4";
                    string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "INSERT INTO db_estrutura(empresa, item_pai, descri_pai, cod_item_compon, descri_filho, qtd_necessaria, Qt_total, pct_refug, dat_validade_ini, dat_validade_fim, cod_posicao, num_transac, cliente, marcador_campo, maquina_destino) " +
                    "VALUES('" + empresa + "','" + item_pai + "','" + descri_pai + "','" + cod_item_compon + "','" + descri_filho + "','" + qtd_necessaria + "','" + Qt_total + "','" + pct_refug + "','" + dat_validade_ini + "','" + dat_validade_fim + "','" + cod_posicao + "','" + num_transac + "','" + cliente + "','" + marcador_campo + "','" + maquina_destino + "')";


                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.Message);

                }

            }

            if (id06.Text != "id")
            {
                string empresa = combo_empresa.Text;
                string item_pai = text_cod_item.Text;
                string descri_pai = combo_descricao_item.Text;
                string cod_item_compon = string.Empty;
                string cliente = combo_cliente.Text;
                string num_transac = Gerar_num_transac(DateTime.Now, DateTime.Now);
                double Qt_total = 0;
                DateTime dat_validade_fim = DateTime.Now.AddDays(1826);
                int cod_posicao = 0;

                int pct_refug = Convert.ToInt32(text_percentual_refugo06.Text);
                DateTime dat_validade_ini = dt_inicio06.Value;
                string descri_filho = combo_componente06.Text;
                double qtd_necessaria = Convert.ToDouble(text_qtd_necess06.Text);
                string marcador_campo = combo_componente06.Name;

                string maquina_destino = combo_maquina_destino.Text;

                try
                {
                    //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                    string local_default = @"C:\JP4";
                    string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();
                    string comando_sql;

                    comando_sql = "UPDATE db_estrutura SET " +
                        "empresa='" + empresa +
                        "', item_pai='" + item_pai +
                        "', descri_pai='" + descri_pai +
                        "', cod_item_compon='" + cod_item_compon +
                        "', descri_filho='" + descri_filho +
                        "', qtd_necessaria='" + qtd_necessaria +
                        "', Qt_total='" + Qt_total +
                        "', pct_refug='" + pct_refug +
                        "', dat_validade_ini='" + Convert.ToDateTime(dat_validade_ini) +
                        "', dat_validade_fim='" + Convert.ToDateTime(dat_validade_fim) +
                        "', cod_posicao='" + cod_posicao +
                        "', num_transac='" + num_transac +
                        "', cliente='" + cliente +
                        "', marcador_campo='" + marcador_campo +
                        "', maquina_destino='" + maquina_destino +
                        "' WHERE id_estrutura=" + Convert.ToInt64(id01.Text) + "";


                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            else if (combo_componente06.Text != string.Empty)
            {
                string empresa = combo_empresa.Text;
                string item_pai = text_cod_item.Text;
                string descri_pai = combo_descricao_item.Text;

                string cod_item_compon = string.Empty;

                string cliente = combo_cliente.Text;
                string num_transac = Gerar_num_transac(DateTime.Now, DateTime.Now);

                double Qt_total = 0;
                DateTime dat_validade_fim = DateTime.Now.AddDays(1860);

                int cod_posicao = 0;

                int pct_refug = Convert.ToInt32(text_percentual_refugo06.Text);
                DateTime dat_validade_ini = dt_inicio06.Value;
                string descri_filho = combo_componente06.Text;
                double qtd_necessaria = Convert.ToDouble(text_qtd_necess06.Text);
                string marcador_campo = combo_componente06.Name;
                string maquina_destino = combo_maquina_destino.Text;

                try
                {

                    string comando_sql;
                    //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                    string local_default = @"C:\JP4";
                    string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "INSERT INTO db_estrutura(empresa, item_pai, descri_pai, cod_item_compon, descri_filho, qtd_necessaria, Qt_total, pct_refug, dat_validade_ini, dat_validade_fim, cod_posicao, num_transac, cliente, marcador_campo, maquina_destino) " +
                    "VALUES('" + empresa + "','" + item_pai + "','" + descri_pai + "','" + cod_item_compon + "','" + descri_filho + "','" + qtd_necessaria + "','" + Qt_total + "','" + pct_refug + "','" + dat_validade_ini + "','" + dat_validade_fim + "','" + cod_posicao + "','" + num_transac + "','" + cliente + "','" + marcador_campo + "','" + maquina_destino + "')";


                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.Message);

                }

            }

            if (id07.Text != "id")
            {
                string empresa = combo_empresa.Text;
                string item_pai = text_cod_item.Text;
                string descri_pai = combo_descricao_item.Text;
                string cod_item_compon = string.Empty;
                string cliente = combo_cliente.Text;
                string num_transac = Gerar_num_transac(DateTime.Now, DateTime.Now);
                double Qt_total = 0;
                DateTime dat_validade_fim = DateTime.Now.AddDays(1826);
                int cod_posicao = 0;

                int pct_refug = Convert.ToInt32(text_percentual_refugo07.Text);
                DateTime dat_validade_ini = dt_inicio07.Value;
                string descri_filho = combo_componente07.Text;
                double qtd_necessaria = Convert.ToDouble(text_qtd_necess07.Text);
                string marcador_campo = combo_componente07.Name;

                string maquina_destino = combo_maquina_destino.Text;

                try
                {
                    //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                    string local_default = @"C:\JP4";
                    string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();
                    string comando_sql;

                    comando_sql = "UPDATE db_estrutura SET " +
                        "empresa='" + empresa +
                        "', item_pai='" + item_pai +
                        "', descri_pai='" + descri_pai +
                        "', cod_item_compon='" + cod_item_compon +
                        "', descri_filho='" + descri_filho +
                        "', qtd_necessaria='" + qtd_necessaria +
                        "', Qt_total='" + Qt_total +
                        "', pct_refug='" + pct_refug +
                        "', dat_validade_ini='" + Convert.ToDateTime(dat_validade_ini) +
                        "', dat_validade_fim='" + Convert.ToDateTime(dat_validade_fim) +
                        "', cod_posicao='" + cod_posicao +
                        "', num_transac='" + num_transac +
                        "', cliente='" + cliente +
                        "', marcador_campo='" + marcador_campo +
                        "', maquina_destino='" + maquina_destino +
                        "' WHERE id_estrutura=" + Convert.ToInt64(id01.Text) + "";


                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            else if (combo_componente07.Text != string.Empty)
            {
                string empresa = combo_empresa.Text;
                string item_pai = text_cod_item.Text;
                string descri_pai = combo_descricao_item.Text;

                string cod_item_compon = string.Empty;

                string cliente = combo_cliente.Text;
                string num_transac = Gerar_num_transac(DateTime.Now, DateTime.Now);

                double Qt_total = 0;
                DateTime dat_validade_fim = DateTime.Now.AddDays(1860);

                int cod_posicao = 0;

                int pct_refug = Convert.ToInt32(text_percentual_refugo07.Text);
                DateTime dat_validade_ini = dt_inicio07.Value;
                string descri_filho = combo_componente07.Text;
                double qtd_necessaria = Convert.ToDouble(text_qtd_necess07.Text);
                string marcador_campo = combo_componente07.Name;
                string maquina_destino = combo_maquina_destino.Text;

                try
                {

                    string comando_sql;
                    //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                    string local_default = @"C:\JP4";
                    string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "INSERT INTO db_estrutura(empresa, item_pai, descri_pai, cod_item_compon, descri_filho, qtd_necessaria, Qt_total, pct_refug, dat_validade_ini, dat_validade_fim, cod_posicao, num_transac, cliente, marcador_campo, maquina_destino) " +
                    "VALUES('" + empresa + "','" + item_pai + "','" + descri_pai + "','" + cod_item_compon + "','" + descri_filho + "','" + qtd_necessaria + "','" + Qt_total + "','" + pct_refug + "','" + dat_validade_ini + "','" + dat_validade_fim + "','" + cod_posicao + "','" + num_transac + "','" + cliente + "','" + marcador_campo + "','" + maquina_destino + "')";


                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.Message);

                }

            }

            if (id08.Text != "id")
            {
                string empresa = combo_empresa.Text;
                string item_pai = text_cod_item.Text;
                string descri_pai = combo_descricao_item.Text;
                string cod_item_compon = string.Empty;
                string cliente = combo_cliente.Text;
                string num_transac = Gerar_num_transac(DateTime.Now, DateTime.Now);
                double Qt_total = 0;
                DateTime dat_validade_fim = DateTime.Now.AddDays(1826);
                int cod_posicao = 0;

                int pct_refug = Convert.ToInt32(text_percentual_refugo08.Text);
                DateTime dat_validade_ini = dt_inicio08.Value;
                string descri_filho = combo_componente08.Text;
                double qtd_necessaria = Convert.ToDouble(text_qtd_necess08.Text);
                string marcador_campo = combo_componente08.Name;

                string maquina_destino = combo_maquina_destino.Text;

                try
                {
                    //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                    string local_default = @"C:\JP4";
                    string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();
                    string comando_sql;

                    comando_sql = "UPDATE db_estrutura SET " +
                        "empresa='" + empresa +
                        "', item_pai='" + item_pai +
                        "', descri_pai='" + descri_pai +
                        "', cod_item_compon='" + cod_item_compon +
                        "', descri_filho='" + descri_filho +
                        "', qtd_necessaria='" + qtd_necessaria +
                        "', Qt_total='" + Qt_total +
                        "', pct_refug='" + pct_refug +
                        "', dat_validade_ini='" + Convert.ToDateTime(dat_validade_ini) +
                        "', dat_validade_fim='" + Convert.ToDateTime(dat_validade_fim) +
                        "', cod_posicao='" + cod_posicao +
                        "', num_transac='" + num_transac +
                        "', cliente='" + cliente +
                        "', marcador_campo='" + marcador_campo +
                        "', maquina_destino='" + maquina_destino +
                        "' WHERE id_estrutura=" + Convert.ToInt64(id01.Text) + "";


                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            else if (combo_componente08.Text != string.Empty)
            {
                string empresa = combo_empresa.Text;
                string item_pai = text_cod_item.Text;
                string descri_pai = combo_descricao_item.Text;

                string cod_item_compon = string.Empty;

                string cliente = combo_cliente.Text;
                string num_transac = Gerar_num_transac(DateTime.Now, DateTime.Now);

                double Qt_total = 0;
                DateTime dat_validade_fim = DateTime.Now.AddDays(1860);

                int cod_posicao = 0;

                int pct_refug = Convert.ToInt32(text_percentual_refugo08.Text);
                DateTime dat_validade_ini = dt_inicio08.Value;
                string descri_filho = combo_componente08.Text;
                double qtd_necessaria = Convert.ToDouble(text_qtd_necess08.Text);
                string marcador_campo = combo_componente08.Name;
                string maquina_destino = combo_maquina_destino.Text;

                try
                {

                    string comando_sql;
                    //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                    string local_default = @"C:\JP4";
                    string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "INSERT INTO db_estrutura(empresa, item_pai, descri_pai, cod_item_compon, descri_filho, qtd_necessaria, Qt_total, pct_refug, dat_validade_ini, dat_validade_fim, cod_posicao, num_transac, cliente, marcador_campo, maquina_destino) " +
                    "VALUES('" + empresa + "','" + item_pai + "','" + descri_pai + "','" + cod_item_compon + "','" + descri_filho + "','" + qtd_necessaria + "','" + Qt_total + "','" + pct_refug + "','" + dat_validade_ini + "','" + dat_validade_fim + "','" + cod_posicao + "','" + num_transac + "','" + cliente + "','" + marcador_campo + "','" + maquina_destino + "')";


                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.Message);

                }
            }

            if (id09.Text != "id")
            {
                string empresa = combo_empresa.Text;
                string item_pai = text_cod_item.Text;
                string descri_pai = combo_descricao_item.Text;
                string cod_item_compon = string.Empty;
                string cliente = combo_cliente.Text;
                string num_transac = Gerar_num_transac(DateTime.Now, DateTime.Now);
                double Qt_total = 0;
                DateTime dat_validade_fim = DateTime.Now.AddDays(1826);
                int cod_posicao = 0;

                int pct_refug = Convert.ToInt32(text_percentual_refugo09.Text);
                DateTime dat_validade_ini = dt_inicio09.Value;
                string descri_filho = combo_componente09.Text;
                double qtd_necessaria = Convert.ToDouble(text_qtd_necess09.Text);
                string marcador_campo = combo_componente09.Name;

                string maquina_destino = combo_maquina_destino.Text;

                try
                {
                    //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                    string local_default = @"C:\JP4";
                    string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();
                    string comando_sql;

                    comando_sql = "UPDATE db_estrutura SET " +
                        "empresa='" + empresa +
                        "', item_pai='" + item_pai +
                        "', descri_pai='" + descri_pai +
                        "', cod_item_compon='" + cod_item_compon +
                        "', descri_filho='" + descri_filho +
                        "', qtd_necessaria='" + qtd_necessaria +
                        "', Qt_total='" + Qt_total +
                        "', pct_refug='" + pct_refug +
                        "', dat_validade_ini='" + Convert.ToDateTime(dat_validade_ini) +
                        "', dat_validade_fim='" + Convert.ToDateTime(dat_validade_fim) +
                        "', cod_posicao='" + cod_posicao +
                        "', num_transac='" + num_transac +
                        "', cliente='" + cliente +
                        "', marcador_campo='" + marcador_campo +
                        "', maquina_destino='" + maquina_destino +
                        "' WHERE id_estrutura=" + Convert.ToInt64(id01.Text) + "";


                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            else if (combo_componente09.Text != string.Empty)
            {
                string empresa = combo_empresa.Text;
                string item_pai = text_cod_item.Text;
                string descri_pai = combo_descricao_item.Text;

                string cod_item_compon = string.Empty;

                string cliente = combo_cliente.Text;
                string num_transac = Gerar_num_transac(DateTime.Now, DateTime.Now);

                double Qt_total = 0;
                DateTime dat_validade_fim = DateTime.Now.AddDays(1860);

                int cod_posicao = 0;

                int pct_refug = Convert.ToInt32(text_percentual_refugo09.Text);
                DateTime dat_validade_ini = dt_inicio09.Value;
                string descri_filho = combo_componente09.Text;
                double qtd_necessaria = Convert.ToDouble(text_qtd_necess09.Text);
                string marcador_campo = combo_componente09.Name;
                string maquina_destino = combo_maquina_destino.Text;

                try
                {

                    string comando_sql;
                    //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                    string local_default = @"C:\JP4";
                    string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "INSERT INTO db_estrutura(empresa, item_pai, descri_pai, cod_item_compon, descri_filho, qtd_necessaria, Qt_total, pct_refug, dat_validade_ini, dat_validade_fim, cod_posicao, num_transac, cliente, marcador_campo, maquina_destino) " +
                    "VALUES('" + empresa + "','" + item_pai + "','" + descri_pai + "','" + cod_item_compon + "','" + descri_filho + "','" + qtd_necessaria + "','" + Qt_total + "','" + pct_refug + "','" + dat_validade_ini + "','" + dat_validade_fim + "','" + cod_posicao + "','" + num_transac + "','" + cliente + "','" + marcador_campo + "','" + maquina_destino + "')";


                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.Message);

                }

            }

            if (id10.Text != "id")
            {
                string empresa = combo_empresa.Text;
                string item_pai = text_cod_item.Text;
                string descri_pai = combo_descricao_item.Text;
                string cod_item_compon = string.Empty;
                string cliente = combo_cliente.Text;
                string num_transac = Gerar_num_transac(DateTime.Now, DateTime.Now);
                double Qt_total = 0;
                DateTime dat_validade_fim = DateTime.Now.AddDays(1826);
                int cod_posicao = 0;

                int pct_refug = Convert.ToInt32(text_percentual_refugo10.Text);
                DateTime dat_validade_ini = dt_inicio10.Value;
                string descri_filho = combo_componente10.Text;
                double qtd_necessaria = Convert.ToDouble(text_qtd_necess10.Text);
                string marcador_campo = combo_componente10.Name;

                string maquina_destino = combo_maquina_destino.Text;

                try
                {
                    //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                    string local_default = @"C:\JP4";
                    string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();
                    string comando_sql;

                    comando_sql = "UPDATE db_estrutura SET " +
                        "empresa='" + empresa +
                        "', item_pai='" + item_pai +
                        "', descri_pai='" + descri_pai +
                        "', cod_item_compon='" + cod_item_compon +
                        "', descri_filho='" + descri_filho +
                        "', qtd_necessaria='" + qtd_necessaria +
                        "', Qt_total='" + Qt_total +
                        "', pct_refug='" + pct_refug +
                        "', dat_validade_ini='" + Convert.ToDateTime(dat_validade_ini) +
                        "', dat_validade_fim='" + Convert.ToDateTime(dat_validade_fim) +
                        "', cod_posicao='" + cod_posicao +
                        "', num_transac='" + num_transac +
                        "', cliente='" + cliente +
                        "', marcador_campo='" + marcador_campo +
                        "', maquina_destino='" + maquina_destino +
                        "' WHERE id_estrutura=" + Convert.ToInt64(id01.Text) + "";


                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            else if (combo_componente10.Text != string.Empty)
            {
                string empresa = combo_empresa.Text;
                string item_pai = text_cod_item.Text;
                string descri_pai = combo_descricao_item.Text;

                string cod_item_compon = string.Empty;

                string cliente = combo_cliente.Text;
                string num_transac = Gerar_num_transac(DateTime.Now, DateTime.Now);

                double Qt_total = 0;
                DateTime dat_validade_fim = DateTime.Now.AddDays(1860);

                int cod_posicao = 0;

                int pct_refug = Convert.ToInt32(text_percentual_refugo10.Text);
                DateTime dat_validade_ini = dt_inicio10.Value;
                string descri_filho = combo_componente10.Text;
                double qtd_necessaria = Convert.ToDouble(text_qtd_necess10.Text);
                string marcador_campo = combo_componente10.Name;
                string maquina_destino = combo_maquina_destino.Text;

                try
                {

                    string comando_sql;
                    //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                    string local_default = @"C:\JP4";
                    string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "INSERT INTO db_estrutura(empresa, item_pai, descri_pai, cod_item_compon, descri_filho, qtd_necessaria, Qt_total, pct_refug, dat_validade_ini, dat_validade_fim, cod_posicao, num_transac, cliente, marcador_campo, maquina_destino) " +
                    "VALUES('" + empresa + "','" + item_pai + "','" + descri_pai + "','" + cod_item_compon + "','" + descri_filho + "','" + qtd_necessaria + "','" + Qt_total + "','" + pct_refug + "','" + dat_validade_ini + "','" + dat_validade_fim + "','" + cod_posicao + "','" + num_transac + "','" + cliente + "','" + marcador_campo + "','" + maquina_destino + "')";


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
        private string Gerar_num_transac(DateTime dia_atual, DateTime hr_atual)
        {
            string resultado = Convert.ToString(dia_atual.Day) + hr_atual.Hour + hr_atual.Minute + hr_atual.Second;
            return resultado;

        }
        private void Salvar_estrutura()
        {
            if (combo_componente01.Text != string.Empty)
            {
                string empresa = combo_empresa.Text;
                string item_pai = text_cod_item.Text;
                string descri_pai = combo_descricao_item.Text;

                string cod_item_compon = string.Empty;

                string cliente = combo_cliente.Text;
                string num_transac = Gerar_num_transac(DateTime.Now, DateTime.Now);

                double Qt_total = 0;
                DateTime dat_validade_fim = DateTime.Now.AddDays(1860);

                int cod_posicao = 0;

                int pct_refug = Convert.ToInt32(text_percentual_refugo01.Text);
                DateTime dat_validade_ini = dt_inicio01.Value;
                string descri_filho = combo_componente01.Text;
                double qtd_necessaria = Convert.ToDouble(text_qtd_necess01.Text);
                string marcador_campo = combo_componente01.Name;

                string maquina_destino = combo_maquina_destino.Text;

                try
                {

                    string comando_sql;
                    //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                    string local_default = @"C:\JP4";
                    string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "INSERT INTO db_estrutura(empresa, item_pai, descri_pai, cod_item_compon, descri_filho, qtd_necessaria, Qt_total, pct_refug, dat_validade_ini, dat_validade_fim, cod_posicao, num_transac, cliente, marcador_campo, maquina_destino) " +
                    "VALUES('" + empresa + "','" + item_pai + "','" + descri_pai + "','" + cod_item_compon + "','" + descri_filho + "','" + qtd_necessaria + "','" + Qt_total + "','" + pct_refug + "','" + dat_validade_ini + "','" + dat_validade_fim + "','" + cod_posicao + "','" + num_transac + "','" + cliente + "','" + marcador_campo + "','" + maquina_destino + "')";


                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.Message);

                }

            }
            if (combo_componente02.Text != string.Empty)
            {
                string empresa = combo_empresa.Text;
                string item_pai = text_cod_item.Text;
                string descri_pai = combo_descricao_item.Text;

                string cod_item_compon = string.Empty;

                string cliente = combo_cliente.Text;
                string num_transac = Gerar_num_transac(DateTime.Now, DateTime.Now);

                double Qt_total = 0;
                DateTime dat_validade_fim = DateTime.Now.AddDays(1860);

                int cod_posicao = 0;

                int pct_refug = Convert.ToInt32(text_percentual_refugo02.Text);
                DateTime dat_validade_ini = dt_inicio02.Value;
                string descri_filho = combo_componente02.Text;
                double qtd_necessaria = Convert.ToDouble(text_qtd_necess02.Text);
                string marcador_campo = combo_componente02.Name;

                string maquina_destino = combo_maquina_destino.Text;

                try
                {

                    string comando_sql;
                    //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                    string local_default = @"C:\JP4";
                    string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "INSERT INTO db_estrutura(empresa, item_pai, descri_pai, cod_item_compon, descri_filho, qtd_necessaria, Qt_total, pct_refug, dat_validade_ini, dat_validade_fim, cod_posicao, num_transac, cliente, marcador_campo, maquina_destino) " +
                    "VALUES('" + empresa + "','" + item_pai + "','" + descri_pai + "','" + cod_item_compon + "','" + descri_filho + "','" + qtd_necessaria + "','" + Qt_total + "','" + pct_refug + "','" + dat_validade_ini + "','" + dat_validade_fim + "','" + cod_posicao + "','" + num_transac + "','" + cliente + "','" + marcador_campo + "','" + maquina_destino + "')";


                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.Message);

                }


            }
            if (combo_componente03.Text != string.Empty)
            {
                string empresa = combo_empresa.Text;
                string item_pai = text_cod_item.Text;
                string descri_pai = combo_descricao_item.Text;

                string cod_item_compon = string.Empty;

                string cliente = combo_cliente.Text;
                string num_transac = Gerar_num_transac(DateTime.Now, DateTime.Now);

                double Qt_total = 0;
                DateTime dat_validade_fim = DateTime.Now.AddDays(1860);

                int cod_posicao = 0;

                int pct_refug = Convert.ToInt32(text_percentual_refugo03.Text);
                DateTime dat_validade_ini = dt_inicio03.Value;
                string descri_filho = combo_componente03.Text;
                double qtd_necessaria = Convert.ToDouble(text_qtd_necess03.Text);
                string marcador_campo = combo_componente03.Name;
                string maquina_destino = combo_maquina_destino.Text;

                try
                {

                    string comando_sql;
                    //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                    string local_default = @"C:\JP4";
                    string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "INSERT INTO db_estrutura(empresa, item_pai, descri_pai, cod_item_compon, descri_filho, qtd_necessaria, Qt_total, pct_refug, dat_validade_ini, dat_validade_fim, cod_posicao, num_transac, cliente, marcador_campo, maquina_destino) " +
                    "VALUES('" + empresa + "','" + item_pai + "','" + descri_pai + "','" + cod_item_compon + "','" + descri_filho + "','" + qtd_necessaria + "','" + Qt_total + "','" + pct_refug + "','" + dat_validade_ini + "','" + dat_validade_fim + "','" + cod_posicao + "','" + num_transac + "','" + cliente + "','" + marcador_campo + "','" + maquina_destino + "')";


                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.Message);

                }


            }
            if (combo_componente04.Text != string.Empty)
            {
                string empresa = combo_empresa.Text;
                string item_pai = text_cod_item.Text;
                string descri_pai = combo_descricao_item.Text;

                string cod_item_compon = string.Empty;

                string cliente = combo_cliente.Text;
                string num_transac = Gerar_num_transac(DateTime.Now, DateTime.Now);

                double Qt_total = 0;
                DateTime dat_validade_fim = DateTime.Now.AddDays(1860);

                int cod_posicao = 0;

                int pct_refug = Convert.ToInt32(text_percentual_refugo04.Text);
                DateTime dat_validade_ini = dt_inicio04.Value;
                string descri_filho = combo_componente04.Text;
                double qtd_necessaria = Convert.ToDouble(text_qtd_necess04.Text);
                string marcador_campo = combo_componente04.Name;

                string maquina_destino = combo_maquina_destino.Text;

                try
                {

                    string comando_sql;
                    //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                    string local_default = @"C:\JP4";
                    string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "INSERT INTO db_estrutura(empresa, item_pai, descri_pai, cod_item_compon, descri_filho, qtd_necessaria, Qt_total, pct_refug, dat_validade_ini, dat_validade_fim, cod_posicao, num_transac, cliente, marcador_campo, maquina_destino) " +
                    "VALUES('" + empresa + "','" + item_pai + "','" + descri_pai + "','" + cod_item_compon + "','" + descri_filho + "','" + qtd_necessaria + "','" + Qt_total + "','" + pct_refug + "','" + dat_validade_ini + "','" + dat_validade_fim + "','" + cod_posicao + "','" + num_transac + "','" + cliente + "','" + marcador_campo + "','" + maquina_destino + "')";


                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.Message);

                }

            }
            if (combo_componente05.Text != string.Empty)
            {
                string empresa = combo_empresa.Text;
                string item_pai = text_cod_item.Text;
                string descri_pai = combo_descricao_item.Text;

                string cod_item_compon = string.Empty;

                string cliente = combo_cliente.Text;
                string num_transac = Gerar_num_transac(DateTime.Now, DateTime.Now);

                double Qt_total = 0;
                DateTime dat_validade_fim = DateTime.Now.AddDays(1860);

                int cod_posicao = 0;

                int pct_refug = Convert.ToInt32(text_percentual_refugo05.Text);
                DateTime dat_validade_ini = dt_inicio05.Value;
                string descri_filho = combo_componente05.Text;
                double qtd_necessaria = Convert.ToDouble(text_qtd_necess05.Text);
                string marcador_campo = combo_componente05.Name;

                string maquina_destino = combo_maquina_destino.Text;

                try
                {

                    string comando_sql;
                    //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                    string local_default = @"C:\JP4";
                    string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "INSERT INTO db_estrutura(empresa, item_pai, descri_pai, cod_item_compon, descri_filho, qtd_necessaria, Qt_total, pct_refug, dat_validade_ini, dat_validade_fim, cod_posicao, num_transac, cliente, marcador_campo, maquina_destino) " +
                    "VALUES('" + empresa + "','" + item_pai + "','" + descri_pai + "','" + cod_item_compon + "','" + descri_filho + "','" + qtd_necessaria + "','" + Qt_total + "','" + pct_refug + "','" + dat_validade_ini + "','" + dat_validade_fim + "','" + cod_posicao + "','" + num_transac + "','" + cliente + "','" + marcador_campo + "','" + maquina_destino + "')";


                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.Message);

                }


            }
            if (combo_componente06.Text != string.Empty)
            {
                string empresa = combo_empresa.Text;
                string item_pai = text_cod_item.Text;
                string descri_pai = combo_descricao_item.Text;

                string cod_item_compon = string.Empty;

                string cliente = combo_cliente.Text;
                string num_transac = Gerar_num_transac(DateTime.Now, DateTime.Now);

                double Qt_total = 0;
                DateTime dat_validade_fim = DateTime.Now.AddDays(1860);

                int cod_posicao = 0;

                int pct_refug = Convert.ToInt32(text_percentual_refugo06.Text);
                DateTime dat_validade_ini = dt_inicio06.Value;
                string descri_filho = combo_componente06.Text;
                double qtd_necessaria = Convert.ToDouble(text_qtd_necess06.Text);
                string marcador_campo = combo_componente06.Name;
                string maquina_destino = combo_maquina_destino.Text;

                try
                {

                    string comando_sql;
                    //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                    string local_default = @"C:\JP4";
                    string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "INSERT INTO db_estrutura(empresa, item_pai, descri_pai, cod_item_compon, descri_filho, qtd_necessaria, Qt_total, pct_refug, dat_validade_ini, dat_validade_fim, cod_posicao, num_transac, cliente, marcador_campo, maquina_destino) " +
                    "VALUES('" + empresa + "','" + item_pai + "','" + descri_pai + "','" + cod_item_compon + "','" + descri_filho + "','" + qtd_necessaria + "','" + Qt_total + "','" + pct_refug + "','" + dat_validade_ini + "','" + dat_validade_fim + "','" + cod_posicao + "','" + num_transac + "','" + cliente + "','" + marcador_campo + "','" + maquina_destino + "')";


                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.Message);

                }

            }
            if (combo_componente07.Text != string.Empty)
            {
                string empresa = combo_empresa.Text;
                string item_pai = text_cod_item.Text;
                string descri_pai = combo_descricao_item.Text;

                string cod_item_compon = string.Empty;

                string cliente = combo_cliente.Text;
                string num_transac = Gerar_num_transac(DateTime.Now, DateTime.Now);

                double Qt_total = 0;
                DateTime dat_validade_fim = DateTime.Now.AddDays(1860);

                int cod_posicao = 0;

                int pct_refug = Convert.ToInt32(text_percentual_refugo07.Text);
                DateTime dat_validade_ini = dt_inicio07.Value;
                string descri_filho = combo_componente07.Text;
                double qtd_necessaria = Convert.ToDouble(text_qtd_necess07.Text);
                string marcador_campo = combo_componente07.Name;

                string maquina_destino = combo_maquina_destino.Text;

                try
                {

                    string comando_sql;
                    //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                    string local_default = @"C:\JP4";
                    string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "INSERT INTO db_estrutura(empresa, item_pai, descri_pai, cod_item_compon, descri_filho, qtd_necessaria, Qt_total, pct_refug, dat_validade_ini, dat_validade_fim, cod_posicao, num_transac, cliente, marcador_campo, maquina_destino) " +
                    "VALUES('" + empresa + "','" + item_pai + "','" + descri_pai + "','" + cod_item_compon + "','" + descri_filho + "','" + qtd_necessaria + "','" + Qt_total + "','" + pct_refug + "','" + dat_validade_ini + "','" + dat_validade_fim + "','" + cod_posicao + "','" + num_transac + "','" + cliente + "','" + marcador_campo + "','" + maquina_destino + "')";


                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.Message);

                }


            }
            if (combo_componente08.Text != string.Empty)
            {
                string empresa = combo_empresa.Text;
                string item_pai = text_cod_item.Text;
                string descri_pai = combo_descricao_item.Text;

                string cod_item_compon = string.Empty;

                string cliente = combo_cliente.Text;
                string num_transac = Gerar_num_transac(DateTime.Now, DateTime.Now);

                double Qt_total = 0;
                DateTime dat_validade_fim = DateTime.Now.AddDays(1860);

                int cod_posicao = 0;

                int pct_refug = Convert.ToInt32(text_percentual_refugo08.Text);
                DateTime dat_validade_ini = dt_inicio08.Value;
                string descri_filho = combo_componente08.Text;
                double qtd_necessaria = Convert.ToDouble(text_qtd_necess08.Text);
                string marcador_campo = combo_componente08.Name;

                string maquina_destino = combo_maquina_destino.Text;

                try
                {

                    string comando_sql;
                    //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                    string local_default = @"C:\JP4";
                    string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "INSERT INTO db_estrutura(empresa, item_pai, descri_pai, cod_item_compon, descri_filho, qtd_necessaria, Qt_total, pct_refug, dat_validade_ini, dat_validade_fim, cod_posicao, num_transac, cliente, marcador_campo, maquina_destino) " +
                    "VALUES('" + empresa + "','" + item_pai + "','" + descri_pai + "','" + cod_item_compon + "','" + descri_filho + "','" + qtd_necessaria + "','" + Qt_total + "','" + pct_refug + "','" + dat_validade_ini + "','" + dat_validade_fim + "','" + cod_posicao + "','" + num_transac + "','" + cliente + "','" + marcador_campo + "','" + maquina_destino + "')";


                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.Message);

                }


            }
            if (combo_componente09.Text != string.Empty)
            {
                string empresa = combo_empresa.Text;
                string item_pai = text_cod_item.Text;
                string descri_pai = combo_descricao_item.Text;

                string cod_item_compon = string.Empty;

                string cliente = combo_cliente.Text;
                string num_transac = Gerar_num_transac(DateTime.Now, DateTime.Now);

                double Qt_total = 0;
                DateTime dat_validade_fim = DateTime.Now.AddDays(1860);

                int cod_posicao = 0;

                int pct_refug = Convert.ToInt32(text_percentual_refugo09.Text);
                DateTime dat_validade_ini = dt_inicio09.Value;
                string descri_filho = combo_componente09.Text;
                double qtd_necessaria = Convert.ToDouble(text_qtd_necess09.Text);
                string marcador_campo = combo_componente09.Name;

                string maquina_destino = combo_maquina_destino.Text;

                try
                {

                    string comando_sql;
                    //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                    string local_default = @"C:\JP4";
                    string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "INSERT INTO db_estrutura(empresa, item_pai, descri_pai, cod_item_compon, descri_filho, qtd_necessaria, Qt_total, pct_refug, dat_validade_ini, dat_validade_fim, cod_posicao, num_transac, cliente, marcador_campo, maquina_destino) " +
                    "VALUES('" + empresa + "','" + item_pai + "','" + descri_pai + "','" + cod_item_compon + "','" + descri_filho + "','" + qtd_necessaria + "','" + Qt_total + "','" + pct_refug + "','" + dat_validade_ini + "','" + dat_validade_fim + "','" + cod_posicao + "','" + num_transac + "','" + cliente + "','" + marcador_campo + "','" + maquina_destino + "')";


                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.Message);

                }


            }
            if (combo_componente10.Text != string.Empty)
            {
                string empresa = combo_empresa.Text;
                string item_pai = text_cod_item.Text;
                string descri_pai = combo_descricao_item.Text;

                string cod_item_compon = string.Empty;

                string cliente = combo_cliente.Text;
                string num_transac = Gerar_num_transac(DateTime.Now, DateTime.Now);

                double Qt_total = 0;
                DateTime dat_validade_fim = DateTime.Now.AddDays(1860);

                int cod_posicao = 0;

                int pct_refug = Convert.ToInt32(text_percentual_refugo10.Text);
                DateTime dat_validade_ini = dt_inicio10.Value;
                string descri_filho = combo_componente10.Text;
                double qtd_necessaria = Convert.ToDouble(text_qtd_necess10.Text);
                string marcador_campo = combo_componente10.Name;
                string maquina_destino = combo_maquina_destino.Text;

                try
                {

                    string comando_sql;
                    //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                    string local_default = @"C:\JP4";
                    string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "INSERT INTO db_estrutura(empresa, item_pai, descri_pai, cod_item_compon, descri_filho, qtd_necessaria, Qt_total, pct_refug, dat_validade_ini, dat_validade_fim, cod_posicao, num_transac, cliente, marcador_campo, maquina_destino) " +
                    "VALUES('" + empresa + "','" + item_pai + "','" + descri_pai + "','" + cod_item_compon + "','" + descri_filho + "','" + qtd_necessaria + "','" + Qt_total + "','" + pct_refug + "','" + dat_validade_ini + "','" + dat_validade_fim + "','" + cod_posicao + "','" + num_transac + "','" + cliente + "','" + marcador_campo + "','" + maquina_destino + "')";


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
        private void Delete_item_estrutura(long id_cadastro)
        {

            string comando_sql;

            //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
            IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
            string local_default = @"C:\JP4";
            string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

            OleDbConnection conexao = new OleDbConnection(conecta_string);
            conexao.Open();
            try
            {
                comando_sql = "DELETE FROM db_estrutura WHERE id_estrutura =" + id_cadastro;

                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            Limpar_campos();
            Carregar_estrutura(combo_descricao_item.Text, combo_cliente.Text, combo_maquina_destino.Text);

        }
        private void button_editar_Click(object sender, EventArgs e)
        {
            Desbloquear_controles();
        }
        private void button_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                Salvar_estrutura();
                MessageBox.Show("Salvo com sucesso!");
                Limpar_campos();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao salvar");
            }


        }
        private void button_pesquisar_Click(object sender, EventArgs e)
        {
            Limpar_campos();
            Carregar_estrutura(this.combo_descricao_item.Text, combo_cliente.Text, combo_maquina_destino.Text);

        }
        private void combo_descricao_item_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                string local_default = @"C:\JP4";
                string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select * from db_cadastro_material where descricao_completa = '" + this.combo_descricao_item.Text + "'";


                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    this.text_cod_item.Text = myreader["codigo_item"].ToString();
                }

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void button_delete_Click(object sender, EventArgs e)
        {
            if (delete01.Checked == true)
            {
                Delete_item_estrutura(Convert.ToInt64(id01.Text));
            }

            if (delete02.Checked == true)
            {
                Delete_item_estrutura(Convert.ToInt64(id02.Text));
            }

            if (delete03.Checked == true)
            {
                Delete_item_estrutura(Convert.ToInt64(id03.Text));
            }

            if (delete04.Checked == true)
            {
                Delete_item_estrutura(Convert.ToInt64(id04.Text));
            }

            if (delete05.Checked == true)
            {
                Delete_item_estrutura(Convert.ToInt64(id05.Text));
            }

            if (delete06.Checked == true)
            {
                Delete_item_estrutura(Convert.ToInt64(id06.Text));
            }

            if (delete07.Checked == true)
            {
                Delete_item_estrutura(Convert.ToInt64(id07.Text));
            }

            if (delete08.Checked == true)
            {
                Delete_item_estrutura(Convert.ToInt64(id08.Text));
            }

            if (delete09.Checked == true)
            {
                Delete_item_estrutura(Convert.ToInt64(id09.Text));
            }

            if (delete10.Checked == true)
            {
                Delete_item_estrutura(Convert.ToInt64(id10.Text));
            }

        }
        private void button_atualizar_Click(object sender, EventArgs e)
        {

            try
            {
                Atualizar_estrutura();
                MessageBox.Show("Atualizado com sucesso");
            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao atualizar!");


            }


        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
