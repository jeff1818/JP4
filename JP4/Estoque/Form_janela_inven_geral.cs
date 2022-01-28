using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace JP4
{
    public partial class Form_janela_inven_geral : Form
    {
        public Form_janela_inven_geral()
        {
            InitializeComponent();

            Carregar_grid();
            Carrega_descr_completa();
            Carregar_local_destino();
            Carregar_categorias();
            carregar_unidade_medida();

            Carregar_ano_inven();
            Carregar_meses_invent();

        }




        #region Metodos de calculo
        private double Calculo_quilos(double qtd_kg, double fator_padrao, double qtd_fardos)
        {
            double resultado = 0;

            if (qtd_kg <= 0 & qtd_fardos > 0)
            {
                resultado = fator_padrao * qtd_fardos;
            }
            else
            {
                resultado = qtd_kg;
            }

            return resultado;


        }



        #endregion

        #region Metodos de Busca
        private double Buscar_fator_padrao(string descricao_completa)
        {
            return 1;
        }

        private string Buscar_unidade_medida(string descricao_completa)
        {
            return "0";
        }


        #endregion

        #region Metodos de Carregar Controles

        private void Carrega_descr_completa()
        {
            // db_cadastro_material
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                //IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                //string local_default = @"C:\JP4";
                //string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);
                string comando_sql = "select descricao_completa from db_cadastro_material";

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    combo_descricao_item.Items.Add(myreader["descricao_completa"].ToString());
                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }

        }
        private void Carregar_categorias()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                //IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                //string local_default = @"C:\JP4";
                //string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select * from db_cadastro_categorias_inventario";

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    combo_categoria.Items.Add(myreader["nome_categoria"].ToString());
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
                //IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                //string local_default = @"C:\JP4";
                //string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select * from db_cadastro_unidade_medida";

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    combo_unidade_medida.Items.Add(myreader["unidade"].ToString());

                }

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Carregar_local_destino()
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
                    combo_local_destino.Items.Add(myreader["local_estoque"].ToString());
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
                //IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                //string local_default = @"C:\JP4";
                //string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select id_inventario, data_invent, mes_referencia, categoria_tipos, descricao_completa, unidade_medida, fator_padrao, local_destino, qtd_kg, qtd_fardos, status_mes, observacao  from db_inventario_mensal";

                MySqlConnection connection = new MySqlConnection(conecta_string);
                MySqlDataAdapter myadapter = new MySqlDataAdapter(comando_sql, connection);
                DataTable dt = new DataTable("db_inventario_mensal");

                myadapter.Fill(dt);
                DataView dv = dt.DefaultView;
                grid_movi_estoque.DataSource = dv.ToTable();

                connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Fator_conversao(string cod_descri_completa)
        {
            try
            {

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
                    label_fator_padrao.Text = myreader["peso_padrao"].ToString();
                }

                conexao.Close();


            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Carregar_ano_inven()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                //IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                //string local_default = @"C:\JP4";
                //string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select distinct ano_referencia from db_inventario_mensal";

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    comboBox_ano_referencia.Items.Add(myreader["ano_referencia"].ToString());
                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }
        private void Carregar_meses_invent()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                //IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                //string local_default = @"C:\JP4";
                //string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select distinct mes_referencia from db_inventario_mensal";

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    combo_mes_referencia.Items.Add(myreader["mes_referencia"].ToString());
                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }

        #endregion


        #region Metodos bloqueio // Desbloqueio controles // Limpeza de campos
        private void Bloquear_campos()
        {
            date_contagem.Enabled = false;
            date_referencia_mes_contagem.Enabled = false;
            combo_categoria.Enabled = false;
            combo_descricao_item.Enabled = false;
            combo_unidade_medida.Enabled = false;
            label_fator_padrao.Enabled = false;
            combo_local_destino.Enabled = false;
            text_qtd_kg.Enabled = false;
            text_qtd_fardos.Enabled = false;
            checkBox_mes_aberto.Enabled = false;
            checkBox_mes_fechado.Enabled = false;
            rich_observacao.Enabled = false;
        }
        private void Desbloquear_campos()
        {
            date_contagem.Enabled = true;
            date_referencia_mes_contagem.Enabled = true;
            combo_categoria.Enabled = true;
            combo_descricao_item.Enabled = true;
            combo_unidade_medida.Enabled = true;
            label_fator_padrao.Enabled = true;
            combo_local_destino.Enabled = true;
            text_qtd_kg.Enabled = true;
            text_qtd_fardos.Enabled = true;
            checkBox_mes_aberto.Enabled = true;
            checkBox_mes_fechado.Enabled = true;
            rich_observacao.Enabled = true;
        }
        private void Limpar_campos()
        {
            //date_contagem.Text = string.Empty;
            //date_referencia_mes_contagem.Text = string.Empty;
            combo_categoria.Text = string.Empty;
            combo_descricao_item.Text = string.Empty;
            combo_unidade_medida.Text = string.Empty;
            label_fator_padrao.Text = string.Empty;
            combo_local_destino.Text = string.Empty;
            text_qtd_kg.Text = "0";
            text_qtd_fardos.Text = "0";

            checkBox_mes_aberto.Checked = false;
            checkBox_mes_fechado.Checked = false;

            rich_observacao.Text = string.Empty;

        }

        #endregion


        #region Metodos de salvar // Atualizar // Deletar // Carregar
        private void Salvar_inventario()
        {
            string data_invent = date_contagem.Value.ToString("yyyy/MM/dd");
            string data_referencia = date_referencia_mes_contagem.Value.ToString("yyyy/MM/dd");

            int dia_referencia = date_referencia_mes_contagem.Value.Day;
            int mes_referencia = date_referencia_mes_contagem.Value.Month;
            int ano_referencia = date_referencia_mes_contagem.Value.Year;

            string categoria_tipos = combo_categoria.Text;
            string descricao_completa = combo_descricao_item.Text;
            string unidade_medida = combo_unidade_medida.Text;

            //double fator_padrao = Convert.ToDouble(label_fator_padrao.Text);
            string fator_padrao = label_fator_padrao.Text;

            string local_destino = combo_local_destino.Text;

            //double qtd_kg = Convert.ToDouble(text_qtd_kg.Text);
            string qtd_kg = text_qtd_kg.Text.Replace(',', '.');

            //double qtd_fardos = Convert.ToDouble(text_qtd_fardos.Text);
            string qtd_fardos = text_qtd_fardos.Text.Replace(',', '.');

            //double valor_unit = 0;
            //double valor_total= 0;

            string valor_unit = "0";
            string valor_total = "0";

            string status_mes = string.Empty;

            if (checkBox_mes_aberto.Checked == true)
            {
                status_mes = "A";
            }
            if (checkBox_mes_fechado.Checked == true)
            {
                status_mes = "F";
            }

            string observacao = rich_observacao.Text;



            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                MySqlConnection conexao = new MySqlConnection(conecta_string);
                conexao.Open();

                string comando_sql;

                comando_sql = "INSERT INTO db_inventario_mensal(data_invent, data_referencia, dia_referencia, mes_referencia, ano_referencia, categoria_tipos, descricao_completa, unidade_medida, fator_padrao, local_destino, qtd_kg, qtd_fardos, valor_unit, valor_total, status_mes, observacao) " +
                    "VALUES('" + data_invent + "','" + data_referencia + "','" + dia_referencia + "','" + mes_referencia + "','" + ano_referencia + "','" + categoria_tipos + "','" + descricao_completa + "','" + unidade_medida + "','" + fator_padrao + "','" + local_destino + "','" + qtd_kg + "','" + qtd_fardos + "','" + valor_unit + "','" + valor_total + "','" + status_mes + "','" + observacao + "')";

                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }



        }

        private void Atualizar_inventario(string id_inventario)
        {

            if (checkBox_mes_aberto.Checked == true)
            {

                string data_invent = date_contagem.Value.ToString("yyyy/MM/dd");
                string data_referencia = date_referencia_mes_contagem.Value.ToString("yyyy/MM/dd");

                int dia_referencia = date_referencia_mes_contagem.Value.Day;
                int mes_referencia = date_referencia_mes_contagem.Value.Month;
                int ano_referencia = date_referencia_mes_contagem.Value.Year;

                string categoria_tipos = combo_categoria.Text;
                string descricao_completa = combo_descricao_item.Text;
                string unidade_medida = combo_unidade_medida.Text;

                //double fator_padrao = Convert.ToDouble(label_fator_padrao.Text);
                string fator_padrao = label_fator_padrao.Text;

                string local_destino = combo_local_destino.Text;

                //double qtd_kg = Convert.ToDouble(text_qtd_kg.Text);
                string qtd_kg = text_qtd_kg.Text.Replace(',', '.');

                //double qtd_fardos = Convert.ToDouble(text_qtd_fardos.Text);
                string qtd_fardos = text_qtd_fardos.Text.Replace(',', '.');

                //double valor_unit = 0;
                //double valor_total= 0;

                string valor_unit = "0";
                string valor_total = "0";

                string status_mes = string.Empty;
                string observacao = rich_observacao.Text;


                try
                {
                    string comando_sql;

                    string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                    MySqlConnection conexao = new MySqlConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "UPDATE db_inventario_mensal SET " +
                            "data_invent='" + data_invent +
                            "', data_referencia='" + data_referencia +
                            "',dia_referencia='" + dia_referencia +
                            "',mes_referencia='" + mes_referencia +
                            "',ano_referencia='" + ano_referencia +
                            "',categoria_tipos='" + categoria_tipos +
                            "',descricao_completa='" + descricao_completa +
                            "',unidade_medida='" + unidade_medida +
                            "',fator_padrao='" + fator_padrao +
                            "',local_destino='" + local_destino +
                            "',qtd_kg='" + qtd_kg +
                            "',qtd_fardos='" + qtd_fardos +
                            "',valor_unit='" + valor_unit +
                            "',valor_total='" + valor_total +
                            "',status_mes='" + status_mes +
                            "',observacao='" + observacao +
                            "' WHERE id_inventario=" + id_inventario;

                    MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();

                    MessageBox.Show("Atualizado com sucesso!");


                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }

            }


        }

        private void Deletar_inventario(string id_inventario)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                MySqlConnection conexao = new MySqlConnection(conecta_string);
                conexao.Open();

                string comando_sql;

                comando_sql = "DELETE FROM db_inventario_mensal WHERE ID_cadas_equipamento = " + id_inventario;

                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();

                MessageBox.Show("Deletado com sucesso!");

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void Carrega_campos(string id_inventario)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_inventario_mensal where id_inventario =" + Convert.ToInt64(id_inventario) + "";

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    date_contagem.Value = Convert.ToDateTime(myreader["data_invent"].ToString());
                    date_referencia_mes_contagem.Value = Convert.ToDateTime(myreader["data_referencia"].ToString());

                    combo_categoria.Text = myreader["categoria_tipos"].ToString();
                    combo_descricao_item.Text = myreader["descricao_completa"].ToString();
                    combo_unidade_medida.Text = myreader["unidade_medida"].ToString();
                    label_fator_padrao.Text = myreader["fator_padrao"].ToString();
                    combo_local_destino.Text = myreader["local_destino"].ToString();
                    text_qtd_kg.Text = myreader["qtd_kg"].ToString();
                    text_qtd_fardos.Text = myreader["qtd_fardos"].ToString();
                    rich_observacao.Text = myreader["observacao"].ToString();


                    if (myreader["status_mes"].ToString() == "A")
                    {
                        checkBox_mes_aberto.Checked = true;
                        checkBox_mes_fechado.Checked = false;
                    }

                    if (myreader["status_mes"].ToString() == "F")
                    {
                        checkBox_mes_fechado.Checked = true;
                        checkBox_mes_aberto.Checked = false;
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

        private void button_salvar_Click(object sender, EventArgs e)
        {
            Salvar_inventario();
            Limpar_campos();
            Carregar_grid();
        }

        private void button_atualizar_Click(object sender, EventArgs e)
        {
            Atualizar_inventario(label_id_inventario.Text);
            Limpar_campos();
            Carregar_grid();
        }

        private void button_deletar_Click(object sender, EventArgs e)
        {
            Deletar_inventario(label_id_inventario.Text);
            Limpar_campos();
            Carregar_grid();

        }

        private void button_fechar_mes_Click(object sender, EventArgs e)
        {
            if (panel_fechamento_mes.Visible == false)
            {
                panel_fechamento_mes.Visible = true;
            }
            else
            {
                panel_fechamento_mes.Visible = false;
            }
        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void combo_descricao_item_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fator_conversao(combo_descricao_item.Text);
        }

        private void rich_observacao_Click(object sender, EventArgs e)
        {
            rich_observacao.Text = string.Empty;
        }

        private void rich_observacao_Leave(object sender, EventArgs e)
        {
            if (rich_observacao.Text != "...")
            {

            }
            else
            {
                rich_observacao.Text = "...";
            }

        }

        private void text_qtd_fardos_TextChanged(object sender, EventArgs e) { }

        private void text_qtd_fardos_Leave(object sender, EventArgs e)
        {
            text_qtd_kg.Text = Convert.ToString(Calculo_quilos(Convert.ToDouble(text_qtd_kg.Text), Convert.ToDouble(label_fator_padrao.Text), Convert.ToDouble(text_qtd_fardos.Text)));
        }

        private void grid_movi_estoque_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id_inventario = grid_movi_estoque.CurrentRow.Cells[0].Value.ToString();
            Carrega_campos(id_inventario);
        }

        private void checkBox_mes_aberto_CheckedChanged(object sender, EventArgs e)
        {
            checkBox_mes_fechado.Checked = false;
        }

        private void checkBox_mes_fechado_CheckedChanged(object sender, EventArgs e)
        {
            checkBox_mes_aberto.Checked = false;
        }
    }
}
