using JP4.Config;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            // Carregar_grafico_pico();
            // Carregar_grafico_ext();

            label_report_dia_semana.Text = DateTime.Today.ToString("DDDD");
            label_dia_atual.Text = DateTime.Today.ToString("dd/MM/yyyy");

        }

        private void Carregar_grafico_pico()
        {
            try
            {

                string dat_movto = "01/11/2021"; //Convert.ToDateTime( DateTime.Today.AddDays(-1).ToString("dd/MM/yyyy"));
                string dat_movto2 = "02/11/2021"; //Convert.ToDateTime( DateTime.Today.AddDays(-1).ToString("dd/MM/yyyy"));

                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                //IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                //string local_default = @"C:\JP4";
                //string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                string comando_sql = "select * from estoque_trans where dat_movto >= '" + dat_movto + "' and dat_movto <= '" + dat_movto2 + "'  and cod_operacao = 'APON' and cod_empresa ='SAN MARINO'";
                MySqlDataReader myreader;

                // cod_operacao

                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);                
                conexao.Open();
                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {

                    //Maquina

                    chart_producao_pico.Series["Maquina"].Points.AddXY(myreader["secao_nome"].ToString(), myreader["qtd_movto"].ToString());


                }
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }


        private void Carregar_grafico_ext()
        {
            try
            {

                DateTime dat_movto = Convert.ToDateTime(label_dia_atual.Text);

                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                //IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                //string local_default = @"C:\JP4";
                //string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                string comando_sql = "select * from estoque_trans where dat_movto= " + dat_movto + " and cod_operacao = 'APON' and cod_empresa ='PICOFLEX' ";
                MySqlDataReader myreader;

                // cod_operacao

                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                conexao.Open();
                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {

                    //Maquina

                    chart_producao_extrusora.Series["Maquina"].Points.AddXY(myreader["secao_nome"].ToString(), myreader["qtd_movto"].ToString());


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
