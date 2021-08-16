using ClosedXML.Excel;
using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace JP4
{
    public partial class AP01 : Form
    {
        public AP01()
        {
            InitializeComponent();

            dt_inicio_pro.Value = DateTime.Now;
            dt_final_pro.Value = DateTime.Now;

            #region Chamar Metodos
            Importar_ordens();

            Carregar_empresa_db();
            Carregar_maquina_db();
            Carregar_turno_db();
            Carregar_operadores_db();
            Carregar_local_destino_db();
            Carregar_local_origem_db();
            Carregar_clientes_db();
            // Aba de parada


            // Mistura


            //Carregar_mp_mistura();


            // Aba Pesquisar
            Carregar_operador_pesquisar();
            Carregar_turno_pesquisar();
            Carregar_material_pesquisar();
            Carregar_maquina_pesquisar();

            #endregion

            toolStripStatusLabel_nome.Text = "AP01";
            this.text_operacao.Text = Buscar_operacao("AP01", "Entrada");

            abaPesquisar_text_ano_lanc.Text = Convert.ToString(DateTime.Now.Year);

        }

        public int cod_geral_erro = 0;

        CultureInfo cultures = new CultureInfo("pt-BR");
        private void Form_janela_apont_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Escape)
            {
                //tab_menu_apontamento.SelectedTab = tab_consumo;
                //this.abaConsumo_text__cod_item.Text = combo_cod_item.Text;
                //this.abaConsumo_text_descri_item.Text = combo_desc_completa.Text;
                //this.abaConsumo_text_qtd_boa.Text = Convert.ToString(text_qtd_boa.Text);
                //Carregar_grid(this.combo_desc_completa.Text);

            }
            if (e.KeyCode == Keys.Escape)
            {
                if (Verifica_campos() == 0)
                {
                    tab_menu_apontamento.SelectedTab = tab_consumo;
                    this.abaConsumo_text__cod_item.Text = combo_cod_item.Text;
                    this.abaConsumo_text_descri_item.Text = combo_desc_completa.Text;
                    this.abaConsumo_text_qtd_boa.Text = Convert.ToString(text_qtd_boa.Text);
                    Carregar_grid(combo_desc_completa.Text, combo_cliente_esto.Text, combo_maquinas.Text);

                    if (tab_menu_apontamento.SelectedTab == tab_consumo)
                    {
                        DialogResult resposta = MessageBox.Show(this, "Deseja salvar lançamento!", "Apontamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (resposta == DialogResult.Yes)
                        {
                            //salvar_paradas_mq();
                            //Salvar_mistura();
                            Apontar_ordem(this.label_tipo_movimento.Text);

                            MessageBox.Show("Salvo com Sucesso!!");
                            tab_menu_apontamento.SelectedTab = tab_apontamento;
                            toolStripStatusLabel_status_apon.Text = "Apontamento feito com Sucesso!";
                            Limpar_campos();

                            button_paradas.BackColor = Color.Transparent;
                            button_defeitos.BackColor = Color.Transparent;
                            button_mistura_mp.BackColor = Color.Transparent;
                            this.Refresh();
                        }
                        else if (resposta == DialogResult.No)
                        {
                            tab_menu_apontamento.SelectedTab = tab_apontamento;
                        }
                    }
                }
            }
        }

        #region Metodos de auxiliares

        // Aba apontamento
        private int Verifica_mistura()
        {
            if (text_local_aplicacao.Text == "Extrusora")
            {
                if (AbaMistura_label_total_mistura.Text == "%")
                {
                    MessageBox.Show("Falta completar a mistura ANIMAL!");
                    return 1;
                }
            }

            return 0;

        }

        private void Verifica_ordem_estornada()
        {

        }



        private void Resetar_janela()
        {


        }

        #endregion

        //-------------------------------------------------------------------------------------------

        #region carrega itens do arquivo de excel

        private void Importar_ordens()
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
                        Carregar_local_aplicacao(combo_desc_completa.Text);

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
        private void carregar_maquina_arquivo(string ordem_prod)
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
                        this.combo_maquinas.Text = planilha.Cell($"A{l}").Value.ToString();
                        break;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion // Carregar itens excel 

        //------------------------------------------------------------------------------------------

        #region Botões do menu


        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        #endregion // Botões do menu

        //------------------------------------------------------------------------------------------

        #region Metodos de preencher controles


        // Carregar Local e Empresa
        private void Carregar_local_aplicacao(string descricao_completa)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select local_aplicacao, empresa from db_cadastro_material where descricao_completa ='" + descricao_completa + "'";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    this.text_local_aplicacao.Text = myreader["local_aplicacao"].ToString();
                    this.combo_empresa.Text = myreader["empresa"].ToString();
                    //combo_empresa
                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }


        }
        private void Carregar_empresa_db()
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
        private void Carregar_turno_db()
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
        private void Carregar_maquina_db()
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
        private void Carregar_operadores_db()
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
        private void Carregar_local_origem_db()
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
        private void Carregar_local_destino_db()
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
        private void Carregar_local_origem(string cod_item)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select local_estoque from db_cadastro_material where codigo_item ='" + cod_item + "'";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    this.combo_local_orig.Text = myreader["local_estoque"].ToString();
                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }
        private void Carregar_clientes_db()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_clientes";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();


                while (myreader.Read())
                {
                    this.combo_cliente_esto.Items.Add(myreader["cliente_nome"].ToString());
                }
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        // Aba parada de maquina
        private void Carregar_tipos_parada(string origem_apara)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_paradas where origem_apara ='" + origem_apara + "'";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();
                myreader = cmd.ExecuteReader();


                abaParada_combo_parada01.Items.Clear();
                abaParada_combo_parada02.Items.Clear();
                abaParada_combo_parada03.Items.Clear();
                abaParada_combo_parada04.Items.Clear();
                abaParada_combo_parada05.Items.Clear();
                abaParada_combo_parada06.Items.Clear();
                abaParada_combo_parada07.Items.Clear();
                abaParada_combo_parada08.Items.Clear();


                while (myreader.Read())
                {
                    abaParada_combo_parada01.Items.Add(myreader["descricao_parada"].ToString());
                    abaParada_combo_parada02.Items.Add(myreader["descricao_parada"].ToString());
                    abaParada_combo_parada03.Items.Add(myreader["descricao_parada"].ToString());
                    abaParada_combo_parada04.Items.Add(myreader["descricao_parada"].ToString());
                    abaParada_combo_parada05.Items.Add(myreader["descricao_parada"].ToString());
                    abaParada_combo_parada06.Items.Add(myreader["descricao_parada"].ToString());
                    abaParada_combo_parada07.Items.Add(myreader["descricao_parada"].ToString());
                    abaParada_combo_parada08.Items.Add(myreader["descricao_parada"].ToString());
                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }

        // Aba consumo
        public void Carregar_grid(string item_pai, string cliente, string maquina_destino)
        {
            try
            {
                // Mudei para aceitar o cliente

                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select descri_pai, descri_filho, qtd_necessaria, Qt_total from db_estrutura where cliente='"+ cliente+ "' and maquina_destino = '"+ maquina_destino+"'";

                OleDbConnection connection = new OleDbConnection(conecta_string);
                OleDbDataAdapter myadapter = new OleDbDataAdapter(comando_sql, connection);
                DataTable dt = new DataTable("db_estrutura");

                myadapter.Fill(dt);

                DataView dv = dt.DefaultView;

                dv.RowFilter = string.Format("descri_pai like '%{0}%'", item_pai);
                Grid_estrutura_item.DataSource = dv.ToTable();

                Calcular_qtd_total_grid();

                connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Calcular_qtd_total_grid()
        {

            try
            {
                double total = Convert.ToDouble(this.abaConsumo_text_qtd_boa.Text);

                for (int i = 0; i < Grid_estrutura_item.RowCount - 1; i++)
                {
                    DataGridViewRow row = Grid_estrutura_item.Rows[i];
                    string valueA = row.Cells["qtd_necessaria"].Value.ToString();
                    row.Cells["Qt_total"].Value = (Convert.ToDouble(valueA) * total).ToString("0.00000");
                }

            }
            catch (Exception)
            {
                
            }

        }


        // Aba defeitos de maquina
        private void Carregar_defeitos(string origem_apara)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_apara where origem_apara ='" + origem_apara + "'";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                AbaDefeito_combo_defeito01.Items.Clear();
                AbaDefeito_combo_defeito02.Items.Clear();
                AbaDefeito_combo_defeito03.Items.Clear();
                AbaDefeito_combo_defeito04.Items.Clear();
                AbaDefeito_combo_defeito05.Items.Clear();
                AbaDefeito_combo_defeito06.Items.Clear();
                AbaDefeito_combo_defeito07.Items.Clear();
                AbaDefeito_combo_defeito08.Items.Clear();
                AbaDefeito_combo_defeito09.Items.Clear();
                AbaDefeito_combo_defeito10.Items.Clear();



                while (myreader.Read())
                {
                    this.AbaDefeito_combo_defeito01.Items.Add(myreader["descricao_apara"].ToString());
                    this.AbaDefeito_combo_defeito02.Items.Add(myreader["descricao_apara"].ToString());
                    this.AbaDefeito_combo_defeito03.Items.Add(myreader["descricao_apara"].ToString());
                    this.AbaDefeito_combo_defeito04.Items.Add(myreader["descricao_apara"].ToString());
                    this.AbaDefeito_combo_defeito05.Items.Add(myreader["descricao_apara"].ToString());
                    this.AbaDefeito_combo_defeito06.Items.Add(myreader["descricao_apara"].ToString());
                    this.AbaDefeito_combo_defeito07.Items.Add(myreader["descricao_apara"].ToString());
                    this.AbaDefeito_combo_defeito08.Items.Add(myreader["descricao_apara"].ToString());
                    this.AbaDefeito_combo_defeito09.Items.Add(myreader["descricao_apara"].ToString());
                    this.AbaDefeito_combo_defeito10.Items.Add(myreader["descricao_apara"].ToString());

                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }

        }



        // Metodos de preencher controles
        //------------------------------------------------------------------------------------------
        //Funcionalidade combobox e textbox da janela Apontamento



        //private void text_qtd_fardos_TextChanged(object sender, EventArgs e) { }

        private void combo_ordem_prod_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregar_descricao_completa(this.combo_ordem_prod.Text);
            carregar_cod_item(this.combo_ordem_prod.Text);
            carregar_qtd_prevista(this.combo_ordem_prod.Text);
            Soma_saldo_op(Convert.ToDouble(combo_ordem_prod.Text));
            carregar_maquina_arquivo(this.combo_ordem_prod.Text);
            label_tipo_material.Text = Buscar_tipo_material(combo_desc_completa.Text);


            try
            {
                text_qtd_saldo.Text = Convert.ToString(Convert.ToDouble(text_qtd_planejada.Text) - Convert.ToDouble(text_qtd_saldo.Text));
            }
            catch (Exception)
            {

            }




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
                    hora_inicio = Convert.ToDateTime(myreader["inicio_turno"]);
                    hora_final = Convert.ToDateTime(myreader["fim_turno"]);

                    this.label_descri_turno.Text = hora_inicio.ToString("HH:mm") + " as " + hora_final.ToString("HH;mm");
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
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar == '.'))
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

        private void Calculo_bobina_inicial()
        {
            string descricao_completa = this.combo_desc_completa.Text;
            int qtd_bobina = 0;
            int total = 0;
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_material where descricao_completa = '" + descricao_completa + "'";
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
                MessageBox.Show("Erro ao acessar cadastro de material // " + erro.Message);
            }

            total = Convert.ToInt32(this.text_bobina_fim.Text) - (Convert.ToInt32(this.text_qtd_fardos.Text) * qtd_bobina);

            if (total < 0)
            {
                total = (total * (-1)) + Convert.ToInt32(this.text_bobina_fim.Text);
                this.text_bobina_ini.Text = Convert.ToString(total);
            }
            else
            {
                this.text_bobina_ini.Text = Convert.ToString(total);
            }


        }

        private void text_qtd_fardos_Leave(object sender, EventArgs e)
        {
            string descricao_completa = this.combo_desc_completa.Text;

            int bobina_inicial;
            int bobina_final;
            int qtd_bobina = 0;
            //int total_bobina = 0;

            if (descricao_completa == "" && this.text_bobina_fim.Text == "" && this.text_qtd_fardos.Text == "" && this.combo_maquinas.Text == "")
            {
                //MessageBox.Show("Informar a descrição:");
                return;
            }

            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_material where descricao_completa = '" + descricao_completa + "'";
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
                MessageBox.Show("Erro ao acessar cadastro de material // " + erro.Message);
            }


            if (this.text_bobina_fim.Text == "")
            {
                this.text_bobina_fim.Text = Convert.ToString(0);
            }

            //total_bobina = (bobina_final - bobina_inicial) + 1;

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
        }
        private void text_velocidade_Leave(object sender, EventArgs e)
        {
            Calculo_velocidade();
        }
        private void combo_cod_item_TextChanged(object sender, EventArgs e)
        {
            Carregar_local_origem(combo_cod_item.Text);

        }
        private void text_local_aplicacao_TextChanged(object sender, EventArgs e)
        {

            // Pensar numa forma de fazer essa verificação automatica e dinamica sem congelar 
            // Substituir os termos por algo mais dinamico


            if (text_local_aplicacao.Text == "Extrusora")
            {
                text_contador.Enabled = false;
                text_qtd_fardos.Enabled = false;
                text_largura.Enabled = true;
            }


            if (text_local_aplicacao.Text == "Picotadeira")
            {
                text_largura.Enabled = false;
                text_contador.Enabled = true;
                text_qtd_fardos.Enabled = true;
            }

            if (text_local_aplicacao.Text == String.Empty)
            {
                text_contador.Enabled = true;
                text_qtd_fardos.Enabled = true;
                text_largura.Enabled = true;
            }


        }


        #endregion //Funcionalidade combobox e textbox da janela Apontamento

        //------------------------------------------------------------------------------------------
        #region Metodos de Busca

        // Janela Apontamento

        private string Buscar_operacao(string nome_programa, string tipo_movimento)
        {

            string nome_operacao = "";

            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_operacao where nome_prog = '" + nome_programa + "'";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    if (myreader["tipo_operacao"].ToString() == tipo_movimento)
                    {
                        nome_operacao = myreader["codigo"].ToString();
                    }
                }


                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }

            return nome_operacao;
        }

        private string Buscar_grupo_estoque(string descricao_completa)
        {
            string grupo_estoque = "";

            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_material where descricao_completa = '" + descricao_completa + "'";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    grupo_estoque = myreader["grupo"].ToString();

                }


                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao buscar Grupo de Estoque!  |  " + erro.Message);
            }

            return grupo_estoque;
        }
        private string Buscar_descricao_grupo(string codigo_grupo)
        {
            string nome_grupo = "";

            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_grupo_estoque where codigo_grupo = '" + codigo_grupo + "'";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    nome_grupo = myreader["nome_grupo"].ToString();

                }


                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao buscar Grupo de Estoque!  |  " + erro.Message);
            }

            return nome_grupo;
        }

        private string Buscar_descri_reduzida(string descricao_completa)
        {
            string descri_reduzida = "";

            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_material where descricao_completa = '" + descricao_completa + "'";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    if (myreader["descricao_completa"].ToString() == descri_reduzida)
                    {
                        descri_reduzida = myreader["descricao_reduzida"].ToString();
                    }
                }


                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }

            return descri_reduzida;

        }


        // Janela Parada de maquina
        private string busca_cod_parada_db(string desc_parada)
        {
            string cod_parada = "";
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_paradas where descricao_parada = '" + desc_parada + "'";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    cod_parada = myreader["codigo_parada"].ToString();
                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }

            return cod_parada;
        }


        // Janela Defeitos

        private string busca_cod_defeitos_db(string desc_defeitos)
        {
            string cod_parada = "";
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_apara where descricao_apara = '" + desc_defeitos + "'";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    cod_parada = myreader["codigo_apara"].ToString();
                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }

            return cod_parada;
        }


        // Janela Mistura
        private void Carregar_mp_mistura()
        {
            try
            {

                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;

                string comando_sql = "select * from db_cadastro_material where grupo = '05'";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                abaMistura_combo_mp01.Items.Clear();
                abaMistura_combo_mp02.Items.Clear();
                abaMistura_combo_mp03.Items.Clear();
                abaMistura_combo_mp04.Items.Clear();
                abaMistura_combo_mp05.Items.Clear();
                abaMistura_combo_mp06.Items.Clear();
                abaMistura_combo_mp07.Items.Clear();
                abaMistura_combo_mp08.Items.Clear();
                abaMistura_combo_mp09.Items.Clear();
                abaMistura_combo_mp10.Items.Clear();



                while (myreader.Read())
                {
                    this.abaMistura_combo_mp01.Items.Add(myreader["descricao_completa"].ToString());
                    this.abaMistura_combo_mp02.Items.Add(myreader["descricao_completa"].ToString());
                    this.abaMistura_combo_mp03.Items.Add(myreader["descricao_completa"].ToString());
                    this.abaMistura_combo_mp04.Items.Add(myreader["descricao_completa"].ToString());
                    this.abaMistura_combo_mp05.Items.Add(myreader["descricao_completa"].ToString());
                    this.abaMistura_combo_mp06.Items.Add(myreader["descricao_completa"].ToString());
                    this.abaMistura_combo_mp07.Items.Add(myreader["descricao_completa"].ToString());
                    this.abaMistura_combo_mp08.Items.Add(myreader["descricao_completa"].ToString());
                    this.abaMistura_combo_mp09.Items.Add(myreader["descricao_completa"].ToString());
                    this.abaMistura_combo_mp10.Items.Add(myreader["descricao_completa"].ToString());

                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }


        #endregion // Metodos de busta

        private string Buscar_tipo_material(string cod_descri_completa)
        {
            string tipo_material = "";
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select tipo_material from db_cadastro_material where descricao_completa='" + cod_descri_completa + "'";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
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

        //------------------------------------------------------------------------------------------

        #region Metodos de Calculo

        private void Soma_saldo_op(double num_docum)
        {
            // Ainda falta fazer o calculo de Qtd_boa - soma =  Saldo 

            try
            {

                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;

                string comando_sql = "SELECT SUM(qtd_real) AS Total FROM estoque_trans WHERE num_docum=" + num_docum + " AND cod_operacao='APON'";
                // SELECT NOME, SUM(PONTOS) AS total FROM tabela

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    text_qtd_saldo.Text = myreader["Total"].ToString();
                }

                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Calculo_velocidade()
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
            double veloc_total;

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
                    this.text_velocidade.Text = Convert.ToString(Convert.ToInt32(velocidade_db));
                }
                else
                {
                    this.text_velocidade.Text = Convert.ToString(Convert.ToInt32(veloc_total));
                }
            }
        }

        // Aba Parada de maquina
        private TimeSpan Calculo_hora(DateTime hora_inicio, DateTime hora_fim)
        {
            TimeSpan resultado;

            TimeSpan horaIni = new TimeSpan(hora_inicio.Hour, hora_inicio.Minute, 0);
            TimeSpan horaFim = new TimeSpan(hora_fim.Hour, hora_fim.Minute, 0);
            resultado = horaFim.Subtract(horaIni);

            if (horaFim < horaIni)
            {
                return TimeSpan.FromHours(0);
            }
            else
            {
                return resultado;
            }

        }
        private TimeSpan Soma_hora()
        {
            TimeSpan resultado = TimeSpan.Zero;

            //DateTime h01, h02, h03, h04, h05, h06, h07, h08;
            //TimeSpan rh01, rh02, rh03, rh04, rh05, rh06, rh07, rh08;


            try
            {
                if (abaParada_label_hr_total01.Text != "0")
                {
                    DateTime h01 = Convert.ToDateTime(abaParada_label_hr_total01.Text);
                    TimeSpan rh01 = new TimeSpan(h01.Hour, h01.Minute, 0);
                    resultado = rh01;
                }

                if (abaParada_label_hr_total02.Text != "0")
                {
                    DateTime h02 = Convert.ToDateTime(abaParada_label_hr_total02.Text);
                    TimeSpan rh02 = new TimeSpan(h02.Hour, h02.Minute, 0);
                    resultado += rh02;
                }

                if (abaParada_label_hr_total03.Text != "0")
                {
                    DateTime h03 = Convert.ToDateTime(abaParada_label_hr_total03.Text);
                    TimeSpan rh03 = new TimeSpan(h03.Hour, h03.Minute, 0);
                    resultado += rh03;
                }

                if (abaParada_label_hr_total04.Text != "0")
                {
                    DateTime h04 = Convert.ToDateTime(abaParada_label_hr_total04.Text);
                    TimeSpan rh04 = new TimeSpan(h04.Hour, h04.Minute, 0);
                    resultado += rh04;
                }

                if (abaParada_label_hr_total05.Text != "0")
                {
                    DateTime h05 = Convert.ToDateTime(abaParada_label_hr_total05.Text);
                    TimeSpan rh05 = new TimeSpan(h05.Hour, h05.Minute, 0);
                    resultado += rh05;
                }

                if (abaParada_label_hr_total06.Text != "0")
                {
                    DateTime h06 = Convert.ToDateTime(abaParada_label_hr_total06.Text);
                    TimeSpan rh06 = new TimeSpan(h06.Hour, h06.Minute, 0);
                    resultado += rh06;
                }

                if (abaParada_label_hr_total07.Text != "0")
                {
                    DateTime h07 = Convert.ToDateTime(abaParada_label_hr_total07.Text);
                    TimeSpan rh07 = new TimeSpan(h07.Hour, h07.Minute, 0);
                    resultado += rh07;
                }

                if (abaParada_label_hr_total08.Text != "0")
                {
                    DateTime h08 = Convert.ToDateTime(abaParada_label_hr_total08.Text);
                    TimeSpan rh08 = new TimeSpan(h08.Hour, h08.Minute, 0);
                    resultado += rh08;
                }

            }
            catch (Exception)
            {

            }
            return resultado;
        }


        //------------------------------------------------------------------------------------------

        #region Metodos Janela Apontamento
        private void Limpar_campos()
        {
            combo_ordem_prod.Text = string.Empty;
            combo_cod_item.Text = string.Empty;
            combo_desc_completa.Text = string.Empty;

            text_qtd_planejada.Text = "0";
            text_qtd_saldo.Text = "0";
            combo_cliente_esto.Text = string.Empty;
            combo_turnos.Text = string.Empty;
            label_descri_turno.Text = "---";

            combo_operadores.Text = string.Empty;

            text_qtd_boa.Text = "0";
            text_bobina_ini.Text = "0";
            text_bobina_fim.Text = "0";
            text_velocidade.Text = "0";
            text_contador.Text = "0";
            text_qtd_fardos.Text = "0";
            text_largura.Text = "0";

            text_local_aplicacao.Text = string.Empty;

            text_lotes.Text = string.Empty;
            richText_observacao.Text = string.Empty;

            dt_lançamento.Value = DateTime.Now;

            toolStripStatusLabel_status_apon.Text = "---";

            abaApon_label_num_transa.Text = "---------";
            abaApon_label_id_apont.Text = "---------";

            //Aba Defeitos------------------------------------------------

            label_AbaDefeitos_maq.Text = string.Empty;
            label_AbaDefeitos_ordem.Text = string.Empty;
            label_AbaDefeitos_operador.Text = string.Empty;
            label_AbaDefeitos_turno.Text = string.Empty;
            label_AbaDefeitos_data.Text = string.Empty;
            label_AbaDefeitos_localAplicacao.Text = string.Empty;
            richText_label_AbaDefeitos_obs.Text = string.Empty;


            AbaDefeito_combo_defeito01.Text = string.Empty;
            AbaDefeito_combo_defeito02.Text = string.Empty;
            AbaDefeito_combo_defeito03.Text = string.Empty;
            AbaDefeito_combo_defeito04.Text = string.Empty;
            AbaDefeito_combo_defeito05.Text = string.Empty;
            AbaDefeito_combo_defeito06.Text = string.Empty;
            AbaDefeito_combo_defeito07.Text = string.Empty;
            AbaDefeito_combo_defeito08.Text = string.Empty;
            AbaDefeito_combo_defeito09.Text = string.Empty;
            AbaDefeito_combo_defeito10.Text = string.Empty;

            AbaDefeito_text_qtd01.Text = "0";
            AbaDefeito_text_qtd02.Text = "0";
            AbaDefeito_text_qtd03.Text = "0";
            AbaDefeito_text_qtd04.Text = "0";
            AbaDefeito_text_qtd05.Text = "0";
            AbaDefeito_text_qtd06.Text = "0";
            AbaDefeito_text_qtd07.Text = "0";
            AbaDefeito_text_qtd08.Text = "0";
            AbaDefeito_text_qtd09.Text = "0";
            AbaDefeito_text_qtd10.Text = "0";

            //-------------------------------------------------------------
            //Limpar aba Paradas ------------------------------------------

            abaParadas_label_numero_op.Text = string.Empty;
            abaParadas_label_maquina.Text = string.Empty;
            abaParadas_label_turno.Text = string.Empty;
            abaParadas_label_operador.Text = string.Empty;
            abaParadas_obs.Text = string.Empty;
            abaParadas_label_data.Text = string.Empty;
            abaParada_label_hr_total.Text = "00:00:00";

            abaParada_combo_parada01.Text = string.Empty;
            abaParada_combo_parada02.Text = string.Empty;
            abaParada_combo_parada03.Text = string.Empty;
            abaParada_combo_parada04.Text = string.Empty;
            abaParada_combo_parada05.Text = string.Empty;
            abaParada_combo_parada06.Text = string.Empty;
            abaParada_combo_parada07.Text = string.Empty;
            abaParada_combo_parada07.Text = string.Empty;

            abaParada_label_hr_total01.Text = "0";
            abaParada_label_hr_total02.Text = "0";
            abaParada_label_hr_total03.Text = "0";
            abaParada_label_hr_total04.Text = "0";
            abaParada_label_hr_total05.Text = "0";
            abaParada_label_hr_total06.Text = "0";
            abaParada_label_hr_total07.Text = "0";
            abaParada_label_hr_total08.Text = "0";

            abaParada_hr_inicio01.Value = Convert.ToDateTime("01/01/2000 00:00:00");
            abaParada_hr_inicio02.Value = Convert.ToDateTime("01/01/2000 00:00:00");
            abaParada_hr_inicio03.Value = Convert.ToDateTime("01/01/2000 00:00:00");
            abaParada_hr_inicio04.Value = Convert.ToDateTime("01/01/2000 00:00:00");
            abaParada_hr_inicio05.Value = Convert.ToDateTime("01/01/2000 00:00:00");
            abaParada_hr_inicio06.Value = Convert.ToDateTime("01/01/2000 00:00:00");
            abaParada_hr_inicio07.Value = Convert.ToDateTime("01/01/2000 00:00:00");
            abaParada_hr_inicio08.Value = Convert.ToDateTime("01/01/2000 00:00:00");

            abaParada_hr_fim01.Value = Convert.ToDateTime("01/01/2000 00:00:00");
            abaParada_hr_fim02.Value = Convert.ToDateTime("01/01/2000 00:00:00");
            abaParada_hr_fim04.Value = Convert.ToDateTime("01/01/2000 00:00:00");
            abaParada_hr_fim05.Value = Convert.ToDateTime("01/01/2000 00:00:00");
            abaParada_hr_fim06.Value = Convert.ToDateTime("01/01/2000 00:00:00");
            abaParada_hr_fim07.Value = Convert.ToDateTime("01/01/2000 00:00:00");
            abaParada_hr_fim08.Value = Convert.ToDateTime("01/01/2000 00:00:00");

            //-------------------------------------------------------------
            //Limpar aba de mistura ---------------------------------------

            AbaMistura_label_op.Text = string.Empty;
            AbaMistura_label_mq.Text = string.Empty;
            AbaMistura_label_turno.Text = string.Empty;
            AbaMistura_label_operador.Text = string.Empty;
            AbaMistura_label_producao.Text = string.Empty;

            abaParadas_obs.Text = string.Empty;


            abaMistura_combo_mp01.Text = string.Empty;
            abaMistura_combo_mp02.Text = string.Empty;
            abaMistura_combo_mp03.Text = string.Empty;
            abaMistura_combo_mp04.Text = string.Empty;
            abaMistura_combo_mp05.Text = string.Empty;
            abaMistura_combo_mp06.Text = string.Empty;
            abaMistura_combo_mp07.Text = string.Empty;
            abaMistura_combo_mp08.Text = string.Empty;
            abaMistura_combo_mp09.Text = string.Empty;
            abaMistura_combo_mp10.Text = string.Empty;


            abaMistura_text_perct01.Text = string.Empty;
            abaMistura_text_perct02.Text = string.Empty;
            abaMistura_text_perct03.Text = string.Empty;
            abaMistura_text_perct04.Text = string.Empty;
            abaMistura_text_perct05.Text = string.Empty;
            abaMistura_text_perct06.Text = string.Empty;
            abaMistura_text_perct07.Text = string.Empty;
            abaMistura_text_perct08.Text = string.Empty;
            abaMistura_text_perct09.Text = string.Empty;
            abaMistura_text_perct10.Text = string.Empty;

            //-------------------------------------------------------------

            //Limpar aba de Consumo ---------------------------------------
            abaConsumo_text__cod_item.Text = String.Empty;
            abaConsumo_text_descri_item.Text = string.Empty;
            abaConsumo_text_qtd_boa.Text = string.Empty;


            //-------------------------------------------------------------



        }
        private string Gerar_num_transac(double num_docum, DateTime hr_atual)
        {
            string resultado = "";

            resultado = Convert.ToString(num_docum) + hr_atual.Hour + hr_atual.Minute + hr_atual.Second;
            return resultado;

        }
        private int Verifica_campos()
        {
            int cod_geral_erro = 0;

            cod_geral_erro = Verifica_mistura();

            if (combo_ordem_prod.Text == string.Empty)
            {
                MessageBox.Show("Verifique os campo Ordem");
                cod_geral_erro = 1;
                return cod_geral_erro;


            }
            if (combo_cod_item.Text == string.Empty)
            {
                MessageBox.Show("Verifique os campo Codigo");
                cod_geral_erro = 1;
                return cod_geral_erro;
            }
            if (combo_cliente_esto.Text == string.Empty)
            {
                MessageBox.Show("Verifique os campo Cliente");
                cod_geral_erro = 1;
                return cod_geral_erro;
            }

            if (combo_local_orig.Text == string.Empty)
            {
                MessageBox.Show("Verifique os campo Local de origem");
                cod_geral_erro = 1;
                return cod_geral_erro;
            }

            if (combo_local_desti.Text == string.Empty)
            {
                MessageBox.Show("Verifique os campo origem e destino");
                cod_geral_erro = 1;
                return cod_geral_erro;
            }

            if (combo_operadores.Text == string.Empty)
            {
                MessageBox.Show("Verifique os campo Operadores");
                cod_geral_erro = 1;
                return cod_geral_erro;
            }

            if (combo_turnos.Text == string.Empty)
            {
                MessageBox.Show("Verifique os campo Turnos");
                cod_geral_erro = 1;
                return cod_geral_erro;
            }

            return cod_geral_erro;
        }
        private void Desbloquear_controles()
        {
            this.text_operacao.Text = "APON";


            this.combo_ordem_prod.Enabled = true;
            this.combo_maquinas.Enabled = true;
            this.combo_cod_item.Enabled = true;
            this.combo_desc_completa.Enabled = true;
            this.text_qtd_planejada.Enabled = true;
            // this.text_qtd_saldo.Enabled = true;
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
            this.combo_cliente_esto.Enabled = true;



        }
        private void Apontar_ordem(string tipo_movimento)
        {

            // id_estoque_trans = 
            string cod_empresa = this.combo_empresa.Text;
            string num_transac = "";
            string cod_item = this.combo_cod_item.Text;
            string cod_descri_completa = this.combo_desc_completa.Text;
            string cod_descri_reduzida = Buscar_descri_reduzida(cod_descri_completa);
            int mes_proces = DateTime.Now.Month;
            int mes_movto = DateTime.Now.Month;
            int ano_movto = DateTime.Now.Year;
            DateTime dat_proces = DateTime.Today;
            DateTime dat_movto = Convert.ToDateTime(this.dt_final_pro.Value);
            string cod_operacao = this.text_operacao.Text;
            double num_docum = Convert.ToDouble(this.combo_ordem_prod.Text);
            string ies_tip_movto = tipo_movimento; //this.label_tipo_movimento.Text;
            double qtd_movto = Convert.ToDouble(this.text_qtd_boa.Text);
            double qtd_real = qtd_movto;// * (-1);
            double fardos = Convert.ToDouble(this.text_qtd_fardos.Text);
            double num_secao_requis = 1;
            string operador = this.combo_operadores.Text;
            string secao_nome = this.combo_maquinas.Text;
            string cod_local_est_orig = this.combo_local_orig.Text;
            string cod_local_est_dest = this.combo_local_desti.Text;
            string num_lote_orig = "";
            string num_lote_dest = text_lotes.Text;
            string ies_sit_est_orig = "L";
            string ies_sit_est_dest = "L";
            string cod_turno = this.combo_turnos.Text;
            string nom_usuario = "";
            string num_prog = this.Name;
            double largura_material = Convert.ToDouble(text_largura.Text);
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

            if(richText_observacao.Text == string.Empty)
            {
                richText_observacao.Text = "--";
            }

            string observacao = richText_observacao.Text;

            int status_estorno = 0;
            string cliente_apon = this.combo_cliente_esto.Text;

            num_transac = Gerar_num_transac(num_docum, hor_operac);

            // links para banco de dados

            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                OleDbConnection conexao = new OleDbConnection(conecta_string);
                conexao.Open();

                string comando_sql;

                comando_sql = "INSERT INTO estoque_trans(cod_empresa, num_transac, cod_item, cod_descri_completa, cod_descri_reduzida, mes_proces, mes_movto, ano_movto, dat_proces, dat_movto, cod_operacao, num_docum, ies_tip_movto, qtd_real, qtd_movto, num_secao_requis, operador, secao_nome, cod_local_est_orig, cod_local_est_dest, num_lote_orig, num_lote_dest, ies_sit_est_orig, ies_sit_est_dest, cod_turno, nom_usuario, num_prog, largura_material, n_bobina_inical, n_bobina_final, velocidade, contador, fardos, peso_medio_bobina, peso_total_fardo, hora_inical, hora_final, data_operac, hor_operac, Tipo_material, observacao, status_estorno, cliente_apon) " +
                    "VALUES('" + cod_empresa + "','" + num_transac + "','" + cod_item + "','" + cod_descri_completa + "','" + cod_descri_reduzida + "','" + mes_proces + "','" + mes_movto + "','" + ano_movto + "','" + dat_proces + "','" + dat_movto + "','" + cod_operacao + "','" + num_docum + "','" + ies_tip_movto + "','" + qtd_real + "','" + qtd_movto + "','" + num_secao_requis + "','" + operador + "','" + secao_nome + "','" + cod_local_est_orig + "','" + cod_local_est_dest + "','" + num_lote_orig + "','" + num_lote_dest + "','" + ies_sit_est_orig + "','" + ies_sit_est_dest + "','" + cod_turno + "','" + nom_usuario + "','" + num_prog + "','" + largura_material + "','" + n_bobina_inical + "','" + n_bobina_final + "','" + velocidade + "','" + contador_fardos + "','" + fardos + "','" + peso_medio_bobina + "','" + peso_total_fardo + "','" + hora_inical + "','" + hora_final + "','" + data_operac + "','" + hor_operac + "','" + Tipo_material + "','" + observacao + "','" + status_estorno + "','" + cliente_apon + "')";

                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();

                Consumo_estrutura(cod_descri_completa, qtd_movto);

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

            Salvar_paradas_mq(num_transac);
            Salvar_defeitos_mq(num_transac);
            Salvar_mistura(num_transac);

        }
        private void Consumo_estrutura(string descri_item, double qtd_apont)
        {

            string cod_empresa = this.combo_empresa.Text;
            double num_transac = 0;
            string cod_item = "";//this.combo_cod_item.Text;
            //string cod_descri_completa = this.combo_desc_completa.Text;
            string cod_descri_reduzida = "";
            int mes_proces = DateTime.Now.Month;
            int mes_movto = DateTime.Now.Month;
            int ano_movto = DateTime.Now.Year;
            DateTime dat_proces = DateTime.Today;
            DateTime dat_movto = Convert.ToDateTime(this.dt_final_pro.Value);
            string cod_operacao = Buscar_operacao("AP01", "Saida"); //this.text_operacao.Text;
            double num_docum = Convert.ToDouble(this.combo_ordem_prod.Text);
            string ies_tip_movto = this.label_tipo_movimento.Text;
            double qtd_movto = 0; // Convert.ToDouble(this.text_qtd_boa.Text);
            double qtd_real = qtd_movto * (-1);
            double fardos = Convert.ToDouble(this.text_qtd_fardos.Text);
            double num_secao_requis = 1;

            string operador = this.combo_operadores.Text;
            string secao_nome = "";
            string cod_local_est_orig = this.combo_local_orig.Text;
            string cod_local_est_dest = this.combo_local_desti.Text;
            string num_lote_orig = "";
            string num_lote_dest = "";// text_lotes.Text;
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
            string Tipo_material = ""; // this.label_tipo_material.Text;
            string observacao = "";//this.richText_observacao.Text;

            try
            {
                string comando_sql02;
                string item_filho = "";
                //double qtd_item_filho = 0;

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
                        cod_item = myreader["cod_item_compon"].ToString();
                        item_filho = myreader["descri_filho"].ToString();
                        qtd_movto = Convert.ToDouble(myreader["qtd_necessaria"]) * qtd_apont;
                        qtd_real = qtd_movto * (-1);

                        comando_sql02 = "INSERT INTO estoque_trans(cod_empresa, num_transac, cod_item, cod_descri_completa, cod_descri_reduzida, mes_proces, mes_movto, ano_movto, dat_proces, dat_movto, cod_operacao, num_docum, ies_tip_movto, qtd_real, qtd_movto, num_secao_requis, operador, secao_nome, cod_local_est_orig, cod_local_est_dest, num_lote_orig, num_lote_dest, ies_sit_est_orig, ies_sit_est_dest, cod_turno, nom_usuario, num_prog, largura_material, n_bobina_inical, n_bobina_final, velocidade, contador, fardos, peso_medio_bobina, peso_total_fardo, hora_inical, hora_final, data_operac, hor_operac, Tipo_material, observacao) " +
                    "VALUES('" + cod_empresa + "','" + num_transac + "','" + cod_item + "','" + item_filho + "','" + cod_descri_reduzida + "','" + mes_proces + "','" + mes_movto + "','" + ano_movto + "','" + dat_proces + "','" + dat_movto + "','" + cod_operacao + "','" + num_docum + "','" + ies_tip_movto + "','" + qtd_real + "','" + qtd_movto + "','" + num_secao_requis + "','" + operador + "','" + secao_nome + "','" + cod_local_est_orig + "','" + cod_local_est_dest + "','" + num_lote_orig + "','" + num_lote_dest + "','" + ies_sit_est_orig + "','" + ies_sit_est_dest + "','" + cod_turno + "','" + nom_usuario + "','" + num_prog + "','" + largura_material + "','" + n_bobina_inical + "','" + n_bobina_final + "','" + velocidade + "','" + contador_fardos + "','" + fardos + "','" + peso_medio_bobina + "','" + peso_total_fardo + "','" + hora_inical + "','" + hora_final + "','" + data_operac + "','" + hor_operac + "','" + Tipo_material + "','" + observacao + "')";

                        OleDbCommand cmd02 = new OleDbCommand(comando_sql02, conexao);
                        cmd02.ExecuteNonQuery();
                    }
                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }


        private void Estornar_apontamento_delete(string id_apontamento)
        {
            // Estornando e deletando
            
            string num_transac = this.abaApon_label_num_transa.Text; // mudou aqui            
            string cod_descri_completa = this.combo_desc_completa.Text; 
            double qtd_movto = Convert.ToDouble(this.text_qtd_boa.Text);

            try
            {
                string comando_sql;

                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                OleDbConnection conexao = new OleDbConnection(conecta_string);
                conexao.Open();

                comando_sql = "DELETE FROM estoque_trans WHERE id_estoque_trans=" + Convert.ToInt32(id_apontamento) + "";

                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();

                Consumo_estrutura(cod_descri_completa, qtd_movto); // ve se vai se comportar do jeito certo
                Estornar_paradas(num_transac);
                Estornar_consumo_mp(num_transac);
                Estornar_defeitos_mq(num_transac);

                MessageBox.Show("Estornado Com sucesso!");

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void Estornar_apontamento(string tipo_movimento)
        {
            // id_estoque_trans = 
            string cod_empresa = this.combo_empresa.Text;
            string num_transac = this.abaApon_label_num_transa.Text; // mudou aqui
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
            string ies_tip_movto = tipo_movimento; // this.label_tipo_movimento.Text;
            double qtd_movto = Convert.ToDouble(this.text_qtd_boa.Text);
            double qtd_real = qtd_movto * (-1); // mudou aqui
            double fardos = Convert.ToDouble(this.text_qtd_fardos.Text) * (-1); // Mudou
            double num_secao_requis = 1;
            string operador = this.combo_operadores.Text;
            string secao_nome = this.combo_maquinas.Text;
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

            string cliente_apon = this.combo_cliente_esto.Text;
            
            //num_transac = Gerar_num_transac(num_docum, hor_operac);

            // links para banco de dados


            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                OleDbConnection conexao = new OleDbConnection(conecta_string);
                conexao.Open();

                string comando_sql;

                comando_sql = "INSERT INTO estoque_trans(cod_empresa, num_transac, cod_item, cod_descri_completa, cod_descri_reduzida, mes_proces, mes_movto, ano_movto, dat_proces, dat_movto, cod_operacao, num_docum, ies_tip_movto, qtd_real, qtd_movto, num_secao_requis, operador, secao_nome, cod_local_est_orig, cod_local_est_dest, num_lote_orig, num_lote_dest, ies_sit_est_orig, ies_sit_est_dest, cod_turno, nom_usuario, num_prog, largura_material, n_bobina_inical, n_bobina_final, velocidade, contador, fardos, peso_medio_bobina, peso_total_fardo, hora_inical, hora_final, data_operac, hor_operac, Tipo_material, observacao) " +
                    "VALUES('" + cod_empresa + "','" + num_transac + "','" + cod_item + "','" + cod_descri_completa + "','" + cod_descri_reduzida + "','" + mes_proces + "','" + mes_movto + "','" + ano_movto + "','" + dat_proces + "','" + dat_movto + "','" + cod_operacao + "','" + num_docum + "','" + ies_tip_movto + "','" + qtd_real + "','" + qtd_movto + "','" + num_secao_requis + "','" + operador + "','" + secao_nome + "','" + cod_local_est_orig + "','" + cod_local_est_dest + "','" + num_lote_orig + "','" + num_lote_dest + "','" + ies_sit_est_orig + "','" + ies_sit_est_dest + "','" + cod_turno + "','" + nom_usuario + "','" + num_prog + "','" + largura_material + "','" + n_bobina_inical + "','" + n_bobina_final + "','" + velocidade + "','" + contador_fardos + "','" + fardos + "','" + peso_medio_bobina + "','" + peso_total_fardo + "','" + hora_inical + "','" + hora_final + "','" + data_operac + "','" + hor_operac + "','" + Tipo_material + "','" + observacao + "','"+ cliente_apon + "')";

                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();

                Consumo_estrutura(cod_descri_completa, qtd_movto); // ve se vai se comportar do jeito certo
                Estornar_paradas(num_transac);
                Estornar_consumo_mp(num_transac);
                Estornar_defeitos_mq(num_transac);

                MessageBox.Show("Estornado Com sucesso!");

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message + "// Erro no metodo Estornar //");

            }



        }
        private void Estatus_estorno(string id_apontamento)
        {
            // identifica qual ordem de produção foi estornada

            int status_estorno = 1;

            try
            {
                string comando_sql;

                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                OleDbConnection conexao = new OleDbConnection(conecta_string);
                conexao.Open();

                comando_sql = "UPDATE estoque_trans SET status_estorno='" + status_estorno +
                        "' WHERE id_estoque_trans=" + Convert.ToInt32(id_apontamento) + "";

                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Buscar_apontamento() { }


        // Metodos de atualização de lançamento
        private void Atualizar_lancamento(string id_apontamento)
        {

            string cod_empresa = this.combo_empresa.Text;
            string num_transac = "";
            string cod_item = this.combo_cod_item.Text;
            string cod_descri_completa = this.combo_desc_completa.Text;
            //string cod_descri_reduzida = "";
            int mes_proces = DateTime.Now.Month;
            int mes_movto = DateTime.Now.Month;
            int ano_movto = DateTime.Now.Year;
            DateTime dat_proces = DateTime.Today;
            DateTime dat_movto = Convert.ToDateTime(this.dt_final_pro.Value);
            string cod_operacao = this.text_operacao.Text;
            double num_docum = Convert.ToDouble(this.combo_ordem_prod.Text);
            string ies_tip_movto = this.label_tipo_movimento.Text;
            double qtd_movto = Convert.ToDouble(this.text_qtd_boa.Text);
            double qtd_real = qtd_movto;// * (-1);
            double fardos = Convert.ToDouble(this.text_qtd_fardos.Text);
            double num_secao_requis = 1;
            string operador = this.combo_operadores.Text;
            string secao_nome = this.combo_maquinas.Text;
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

            num_transac = abaApon_label_num_transa.Text;

            try
            {
                string comando_sql;

                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                OleDbConnection conexao = new OleDbConnection(conecta_string);
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

                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Atualizar_parada_mq(string num_tran)
        {

            if (abaParada_label_hr_total.Text != "00:00:00")
            {
                if (abaParada_label_hr_total01.Text != "0")
                {

                    //id_parada
                    double ordem_prod = Convert.ToDouble(abaParadas_label_numero_op.Text);
                    string maquina = abaParadas_label_maquina.Text;
                    string turno = abaParadas_label_turno.Text;
                    string operador = abaParadas_label_operador.Text;
                    string codigo_parada = "";
                    string descricao_parada = abaParada_combo_parada01.Text;
                    DateTime hora_inicio = abaParada_hr_inicio01.Value;
                    DateTime hora_final = abaParada_hr_fim01.Value;
                    DateTime total_horas = Convert.ToDateTime(abaParada_label_hr_total01.Text);
                    double total_minutos = Convert.ToDateTime(abaParada_label_hr_total01.Text).Hour + Convert.ToDateTime(abaParada_label_hr_total01.Text).Minute;
                    string observacao = abaParadas_obs.Text;
                    string num_transac = num_tran;

                    string campo_marcador = abaParada_combo_parada01.Name;
                    codigo_parada = busca_cod_parada_db(descricao_parada);

                    try
                    {
                        string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                        OleDbConnection conexao = new OleDbConnection(conecta_string);
                        conexao.Open();

                        string comando_sql;

                        comando_sql = "UPDATE db_paradas_mq SET " +
                        "ordem_prod='" + ordem_prod +
                        "', maquina='" + maquina +
                        "', turno='" + turno +
                        "', operador='" + operador +
                        "', codigo_parada='" + codigo_parada +
                        "', descricao_parada='" + descricao_parada +
                        "', hora_inicio='" + hora_inicio +
                        "', hora_final='" + hora_final +
                        "', total_horas='" + total_horas +
                        "', total_minutos='" + total_minutos +
                        "', observacao='" + observacao +
                        "', num_transac='" + num_transac +
                        "', campo_marcador='" + campo_marcador +
                        "' WHERE num_transac=" + Convert.ToInt32(num_tran) + "";

                        OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                        cmd.ExecuteNonQuery();
                        conexao.Close();
                    }
                    catch (Exception erro)
                    {

                        MessageBox.Show(erro.Message);
                        cod_geral_erro = 1;
                    }
                }
                if (abaParada_label_hr_total02.Text != "0")
                {

                    //id_parada
                    double ordem_prod = Convert.ToDouble(abaParadas_label_numero_op.Text);
                    string maquina = abaParadas_label_maquina.Text;
                    string turno = abaParadas_label_turno.Text;
                    string operador = abaParadas_label_operador.Text;
                    string codigo_parada = "";
                    string descricao_parada = abaParada_combo_parada02.Text;
                    DateTime hora_inicio = abaParada_hr_inicio02.Value;
                    DateTime hora_final = abaParada_hr_fim02.Value;
                    DateTime total_horas = Convert.ToDateTime(abaParada_label_hr_total02.Text);
                    double total_minutos = Convert.ToDateTime(abaParada_label_hr_total02.Text).Hour + Convert.ToDateTime(abaParada_label_hr_total02.Text).Minute;
                    string observacao = abaParadas_obs.Text;
                    string num_transac = num_tran;

                    string campo_marcador = abaParada_combo_parada02.Name;
                    codigo_parada = busca_cod_parada_db(descricao_parada);

                    try
                    {
                        string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                        OleDbConnection conexao = new OleDbConnection(conecta_string);
                        conexao.Open();

                        string comando_sql;

                        comando_sql = "UPDATE db_paradas_mq SET " +
                        "ordem_prod='" + ordem_prod +
                        "', maquina='" + maquina +
                        "', turno='" + turno +
                        "', operador='" + operador +
                        "', codigo_parada='" + codigo_parada +
                        "', descricao_parada='" + descricao_parada +
                        "', hora_inicio='" + hora_inicio +
                        "', hora_final='" + hora_final +
                        "', total_horas='" + total_horas +
                        "', total_minutos='" + total_minutos +
                        "', observacao='" + observacao +
                        "', num_transac='" + num_transac +
                        "', campo_marcador='" + campo_marcador +
                        "' WHERE num_transac=" + Convert.ToInt32(num_tran) + "";

                        OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                        cmd.ExecuteNonQuery();
                        conexao.Close();
                    }
                    catch (Exception erro)
                    {

                        MessageBox.Show(erro.Message);
                        cod_geral_erro = 1;
                    }
                }
                if (abaParada_label_hr_total03.Text != "0")
                {

                    //id_parada
                    double ordem_prod = Convert.ToDouble(abaParadas_label_numero_op.Text);
                    string maquina = abaParadas_label_maquina.Text;
                    string turno = abaParadas_label_turno.Text;
                    string operador = abaParadas_label_operador.Text;
                    string codigo_parada = "";
                    string descricao_parada = abaParada_combo_parada03.Text;
                    DateTime hora_inicio = abaParada_hr_inicio03.Value;
                    DateTime hora_final = abaParada_hr_fim03.Value;
                    DateTime total_horas = Convert.ToDateTime(abaParada_label_hr_total03.Text);
                    double total_minutos = Convert.ToDateTime(abaParada_label_hr_total03.Text).Hour + Convert.ToDateTime(abaParada_label_hr_total03.Text).Minute;
                    string observacao = abaParadas_obs.Text;
                    string num_transac = num_tran;

                    string campo_marcador = abaParada_combo_parada03.Name;
                    codigo_parada = busca_cod_parada_db(descricao_parada);

                    try
                    {
                        string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                        OleDbConnection conexao = new OleDbConnection(conecta_string);
                        conexao.Open();

                        string comando_sql;

                        comando_sql = "UPDATE db_paradas_mq SET " +
                        "ordem_prod='" + ordem_prod +
                        "', maquina='" + maquina +
                        "', turno='" + turno +
                        "', operador='" + operador +
                        "', codigo_parada='" + codigo_parada +
                        "', descricao_parada='" + descricao_parada +
                        "', hora_inicio='" + hora_inicio +
                        "', hora_final='" + hora_final +
                        "', total_horas='" + total_horas +
                        "', total_minutos='" + total_minutos +
                        "', observacao='" + observacao +
                        "', num_transac='" + num_transac +
                        "', campo_marcador='" + campo_marcador +
                        "' WHERE num_transac=" + Convert.ToInt32(num_tran) + "";

                        OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                        cmd.ExecuteNonQuery();
                        conexao.Close();
                    }
                    catch (Exception erro)
                    {

                        MessageBox.Show(erro.Message);
                        cod_geral_erro = 1;
                    }
                }
                if (abaParada_label_hr_total04.Text != "0")
                {

                    //id_parada
                    double ordem_prod = Convert.ToDouble(abaParadas_label_numero_op.Text);
                    string maquina = abaParadas_label_maquina.Text;
                    string turno = abaParadas_label_turno.Text;
                    string operador = abaParadas_label_operador.Text;
                    string codigo_parada = "";
                    string descricao_parada = abaParada_combo_parada04.Text;
                    DateTime hora_inicio = abaParada_hr_inicio04.Value;
                    DateTime hora_final = abaParada_hr_fim04.Value;
                    DateTime total_horas = Convert.ToDateTime(abaParada_label_hr_total04.Text);
                    double total_minutos = Convert.ToDateTime(abaParada_label_hr_total04.Text).Hour + Convert.ToDateTime(abaParada_label_hr_total04.Text).Minute;
                    string observacao = abaParadas_obs.Text;
                    string num_transac = num_tran;

                    string campo_marcador = abaParada_combo_parada04.Name;
                    codigo_parada = busca_cod_parada_db(descricao_parada);

                    try
                    {
                        string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                        OleDbConnection conexao = new OleDbConnection(conecta_string);
                        conexao.Open();

                        string comando_sql;

                        comando_sql = "UPDATE db_paradas_mq SET " +
                        "ordem_prod='" + ordem_prod +
                        "', maquina='" + maquina +
                        "', turno='" + turno +
                        "', operador='" + operador +
                        "', codigo_parada='" + codigo_parada +
                        "', descricao_parada='" + descricao_parada +
                        "', hora_inicio='" + hora_inicio +
                        "', hora_final='" + hora_final +
                        "', total_horas='" + total_horas +
                        "', total_minutos='" + total_minutos +
                        "', observacao='" + observacao +
                        "', num_transac='" + num_transac +
                        "', campo_marcador='" + campo_marcador +
                        "' WHERE num_transac=" + Convert.ToInt32(num_tran) + "";

                        OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                        cmd.ExecuteNonQuery();
                        conexao.Close();
                    }
                    catch (Exception erro)
                    {

                        MessageBox.Show(erro.Message);
                        cod_geral_erro = 1;
                    }
                }
                if (abaParada_label_hr_total05.Text != "0")
                {

                    //id_parada
                    double ordem_prod = Convert.ToDouble(abaParadas_label_numero_op.Text);
                    string maquina = abaParadas_label_maquina.Text;
                    string turno = abaParadas_label_turno.Text;
                    string operador = abaParadas_label_operador.Text;
                    string codigo_parada = "";
                    string descricao_parada = abaParada_combo_parada05.Text;
                    DateTime hora_inicio = abaParada_hr_inicio05.Value;
                    DateTime hora_final = abaParada_hr_fim05.Value;
                    DateTime total_horas = Convert.ToDateTime(abaParada_label_hr_total05.Text);
                    double total_minutos = Convert.ToDateTime(abaParada_label_hr_total05.Text).Hour + Convert.ToDateTime(abaParada_label_hr_total05.Text).Minute;
                    string observacao = abaParadas_obs.Text;
                    string num_transac = num_tran;

                    string campo_marcador = abaParada_combo_parada05.Name;
                    codigo_parada = busca_cod_parada_db(descricao_parada);

                    try
                    {
                        string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                        OleDbConnection conexao = new OleDbConnection(conecta_string);
                        conexao.Open();

                        string comando_sql;

                        comando_sql = "UPDATE db_paradas_mq SET " +
                        "ordem_prod='" + ordem_prod +
                        "', maquina='" + maquina +
                        "', turno='" + turno +
                        "', operador='" + operador +
                        "', codigo_parada='" + codigo_parada +
                        "', descricao_parada='" + descricao_parada +
                        "', hora_inicio='" + hora_inicio +
                        "', hora_final='" + hora_final +
                        "', total_horas='" + total_horas +
                        "', total_minutos='" + total_minutos +
                        "', observacao='" + observacao +
                        "', num_transac='" + num_transac +
                        "', campo_marcador='" + campo_marcador +
                        "' WHERE num_transac=" + Convert.ToInt32(num_tran) + "";

                        OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                        cmd.ExecuteNonQuery();
                        conexao.Close();
                    }
                    catch (Exception erro)
                    {

                        MessageBox.Show(erro.Message);
                        cod_geral_erro = 1;
                    }
                }
                if (abaParada_label_hr_total06.Text != "0")
                {

                    //id_parada
                    double ordem_prod = Convert.ToDouble(abaParadas_label_numero_op.Text);
                    string maquina = abaParadas_label_maquina.Text;
                    string turno = abaParadas_label_turno.Text;
                    string operador = abaParadas_label_operador.Text;
                    string codigo_parada = "";
                    string descricao_parada = abaParada_combo_parada06.Text;
                    DateTime hora_inicio = abaParada_hr_inicio06.Value;
                    DateTime hora_final = abaParada_hr_fim06.Value;
                    DateTime total_horas = Convert.ToDateTime(abaParada_label_hr_total06.Text);
                    double total_minutos = Convert.ToDateTime(abaParada_label_hr_total06.Text).Hour + Convert.ToDateTime(abaParada_label_hr_total06.Text).Minute;
                    string observacao = abaParadas_obs.Text;
                    string num_transac = num_tran;

                    string campo_marcador = abaParada_combo_parada06.Name;
                    codigo_parada = busca_cod_parada_db(descricao_parada);

                    try
                    {
                        string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                        OleDbConnection conexao = new OleDbConnection(conecta_string);
                        conexao.Open();

                        string comando_sql;

                        comando_sql = "UPDATE db_paradas_mq SET " +
                        "ordem_prod='" + ordem_prod +
                        "', maquina='" + maquina +
                        "', turno='" + turno +
                        "', operador='" + operador +
                        "', codigo_parada='" + codigo_parada +
                        "', descricao_parada='" + descricao_parada +
                        "', hora_inicio='" + hora_inicio +
                        "', hora_final='" + hora_final +
                        "', total_horas='" + total_horas +
                        "', total_minutos='" + total_minutos +
                        "', observacao='" + observacao +
                        "', num_transac='" + num_transac +
                        "', campo_marcador='" + campo_marcador +
                        "' WHERE num_transac=" + Convert.ToInt32(num_tran) + "";

                        OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                        cmd.ExecuteNonQuery();
                        conexao.Close();
                    }
                    catch (Exception erro)
                    {

                        MessageBox.Show(erro.Message);
                        cod_geral_erro = 1;
                    }
                }
                if (abaParada_label_hr_total07.Text != "0")
                {

                    //id_parada
                    double ordem_prod = Convert.ToDouble(abaParadas_label_numero_op.Text);
                    string maquina = abaParadas_label_maquina.Text;
                    string turno = abaParadas_label_turno.Text;
                    string operador = abaParadas_label_operador.Text;
                    string codigo_parada = "";
                    string descricao_parada = abaParada_combo_parada07.Text;
                    DateTime hora_inicio = abaParada_hr_inicio07.Value;
                    DateTime hora_final = abaParada_hr_fim07.Value;
                    DateTime total_horas = Convert.ToDateTime(abaParada_label_hr_total07.Text);
                    double total_minutos = Convert.ToDateTime(abaParada_label_hr_total07.Text).Hour + Convert.ToDateTime(abaParada_label_hr_total07.Text).Minute;
                    string observacao = abaParadas_obs.Text;
                    string num_transac = num_tran;

                    string campo_marcador = abaParada_combo_parada07.Name;
                    codigo_parada = busca_cod_parada_db(descricao_parada);

                    try
                    {
                        string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                        OleDbConnection conexao = new OleDbConnection(conecta_string);
                        conexao.Open();

                        string comando_sql;

                        comando_sql = "UPDATE db_paradas_mq SET " +
                        "ordem_prod='" + ordem_prod +
                        "', maquina='" + maquina +
                        "', turno='" + turno +
                        "', operador='" + operador +
                        "', codigo_parada='" + codigo_parada +
                        "', descricao_parada='" + descricao_parada +
                        "', hora_inicio='" + hora_inicio +
                        "', hora_final='" + hora_final +
                        "', total_horas='" + total_horas +
                        "', total_minutos='" + total_minutos +
                        "', observacao='" + observacao +
                        "', num_transac='" + num_transac +
                        "', campo_marcador='" + campo_marcador +
                        "' WHERE num_transac=" + Convert.ToInt32(num_tran) + "";

                        OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                        cmd.ExecuteNonQuery();
                        conexao.Close();
                    }
                    catch (Exception erro)
                    {

                        MessageBox.Show(erro.Message);
                        cod_geral_erro = 1;
                    }
                }
                if (abaParada_label_hr_total08.Text != "0")
                {

                    //id_parada
                    double ordem_prod = Convert.ToDouble(abaParadas_label_numero_op.Text);
                    string maquina = abaParadas_label_maquina.Text;
                    string turno = abaParadas_label_turno.Text;
                    string operador = abaParadas_label_operador.Text;
                    string codigo_parada = "";
                    string descricao_parada = abaParada_combo_parada08.Text;
                    DateTime hora_inicio = abaParada_hr_inicio08.Value;
                    DateTime hora_final = abaParada_hr_fim08.Value;
                    DateTime total_horas = Convert.ToDateTime(abaParada_label_hr_total08.Text);
                    double total_minutos = Convert.ToDateTime(abaParada_label_hr_total08.Text).Hour + Convert.ToDateTime(abaParada_label_hr_total08.Text).Minute;
                    string observacao = abaParadas_obs.Text;
                    string num_transac = num_tran;

                    string campo_marcador = abaParada_combo_parada08.Name;
                    codigo_parada = busca_cod_parada_db(descricao_parada);

                    try
                    {
                        string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                        OleDbConnection conexao = new OleDbConnection(conecta_string);
                        conexao.Open();

                        string comando_sql;

                        comando_sql = "UPDATE db_paradas_mq SET " +
                        "ordem_prod='" + ordem_prod +
                        "', maquina='" + maquina +
                        "', turno='" + turno +
                        "', operador='" + operador +
                        "', codigo_parada='" + codigo_parada +
                        "', descricao_parada='" + descricao_parada +
                        "', hora_inicio='" + hora_inicio +
                        "', hora_final='" + hora_final +
                        "', total_horas='" + total_horas +
                        "', total_minutos='" + total_minutos +
                        "', observacao='" + observacao +
                        "', num_transac='" + num_transac +
                        "', campo_marcador='" + campo_marcador +
                        "' WHERE num_transac=" + Convert.ToInt32(num_tran) + "";

                        OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                        cmd.ExecuteNonQuery();
                        conexao.Close();
                    }
                    catch (Exception erro)
                    {

                        MessageBox.Show(erro.Message);
                        cod_geral_erro = 1;
                    }
                }
            }


        }
        private void Atualizar_consumo_estrutura()
        {
            string cod_descri_completa = this.combo_desc_completa.Text;
            double qtd_movto = Convert.ToDouble(this.text_qtd_boa.Text);

            Consumo_estrutura(cod_descri_completa, qtd_movto);



        }
        private void Atualizar_mistura()
        {

        }   


        #endregion


        //------------------------------------------------------------------------------------------
        #region Metodos da janela defeitos 

        private void Salvar_defeitos_mq(string num_tran)
        {

            if (AbaDefeito_text_qtd01.Text != "0")
            {

                //id_parada
                double ordem_prod = Convert.ToDouble(label_AbaDefeitos_ordem.Text);
                string maquina = label_AbaDefeitos_maq.Text;
                string turno = label_AbaDefeitos_turno.Text;
                string operador = label_AbaDefeitos_operador.Text;
                string codigo_defeitos;
                string descricao_defeitos = AbaDefeito_combo_defeito01.Text;
                double qtd_defeitos = Convert.ToDouble(AbaDefeito_text_qtd01.Text, cultures);
                string observacao = richText_label_AbaDefeitos_obs.Text;
                string num_transac = num_tran;
                string campo_marcador = AbaDefeito_combo_defeito01.Name;
                codigo_defeitos = busca_cod_defeitos_db(descricao_defeitos);
                DateTime data_lanc = Convert.ToDateTime(label_AbaDefeitos_data.Text);

                double mes_lanc = data_lanc.Month;
                double ano_lanc = data_lanc.Year;

                try
                {
                    string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    string comando_sql;

                    comando_sql = "INSERT INTO db_defeitos_mq(data_lanc, ordem_prod, maquina, turno, operador, codigo_defeitos, descricao_defeitos, qtd_defeitos, observacao, num_transac, campo_marcador, mes_lanc, ano_lanc) " +
                        "VALUES('" + data_lanc + "','" + ordem_prod + "','" + maquina + "','" + turno + "','" + operador + "','" + codigo_defeitos + "','" + descricao_defeitos + "','" + qtd_defeitos + "','" + observacao + "','" + num_transac + "','" + campo_marcador + "','" + mes_lanc + "','" + ano_lanc + "')";

                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.Message);
                    cod_geral_erro = 1;
                }


            }
            if (AbaDefeito_text_qtd02.Text != "0")
            {

                //id_parada
                double ordem_prod = Convert.ToDouble(label_AbaDefeitos_ordem.Text);
                string maquina = label_AbaDefeitos_maq.Text;
                string turno = label_AbaDefeitos_turno.Text;
                string operador = label_AbaDefeitos_operador.Text;
                string codigo_defeitos;
                string descricao_defeitos = AbaDefeito_combo_defeito02.Text;
                double qtd_defeitos = Convert.ToDouble(AbaDefeito_text_qtd02.Text, cultures);
                string observacao = richText_label_AbaDefeitos_obs.Text;
                string num_transac = num_tran;
                string campo_marcador = AbaDefeito_combo_defeito02.Name;
                codigo_defeitos = busca_cod_defeitos_db(descricao_defeitos);
                DateTime data_lanc = Convert.ToDateTime(label_AbaDefeitos_data.Text);

                double mes_lanc = data_lanc.Month;
                double ano_lanc = data_lanc.Year;

                try
                {
                    string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    string comando_sql;

                    comando_sql = "INSERT INTO db_defeitos_mq(data_lanc, ordem_prod, maquina, turno, operador, codigo_defeitos, descricao_defeitos, qtd_defeitos, observacao, num_transac, campo_marcador, mes_lanc, ano_lanc) " +
                        "VALUES('" + data_lanc + "','" + ordem_prod + "','" + maquina + "','" + turno + "','" + operador + "','" + codigo_defeitos + "','" + descricao_defeitos + "','" + qtd_defeitos + "','" + observacao + "','" + num_transac + "','" + campo_marcador + "','" + mes_lanc + "','" + ano_lanc + "')";

                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.Message);
                    cod_geral_erro = 1;
                }


            }
            if (AbaDefeito_text_qtd03.Text != "0")
            {

                //id_parada
                double ordem_prod = Convert.ToDouble(label_AbaDefeitos_ordem.Text);
                string maquina = label_AbaDefeitos_maq.Text;
                string turno = label_AbaDefeitos_turno.Text;
                string operador = label_AbaDefeitos_operador.Text;
                string codigo_defeitos;
                string descricao_defeitos = AbaDefeito_combo_defeito01.Text;
                double qtd_defeitos = Convert.ToDouble(AbaDefeito_text_qtd03.Text, cultures);
                string observacao = richText_label_AbaDefeitos_obs.Text;
                string num_transac = num_tran;
                string campo_marcador = AbaDefeito_combo_defeito03.Name;
                codigo_defeitos = busca_cod_defeitos_db(descricao_defeitos);
                DateTime data_lanc = Convert.ToDateTime(label_AbaDefeitos_data.Text);


                double mes_lanc = data_lanc.Month;
                double ano_lanc = data_lanc.Year;

                try
                {
                    string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    string comando_sql;

                    comando_sql = "INSERT INTO db_defeitos_mq(data_lanc, ordem_prod, maquina, turno, operador, codigo_defeitos, descricao_defeitos, qtd_defeitos, observacao, num_transac, campo_marcador, mes_lanc, ano_lanc) " +
                        "VALUES('" + data_lanc + "','" + ordem_prod + "','" + maquina + "','" + turno + "','" + operador + "','" + codigo_defeitos + "','" + descricao_defeitos + "','" + qtd_defeitos + "','" + observacao + "','" + num_transac + "','" + campo_marcador + "','" + mes_lanc + "','" + ano_lanc + "')";

                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.Message);
                    cod_geral_erro = 1;
                }

            }
            if (AbaDefeito_text_qtd04.Text != "0")
            {

                //id_parada
                double ordem_prod = Convert.ToDouble(label_AbaDefeitos_ordem.Text);
                string maquina = label_AbaDefeitos_maq.Text;
                string turno = label_AbaDefeitos_turno.Text;
                string operador = label_AbaDefeitos_operador.Text;
                string codigo_defeitos;
                string descricao_defeitos = AbaDefeito_combo_defeito04.Text;
                double qtd_defeitos = Convert.ToDouble(AbaDefeito_text_qtd04.Text, cultures);
                string observacao = richText_label_AbaDefeitos_obs.Text;
                string num_transac = num_tran;
                string campo_marcador = AbaDefeito_combo_defeito04.Name;
                codigo_defeitos = busca_cod_defeitos_db(descricao_defeitos);
                DateTime data_lanc = Convert.ToDateTime(label_AbaDefeitos_data.Text);


                double mes_lanc = data_lanc.Month;
                double ano_lanc = data_lanc.Year;

                try
                {
                    string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    string comando_sql;

                    comando_sql = "INSERT INTO db_defeitos_mq(data_lanc, ordem_prod, maquina, turno, operador, codigo_defeitos, descricao_defeitos, qtd_defeitos, observacao, num_transac, campo_marcador, mes_lanc, ano_lanc) " +
                        "VALUES('" + data_lanc + "','" + ordem_prod + "','" + maquina + "','" + turno + "','" + operador + "','" + codigo_defeitos + "','" + descricao_defeitos + "','" + qtd_defeitos + "','" + observacao + "','" + num_transac + "','" + campo_marcador + "','" + mes_lanc + "','" + ano_lanc + "')";

                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.Message);
                    cod_geral_erro = 1;
                }
            }
            if (AbaDefeito_text_qtd05.Text != "0")
            {

                //id_parada
                double ordem_prod = Convert.ToDouble(label_AbaDefeitos_ordem.Text);
                string maquina = label_AbaDefeitos_maq.Text;
                string turno = label_AbaDefeitos_turno.Text;
                string operador = label_AbaDefeitos_operador.Text;
                string codigo_defeitos;
                string descricao_defeitos = AbaDefeito_combo_defeito05.Text;
                double qtd_defeitos = Convert.ToDouble(AbaDefeito_text_qtd05.Text, cultures);
                string observacao = richText_label_AbaDefeitos_obs.Text;
                string num_transac = num_tran;
                string campo_marcador = AbaDefeito_combo_defeito05.Name;
                codigo_defeitos = busca_cod_defeitos_db(descricao_defeitos);
                DateTime data_lanc = Convert.ToDateTime(label_AbaDefeitos_data.Text);


                double mes_lanc = data_lanc.Month;
                double ano_lanc = data_lanc.Year;

                try
                {
                    string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    string comando_sql;

                    comando_sql = "INSERT INTO db_defeitos_mq(data_lanc, ordem_prod, maquina, turno, operador, codigo_defeitos, descricao_defeitos, qtd_defeitos, observacao, num_transac, campo_marcador, mes_lanc, ano_lanc) " +
                        "VALUES('" + data_lanc + "','" + ordem_prod + "','" + maquina + "','" + turno + "','" + operador + "','" + codigo_defeitos + "','" + descricao_defeitos + "','" + qtd_defeitos + "','" + observacao + "','" + num_transac + "','" + campo_marcador + "','" + mes_lanc + "','" + ano_lanc + "')";

                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.Message);
                    cod_geral_erro = 1;
                }
            }
            if (AbaDefeito_text_qtd06.Text != "0")
            {

                //id_parada
                double ordem_prod = Convert.ToDouble(label_AbaDefeitos_ordem.Text);
                string maquina = label_AbaDefeitos_maq.Text;
                string turno = label_AbaDefeitos_turno.Text;
                string operador = label_AbaDefeitos_operador.Text;
                string codigo_defeitos;
                string descricao_defeitos = AbaDefeito_combo_defeito06.Text;
                double qtd_defeitos = Convert.ToDouble(AbaDefeito_text_qtd06.Text, cultures);
                string observacao = richText_label_AbaDefeitos_obs.Text;
                string num_transac = num_tran;
                string campo_marcador = AbaDefeito_combo_defeito06.Name;
                codigo_defeitos = busca_cod_defeitos_db(descricao_defeitos);
                DateTime data_lanc = Convert.ToDateTime(label_AbaDefeitos_data.Text);


                double mes_lanc = data_lanc.Month;
                double ano_lanc = data_lanc.Year;

                try
                {
                    string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    string comando_sql;

                    comando_sql = "INSERT INTO db_defeitos_mq(data_lanc, ordem_prod, maquina, turno, operador, codigo_defeitos, descricao_defeitos, qtd_defeitos, observacao, num_transac, campo_marcador, mes_lanc, ano_lanc) " +
                        "VALUES('" + data_lanc + "','" + ordem_prod + "','" + maquina + "','" + turno + "','" + operador + "','" + codigo_defeitos + "','" + descricao_defeitos + "','" + qtd_defeitos + "','" + observacao + "','" + num_transac + "','" + campo_marcador + "','" + mes_lanc + "','" + ano_lanc + "')";

                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.Message);
                    cod_geral_erro = 1;
                }
            }
            if (AbaDefeito_text_qtd07.Text != "0")
            {

                //id_parada
                double ordem_prod = Convert.ToDouble(label_AbaDefeitos_ordem.Text);
                string maquina = label_AbaDefeitos_maq.Text;
                string turno = label_AbaDefeitos_turno.Text;
                string operador = label_AbaDefeitos_operador.Text;
                string codigo_defeitos;
                string descricao_defeitos = AbaDefeito_combo_defeito07.Text;
                double qtd_defeitos = Convert.ToDouble(AbaDefeito_text_qtd07.Text, cultures);
                string observacao = richText_label_AbaDefeitos_obs.Text;
                string num_transac = num_tran;
                string campo_marcador = AbaDefeito_combo_defeito07.Name;
                codigo_defeitos = busca_cod_defeitos_db(descricao_defeitos);
                DateTime data_lanc = Convert.ToDateTime(label_AbaDefeitos_data.Text);


                double mes_lanc = data_lanc.Month;
                double ano_lanc = data_lanc.Year;

                try
                {
                    string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    string comando_sql;

                    comando_sql = "INSERT INTO db_defeitos_mq(data_lanc, ordem_prod, maquina, turno, operador, codigo_defeitos, descricao_defeitos, qtd_defeitos, observacao, num_transac, campo_marcador, mes_lanc, ano_lanc) " +
                        "VALUES('" + data_lanc + "','" + ordem_prod + "','" + maquina + "','" + turno + "','" + operador + "','" + codigo_defeitos + "','" + descricao_defeitos + "','" + qtd_defeitos + "','" + observacao + "','" + num_transac + "','" + campo_marcador + "','" + mes_lanc + "','" + ano_lanc + "')";

                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.Message);
                    cod_geral_erro = 1;
                }
            }
            if (AbaDefeito_text_qtd08.Text != "0")
            {

                //id_parada
                double ordem_prod = Convert.ToDouble(label_AbaDefeitos_ordem.Text);
                string maquina = label_AbaDefeitos_maq.Text;
                string turno = label_AbaDefeitos_turno.Text;
                string operador = label_AbaDefeitos_operador.Text;
                string codigo_defeitos;
                string descricao_defeitos = AbaDefeito_combo_defeito08.Text;
                double qtd_defeitos = Convert.ToDouble(AbaDefeito_text_qtd08.Text, cultures);
                string observacao = richText_label_AbaDefeitos_obs.Text;
                string num_transac = num_tran;
                string campo_marcador = AbaDefeito_combo_defeito08.Name;
                codigo_defeitos = busca_cod_defeitos_db(descricao_defeitos);
                DateTime data_lanc = Convert.ToDateTime(label_AbaDefeitos_data.Text);


                double mes_lanc = data_lanc.Month;
                double ano_lanc = data_lanc.Year;

                try
                {
                    string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    string comando_sql;

                    comando_sql = "INSERT INTO db_defeitos_mq(data_lanc, ordem_prod, maquina, turno, operador, codigo_defeitos, descricao_defeitos, qtd_defeitos, observacao, num_transac, campo_marcador, mes_lanc, ano_lanc) " +
                        "VALUES('" + data_lanc + "','" + ordem_prod + "','" + maquina + "','" + turno + "','" + operador + "','" + codigo_defeitos + "','" + descricao_defeitos + "','" + qtd_defeitos + "','" + observacao + "','" + num_transac + "','" + campo_marcador + "','" + mes_lanc + "','" + ano_lanc + "')";
                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.Message);
                    cod_geral_erro = 1;
                }
            }
            if (AbaDefeito_text_qtd09.Text != "0")
            {

                //id_parada
                double ordem_prod = Convert.ToDouble(label_AbaDefeitos_ordem.Text);
                string maquina = label_AbaDefeitos_maq.Text;
                string turno = label_AbaDefeitos_turno.Text;
                string operador = label_AbaDefeitos_operador.Text;
                string codigo_defeitos;
                string descricao_defeitos = AbaDefeito_combo_defeito09.Text;
                double qtd_defeitos = Convert.ToDouble(AbaDefeito_text_qtd09.Text, cultures);
                string observacao = richText_label_AbaDefeitos_obs.Text;
                string num_transac = num_tran;
                string campo_marcador = AbaDefeito_combo_defeito09.Name;
                codigo_defeitos = busca_cod_defeitos_db(descricao_defeitos);
                DateTime data_lanc = Convert.ToDateTime(label_AbaDefeitos_data.Text);


                double mes_lanc = data_lanc.Month;
                double ano_lanc = data_lanc.Year;

                try
                {
                    string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    string comando_sql;

                    comando_sql = "INSERT INTO db_defeitos_mq(data_lanc, ordem_prod, maquina, turno, operador, codigo_defeitos, descricao_defeitos, qtd_defeitos, observacao, num_transac, campo_marcador, mes_lanc, ano_lanc) " +
                        "VALUES('" + data_lanc + "','" + ordem_prod + "','" + maquina + "','" + turno + "','" + operador + "','" + codigo_defeitos + "','" + descricao_defeitos + "','" + qtd_defeitos + "','" + observacao + "','" + num_transac + "','" + campo_marcador + "','" + mes_lanc + "','" + ano_lanc + "')";

                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.Message);
                    cod_geral_erro = 1;
                }
            }
            if (AbaDefeito_text_qtd10.Text != "0")
            {

                //id_parada
                double ordem_prod = Convert.ToDouble(label_AbaDefeitos_ordem.Text);
                string maquina = label_AbaDefeitos_maq.Text;
                string turno = label_AbaDefeitos_turno.Text;
                string operador = label_AbaDefeitos_operador.Text;
                string codigo_defeitos;
                string descricao_defeitos = AbaDefeito_combo_defeito10.Text;
                double qtd_defeitos = Convert.ToDouble(AbaDefeito_text_qtd10.Text, cultures);
                string observacao = richText_label_AbaDefeitos_obs.Text;
                string num_transac = num_tran;

                string campo_marcador = AbaDefeito_combo_defeito10.Name;
                codigo_defeitos = busca_cod_defeitos_db(descricao_defeitos);

                DateTime data_lanc = Convert.ToDateTime(label_AbaDefeitos_data.Text);


                double mes_lanc = data_lanc.Month;
                double ano_lanc = data_lanc.Year;

                try
                {
                    string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    string comando_sql;

                    comando_sql = "INSERT INTO db_defeitos_mq(data_lanc, ordem_prod, maquina, turno, operador, codigo_defeitos, descricao_defeitos, qtd_defeitos, observacao, num_transac, campo_marcador, mes_lanc, ano_lanc) " +
                        "VALUES('" + data_lanc + "','" + ordem_prod + "','" + maquina + "','" + turno + "','" + operador + "','" + codigo_defeitos + "','" + descricao_defeitos + "','" + qtd_defeitos + "','" + observacao + "','" + num_transac + "','" + campo_marcador + "','" + mes_lanc + "','" + ano_lanc + "')";

                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.Message);
                    cod_geral_erro = 1;
                }
            }
        }
        private void Estornar_defeitos_mq(string num_transac)
        {
            try
            {
                string comando_sql;

                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                OleDbConnection conexao = new OleDbConnection(conecta_string);
                conexao.Open();

                comando_sql = "DELETE FROM db_defeitos_mq WHERE num_transac='" + num_transac + "'";

                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }


        #endregion // Metodo de defeitos

        //------------------------------------------------------------------------------------------
        #region Metodos Janela Parada
        private void Salvar_paradas_mq(string num_tran)
        {

            if (abaParada_label_hr_total.Text != "00:00:00")
            {
                if (abaParada_label_hr_total01.Text != "0")
                {

                    //id_parada
                    double ordem_prod = Convert.ToDouble(abaParadas_label_numero_op.Text);
                    string maquina = abaParadas_label_maquina.Text;
                    string turno = abaParadas_label_turno.Text;
                    string operador = abaParadas_label_operador.Text;
                    string codigo_parada = "";
                    string descricao_parada = abaParada_combo_parada01.Text;
                    DateTime hora_inicio = abaParada_hr_inicio01.Value;
                    DateTime hora_final = abaParada_hr_fim01.Value;
                    DateTime total_horas = Convert.ToDateTime(abaParada_label_hr_total01.Text);
                    double total_minutos = Convert.ToDateTime(abaParada_label_hr_total01.Text).Hour + Convert.ToDateTime(abaParada_label_hr_total01.Text).Minute;
                    string observacao = abaParadas_obs.Text;
                    string num_transac = num_tran;
                    string campo_marcador = abaParada_combo_parada01.Name;
                    codigo_parada = busca_cod_parada_db(descricao_parada);
                    DateTime data_lanc = Convert.ToDateTime(abaParadas_label_data.Text);

                    double mes_lanc = data_lanc.Month;
                    double ano_lanc = data_lanc.Year;


                    try
                    {
                        string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                        OleDbConnection conexao = new OleDbConnection(conecta_string);
                        conexao.Open();

                        string comando_sql;

                        comando_sql = "INSERT INTO db_paradas_mq(data_lanc, ordem_prod, maquina, turno, operador, codigo_parada, descricao_parada, hora_inicio, hora_final, total_horas, total_minutos, observacao, num_transac, campo_marcador, mes_lanc, ano_lanc) " +
                            "VALUES('" + data_lanc + "','" + ordem_prod + "','" + maquina + "','" + turno + "','" + operador + "','" + codigo_parada + "','" + descricao_parada + "','" + hora_inicio + "','" + hora_final + "','" + total_horas + "','" + total_minutos + "','" + observacao + "','" + num_transac + "','" + campo_marcador + "','" + mes_lanc + "','" + ano_lanc + "')";

                        OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                        cmd.ExecuteNonQuery();
                        conexao.Close();
                    }
                    catch (Exception erro)
                    {

                        MessageBox.Show(erro.Message);
                        cod_geral_erro = 1;
                    }
                }
                if (abaParada_label_hr_total02.Text != "0")
                {

                    //id_parada
                    double ordem_prod = Convert.ToDouble(abaParadas_label_numero_op.Text);
                    string maquina = abaParadas_label_maquina.Text;
                    string turno = abaParadas_label_turno.Text;
                    string operador = abaParadas_label_operador.Text;
                    string codigo_parada = "";
                    string descricao_parada = abaParada_combo_parada02.Text;
                    DateTime hora_inicio = abaParada_hr_inicio02.Value;
                    DateTime hora_final = abaParada_hr_fim02.Value;
                    DateTime total_horas = Convert.ToDateTime(abaParada_label_hr_total02.Text);
                    double total_minutos = Convert.ToDateTime(abaParada_label_hr_total02.Text).Hour + Convert.ToDateTime(abaParada_label_hr_total02.Text).Minute;
                    string observacao = abaParadas_obs.Text;
                    string num_transac = num_tran;

                    string campo_marcador = abaParada_combo_parada02.Name;
                    codigo_parada = busca_cod_parada_db(descricao_parada);

                    DateTime data_lanc = Convert.ToDateTime(abaParadas_label_data.Text);

                    double mes_lanc = data_lanc.Month;
                    double ano_lanc = data_lanc.Year;


                    try
                    {
                        string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                        OleDbConnection conexao = new OleDbConnection(conecta_string);
                        conexao.Open();

                        string comando_sql;

                        comando_sql = "INSERT INTO db_paradas_mq(data_lanc, ordem_prod, maquina, turno, operador, codigo_parada, descricao_parada, hora_inicio, hora_final, total_horas, total_minutos, observacao, num_transac, campo_marcador, mes_lanc, ano_lanc) " +
                            "VALUES('" + data_lanc + "','" + ordem_prod + "','" + maquina + "','" + turno + "','" + operador + "','" + codigo_parada + "','" + descricao_parada + "','" + hora_inicio + "','" + hora_final + "','" + total_horas + "','" + total_minutos + "','" + observacao + "','" + num_transac + "','" + campo_marcador + "','" + mes_lanc + "','" + ano_lanc + "')";

                        OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                        cmd.ExecuteNonQuery();
                        conexao.Close();
                    }
                    catch (Exception erro)
                    {

                        MessageBox.Show(erro.Message);
                        cod_geral_erro = 1;
                    }
                }
                if (abaParada_label_hr_total03.Text != "0")
                {

                    //id_parada
                    double ordem_prod = Convert.ToDouble(abaParadas_label_numero_op.Text);
                    string maquina = abaParadas_label_maquina.Text;
                    string turno = abaParadas_label_turno.Text;
                    string operador = abaParadas_label_operador.Text;
                    string codigo_parada = "";
                    string descricao_parada = abaParada_combo_parada03.Text;
                    DateTime hora_inicio = abaParada_hr_inicio03.Value;
                    DateTime hora_final = abaParada_hr_fim03.Value;
                    DateTime total_horas = Convert.ToDateTime(abaParada_label_hr_total03.Text);
                    double total_minutos = Convert.ToDateTime(abaParada_label_hr_total03.Text).Hour + Convert.ToDateTime(abaParada_label_hr_total03.Text).Minute;
                    string observacao = abaParadas_obs.Text;
                    string num_transac = num_tran;

                    string campo_marcador = abaParada_combo_parada03.Name;
                    codigo_parada = busca_cod_parada_db(descricao_parada);
                    DateTime data_lanc = Convert.ToDateTime(abaParadas_label_data.Text);
                    double mes_lanc = data_lanc.Month;
                    double ano_lanc = data_lanc.Year;


                    try
                    {
                        string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                        OleDbConnection conexao = new OleDbConnection(conecta_string);
                        conexao.Open();

                        string comando_sql;

                        comando_sql = "INSERT INTO db_paradas_mq(data_lanc, ordem_prod, maquina, turno, operador, codigo_parada, descricao_parada, hora_inicio, hora_final, total_horas, total_minutos, observacao, num_transac, campo_marcador, mes_lanc, ano_lanc) " +
                            "VALUES('" + data_lanc + "','" + ordem_prod + "','" + maquina + "','" + turno + "','" + operador + "','" + codigo_parada + "','" + descricao_parada + "','" + hora_inicio + "','" + hora_final + "','" + total_horas + "','" + total_minutos + "','" + observacao + "','" + num_transac + "','" + campo_marcador + "','" + mes_lanc + "','" + ano_lanc + "')";

                        OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                        cmd.ExecuteNonQuery();
                        conexao.Close();
                    }
                    catch (Exception erro)
                    {

                        MessageBox.Show(erro.Message);
                        cod_geral_erro = 1;
                    }
                }
                if (abaParada_label_hr_total04.Text != "0")
                {

                    //id_parada
                    double ordem_prod = Convert.ToDouble(abaParadas_label_numero_op.Text);
                    string maquina = abaParadas_label_maquina.Text;
                    string turno = abaParadas_label_turno.Text;
                    string operador = abaParadas_label_operador.Text;
                    string codigo_parada = "";
                    string descricao_parada = abaParada_combo_parada04.Text;
                    DateTime hora_inicio = abaParada_hr_inicio04.Value;
                    DateTime hora_final = abaParada_hr_fim04.Value;
                    DateTime total_horas = Convert.ToDateTime(abaParada_label_hr_total04.Text);
                    double total_minutos = Convert.ToDateTime(abaParada_label_hr_total04.Text).Hour + Convert.ToDateTime(abaParada_label_hr_total04.Text).Minute;
                    string observacao = abaParadas_obs.Text;
                    string num_transac = num_tran;

                    string campo_marcador = abaParada_combo_parada04.Name;
                    codigo_parada = busca_cod_parada_db(descricao_parada);
                    DateTime data_lanc = Convert.ToDateTime(abaParadas_label_data.Text);

                    double mes_lanc = data_lanc.Month;
                    double ano_lanc = data_lanc.Year;


                    try
                    {
                        string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                        OleDbConnection conexao = new OleDbConnection(conecta_string);
                        conexao.Open();

                        string comando_sql;

                        comando_sql = "INSERT INTO db_paradas_mq(data_lanc, ordem_prod, maquina, turno, operador, codigo_parada, descricao_parada, hora_inicio, hora_final, total_horas, total_minutos, observacao, num_transac, campo_marcador, mes_lanc, ano_lanc) " +
                            "VALUES('" + data_lanc + "','" + ordem_prod + "','" + maquina + "','" + turno + "','" + operador + "','" + codigo_parada + "','" + descricao_parada + "','" + hora_inicio + "','" + hora_final + "','" + total_horas + "','" + total_minutos + "','" + observacao + "','" + num_transac + "','" + campo_marcador + "','" + mes_lanc + "','" + ano_lanc + "')";

                        OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                        cmd.ExecuteNonQuery();
                        conexao.Close();
                    }
                    catch (Exception erro)
                    {

                        MessageBox.Show(erro.Message);
                        cod_geral_erro = 1;
                    }
                }
                if (abaParada_label_hr_total05.Text != "0")
                {

                    //id_parada
                    double ordem_prod = Convert.ToDouble(abaParadas_label_numero_op.Text);
                    string maquina = abaParadas_label_maquina.Text;
                    string turno = abaParadas_label_turno.Text;
                    string operador = abaParadas_label_operador.Text;
                    string codigo_parada = "";
                    string descricao_parada = abaParada_combo_parada05.Text;
                    DateTime hora_inicio = abaParada_hr_inicio05.Value;
                    DateTime hora_final = abaParada_hr_fim05.Value;
                    DateTime total_horas = Convert.ToDateTime(abaParada_label_hr_total05.Text);
                    double total_minutos = Convert.ToDateTime(abaParada_label_hr_total05.Text).Hour + Convert.ToDateTime(abaParada_label_hr_total05.Text).Minute;
                    string observacao = abaParadas_obs.Text;
                    string num_transac = num_tran;

                    string campo_marcador = abaParada_combo_parada05.Name;
                    codigo_parada = busca_cod_parada_db(descricao_parada);
                    DateTime data_lanc = Convert.ToDateTime(abaParadas_label_data.Text);

                    double mes_lanc = data_lanc.Month;
                    double ano_lanc = data_lanc.Year;


                    try
                    {
                        string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                        OleDbConnection conexao = new OleDbConnection(conecta_string);
                        conexao.Open();

                        string comando_sql;

                        comando_sql = "INSERT INTO db_paradas_mq(data_lanc, ordem_prod, maquina, turno, operador, codigo_parada, descricao_parada, hora_inicio, hora_final, total_horas, total_minutos, observacao, num_transac, campo_marcador, mes_lanc, ano_lanc) " +
                            "VALUES('" + data_lanc + "','" + ordem_prod + "','" + maquina + "','" + turno + "','" + operador + "','" + codigo_parada + "','" + descricao_parada + "','" + hora_inicio + "','" + hora_final + "','" + total_horas + "','" + total_minutos + "','" + observacao + "','" + num_transac + "','" + campo_marcador + "','" + mes_lanc + "','" + ano_lanc + "')";

                        OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                        cmd.ExecuteNonQuery();
                        conexao.Close();
                    }
                    catch (Exception erro)
                    {

                        MessageBox.Show(erro.Message);
                        cod_geral_erro = 1;
                    }
                }
                if (abaParada_label_hr_total06.Text != "0")
                {

                    //id_parada
                    double ordem_prod = Convert.ToDouble(abaParadas_label_numero_op.Text);
                    string maquina = abaParadas_label_maquina.Text;
                    string turno = abaParadas_label_turno.Text;
                    string operador = abaParadas_label_operador.Text;
                    string codigo_parada = "";
                    string descricao_parada = abaParada_combo_parada06.Text;
                    DateTime hora_inicio = abaParada_hr_inicio06.Value;
                    DateTime hora_final = abaParada_hr_fim06.Value;
                    DateTime total_horas = Convert.ToDateTime(abaParada_label_hr_total06.Text);
                    double total_minutos = Convert.ToDateTime(abaParada_label_hr_total06.Text).Hour + Convert.ToDateTime(abaParada_label_hr_total06.Text).Minute;
                    string observacao = abaParadas_obs.Text;
                    string num_transac = num_tran;

                    string campo_marcador = abaParada_combo_parada06.Name;
                    codigo_parada = busca_cod_parada_db(descricao_parada);
                    DateTime data_lanc = Convert.ToDateTime(abaParadas_label_data.Text);

                    double mes_lanc = data_lanc.Month;
                    double ano_lanc = data_lanc.Year;


                    try
                    {
                        string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                        OleDbConnection conexao = new OleDbConnection(conecta_string);
                        conexao.Open();

                        string comando_sql;

                        comando_sql = "INSERT INTO db_paradas_mq(data_lanc, ordem_prod, maquina, turno, operador, codigo_parada, descricao_parada, hora_inicio, hora_final, total_horas, total_minutos, observacao, num_transac, campo_marcador, mes_lanc, ano_lanc) " +
                            "VALUES('" + data_lanc + "','" + ordem_prod + "','" + maquina + "','" + turno + "','" + operador + "','" + codigo_parada + "','" + descricao_parada + "','" + hora_inicio + "','" + hora_final + "','" + total_horas + "','" + total_minutos + "','" + observacao + "','" + num_transac + "','" + campo_marcador + "','" + mes_lanc + "','" + ano_lanc + "')";


                        OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                        cmd.ExecuteNonQuery();
                        conexao.Close();
                    }
                    catch (Exception erro)
                    {

                        MessageBox.Show(erro.Message);
                        cod_geral_erro = 1;
                    }
                }
                if (abaParada_label_hr_total07.Text != "0")
                {

                    //id_parada
                    double ordem_prod = Convert.ToDouble(abaParadas_label_numero_op.Text);
                    string maquina = abaParadas_label_maquina.Text;
                    string turno = abaParadas_label_turno.Text;
                    string operador = abaParadas_label_operador.Text;
                    string codigo_parada = "";
                    string descricao_parada = abaParada_combo_parada07.Text;
                    DateTime hora_inicio = abaParada_hr_inicio07.Value;
                    DateTime hora_final = abaParada_hr_fim07.Value;
                    DateTime total_horas = Convert.ToDateTime(abaParada_label_hr_total07.Text);
                    double total_minutos = Convert.ToDateTime(abaParada_label_hr_total07.Text).Hour + Convert.ToDateTime(abaParada_label_hr_total07.Text).Minute;
                    string observacao = abaParadas_obs.Text;
                    string num_transac = num_tran;

                    string campo_marcador = abaParada_combo_parada07.Name;
                    codigo_parada = busca_cod_parada_db(descricao_parada);
                    DateTime data_lanc = Convert.ToDateTime(abaParadas_label_data.Text);

                    double mes_lanc = data_lanc.Month;
                    double ano_lanc = data_lanc.Year;

                    try
                    {
                        string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                        OleDbConnection conexao = new OleDbConnection(conecta_string);
                        conexao.Open();

                        string comando_sql;

                        comando_sql = "INSERT INTO db_paradas_mq(data_lanc, ordem_prod, maquina, turno, operador, codigo_parada, descricao_parada, hora_inicio, hora_final, total_horas, total_minutos, observacao, num_transac, campo_marcador, mes_lanc, ano_lanc) " +
                            "VALUES('" + data_lanc + "','" + ordem_prod + "','" + maquina + "','" + turno + "','" + operador + "','" + codigo_parada + "','" + descricao_parada + "','" + hora_inicio + "','" + hora_final + "','" + total_horas + "','" + total_minutos + "','" + observacao + "','" + num_transac + "','" + campo_marcador + "','" + mes_lanc + "','" + ano_lanc + "')";

                        OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                        cmd.ExecuteNonQuery();
                        conexao.Close();
                    }
                    catch (Exception erro)
                    {

                        MessageBox.Show(erro.Message);
                        cod_geral_erro = 1;
                    }
                }
                if (abaParada_label_hr_total08.Text != "0")
                {

                    //id_parada
                    double ordem_prod = Convert.ToDouble(abaParadas_label_numero_op.Text);
                    string maquina = abaParadas_label_maquina.Text;
                    string turno = abaParadas_label_turno.Text;
                    string operador = abaParadas_label_operador.Text;
                    string codigo_parada = "";
                    string descricao_parada = abaParada_combo_parada08.Text;
                    DateTime hora_inicio = abaParada_hr_inicio08.Value;
                    DateTime hora_final = abaParada_hr_fim08.Value;
                    DateTime total_horas = Convert.ToDateTime(abaParada_label_hr_total08.Text);
                    double total_minutos = Convert.ToDateTime(abaParada_label_hr_total08.Text).Hour + Convert.ToDateTime(abaParada_label_hr_total08.Text).Minute;
                    string observacao = abaParadas_obs.Text;
                    string num_transac = num_tran;

                    string campo_marcador = abaParada_combo_parada08.Name;
                    codigo_parada = busca_cod_parada_db(descricao_parada);
                    DateTime data_lanc = Convert.ToDateTime(abaParadas_label_data.Text);

                    double mes_lanc = data_lanc.Month;
                    double ano_lanc = data_lanc.Year;

                    try
                    {
                        string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                        OleDbConnection conexao = new OleDbConnection(conecta_string);
                        conexao.Open();

                        string comando_sql;

                        comando_sql = "INSERT INTO db_paradas_mq(data_lanc, ordem_prod, maquina, turno, operador, codigo_parada, descricao_parada, hora_inicio, hora_final, total_horas, total_minutos, observacao, num_transac, campo_marcador, mes_lanc, ano_lanc) " +
                            "VALUES('" + data_lanc + "','" + ordem_prod + "','" + maquina + "','" + turno + "','" + operador + "','" + codigo_parada + "','" + descricao_parada + "','" + hora_inicio + "','" + hora_final + "','" + total_horas + "','" + total_minutos + "','" + observacao + "','" + num_transac + "','" + campo_marcador + "','" + mes_lanc + "','" + ano_lanc + "')";

                        OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                        cmd.ExecuteNonQuery();
                        conexao.Close();
                    }
                    catch (Exception erro)
                    {

                        MessageBox.Show(erro.Message);
                        cod_geral_erro = 1;
                    }
                }
            }
        }
        private void Estornar_paradas(string num_transac)
        {
            // num_transac = id + OP

            // 01 - buscar numero da transação
            // 02 - comparar na base o numero
            // 03 - escluir o registro no banco

            try
            {
                string comando_sql;

                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                OleDbConnection conexao = new OleDbConnection(conecta_string);
                conexao.Open();

                comando_sql = "DELETE FROM db_paradas_mq WHERE num_transac='" + num_transac + "'";

                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }



        }


        #endregion //Metodos Janela Parada

        //------------------------------------------------------------------------------------------

        #region Metodos Janela Mistura

        private void Salvar_mistura(string num_tran)
        {
            // falta modificar esse metodo
            if (AbaMistura_label_total_mistura.Text != "%")
            {
                if (abaMistura_text_perct01.Text != string.Empty)
                {

                    //id_parada
                    double ordem_prod = Convert.ToDouble(AbaMistura_label_op.Text);
                    string maquina = AbaMistura_label_mq.Text;
                    string turno = AbaMistura_label_turno.Text;
                    string operador = AbaMistura_label_operador.Text;
                    string materia_prima = abaMistura_combo_mp01.Text;
                    double producao = Convert.ToDouble(AbaMistura_label_producao.Text);
                    double percentual = Convert.ToDouble(abaMistura_text_perct01.Text) / 100;
                    double consumo_mp = producao * percentual;
                    int dia = Convert.ToDateTime(dt_inicio_pro.Value).Date.Day;
                    int mes = Convert.ToDateTime(dt_inicio_pro.Value).Date.Month;
                    int ano = Convert.ToDateTime(dt_inicio_pro.Value).Date.Year;
                    DateTime data_lancamento = Convert.ToDateTime(dt_inicio_pro.Value);
                    string observacao = abaParadas_obs.Text;
                    string num_transac = num_tran;
                    string campo_marcador = abaMistura_combo_mp01.Name;

                    try
                    {
                        string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                        OleDbConnection conexao = new OleDbConnection(conecta_string);
                        conexao.Open();

                        string comando_sql;

                        comando_sql = "INSERT INTO db_mp_apon(ordem_prod, maquina, turno, operador, materia_prima, producao, percentual, consumo_mp, dia, mes, ano, data_lancamento, observacao, num_transac, campo_marcador) " +
                          "VALUES('" + ordem_prod + "','" + maquina + "','" + turno + "','" + operador + "','" + materia_prima + "','" + producao + "','" + percentual + "','" + consumo_mp + "','" + dia + "','" + mes + "','" + ano + "','" + data_lancamento + "','" + observacao + "','" + num_transac + "','" + campo_marcador + "')";

                        OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                        cmd.ExecuteNonQuery();
                        conexao.Close();
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message);
                        cod_geral_erro = 1;
                    }
                }
                if (abaMistura_text_perct02.Text != string.Empty)
                {

                    //id_parada
                    double ordem_prod = Convert.ToDouble(AbaMistura_label_op.Text);
                    string maquina = AbaMistura_label_mq.Text;
                    string turno = AbaMistura_label_turno.Text;
                    string operador = AbaMistura_label_operador.Text;
                    string materia_prima = abaMistura_combo_mp02.Text;
                    double producao = Convert.ToDouble(AbaMistura_label_producao.Text);
                    double percentual = Convert.ToDouble(abaMistura_text_perct02.Text) / 100;
                    double consumo_mp = producao * percentual;
                    int dia = Convert.ToDateTime(dt_inicio_pro.Value).Date.Day;
                    int mes = Convert.ToDateTime(dt_inicio_pro.Value).Date.Month;
                    int ano = Convert.ToDateTime(dt_inicio_pro.Value).Date.Year;
                    DateTime data_lancamento = Convert.ToDateTime(dt_inicio_pro.Value);
                    string observacao = abaParadas_obs.Text;
                    string num_transac = num_tran;
                    string campo_marcador = abaMistura_combo_mp02.Name;

                    try
                    {
                        string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                        OleDbConnection conexao = new OleDbConnection(conecta_string);
                        conexao.Open();

                        string comando_sql;

                        comando_sql = "INSERT INTO db_mp_apon(ordem_prod, maquina, turno, operador, materia_prima, producao, percentual, consumo_mp, dia, mes, ano, data_lancamento, observacao, num_transac, campo_marcador) " +
                          "VALUES('" + ordem_prod + "','" + maquina + "','" + turno + "','" + operador + "','" + materia_prima + "','" + producao + "','" + percentual + "','" + consumo_mp + "','" + dia + "','" + mes + "','" + ano + "','" + data_lancamento + "','" + observacao + "','" + num_transac + "','" + campo_marcador + "')";

                        OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                        cmd.ExecuteNonQuery();
                        conexao.Close();
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message);
                        cod_geral_erro = 1;
                    }
                }
                if (abaMistura_text_perct03.Text != string.Empty)
                {

                    //id_parada
                    double ordem_prod = Convert.ToDouble(AbaMistura_label_op.Text);
                    string maquina = AbaMistura_label_mq.Text;
                    string turno = AbaMistura_label_turno.Text;
                    string operador = AbaMistura_label_operador.Text;
                    string materia_prima = abaMistura_combo_mp03.Text;
                    double producao = Convert.ToDouble(AbaMistura_label_producao.Text);
                    double percentual = Convert.ToDouble(abaMistura_text_perct03.Text) / 100;
                    double consumo_mp = producao * percentual;
                    int dia = Convert.ToDateTime(dt_inicio_pro.Value).Date.Day;
                    int mes = Convert.ToDateTime(dt_inicio_pro.Value).Date.Month;
                    int ano = Convert.ToDateTime(dt_inicio_pro.Value).Date.Year;
                    DateTime data_lancamento = Convert.ToDateTime(dt_inicio_pro.Value);
                    string observacao = abaParadas_obs.Text;
                    string num_transac = num_tran;
                    string campo_marcador = abaMistura_combo_mp03.Name;

                    try
                    {
                        string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                        OleDbConnection conexao = new OleDbConnection(conecta_string);
                        conexao.Open();

                        string comando_sql;

                        comando_sql = "INSERT INTO db_mp_apon(ordem_prod, maquina, turno, operador, materia_prima, producao, percentual, consumo_mp, dia, mes, ano, data_lancamento, observacao, num_transac, campo_marcador) " +
                          "VALUES('" + ordem_prod + "','" + maquina + "','" + turno + "','" + operador + "','" + materia_prima + "','" + producao + "','" + percentual + "','" + consumo_mp + "','" + dia + "','" + mes + "','" + ano + "','" + data_lancamento + "','" + observacao + "','" + num_transac + "','" + campo_marcador + "')";

                        OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                        cmd.ExecuteNonQuery();
                        conexao.Close();
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message);
                        cod_geral_erro = 1;
                    }
                }
                if (abaMistura_text_perct04.Text != string.Empty)
                {

                    //id_parada
                    double ordem_prod = Convert.ToDouble(AbaMistura_label_op.Text);
                    string maquina = AbaMistura_label_mq.Text;
                    string turno = AbaMistura_label_turno.Text;
                    string operador = AbaMistura_label_operador.Text;
                    string materia_prima = abaMistura_combo_mp04.Text;
                    double producao = Convert.ToDouble(AbaMistura_label_producao.Text);
                    double percentual = Convert.ToDouble(abaMistura_text_perct04.Text) / 100;
                    double consumo_mp = producao * percentual;
                    int dia = Convert.ToDateTime(dt_inicio_pro.Value).Date.Day;
                    int mes = Convert.ToDateTime(dt_inicio_pro.Value).Date.Month;
                    int ano = Convert.ToDateTime(dt_inicio_pro.Value).Date.Year;
                    DateTime data_lancamento = Convert.ToDateTime(dt_inicio_pro.Value);
                    string observacao = abaParadas_obs.Text;
                    string num_transac = num_tran;
                    string campo_marcador = abaMistura_combo_mp04.Name;

                    try
                    {
                        string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                        OleDbConnection conexao = new OleDbConnection(conecta_string);
                        conexao.Open();

                        string comando_sql;

                        comando_sql = "INSERT INTO db_mp_apon(ordem_prod, maquina, turno, operador, materia_prima, producao, percentual, consumo_mp, dia, mes, ano, data_lancamento, observacao, num_transac, campo_marcador) " +
                          "VALUES('" + ordem_prod + "','" + maquina + "','" + turno + "','" + operador + "','" + materia_prima + "','" + producao + "','" + percentual + "','" + consumo_mp + "','" + dia + "','" + mes + "','" + ano + "','" + data_lancamento + "','" + observacao + "','" + num_transac + "','" + campo_marcador + "')";

                        OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                        cmd.ExecuteNonQuery();
                        conexao.Close();
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message);
                        cod_geral_erro = 1;
                    }
                }
                if (abaMistura_text_perct05.Text != string.Empty)
                {

                    //id_parada
                    double ordem_prod = Convert.ToDouble(AbaMistura_label_op.Text);
                    string maquina = AbaMistura_label_mq.Text;
                    string turno = AbaMistura_label_turno.Text;
                    string operador = AbaMistura_label_operador.Text;
                    string materia_prima = abaMistura_combo_mp05.Text;
                    double producao = Convert.ToDouble(AbaMistura_label_producao.Text);
                    double percentual = Convert.ToDouble(abaMistura_text_perct05.Text) / 100;
                    double consumo_mp = producao * percentual;
                    int dia = Convert.ToDateTime(dt_inicio_pro.Value).Date.Day;
                    int mes = Convert.ToDateTime(dt_inicio_pro.Value).Date.Month;
                    int ano = Convert.ToDateTime(dt_inicio_pro.Value).Date.Year;
                    DateTime data_lancamento = Convert.ToDateTime(dt_inicio_pro.Value);
                    string observacao = abaParadas_obs.Text;
                    string num_transac = num_tran;
                    string campo_marcador = abaMistura_combo_mp05.Name;

                    try
                    {
                        string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                        OleDbConnection conexao = new OleDbConnection(conecta_string);
                        conexao.Open();

                        string comando_sql;

                        comando_sql = "INSERT INTO db_mp_apon(ordem_prod, maquina, turno, operador, materia_prima, producao, percentual, consumo_mp, dia, mes, ano, data_lancamento, observacao, num_transac, campo_marcador) " +
                          "VALUES('" + ordem_prod + "','" + maquina + "','" + turno + "','" + operador + "','" + materia_prima + "','" + producao + "','" + percentual + "','" + consumo_mp + "','" + dia + "','" + mes + "','" + ano + "','" + data_lancamento + "','" + observacao + "','" + num_transac + "','" + campo_marcador + "')";

                        OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                        cmd.ExecuteNonQuery();
                        conexao.Close();
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message);
                        cod_geral_erro = 1;
                    }
                }
                if (abaMistura_text_perct06.Text != string.Empty)
                {

                    //id_parada
                    double ordem_prod = Convert.ToDouble(AbaMistura_label_op.Text);
                    string maquina = AbaMistura_label_mq.Text;
                    string turno = AbaMistura_label_turno.Text;
                    string operador = AbaMistura_label_operador.Text;
                    string materia_prima = abaMistura_combo_mp06.Text;
                    double producao = Convert.ToDouble(AbaMistura_label_producao.Text);
                    double percentual = Convert.ToDouble(abaMistura_text_perct06.Text) / 100;
                    double consumo_mp = producao * percentual;
                    int dia = Convert.ToDateTime(dt_inicio_pro.Value).Date.Day;
                    int mes = Convert.ToDateTime(dt_inicio_pro.Value).Date.Month;
                    int ano = Convert.ToDateTime(dt_inicio_pro.Value).Date.Year;
                    DateTime data_lancamento = Convert.ToDateTime(dt_inicio_pro.Value);
                    string observacao = abaParadas_obs.Text;
                    string num_transac = num_tran;
                    string campo_marcador = abaMistura_combo_mp06.Name;

                    try
                    {
                        string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                        OleDbConnection conexao = new OleDbConnection(conecta_string);
                        conexao.Open();

                        string comando_sql;

                        comando_sql = "INSERT INTO db_mp_apon(ordem_prod, maquina, turno, operador, materia_prima, producao, percentual, consumo_mp, dia, mes, ano, data_lancamento, observacao, num_transac, campo_marcador) " +
                          "VALUES('" + ordem_prod + "','" + maquina + "','" + turno + "','" + operador + "','" + materia_prima + "','" + producao + "','" + percentual + "','" + consumo_mp + "','" + dia + "','" + mes + "','" + ano + "','" + data_lancamento + "','" + observacao + "','" + num_transac + "','" + campo_marcador + "')";

                        OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                        cmd.ExecuteNonQuery();
                        conexao.Close();
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message);
                        cod_geral_erro = 1;
                    }
                }
                if (abaMistura_text_perct07.Text != string.Empty)
                {

                    //id_parada
                    double ordem_prod = Convert.ToDouble(AbaMistura_label_op.Text);
                    string maquina = AbaMistura_label_mq.Text;
                    string turno = AbaMistura_label_turno.Text;
                    string operador = AbaMistura_label_operador.Text;
                    string materia_prima = abaMistura_combo_mp07.Text;
                    double producao = Convert.ToDouble(AbaMistura_label_producao.Text);
                    double percentual = Convert.ToDouble(abaMistura_text_perct07.Text) / 100;
                    double consumo_mp = producao * percentual;
                    int dia = Convert.ToDateTime(dt_inicio_pro.Value).Date.Day;
                    int mes = Convert.ToDateTime(dt_inicio_pro.Value).Date.Month;
                    int ano = Convert.ToDateTime(dt_inicio_pro.Value).Date.Year;
                    DateTime data_lancamento = Convert.ToDateTime(dt_inicio_pro.Value);
                    string observacao = abaParadas_obs.Text;
                    string num_transac = num_tran;
                    string campo_marcador = abaMistura_combo_mp07.Name;

                    try
                    {
                        string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                        OleDbConnection conexao = new OleDbConnection(conecta_string);
                        conexao.Open();

                        string comando_sql;

                        comando_sql = "INSERT INTO db_mp_apon(ordem_prod, maquina, turno, operador, materia_prima, producao, percentual, consumo_mp, dia, mes, ano, data_lancamento, observacao, num_transac, campo_marcador) " +
                          "VALUES('" + ordem_prod + "','" + maquina + "','" + turno + "','" + operador + "','" + materia_prima + "','" + producao + "','" + percentual + "','" + consumo_mp + "','" + dia + "','" + mes + "','" + ano + "','" + data_lancamento + "','" + observacao + "','" + num_transac + "','" + campo_marcador + "')";

                        OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                        cmd.ExecuteNonQuery();
                        conexao.Close();
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message);
                        cod_geral_erro = 1;
                    }
                }
                if (abaMistura_text_perct08.Text != string.Empty)
                {

                    //id_parada
                    double ordem_prod = Convert.ToDouble(AbaMistura_label_op.Text);
                    string maquina = AbaMistura_label_mq.Text;
                    string turno = AbaMistura_label_turno.Text;
                    string operador = AbaMistura_label_operador.Text;
                    string materia_prima = abaMistura_combo_mp08.Text;
                    double producao = Convert.ToDouble(AbaMistura_label_producao.Text);
                    double percentual = Convert.ToDouble(abaMistura_text_perct08.Text) / 100;
                    double consumo_mp = producao * percentual;
                    int dia = Convert.ToDateTime(dt_inicio_pro.Value).Date.Day;
                    int mes = Convert.ToDateTime(dt_inicio_pro.Value).Date.Month;
                    int ano = Convert.ToDateTime(dt_inicio_pro.Value).Date.Year;
                    DateTime data_lancamento = Convert.ToDateTime(dt_inicio_pro.Value);
                    string observacao = abaParadas_obs.Text;
                    string num_transac = num_tran;
                    string campo_marcador = abaMistura_combo_mp08.Name;

                    try
                    {
                        string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                        OleDbConnection conexao = new OleDbConnection(conecta_string);
                        conexao.Open();

                        string comando_sql;

                        comando_sql = "INSERT INTO db_mp_apon(ordem_prod, maquina, turno, operador, materia_prima, producao, percentual, consumo_mp, dia, mes, ano, data_lancamento, observacao, num_transac, campo_marcador) " +
                          "VALUES('" + ordem_prod + "','" + maquina + "','" + turno + "','" + operador + "','" + materia_prima + "','" + producao + "','" + percentual + "','" + consumo_mp + "','" + dia + "','" + mes + "','" + ano + "','" + data_lancamento + "','" + observacao + "','" + num_transac + "','" + campo_marcador + "')";

                        OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                        cmd.ExecuteNonQuery();
                        conexao.Close();
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message);
                        cod_geral_erro = 1;
                    }
                }
                if (abaMistura_text_perct09.Text != string.Empty)
                {

                    //id_parada
                    double ordem_prod = Convert.ToDouble(AbaMistura_label_op.Text);
                    string maquina = AbaMistura_label_mq.Text;
                    string turno = AbaMistura_label_turno.Text;
                    string operador = AbaMistura_label_operador.Text;
                    string materia_prima = abaMistura_combo_mp09.Text;
                    double producao = Convert.ToDouble(AbaMistura_label_producao.Text);
                    double percentual = Convert.ToDouble(abaMistura_text_perct09.Text) / 100;
                    double consumo_mp = producao * percentual;
                    int dia = Convert.ToDateTime(dt_inicio_pro.Value).Date.Day;
                    int mes = Convert.ToDateTime(dt_inicio_pro.Value).Date.Month;
                    int ano = Convert.ToDateTime(dt_inicio_pro.Value).Date.Year;
                    DateTime data_lancamento = Convert.ToDateTime(dt_inicio_pro.Value);
                    string observacao = abaParadas_obs.Text;
                    string num_transac = num_tran;
                    string campo_marcador = abaMistura_combo_mp09.Name;

                    try
                    {
                        string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                        OleDbConnection conexao = new OleDbConnection(conecta_string);
                        conexao.Open();

                        string comando_sql;

                        comando_sql = "INSERT INTO db_mp_apon(ordem_prod, maquina, turno, operador, materia_prima, producao, percentual, consumo_mp, dia, mes, ano, data_lancamento, observacao, num_transac, campo_marcador) " +
                          "VALUES('" + ordem_prod + "','" + maquina + "','" + turno + "','" + operador + "','" + materia_prima + "','" + producao + "','" + percentual + "','" + consumo_mp + "','" + dia + "','" + mes + "','" + ano + "','" + data_lancamento + "','" + observacao + "','" + num_transac + "','" + campo_marcador + "')";

                        OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                        cmd.ExecuteNonQuery();
                        conexao.Close();
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message);
                        cod_geral_erro = 1;
                    }
                }
                if (abaMistura_text_perct10.Text != string.Empty)
                {

                    //id_parada
                    double ordem_prod = Convert.ToDouble(AbaMistura_label_op.Text);
                    string maquina = AbaMistura_label_mq.Text;
                    string turno = AbaMistura_label_turno.Text;
                    string operador = AbaMistura_label_operador.Text;
                    string materia_prima = abaMistura_combo_mp10.Text;
                    double producao = Convert.ToDouble(AbaMistura_label_producao.Text);
                    double percentual = Convert.ToDouble(abaMistura_text_perct10.Text) / 100;
                    double consumo_mp = producao * percentual;
                    int dia = Convert.ToDateTime(dt_inicio_pro.Value).Date.Day;
                    int mes = Convert.ToDateTime(dt_inicio_pro.Value).Date.Month;
                    int ano = Convert.ToDateTime(dt_inicio_pro.Value).Date.Year;
                    DateTime data_lancamento = Convert.ToDateTime(dt_inicio_pro.Value);
                    string observacao = abaParadas_obs.Text;
                    string num_transac = num_tran;

                    try
                    {
                        string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                        OleDbConnection conexao = new OleDbConnection(conecta_string);
                        conexao.Open();

                        string comando_sql;

                        comando_sql = "INSERT INTO db_mp_apon(ordem_prod, maquina, turno, operador, materia_prima, producao, percentual, consumo_mp, dia, mes, ano, data_lancamento, observacao, num_transac) " +
                          "VALUES('" + ordem_prod + "','" + maquina + "','" + turno + "','" + operador + "','" + materia_prima + "','" + producao + "','" + percentual + "','" + consumo_mp + "','" + dia + "','" + mes + "','" + ano + "','" + data_lancamento + "','" + observacao + "','" + num_transac + "')";

                        OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                        cmd.ExecuteNonQuery();
                        conexao.Close();
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message);
                        cod_geral_erro = 1;
                    }
                }
            }
        }
        private void Estornar_consumo_mp(string num_transac)
        {
            try
            {
                string comando_sql;

                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                OleDbConnection conexao = new OleDbConnection(conecta_string);
                conexao.Open();

                comando_sql = "DELETE FROM db_mp_apon WHERE num_transac='" + num_transac + "'";

                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
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



        #endregion // Metodos Janela Mistura

        //------------------------------------------------------------------------------------------

        #region Botoões do menu da direita

        private void button_apontamento_Click(object sender, EventArgs e)
        {
            Desbloquear_controles();            
            this.label_tipo_movimento.Text = "N";

            if(combo_ordem_prod.Text != string.Empty)
            {
                Limpar_campos();
            }

        }
        private void button_estornar_Click(object sender, EventArgs e)
        {
            
            //Estatus_estorno(abaApon_label_id_apont.Text); // identifica qual ordem foi estornada            
            
            Estornar_apontamento_delete(abaApon_label_id_apont.Text); // 13/08
            label_tipo_movimento.Text = "R"; 

            //Estornar_apontamento("R");
            
            Limpar_campos();

        }
        private void button_importar_Click(object sender, EventArgs e)
        {
            Importar_ordens();
            MessageBox.Show("Dados importados com sucesso!");

        }
        private void button_paradas_Click(object sender, EventArgs e)
        {
            tab_menu_apontamento.SelectedTab = tab_paradas;


            Carregar_tipos_parada(this.text_local_aplicacao.Text);

            abaParadas_label_data.Text = dt_inicio_pro.Value.ToString("dd/MM/yyyy");

            abaParadas_label_turno.Text = combo_turnos.Text;
            abaParadas_label_numero_op.Text = combo_ordem_prod.Text;
            abaParadas_label_local_aplicacao.Text = text_local_aplicacao.Text;
            abaParadas_label_maquina.Text = combo_maquinas.Text;
            abaParadas_label_operador.Text = combo_operadores.Text;
            //AP02 janela_parada = new AP02(this.combo_ordem_prod.Text, this.text_local_aplicacao.Text);
            //janela_parada.Show();

        }
        private void button_defeitos_Click(object sender, EventArgs e)
        {
            tab_menu_apontamento.SelectedTab = tab_defeitos_apon;
            label_AbaDefeitos_turno.Text = combo_turnos.Text;

            label_AbaDefeitos_data.Text = dt_inicio_pro.Value.ToString("dd/MM/yyyy");

            Carregar_defeitos(this.text_local_aplicacao.Text);
            label_AbaDefeitos_ordem.Text = combo_ordem_prod.Text;
            label_AbaDefeitos_localAplicacao.Text = text_local_aplicacao.Text;
            label_AbaDefeitos_maq.Text = combo_maquinas.Text;
            label_AbaDefeitos_operador.Text = combo_operadores.Text;

            button_defeitos.BackColor = Color.LightGreen;


        }
        private void button_obs_Click(object sender, EventArgs e)
        {

        }
        private void button_mistura_mp_Click(object sender, EventArgs e)
        {
            if (text_local_aplicacao.Text == "Extrusora")
            {
                tab_menu_apontamento.SelectedTab = tab_mistura;
                Carregar_mp_mistura();

                AbaMistura_label_op.Text = combo_ordem_prod.Text;
                AbaMistura_label_mq.Text = combo_maquinas.Text;
                AbaMistura_label_operador.Text = combo_operadores.Text;
                AbaMistura_label_turno.Text = combo_turnos.Text;
                AbaMistura_label_producao.Text = text_qtd_boa.Text;
                AbaMistura_label_data_lanc.Text = dt_inicio_pro.Value.ToString("dd/MM/yyyy");
                button_mistura_mp.BackColor = Color.LightGreen;
            }
            else
            {
                MessageBox.Show("Não é necessario informar mistura para itens da picotadeira!");

            }

        }
        private void button_retrabalho_Click(object sender, EventArgs e)
        {

        }
        #endregion

        //------------------------------------------------------------------------------------------

        #region Funcionalidade Aba Mistura
        private void abaMistura_text_perct01_Leave(object sender, EventArgs e) { }
        private void abaMistura_text_perct02_Leave(object sender, EventArgs e) { }
        private void abaMistura_text_perct03_TextChanged(object sender, EventArgs e)
        {
            double resultado = 0;
            resultado = Soma_percentual(abaMistura_text_perct01.Text, abaMistura_text_perct02.Text, abaMistura_text_perct03.Text, abaMistura_text_perct04.Text, abaMistura_text_perct05.Text, abaMistura_text_perct06.Text, abaMistura_text_perct07.Text, abaMistura_text_perct08.Text, abaMistura_text_perct09.Text, abaMistura_text_perct10.Text);
            AbaMistura_label_total_mistura.Text = Convert.ToString(resultado);
        }
        private void abaMistura_text_perct01_TextChanged(object sender, EventArgs e)
        {
            double resultado = 0;
            resultado = Soma_percentual(abaMistura_text_perct01.Text, abaMistura_text_perct02.Text, abaMistura_text_perct03.Text, abaMistura_text_perct04.Text, abaMistura_text_perct05.Text, abaMistura_text_perct06.Text, abaMistura_text_perct07.Text, abaMistura_text_perct08.Text, abaMistura_text_perct09.Text, abaMistura_text_perct10.Text);
            AbaMistura_label_total_mistura.Text = Convert.ToString(resultado);
        }
        private void abaMistura_text_perct02_TextChanged(object sender, EventArgs e)
        {
            double resultado = 0;
            resultado = Soma_percentual(abaMistura_text_perct01.Text, abaMistura_text_perct02.Text, abaMistura_text_perct03.Text, abaMistura_text_perct04.Text, abaMistura_text_perct05.Text, abaMistura_text_perct06.Text, abaMistura_text_perct07.Text, abaMistura_text_perct08.Text, abaMistura_text_perct09.Text, abaMistura_text_perct10.Text);
            AbaMistura_label_total_mistura.Text = Convert.ToString(resultado);
        }
        private void abaMistura_text_perct04_TextChanged(object sender, EventArgs e)
        {
            double resultado;
            resultado = Soma_percentual(abaMistura_text_perct01.Text, abaMistura_text_perct02.Text, abaMistura_text_perct03.Text, abaMistura_text_perct04.Text, abaMistura_text_perct05.Text, abaMistura_text_perct06.Text, abaMistura_text_perct07.Text, abaMistura_text_perct08.Text, abaMistura_text_perct09.Text, abaMistura_text_perct10.Text);
            AbaMistura_label_total_mistura.Text = Convert.ToString(resultado);
        }
        private void abaMistura_text_perct05_TextChanged(object sender, EventArgs e)
        {
            double resultado = 0;
            resultado = Soma_percentual(abaMistura_text_perct01.Text, abaMistura_text_perct02.Text, abaMistura_text_perct03.Text, abaMistura_text_perct04.Text, abaMistura_text_perct05.Text, abaMistura_text_perct06.Text, abaMistura_text_perct07.Text, abaMistura_text_perct08.Text, abaMistura_text_perct09.Text, abaMistura_text_perct10.Text);
            AbaMistura_label_total_mistura.Text = Convert.ToString(resultado);
        }
        private void abaMistura_text_perct06_TextChanged(object sender, EventArgs e)
        {
            double resultado = 0;
            resultado = Soma_percentual(abaMistura_text_perct01.Text, abaMistura_text_perct02.Text, abaMistura_text_perct03.Text, abaMistura_text_perct04.Text, abaMistura_text_perct05.Text, abaMistura_text_perct06.Text, abaMistura_text_perct07.Text, abaMistura_text_perct08.Text, abaMistura_text_perct09.Text, abaMistura_text_perct10.Text);
            AbaMistura_label_total_mistura.Text = Convert.ToString(resultado);
        }
        private void abaMistura_text_perct07_TextChanged(object sender, EventArgs e)
        {
            double resultado = 0;
            resultado = Soma_percentual(abaMistura_text_perct01.Text, abaMistura_text_perct02.Text, abaMistura_text_perct03.Text, abaMistura_text_perct04.Text, abaMistura_text_perct05.Text, abaMistura_text_perct06.Text, abaMistura_text_perct07.Text, abaMistura_text_perct08.Text, abaMistura_text_perct09.Text, abaMistura_text_perct10.Text);
            AbaMistura_label_total_mistura.Text = Convert.ToString(resultado);
        }
        private void abaMistura_text_perct08_TextChanged(object sender, EventArgs e)
        {
            double resultado = 0;
            resultado = Soma_percentual(abaMistura_text_perct01.Text, abaMistura_text_perct02.Text, abaMistura_text_perct03.Text, abaMistura_text_perct04.Text, abaMistura_text_perct05.Text, abaMistura_text_perct06.Text, abaMistura_text_perct07.Text, abaMistura_text_perct08.Text, abaMistura_text_perct09.Text, abaMistura_text_perct10.Text);
            AbaMistura_label_total_mistura.Text = Convert.ToString(resultado);
        }
        private void abaMistura_text_perct09_TextChanged(object sender, EventArgs e)
        {
            double resultado = 0;
            resultado = Soma_percentual(abaMistura_text_perct01.Text, abaMistura_text_perct02.Text, abaMistura_text_perct03.Text, abaMistura_text_perct04.Text, abaMistura_text_perct05.Text, abaMistura_text_perct06.Text, abaMistura_text_perct07.Text, abaMistura_text_perct08.Text, abaMistura_text_perct09.Text, abaMistura_text_perct10.Text);
            AbaMistura_label_total_mistura.Text = Convert.ToString(resultado);
        }
        private void abaMistura_text_perct10_TextChanged(object sender, EventArgs e)
        {
            double resultado = 0;
            resultado = Soma_percentual(abaMistura_text_perct01.Text, abaMistura_text_perct02.Text, abaMistura_text_perct03.Text, abaMistura_text_perct04.Text, abaMistura_text_perct05.Text, abaMistura_text_perct06.Text, abaMistura_text_perct07.Text, abaMistura_text_perct08.Text, abaMistura_text_perct09.Text, abaMistura_text_perct10.Text);
            AbaMistura_label_total_mistura.Text = Convert.ToString(resultado);
        }
        private void abaMistura_button_voltar_parada_Click(object sender, EventArgs e)
        {
            tab_menu_apontamento.SelectedTab = tab_apontamento;
            button_mistura_mp.BackColor = Color.LightGreen;

        }
        private void abaMistura_button_ir_consumo_Click(object sender, EventArgs e)
        {
            tab_menu_apontamento.SelectedTab = tab_consumo;
        }

        #endregion // Funcionalidades Mistura

        //------------------------------------------------------------------------------------------

        #region Funções da aba Parada
        private void abaParada_hr_inicio01_ValueChanged(object sender, EventArgs e)
        {
            abaParada_label_hr_total01.Text = Convert.ToString(Calculo_hora(Convert.ToDateTime(abaParada_hr_inicio01.Value), Convert.ToDateTime(abaParada_hr_fim01.Value)));
            TimeSpan resultado = Soma_hora();
            abaParada_label_hr_total.Text = Convert.ToString(resultado);

        }
        private void abaParada_hr_fim01_ValueChanged(object sender, EventArgs e)
        {
            abaParada_label_hr_total01.Text = Convert.ToString(Calculo_hora(Convert.ToDateTime(abaParada_hr_inicio01.Value), Convert.ToDateTime(abaParada_hr_fim01.Value)));
            TimeSpan resultado = Soma_hora();
            abaParada_label_hr_total.Text = Convert.ToString(resultado);
        }
        private void abaParada_hr_inicio02_ValueChanged(object sender, EventArgs e)
        {
            abaParada_label_hr_total02.Text = Convert.ToString(Calculo_hora(Convert.ToDateTime(abaParada_hr_inicio02.Value), Convert.ToDateTime(abaParada_hr_fim02.Value)));
            TimeSpan resultado = Soma_hora();
            abaParada_label_hr_total.Text = Convert.ToString(resultado);
        }
        private void abaParada_hr_fim02_ValueChanged(object sender, EventArgs e)
        {
            abaParada_label_hr_total02.Text = Convert.ToString(Calculo_hora(Convert.ToDateTime(abaParada_hr_inicio02.Value), Convert.ToDateTime(abaParada_hr_fim02.Value)));
            TimeSpan resultado = Soma_hora();
            abaParada_label_hr_total.Text = Convert.ToString(resultado);
        }
        private void abaParada_hr_inicio03_ValueChanged(object sender, EventArgs e)
        {
            abaParada_label_hr_total03.Text = Convert.ToString(Calculo_hora(Convert.ToDateTime(abaParada_hr_inicio03.Value), Convert.ToDateTime(abaParada_hr_fim03.Value)));
            TimeSpan resultado = Soma_hora();
            abaParada_label_hr_total.Text = Convert.ToString(resultado);
        }
        private void abaParada_hr_fim03_ValueChanged(object sender, EventArgs e)
        {
            abaParada_label_hr_total03.Text = Convert.ToString(Calculo_hora(Convert.ToDateTime(abaParada_hr_inicio03.Value), Convert.ToDateTime(abaParada_hr_fim03.Value)));
            TimeSpan resultado = Soma_hora();
            abaParada_label_hr_total.Text = Convert.ToString(resultado);
        }
        private void abaParada_hr_inicio04_ValueChanged(object sender, EventArgs e)
        {
            abaParada_label_hr_total04.Text = Convert.ToString(Calculo_hora(Convert.ToDateTime(abaParada_hr_inicio04.Value), Convert.ToDateTime(abaParada_hr_fim04.Value)));
            TimeSpan resultado = Soma_hora();
            abaParada_label_hr_total.Text = Convert.ToString(resultado);
        }
        private void abaParada_hr_fim04_ValueChanged(object sender, EventArgs e)
        {
            abaParada_label_hr_total04.Text = Convert.ToString(Calculo_hora(Convert.ToDateTime(abaParada_hr_inicio04.Value), Convert.ToDateTime(abaParada_hr_fim04.Value)));
            TimeSpan resultado = Soma_hora();
            abaParada_label_hr_total.Text = Convert.ToString(resultado);
        }
        private void abaParada_hr_inicio05_ValueChanged(object sender, EventArgs e)
        {
            abaParada_label_hr_total05.Text = Convert.ToString(Calculo_hora(Convert.ToDateTime(abaParada_hr_inicio05.Value), Convert.ToDateTime(abaParada_hr_fim05.Value)));
            TimeSpan resultado = Soma_hora();
            abaParada_label_hr_total.Text = Convert.ToString(resultado);
        }
        private void abaParada_hr_fim05_ValueChanged(object sender, EventArgs e)
        {
            abaParada_label_hr_total05.Text = Convert.ToString(Calculo_hora(Convert.ToDateTime(abaParada_hr_inicio05.Value), Convert.ToDateTime(abaParada_hr_fim05.Value)));
            TimeSpan resultado = Soma_hora();
            abaParada_label_hr_total.Text = Convert.ToString(resultado);
        }
        private void abaParada_hr_inicio06_ValueChanged(object sender, EventArgs e)
        {
            abaParada_label_hr_total06.Text = Convert.ToString(Calculo_hora(Convert.ToDateTime(abaParada_hr_inicio06.Value), Convert.ToDateTime(abaParada_hr_fim06.Value)));
            TimeSpan resultado = Soma_hora();
            abaParada_label_hr_total.Text = Convert.ToString(resultado);
        }
        private void abaParada_hr_fim06_ValueChanged(object sender, EventArgs e)
        {
            abaParada_label_hr_total06.Text = Convert.ToString(Calculo_hora(Convert.ToDateTime(abaParada_hr_inicio06.Value), Convert.ToDateTime(abaParada_hr_fim06.Value)));
            TimeSpan resultado = Soma_hora();
            abaParada_label_hr_total.Text = Convert.ToString(resultado);
        }
        private void abaParada_hr_inicio07_ValueChanged(object sender, EventArgs e)
        {
            abaParada_label_hr_total07.Text = Convert.ToString(Calculo_hora(Convert.ToDateTime(abaParada_hr_inicio07.Value), Convert.ToDateTime(abaParada_hr_fim07.Value)));
            TimeSpan resultado = Soma_hora();
            abaParada_label_hr_total.Text = Convert.ToString(resultado);
        }
        private void abaParada_hr_fim07_ValueChanged(object sender, EventArgs e)
        {
            abaParada_label_hr_total07.Text = Convert.ToString(Calculo_hora(Convert.ToDateTime(abaParada_hr_inicio07.Value), Convert.ToDateTime(abaParada_hr_fim07.Value)));
            TimeSpan resultado = Soma_hora();
            abaParada_label_hr_total.Text = Convert.ToString(resultado);
        }
        private void abaParada_hr_inicio08_ValueChanged(object sender, EventArgs e)
        {
            abaParada_label_hr_total08.Text = Convert.ToString(Calculo_hora(Convert.ToDateTime(abaParada_hr_inicio08.Value), Convert.ToDateTime(abaParada_hr_fim08.Value)));
            TimeSpan resultado = Soma_hora();
            abaParada_label_hr_total.Text = Convert.ToString(resultado);
        }
        private void abaParada_hr_fim08_ValueChanged(object sender, EventArgs e)
        {
            abaParada_label_hr_total08.Text = Convert.ToString(Calculo_hora(Convert.ToDateTime(abaParada_hr_inicio08.Value), Convert.ToDateTime(abaParada_hr_fim08.Value)));
            TimeSpan resultado = Soma_hora();
            abaParada_label_hr_total.Text = Convert.ToString(resultado);
        }
        private void abaParada_button_voltar_apontamento_Click(object sender, EventArgs e)
        {
            tab_menu_apontamento.SelectedTab = tab_apontamento;
            button_paradas.BackColor = Color.LightGreen;

        }

        private void abaParada_button_ir_mistura_Click(object sender, EventArgs e)
        {
            tab_menu_apontamento.SelectedTab = tab_mistura;
        }



        #endregion //Funções da aba Parada

        #region Funções da aba Defeitos
        private void AbaDefeitos_button_voltar_apon_Click(object sender, EventArgs e)
        {
            button_defeitos.BackColor = Color.LightGreen;
            tab_menu_apontamento.SelectedTab = tab_apontamento;
        }

        #endregion // aba defeitos


        //------------------------------------------------------------------------------------------
        #region Funcionalidades Aba Pesquisar

        private void Verificar_ordem_estornada()
        {

        }
        private void Carregar_operador_pesquisar()
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

                    this.abaPesquisar_combo_operador.Items.Add(myreader["nome"].ToString());
                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }
        private void Carregar_turno_pesquisar()
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
                    this.abaPesquisar_combo_turno.Items.Add(myreader["turno"].ToString());
                }
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Carregar_material_pesquisar()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_material";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    this.abaPesquisar_combo_material.Items.Add(myreader["descricao_completa"].ToString());

                }

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Carregar_maquina_pesquisar()
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
                    this.abaPesquisar_combo_maq.Items.Add(myreader["descricao_equipamento"].ToString());
                }

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Carregar_campos_apontamento(string id_apontamento)
        {
            //string num_transac = "";

            this.abaApon_label_id_apont.Text = id_apontamento;

            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from estoque_trans where id_estoque_trans =" + Convert.ToInt32(id_apontamento) + "";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {

                    this.combo_empresa.Text = myreader["cod_empresa"].ToString();
                    this.abaApon_label_num_transa.Text = myreader["num_transac"].ToString();
                    this.combo_cod_item.Text = myreader["cod_item"].ToString();
                    this.combo_desc_completa.Text = myreader["cod_descri_completa"].ToString();

                    //cod_descri_reduzida = "" myreader["cod_descri_reduzida"].ToString();
                    //int mes_proces = DateTime.Now.Month = myreader["cod_empresa"].ToString();
                    //int mes_movto = DateTime.Now.Month;
                    //int ano_movto = DateTime.Now.Year;
                    //DateTime dat_proces = DateTime.Today;                    
                    this.dt_final_pro.Value = Convert.ToDateTime(myreader["dat_movto"].ToString());
                    this.text_operacao.Text = myreader["cod_operacao"].ToString();
                    this.combo_ordem_prod.Text = myreader["num_docum"].ToString();
                    this.label_tipo_movimento.Text = myreader["ies_tip_movto"].ToString();
                    this.text_qtd_boa.Text = myreader["qtd_movto"].ToString();
                    //double qtd_real = qtd_movto * (-1) = myreader["num_docum"].ToString(); // mudou aqui 
                    this.text_qtd_fardos.Text = myreader["fardos"].ToString();
                    //double num_secao_requis = 1 = myreader["num_docum"].ToString();
                    this.combo_operadores.Text = myreader["operador"].ToString();
                    this.combo_maquinas.Text = myreader["secao_nome"].ToString();
                    this.combo_local_orig.Text = myreader["cod_local_est_orig"].ToString();
                    this.combo_local_desti.Text = myreader["cod_local_est_dest"].ToString();
                    //string num_lote_orig = myreader["num_docum"].ToString();
                    text_lotes.Text = myreader["num_lote_dest"].ToString();
                    //string ies_sit_est_orig = "L";
                    //string ies_sit_est_dest = "L";
                    this.combo_turnos.Text = myreader["cod_turno"].ToString();
                    //string nom_usuario = myreader["num_docum"].ToString();
                    //string num_prog = this.Name;
                    //double largura_material = myreader["largura_material"].ToString();
                    this.text_bobina_ini.Text = myreader["n_bobina_inical"].ToString();
                    this.text_bobina_fim.Text = myreader["n_bobina_final"].ToString();
                    this.text_velocidade.Text = myreader["velocidade"].ToString();
                    this.text_contador.Text = myreader["contador_fardos"].ToString(); // pq abre msg box
                    //double peso_medio_bobina = 0; // Fazer metodo pra calcular o peso
                    //double peso_total_fardo = 0; // Fazer metodos pra calcular
                    this.hr_inicial_prod.Value = Convert.ToDateTime(myreader["hora_inical"].ToString());
                    this.hr_final_prod.Value = Convert.ToDateTime(myreader["hora_final"].ToString());
                    this.dt_lançamento.Value = Convert.ToDateTime(myreader["data_operac"].ToString());
                    //DateTime hor_operac = Convert.ToDateTime(DateTime.Now) = myreader["hor_operac"].ToString(); 
                    this.label_tipo_material.Text = myreader["Tipo_material"].ToString();
                    this.richText_observacao.Text = myreader["observacao"].ToString();
                    //this.abaPesquisar_combo_operador.Items.Add();                   
                    abaApon_label_num_transa.Text = myreader["num_transac"].ToString();
                    this.combo_cliente_esto.Text = myreader["cliente_apon"].ToString();
                    //num_transac = myreader["num_transac"].ToString();
                }




                conexao.Close();
            }
            catch (Exception)
            {
                //MessageBox.Show("Erro Ao carregar! // " + erro.Message);
            }

        }
        private void Carregar_paradas_apontamento(string num_transac)
        {

            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_paradas_mq where num_transac ='" + num_transac + "'";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    abaParadas_label_maquina.Text = myreader["maquina"].ToString();
                    abaParadas_label_numero_op.Text = myreader["ordem_prod"].ToString();
                    abaParadas_label_operador.Text = myreader["operador"].ToString();
                    abaParadas_label_turno.Text = myreader["turno"].ToString();

                    abaParadas_obs.Text = myreader["observacao"].ToString();

                    if (myreader["campo_marcador"].ToString() == abaParada_combo_parada01.Name)
                    {
                        abaParada_combo_parada01.Text = myreader["descricao_parada"].ToString();
                        abaParada_hr_inicio01.Value = Convert.ToDateTime(myreader["hora_inicio"]).ToUniversalTime();
                        abaParada_hr_fim01.Value = Convert.ToDateTime(myreader["hora_final"]).ToUniversalTime();
                        abaParada_label_hr_total01.Text = Convert.ToDateTime(myreader["total_horas"]).ToString("hh:mm");
                    }

                    if (myreader["campo_marcador"].ToString() == abaParada_combo_parada02.Name)
                    {
                        abaParada_combo_parada02.Text = myreader["descricao_parada"].ToString();
                        abaParada_hr_inicio02.Value = Convert.ToDateTime(myreader["hora_inicio"]).ToUniversalTime();
                        abaParada_hr_fim02.Value = Convert.ToDateTime(myreader["hora_final"]).ToUniversalTime();
                        abaParada_label_hr_total02.Text = Convert.ToDateTime(myreader["total_horas"]).ToString("hh:mm");
                    }

                    if (myreader["campo_marcador"].ToString() == abaParada_combo_parada03.Name)
                    {
                        abaParada_combo_parada03.Text = myreader["descricao_parada"].ToString();
                        abaParada_hr_inicio03.Value = Convert.ToDateTime(myreader["hora_inicio"]).ToUniversalTime();
                        abaParada_hr_fim03.Value = Convert.ToDateTime(myreader["hora_final"]).ToUniversalTime();
                        abaParada_label_hr_total03.Text = Convert.ToDateTime(myreader["total_horas"]).ToString("hh:mm");
                    }

                    if (myreader["campo_marcador"].ToString() == abaParada_combo_parada04.Name)
                    {
                        abaParada_combo_parada04.Text = myreader["descricao_parada"].ToString();
                        abaParada_hr_inicio04.Value = Convert.ToDateTime(myreader["hora_inicio"]).ToUniversalTime();
                        abaParada_hr_fim04.Value = Convert.ToDateTime(myreader["hora_final"]).ToUniversalTime();
                        abaParada_label_hr_total04.Text = Convert.ToDateTime(myreader["total_horas"]).ToString("hh:mm");
                    }

                    if (myreader["campo_marcador"].ToString() == abaParada_combo_parada05.Name)
                    {
                        abaParada_combo_parada05.Text = myreader["descricao_parada"].ToString();
                        abaParada_hr_inicio05.Value = Convert.ToDateTime(myreader["hora_inicio"]).ToUniversalTime();
                        abaParada_hr_fim05.Value = Convert.ToDateTime(myreader["hora_final"]).ToUniversalTime();
                        abaParada_label_hr_total05.Text = Convert.ToDateTime(myreader["total_horas"]).ToString("hh:mm");
                    }

                    if (myreader["campo_marcador"].ToString() == abaParada_combo_parada06.Name)
                    {
                        abaParada_combo_parada06.Text = myreader["descricao_parada"].ToString();
                        abaParada_hr_inicio06.Value = Convert.ToDateTime(myreader["hora_inicio"]).ToUniversalTime();
                        abaParada_hr_fim06.Value = Convert.ToDateTime(myreader["hora_final"]).ToUniversalTime();
                        abaParada_label_hr_total06.Text = Convert.ToDateTime(myreader["total_horas"]).ToString("hh:mm");
                    }

                    if (myreader["campo_marcador"].ToString() == abaParada_combo_parada07.Name)
                    {
                        abaParada_combo_parada07.Text = myreader["descricao_parada"].ToString();
                        abaParada_hr_inicio07.Value = Convert.ToDateTime(myreader["hora_inicio"]).ToUniversalTime();
                        abaParada_hr_fim07.Value = Convert.ToDateTime(myreader["hora_final"]).ToUniversalTime();
                        abaParada_label_hr_total07.Text = Convert.ToDateTime(myreader["total_horas"]).ToString("hh:mm");
                    }

                    if (myreader["campo_marcador"].ToString() == abaParada_combo_parada08.Name)
                    {
                        abaParada_combo_parada08.Text = myreader["descricao_parada"].ToString();
                        abaParada_hr_inicio08.Value = Convert.ToDateTime(myreader["hora_inicio"]).ToUniversalTime();
                        abaParada_hr_fim08.Value = Convert.ToDateTime(myreader["hora_final"]).ToUniversalTime();
                        abaParada_label_hr_total08.Text = Convert.ToDateTime(myreader["total_horas"]).ToString("hh:mm");
                    }

                }

                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro Ao carregar paradas ! // " + erro.Message);
            }

        }
        private void Carregar_defeitos_apontamento(string num_transac)
        {

            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_defeitos_mq where num_transac ='" + num_transac + "'";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();             


                while (myreader.Read())
                {
                    label_AbaDefeitos_maq.Text = myreader["maquina"].ToString();
                    label_AbaDefeitos_ordem.Text = myreader["ordem_prod"].ToString();
                    label_AbaDefeitos_operador.Text = myreader["operador"].ToString();
                    label_AbaDefeitos_turno.Text = myreader["turno"].ToString();
                    label_AbaDefeitos_data.Text = myreader["data_lanc"].ToString();

                    richText_label_AbaDefeitos_obs.Text = myreader["observacao"].ToString();

                    if (myreader["campo_marcador"].ToString() == AbaDefeito_combo_defeito01.Name)
                    {
                        AbaDefeito_combo_defeito01.Text = myreader["descricao_defeitos"].ToString();
                        AbaDefeito_text_qtd01.Text = myreader["qtd_defeitos"].ToString();
                    }

                    if (myreader["campo_marcador"].ToString() == AbaDefeito_combo_defeito02.Name)
                    {
                        AbaDefeito_combo_defeito02.Text = myreader["descricao_defeitos"].ToString();
                        AbaDefeito_text_qtd02.Text = myreader["qtd_defeitos"].ToString();
                    }

                    if (myreader["campo_marcador"].ToString() == AbaDefeito_combo_defeito03.Name)
                    {
                        AbaDefeito_combo_defeito03.Text = myreader["descricao_defeitos"].ToString();
                        AbaDefeito_text_qtd03.Text = myreader["qtd_defeitos"].ToString();
                    }

                    if (myreader["campo_marcador"].ToString() == AbaDefeito_combo_defeito04.Name)
                    {
                        AbaDefeito_combo_defeito04.Text = myreader["descricao_defeitos"].ToString();
                        AbaDefeito_text_qtd04.Text = myreader["qtd_defeitos"].ToString();
                    }

                    if (myreader["campo_marcador"].ToString() == AbaDefeito_combo_defeito05.Name)
                    {
                        AbaDefeito_combo_defeito05.Text = myreader["descricao_defeitos"].ToString();
                        AbaDefeito_text_qtd05.Text = myreader["qtd_defeitos"].ToString();
                    }

                    if (myreader["campo_marcador"].ToString() == AbaDefeito_combo_defeito06.Name)
                    {
                        AbaDefeito_combo_defeito06.Text = myreader["descricao_defeitos"].ToString();
                        AbaDefeito_text_qtd06.Text = myreader["qtd_defeitos"].ToString();
                    }

                    if (myreader["campo_marcador"].ToString() == AbaDefeito_combo_defeito07.Name)
                    {
                        AbaDefeito_combo_defeito07.Text = myreader["descricao_defeitos"].ToString();
                        AbaDefeito_text_qtd07.Text = myreader["qtd_defeitos"].ToString();
                    }

                    if (myreader["campo_marcador"].ToString() == AbaDefeito_combo_defeito08.Name)
                    {
                        AbaDefeito_combo_defeito08.Text = myreader["descricao_defeitos"].ToString();
                        AbaDefeito_text_qtd08.Text = myreader["qtd_defeitos"].ToString();
                    }

                    if (myreader["campo_marcador"].ToString() == AbaDefeito_combo_defeito09.Name)
                    {
                        AbaDefeito_combo_defeito09.Text = myreader["descricao_defeitos"].ToString();
                        AbaDefeito_text_qtd09.Text = myreader["qtd_defeitos"].ToString();
                    }

                    if (myreader["campo_marcador"].ToString() == AbaDefeito_combo_defeito10.Name)
                    {
                        AbaDefeito_combo_defeito10.Text = myreader["descricao_defeitos"].ToString();
                        AbaDefeito_text_qtd10.Text = myreader["qtd_defeitos"].ToString();
                    }

                }

                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro Ao carregar paradas ! // " + erro.Message);
            }

        }
        private void Carregar_consumo_mp_apontamento()
        {
            // ll
        }

        private void Carregar_mistura_apontamento(string num_transac)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_mp_apon where num_transac ='" + num_transac + "'";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    AbaMistura_label_mq.Text = myreader["maquina"].ToString();
                    AbaMistura_label_op.Text = myreader["ordem_prod"].ToString();
                    AbaMistura_label_producao.Text = myreader["producao"].ToString();

                    AbaMistura_label_operador.Text = myreader["operador"].ToString();
                    AbaMistura_label_turno.Text = myreader["turno"].ToString();
                    AbaMistura_label_data_lanc.Text = Convert.ToDateTime(myreader["data_lancamento"]).ToString("dd/MM/yyyy");


                    if (myreader["campo_marcador"].ToString() == abaMistura_combo_mp01.Name)
                    {
                        abaMistura_combo_mp01.Text = myreader["materia_prima"].ToString();
                        abaMistura_text_perct01.Text = Convert.ToString(Convert.ToDouble(myreader["percentual"]) * 100);
                    }

                    if (myreader["campo_marcador"].ToString() == abaMistura_combo_mp02.Name)
                    {
                        abaMistura_combo_mp02.Text = myreader["materia_prima"].ToString();
                        abaMistura_text_perct02.Text = Convert.ToString(Convert.ToDouble(myreader["percentual"]) * 100);
                    }

                    if (myreader["campo_marcador"].ToString() == abaMistura_combo_mp03.Name)
                    {
                        abaMistura_combo_mp03.Text = myreader["materia_prima"].ToString();
                        abaMistura_text_perct03.Text = Convert.ToString(Convert.ToDouble(myreader["percentual"]) * 100);
                    }

                    if (myreader["campo_marcador"].ToString() == abaMistura_combo_mp04.Name)
                    {
                        abaMistura_combo_mp04.Text = myreader["materia_prima"].ToString();
                        abaMistura_text_perct04.Text = Convert.ToString(Convert.ToDouble(myreader["percentual"]) * 100);
                    }

                    if (myreader["campo_marcador"].ToString() == abaMistura_combo_mp05.Name)
                    {
                        abaMistura_combo_mp05.Text = myreader["materia_prima"].ToString();
                        abaMistura_text_perct05.Text = Convert.ToString(Convert.ToDouble(myreader["percentual"]) * 100);
                    }

                    if (myreader["campo_marcador"].ToString() == abaMistura_combo_mp06.Name)
                    {
                        abaMistura_combo_mp06.Text = myreader["materia_prima"].ToString();
                        abaMistura_text_perct06.Text = Convert.ToString(Convert.ToDouble(myreader["percentual"]) * 100);
                    }

                    if (myreader["campo_marcador"].ToString() == abaMistura_combo_mp07.Name)
                    {
                        abaMistura_combo_mp07.Text = myreader["materia_prima"].ToString();
                        abaMistura_text_perct07.Text = Convert.ToString(Convert.ToDouble(myreader["percentual"]) * 100);
                    }

                    if (myreader["campo_marcador"].ToString() == abaMistura_combo_mp08.Name)
                    {
                        abaMistura_combo_mp08.Text = myreader["materia_prima"].ToString();
                        abaMistura_text_perct08.Text = Convert.ToString(Convert.ToDouble(myreader["percentual"]) * 100);
                    }

                    if (myreader["campo_marcador"].ToString() == abaMistura_combo_mp09.Name)
                    {
                        abaMistura_combo_mp09.Text = myreader["materia_prima"].ToString();
                        abaMistura_text_perct09.Text = Convert.ToString(Convert.ToDouble(myreader["percentual"]) * 100);
                    }

                    if (myreader["campo_marcador"].ToString() == abaMistura_combo_mp10.Name)
                    {
                        abaMistura_combo_mp10.Text = myreader["materia_prima"].ToString();
                        abaMistura_text_perct10.Text = Convert.ToString(Convert.ToDouble(myreader["percentual"]) * 100);
                    }


                }

                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar Mistura! // " + erro.Message);
            }

        }
        private void Carregar_grid_pesquisar()
        {
            //Achar um jeito de carregar somente ordens com status normal
            //excluir do filtro ordems que foram estornadas
            //Achar um jeito de identificar ordens ja estornadas
            try
            {
                string cod_operacao = "APON";
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select id_estoque_trans, cod_descri_completa, cod_operacao, num_docum, qtd_real, fardos, operador, secao_nome, cod_turno, mes_movto, ano_movto, dat_movto from estoque_trans " +
                    "where (cod_operacao='" + cod_operacao + "') AND (qtd_real >= 0 AND status_estorno = 0)";

                // Verificar se ordem e qtd é igual 
                // se for igual não puxar

                OleDbConnection connection = new OleDbConnection(conecta_string);
                OleDbDataAdapter myadapter = new OleDbDataAdapter(comando_sql, connection);
                DataTable dt = new DataTable("estoque_trans");
                myadapter.Fill(dt);
                DataView dv = dt.DefaultView;
                abaPesquisar_Grid_apon.DataSource = dt;
                connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }


        private void Filtrar_ano(int ano_movto)
        {
            try
            {
                string cod_operacao = "APON";
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select id_estoque_trans, cod_descri_completa, cod_operacao, num_docum, qtd_real, fardos, operador, secao_nome, cod_turno, mes_movto, ano_movto, dat_movto from estoque_trans where cod_operacao='" + cod_operacao + "' AND qtd_real >= 0 ";

                OleDbConnection connection = new OleDbConnection(conecta_string);
                OleDbDataAdapter myadapter = new OleDbDataAdapter(comando_sql, connection);
                DataTable dt = new DataTable("estoque_trans");
                myadapter.Fill(dt);
                DataView dv = dt.DefaultView;



                //dv.RowFilter = string.Format("ano_movto like '%{0}%'", ano_movto);
                dv.RowFilter = string.Format("CONVERT(ano_movto, 'System.String') like '%{0}%'", ano_movto.ToString());
                abaPesquisar_Grid_apon.DataSource = dv.ToTable();


                connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }


        private void Filtrar_mes_ano(int mes_movto)
        {
            try
            {
                string cod_operacao = "APON";
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select id_estoque_trans, cod_descri_completa, cod_operacao, num_docum, qtd_real, fardos, operador, secao_nome, cod_turno, mes_movto, ano_movto, dat_movto from estoque_trans where cod_operacao='" + cod_operacao + "' AND qtd_real >= 0 ";

                OleDbConnection connection = new OleDbConnection(conecta_string);
                OleDbDataAdapter myadapter = new OleDbDataAdapter(comando_sql, connection);
                DataTable dt = new DataTable("estoque_trans");
                myadapter.Fill(dt);
                DataView dv = dt.DefaultView;

                //dv.RowFilter = string.Format("mes_movto like '%{0}%'", mes_movto);
                dv.RowFilter = string.Format("CONVERT(mes_movto, 'System.String') like '%{0}%'", mes_movto.ToString());
                abaPesquisar_Grid_apon.DataSource = dv.ToTable();

                //dv.RowFilter = string.Format("CONVERT(ano_movto, 'System.String') like '%{0}%'", ano_movto.ToString());
                //abaPesquisar_Grid_apon.DataSource = dv.ToTable();




                connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }


        private void Filtrar_grid_pesquisar(string num_docum, string data_lancamento, string operador, string turno, string descricao_material, string maquina)
        {

            try
            {
                string cod_operacao = "APON";
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select id_estoque_trans, cod_descri_completa, cod_operacao, num_docum, qtd_real, fardos, operador, secao_nome, cod_turno, mes_movto, ano_movto, dat_movto from estoque_trans where cod_operacao='" + cod_operacao + "' AND qtd_real >= 0 ";

                OleDbConnection connection = new OleDbConnection(conecta_string);
                OleDbDataAdapter myadapter = new OleDbDataAdapter(comando_sql, connection);
                DataTable dt = new DataTable("estoque_trans");
                myadapter.Fill(dt);
                DataView dv = dt.DefaultView;

                if (num_docum != string.Empty)
                {
                    dv.RowFilter = string.Format("CONVERT(num_docum, 'System.String') like '%{0}%'", num_docum);
                    abaPesquisar_Grid_apon.DataSource = dv.ToTable();
                }

                if (operador != string.Empty)
                {
                    dv.RowFilter = string.Format("operador like '%{0}%'", operador);
                    abaPesquisar_Grid_apon.DataSource = dv.ToTable();
                }
                if (turno != string.Empty)
                {
                    dv.RowFilter = string.Format("cod_turno like '%{0}%'", turno);
                    abaPesquisar_Grid_apon.DataSource = dv.ToTable();
                }

                if (descricao_material != string.Empty)
                {
                    dv.RowFilter = string.Format("cod_descri_completa like '%{0}%'", descricao_material);
                    abaPesquisar_Grid_apon.DataSource = dv.ToTable();
                }

                if (maquina != string.Empty)
                {
                    dv.RowFilter = string.Format("secao_nome like '%{0}%'", maquina);
                    abaPesquisar_Grid_apon.DataSource = dv.ToTable();
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
        private void abaPesquisar_button_pesquisar_Click(object sender, EventArgs e)
        {
            Carregar_grid_pesquisar();
        }

        private void abaPesquisar_button_Click(object sender, EventArgs e)
        {
            Filtrar_grid_pesquisar(abaPesquisar_text_ordem.Text, abaPesquisar_text_dt_lanc.Text, abaPesquisar_combo_operador.Text, abaPesquisar_combo_turno.Text, abaPesquisar_combo_material.Text, abaPesquisar_combo_maq.Text);
        }


        #endregion
        //------------------------------------------------------------------------------------------




        #endregion

        private void abaPesquisar_Grid_apon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id_apontamento = abaPesquisar_Grid_apon.CurrentRow.Cells[0].Value.ToString();
            tab_menu_apontamento.SelectedTab = tab_apontamento;

            Carregar_campos_apontamento(id_apontamento);
            Carregar_paradas_apontamento(abaApon_label_num_transa.Text);
            Carregar_defeitos_apontamento(abaApon_label_num_transa.Text);
            Carregar_mistura_apontamento(abaApon_label_num_transa.Text);

            Carregar_grid(combo_desc_completa.Text, combo_cliente_esto.Text, combo_maquinas.Text);
            Calcular_qtd_total_grid();



        }

        private void cadItensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CAD01 cad_material = new CAD01();
            cad_material.ShowDialog();
        }

        private void maquinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_janela_cad_equipamentos cad_equipamento = new Form_janela_cad_equipamentos();
            cad_equipamento.ShowDialog();
        }

        private void turnosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void operadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_janela_cad_operador cad_operador = new Form_janela_cad_operador();
            cad_operador.ShowDialog();
        }

        private void operaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void defeitosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_janela_cad_defeitos cad_defeitos = new Form_janela_cad_defeitos();
            cad_defeitos.ShowDialog();
        }

        private void paradasToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void etruturaDoItemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void abaPesquisar_combo_mes_lanc_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtrar_mes_ano(Convert.ToInt32(abaPesquisar_combo_mes_lanc.Text));
        }

        private void abaPesquisar_text_ano_lanc_Leave(object sender, EventArgs e)
        {
            Filtrar_ano(Convert.ToInt32(abaPesquisar_text_ano_lanc.Text));
        }
    }
}
