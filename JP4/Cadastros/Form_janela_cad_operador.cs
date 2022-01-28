using MySql.Data.MySqlClient;
using System;
using System.Data;
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

                MySqlConnection connection = new MySqlConnection(conecta_string);
                MySqlDataAdapter myadapter = new MySqlDataAdapter(comando_sql, connection);
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

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
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

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
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

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
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
        private void limpar_controles()
        {
            text_nome_operador.Text = string.Empty;
            combo_turno.Text = string.Empty;
            text_funcao.Text = string.Empty;
            combo_equipamento.Text = string.Empty;
            label_descri_turno.Text = "....";
        }
        private void Salvar_operador()
        {
            string nome = text_nome_operador.Text;
            string turno = combo_turno.Text;
            string funcao = text_funcao.Text;
            string equipamento = combo_equipamento.Text;


            // id_operador
            // nome
            // turno
            // funcao
            // equipamento
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                MySqlConnection conexao = new MySqlConnection(conecta_string);
                conexao.Open();

                string comando_sql;

                comando_sql = "INSERT INTO db_cadastro_operador(nome, turno, funcao, equipamento) " +
                    "VALUES('" + nome + "','" + turno + "','" + funcao + "','" + equipamento + "')";

                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }
        }
        private void Atualizar_operador(string id_operador)
        {
            string nome = text_nome_operador.Text;
            string turno = combo_turno.Text;
            string funcao = text_funcao.Text;
            string equipamento = combo_equipamento.Text;

            try
            {
                string comando_sql;

                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                MySqlConnection conexao = new MySqlConnection(conecta_string);
                conexao.Open();

                comando_sql = "UPDATE db_cadastro_operador SET " +
                        "nome='" + nome +
                        "', turno='" + turno +
                        "', funcao='" + funcao +
                        "', equipamento='" + equipamento +
                        "' WHERE id_operador=" + id_operador;

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
        private void Deletar_operador(string id_operador)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                MySqlConnection conexao = new MySqlConnection(conecta_string);
                conexao.Open();

                string comando_sql;

                comando_sql = "DELETE FROM db_cadastro_operador WHERE id_operador = " + id_operador;

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

        //----------------------------------------------------------------------------------------------------------------

        private void button_salvar_Click(object sender, EventArgs e)
        {
            Salvar_operador();
            Carregar_grid_operador();
            limpar_controles();
        }

        private void button_atualizar_Click(object sender, EventArgs e)
        {
            Atualizar_operador(label_id_cad_operador.Text);
            Carregar_grid_operador();
            limpar_controles();
        }

        private void button_deletar_Click(object sender, EventArgs e)
        {
            Deletar_operador(label_id_cad_operador.Text);
            Carregar_grid_operador();
            limpar_controles();
        }

        private void button_limpar_controles_Click(object sender, EventArgs e)
        {
            limpar_controles();
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

                var turno = combo_turno.Text;
                DateTime hora_inicio;
                DateTime hora_final;


                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_turnos where turno='" + turno + "'";
                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
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

        private void button_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
