using ClosedXML.Excel;
using System;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace JP4
{
    public partial class AP01 : Form
    {
        public AP01()
        {
            InitializeComponent();

            #region Chamar Metodos
            importar_ordens();
            carregar_empresa_db();
            carregar_maquina_db();
            carregar_turno_db();
            carregar_operadores_db();
            carregar_local_destino_db();
            carregar_local_origem_db();
            #endregion

        }

        private void Form_janela_apont_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult resposta = MessageBox.Show(this, "Deseja salvar lançamento!", "Apontamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    MessageBox.Show(resposta.ToString());
                    apontar_ordem();
                    

                }
                else if (resposta == DialogResult.No)
                {

                }

            }
        }


        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #region Metodos Janela Apontamento

        private int verifica_campos()
        {
            //if(!string.IsNullOrEmpty(this.combo_ordem_prod.Text))



            this.combo_maquinas.Enabled = true;
            this.combo_cod_item.Enabled = true;
            this.combo_desc_completa.Enabled = true;
            this.text_qtd_planejada.Enabled = true;
            this.text_qtd_saldo.Enabled = true;
            this.combo_maquinas.Enabled = true;
            this.combo_turnos.Enabled = true;
            this.combo_operadores.Enabled = true;
            this.dt_inicio_pro.Enabled = true;
            this.hr_inicial_prod.Enabled = true;
            this.dt_final_pro.Enabled = true;
            this.hr_final_prod.Enabled = true;
            this.text_operacao.Enabled = true;
            this.text_qtd_boa.Enabled = true;
            this.text_bobina_ini.Enabled = true;
            this.text_bobina_fim.Enabled = true;
            this.text_velocidade.Enabled = true;
            this.text_contador.Enabled = true;
            this.text_qtd_fardos.Enabled = true;
            this.text_largura.Enabled = true;
            this.combo_local_orig.Enabled = true;
            this.combo_local_desti.Enabled = true;
            this.text_lotes.Enabled = true;
            this.combo_empresa.Enabled = true;
            this.dt_lançamento.Enabled = true;

            return 0;
        }

        private void desbloquear_controles()
        {
            this.text_operacao.Text = "APON";


            this.combo_ordem_prod.Enabled = true;
            this.combo_maquinas.Enabled = true;
            this.combo_cod_item.Enabled = true;
            this.combo_desc_completa.Enabled = true;
            this.text_qtd_planejada.Enabled = true;
            this.text_qtd_saldo.Enabled = true;
            this.combo_maquinas.Enabled = true;
            this.combo_turnos.Enabled = true;
            this.combo_operadores.Enabled = true;
            this.dt_inicio_pro.Enabled = true;
            this.hr_inicial_prod.Enabled = true;
            this.dt_final_pro.Enabled = true;
            this.hr_final_prod.Enabled = true;
            this.text_operacao.Enabled = true;
            this.text_qtd_boa.Enabled = true;
            this.text_bobina_ini.Enabled = true;
            this.text_bobina_fim.Enabled = true;
            this.text_velocidade.Enabled = true;
            this.text_contador.Enabled = true;
            this.text_qtd_fardos.Enabled = true;
            this.text_largura.Enabled = true;
            this.combo_local_orig.Enabled = true;
            this.combo_local_desti.Enabled = true;
            this.text_lotes.Enabled = true;
            this.combo_empresa.Enabled = true;
            this.dt_lançamento.Enabled = true;



        }



        private void apontar_ordem()
        {
            // Metodos
            //desbloquear_controles();

            //----

            // id_estoque_trans = 
            string cod_empresa = this.combo_empresa.Text;
            double num_transac = 0;
            string cod_item = this.combo_cod_item.Text;
            string cod_descri_completa = this.combo_desc_completa.Text;
            string cod_descri_reduzida = "";
            int mes_proces = DateTime.Now.Month;
            int mes_movto = DateTime.Now.Month;
            int ano_movto = DateTime.Now.Year;
            DateTime dat_proces = DateTime.Today;
            DateTime dat_movto = Convert.ToDateTime(this.dt_final_pro.Value);
            string cod_operacao = this.text_operacao.Text;
            double num_docum = Convert.ToDouble(this.combo_ordem_prod.Text);
            string ies_tip_movto = this.label_tipo_movimento.Text;
            double qtd_movto = Convert.ToDouble(this.text_qtd_boa.Text);
            double qtd_real = qtd_movto * (-1);            
            double fardos = Convert.ToDouble(this.text_qtd_fardos.Text);
            double num_secao_requis = 1;
            string operador = this.combo_operadores.Text;
            string secao_nome = "";
            string cod_local_est_orig = this.combo_local_orig.Text;
            string cod_local_est_dest = this.combo_local_desti.Text;
            string num_lote_orig = "";
            string num_lote_dest = text_lotes.Text;
            string ies_sit_est_orig = "L";
            string ies_sit_est_dest = "L";
            string cod_turno = this.combo_turnos.Text;
            string nom_usuario = "";
            string num_prog = this.Name;
            double largura_material = 0;
            double n_bobina_inical = Convert.ToDouble(this.text_bobina_ini.Text);
            double n_bobina_final = Convert.ToDouble(this.text_bobina_fim.Text);
            double velocidade = Convert.ToDouble(this.text_velocidade.Text);
            double contador_fardos = Convert.ToDouble(this.text_contador.Text);
            double peso_medio_bobina = 0; // Fazer metodo pra calcular o peso
            double peso_total_fardo = 0; // Fazer metodos pra calcular
            DateTime hora_inical = Convert.ToDateTime(this.hr_inicial_prod.Value);
            DateTime hora_final = Convert.ToDateTime(this.hr_final_prod.Value);
            DateTime data_operac = Convert.ToDateTime(this.dt_lançamento.Value);
            DateTime hor_operac = Convert.ToDateTime(DateTime.Now);
            string Tipo_material = this.label_tipo_material.Text;
            string observacao = this.richText_observacao.Text;


            // links para banco de dados

            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                OleDbConnection conexao = new OleDbConnection(conecta_string);
                conexao.Open();

                string comando_sql;

                comando_sql = "INSERT INTO estoque_trans(cod_empresa, num_transac, cod_item, cod_descri_completa, cod_descri_reduzida, mes_proces, mes_movto, ano_movto, dat_proces, dat_movto, cod_operacao, num_docum, ies_tip_movto, qtd_real, qtd_movto, num_secao_requis, operador, secao_nome, cod_local_est_orig, cod_local_est_dest, num_lote_orig, num_lote_dest, ies_sit_est_orig, ies_sit_est_dest, cod_turno, nom_usuario, num_prog, largura_material, n_bobina_inical, n_bobina_final, velocidade, contador, fardos, peso_medio_bobina, peso_total_fardo, hora_inical, hora_final, data_operac, hor_operac, Tipo_material, observacao) " +
                    "VALUES('" + cod_empresa + "','" + num_transac + "','" + cod_item + "','" + cod_descri_completa + "','" + cod_descri_reduzida + "','" + mes_proces + "','" + mes_movto + "','" + ano_movto + "','" + dat_proces + "','" + dat_movto + "','" + cod_operacao + "','" + num_docum + "','" + ies_tip_movto + "','" + qtd_real + "','" + qtd_movto + "','" + num_secao_requis + "','" + operador + "','" + secao_nome + "','" + cod_local_est_orig + "','" + cod_local_est_dest + "','" + num_lote_orig + "','" + num_lote_dest + "','" + ies_sit_est_orig + "','" + ies_sit_est_dest + "','" + cod_turno + "','" + nom_usuario + "','" + num_prog + "','" + largura_material + "','" + n_bobina_inical + "','" + n_bobina_final + "','" + velocidade + "','" + contador_fardos + "','" + fardos + "','" + peso_medio_bobina + "','" + peso_total_fardo + "','" + hora_inical + "','" + hora_final + "','" + data_operac + "','" + hor_operac + "','" + Tipo_material + "','" + observacao + "')";


                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Salvo com Sucesso!!");

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }


            /*
             * Antes de Salvar
             * 01 - Lançar primeiro a movimentação APON
             * 02 - Buscar estrutura do item pai
             * 03 - fazer os calculos da estrutura
             * 04 - lançar componenten com a operação BACK (baixa)
             * 05 - Mostrar mensagem
             */




        }

        private void consumo_estrutura(string descri_item, double qtd_apont)
        {
            try
            {
                string item_filho = "";
                double qtd_item_filho = 0;


                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;

                string comando_sql = "select * from db_estrutura where descri_pai = '" + descri_item + "'";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();


                while (myreader.Read())
                {
                    if (DateTime.Today >= Convert.ToDateTime(myreader["dat_validade_ini"]) & DateTime.Today <= Convert.ToDateTime(myreader["dat_validade_fim"]))
                    {
                        item_filho = myreader["descri_filho"].ToString();
                        qtd_item_filho = Convert.ToDouble(myreader["qtd_necessaria"]) * qtd_apont;
                    }
                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }

        private void estornar_ordem()
        {
            /*
            try
            {

                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;

                string comando_sql = "select * from db_cadastro_empresas";

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
            */
        }



        #endregion


        #region Metodos de calculo


        private void importar_ordens()
        {

            try
            {
                // adicionar uma janela para o usuário esclher a pasta e local da pasta
                // adicionar uma opção para escolher o nome da aba dentro do arquivo

                //var xls = new XLWorkbook(@"C:\Users\Jeferson\OneDrive\Visual - basic c#\Import_sistema\db_ordem_prod.xlsx");
                var xls = new XLWorkbook(Properties.Settings.Default.local_arquivo_excel);
                var planilha = xls.Worksheets.First(w => w.Name == "db_ordem_prod");
                var totalLinhas = planilha.Rows().Count();
                // primeira linha é o cabecalho
                for (int l = 2; l <= totalLinhas; l++)
                {

                    if (planilha.Cell($"G{l}").Value.ToString() != "Digitada")
                        this.combo_ordem_prod.Items.Add(planilha.Cell($"B{l}").Value.ToString());


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void carregar_descricao_completa(string ordem_prod)
        {
            try
            {
                // Referencia https://carloscds.net/2021/01/lendo-planilha-excel-mais-simples/
                // adicionar uma janela para o usuário esclher a pasta e local da pasta
                // adicionar uma opção para escolher o nome da aba dentro do arquivo

                //var xls = new XLWorkbook(@"C:\Users\Jeferson\OneDrive\Visual - basic c#\Import_sistema\db_ordem_prod.xlsx");
                var xls = new XLWorkbook(Properties.Settings.Default.local_arquivo_excel);
                var planilha = xls.Worksheets.First(w => w.Name == "db_ordem_prod");
                var totalLinhas = planilha.Rows().Count();
                // primeira linha é o cabecalho
                for (int l = 2; l <= totalLinhas; l++)
                {
                    if (planilha.Cell($"B{l}").Value.ToString() == ordem_prod & planilha.Cell($"G{l}").Value.ToString() != "Digitada")
                    {
                        this.combo_desc_completa.Text = planilha.Cell($"F{l}").Value.ToString();
                        break;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void carregar_cod_item(string ordem_prod)
        {
            try
            {
                // Referencia https://carloscds.net/2021/01/lendo-planilha-excel-mais-simples/
                // adicionar uma janela para o usuário esclher a pasta e local da pasta
                // adicionar uma opção para escolher o nome da aba dentro do arquivo

                //var xls = new XLWorkbook(@"C:\Users\Jeferson\OneDrive\Visual - basic c#\Import_sistema\db_ordem_prod.xlsx");
                var xls = new XLWorkbook(Properties.Settings.Default.local_arquivo_excel);
                var planilha = xls.Worksheets.First(w => w.Name == "db_ordem_prod");
                var totalLinhas = planilha.Rows().Count();
                // primeira linha é o cabecalho
                for (int l = 2; l <= totalLinhas; l++)
                {
                    if (planilha.Cell($"B{l}").Value.ToString() == ordem_prod & planilha.Cell($"G{l}").Value.ToString() != "Digitada")
                    {
                        this.combo_cod_item.Text = planilha.Cell($"E{l}").Value.ToString();
                        break;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void carregar_qtd_prevista(string ordem_prod)
        {
            try
            {
                // Referencia https://carloscds.net/2021/01/lendo-planilha-excel-mais-simples/
                // adicionar uma janela para o usuário esclher a pasta e local da pasta
                // adicionar uma opção para escolher o nome da aba dentro do arquivo

                //var xls = new XLWorkbook(@"C:\Users\Jeferson\OneDrive\Visual - basic c#\Import_sistema\db_ordem_prod.xlsx");
                var xls = new XLWorkbook(Properties.Settings.Default.local_arquivo_excel);
                var planilha = xls.Worksheets.First(w => w.Name == "db_ordem_prod");
                var totalLinhas = planilha.Rows().Count();
                // primeira linha é o cabecalho
                for (int l = 2; l <= totalLinhas; l++)
                {
                    if (planilha.Cell($"B{l}").Value.ToString() == ordem_prod & planilha.Cell($"G{l}").Value.ToString() != "Digitada")
                    {
                        this.text_qtd_planejada.Text = planilha.Cell($"H{l}").Value.ToString();
                        break;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void calculo_velocidade()
        {
            double velocidade = 0;

            if (this.text_velocidade.Text == "")
            {
                velocidade = 0;
            }

            string maquina = maquina = this.combo_maquinas.Text;
            velocidade = Convert.ToDouble(this.text_velocidade.Text);

            double velocidade_db = 0;
            double fator = 0;
            double veloc_total = 0;

            if (maquina == "" || velocidade == 0)
            {
                return;
            }

            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_equipamento where descricao_equipamento = '" + maquina + "'";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();


                while (myreader.Read())
                {
                    velocidade_db = Convert.ToDouble(myreader["velocidade_padrao"].ToString());
                    fator = Convert.ToDouble(myreader["fator"].ToString());
                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);

            }


            if (velocidade_db != 0)
            {
                veloc_total = ((velocidade / 100) * velocidade_db) / fator;

                if (veloc_total > velocidade_db)
                {
                    this.text_velocidade.Text = Convert.ToString(velocidade_db);
                }
                else
                {
                    this.text_velocidade.Text = Convert.ToString(veloc_total);
                }
            }
        }


        #endregion



        #region Metodos Carregar combobox

        private void carregar_empresa_db()
        {
            try
            {

                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;

                string comando_sql = "select * from db_cadastro_empresas";

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

        private void carregar_turno_db()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_turnos";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();


                while (myreader.Read())
                {
                    this.combo_turnos.Items.Add(myreader["turno"].ToString());
                }
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }


        private void carregar_maquina_db()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;

                string comando_sql = "select * from db_cadastro_equipamento";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();


                while (myreader.Read())
                {
                    this.combo_maquinas.Items.Add(myreader["descricao_equipamento"].ToString());
                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }

        private void carregar_operadores_db()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_operador"; //where equipamento = 'Picotadeira'";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {

                    this.combo_operadores.Items.Add(myreader["nome"].ToString());
                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }

        }

        private void carregar_local_origem_db()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_local_estoque";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {

                    this.combo_local_orig.Items.Add(myreader["local_estoque"].ToString());
                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }

        private void carregar_local_destino_db()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_local_estoque";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {

                    this.combo_local_desti.Items.Add(myreader["local_estoque"].ToString());
                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }


        #endregion


        #region Botoões do menu da direita

        private void button_apontamento_Click(object sender, EventArgs e)
        {
            desbloquear_controles();
            this.label_tipo_movimento.Text = "N";

        }

        private void button_estornar_Click(object sender, EventArgs e)
        {

        }

        private void button_importar_Click(object sender, EventArgs e)
        {
            importar_ordens();
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

        #region Funcionalidade combobox e textbox da janela

        private void text_qtd_fardos_TextChanged(object sender, EventArgs e)
        {
            string descricao_reduzida = this.combo_cod_item.Text;

            int bobina_inicial = 0;
            int bobina_final = 0;
            int qtd_bobina = 0;
            int total_bobina = 0;

            if (descricao_reduzida == "")
            {
                //MessageBox.Show("Informar a descrição:");
                return;
            }

            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_material where descricao_reduzida = '" + descricao_reduzida + "'";
                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    qtd_bobina = Convert.ToInt32(myreader["qtd_embala"].ToString());

                }
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }

            if (this.text_bobina_fim.Text == "")
            {
                return;
            }

            if (this.text_bobina_fim.Text == "")
            {
                this.text_bobina_fim.Text = Convert.ToString(0);
            }

            if (this.text_qtd_fardos.Text == "")
            {
                //MessageBox.Show("Fardos não deve ser vazio!");
                return;
                //this.text_pico_qtdFardos.Text = Convert.ToString(0);
            }

            if (this.combo_maquinas.Text == "")
            {
                //MessageBox.Show("Maquina não deve ser vazio!");
                return;
                //this.text_pico_qtdFardos.Text = Convert.ToString(0);
            }

            total_bobina = (bobina_final - bobina_inicial) + 1;


            bobina_inicial = Convert.ToInt32(this.text_bobina_fim.Text) - (Convert.ToInt32(this.text_qtd_fardos.Text) * qtd_bobina);

            if (bobina_inicial < 0)
            {
                bobina_final = (bobina_inicial * (-1)) + Convert.ToInt32(this.text_bobina_fim.Text);
                this.text_bobina_fim.Text = Convert.ToString(bobina_final);
                this.text_bobina_ini.Text = Convert.ToString(0);
            }
            else
            {
                this.text_bobina_ini.Text = Convert.ToString(bobina_inicial);
            }

            calculo_velocidade();
        }

        #endregion

        private void combo_ordem_prod_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregar_descricao_completa(this.combo_ordem_prod.Text);
            carregar_cod_item(this.combo_ordem_prod.Text);
            carregar_qtd_prevista(this.combo_ordem_prod.Text);
        }

        private void combo_turnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Esta aparecendo um erro e não puxar do  jeito certo 
                // 08/03/2021 - 17:37
                // 

                var turno = this.combo_turnos.Text;

                DateTime hora_inicio;
                DateTime hora_final;


                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;

                string comando_sql = "select * from db_cadastro_turnos where turno='" + turno + "'";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();


                while (myreader.Read())
                {
                    hora_inicio = Convert.ToDateTime( myreader["inicio_turno"]);
                    hora_final = Convert.ToDateTime( myreader["fim_turno"]);

                    this.label_descri_turno.Text = hora_inicio.ToString("hh:mm") + " as " + hora_final.ToString("hh;mm");
                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }

        private void text_qtd_boa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void text_bobina_ini_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void text_bobina_fim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void text_contador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void text_qtd_fardos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void text_largura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
    }
}
