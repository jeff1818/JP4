using JP4.Config;
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
    public partial class Form_janela_cad_empresas : Form
    {
        public Form_janela_cad_empresas()
        {
            InitializeComponent();

            Carregar_grid_empresa();
        }

        // db_cadastro_local_estoque

        private void Carregar_grid_empresa()
        {
            try
            {
                //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                string local_default = @"C:\JP4";
                string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select * from db_cadastro_empresas";

                OleDbConnection connection = new OleDbConnection(conecta_string);
                OleDbDataAdapter myadapter = new OleDbDataAdapter(comando_sql, connection);
                DataTable dt = new DataTable("db_cadastro_empresas");

                myadapter.Fill(dt);
                DataView dv = dt.DefaultView;

                //dv.RowFilter = string.Format("descri_pai like '%{0}%'", item_pai);
                grid_cad_empresa.DataSource = dv.ToTable();

                connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Carregar_controles(string id_empresa)
        {
            try
            {
                // string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                string local_default = @"C:\JP4";
                string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);
                string comando_sql = "select * from db_cadastro_empresas where id_empresa=" + id_empresa;

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    text_cod_empresa.Text = myreader["codigo_empresa"].ToString();
                    text_nome_empresa.Text = myreader["descricao"].ToString();
                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }        

        //-------------------------------------------------------------------------------------------------
        // Salvar // Atualizar // Deletar

        private void Salvar_empresa()
        {
            string codigo_empresa = text_cod_empresa.Text;
            string descricao = text_nome_empresa.Text;

            try
            {
                //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                string local_default = @"C:\JP4";
                string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                conexao.Open();

                string comando_sql;

                comando_sql = "INSERT INTO db_cadastro_empresas(codigo_empresa, descricao) " +
                    "VALUES('" + codigo_empresa + "','" + descricao + "')";

                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }
        }
        private void Atualizar_empresa(string id_empresa)
        {
            string codigo_empresa = text_cod_empresa.Text;
            string descricao = text_nome_empresa.Text;

            try
            {
                string comando_sql;

                //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                string local_default = @"C:\JP4";
                string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                conexao.Open();

                comando_sql = "UPDATE db_cadastro_empresas SET " +
                        "codigo_empresa='" + codigo_empresa +
                        "', descricao='" + descricao +
                        "' WHERE id_empresa=" + id_empresa;

                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();

                MessageBox.Show("Atualizado com sucesso!");


            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Deletar_empresa(string id_empresa)
        {
            try
            {
                //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                string local_default = @"C:\JP4";
                string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                conexao.Open();

                string comando_sql;

                comando_sql = "DELETE FROM db_cadastro_empresas WHERE id_empresa = " + id_empresa;

                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();

                MessageBox.Show("Deletado com sucesso!");

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Limpar_controles()
        {
            text_cod_empresa.Text = string.Empty;
            text_nome_empresa.Text = string.Empty;
        }

        //----------------------------------------------------------------------------

        private void button_salvar_Click(object sender, EventArgs e)
        {
            Salvar_empresa();
            Limpar_controles();
            Carregar_grid_empresa();

        }

        private void button_atualizar_Click(object sender, EventArgs e)
        {
            Atualizar_empresa(label_id_cad_empresa.Text);
            Limpar_controles();
            Carregar_grid_empresa();
        }

        private void button_deletar_Click(object sender, EventArgs e)
        {
            Deletar_empresa(label_id_cad_empresa.Text);
            Limpar_controles();
            Carregar_grid_empresa();
        }

        private void button_limpar_controles_Click(object sender, EventArgs e)
        {
            Limpar_controles();
        }

        private void grid_cad_empresa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id_empresa = grid_cad_empresa.CurrentRow.Cells[0].Value.ToString();
            label_id_cad_empresa.Text = id_empresa;
            Carregar_controles(id_empresa);
        }


        // db_cadastro_empresas





    }
}
