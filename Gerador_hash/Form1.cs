using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;



namespace Gerador_hash
{
    public partial class Form_gerador_md5 : Form
    {
        public Form_gerador_md5()
        {
            InitializeComponent();

            Carregar_grid_cad_operacao();
            Carregar_grid_pc_liberado();

            Carregar_nome_pc();
        }


        #region Metodos Aba Cadastro

        private void Limpar_campos()
        {
            textBox_cad_nome_cliente.Text = string.Empty;
            textBox_cad_nome_pc.Text = string.Empty;
            textBox_cad_hash_produto.Text = string.Empty;
            combo_cad_liberar_pc.Text = string.Empty;
            label_id_computadores.Text = "id";

        }

        private void Carregar_controles(string id_pc)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from 03db_controle_acesso where id_pc=" + id_pc;

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    combo_nome_pc.Text = myreader["nome_pc"].ToString();
                    textBox_md05.Text = myreader["maquina_md5"].ToString();

                    textBox_cad_nome_cliente.Text = myreader["user_name_pc"].ToString();
                    textBox_cad_nome_pc.Text = myreader["nome_pc"].ToString();
                    //textBox_cad_hash_produto.Text = myreader["maquina_md5"].ToString();

                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }

        }
        private void Carregar_nome_pc()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select distinct nome_pc from 03db_controle_acesso";

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    combo_nome_pc.Items.Add(myreader["nome_pc"].ToString());
                }
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }


        #endregion




        #region Metodos Aba Relatorio
        private void Carregar_grid_cad_operacao()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from 03db_controle_acesso order by data_entrada desc";

                MySqlConnection connection = new MySqlConnection(conecta_string);
                MySqlDataAdapter myadapter = new MySqlDataAdapter(comando_sql, connection);
                DataTable dt = new DataTable("03db_controle_acesso");

                myadapter.Fill(dt);
                DataView dv = dt.DefaultView;

                //dv.RowFilter = string.Format("descri_pai like '%{0}%'", item_pai);
                grid_lista_pc_conectado.DataSource = dv.ToTable();

                connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        public void Habilitar_novo_cliente()
        {
            string nome_cliente = textBox_cad_nome_cliente.Text;
            string nome_pc = textBox_cad_nome_pc.Text;
            string produto_hash = textBox_cad_hash_produto.Text;
            string controle_acesso = combo_cad_liberar_pc.Text;

            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                MySqlConnection conexao = new MySqlConnection(conecta_string);
                conexao.Open();

                string comando_sql;

                comando_sql = "INSERT INTO 02db_cadastro_computadores(nome_cliente, nome_pc, produto_hash, controle_acesso) " +
                    "VALUES('" + nome_cliente + "','" + nome_pc + "','" + produto_hash + "','" + controle_acesso + "')";

                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();

                MessageBox.Show("Cadastro feito com sucesso!");

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }
        }

        public void Atualizar_pc_liberado(string id_computadores)
        {
            string nome_cliente = textBox_cad_nome_cliente.Text;
            string nome_pc = textBox_cad_nome_pc.Text;
            string produto_hash = textBox_cad_hash_produto.Text;
            string controle_acesso = combo_cad_liberar_pc.Text;

            try
            {
                string comando_sql;

                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                MySqlConnection conexao = new MySqlConnection(conecta_string);
                conexao.Open();

                comando_sql = "UPDATE 02db_cadastro_computadores SET " +
                        "nome_cliente='" + nome_cliente +
                        "', nome_pc='" + nome_pc +
                        "', produto_hash='" + produto_hash +
                        "', controle_acesso='" + controle_acesso +
                        "' WHERE id_computadores=" + id_computadores;

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

        private void Deletar_pc_liberado(string id_computadores)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                MySqlConnection conexao = new MySqlConnection(conecta_string);
                conexao.Open();

                string comando_sql;

                comando_sql = "DELETE FROM 02db_cadastro_computadores WHERE id_computadores = " + id_computadores;

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

        #region Metodos Aba Computadores liberados

        private void Carregar_grid_pc_liberado()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from 02db_cadastro_computadores";

                MySqlConnection connection = new MySqlConnection(conecta_string);
                MySqlDataAdapter myadapter = new MySqlDataAdapter(comando_sql, connection);
                DataTable dt = new DataTable("02db_cadastro_computadores");

                myadapter.Fill(dt);
                DataView dv = dt.DefaultView;

                //dv.RowFilter = string.Format("descri_pai like '%{0}%'", item_pai);
                dataGrid_computadores_liberados.DataSource = dv.ToTable();

                connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Carregar_controles_pc(string id_computadores)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from 02db_cadastro_computadores where id_computadores=" + id_computadores;

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    textBox_cad_nome_cliente.Text = myreader["nome_cliente"].ToString();
                    textBox_cad_nome_pc.Text = myreader["nome_pc"].ToString();
                    textBox_cad_hash_produto.Text = myreader["produto_hash"].ToString();
                    combo_cad_liberar_pc.Text = myreader["controle_acesso"].ToString(); ;


                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }

        }




        #endregion


        public string CalculaHash(string Senha)
        {
            try
            {
                System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(Senha);
                byte[] hash = md5.ComputeHash(inputBytes);
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("X2"));
                }
                return sb.ToString(); // Retorna senha criptografada 
            }
            catch (Exception)
            {
                return null; // Caso encontre erro retorna nulo
            }
        }



        private void button_gerar_md5_Click(object sender, EventArgs e)
        {
            textBox_md05.Text = CalculaHash(combo_nome_pc.Text);

            textBox_cad_nome_pc.Text = combo_nome_pc.Text;
            textBox_cad_hash_produto.Text = textBox_md05.Text;
        }

        private void grid_lista_pc_conectado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id_pc = grid_lista_pc_conectado.CurrentRow.Cells[0].Value.ToString();

            tab_area_relatorio_computadores.SelectedTab = tab_cadastro;
            Carregar_controles(id_pc);

        }

        private void button_atualizar_tabela_Click(object sender, EventArgs e)
        {
            Carregar_grid_cad_operacao();
        }

        private void button_liberar_pc_Click(object sender, EventArgs e)
        {
            Habilitar_novo_cliente();

        }

        private void button_atualizar_Click(object sender, EventArgs e)
        {
            Atualizar_pc_liberado(label_id_computadores.Text);
            Limpar_campos();
            Carregar_grid_pc_liberado();
        }

        private void button_deletar_Click(object sender, EventArgs e)
        {
            Deletar_pc_liberado(label_id_computadores.Text);
            Limpar_campos();
            Carregar_grid_pc_liberado();
        }




        private void dataGrid_computadores_liberados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id_pc = dataGrid_computadores_liberados.CurrentRow.Cells[0].Value.ToString();
            label_id_computadores.Text = id_pc;
            tab_area_relatorio_computadores.SelectedTab = tab_cadastro;
            Carregar_controles_pc(id_pc);
        }

        private void button_atualizar_pc_liberados_Click(object sender, EventArgs e)
        {
            Carregar_grid_pc_liberado();
        }

    }
}
