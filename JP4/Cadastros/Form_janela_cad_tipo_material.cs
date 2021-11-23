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

namespace JP4.Cadastros
{
    public partial class Form_janela_cad_tipo_material : Form
    {
        public Form_janela_cad_tipo_material()
        {
            InitializeComponent();

            Carregar_grid();

        }

        #region Metodos Carregar controles
        private void Carregar_controles(string id_tipo_material)
        {
            try
            {
                //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                string local_default = @"C:\JP4";
                string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select * from db_cadastro_operador where id_tipo_material=" + id_tipo_material;

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    text_codigo_tipo_material.Text = myreader["codigo_material"].ToString();
                    text_tipo_material.Text = myreader["tipo_material"].ToString();
                    text_descri_tipo_material.Text = myreader["descricao"].ToString();

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
                //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                string local_default = @"C:\JP4";
                string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select * from db_cadastro_tipo_material";

                OleDbConnection connection = new OleDbConnection(conecta_string);
                OleDbDataAdapter myadapter = new OleDbDataAdapter(comando_sql, connection);
                DataTable dt = new DataTable("db_cadastro_operador");

                myadapter.Fill(dt);
                DataView dv = dt.DefaultView;

                //dv.RowFilter = string.Format("descri_pai like '%{0}%'", item_pai);
                grid_tipo_material.DataSource = dv.ToTable();

                connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        #endregion

        #region Metodos // Salvar // Atualizar // Deletear // 

        private void Salvar_tipo_material()
        {

            string codigo_material = text_codigo_tipo_material.Text;
            string tipo_material = text_tipo_material.Text;
            string descricao = text_descri_tipo_material.Text;
            

            try
            {
                //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                string local_default = @"C:\JP4";
                string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                conexao.Open();

                string comando_sql;

                comando_sql = "INSERT INTO db_cadastro_tipo_material(codigo_material, tipo_material, descricao) " +
                    "VALUES('" + codigo_material + "','" + tipo_material + "','" + descricao + "')";

                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }
        }

        private void Atualizar_tipo_material(string id_tipo_material)
        {
            string codigo_material = text_codigo_tipo_material.Text;
            string tipo_material = text_tipo_material.Text;
            string descricao = text_descri_tipo_material.Text;

            try
            {
                string comando_sql;

                //string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                string local_default = @"C:\JP4";
                string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                conexao.Open();

                comando_sql = "UPDATE db_cadastro_tipo_material SET " +
                        "codigo_material='" + codigo_material +
                        "', tipo_material='" + tipo_material +
                        "', descricao='" + descricao +
                        "' WHERE id_tipo_material=" + id_tipo_material;

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

        private void Deletar_tipo_material(string id_tipo_material)
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

                comando_sql = "DELETE FROM db_cadastro_tipo_material WHERE id_operador = " + id_tipo_material;

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
        #endregion

        #region Filtros // Limpar

        private void Limpar_filtros()
        {

        }

        private void Filtrar_tipos()
        {

        }

        private void limpar_controles()
        {
            text_codigo_tipo_material.Text = string.Empty;
            text_tipo_material.Text = string.Empty;
            text_descri_tipo_material.Text = string.Empty;
        }

        #endregion

        private void button_salvar_Click(object sender, EventArgs e)
        {
            Salvar_tipo_material();
            Carregar_grid();
            limpar_controles();
        }

        private void button_atualizar_Click(object sender, EventArgs e)
        {
            Atualizar_tipo_material(label_id_tipo_material.Text);
            Carregar_grid();
            limpar_controles();
        }

        private void button_deletar_Click(object sender, EventArgs e)
        {
            Deletar_tipo_material(label_id_tipo_material.Text);
            Carregar_grid();
            limpar_controles();
        }

        private void button_limpar_controles_Click(object sender, EventArgs e)
        {
            limpar_controles();
        }

        private void button_filtrar_Click(object sender, EventArgs e)
        {

        }

        private void grid_tipo_material_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id_tipo_material = grid_tipo_material.CurrentRow.Cells[0].Value.ToString();
            label_id_tipo_material.Text = id_tipo_material;            
            Carregar_controles(id_tipo_material);
        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
