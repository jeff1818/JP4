using ClosedXML.Excel;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Threading;


namespace JP4.Config
{
    public partial class Form_exportar_dados : Form
    {
        public Form_exportar_dados()
        {
            InitializeComponent();

            Ler_arquivo_config_ini();
        }

        

        #region Configuração INI
        private void Ler_arquivo_config_ini()
        {
            IniFile config_ini = new IniFile(@"C:\JP4", "config_app");

            string local_default = @"C:\JP4";

            text_local_export.Text = config_ini.IniReadString("LOCAL_EXPORT", "local_exporta_arquivo", local_default);

        }

        private string Procurar_pasta_os()
        {
            string local_pasta;
            string nome_arquivo;
            string endereco_completo = string.Empty;

            OpenFileDialog folderBrowser = new OpenFileDialog();

            folderBrowser.ValidateNames = true;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;

            folderBrowser.FileName = "Localizar Arquivo";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                local_pasta = Path.GetDirectoryName(folderBrowser.FileName);
                nome_arquivo = Path.GetFileName(folderBrowser.FileName);

                endereco_completo = local_pasta + @"\";//  + "Relatorio.xlsx"; // nome_arquivo;
                //criar_pasta_backup(local_pasta);
            }

            return endereco_completo;
        }
        #endregion


        #region Metodos Exportar
        
        private void criar_pasta_backup(string local_db)
        {
            string folderName = local_db + @"\Export_dados";
            // If directory does not exist, create it
            if (!Directory.Exists(folderName))
            {
                Directory.CreateDirectory(folderName);
            }


        }
                

        private void Exportar_dados_mysql(string comando_sql, string nome_aba, string nome_arquivo)
        {
          using(var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add(nome_aba);

                //string comando_sql = "select * from estoque_trans";
                string conexao = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                MySqlConnection connection = new MySqlConnection(conexao);
                var comando = new MySqlCommand(comando_sql, connection);

                using (connection)
                {
                    connection.Open();

                    var dr = comando.ExecuteReader();
                    int qtd_colunas = dr.FieldCount;
                    

                    for (int coluna = 1; coluna <= qtd_colunas; coluna++)
                    {
                        worksheet.Cell(1, coluna).Value = dr.GetName(coluna - 1);
                    }

                    int linha = 1;
                    
                    while (dr.Read())
                    {
                        linha++;
                        for(int coluna = 1;coluna <= qtd_colunas; coluna++)
                        {
                            worksheet.Cell(linha, coluna).Value = dr[coluna - 1];
                        }
                    }

                    connection.Close();

                    backgroundWorker1.RunWorkerAsync();

                };
                
                //workbook.SaveAs(@"C:\JP4\Export_dados\Relatorio.xlsx");
                workbook.SaveAs(text_local_export.Text + nome_arquivo);

            }

            //Process.Start(new ProcessStartInfo(@"C:\JP4\Export_dados\Relatorio.xlsx") {UseShellExecute = true });
            
            //Process.Start(new ProcessStartInfo(text_local_export.Text +  nome_arquivo) { UseShellExecute = true });


        }
        #endregion


        private void button_exportar_dados_Click(object sender, EventArgs e){}

        private void button_buscar_local_Click(object sender, EventArgs e)
        {
            text_local_export.Text = Procurar_pasta_os();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Salvar local

            if (text_local_export.Text != string.Empty)
            {
                IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                config_ini.IniWriteString("LOCAL_EXPORT", "local_exporta_arquivo", text_local_export.Text);

                MessageBox.Show("Salvo com sucesso!");

            }
            else
            {
                MessageBox.Show("Campo de endereço não pode ficar em branco!");
            }

        }

        private void button_apontamento_Click(object sender, EventArgs e)
        {
            label_titulo_tabela.Text = "Gerando tabela de apontamento";
            Exportar_dados_mysql("select * from estoque_trans", "estoque_trans", "db_estoque_trans.xlsx");            
            MessageBox.Show("Salvo com sucesso!");
            backgroundWorker1.Dispose();

        }

        private void button_defeitos_Click(object sender, EventArgs e)
        {
            label_titulo_tabela.Text = "Gerando tabela de defeitos/Aparas";
            Exportar_dados_mysql("select * from db_defeitos_mq", "defeitos", "db_defeitos.xlsx");
            MessageBox.Show("Salvo com sucesso!");
            backgroundWorker1.Dispose();
        }

        private void button_paradas_Click(object sender, EventArgs e)
        {
            label_titulo_tabela.Text = "Gerando tabela de paradas de maquina";
            Exportar_dados_mysql("select * from db_paradas_mq", "paradas_mq", "db_paradas.xlsx");
            MessageBox.Show("Salvo com sucesso!");
            backgroundWorker1.Dispose();
        }

        private void button_consumo_mp_Click(object sender, EventArgs e)
        {
            label_titulo_tabela.Text = "Gerando tabela de consumo materia prima";
            Exportar_dados_mysql("select * from db_mp_apon", "consumo_mp", "db_consumo_mp.xlsx");
            MessageBox.Show("Salvo com sucesso!");
            backgroundWorker1.Dispose();
        }
        private void button_exportar_cadastro_Click(object sender, EventArgs e)
        {
            label_titulo_tabela.Text = "Gerando tabela de cadastro de material";
            Exportar_dados_mysql("select * from db_cadastro_material", "cadastro_material", "db_cadastro.xlsx");
            MessageBox.Show("Salvo com sucesso!");
            backgroundWorker1.Dispose();
        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void combo_filtro_mes_SelectedIndexChanged(object sender, EventArgs e){}

        private void combo_filtro_ano_SelectedIndexChanged(object sender, EventArgs e){}

        private void button_exportar_todos_Click(object sender, EventArgs e)
        {
            // Todos ainda não funciona muito bem 05/01

            MessageBox.Show("O processo vai varios minutos para terminar!");

            label_titulo_tabela.Text = "Gerando Tabela de apontamento";
            Exportar_dados_mysql("select * from estoque_trans", "estoque_trans", "db_estoque_trans.xlsx");
            backgroundWorker1.Dispose();

            label_titulo_tabela.Text = "Gerando Tabela de defeitos/Aparas";
            Exportar_dados_mysql("select * from db_defeitos_mq", "defeitos", "db_defeitos.xlsx");
            backgroundWorker1.Dispose();

            label_titulo_tabela.Text = "Gerando Tabela de Paradas de maquina";
            Exportar_dados_mysql("select * from db_paradas_mq", "paradas_mq", "db_paradas.xlsx");
            backgroundWorker1.Dispose();

            label_titulo_tabela.Text = "Gerando Tabela de consumo materia-prima";
            Exportar_dados_mysql("select * from db_mp_apon", "consumo_mp", "db_consumo_mp.xlsx");
            backgroundWorker1.Dispose();

            label_titulo_tabela.Text = "Gerando Tabela de cadastro de material";
            Exportar_dados_mysql("select * from db_cadastro_material", "cadastro_material", "db_cadastro.xlsx");
            backgroundWorker1.Dispose();

            MessageBox.Show("Todos os arquivos gerados com sucesso!");

            label_titulo_tabela.Text = "Finalizado!";
        }

       

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            for(int i = 1; i <= 100; i++)
            {
                Thread.Sleep(10);
                backgroundWorker1.WorkerReportsProgress = true;
                backgroundWorker1.ReportProgress(i);
            }

        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
    }
}
