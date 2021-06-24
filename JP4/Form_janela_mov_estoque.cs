using System;
using System.Data;
using System.Data.OleDb;
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
        }



        #region Metodos de busca
        private string Busca_descricao_operacao(string codigo)
        {
            string resultado_descri_operacao = string.Empty;

            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_operacao where codigo = '" + codigo + "'";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
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
                string comando_sql = "select * from db_cadastro_material where descricao_completa ='" + descricao_completa + "'";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
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
                string comando_sql = "select * from db_cadastro_material where codigo_item ='" + codigo_item + "'";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
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
                string comando_sql = "select * from db_cadastro_operacao where codigo = '" + operacao + "'";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
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
        }


        #endregion

        #region Carregar controles
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
                string comando_sql = "select * from estoque_trans where id_estoque_trans=" + id_estoque_trans;

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    combo_cod_item.Text = myreader["cod_item"].ToString();
                    combo_descri_completa.Text = myreader["cod_descri_completa"].ToString();
                    combo_operacao.Text = myreader["cod_operacao"].ToString();
                    text_num_documento.Text = myreader["num_docum"].ToString();
                    combo_secao_maquina.Text = myreader["num_secao_requis"].ToString();
                    text_qtd_movt.Text = myreader["qtd_movto"].ToString();
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
                string comando_sql = "select codigo_item from db_cadastro_material";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
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
                string comando_sql = "select descricao_completa from db_cadastro_material";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
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
                string comando_sql = "select * from db_cadastro_operacao where nome_prog = '" + nome_programa + "'";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
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

                string comando_sql = "select * from db_cadastro_equipamento";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
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
                string comando_sql = "select * from db_cadastro_local_estoque";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
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
                string comando_sql = "select id_estoque_trans, cod_descri_completa, cod_operacao, num_docum, qtd_movto, secao_nome, data_operac, observacao from estoque_trans " +
                    "where (cod_operacao <>'" + cod_operacao + "') AND (qtd_movto >= 0 AND status_estorno = 0)";

                // Verificar se ordem e qtd é igual 
                // se for igual não puxar

                OleDbConnection connection = new OleDbConnection(conecta_string);
                OleDbDataAdapter myadapter = new OleDbDataAdapter(comando_sql, connection);
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

        private void Salvar_lancamento()
        {

            string cod_item = this.combo_cod_item.Text;
            string cod_descri_completa = combo_descri_completa.Text;
            string cod_operacao = combo_operacao.Text;
            double num_docum = Convert.ToDouble(text_num_documento.Text);
            string secao_nome = combo_secao_maquina.Text;
            string ies_tip_movto = text_tipo_mov.Text;

            double qtd_movto = Convert.ToDouble(text_qtd_movt.Text);

            double qtd_real = 0;
            if (Busca_tipo_baixa(combo_operacao.Text) == "Saida")
            {
                qtd_real = qtd_movto * (-1);
            }
            if (Busca_tipo_baixa(combo_operacao.Text) == "Entrada")
            {
                qtd_real = qtd_movto;// * (-1);
            }

            //double qtd_real = qtd_movto;// * (-1);

            string cod_local_est_orig = combo_local_orig.Text;
            string cod_local_est_dest = combo_local_destino.Text;

            string observacao = rich_observa.Text;

            int mes_proces = DateTime.Now.Month;
            int mes_movto = DateTime.Now.Month;
            int ano_movto = DateTime.Now.Year;
            DateTime dat_proces = DateTime.Today;
            DateTime dat_movto = Convert.ToDateTime(dt_movt.Value);

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
            DateTime hora_inical = DateTime.Now;
            DateTime hora_final = DateTime.Now;
            DateTime data_operac = Convert.ToDateTime(dt_lancamento.Value);
            DateTime hor_operac = Convert.ToDateTime(DateTime.Now);
            string Tipo_material = Buscar_tipo_material(combo_descri_completa.Text);
            int status_estorno = 0;
            string cliente_apon = "";

            num_transac = Gerar_num_transac(num_docum, hor_operac);

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

            double qtd_movto = Convert.ToDouble(text_qtd_movt.Text);
            double qtd_real = qtd_movto;

            string cod_local_est_orig = combo_local_orig.Text;
            string cod_local_est_dest = combo_local_destino.Text;

            string observacao = rich_observa.Text;

            int mes_proces = DateTime.Now.Month;
            int mes_movto = DateTime.Now.Month;
            int ano_movto = DateTime.Now.Year;
            DateTime dat_proces = DateTime.Today;
            DateTime dat_movto = Convert.ToDateTime(dt_movt.Value);

            string cod_empresa = combo_empresa.Text;
            string num_transac;

            // Não aproveita 

            string cod_descri_reduzida;
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
            DateTime hora_inical = DateTime.Now;
            DateTime hora_final = DateTime.Now;
            DateTime data_operac = Convert.ToDateTime(dt_lancamento.Value);
            DateTime hor_operac = Convert.ToDateTime(DateTime.Now);
            string Tipo_material = Buscar_tipo_material(combo_descri_completa.Text);
            int status_estorno;
            string cliente_apon;

            num_transac = Gerar_num_transac(num_docum, hor_operac);


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
                OleDbConnection conexao = new OleDbConnection(conecta_string);
                conexao.Open();

                string comando_sql;

                comando_sql = "DELETE FROM estoque_trans WHERE id_estoque_trans=" + Convert.ToInt32(id_apontamento);

                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
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

        private void grid_mov_estoque_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id_estoque_trans = grid_mov_estoque.CurrentRow.Cells[0].Value.ToString();
            label_id_stoque_trans.Text = id_estoque_trans;
            Carregar_controles(id_estoque_trans);

        }

        private void button_iniciar_Click(object sender, EventArgs e)
        {
            Limpar_controles();
            Desbloquear_controles();
        }

        private void button_salvar_Click(object sender, EventArgs e)
        {
            Salvar_lancamento();
            Limpar_controles();
            Carrega_grid();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Atualizar_lancamento(label_id_stoque_trans.Text);
            Limpar_controles();
            Carrega_grid();

        }

        private void button_estornar_Click(object sender, EventArgs e)
        {
            Deletar_movimento(label_id_stoque_trans.Text);
            Limpar_controles();
            Carrega_grid();
        }

        private void button_buscar_Click(object sender, EventArgs e)
        {

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

     
    }
}
