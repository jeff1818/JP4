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

namespace JP4
{
    public partial class Form_janela_retrabalho : Form
    {
        

        public Form_janela_retrabalho()
        {
            InitializeComponent();
        }

        // Janela de retrabalho esta dando muito trabalho
        // ainda precisa melhorar a logica dos filtros e busca no banco de dados
        // Pensar numa forma de transformar os fardos "errados" sem precisar estornar


        private void Busca_apon_ordem(DateTime data_apontamento)
        {
            // alimenta o campo de ordem de produção

            int dia = data_apontamento.Day;
            int mes = data_apontamento.Month;
            int ano = data_apontamento.Year;
            


            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from estoque_trans where cod_operacao = 'APON'";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    int dia_db = Convert.ToDateTime(myreader["dat_movto"]).Day;
                    int mes_db = Convert.ToDateTime(myreader["dat_movto"]).Month;
                    int ano_db = Convert.ToDateTime(myreader["dat_movto"]).Year;

                    if(dia == dia_db && mes == mes_db && ano == ano_db)
                    {
                        origem_combo_ordem_prod.Items.Add(myreader["num_docum"].ToString());
                    }
                    
                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }

        }
        private void Busca_apon_maquina(double ordem_prod)
        {
            // alimenta o campo de maquina
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from estoque_trans where cod_operacao = 'APON' AND num_docum = " + ordem_prod;

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    origem_text_descri_item.Text = myreader["cod_descri_completa"].ToString();
                    origem_combo_maquina.Items.Add(myreader["secao_nome"].ToString());

                }              

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }

        }
        private void Busca_maquina(double ordem_prod)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select distinct secao_nome from estoque_trans where cod_operacao = 'APON' AND num_docum = " + ordem_prod;

                //SELECT DISTINCT Names FROM MstNames
                // TEm que achar um jeito de fazer isso aqui retornar somente itens distintos

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    origem_combo_maquina.Items.Add(myreader["secao_nome"].ToString());

                }

                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        
        private void Busca_operador_afins(double ordem_prod, string maquina)
        {
            // operador
            // Local destino
            // qtd fardo

            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from estoque_trans where cod_operacao = 'APON' AND num_docum = " + ordem_prod + " AND secao_nome = '"+ maquina + "'";

                //SELECT DISTINCT Names FROM MstNames
                // TEm que achar um jeito de fazer isso aqui retornar somente itens distintos

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    origem_combo_operador.Items.Add(myreader["operador"].ToString()); // tem que ser distinto
                    origem_combo_local_destino.Items.Add(myreader["cod_local_est_dest"].ToString());
                    origem_text_qtd_fardo.Text = myreader["fardos"].ToString();

                }

                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }


        }

        private void origem_dt_apontameno_ValueChanged(object sender, EventArgs e)
        {
            //origem_combo_maquina.Items.Clear();
            origem_combo_ordem_prod.Items.Clear();
            Busca_apon_ordem(origem_dt_apontameno.Value);
        }

        private void origem_combo_ordem_prod_SelectedIndexChanged(object sender, EventArgs e)
        {

            origem_combo_maquina.Items.Clear();
            Busca_apon_maquina(Convert.ToDouble(origem_combo_ordem_prod.Text));
            Busca_maquina(Convert.ToDouble(origem_combo_ordem_prod.Text));
        }

        private void origem_combo_maquina_SelectedIndexChanged(object sender, EventArgs e)
        {
            origem_combo_operador.Items.Clear();
            Busca_operador_afins(Convert.ToDouble(origem_combo_ordem_prod.Text), origem_combo_maquina.Text);
        }
    }
}
