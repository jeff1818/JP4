
namespace JP4
{
    partial class STOQ01
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadMaterialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadOperaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadMaquinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadLocaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadEmpresasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventárioMensalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_mov_estoque = new System.Windows.Forms.TabPage();
            this.tab_relatorio_estoque = new System.Windows.Forms.TabPage();
            this.grid_mov_estoque = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_descricao_operacao = new System.Windows.Forms.Label();
            this.combo_empresa = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label_id_stoque_trans = new System.Windows.Forms.Label();
            this.rich_observa = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.combo_local_destino = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.combo_local_orig = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.text_qtd_movt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.text_tipo_mov = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.combo_secao_maquina = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.text_num_documento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dt_movt = new System.Windows.Forms.DateTimePicker();
            this.dt_lancamento = new System.Windows.Forms.DateTimePicker();
            this.combo_operacao = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_descri_completa = new System.Windows.Forms.ComboBox();
            this.combo_cod_item = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox_mes_filtro = new System.Windows.Forms.ComboBox();
            this.textBox_ano_filtro = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button_limpar_filtro = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_buscar = new System.Windows.Forms.Button();
            this.button_estornar = new System.Windows.Forms.Button();
            this.button_salvar = new System.Windows.Forms.Button();
            this.button_iniciar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.Grid_relatorio_estoque = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_mov_estoque.SuspendLayout();
            this.tab_relatorio_estoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_mov_estoque)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_relatorio_estoque)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.inventárioToolStripMenuItem,
            this.relatorioEstoqueToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1012, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadMaterialToolStripMenuItem,
            this.cadOperaçãoToolStripMenuItem,
            this.cadMaquinaToolStripMenuItem,
            this.cadLocaisToolStripMenuItem,
            this.cadEmpresasToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // cadMaterialToolStripMenuItem
            // 
            this.cadMaterialToolStripMenuItem.Name = "cadMaterialToolStripMenuItem";
            this.cadMaterialToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cadMaterialToolStripMenuItem.Text = "Cad. Material";
            // 
            // cadOperaçãoToolStripMenuItem
            // 
            this.cadOperaçãoToolStripMenuItem.Name = "cadOperaçãoToolStripMenuItem";
            this.cadOperaçãoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cadOperaçãoToolStripMenuItem.Text = "Cad. Operação";
            // 
            // cadMaquinaToolStripMenuItem
            // 
            this.cadMaquinaToolStripMenuItem.Name = "cadMaquinaToolStripMenuItem";
            this.cadMaquinaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cadMaquinaToolStripMenuItem.Text = "Cad. Maquina";
            // 
            // cadLocaisToolStripMenuItem
            // 
            this.cadLocaisToolStripMenuItem.Name = "cadLocaisToolStripMenuItem";
            this.cadLocaisToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cadLocaisToolStripMenuItem.Text = "Cad. Locais";
            // 
            // cadEmpresasToolStripMenuItem
            // 
            this.cadEmpresasToolStripMenuItem.Name = "cadEmpresasToolStripMenuItem";
            this.cadEmpresasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cadEmpresasToolStripMenuItem.Text = "Cad. Empresas";
            // 
            // inventárioToolStripMenuItem
            // 
            this.inventárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventárioMensalToolStripMenuItem});
            this.inventárioToolStripMenuItem.Name = "inventárioToolStripMenuItem";
            this.inventárioToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.inventárioToolStripMenuItem.Text = "Inventário";
            // 
            // inventárioMensalToolStripMenuItem
            // 
            this.inventárioMensalToolStripMenuItem.Name = "inventárioMensalToolStripMenuItem";
            this.inventárioMensalToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.inventárioMensalToolStripMenuItem.Text = "Inventário Mensal";
            this.inventárioMensalToolStripMenuItem.Click += new System.EventHandler(this.inventárioMensalToolStripMenuItem_Click);
            // 
            // relatorioEstoqueToolStripMenuItem
            // 
            this.relatorioEstoqueToolStripMenuItem.Name = "relatorioEstoqueToolStripMenuItem";
            this.relatorioEstoqueToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.relatorioEstoqueToolStripMenuItem.Text = "Relatorio Estoque";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_mov_estoque);
            this.tabControl1.Controls.Add(this.tab_relatorio_estoque);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1012, 578);
            this.tabControl1.TabIndex = 8;
            // 
            // tab_mov_estoque
            // 
            this.tab_mov_estoque.Controls.Add(this.grid_mov_estoque);
            this.tab_mov_estoque.Controls.Add(this.groupBox2);
            this.tab_mov_estoque.Controls.Add(this.groupBox1);
            this.tab_mov_estoque.Location = new System.Drawing.Point(4, 22);
            this.tab_mov_estoque.Name = "tab_mov_estoque";
            this.tab_mov_estoque.Padding = new System.Windows.Forms.Padding(3);
            this.tab_mov_estoque.Size = new System.Drawing.Size(1004, 552);
            this.tab_mov_estoque.TabIndex = 0;
            this.tab_mov_estoque.Text = "Movimentação";
            this.tab_mov_estoque.UseVisualStyleBackColor = true;
            // 
            // tab_relatorio_estoque
            // 
            this.tab_relatorio_estoque.Controls.Add(this.Grid_relatorio_estoque);
            this.tab_relatorio_estoque.Controls.Add(this.groupBox3);
            this.tab_relatorio_estoque.Location = new System.Drawing.Point(4, 22);
            this.tab_relatorio_estoque.Name = "tab_relatorio_estoque";
            this.tab_relatorio_estoque.Padding = new System.Windows.Forms.Padding(3);
            this.tab_relatorio_estoque.Size = new System.Drawing.Size(1004, 552);
            this.tab_relatorio_estoque.TabIndex = 1;
            this.tab_relatorio_estoque.Text = "Relatório Estoque";
            this.tab_relatorio_estoque.UseVisualStyleBackColor = true;
            // 
            // grid_mov_estoque
            // 
            this.grid_mov_estoque.AllowUserToAddRows = false;
            this.grid_mov_estoque.AllowUserToDeleteRows = false;
            this.grid_mov_estoque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_mov_estoque.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grid_mov_estoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_mov_estoque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_mov_estoque.Location = new System.Drawing.Point(131, 237);
            this.grid_mov_estoque.Name = "grid_mov_estoque";
            this.grid_mov_estoque.ReadOnly = true;
            this.grid_mov_estoque.Size = new System.Drawing.Size(870, 312);
            this.grid_mov_estoque.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_descricao_operacao);
            this.groupBox2.Controls.Add(this.combo_empresa);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label_id_stoque_trans);
            this.groupBox2.Controls.Add(this.rich_observa);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.combo_local_destino);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.combo_local_orig);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.text_qtd_movt);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.text_tipo_mov);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.combo_secao_maquina);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.text_num_documento);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dt_movt);
            this.groupBox2.Controls.Add(this.dt_lancamento);
            this.groupBox2.Controls.Add(this.combo_operacao);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.combo_descri_completa);
            this.groupBox2.Controls.Add(this.combo_cod_item);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(131, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(870, 234);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "...";
            // 
            // label_descricao_operacao
            // 
            this.label_descricao_operacao.AutoSize = true;
            this.label_descricao_operacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_descricao_operacao.Location = new System.Drawing.Point(220, 49);
            this.label_descricao_operacao.Name = "label_descricao_operacao";
            this.label_descricao_operacao.Size = new System.Drawing.Size(47, 13);
            this.label_descricao_operacao.TabIndex = 28;
            this.label_descricao_operacao.Text = "..........";
            // 
            // combo_empresa
            // 
            this.combo_empresa.FormattingEnabled = true;
            this.combo_empresa.Location = new System.Drawing.Point(730, 139);
            this.combo_empresa.Name = "combo_empresa";
            this.combo_empresa.Size = new System.Drawing.Size(128, 21);
            this.combo_empresa.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(727, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Empresa";
            // 
            // label_id_stoque_trans
            // 
            this.label_id_stoque_trans.AutoSize = true;
            this.label_id_stoque_trans.Location = new System.Drawing.Point(727, 203);
            this.label_id_stoque_trans.Name = "label_id_stoque_trans";
            this.label_id_stoque_trans.Size = new System.Drawing.Size(19, 13);
            this.label_id_stoque_trans.TabIndex = 25;
            this.label_id_stoque_trans.Text = "....";
            // 
            // rich_observa
            // 
            this.rich_observa.Location = new System.Drawing.Point(85, 152);
            this.rich_observa.Name = "rich_observa";
            this.rich_observa.Size = new System.Drawing.Size(602, 64);
            this.rich_observa.TabIndex = 10;
            this.rich_observa.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 175);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Observação:";
            // 
            // combo_local_destino
            // 
            this.combo_local_destino.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.combo_local_destino.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_local_destino.FormattingEnabled = true;
            this.combo_local_destino.Location = new System.Drawing.Point(291, 125);
            this.combo_local_destino.Name = "combo_local_destino";
            this.combo_local_destino.Size = new System.Drawing.Size(128, 21);
            this.combo_local_destino.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(213, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Local Destino:";
            // 
            // combo_local_orig
            // 
            this.combo_local_orig.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.combo_local_orig.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_local_orig.FormattingEnabled = true;
            this.combo_local_orig.Location = new System.Drawing.Point(85, 125);
            this.combo_local_orig.Name = "combo_local_orig";
            this.combo_local_orig.Size = new System.Drawing.Size(128, 21);
            this.combo_local_orig.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Local Origem:";
            // 
            // text_qtd_movt
            // 
            this.text_qtd_movt.Location = new System.Drawing.Point(85, 99);
            this.text_qtd_movt.Name = "text_qtd_movt";
            this.text_qtd_movt.Size = new System.Drawing.Size(128, 20);
            this.text_qtd_movt.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Qtd. Movt.";
            // 
            // text_tipo_mov
            // 
            this.text_tipo_mov.Enabled = false;
            this.text_tipo_mov.Location = new System.Drawing.Point(489, 74);
            this.text_tipo_mov.Name = "text_tipo_mov";
            this.text_tipo_mov.Size = new System.Drawing.Size(44, 20);
            this.text_tipo_mov.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(425, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tipo Movt.";
            // 
            // combo_secao_maquina
            // 
            this.combo_secao_maquina.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.combo_secao_maquina.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_secao_maquina.FormattingEnabled = true;
            this.combo_secao_maquina.Location = new System.Drawing.Point(291, 73);
            this.combo_secao_maquina.Name = "combo_secao_maquina";
            this.combo_secao_maquina.Size = new System.Drawing.Size(128, 21);
            this.combo_secao_maquina.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(219, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Seção / MQ";
            // 
            // text_num_documento
            // 
            this.text_num_documento.Location = new System.Drawing.Point(85, 73);
            this.text_num_documento.Name = "text_num_documento";
            this.text_num_documento.Size = new System.Drawing.Size(128, 20);
            this.text_num_documento.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Documento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(727, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dt. Lançamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(727, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Dt. Mov";
            // 
            // dt_movt
            // 
            this.dt_movt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_movt.Location = new System.Drawing.Point(730, 38);
            this.dt_movt.Name = "dt_movt";
            this.dt_movt.Size = new System.Drawing.Size(128, 20);
            this.dt_movt.TabIndex = 9;
            // 
            // dt_lancamento
            // 
            this.dt_lancamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_lancamento.Location = new System.Drawing.Point(730, 82);
            this.dt_lancamento.Name = "dt_lancamento";
            this.dt_lancamento.Size = new System.Drawing.Size(128, 20);
            this.dt_lancamento.TabIndex = 7;
            // 
            // combo_operacao
            // 
            this.combo_operacao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.combo_operacao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_operacao.FormattingEnabled = true;
            this.combo_operacao.Location = new System.Drawing.Point(85, 46);
            this.combo_operacao.Name = "combo_operacao";
            this.combo_operacao.Size = new System.Drawing.Size(128, 21);
            this.combo_operacao.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Operação:";
            // 
            // combo_descri_completa
            // 
            this.combo_descri_completa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.combo_descri_completa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_descri_completa.FormattingEnabled = true;
            this.combo_descri_completa.Location = new System.Drawing.Point(291, 19);
            this.combo_descri_completa.Name = "combo_descri_completa";
            this.combo_descri_completa.Size = new System.Drawing.Size(392, 21);
            this.combo_descri_completa.TabIndex = 2;
            // 
            // combo_cod_item
            // 
            this.combo_cod_item.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combo_cod_item.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_cod_item.FormattingEnabled = true;
            this.combo_cod_item.Location = new System.Drawing.Point(85, 19);
            this.combo_cod_item.Name = "combo_cod_item";
            this.combo_cod_item.Size = new System.Drawing.Size(128, 21);
            this.combo_cod_item.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.comboBox_mes_filtro);
            this.groupBox1.Controls.Add(this.textBox_ano_filtro);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.button_limpar_filtro);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button_buscar);
            this.groupBox1.Controls.Add(this.button_estornar);
            this.groupBox1.Controls.Add(this.button_salvar);
            this.groupBox1.Controls.Add(this.button_iniciar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 546);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 279);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "Filtro Mês";
            // 
            // comboBox_mes_filtro
            // 
            this.comboBox_mes_filtro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBox_mes_filtro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_mes_filtro.FormattingEnabled = true;
            this.comboBox_mes_filtro.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBox_mes_filtro.Location = new System.Drawing.Point(67, 276);
            this.comboBox_mes_filtro.Name = "comboBox_mes_filtro";
            this.comboBox_mes_filtro.Size = new System.Drawing.Size(55, 21);
            this.comboBox_mes_filtro.TabIndex = 19;
            // 
            // textBox_ano_filtro
            // 
            this.textBox_ano_filtro.Location = new System.Drawing.Point(67, 250);
            this.textBox_ano_filtro.Name = "textBox_ano_filtro";
            this.textBox_ano_filtro.Size = new System.Drawing.Size(55, 20);
            this.textBox_ano_filtro.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 252);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Filtro Ano";
            // 
            // button_limpar_filtro
            // 
            this.button_limpar_filtro.Location = new System.Drawing.Point(6, 163);
            this.button_limpar_filtro.Name = "button_limpar_filtro";
            this.button_limpar_filtro.Size = new System.Drawing.Size(116, 23);
            this.button_limpar_filtro.TabIndex = 5;
            this.button_limpar_filtro.Text = "Limpar Filtro";
            this.button_limpar_filtro.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Atualizar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button_buscar
            // 
            this.button_buscar.Location = new System.Drawing.Point(6, 134);
            this.button_buscar.Name = "button_buscar";
            this.button_buscar.Size = new System.Drawing.Size(116, 23);
            this.button_buscar.TabIndex = 3;
            this.button_buscar.Text = "Filtrar";
            this.button_buscar.UseVisualStyleBackColor = true;
            // 
            // button_estornar
            // 
            this.button_estornar.Location = new System.Drawing.Point(6, 105);
            this.button_estornar.Name = "button_estornar";
            this.button_estornar.Size = new System.Drawing.Size(116, 23);
            this.button_estornar.TabIndex = 2;
            this.button_estornar.Text = "Estornar";
            this.button_estornar.UseVisualStyleBackColor = true;
            // 
            // button_salvar
            // 
            this.button_salvar.Location = new System.Drawing.Point(6, 47);
            this.button_salvar.Name = "button_salvar";
            this.button_salvar.Size = new System.Drawing.Size(116, 23);
            this.button_salvar.TabIndex = 1;
            this.button_salvar.Text = "Salvar";
            this.button_salvar.UseVisualStyleBackColor = true;
            // 
            // button_iniciar
            // 
            this.button_iniciar.Location = new System.Drawing.Point(6, 19);
            this.button_iniciar.Name = "button_iniciar";
            this.button_iniciar.Size = new System.Drawing.Size(116, 23);
            this.button_iniciar.TabIndex = 0;
            this.button_iniciar.Text = "Iniciar";
            this.button_iniciar.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.comboBox3);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.dateTimePicker2);
            this.groupBox3.Controls.Add(this.comboBox6);
            this.groupBox3.Controls.Add(this.comboBox7);
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Controls.Add(this.label30);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(998, 152);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "...";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(85, 100);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(128, 21);
            this.comboBox1.TabIndex = 27;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(31, 108);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 13);
            this.label17.TabIndex = 26;
            this.label17.Text = "Empresa";
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(300, 46);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(128, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(219, 49);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(75, 13);
            this.label20.TabIndex = 21;
            this.label20.Text = "Local Destino:";
            // 
            // comboBox3
            // 
            this.comboBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(85, 46);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(128, 21);
            this.comboBox3.TabIndex = 7;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(7, 49);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(72, 13);
            this.label21.TabIndex = 19;
            this.label21.Text = "Local Origem:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(727, 66);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(83, 13);
            this.label26.TabIndex = 10;
            this.label26.Text = "Dt. Lançamento";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(34, 79);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(45, 13);
            this.label27.TabIndex = 9;
            this.label27.Text = "Dt. Mov";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(85, 73);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(128, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(730, 82);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(128, 20);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // comboBox6
            // 
            this.comboBox6.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBox6.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(300, 19);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(392, 21);
            this.comboBox6.TabIndex = 2;
            // 
            // comboBox7
            // 
            this.comboBox7.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox7.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(85, 19);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(128, 21);
            this.comboBox7.TabIndex = 1;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(219, 22);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(58, 13);
            this.label29.TabIndex = 1;
            this.label29.Text = "Descrição:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(49, 22);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(30, 13);
            this.label30.TabIndex = 0;
            this.label30.Text = "Item:";
            // 
            // Grid_relatorio_estoque
            // 
            this.Grid_relatorio_estoque.AllowUserToAddRows = false;
            this.Grid_relatorio_estoque.AllowUserToDeleteRows = false;
            this.Grid_relatorio_estoque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_relatorio_estoque.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Grid_relatorio_estoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_relatorio_estoque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid_relatorio_estoque.Location = new System.Drawing.Point(3, 155);
            this.Grid_relatorio_estoque.Name = "Grid_relatorio_estoque";
            this.Grid_relatorio_estoque.ReadOnly = true;
            this.Grid_relatorio_estoque.Size = new System.Drawing.Size(998, 394);
            this.Grid_relatorio_estoque.TabIndex = 11;
            // 
            // STOQ01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 602);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "STOQ01";
            this.Text = "Form_janela_mov_estoque";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tab_mov_estoque.ResumeLayout(false);
            this.tab_relatorio_estoque.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_mov_estoque)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_relatorio_estoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadMaterialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadOperaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadMaquinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadLocaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadEmpresasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventárioMensalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioEstoqueToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_mov_estoque;
        private System.Windows.Forms.DataGridView grid_mov_estoque;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_descricao_operacao;
        private System.Windows.Forms.ComboBox combo_empresa;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label_id_stoque_trans;
        private System.Windows.Forms.RichTextBox rich_observa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox combo_local_destino;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox combo_local_orig;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox text_qtd_movt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox text_tipo_mov;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox combo_secao_maquina;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox text_num_documento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dt_movt;
        private System.Windows.Forms.DateTimePicker dt_lancamento;
        private System.Windows.Forms.ComboBox combo_operacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_descri_completa;
        private System.Windows.Forms.ComboBox combo_cod_item;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox_mes_filtro;
        private System.Windows.Forms.TextBox textBox_ano_filtro;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button_limpar_filtro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_buscar;
        private System.Windows.Forms.Button button_estornar;
        private System.Windows.Forms.Button button_salvar;
        private System.Windows.Forms.Button button_iniciar;
        private System.Windows.Forms.TabPage tab_relatorio_estoque;
        private System.Windows.Forms.DataGridView Grid_relatorio_estoque;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
    }
}