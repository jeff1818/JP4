using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace JP4
{
    public partial class ST01 : Form
    {
        public ST01()
        {
            InitializeComponent();
            Carregar_descricao_completa();
            Carregar_descricao_componente();
            Carregar_empresa();
            Bloquear_controles();
            Carregar_clientes();

            this.combo_empresa.Text = "Picoflex";

        }

        private bool TextBoxVazias()
        {
            foreach (Control c in this.Controls)
                if (c is System.Windows.Forms.TextBox)
                {
                    System.Windows.Forms.TextBox textBox = c as System.Windows.Forms.TextBox;
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                        return true;
                }
            return false;
        }

        private void Limpar_campos()
        {
            
            this.combo_componente01.Text = string.Empty;
            this.text_qtd_necess01.Text = string.Empty;
            this.text_percentual_refugo01.Text = string.Empty;
            this.text_dt_inicio01.Text = string.Empty;
            this.text_dt_validade01.Text = string.Empty;
            
            this.combo_componente02.Text = string.Empty;
            this.text_qtd_necess02.Text = string.Empty;
            this.text_percentual_refugo02.Text = string.Empty;
            this.text_dt_inicio02.Text = string.Empty;
            this.text_dt_validade02.Text = string.Empty;
        
            this.combo_componente03.Text = string.Empty;
            this.text_qtd_necess03.Text = string.Empty;
            this.text_percentual_refugo03.Text = string.Empty;
            this.text_dt_inicio03.Text = string.Empty;
            this.text_dt_validade03.Text = string.Empty;
        
            this.combo_componente04.Text = string.Empty;
            this.text_qtd_necess04.Text = string.Empty;
            this.text_percentual_refugo04.Text = string.Empty;
            this.text_dt_inicio04.Text = string.Empty;
            this.text_dt_validade04.Text = string.Empty;

            this.combo_componente05.Text = string.Empty;
            this.text_qtd_necess05.Text = string.Empty;
            this.text_percentual_refugo05.Text = string.Empty;
            this.text_dt_inicio05.Text = string.Empty;
            this.text_dt_validade05.Text = string.Empty;

            this.combo_componente06.Text = string.Empty;
            this.text_qtd_necess06.Text = string.Empty;
            this.text_percentual_refugo06.Text = string.Empty;
            this.text_dt_inicio06.Text = string.Empty;
            this.text_dt_validade06.Text = string.Empty;

            this.combo_componente07.Text = string.Empty;
            this.text_qtd_necess07.Text = string.Empty;
            this.text_percentual_refugo07.Text = string.Empty;
            this.text_dt_inicio07.Text = string.Empty;
            this.text_dt_validade07.Text = string.Empty;

            this.combo_componente08.Text = string.Empty;
            this.text_qtd_necess08.Text = string.Empty;
            this.text_percentual_refugo08.Text = string.Empty;
            this.text_dt_inicio08.Text = string.Empty;
            this.text_dt_validade08.Text = string.Empty;

            this.combo_componente09.Text = string.Empty;
            this.text_qtd_necess09.Text = string.Empty;
            this.text_percentual_refugo09.Text = string.Empty;
            this.text_dt_inicio09.Text = string.Empty;
            this.text_dt_validade09.Text = string.Empty;

            this.combo_componente10.Text = string.Empty;
            this.text_qtd_necess10.Text = string.Empty;
            this.text_percentual_refugo10.Text = string.Empty;
            this.text_dt_inicio10.Text = string.Empty;
            this.text_dt_validade10.Text = string.Empty;

            this.id01.Text = "id";
            this.id02.Text = "id";
            this.id03.Text = "id";
            this.id04.Text = "id";
            this.id05.Text = "id";
            this.id06.Text = "id";
            this.id07.Text = "id";
            this.id08.Text = "id";
            this.id09.Text = "id";
            this.id10.Text = "id";

            this.delete01.Checked = false;
            this.delete02.Checked = false;
            this.delete03.Checked = false;
            this.delete04.Checked = false;
            this.delete05.Checked = false;
            this.delete06.Checked = false;
            this.delete07.Checked = false;
            this.delete08.Checked = false;
            this.delete09.Checked = false;
            this.delete10.Checked = false;



        }
        public void Carregar_estrutura(string item_pai)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "SELECT * FROM db_estrutura WHERE descri_pai = '"+item_pai+"'";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                int contagem = 0;
                DateTime diahoje = DateTime.Today;

                while (myreader.Read())
                {
                    //int contagem = myreader.VisibleFieldCount;
                    if (contagem == 0)
                    {
                        this.combo_componente01.Text =myreader["descri_filho"].ToString();
                        this.text_qtd_necess01.Text = myreader["qtd_necessaria"].ToString();
                        this.text_percentual_refugo01.Text =  myreader["pct_refug"].ToString();
                        this.text_dt_inicio01.Text = Convert.ToDateTime(myreader["dat_validade_ini"]).ToString("dd/MM/yyyy");
                        this.text_dt_validade01.Text = Convert.ToDateTime(myreader["dat_validade_fim"]).ToString("dd/MM/yyyy");
                        this.id01.Text = myreader["id_estrutura"].ToString();
                        this.combo_cliente.Text = myreader["cliente"].ToString();
                    }
                    if(contagem == 1)
                    {
                        this.combo_componente02.Text =myreader["descri_filho"].ToString();
                        this.text_qtd_necess02.Text = myreader["qtd_necessaria"].ToString();
                        this.text_percentual_refugo02.Text = myreader["pct_refug"].ToString();
                        this.text_dt_inicio02.Text = Convert.ToDateTime(myreader["dat_validade_ini"]).ToString("dd/MM/yyyy");
                        this.text_dt_validade02.Text = Convert.ToDateTime(myreader["dat_validade_fim"]).ToString("dd/MM/yyyy");
                        this.id02.Text = myreader["id_estrutura"].ToString();
                        this.combo_cliente.Text = myreader["cliente"].ToString();
                    }
                    if (contagem == 2)
                    {
                        this.combo_componente03.Text = myreader["descri_filho"].ToString();
                        this.text_qtd_necess03.Text = myreader["qtd_necessaria"].ToString();
                        this.text_percentual_refugo03.Text = myreader["pct_refug"].ToString();
                        this.text_dt_inicio03.Text = Convert.ToDateTime(myreader["dat_validade_ini"]).ToString("dd/MM/yyyy");
                        this.text_dt_validade03.Text = Convert.ToDateTime(myreader["dat_validade_fim"]).ToString("dd/MM/yyyy");
                        this.id03.Text = myreader["id_estrutura"].ToString();
                        this.combo_cliente.Text = myreader["cliente"].ToString();
                    }
                    if (contagem == 3)
                    {
                        this.combo_componente04.Text = myreader["descri_filho"].ToString();
                        this.text_qtd_necess04.Text = myreader["qtd_necessaria"].ToString();
                        this.text_percentual_refugo04.Text = myreader["pct_refug"].ToString();
                        this.text_dt_inicio04.Text = Convert.ToDateTime(myreader["dat_validade_ini"]).ToString("dd/MM/yyyy");
                        this.text_dt_validade04.Text = Convert.ToDateTime(myreader["dat_validade_fim"]).ToString("dd/MM/yyyy");
                        this.id04.Text = myreader["id_estrutura"].ToString();
                        this.combo_cliente.Text = myreader["cliente"].ToString();
                    }
                    if (contagem == 4)
                    {
                        this.combo_componente05.Text = myreader["descri_filho"].ToString();
                        this.text_qtd_necess05.Text = myreader["qtd_necessaria"].ToString();
                        this.text_percentual_refugo05.Text = myreader["pct_refug"].ToString();
                        this.text_dt_inicio05.Text = Convert.ToDateTime(myreader["dat_validade_ini"]).ToString("dd/MM/yyyy");
                        this.text_dt_validade05.Text = Convert.ToDateTime(myreader["dat_validade_fim"]).ToString("dd/MM/yyyy");
                        this.id05.Text = myreader["id_estrutura"].ToString();
                        this.combo_cliente.Text = myreader["cliente"].ToString();
                    }
                    if (contagem == 5)
                    {
                        this.combo_componente06.Text = myreader["descri_filho"].ToString();
                        this.text_qtd_necess06.Text = myreader["qtd_necessaria"].ToString();
                        this.text_percentual_refugo06.Text = myreader["pct_refug"].ToString();
                        this.text_dt_inicio06.Text = Convert.ToDateTime(myreader["dat_validade_ini"]).ToString("dd/MM/yyyy");
                        this.text_dt_validade06.Text = Convert.ToDateTime(myreader["dat_validade_fim"]).ToString("dd/MM/yyyy");
                        this.id06.Text = myreader["id_estrutura"].ToString();
                        this.combo_cliente.Text = myreader["cliente"].ToString();
                    }
                    if (contagem == 6)
                    {
                        this.combo_componente07.Text = myreader["descri_filho"].ToString();
                        this.text_qtd_necess07.Text = myreader["qtd_necessaria"].ToString();
                        this.text_percentual_refugo07.Text = myreader["pct_refug"].ToString();
                        this.text_dt_inicio07.Text = Convert.ToDateTime(myreader["dat_validade_ini"]).ToString("dd/MM/yyyy");
                        this.text_dt_validade07.Text = Convert.ToDateTime(myreader["dat_validade_fim"]).ToString("dd/MM/yyyy");
                        this.id07.Text = myreader["id_estrutura"].ToString();
                        this.combo_cliente.Text = myreader["cliente"].ToString();
                    }
                    if (contagem == 7)
                    {
                        this.combo_componente08.Text = myreader["descri_filho"].ToString();
                        this.text_qtd_necess08.Text = myreader["qtd_necessaria"].ToString();
                        this.text_percentual_refugo08.Text = myreader["pct_refug"].ToString();
                        this.text_dt_inicio08.Text = Convert.ToDateTime(myreader["dat_validade_ini"]).ToString("dd/MM/yyyy");
                        this.text_dt_validade08.Text = Convert.ToDateTime(myreader["dat_validade_fim"]).ToString("dd/MM/yyyy");
                        this.id08.Text = myreader["id_estrutura"].ToString();
                        this.combo_cliente.Text = myreader["cliente"].ToString();
                    }
                    if (contagem == 8)
                    {
                        this.combo_componente09.Text = myreader["descri_filho"].ToString();
                        this.text_qtd_necess09.Text = myreader["qtd_necessaria"].ToString();
                        this.text_percentual_refugo09.Text = myreader["pct_refug"].ToString();
                        this.text_dt_inicio09.Text = Convert.ToDateTime(myreader["dat_validade_ini"]).ToString("dd/MM/yyyy");
                        this.text_dt_validade09.Text = Convert.ToDateTime(myreader["dat_validade_fim"]).ToString("dd/MM/yyyy");
                        this.id09.Text = myreader["id_estrutura"].ToString();
                        this.combo_cliente.Text = myreader["cliente"].ToString();
                    }
                    if (contagem == 9)
                    {
                        this.combo_componente10.Text = myreader["descri_filho"].ToString();
                        this.text_qtd_necess10.Text = myreader["qtd_necessaria"].ToString();
                        this.text_percentual_refugo10.Text = myreader["pct_refug"].ToString();
                        this.text_dt_inicio10.Text = Convert.ToDateTime(myreader["dat_validade_ini"]).ToString("dd/MM/yyyy");
                        this.text_dt_validade10.Text = Convert.ToDateTime(myreader["dat_validade_fim"]).ToString("dd/MM/yyyy");
                        this.id10.Text = myreader["id_estrutura"].ToString();
                        this.combo_cliente.Text = myreader["cliente"].ToString();
                    }                   

                    contagem++;
                    //MessageBox.Show(contagem.ToString());
                    
                }

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Carregar_descricao_componente()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select descricao_completa from db_cadastro_material where tem_estrutura = 0";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    this.combo_componente01.Items.Add(myreader["descricao_completa"].ToString());
                    this.combo_componente02.Items.Add(myreader["descricao_completa"].ToString());
                    this.combo_componente03.Items.Add(myreader["descricao_completa"].ToString());
                    this.combo_componente04.Items.Add(myreader["descricao_completa"].ToString());
                    this.combo_componente05.Items.Add(myreader["descricao_completa"].ToString());
                    this.combo_componente06.Items.Add(myreader["descricao_completa"].ToString());
                    this.combo_componente07.Items.Add(myreader["descricao_completa"].ToString());
                    this.combo_componente08.Items.Add(myreader["descricao_completa"].ToString());
                    this.combo_componente09.Items.Add(myreader["descricao_completa"].ToString());
                    this.combo_componente10.Items.Add(myreader["descricao_completa"].ToString());
                }

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }


        }
        private void Carregar_descricao_completa()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_material where tem_estrutura = 1";


                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    this.text_cod_item.Text = myreader["codigo_item"].ToString();
                    this.combo_descricao_item.Items.Add(myreader["descricao_completa"].ToString());
                }

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Carregar_empresa()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_empresas";// where tem_estrutura = 1";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {                    
                    this.combo_empresa.Items.Add(myreader["descricao"].ToString());
                }

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void Carregar_clientes()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_clientes";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();


                while (myreader.Read())
                {
                    combo_cliente.Items.Add(myreader["cliente_nome"].ToString());
                }
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }


        private void Bloquear_controles()
        {
            this.combo_componente01.Enabled = false;
            this.text_qtd_necess01.Enabled = false;
            this.text_percentual_refugo01.Enabled = false;
            this.text_dt_inicio01.Enabled = false;
            this.text_dt_validade01.Enabled = false;

            this.combo_componente02.Enabled = false;
            this.text_qtd_necess02.Enabled = false;
            this.text_percentual_refugo02.Enabled = false;
            this.text_dt_inicio02.Enabled = false;
            this.text_dt_validade02.Enabled = false;

            this.combo_componente03.Enabled = false;
            this.text_qtd_necess03.Enabled = false;
            this.text_percentual_refugo03.Enabled = false;
            this.text_dt_inicio03.Enabled = false;
            this.text_dt_validade03.Enabled = false;

            this.combo_componente04.Enabled = false;
            this.text_qtd_necess04.Enabled = false;
            this.text_percentual_refugo04.Enabled = false;
            this.text_dt_inicio04.Enabled = false;
            this.text_dt_validade04.Enabled = false;

            this.combo_componente05.Enabled = false;
            this.text_qtd_necess05.Enabled = false;
            this.text_percentual_refugo05.Enabled = false;
            this.text_dt_inicio05.Enabled = false;
            this.text_dt_validade05.Enabled = false;

            this.combo_componente06.Enabled = false;
            this.text_qtd_necess06.Enabled = false;
            this.text_percentual_refugo06.Enabled = false;
            this.text_dt_inicio06.Enabled = false;
            this.text_dt_validade06.Enabled = false;

            this.combo_componente07.Enabled = false;
            this.text_qtd_necess07.Enabled = false;
            this.text_percentual_refugo07.Enabled = false;
            this.text_dt_inicio07.Enabled = false;
            this.text_dt_validade07.Enabled = false;

            this.combo_componente08.Enabled = false;
            this.text_qtd_necess08.Enabled = false;
            this.text_percentual_refugo08.Enabled = false;
            this.text_dt_inicio08.Enabled = false;
            this.text_dt_validade08.Enabled = false;

            this.combo_componente09.Enabled = false;
            this.text_qtd_necess09.Enabled = false;
            this.text_percentual_refugo09.Enabled = false;
            this.text_dt_inicio09.Enabled = false;
            this.text_dt_validade09.Enabled = false;

            this.combo_componente10.Enabled = false;
            this.text_qtd_necess10.Enabled = false;
            this.text_percentual_refugo10.Enabled = false;
            this.text_dt_inicio10.Enabled = false;
            this.text_dt_validade10.Enabled = false;

            this.delete01.Enabled = false;
            this.delete02.Enabled = false;
            this.delete03.Enabled = false;
            this.delete04.Enabled = false;
            this.delete05.Enabled = false;
            this.delete06.Enabled = false;
            this.delete07.Enabled = false;
            this.delete08.Enabled = false;
            this.delete09.Enabled = false;
            this.delete10.Enabled = false;
        }

        private void Desbloquear_controles()
        {
            this.combo_componente01.Enabled = true;
            this.text_qtd_necess01.Enabled = true;
            this.text_percentual_refugo01.Enabled = true;
            this.text_dt_inicio01.Enabled = true;
            this.text_dt_validade01.Enabled = true;

            this.combo_componente02.Enabled = true;
            this.text_qtd_necess02.Enabled = true;
            this.text_percentual_refugo02.Enabled = true;
            this.text_dt_inicio02.Enabled = true;
            this.text_dt_validade02.Enabled = true;

            this.combo_componente03.Enabled = true;
            this.text_qtd_necess03.Enabled = true;
            this.text_percentual_refugo03.Enabled = true;
            this.text_dt_inicio03.Enabled = true;
            this.text_dt_validade03.Enabled = true;

            this.combo_componente04.Enabled = true;
            this.text_qtd_necess04.Enabled = true;
            this.text_percentual_refugo04.Enabled = true;
            this.text_dt_inicio04.Enabled = true;
            this.text_dt_validade04.Enabled = true;

            this.combo_componente05.Enabled = true;
            this.text_qtd_necess05.Enabled = true;
            this.text_percentual_refugo05.Enabled = true;
            this.text_dt_inicio05.Enabled = true;
            this.text_dt_validade05.Enabled = true;

            this.combo_componente06.Enabled = true;
            this.text_qtd_necess06.Enabled = true;
            this.text_percentual_refugo06.Enabled = true;
            this.text_dt_inicio06.Enabled = true;
            this.text_dt_validade06.Enabled = true;

            this.combo_componente07.Enabled = true;
            this.text_qtd_necess07.Enabled = true;
            this.text_percentual_refugo07.Enabled = true;
            this.text_dt_inicio07.Enabled = true;
            this.text_dt_validade07.Enabled = true;

            this.combo_componente08.Enabled = true;
            this.text_qtd_necess08.Enabled = true;
            this.text_percentual_refugo08.Enabled = true;
            this.text_dt_inicio08.Enabled = true;
            this.text_dt_validade08.Enabled = true;

            this.combo_componente09.Enabled = true;
            this.text_qtd_necess09.Enabled = true;
            this.text_percentual_refugo09.Enabled = true;
            this.text_dt_inicio09.Enabled = true;
            this.text_dt_validade09.Enabled = true;

            this.combo_componente10.Enabled = true;
            this.text_qtd_necess10.Enabled = true;
            this.text_percentual_refugo10.Enabled = true;
            this.text_dt_inicio10.Enabled = true;
            this.text_dt_validade10.Enabled = true;

            this.delete01.Enabled = true;
            this.delete02.Enabled = true;
            this.delete03.Enabled = true;
            this.delete04.Enabled = true;
            this.delete05.Enabled = true;
            this.delete06.Enabled = true;
            this.delete07.Enabled = true;
            this.delete08.Enabled = true;
            this.delete09.Enabled = true;
            this.delete10.Enabled = true;

        }

        private void atualizar_estrutura(int id_modificado)
        {
            
        }

        private void Salvar_estrutura()
        {            
            string comando_sql;

            string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
            OleDbConnection conexao = new OleDbConnection(conecta_string);
            conexao.Open();
            try
            {
                if (id01.Text == "id")
                {
                    if (combo_componente01.Text != string.Empty && text_qtd_necess01.Text != string.Empty && text_percentual_refugo01.Text != string.Empty && text_dt_inicio01.Text != string.Empty)
                    {
                        DateTime data_inicio = Convert.ToDateTime(this.text_dt_inicio01.Text);
                        DateTime data_validade = Convert.ToDateTime(this.text_dt_validade01.Text);

                        comando_sql = "INSERT INTO db_estrutura(empresa, item_pai, descri_pai, descri_filho, qtd_necessaria, pct_refug, dat_validade_ini, dat_validade_fim, cliente) " +
                        "VALUES('" + combo_empresa.Text + "','" + text_cod_item.Text + "','" + combo_descricao_item.Text + "','" + combo_componente01.Text + "','" + text_qtd_necess01.Text + "','" + text_percentual_refugo01.Text + "','" + data_inicio + "','" + data_validade + "','"+combo_cliente+ "')";

                        OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                        cmd.ExecuteNonQuery();
                    }
                }
                if (id01.Text != "id")
                {
                    string data_inicio = this.text_dt_inicio01.Text;
                    string data_validade = this.text_dt_validade01.Text;

                    comando_sql = "UPDATE db_estrutura SET " +
                        "empresa='" + combo_empresa.Text +
                        "', item_pai='" + text_cod_item.Text +
                        "', descri_filho='" + combo_componente01.Text +
                        "', qtd_necessaria='" + text_qtd_necess01.Text +
                        "', pct_refug='" + text_percentual_refugo01.Text +
                        "', dat_validade_ini='" + Convert.ToDateTime(data_inicio) +
                        "', dat_validade_fim='" + Convert.ToDateTime(data_validade) +
                        "' WHERE id_estrutura=" + Convert.ToInt64(id01.Text) + "";

                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                }

                if (id02.Text == "id")
                {
                    if (combo_componente02.Text != string.Empty && text_qtd_necess02.Text != string.Empty && text_percentual_refugo02.Text != string.Empty && text_dt_inicio02.Text != string.Empty)
                    {
                        DateTime data_inicio = Convert.ToDateTime(this.text_dt_inicio02.Text);
                        DateTime data_validade = Convert.ToDateTime(this.text_dt_validade02.Text);


                        comando_sql = "INSERT INTO db_estrutura(empresa, item_pai, descri_pai, descri_filho, qtd_necessaria, pct_refug, dat_validade_ini, dat_validade_fim, cliente) " +
                        "VALUES('" + combo_empresa.Text + "','" + text_cod_item.Text + "','" + combo_descricao_item.Text + "','" + combo_componente01.Text + "','" + text_qtd_necess01.Text + "','" + text_percentual_refugo01.Text + "','" + data_inicio + "','" + data_validade + "','" + combo_cliente + "')";


                        OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                        cmd.ExecuteNonQuery();
                    }                    
                }
                if (id02.Text != "id")
                {
                    string data_inicio = this.text_dt_inicio02.Text;
                    string data_validade = this.text_dt_validade02.Text;

                    comando_sql = "UPDATE db_estrutura SET " +
                        "empresa='" + combo_empresa.Text +
                        "', item_pai='" + text_cod_item.Text +
                        "', descri_filho='" + combo_componente02.Text +
                        "', qtd_necessaria='" + text_qtd_necess02.Text +
                        "', pct_refug='" + text_percentual_refugo02.Text +
                        "', dat_validade_ini='" + Convert.ToDateTime(data_inicio) +
                        "', dat_validade_fim='" + Convert.ToDateTime(data_validade) +
                        "' WHERE id_estrutura=" + Convert.ToInt64(id02.Text) + "";

                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                }

                if (id03.Text == "id")
                {
                    if (combo_componente03.Text != string.Empty && text_qtd_necess03.Text != string.Empty && text_percentual_refugo03.Text != string.Empty && text_dt_inicio03.Text != string.Empty)
                    {
                        DateTime data_inicio = Convert.ToDateTime(this.text_dt_inicio03.Text);
                        DateTime data_validade = Convert.ToDateTime(this.text_dt_validade03.Text);


                        comando_sql = "INSERT INTO db_estrutura(empresa, item_pai, descri_pai, descri_filho, qtd_necessaria, pct_refug, dat_validade_ini, dat_validade_fim, cliente) " +
                        "VALUES('" + combo_empresa.Text + "','" + text_cod_item.Text + "','" + combo_descricao_item.Text + "','" + combo_componente01.Text + "','" + text_qtd_necess01.Text + "','" + text_percentual_refugo01.Text + "','" + data_inicio + "','" + data_validade + "','" + combo_cliente + "')";


                        OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                        cmd.ExecuteNonQuery();
                    }
                }
                if (id03.Text != "id")
                {
                    string data_inicio = this.text_dt_inicio03.Text;
                    string data_validade = this.text_dt_validade03.Text;

                    comando_sql = "UPDATE db_estrutura SET " +
                        "empresa='" + combo_empresa.Text +
                        "', item_pai='" + text_cod_item.Text +
                        "', descri_filho='" + combo_componente03.Text +
                        "', qtd_necessaria='" + text_qtd_necess03.Text +
                        "', pct_refug='" + text_percentual_refugo03.Text +
                        "', dat_validade_ini='" + Convert.ToDateTime(data_inicio) +
                        "', dat_validade_fim='" + Convert.ToDateTime(data_validade) +
                        "' WHERE id_estrutura=" + Convert.ToInt64(id03.Text) + "";

                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                }

                if (id04.Text == "id")
                {
                    if (combo_componente04.Text != string.Empty && text_qtd_necess04.Text != string.Empty && text_percentual_refugo04.Text != string.Empty && text_dt_inicio04.Text != string.Empty)
                    {
                        DateTime data_inicio = Convert.ToDateTime(this.text_dt_inicio04.Text);
                        DateTime data_validade = Convert.ToDateTime(this.text_dt_validade04.Text);


                        comando_sql = "INSERT INTO db_estrutura(empresa, item_pai, descri_pai, descri_filho, qtd_necessaria, pct_refug, dat_validade_ini, dat_validade_fim, cliente) " +
                        "VALUES('" + combo_empresa.Text + "','" + text_cod_item.Text + "','" + combo_descricao_item.Text + "','" + combo_componente01.Text + "','" + text_qtd_necess01.Text + "','" + text_percentual_refugo01.Text + "','" + data_inicio + "','" + data_validade + "','" + combo_cliente + "')";


                        OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                        cmd.ExecuteNonQuery();
                    }
                }
                if (id04.Text != "id")
                {
                    string data_inicio = this.text_dt_inicio04.Text;
                    string data_validade = this.text_dt_validade04.Text;

                    comando_sql = "UPDATE db_estrutura SET " +
                        "empresa='" + combo_empresa.Text +
                        "', item_pai='" + text_cod_item.Text +
                        "', descri_filho='" + combo_componente04.Text +
                        "', qtd_necessaria='" + text_qtd_necess04.Text +
                        "', pct_refug='" + text_percentual_refugo04.Text +
                        "', dat_validade_ini='" + Convert.ToDateTime(data_inicio) +
                        "', dat_validade_fim='" + Convert.ToDateTime(data_validade) +
                        "' WHERE id_estrutura=" + Convert.ToInt64(id04.Text) + "";

                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                }

                if (id05.Text == "id")
                {
                    if (combo_componente05.Text != string.Empty && text_qtd_necess05.Text != string.Empty && text_percentual_refugo05.Text != string.Empty && text_dt_inicio05.Text != string.Empty)
                    {
                        DateTime data_inicio = Convert.ToDateTime(this.text_dt_inicio05.Text);
                        DateTime data_validade = Convert.ToDateTime(this.text_dt_validade05.Text);


                        comando_sql = "INSERT INTO db_estrutura(empresa, item_pai, descri_pai, descri_filho, qtd_necessaria, pct_refug, dat_validade_ini, dat_validade_fim, cliente) " +
                        "VALUES('" + combo_empresa.Text + "','" + text_cod_item.Text + "','" + combo_descricao_item.Text + "','" + combo_componente01.Text + "','" + text_qtd_necess01.Text + "','" + text_percentual_refugo01.Text + "','" + data_inicio + "','" + data_validade + "','" + combo_cliente + "')";


                        OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                        cmd.ExecuteNonQuery();
                    }
                }
                if (id05.Text != "id")
                {
                    string data_inicio = this.text_dt_inicio05.Text;
                    string data_validade = this.text_dt_validade05.Text;

                    comando_sql = "UPDATE db_estrutura SET " +
                        "empresa='" + combo_empresa.Text +
                        "', item_pai='" + text_cod_item.Text +
                        "', descri_filho='" + combo_componente05.Text +
                        "', qtd_necessaria='" + text_qtd_necess05.Text +
                        "', pct_refug='" + text_percentual_refugo05.Text +
                        "', dat_validade_ini='" + Convert.ToDateTime(data_inicio) +
                        "', dat_validade_fim='" + Convert.ToDateTime(data_validade) +
                        "' WHERE id_estrutura=" + Convert.ToInt64(id05.Text) + "";

                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                }

                if (id06.Text == "id")
                {
                    if (combo_componente06.Text != string.Empty && text_qtd_necess06.Text != string.Empty && text_percentual_refugo06.Text != string.Empty && text_dt_inicio06.Text != string.Empty)
                    {
                        DateTime data_inicio = Convert.ToDateTime(this.text_dt_inicio06.Text);
                        DateTime data_validade = Convert.ToDateTime(this.text_dt_validade06.Text);


                        comando_sql = "INSERT INTO db_estrutura(empresa, item_pai, descri_pai, descri_filho, qtd_necessaria, pct_refug, dat_validade_ini, dat_validade_fim, cliente) " +
                        "VALUES('" + combo_empresa.Text + "','" + text_cod_item.Text + "','" + combo_descricao_item.Text + "','" + combo_componente01.Text + "','" + text_qtd_necess01.Text + "','" + text_percentual_refugo01.Text + "','" + data_inicio + "','" + data_validade + "','" + combo_cliente + "')";


                        OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                        cmd.ExecuteNonQuery();
                    }
                }
                if (id06.Text != "id")
                {
                    string data_inicio = this.text_dt_inicio06.Text;
                    string data_validade = this.text_dt_validade06.Text;

                    comando_sql = "UPDATE db_estrutura SET " +
                        "empresa='" + combo_empresa.Text +
                        "', item_pai='" + text_cod_item.Text +
                        "', descri_filho='" + combo_componente06.Text +
                        "', qtd_necessaria='" + text_qtd_necess06.Text +
                        "', pct_refug='" + text_percentual_refugo06.Text +
                        "', dat_validade_ini='" + Convert.ToDateTime(data_inicio) +
                        "', dat_validade_fim='" + Convert.ToDateTime(data_validade) +
                        "' WHERE id_estrutura=" + Convert.ToInt64(id06.Text) + "";

                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                }

                if (id07.Text == "id")
                {
                    if (combo_componente07.Text != string.Empty && text_qtd_necess07.Text != string.Empty && text_percentual_refugo07.Text != string.Empty && text_dt_inicio07.Text != string.Empty)
                    {
                        DateTime data_inicio = Convert.ToDateTime(this.text_dt_inicio07.Text);
                        DateTime data_validade = Convert.ToDateTime(this.text_dt_validade07.Text);


                        comando_sql = "INSERT INTO db_estrutura(empresa, item_pai, descri_pai, descri_filho, qtd_necessaria, pct_refug, dat_validade_ini, dat_validade_fim, cliente) " +
                        "VALUES('" + combo_empresa.Text + "','" + text_cod_item.Text + "','" + combo_descricao_item.Text + "','" + combo_componente01.Text + "','" + text_qtd_necess01.Text + "','" + text_percentual_refugo01.Text + "','" + data_inicio + "','" + data_validade + "','" + combo_cliente + "')";


                        OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                        cmd.ExecuteNonQuery();
                    }
                }
                if (id07.Text != "id")
                {
                    string data_inicio = this.text_dt_inicio07.Text;
                    string data_validade = this.text_dt_validade07.Text;

                    comando_sql = "UPDATE db_estrutura SET " +
                        "empresa='" + combo_empresa.Text +
                        "', item_pai='" + text_cod_item.Text +
                        "', descri_filho='" + combo_componente07.Text +
                        "', qtd_necessaria='" + text_qtd_necess07.Text +
                        "', pct_refug='" + text_percentual_refugo07.Text +
                        "', dat_validade_ini='" + Convert.ToDateTime(data_inicio) +
                        "', dat_validade_fim='" + Convert.ToDateTime(data_validade) +
                        "' WHERE id_estrutura=" + Convert.ToInt64(id07.Text) + "";

                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                }               

                if (id08.Text == "id")
                {
                    if (combo_componente08.Text != string.Empty && text_qtd_necess08.Text != string.Empty && text_percentual_refugo08.Text != string.Empty && text_dt_inicio08.Text != string.Empty)
                    {
                        DateTime data_inicio = Convert.ToDateTime(this.text_dt_inicio08.Text);
                        DateTime data_validade = Convert.ToDateTime(this.text_dt_validade08.Text);


                        comando_sql = "INSERT INTO db_estrutura(empresa, item_pai, descri_pai, descri_filho, qtd_necessaria, pct_refug, dat_validade_ini, dat_validade_fim, cliente) " +
                        "VALUES('" + combo_empresa.Text + "','" + text_cod_item.Text + "','" + combo_descricao_item.Text + "','" + combo_componente01.Text + "','" + text_qtd_necess01.Text + "','" + text_percentual_refugo01.Text + "','" + data_inicio + "','" + data_validade + "','" + combo_cliente + "')";


                        OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                        cmd.ExecuteNonQuery();
                    }
                }
                if (id08.Text != "id")
                {
                    string data_inicio = this.text_dt_inicio08.Text;
                    string data_validade = this.text_dt_validade08.Text;

                    comando_sql = "UPDATE db_estrutura SET " +
                        "empresa='" + combo_empresa.Text +
                        "', item_pai='" + text_cod_item.Text +
                        "', descri_filho='" + combo_componente08.Text +
                        "', qtd_necessaria='" + text_qtd_necess08.Text +
                        "', pct_refug='" + text_percentual_refugo08.Text +
                        "', dat_validade_ini='" + Convert.ToDateTime(data_inicio) +
                        "', dat_validade_fim='" + Convert.ToDateTime(data_validade) +
                        "' WHERE id_estrutura=" + Convert.ToInt64(id08.Text) + "";

                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                }

                if (id09.Text == "id")
                {
                    if (combo_componente09.Text != string.Empty && text_qtd_necess09.Text != string.Empty && text_percentual_refugo09.Text != string.Empty && text_dt_inicio09.Text != string.Empty)
                    {
                        DateTime data_inicio = Convert.ToDateTime(this.text_dt_inicio09.Text);
                        DateTime data_validade = Convert.ToDateTime(this.text_dt_validade09.Text);


                        comando_sql = "INSERT INTO db_estrutura(empresa, item_pai, descri_pai, descri_filho, qtd_necessaria, pct_refug, dat_validade_ini, dat_validade_fim, cliente) " +
                        "VALUES('" + combo_empresa.Text + "','" + text_cod_item.Text + "','" + combo_descricao_item.Text + "','" + combo_componente01.Text + "','" + text_qtd_necess01.Text + "','" + text_percentual_refugo01.Text + "','" + data_inicio + "','" + data_validade + "','" + combo_cliente + "')";


                        OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                        cmd.ExecuteNonQuery();
                    }
                }
                if (id09.Text != "id")
                {
                    string data_inicio = this.text_dt_inicio09.Text;
                    string data_validade = this.text_dt_validade09.Text;

                    comando_sql = "UPDATE db_estrutura SET " +
                        "empresa='" + combo_empresa.Text +
                        "', item_pai='" + text_cod_item.Text +
                        "', descri_filho='" + combo_componente09.Text +
                        "', qtd_necessaria='" + text_qtd_necess09.Text +
                        "', pct_refug='" + text_percentual_refugo09.Text +
                        "', dat_validade_ini='" + Convert.ToDateTime(data_inicio) +
                        "', dat_validade_fim='" + Convert.ToDateTime(data_validade) +
                        "' WHERE id_estrutura=" + Convert.ToInt64(id09.Text) + "";

                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                }

                if (id10.Text == "id")
                {
                    if (combo_componente10.Text != string.Empty && text_qtd_necess10.Text != string.Empty && text_percentual_refugo10.Text != string.Empty && text_dt_inicio10.Text != string.Empty)
                    {
                        DateTime data_inicio = Convert.ToDateTime(this.text_dt_inicio10.Text);
                        DateTime data_validade = Convert.ToDateTime(this.text_dt_validade10.Text);


                        comando_sql = "INSERT INTO db_estrutura(empresa, item_pai, descri_pai, descri_filho, qtd_necessaria, pct_refug, dat_validade_ini, dat_validade_fim, cliente) " +
                        "VALUES('" + combo_empresa.Text + "','" + text_cod_item.Text + "','" + combo_descricao_item.Text + "','" + combo_componente01.Text + "','" + text_qtd_necess01.Text + "','" + text_percentual_refugo01.Text + "','" + data_inicio + "','" + data_validade + "','" + combo_cliente + "')";


                        OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                        cmd.ExecuteNonQuery();
                    }
                }
                if (id10.Text != "id")
                {
                    string data_inicio = this.text_dt_inicio10.Text;
                    string data_validade = this.text_dt_validade10.Text;

                    comando_sql = "UPDATE db_estrutura SET " +
                        "empresa='" + combo_empresa.Text +
                        "', item_pai='" + text_cod_item.Text +
                        "', descri_filho='" + combo_componente10.Text +
                        "', qtd_necessaria='" + text_qtd_necess10.Text +
                        "', pct_refug='" + text_percentual_refugo10.Text +
                        "', dat_validade_ini='" + Convert.ToDateTime(data_inicio) +
                        "', dat_validade_fim='" + Convert.ToDateTime(data_validade) +
                        "' WHERE id_estrutura=" + Convert.ToInt64(id10.Text) + "";

                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                }


                conexao.Close();
                MessageBox.Show("Salvo com Sucesso!!");
                Limpar_campos();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        private void Delete_item_estrutura(Int64 id_cadastro)
        {
            
            string comando_sql;

            string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
            OleDbConnection conexao = new OleDbConnection(conecta_string);
            conexao.Open();
            try
            {
                comando_sql = "DELETE FROM db_estrutura WHERE id_estrutura =" + id_cadastro;

                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            Limpar_campos();
            Carregar_estrutura(this.combo_descricao_item.Text);

        }           
                

        private void button_editar_Click(object sender, EventArgs e)
        {
            Desbloquear_controles();
        }

        private void button_salvar_Click(object sender, EventArgs e)
        { 
            Salvar_estrutura();
        }

        private void button_pesquisar_Click(object sender, EventArgs e)
        {
            Limpar_campos();
            Carregar_estrutura(this.combo_descricao_item.Text);
            
        }

        private void combo_descricao_item_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_material where descricao_completa = '"+this.combo_descricao_item.Text+"'";


                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    this.text_cod_item.Text = myreader["codigo_item"].ToString();
                }

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if(delete01.Checked == true)
            {
                Delete_item_estrutura(Convert.ToInt64(id01.Text));
            }

            if (delete02.Checked == true)
            {
                Delete_item_estrutura(Convert.ToInt64(id02.Text));
            }

            if (delete03.Checked == true)
            {
                Delete_item_estrutura(Convert.ToInt64(id03.Text));
            }

            if (delete04.Checked == true)
            {
                Delete_item_estrutura(Convert.ToInt64(id04.Text));
            }

            if (delete05.Checked == true)
            {
                Delete_item_estrutura(Convert.ToInt64(id05.Text));
            }

            if (delete06.Checked == true)
            {
                Delete_item_estrutura(Convert.ToInt64(id06.Text));
            }

            if (delete07.Checked == true)
            {
                Delete_item_estrutura(Convert.ToInt64(id07.Text));
            }

            if (delete08.Checked == true)
            {
                Delete_item_estrutura(Convert.ToInt64(id08.Text));
            }

            if (delete09.Checked == true)
            {
                Delete_item_estrutura(Convert.ToInt64(id09.Text));
            }

            if (delete10.Checked == true)
            {
                Delete_item_estrutura(Convert.ToInt64(id10.Text));
            }

        }
    }
}
