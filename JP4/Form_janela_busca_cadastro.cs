using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace JP4
{
    public partial class FIND_CAD : Form
    {
        public FIND_CAD()
        {
            InitializeComponent();
            Carregar_status_material();
            Carregar_descri_completa();
            Carregar_cod_item();
            Carregar_grupo_estoque();

            Carregar_grid();
        }        

        #region Metodos comboBox
        private void Carregar_grupo_estoque()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_grupo_estoque";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    this.combo_grupo_estoque.Items.Add(myreader["codigo_grupo"].ToString());
                }

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Carregar_status_material()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_status";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    this.combo_status.Items.Add(myreader["status_material"].ToString());

                }

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Carregar_descri_completa()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_material";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    this.combo_descri_completa.Items.Add(myreader["descricao_completa"].ToString());

                }

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Carregar_cod_item()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_material";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    this.combo_cod_item.Items.Add(myreader["codigo_item"].ToString());

                }

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Carregar_grid()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select cadastro_id, codigo_item, status_item, descricao_completa, grupo, tipo_material from db_cadastro_material";

                OleDbConnection connection = new OleDbConnection(conecta_string);
                OleDbDataAdapter myadapter = new OleDbDataAdapter(comando_sql, connection);
                DataTable dt = new DataTable("db_estrutura");

                myadapter.Fill(dt);

                DataView dv = dt.DefaultView;

                grid_cadastro.DataSource = dt;


                connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        #endregion

        #region Metodos adicionais
        private void Filtrar_grid(string codigo_item, string status_item, string grupo_item, string descri_completa)
        {

            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select cadastro_id, codigo_item, status_item, descricao_completa, grupo, tipo_material from db_cadastro_material";

                OleDbConnection connection = new OleDbConnection(conecta_string);
                OleDbDataAdapter myadapter = new OleDbDataAdapter(comando_sql, connection);
                DataTable dt = new DataTable("db_estrutura");

                myadapter.Fill(dt);

                DataView dv = dt.DefaultView;

                if (codigo_item != string.Empty)
                {
                    dv.RowFilter = string.Format("codigo_item like '%{0}%'", codigo_item);
                    grid_cadastro.DataSource = dv.ToTable();
                }
                if (status_item != string.Empty)
                {
                    dv.RowFilter = string.Format("status_item like '%{0}%'", status_item);
                    grid_cadastro.DataSource = dv.ToTable();
                }
                if (grupo_item != string.Empty)
                {
                    dv.RowFilter = string.Format("grupo like '%{0}%'", grupo_item);
                    grid_cadastro.DataSource = dv.ToTable();
                }
                if (descri_completa != string.Empty)
                {
                    dv.RowFilter = string.Format("descricao_completa like '%{0}%'", descri_completa);
                    grid_cadastro.DataSource = dv.ToTable();
                }

                //dv.RowFilter = string.Format("codigo_item like '%{0}%', status_item like '%{1}%', grupo like '%{2}%', descricao_completa like '%{3}%' ", codigo_item, status_item, grupo_item, descri_completa);
                //grid_cadastro.DataSource = dv.ToTable();


                connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void Carrega_controles(string descricao_completa)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_material where descricao_completa ='" + descricao_completa + "'";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    combo_cod_item.Text = myreader["codigo_item"].ToString();
                    combo_status.Text = myreader["status_item"].ToString();
                    combo_grupo_estoque.Text = myreader["grupo"].ToString();

                }

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void Carregar_descricao_grupo(string descricao_completa)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_grupo_estoque where codigo_grupo = '" + descricao_completa + "'";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    this.label_descri_grupo.Text = myreader["nome_grupo"].ToString();
                }

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void Limpar_filtro()
        {

            combo_cod_item.Text = string.Empty;
            combo_status.Text = string.Empty;
            combo_grupo_estoque.Text = string.Empty;
            combo_descri_completa.Text = string.Empty;

            Carregar_grid();
        }

        #endregion

        private void button_filtrar_Click(object sender, EventArgs e)
        {
            Filtrar_grid(combo_cod_item.Text, combo_status.Text, combo_grupo_estoque.Text, combo_descri_completa.Text);
        }

        private void combo_descri_completa_SelectedIndexChanged(object sender, EventArgs e)
        {
            Carrega_controles(combo_descri_completa.Text);
        }

        private void combo_grupo_estoque_SelectedIndexChanged(object sender, EventArgs e)
        {
            Carregar_descricao_grupo(combo_grupo_estoque.Text);
        }

        private void grid_cadastro_DoubleClick(object sender, EventArgs e)
        {

        }

        private void button_editar_Click(object sender, EventArgs e)
        {

        }

        private void button_limpar_filtro_Click(object sender, EventArgs e)
        {
            Limpar_filtro();
        }

        private void grid_cadastro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string idCliente = grid_cadastro.CurrentRow.Cells[0].Value.ToString();
            text_id_componente_envia.Text = idCliente;

            
            //cadastro.Refresh();
            //MessageBox.Show("Formulario de busca Envia >> " + idCliente.ToString());
            //this.Close();



        }

        private void text_id_componente_envia_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
