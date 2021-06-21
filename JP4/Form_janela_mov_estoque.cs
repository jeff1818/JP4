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

            Carrega_secao_maquina();
            Carrega_locais();
            Carrega_grid();
        }



        #region Metodos de busca

        private string Buscar_tipo_material(string cod_descri_completa)
        {
            return "";
        }

        private string Gerar_num_transac(double num_docum, DateTime hr_atual)
        {
            string resultado = "";

            resultado = Convert.ToString(num_docum) + hr_atual.Hour + hr_atual.Minute + hr_atual.Second;
            return resultado;

        }

        #endregion

        #region Metodos Limpeza
        private void Desbloquear_controles()
        {

        }

        private void Bloqueia_controles()
        {

        }
        private void Limpar_controles()
        {

        }


        #endregion

        #region Carregar controles
        private void Carrega_controles()
        {

            string cod_empresa = combo_empresa.Text;
            string num_transac = "";
            string cod_item = this.combo_cod_item.Text;
            string cod_descri_completa = combo_descri_completa.Text;
            string cod_descri_reduzida = "";
            int mes_proces = DateTime.Now.Month;
            int mes_movto = DateTime.Now.Month;
            int ano_movto = DateTime.Now.Year;
            DateTime dat_proces = DateTime.Today;
            DateTime dat_movto = Convert.ToDateTime(dt_movt.Value);
            string cod_operacao = combo_operacao.Text;
            double num_docum = Convert.ToDouble(text_num_documento.Text);
            string ies_tip_movto = text_tipo_mov.Text;
            double qtd_movto = Convert.ToDouble(text_qtd_movt.Text);
            double qtd_real = qtd_movto;// * (-1);
            double fardos = 0;
            double num_secao_requis = 1;
            string operador = "";
            string secao_nome = combo_secao_maquina.Text;
            string cod_local_est_orig = combo_local_orig.Text;
            string cod_local_est_dest = combo_local_destino.Text;
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
            string observacao = rich_observa.Text;
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

                Carrega_grid();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }
        private void Carrega_iten()
        {

        }
        private void Carrega_descr_completa()
        {

        }
        private void Carrega_operacao()
        {

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

        #region Metodos Salvar // Estornar // Buscar



        #endregion

        private void grid_mov_estoque_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id_apontamento = grid_mov_estoque.CurrentRow.Cells[0].Value.ToString();
            label_id_stoque_trans.Text = id_apontamento;

            
        }

        private void button_iniciar_Click(object sender, EventArgs e)
        {

        }

        private void button_salvar_Click(object sender, EventArgs e)
        {

        }

        private void button_estornar_Click(object sender, EventArgs e)
        {

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
    }
}
