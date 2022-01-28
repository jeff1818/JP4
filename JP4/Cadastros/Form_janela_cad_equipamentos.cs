using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace JP4
{
    public partial class Form_janela_cad_equipamentos : Form
    {
        public Form_janela_cad_equipamentos()
        {
            InitializeComponent();

            Carregar_grid_equipamento();
            Carregar_empresa_db();
        }

        private void Carregar_grid_equipamento()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_equipamento";

                MySqlConnection connection = new MySqlConnection(conecta_string);
                MySqlDataAdapter myadapter = new MySqlDataAdapter(comando_sql, connection);
                DataTable dt = new DataTable("db_cadastro_equipamento");

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

        private void Carregar_controles(string iD_cadas_equipamento)
        {


            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_equipamento where ID_cadas_equipamento=" + iD_cadas_equipamento;

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    text_cod_equipamento.Text = myreader["codigo_equipamento"].ToString();
                    text_descri_equipamento.Text = myreader["descricao_equipamento"].ToString();
                    combo_situacao_aquipamento.Text = myreader["situacao"].ToString();
                    text_fator.Text = myreader["fator"].ToString();
                    text_velocidade_padrao.Text = myreader["velocidade_padrao"].ToString();
                    text_hr_trabalhada.Text = myreader["horas_trabalhadas"].ToString();
                    text_quilo_hora.Text = myreader["quilo_hora"].ToString();
                    text_prod_minuto.Text = myreader["minutos"].ToString();
                    text_patriponio.Text = myreader["patrimonio"].ToString();
                    text_comprimento.Text = myreader["comprimento"].ToString();
                    text_altura.Text = myreader["altura"].ToString();
                    text_largura.Text = myreader["largura"].ToString();
                    combo_eq_empresa.Text = myreader["empresa_fornecedora"].ToString();

                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }

        private void Carregar_empresa_db()
        {
            try
            {

                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                string comando_sql = "select * from db_cadastro_empresas";

                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();


                while (myreader.Read())
                {
                    combo_eq_empresa.Items.Add(myreader["descricao"].ToString());
                }

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }

        //-------------------------------------------------------------------------------------------
        //Salvar // Atualizar // Deletar

        private void Salvar_empresa()
        {
            // db_cadastro_equipamento


            string codigo_equipamento = text_cod_equipamento.Text;
            string descricao_equipamento = text_descri_equipamento.Text;
            string situacao = combo_situacao_aquipamento.Text;
            double fator = Convert.ToDouble(text_fator.Text);
            double velocidade_padrao = Convert.ToDouble(text_velocidade_padrao.Text);
            double horas_trabalhadas = Convert.ToDouble(text_hr_trabalhada.Text);
            double quilo_hora = Convert.ToDouble(text_quilo_hora.Text);
            double minutos = Convert.ToDouble(text_prod_minuto.Text);
            string patrimonio = text_patriponio.Text;
            double comprimento = Convert.ToDouble(text_comprimento.Text);
            double altura = Convert.ToDouble(text_altura.Text);
            double largura = Convert.ToDouble(text_largura.Text);
            string empresa_fornecedora = combo_eq_empresa.Text;

            // codigo_equipamento, descricao_equipamento, situacao, fator, velocidade_padrao, horas_trabalhadas, quilo_hora, minutos, patrimonio, comprimento, altura, largura, empresa_fornecedora

            //  + codigo_equipamento +"','"+ descricao_equipamento+"','"+ situacao+"','"+ fator+"','"+ velocidade_padrao+"','"+ horas_trabalhadas+"','"+ quilo_hora+"','"+ minutos+"','"+ patrimonio+"','"+ comprimento+"','"+ altura+"','"+ largura+"','"+ empresa_fornecedora

            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                MySqlConnection conexao = new MySqlConnection(conecta_string);
                conexao.Open();

                string comando_sql;

                comando_sql = "INSERT INTO db_cadastro_equipamento(codigo_equipamento, descricao_equipamento, situacao, fator, velocidade_padrao, horas_trabalhadas, quilo_hora, minutos, patrimonio, comprimento, altura, largura, empresa_fornecedora) " +
                    "VALUES('" + codigo_equipamento + "','" + descricao_equipamento + "','" + situacao + "','" + fator + "','" + velocidade_padrao + "','" + horas_trabalhadas + "','" + quilo_hora + "','" + minutos + "','" + patrimonio + "','" + comprimento + "','" + altura + "','" + largura + "','" + empresa_fornecedora + "')";

                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }
        }
        private void Atualizar_empresa(string ID_cadas_equipamento)
        {
            string codigo_equipamento = text_cod_equipamento.Text;
            string descricao_equipamento = text_descri_equipamento.Text;
            string situacao = combo_situacao_aquipamento.Text;
            double fator = Convert.ToDouble(text_fator.Text);
            double velocidade_padrao = Convert.ToDouble(text_velocidade_padrao.Text);
            double horas_trabalhadas = Convert.ToDouble(text_hr_trabalhada.Text);
            double quilo_hora = Convert.ToDouble(text_quilo_hora.Text);
            double minutos = Convert.ToDouble(text_prod_minuto.Text);
            string patrimonio = text_patriponio.Text;
            double comprimento = Convert.ToDouble(text_comprimento.Text);
            double altura = Convert.ToDouble(text_altura.Text);
            double largura = Convert.ToDouble(text_largura.Text);
            string empresa_fornecedora = combo_eq_empresa.Text;

            try
            {
                string comando_sql;

                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                MySqlConnection conexao = new MySqlConnection(conecta_string);
                conexao.Open();

                comando_sql = "UPDATE db_cadastro_equipamento SET " +
                        "codigo_equipamento='" + codigo_equipamento +
                        "', descricao_equipamento='" + descricao_equipamento +
                        "',situacao='" + situacao +
                        "',fator='" + fator +
                        "',velocidade_padrao='" + velocidade_padrao +
                        "',horas_trabalhadas='" + horas_trabalhadas +
                        "',quilo_hora='" + quilo_hora +
                        "',minutos='" + minutos +
                        "',patrimonio='" + patrimonio +
                        "',comprimento='" + comprimento +
                        "',altura='" + altura +
                        "',largura='" + largura +
                        "',empresa_fornecedora='" + empresa_fornecedora +
                        "' WHERE ID_cadas_equipamento=" + ID_cadas_equipamento;

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
        private void Deletar_empresa(string ID_cadas_equipamento)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                MySqlConnection conexao = new MySqlConnection(conecta_string);
                conexao.Open();

                string comando_sql;

                comando_sql = "DELETE FROM db_cadastro_equipamento WHERE ID_cadas_equipamento = " + ID_cadas_equipamento;

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
        private void Limpar_controles()
        {
            text_cod_equipamento.Text = string.Empty;
            text_descri_equipamento.Text = string.Empty;
            combo_situacao_aquipamento.Text = string.Empty;
            text_fator.Text = "0";
            text_velocidade_padrao.Text = "0";
            text_hr_trabalhada.Text = "0";
            text_quilo_hora.Text = "0";
            text_prod_minuto.Text = "0";
            text_patriponio.Text = string.Empty;
            text_comprimento.Text = "0";
            text_altura.Text = "0";
            text_largura.Text = "0";
            combo_eq_empresa.Text = string.Empty;
        }

        // db_cadastro_equipamento

        // ID_cadas_equipamento
        // codigo_equipamento
        // descricao_equipamento
        // situacao
        // fator
        // velocidade_padrao
        // horas_trabalhadas
        // quilo/hora
        // minutos
        // patrimonio
        // comprimento
        // altura
        // largura
        // empresa_fornecedora





        //-------------------------------------------------------------------------------------------
        // Botões

        private void button_salvar_Click(object sender, EventArgs e)
        {
            Salvar_empresa();
            Limpar_controles();
            Carregar_grid_equipamento();

        }

        private void button_atualizar_Click(object sender, EventArgs e)
        {
            Atualizar_empresa(label_id_cad_equipamento.Text);
            Limpar_controles();
            Carregar_grid_equipamento();
        }

        private void button_deletar_Click(object sender, EventArgs e)
        {
            Deletar_empresa(label_id_cad_equipamento.Text);
            Limpar_controles();
            Carregar_grid_equipamento();
        }

        private void button_limpar_controles_Click(object sender, EventArgs e)
        {
            Limpar_controles();
        }

        private void grid_cad_empresa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string ID_cadas_equipamento = grid_cad_empresa.CurrentRow.Cells[0].Value.ToString();
            label_id_cad_equipamento.Text = ID_cadas_equipamento;
            Carregar_controles(ID_cadas_equipamento);
        }


    }
}
