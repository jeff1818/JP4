using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        Saldo = Inventário inicial + Entradas (Apon, AR, AJ+) - Saidas (Back, consumo MP, AJ-, RM, BAXM)
        
        inventário inicial = tabela de inventário.

        Entradas (Apon, AR, AJ+) = stoque_trans

        Saidas (Back, consumo MP, AJ-, RM, BAXM) = stoque_trans

        criar rotina para relacionar e calcular esses dados



         */


        #region Metodos de Busca



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
