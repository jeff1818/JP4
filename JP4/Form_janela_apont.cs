using System;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Data;
using ClosedXML.Excel;

namespace JP4
{
    public partial class Form_janela_apont : Form
    {
        public Form_janela_apont()
        {
            InitializeComponent();

            #region Chamar Metodos
            importar_ordens();
            carregar_empresa_db();
            carregar_maquina_db();
            carregar_turno_db();
            carregar_operadores_db();

            #endregion

        }

        private void Form_janela_apont_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                button_apontamento.Focus();
            }
        }


        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Metodos Janela Apontamento

        private void apontar_ordem()
        {
            // Variaveis

            /*
             * 
             * id_estoque_trans
             * cod_empresa
             * num_transac
             * cod_item
             * cod_descri_completa
             * cod_descri_reduzida
             * mes_proces
             * mes_movto
             * ano_movto
             * dat_proces
             * dat_movto
             * cod_operacao
             * num_docum
             * ies_tip_movto
             * qtd_real
             * qtd_movto
             * num_secao_requis
             * operador
             * secao_nome
             * cod_local_est_orig
             * cod_local_est_dest
             * num_lote_orig
             * num_lote_dest
             * ies_sit_est_orig
             * ies_sit_est_dest
             * cod_turno
             * nom_usuario
             * num_prog
             * largura_material
             * n_bobina_inical
             * n_bobina_final
             * velocidade
             * contador	fardos
             * peso_medio_bobina
             * peso_total_fardo
             * hora_inical
             * hora_final
             * data_operac
             * hor_operac
             * Tipo_material
             * observacao
             */


            // links para banco de dados  

        }

        private void estornar_ordem()
        {

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
                var descri_turno = "";


                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;

                string comando_sql = "select * from db_cadastro_turnos where turno='"+ turno + "'";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();


                while (myreader.Read())
                {
                    descri_turno = myreader["inicio_turno"].ToString() + " / " + myreader["fim_turno"].ToString();
                    this.label_descri_turno.Text = descri_turno;                    
                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }
    }
}
