using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace JP4
{
    public partial class Form_janela_estoque : Form
    {
        public Form_janela_estoque()
        {
            InitializeComponent();
        }

        /*
         * 
        Saldo = Inventário inicial + Entradas (Apon, AR, AJ+) - Saidas (Back, consumo MP, AJ-, RM, BAXM)
        
        inventário inicial = tabela de inventário.

        Entradas (Apon, AR, AJ+) = stoque_trans
        Saidas (Back, consumo MP, AJ-, RM, BAXM) = stoque_trans
        Saidas MP = mp_apon


        criar rotina para relacionar e calcular esses dados

        filtrar por data

        Relacionar tabelas (estoque_lote + estoque_trans + mp_apon)
        buscar pela descrição do produto

         */


        #region Metodos de Busca

        private void Busca_estoque()
        {
            try
            {

                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "";

                // Verificar se ordem e qtd é igual 
                // se for igual não puxar
                //select cod_descri_completa, cod_operacao, cod_local_est_orig, cod_local_est_dest, mes_movto, ano_movto, dat_movto from estoque_trans

                MySqlConnection connection = new MySqlConnection(conecta_string);
                MySqlDataAdapter myadapter = new MySqlDataAdapter(comando_sql, connection);
                DataTable dt = new DataTable("estoque_trans");
                myadapter.Fill(dt);
                DataView dv = dt.DefaultView;
                grid_consulta_estoque.DataSource = dt;
                connection.Close();


            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }



        #endregion

        #region Metodos para carregar Material
        private void Carregar_descri_material()
        {

        }

        private void Carregar_local_destino()
        {

        }




        #endregion

        #region Metodos de calculo de estoque
        // A logica do estoque
        // Saldo = Estoque Inicial + (Entradas + Ajuste + ) - (Saidas + Ajustes - )

        public void Update_estoque(double entrada, double saida, DateTime data_movt)
        {
            // data_movt, dia_movt, mes_movt, ano_movt, cod_item, den_item, qtd_invent_inicial, qtd_entradas, qtd_saidas, qtd_saldo, cod_local_destino, situa_qtd, cod_empresa, cod_barra, num_lote



        }



        #endregion






    }
}
