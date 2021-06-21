
namespace JP4
{
    partial class OP001
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
            this.importarOrdensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl_abrir_ordem = new System.Windows.Forms.TabControl();
            this.tab_abrir_ordem_pg01 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button_localizar_op = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.grid_ordem_prod = new System.Windows.Forms.DataGridView();
            this.richTextBox_obs = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combo_setor_maquina_op = new System.Windows.Forms.ComboBox();
            this.text_qtd_produzida_op = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.text_qtd_prevista_op = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dt_fim_op = new System.Windows.Forms.DateTimePicker();
            this.dt_inicio_op = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.combo_empresa = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.combo_status_ordem = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.combo_produto_op = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_num_ordem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_imprmir_op = new System.Windows.Forms.Button();
            this.button_deletar_op = new System.Windows.Forms.Button();
            this.button_salvar_op = new System.Windows.Forms.Button();
            this.button_abrir_ordem = new System.Windows.Forms.Button();
            this.tab_impoartar_pg02 = new System.Windows.Forms.TabPage();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadMaterialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tabControl_abrir_ordem.SuspendLayout();
            this.tab_abrir_ordem_pg01.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_ordem_prod)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importarOrdensToolStripMenuItem,
            this.cadastrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1113, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // importarOrdensToolStripMenuItem
            // 
            this.importarOrdensToolStripMenuItem.Name = "importarOrdensToolStripMenuItem";
            this.importarOrdensToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.importarOrdensToolStripMenuItem.Text = "Importar ordens";
            // 
            // tabControl_abrir_ordem
            // 
            this.tabControl_abrir_ordem.Controls.Add(this.tab_abrir_ordem_pg01);
            this.tabControl_abrir_ordem.Controls.Add(this.tab_impoartar_pg02);
            this.tabControl_abrir_ordem.Location = new System.Drawing.Point(12, 27);
            this.tabControl_abrir_ordem.Name = "tabControl_abrir_ordem";
            this.tabControl_abrir_ordem.SelectedIndex = 0;
            this.tabControl_abrir_ordem.Size = new System.Drawing.Size(1089, 486);
            this.tabControl_abrir_ordem.TabIndex = 1;
            // 
            // tab_abrir_ordem_pg01
            // 
            this.tab_abrir_ordem_pg01.Controls.Add(this.groupBox2);
            this.tab_abrir_ordem_pg01.Controls.Add(this.grid_ordem_prod);
            this.tab_abrir_ordem_pg01.Controls.Add(this.richTextBox_obs);
            this.tab_abrir_ordem_pg01.Controls.Add(this.groupBox1);
            this.tab_abrir_ordem_pg01.Controls.Add(this.groupBox3);
            this.tab_abrir_ordem_pg01.Location = new System.Drawing.Point(4, 22);
            this.tab_abrir_ordem_pg01.Name = "tab_abrir_ordem_pg01";
            this.tab_abrir_ordem_pg01.Padding = new System.Windows.Forms.Padding(3);
            this.tab_abrir_ordem_pg01.Size = new System.Drawing.Size(1081, 460);
            this.tab_abrir_ordem_pg01.TabIndex = 0;
            this.tab_abrir_ordem_pg01.Text = "Abrir Ordem";
            this.tab_abrir_ordem_pg01.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button_localizar_op);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(768, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 129);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Limpar:";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button_localizar_op
            // 
            this.button_localizar_op.Location = new System.Drawing.Point(71, 97);
            this.button_localizar_op.Name = "button_localizar_op";
            this.button_localizar_op.Size = new System.Drawing.Size(77, 23);
            this.button_localizar_op.TabIndex = 6;
            this.button_localizar_op.Text = "Localizar";
            this.button_localizar_op.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(71, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Empresa:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(71, 43);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(159, 21);
            this.comboBox2.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Produto:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 20);
            this.textBox1.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(26, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "N° Op:";
            // 
            // grid_ordem_prod
            // 
            this.grid_ordem_prod.AllowUserToAddRows = false;
            this.grid_ordem_prod.AllowUserToDeleteRows = false;
            this.grid_ordem_prod.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_ordem_prod.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grid_ordem_prod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_ordem_prod.Location = new System.Drawing.Point(768, 141);
            this.grid_ordem_prod.Name = "grid_ordem_prod";
            this.grid_ordem_prod.ReadOnly = true;
            this.grid_ordem_prod.Size = new System.Drawing.Size(307, 306);
            this.grid_ordem_prod.TabIndex = 10;
            // 
            // richTextBox_obs
            // 
            this.richTextBox_obs.Location = new System.Drawing.Point(136, 210);
            this.richTextBox_obs.Name = "richTextBox_obs";
            this.richTextBox_obs.Size = new System.Drawing.Size(626, 118);
            this.richTextBox_obs.TabIndex = 9;
            this.richTextBox_obs.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.combo_setor_maquina_op);
            this.groupBox1.Controls.Add(this.text_qtd_produzida_op);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.text_qtd_prevista_op);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dt_fim_op);
            this.groupBox1.Controls.Add(this.dt_inicio_op);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.combo_empresa);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.combo_status_ordem);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.combo_produto_op);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.text_num_ordem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(136, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 198);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "..";
            // 
            // combo_setor_maquina_op
            // 
            this.combo_setor_maquina_op.FormattingEnabled = true;
            this.combo_setor_maquina_op.Location = new System.Drawing.Point(117, 145);
            this.combo_setor_maquina_op.Name = "combo_setor_maquina_op";
            this.combo_setor_maquina_op.Size = new System.Drawing.Size(289, 21);
            this.combo_setor_maquina_op.TabIndex = 6;
            // 
            // text_qtd_produzida_op
            // 
            this.text_qtd_produzida_op.Enabled = false;
            this.text_qtd_produzida_op.Location = new System.Drawing.Point(296, 119);
            this.text_qtd_produzida_op.Name = "text_qtd_produzida_op";
            this.text_qtd_produzida_op.Size = new System.Drawing.Size(110, 20);
            this.text_qtd_produzida_op.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(76, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Setor:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(234, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Qtd prod:";
            // 
            // text_qtd_prevista_op
            // 
            this.text_qtd_prevista_op.Location = new System.Drawing.Point(117, 119);
            this.text_qtd_prevista_op.Name = "text_qtd_prevista_op";
            this.text_qtd_prevista_op.Size = new System.Drawing.Size(110, 20);
            this.text_qtd_prevista_op.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Qtd Prevista:";
            // 
            // dt_fim_op
            // 
            this.dt_fim_op.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fim_op.Location = new System.Drawing.Point(296, 93);
            this.dt_fim_op.Name = "dt_fim_op";
            this.dt_fim_op.Size = new System.Drawing.Size(110, 20);
            this.dt_fim_op.TabIndex = 13;
            // 
            // dt_inicio_op
            // 
            this.dt_inicio_op.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_inicio_op.Location = new System.Drawing.Point(117, 93);
            this.dt_inicio_op.Name = "dt_inicio_op";
            this.dt_inicio_op.Size = new System.Drawing.Size(110, 20);
            this.dt_inicio_op.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(239, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Dt Final:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Dt Inicial:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "......";
            // 
            // combo_empresa
            // 
            this.combo_empresa.FormattingEnabled = true;
            this.combo_empresa.Location = new System.Drawing.Point(117, 66);
            this.combo_empresa.Name = "combo_empresa";
            this.combo_empresa.Size = new System.Drawing.Size(159, 21);
            this.combo_empresa.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(477, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "......";
            // 
            // combo_status_ordem
            // 
            this.combo_status_ordem.FormattingEnabled = true;
            this.combo_status_ordem.Location = new System.Drawing.Point(339, 12);
            this.combo_status_ordem.Name = "combo_status_ordem";
            this.combo_status_ordem.Size = new System.Drawing.Size(132, 21);
            this.combo_status_ordem.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Empresa:";
            // 
            // combo_produto_op
            // 
            this.combo_produto_op.FormattingEnabled = true;
            this.combo_produto_op.Location = new System.Drawing.Point(117, 39);
            this.combo_produto_op.Name = "combo_produto_op";
            this.combo_produto_op.Size = new System.Drawing.Size(159, 21);
            this.combo_produto_op.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Status:";
            // 
            // text_num_ordem
            // 
            this.text_num_ordem.Location = new System.Drawing.Point(117, 13);
            this.text_num_ordem.Name = "text_num_ordem";
            this.text_num_ordem.Size = new System.Drawing.Size(110, 20);
            this.text_num_ordem.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "N° Op:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_imprmir_op);
            this.groupBox3.Controls.Add(this.button_deletar_op);
            this.groupBox3.Controls.Add(this.button_salvar_op);
            this.groupBox3.Controls.Add(this.button_abrir_ordem);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(124, 322);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opções";
            // 
            // button_imprmir_op
            // 
            this.button_imprmir_op.Location = new System.Drawing.Point(6, 106);
            this.button_imprmir_op.Name = "button_imprmir_op";
            this.button_imprmir_op.Size = new System.Drawing.Size(110, 23);
            this.button_imprmir_op.TabIndex = 4;
            this.button_imprmir_op.Text = "Imprimir";
            this.button_imprmir_op.UseVisualStyleBackColor = true;
            // 
            // button_deletar_op
            // 
            this.button_deletar_op.Location = new System.Drawing.Point(6, 77);
            this.button_deletar_op.Name = "button_deletar_op";
            this.button_deletar_op.Size = new System.Drawing.Size(110, 23);
            this.button_deletar_op.TabIndex = 3;
            this.button_deletar_op.Text = "Deletar";
            this.button_deletar_op.UseVisualStyleBackColor = true;
            // 
            // button_salvar_op
            // 
            this.button_salvar_op.Location = new System.Drawing.Point(6, 48);
            this.button_salvar_op.Name = "button_salvar_op";
            this.button_salvar_op.Size = new System.Drawing.Size(110, 23);
            this.button_salvar_op.TabIndex = 1;
            this.button_salvar_op.Text = "Salvar";
            this.button_salvar_op.UseVisualStyleBackColor = true;
            // 
            // button_abrir_ordem
            // 
            this.button_abrir_ordem.Location = new System.Drawing.Point(6, 19);
            this.button_abrir_ordem.Name = "button_abrir_ordem";
            this.button_abrir_ordem.Size = new System.Drawing.Size(110, 23);
            this.button_abrir_ordem.TabIndex = 0;
            this.button_abrir_ordem.Text = "Abrir Ordem";
            this.button_abrir_ordem.UseVisualStyleBackColor = true;
            // 
            // tab_impoartar_pg02
            // 
            this.tab_impoartar_pg02.Location = new System.Drawing.Point(4, 22);
            this.tab_impoartar_pg02.Name = "tab_impoartar_pg02";
            this.tab_impoartar_pg02.Padding = new System.Windows.Forms.Padding(3);
            this.tab_impoartar_pg02.Size = new System.Drawing.Size(1081, 460);
            this.tab_impoartar_pg02.TabIndex = 1;
            this.tab_impoartar_pg02.Text = "Importar OPs";
            this.tab_impoartar_pg02.UseVisualStyleBackColor = true;
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadEmpresaToolStripMenuItem,
            this.cadStatusToolStripMenuItem,
            this.cadMaterialToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // cadEmpresaToolStripMenuItem
            // 
            this.cadEmpresaToolStripMenuItem.Name = "cadEmpresaToolStripMenuItem";
            this.cadEmpresaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadEmpresaToolStripMenuItem.Text = "Cad. Empresa";
            // 
            // cadStatusToolStripMenuItem
            // 
            this.cadStatusToolStripMenuItem.Name = "cadStatusToolStripMenuItem";
            this.cadStatusToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadStatusToolStripMenuItem.Text = "Cad. Status";
            // 
            // cadMaterialToolStripMenuItem
            // 
            this.cadMaterialToolStripMenuItem.Name = "cadMaterialToolStripMenuItem";
            this.cadMaterialToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadMaterialToolStripMenuItem.Text = "Cad. Material";
            // 
            // OP001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 677);
            this.Controls.Add(this.tabControl_abrir_ordem);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OP001";
            this.Text = "Form_janela_abrir_op";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl_abrir_ordem.ResumeLayout(false);
            this.tab_abrir_ordem_pg01.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_ordem_prod)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem importarOrdensToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl_abrir_ordem;
        private System.Windows.Forms.TabPage tab_abrir_ordem_pg01;
        private System.Windows.Forms.TabPage tab_impoartar_pg02;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_localizar_op;
        private System.Windows.Forms.Button button_imprmir_op;
        private System.Windows.Forms.Button button_deletar_op;
        private System.Windows.Forms.Button button_salvar_op;
        private System.Windows.Forms.Button button_abrir_ordem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox text_num_ordem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_produto_op;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_empresa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combo_status_ordem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dt_fim_op;
        private System.Windows.Forms.DateTimePicker dt_inicio_op;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox text_qtd_prevista_op;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox text_qtd_produzida_op;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox richTextBox_obs;
        private System.Windows.Forms.ComboBox combo_setor_maquina_op;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView grid_ordem_prod;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadEmpresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadMaterialToolStripMenuItem;
    }
}