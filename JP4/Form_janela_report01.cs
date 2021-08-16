using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace JP4
{
    public partial class Form_janela_report01 : Form
    {
        public Form_janela_report01()
        {
            InitializeComponent();           
            
        }

        private void Carregar_grafico_pico()
        {
            try
            {
                double mes_movto = 8;

                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                OleDbConnection conexao = new OleDbConnection(conecta_string);
                string comando_sql = "select * from estoque_trans where mes_movto= " + mes_movto;
                OleDbDataReader myreader;


                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);                
                conexao.Open();
                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    //chart_producao_pico.Series["Series1"].Points.AddXY(myreader.GetString("secao_nome"), myreader.GetInt16("qtd_movto"));

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
