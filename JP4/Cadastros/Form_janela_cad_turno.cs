using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace JP4.Cadastros
{
    public partial class Form_janela_cad_turno : Form
    {
        public Form_janela_cad_turno()
        {
            InitializeComponent();
            Carregar_grid_turno();
        }



        #region Carregar Controles
        private void Carregar_grid_turno()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_turnos";

                MySqlConnection connection = new MySqlConnection(conecta_string);
                MySqlDataAdapter myadapter = new MySqlDataAdapter(comando_sql, connection);
                DataTable dt = new DataTable("db_cadastro_turnos");

                myadapter.Fill(dt);
                DataView dv = dt.DefaultView;

                //dv.RowFilter = string.Format("descri_pai like '%{0}%'", item_pai);
                grid_cad_turno.DataSource = dv.ToTable();

                connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void Carregar_controles(string id_turno)
        {
            //id_turno
            //turno
            //inicio_turno
            //fim_turno
            //observacao
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_turnos where id_turno=" + id_turno;

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    text_descri_turno.Text = myreader["turno"].ToString();
                    hr_inicial.Value = Convert.ToDateTime(myreader["inicio_turno"].ToString());
                    hr_final.Value = Convert.ToDateTime(myreader["fim_turno"].ToString());
                    rich_observacao.Text = myreader["observacao"].ToString();
                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }

        #endregion

        #region Salvar // Atualizar // Deletar // Limpar

        private void Limpar_controles()
        {
            text_descri_turno.Text = string.Empty;
            hr_inicial.Value = DateTime.Now;
            hr_final.Value = DateTime.Now;
            rich_observacao.Text = string.Empty;
        }

        private void Salvar_turno()
        {
            //id_turno
            //turno
            //inicio_turno
            //fim_turno
            //observacao

            string turno = text_descri_turno.Text;
            string inicio_turno = hr_inicial.Value.ToString("HH:mm:ss");
            string fim_turno = hr_final.Value.ToString("HH:mm:ss");
            string observacao = rich_observacao.Text;

            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                MySqlConnection conexao = new MySqlConnection(conecta_string);
                conexao.Open();

                string comando_sql;

                comando_sql = "INSERT INTO db_cadastro_turnos(turno, inicio_turno, fim_turno, observacao) " +
                    "VALUES('" + turno + "','" + inicio_turno + "','" + fim_turno + "','" + observacao + "')";

                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();

                MessageBox.Show("Salvo com sucesso!");

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }

        }

        private void Atualizar_turno(string id_turno)
        {
            string turno = text_descri_turno.Text;
            string inicio_turno = hr_inicial.Value.ToString("HH:mm:ss");
            string fim_turno = hr_final.Value.ToString("HH:mm:ss");
            string observacao = rich_observacao.Text;

            try
            {
                string comando_sql;

                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                MySqlConnection conexao = new MySqlConnection(conecta_string);
                conexao.Open();

                comando_sql = "UPDATE db_cadastro_turnos SET " +
                        "turno='" + turno +
                        "', inicio_turno='" + inicio_turno +
                        "', fim_turno='" + fim_turno +
                        "', observacao='" + observacao +
                        "' WHERE id_turno=" + id_turno;

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

        private void Deletar_turno(string id_turno)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                MySqlConnection conexao = new MySqlConnection(conecta_string);
                conexao.Open();

                string comando_sql;

                comando_sql = "DELETE FROM db_cadastro_turnos WHERE id_turno = " + id_turno;

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


        #endregion

        private void button_salvar_Click(object sender, EventArgs e)
        {
            Salvar_turno();
            Carregar_grid_turno();
            Limpar_controles();
        }

        private void button_atualizar_Click(object sender, EventArgs e)
        {
            Atualizar_turno(label_id_cad_turno.Text);
            Carregar_grid_turno();
            Limpar_controles();
        }

        private void button_deletar_Click(object sender, EventArgs e)
        {
            Deletar_turno(label_id_cad_turno.Text);
            Carregar_grid_turno();
            Limpar_controles();
        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grid_cad_turno_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id_operador = grid_cad_turno.CurrentRow.Cells[0].Value.ToString();
            label_id_cad_turno.Text = id_operador;
            Carregar_controles(id_operador);
        }
    }
}
