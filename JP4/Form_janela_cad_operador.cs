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
    public partial class Form_janela_cad_operador : Form
    {
        public Form_janela_cad_operador()
        {
            InitializeComponent();

            Carregar_grid_operador();
            Carregar_turno();
            Carregar_equipamentos();

        }


        //----------------------------------------------------------------------------------------------------------------
        // Carregar controles

        // db_cadastro_operador
        // id_operador
        // nome
        // turno
        // funcao
        // equipamento

        private void Carregar_grid_operador()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_operador";

                OleDbConnection connection = new OleDbConnection(conecta_string);
                OleDbDataAdapter myadapter = new OleDbDataAdapter(comando_sql, connection);
                DataTable dt = new DataTable("db_cadastro_operador");

                myadapter.Fill(dt);
                DataView dv = dt.DefaultView;

                //dv.RowFilter = string.Format("descri_pai like '%{0}%'", item_pai);
                grid_cad_operador.DataSource = dv.ToTable();

                connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Carregar_turno()
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
                    combo_turno.Items.Add(myreader["turno"].ToString());
                }
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }        
        private void Carregar_equipamentos()
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
                    combo_equipamento.Items.Add(myreader["descricao_equipamento"].ToString());
                }
                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }

        private void Carregar_controles(string id_operador)
        {
            // id_operador
            // nome
            // turno
            // funcao
            // equipamento

            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_operador where id_operador=" + id_operador;

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    text_nome_operador.Text = myreader["nome"].ToString();
                    combo_turno.Text = myreader["turno"].ToString();
                    text_funcao.Text = myreader["funcao"].ToString();
                    combo_equipamento.Text = myreader["equipamento"].ToString();
                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }

        //----------------------------------------------------------------------------------------------------------------
        // Salvar / Atualizar / Deletar /
        


        //----------------------------------------------------------------------------------------------------------------

        private void button_salvar_Click(object sender, EventArgs e)
        {

        }

        private void button_atualizar_Click(object sender, EventArgs e)
        {

        }

        private void button_deletar_Click(object sender, EventArgs e)
        {

        }

        private void button_limpar_controles_Click(object sender, EventArgs e)
        {

        }

        private void text_funcao_MouseHover(object sender, EventArgs e)
        {
            ToolTip myToolTip = new ToolTip();
            string aviso = "Somente a primeira Letra deve ser Maiuscula!";
            myToolTip.Show(aviso, text_funcao);

        }

        private void combo_turno_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Esta aparecendo um erro e não puxar do  jeito certo 
                // 08/03/2021 - 17:37
                // 

                var turno = combo_turno.Text;

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

                    label_descri_turno.Text = hora_inicio.ToString("HH:mm") + " as " + hora_final.ToString("HH;mm");
                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }

        private void grid_cad_operador_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id_operador = grid_cad_operador.CurrentRow.Cells[0].Value.ToString();
            label_id_cad_operador.Text = id_operador;
            Carregar_controles(id_operador);
        }
    }
}
