using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;


namespace JP4
{
    public partial class CAD01 : Form
    {
        public CAD01()
        {
            InitializeComponent();

            //Controles
            carregar_grupo_estoque();
            carregar_tipo_material();
            carregar_unidade_medida();
            carregar_status_material();
            carregar_local_estoque();
            carregar_local_aplicacao();
            carregar_empresa();
            //

            // botoes
            Bloquear_controles();
            //

            //
            Carregar_status_material();
            Carregar_descri_completa();
            Carregar_cod_item();
            Carregar_grupo_estoque();

            Carregar_grid();

            //Carregar_descricao_grupo_estoque("03");

        }


        #region Aba procurar

        #region Metodos comboBox
        private void Carregar_descricao_grupo_estoque(string codigo_grupo)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_grupo_estoque where codigo_grupo ='" + codigo_grupo + "'";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    label_descri_grupo_estoque.Text = myreader["nome_grupo"].ToString();
                }
                conexao.Close();



            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Carregar_grupo_estoque()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_grupo_estoque";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    this.combo_grupo_estoque.Items.Add(myreader["codigo_grupo"].ToString());
                }

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Carregar_status_material()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_status";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    this.combo_status_cad_item.Items.Add(myreader["status_material"].ToString());

                }

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Carregar_descri_completa()
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
                    this.combo_descri_completa.Items.Add(myreader["descricao_completa"].ToString());

                }

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Carregar_cod_item()
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
                    this.combo_cod_item.Items.Add(myreader["codigo_item"].ToString());

                }

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Carregar_grid()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select cadastro_id, codigo_item, status_item, descricao_completa, grupo, tipo_material from db_cadastro_material";

                OleDbConnection connection = new OleDbConnection(conecta_string);
                OleDbDataAdapter myadapter = new OleDbDataAdapter(comando_sql, connection);
                DataTable dt = new DataTable("db_estrutura");
                myadapter.Fill(dt);
                DataView dv = dt.DefaultView;
                grid_cadastro.DataSource = dt;
                connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        #endregion

        #region Metodos adicionais
        private void Filtrar_grid(string codigo_item, string status_item, string grupo_item, string descri_completa)
        {

            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select cadastro_id, codigo_item, status_item, descricao_completa, grupo, tipo_material from db_cadastro_material";

                OleDbConnection connection = new OleDbConnection(conecta_string);
                OleDbDataAdapter myadapter = new OleDbDataAdapter(comando_sql, connection);
                DataTable dt = new DataTable("db_estrutura");

                myadapter.Fill(dt);

                DataView dv = dt.DefaultView;

                if (codigo_item != string.Empty)
                {
                    dv.RowFilter = string.Format("codigo_item like '%{0}%'", codigo_item);
                    grid_cadastro.DataSource = dv.ToTable();
                }
                if (status_item != string.Empty)
                {
                    dv.RowFilter = string.Format("status_item like '%{0}%'", status_item);
                    grid_cadastro.DataSource = dv.ToTable();
                }
                if (grupo_item != string.Empty)
                {
                    dv.RowFilter = string.Format("grupo like '%{0}%'", grupo_item);
                    grid_cadastro.DataSource = dv.ToTable();
                }
                if (descri_completa != string.Empty)
                {
                    dv.RowFilter = string.Format("descricao_completa like '%{0}%'", descri_completa);
                    grid_cadastro.DataSource = dv.ToTable();
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

        private void Carrega_controles(string descricao_completa)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_material where descricao_completa ='" + descricao_completa + "'";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    combo_cod_item.Text = myreader["codigo_item"].ToString();
                    combo_status.Text = myreader["status_item"].ToString();
                    combo_grupo_estoque.Text = myreader["grupo"].ToString();

                }

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void Carregar_descricao_grupo(string descricao_completa)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_grupo_estoque where codigo_grupo = '" + descricao_completa + "'";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    this.label_descri_grupo.Text = myreader["nome_grupo"].ToString();
                }

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void Carrega_descricao_undMedida(string unidade)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_unidade_medida where unidade = '" + unidade + "'";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    text_descri_unidade.Text = myreader["descricao"].ToString();
                }

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void Limpar_filtro()
        {

            combo_cod_item.Text = string.Empty;
            combo_status.Text = string.Empty;
            combo_grupo_estoque.Text = string.Empty;
            combo_descri_completa.Text = string.Empty;

            Carregar_grid();
        }

        #endregion

        #region Botoes aba buscar
        private void button_editar_Click(object sender, EventArgs e)
        {
            string idCliente = grid_cadastro.CurrentRow.Cells[0].Value.ToString();
            tab_cadastro_material.SelectedTab = tab_cadastro_item;
            Carrega_campos(idCliente);

        }
        private void button_limpar_filtro_Click_1(object sender, EventArgs e)
        {
            Limpar_filtro();
        }
        private void button_filtrar_Click_1(object sender, EventArgs e)
        {
            Filtrar_grid(combo_cod_item.Text, combo_status.Text, combo_grupo_estoque.Text, combo_descri_completa.Text);
        }

        #endregion


        private void combo_descri_completa_SelectedIndexChanged(object sender, EventArgs e)
        {
            Carrega_controles(combo_descri_completa.Text);
        }

        private void combo_grupo_estoque_SelectedIndexChanged(object sender, EventArgs e)
        {
            Carregar_descricao_grupo(combo_grupo_estoque.Text);
        }

        private void grid_cadastro_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string idCliente = grid_cadastro.CurrentRow.Cells[0].Value.ToString();
            tab_cadastro_material.SelectedTab = tab_cadastro_item;
            Carrega_campos(idCliente);

        }

        #endregion


        #region Carregar controles
        private void carregar_grupo_estoque()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_grupo_estoque";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    this.combo_grupo_material.Items.Add(myreader["codigo_grupo"].ToString());

                }

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void carregar_tipo_material()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_tipo_material";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    this.combo_tipo_material.Items.Add(myreader["tipo_material"].ToString());

                }

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }
        private void carregar_unidade_medida()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_unidade_medida";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    this.combo_und_medida.Items.Add(myreader["unidade"].ToString());

                }

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void carregar_status_material()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_status";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    this.combo_status.Items.Add(myreader["status_material"].ToString());

                }

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void carregar_local_estoque()
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
                    this.combo_local_estoque.Items.Add(myreader["local_estoque"].ToString());

                }

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void carregar_local_aplicacao()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_local_aplicacao";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    this.combo_local_aplicacao.Items.Add(myreader["local_aplicao"].ToString());

                }

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void carregar_empresa()
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
        #endregion

        #region Metodos de salvar / modificar / exluir /  limpar/ check controles
        private void Bloquear_controles()
        {
            this.combo_grupo_material.Enabled = false;
            this.combo_tipo_material.Enabled = false;
            this.text_cod_item.Enabled = false;
            this.combo_und_medida.Enabled = false;
            this.text_descri_unidade.Enabled = false;

            this.text_descr_reduzida.Enabled = false;
            this.text_descr_completa.Enabled = false;
            this.combo_status.Enabled = false;
            this.text_qtd_embala.Enabled = false;
            this.text_num_sacos.Enabled = false;
            this.text_fator_conver.Enabled = false;
            this.text_fator_conver.Enabled = false;
            this.text_peso_minimo.Enabled = false;
            this.text_peso_padrao.Enabled = false;
            this.text_peso_maximo.Enabled = false;

            this.text_altura.Enabled = false;
            this.text_comprimento.Enabled = false;
            this.text_largura.Enabled = false;
            this.text_densidade.Enabled = false;
            this.text_espessura.Enabled = false;

            this.combo_local_aplicacao.Enabled = false;
            this.combo_local_estoque.Enabled = false;

            check_estrutura_SIM.Enabled = false;
            check_estrutura_NAO.Enabled = false;

            this.combo_empresa.Enabled = false;

        }
        private void Desbloquear_controles()
        {
            this.combo_grupo_material.Enabled = true;
            this.combo_tipo_material.Enabled = true;
            this.text_cod_item.Enabled = true;
            this.combo_und_medida.Enabled = true;
            this.text_descri_unidade.Enabled = true;

            this.text_descr_reduzida.Enabled = true;
            this.text_descr_completa.Enabled = true;
            this.combo_status.Enabled = true;
            this.text_qtd_embala.Enabled = true;
            this.text_num_sacos.Enabled = true;
            this.text_fator_conver.Enabled = true;
            this.text_fator_conver.Enabled = true;
            this.text_peso_minimo.Enabled = true;
            this.text_peso_padrao.Enabled = true;
            this.text_peso_maximo.Enabled = true;

            this.text_altura.Enabled = true;
            this.text_comprimento.Enabled = true;
            this.text_largura.Enabled = true;
            this.text_densidade.Enabled = true;
            this.text_espessura.Enabled = true;

            check_estrutura_SIM.Enabled = true;
            check_estrutura_NAO.Enabled = true;

            this.combo_local_aplicacao.Enabled = true;
            this.combo_local_estoque.Enabled = true;

            this.combo_empresa.Enabled = true;
        }
        private void limpar_campos()
        {
            combo_grupo_material.Text = string.Empty;
            combo_tipo_material.Text = string.Empty;
            text_cod_item.Text = string.Empty;
            combo_und_medida.Text = string.Empty;
            text_descri_unidade.Text = string.Empty;

            text_descr_reduzida.Text = string.Empty;
            text_descr_completa.Text = string.Empty;
            combo_status.Text = string.Empty;
            text_qtd_embala.Text = string.Empty;
            text_num_sacos.Text = string.Empty;
            text_fator_conver.Text = string.Empty;
            text_fator_conver.Text = string.Empty;
            text_peso_minimo.Text = string.Empty;
            text_peso_padrao.Text = string.Empty;
            text_peso_maximo.Text = string.Empty;

            text_altura.Text = string.Empty;
            text_comprimento.Text = string.Empty;
            text_largura.Text = string.Empty;
            text_densidade.Text = string.Empty;
            text_espessura.Text = string.Empty;

            combo_local_aplicacao.Text = string.Empty;
            combo_local_estoque.Text = string.Empty;

            combo_empresa.Text = string.Empty;

            check_estrutura_SIM.Checked = false;
            check_estrutura_NAO.Checked = false;

            label_grupo_estoque_id.Text = string.Empty;
            label_descri_grupo_estoque.Text = string.Empty;

            abaCadastro_label_id_cadastro.Text = "0000";
            

        }
        private void verifica_campos()
        {

        }

        private int Verifica_duplicados(string cod_item)
        {
            string codigo_item01 = "";
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_material where codigo_item ='" + cod_item + "'";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    codigo_item01 = myreader["codigo_item"].ToString();

                }


                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

            if (codigo_item01 == cod_item)
            {
                return 1;
            }
            else
            {
                return 0;
            }



        }
        private void Atualizar_cadastro(string id_cadastro)
        {
            string codigo_item = text_cod_item.Text;
            string status_item = combo_status.Text;
            string grupo = combo_grupo_material.Text;
            string descricao_reduzida = text_descr_reduzida.Text;
            string descricao_completa = text_descr_completa.Text;
            string tipo_material = combo_tipo_material.Text;

            double qtd_embala = Convert.ToDouble(text_qtd_embala.Text);
            double fator_multi = Convert.ToDouble(text_fator_conver.Text);
            double peso_minimo = Convert.ToDouble(text_peso_minimo.Text);
            double peso_padrao = Convert.ToDouble(text_peso_padrao.Text);
            double peso_maximo = Convert.ToDouble(text_peso_maximo.Text);

            string unidade_medida = combo_und_medida.Text;

            double altura = Convert.ToDouble(text_altura.Text);
            double comprimento = Convert.ToDouble(text_comprimento.Text);
            double largura = Convert.ToDouble(text_largura.Text);
            double densidade = Convert.ToDouble(text_densidade.Text);
            double espessura = Convert.ToDouble(text_espessura.Text);

            int numero_sacos = Convert.ToInt32(text_num_sacos.Text);

            DateTime data_modificacao = Convert.ToDateTime(dt_modificacao.Value);

            string local_aplicacao = combo_local_aplicacao.Text;
            string local_estoque = combo_local_estoque.Text;
            DateTime data_cadastro = DateTime.Today;

            int tem_estrutura = 2;

            if (check_estrutura_SIM.Checked == true)
            {
                tem_estrutura = 1;
            }

            if (check_estrutura_NAO.Checked == true)
            {
                tem_estrutura = 0;
            }

            string empresa = combo_empresa.Text;
            //------------------------------


            try
            {
                string comando_sql;

                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                OleDbConnection conexao = new OleDbConnection(conecta_string);
                conexao.Open();

                comando_sql = "UPDATE db_cadastro_material SET " +
                    "codigo_item='" + codigo_item +
                    "', status_item='" + status_item +
                    "', grupo='" + grupo +
                    "', descricao_reduzida='" + descricao_reduzida +
                    "', descricao_completa='" + descricao_completa +
                    "', tipo_material='" + tipo_material +
                    "', qtd_embala='" + qtd_embala +
                    "', fator_multi='" + fator_multi +
                    "', peso_minimo='" + peso_minimo +
                    "', peso_padrao='" + peso_padrao +
                    "', peso_maximo='" + peso_maximo +
                    "', unidade_medida='" + unidade_medida +
                    "', altura='" + altura +
                    "', comprimento='" + comprimento +
                    "', largura='" + largura +
                    "', densidade='" + densidade +
                    "', espessura='" + espessura +
                    "', numero_sacos='" + numero_sacos +
                    "', data_modificacao='" + data_modificacao +
                    "', local_aplicacao='" + local_aplicacao +
                    "', local_estoque='" + local_estoque +
                    "', data_cadastro='" + data_cadastro +
                    "', tem_estrutura='" + tem_estrutura +
                    "', empresa='" + empresa +
                    "' WHERE cadastro_id=" + Convert.ToInt64(id_cadastro) + "";

                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Salvar_cadastro()
        {

            char[] charsToTrim = { '*',' ', '\'' };

            string codigo_item = text_cod_item.Text.Trim(charsToTrim);
            string status_item = combo_status.Text.Trim(charsToTrim);
            string grupo = combo_grupo_material.Text;
            string descricao_reduzida = text_descr_reduzida.Text.Trim(charsToTrim);
            string descricao_completa = text_descr_completa.Text.Trim(charsToTrim);
            string tipo_material = combo_tipo_material.Text.Trim(charsToTrim);

            double qtd_embala = Convert.ToDouble(text_qtd_embala.Text);
            double fator_multi = Convert.ToDouble(text_fator_conver.Text);
            double peso_minimo = Convert.ToDouble(text_peso_minimo.Text);
            double peso_padrao = Convert.ToDouble(text_peso_padrao.Text);
            double peso_maximo = Convert.ToDouble(text_peso_maximo.Text);

            string unidade_medida = combo_und_medida.Text.Trim(charsToTrim);

            double altura = Convert.ToDouble(text_altura.Text);
            double comprimento = Convert.ToDouble(text_comprimento.Text);
            double largura = Convert.ToDouble(text_largura.Text);
            double densidade = Convert.ToDouble(text_densidade.Text);
            double espessura = Convert.ToDouble(text_espessura.Text);

            int numero_sacos = Convert.ToInt32(text_num_sacos.Text);

            DateTime data_modificacao = Convert.ToDateTime(dt_modificacao.Value);

            string local_aplicacao = combo_local_aplicacao.Text;
            string local_estoque = combo_local_estoque.Text;
            DateTime data_cadastro = DateTime.Today;

            int tem_estrutura = 2;

            if (check_estrutura_SIM.Checked == true)
            {
                tem_estrutura = 1;
            }

            if (check_estrutura_NAO.Checked == true)
            {
                tem_estrutura = 0;
            }

            string empresa = combo_empresa.Text;
            //----------------------------------------------

            int restulado = Verifica_duplicados(codigo_item);

            if (restulado == 1)
            {
                MessageBox.Show("Já existe cadastro do item");
            }
            else
            {
                try
                {
                    string comando_sql;

                    string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "INSERT INTO db_cadastro_material(codigo_item, status_item, grupo, descricao_reduzida, descricao_completa, tipo_material, qtd_embala, fator_multi, peso_minimo, peso_padrao, peso_maximo, unidade_medida, altura, comprimento, largura, densidade, espessura, numero_sacos, data_modificacao, local_aplicacao, local_estoque, data_cadastro, tem_estrutura, empresa) " +
                    "VALUES('" + codigo_item + "','" + status_item + "','" + grupo + "','" + descricao_reduzida + "','" + descricao_completa + "','" + tipo_material + "','" + qtd_embala + "','" + fator_multi + "','" + peso_minimo + "','" + peso_padrao + "','" + peso_maximo + "','" + unidade_medida + "','" + altura + "','" + comprimento + "','" + largura + "','" + densidade + "','" + espessura + "','" + numero_sacos + "','" + data_modificacao + "','" + local_aplicacao + "','" + local_estoque + "','" + data_cadastro + "','" + tem_estrutura + "','" + empresa + "')";

                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();

                    conexao.Close();
                    MessageBox.Show("Salvo com Sucesso!!");
                    //Limpar_campos();

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
        }
        private void Deletar_cadastro(string cadastro_id)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                OleDbConnection conexao = new OleDbConnection(conecta_string);
                conexao.Open();

                string comando_sql;

                comando_sql = "DELETE FROM db_cadastro_material WHERE cadastro_id = " + cadastro_id;

                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();

                MessageBox.Show("Deletado com sucesso!");


            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Carrega_campos(string id_cadastro)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_material where cadastro_id =" + Convert.ToInt64(id_cadastro) + "";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {

                    // this.combo_und_medida.Items.Add(myreader["unidade"].ToString());
                    abaCadastro_label_id_cadastro.Text = myreader["cadastro_id"].ToString();
                    text_cod_item.Text = myreader["codigo_item"].ToString();
                    combo_status.Text = myreader["status_item"].ToString();
                    combo_grupo_material.Text = myreader["grupo"].ToString();
                    text_descr_reduzida.Text = myreader["descricao_reduzida"].ToString();
                    text_descr_completa.Text = myreader["descricao_completa"].ToString();
                    combo_tipo_material.Text = myreader["tipo_material"].ToString();

                    text_qtd_embala.Text = myreader["qtd_embala"].ToString();
                    text_fator_conver.Text = myreader["fator_multi"].ToString();
                    text_peso_minimo.Text = myreader["peso_minimo"].ToString();
                    text_peso_padrao.Text = myreader["peso_padrao"].ToString();
                    text_peso_maximo.Text = myreader["peso_maximo"].ToString();

                    combo_und_medida.Text = myreader["unidade_medida"].ToString();

                    text_altura.Text = myreader["altura"].ToString();
                    text_comprimento.Text = myreader["comprimento"].ToString();
                    text_largura.Text = myreader["largura"].ToString();
                    text_densidade.Text = myreader["densidade"].ToString();
                    text_espessura.Text = myreader["espessura"].ToString();

                    text_num_sacos.Text = myreader["numero_sacos"].ToString();

                    dt_modificacao.Text = myreader["data_modificacao"].ToString();

                    combo_local_aplicacao.Text = myreader["local_aplicacao"].ToString();
                    combo_local_estoque.Text = myreader["local_estoque"].ToString();
                    //myreader["data_cadastro"].ToString();
                    //

                    if (Convert.ToInt32(myreader["tem_estrutura"].ToString()) == 1)
                    {
                        check_estrutura_SIM.Checked = true;
                        check_estrutura_NAO.Checked = false;

                    }
                    else
                    {
                        check_estrutura_SIM.Checked = false;
                        check_estrutura_NAO.Checked = true;
                    }

                    combo_empresa.Text = myreader["empresa"].ToString();
                }

                Carregar_descricao_grupo_estoque(combo_grupo_material.Text);
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }


        }
        #endregion

        private void button_cadastrar_Click(object sender, EventArgs e)
        {
            Desbloquear_controles();
            limpar_campos();
        }

        private void check_estrutura_SIM_CheckedChanged(object sender, EventArgs e)
        {
            check_estrutura_NAO.Checked = false;
        }

        private void check_estrutura_NAO_CheckedChanged(object sender, EventArgs e)
        {
            check_estrutura_SIM.Checked = false;
        }

        private void button_atualizar_cad_Click(object sender, EventArgs e)
        {
            if (abaCadastro_label_id_cadastro.Text == "0000")
            {
                DialogResult resposta = MessageBox.Show(this, "Deseja cadastrar novo item!", "Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                    Salvar_cadastro();
                    limpar_campos();

            }

            if (abaCadastro_label_id_cadastro.Text != "0000")
            {
                Atualizar_cadastro(abaCadastro_label_id_cadastro.Text);
                MessageBox.Show("Atualizado com sucesso!");
            }

        }

        private void button_buscar_Click(object sender, EventArgs e)
        {
            tab_cadastro_material.SelectedTab = tab_buscar_cadastro;

        }

        private void button_editar_cadastro_Click(object sender, EventArgs e)
        {
            Desbloquear_controles();
        }

        //private void combo_grupo_material_SelectedIndexChanged(object sender, EventArgs e) { }

        private void combo_grupo_material_TextChanged(object sender, EventArgs e)
        {

            //label_grupo_estoque_id.Text = combo_grupo_material.Text;
            //Carregar_descricao_grupo_estoque(combo_grupo_estoque.Text);

        }

        private void combo_grupo_material_SelectedIndexChanged(object sender, EventArgs e)
        {

            label_grupo_estoque_id.Text = combo_grupo_material.Text;
            //Carregar_descricao_grupo_estoque(combo_grupo_material.Text);
        }

        private void label_grupo_estoque_id_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(combo_grupo_estoque.Text);
            Carregar_descricao_grupo_estoque(label_grupo_estoque_id.Text);
        }

        private void combo_und_medida_SelectedIndexChanged(object sender, EventArgs e)
        {
            Carrega_descricao_undMedida(combo_und_medida.Text);
        }

        private void button_deletar_cadastro_Click(object sender, EventArgs e)
        {
            Deletar_cadastro(abaCadastro_label_id_cadastro.Text);
            Carregar_grid();
            limpar_campos();
        }
    }
}
