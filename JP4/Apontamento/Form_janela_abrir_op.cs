using ClosedXML.Excel;
using System;
using System.Linq;
using System.Windows.Forms;

namespace JP4
{
    public partial class OP001 : Form
    {
        public OP001()
        {
            InitializeComponent();
        }


        #region carrega itens do arquivo de excel

        //private void Importar_ordens()
        //{

        //    try
        //    {
        //        // adicionar uma janela para o usuário esclher a pasta e local da pasta
        //        // adicionar uma opção para escolher o nome da aba dentro do arquivo


        //        var xls = new XLWorkbook(Properties.Settings.Default.local_arquivo_excel);
        //        var planilha = xls.Worksheets.First(w => w.Name == "db_ordem_prod");
        //        var totalLinhas = planilha.Rows().Count();
        //        // primeira linha é o cabecalho
        //        for (int l = 2; l <= totalLinhas; l++)
        //        {
        //            if (planilha.Cell($"G{l}").Value.ToString() != "Digitada");
        //                //combo_ordem_prod.Items.Add(planilha.Cell($"B{l}").Value.ToString());
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //}

        private void carregar_descricao_completa(string ordem_prod)
        {
            try
            {
                // Referencia https://carloscds.net/2021/01/lendo-planilha-excel-mais-simples/
                // adicionar uma janela para o usuário esclher a pasta e local da pasta
                // adicionar uma opção para escolher o nome da aba dentro do arquivo

                var xls = new XLWorkbook(Properties.Settings.Default.local_arquivo_excel);
                var planilha = xls.Worksheets.First(w => w.Name == "db_ordem_prod");
                var totalLinhas = planilha.Rows().Count();
                // primeira linha é o cabecalho
                for (int l = 2; l <= totalLinhas; l++)
                {
                    if (planilha.Cell($"B{l}").Value.ToString() == ordem_prod & planilha.Cell($"G{l}").Value.ToString() != "Digitada")
                    {
                        //combo_desc_completa.Text = planilha.Cell($"F{l}").Value.ToString();


                        break;
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void carregar_cod_item(string ordem_prod)
        {
            try
            {
                // Referencia https://carloscds.net/2021/01/lendo-planilha-excel-mais-simples/
                // adicionar uma janela para o usuário esclher a pasta e local da pasta
                // adicionar uma opção para escolher o nome da aba dentro do arquivo

                //var xls = new XLWorkbook(@"C:\Users\Jeferson\OneDrive\Visual - basic c#\Import_sistema\db_ordem_prod.xlsx");
                var xls = new XLWorkbook(Properties.Settings.Default.local_arquivo_excel);
                var planilha = xls.Worksheets.First(w => w.Name == "db_ordem_prod");
                var totalLinhas = planilha.Rows().Count();
                // primeira linha é o cabecalho
                for (int l = 2; l <= totalLinhas; l++)
                {
                    if (planilha.Cell($"B{l}").Value.ToString() == ordem_prod & planilha.Cell($"G{l}").Value.ToString() != "Digitada")
                    {
                        //combo_cod_item.Text = planilha.Cell($"E{l}").Value.ToString();
                        break;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void carregar_qtd_prevista(string ordem_prod)
        {
            try
            {
                // Referencia https://carloscds.net/2021/01/lendo-planilha-excel-mais-simples/
                // adicionar uma janela para o usuário esclher a pasta e local da pasta
                // adicionar uma opção para escolher o nome da aba dentro do arquivo

                //var xls = new XLWorkbook(@"C:\Users\Jeferson\OneDrive\Visual - basic c#\Import_sistema\db_ordem_prod.xlsx");
                var xls = new XLWorkbook(Properties.Settings.Default.local_arquivo_excel);
                var planilha = xls.Worksheets.First(w => w.Name == "db_ordem_prod");
                var totalLinhas = planilha.Rows().Count();
                // primeira linha é o cabecalho
                for (int l = 2; l <= totalLinhas; l++)
                {
                    if (planilha.Cell($"B{l}").Value.ToString() == ordem_prod & planilha.Cell($"G{l}").Value.ToString() != "Digitada")
                    {
                        //text_qtd_planejada.Text = planilha.Cell($"H{l}").Value.ToString();
                        break;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void carregar_maquina_arquivo(string ordem_prod)
        {
            try
            {
                // Referencia https://carloscds.net/2021/01/lendo-planilha-excel-mais-simples/
                // adicionar uma janela para o usuário esclher a pasta e local da pasta
                // adicionar uma opção para escolher o nome da aba dentro do arquivo

                //var xls = new XLWorkbook(@"C:\Users\Jeferson\OneDrive\Visual - basic c#\Import_sistema\db_ordem_prod.xlsx");
                var xls = new XLWorkbook(Properties.Settings.Default.local_arquivo_excel);
                var planilha = xls.Worksheets.First(w => w.Name == "db_ordem_prod");
                var totalLinhas = planilha.Rows().Count();
                // primeira linha é o cabecalho
                for (int l = 2; l <= totalLinhas; l++)
                {
                    if (planilha.Cell($"B{l}").Value.ToString() == ordem_prod & planilha.Cell($"G{l}").Value.ToString() != "Digitada")
                    {
                        // combo_maquinas.Text = planilha.Cell($"A{l}").Value.ToString();
                        break;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion // Carregar itens excel 



        #region Metodos para Carregar controles
        private void Carrega_empresa()
        {

        }
        private void Carrega_setor_maquina()
        {

        }

        private void Carrega_status_op()
        {

        }

        private void Carrega_produto_op()
        {

        }

        private void Caregar_grid()
        {

        }

        #endregion

        #region Metodos de Busca


        #endregion

        #region Metodos Salvar // Atualizar // Deletar 
        #endregion




    }
}
