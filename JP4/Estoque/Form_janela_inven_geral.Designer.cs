
namespace JP4
{
    partial class Form_janela_inven_geral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_janela_inven_geral));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel_fechamento_mes = new System.Windows.Forms.Panel();
            this.button_fechar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_ano_referencia = new System.Windows.Forms.ComboBox();
            this.combo_mes_referencia = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_fechar_mes_op = new System.Windows.Forms.Button();
            this.button_sair = new System.Windows.Forms.Button();
            this.button_deletar = new System.Windows.Forms.Button();
            this.button_atualizar = new System.Windows.Forms.Button();
            this.button_salvar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label_id_inventario = new System.Windows.Forms.Label();
            this.checkBox_mes_fechado = new System.Windows.Forms.CheckBox();
            this.rich_observacao = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.text_qtd_fardos = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.text_qtd_kg = new System.Windows.Forms.TextBox();
            this.label_fator_padrao = new System.Windows.Forms.Label();
            this.combo_unidade_medida = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.date_referencia_mes_contagem = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.date_contagem = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox_mes_aberto = new System.Windows.Forms.CheckBox();
            this.combo_local_destino = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_categoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_descricao_item = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grid_movi_estoque = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.panel_fechamento_mes.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_movi_estoque)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel_fechamento_mes);
            this.groupBox1.Controls.Add(this.button_fechar_mes_op);
            this.groupBox1.Controls.Add(this.button_sair);
            this.groupBox1.Controls.Add(this.button_deletar);
            this.groupBox1.Controls.Add(this.button_atualizar);
            this.groupBox1.Controls.Add(this.button_salvar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 595);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // panel_fechamento_mes
            // 
            this.panel_fechamento_mes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_fechamento_mes.Controls.Add(this.button_fechar);
            this.panel_fechamento_mes.Controls.Add(this.label11);
            this.panel_fechamento_mes.Controls.Add(this.label10);
            this.panel_fechamento_mes.Controls.Add(this.comboBox_ano_referencia);
            this.panel_fechamento_mes.Controls.Add(this.combo_mes_referencia);
            this.panel_fechamento_mes.Controls.Add(this.label7);
            this.panel_fechamento_mes.Location = new System.Drawing.Point(12, 181);
            this.panel_fechamento_mes.Name = "panel_fechamento_mes";
            this.panel_fechamento_mes.Size = new System.Drawing.Size(142, 153);
            this.panel_fechamento_mes.TabIndex = 19;
            this.panel_fechamento_mes.Visible = false;
            // 
            // button_fechar
            // 
            this.button_fechar.Location = new System.Drawing.Point(3, 111);
            this.button_fechar.Name = "button_fechar";
            this.button_fechar.Size = new System.Drawing.Size(127, 23);
            this.button_fechar.TabIndex = 23;
            this.button_fechar.Text = "Fechar";
            this.button_fechar.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Mês";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Ano";
            // 
            // comboBox_ano_referencia
            // 
            this.comboBox_ano_referencia.FormattingEnabled = true;
            this.comboBox_ano_referencia.Location = new System.Drawing.Point(42, 32);
            this.comboBox_ano_referencia.Name = "comboBox_ano_referencia";
            this.comboBox_ano_referencia.Size = new System.Drawing.Size(74, 21);
            this.comboBox_ano_referencia.TabIndex = 20;
            // 
            // combo_mes_referencia
            // 
            this.combo_mes_referencia.FormattingEnabled = true;
            this.combo_mes_referencia.Location = new System.Drawing.Point(42, 76);
            this.combo_mes_referencia.Name = "combo_mes_referencia";
            this.combo_mes_referencia.Size = new System.Drawing.Size(74, 21);
            this.combo_mes_referencia.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Mês que será finalizado.";
            // 
            // button_fechar_mes_op
            // 
            this.button_fechar_mes_op.Location = new System.Drawing.Point(12, 116);
            this.button_fechar_mes_op.Name = "button_fechar_mes_op";
            this.button_fechar_mes_op.Size = new System.Drawing.Size(142, 23);
            this.button_fechar_mes_op.TabIndex = 4;
            this.button_fechar_mes_op.Text = "Fechar o Mês";
            this.button_fechar_mes_op.UseVisualStyleBackColor = true;
            this.button_fechar_mes_op.Click += new System.EventHandler(this.button_fechar_mes_Click);
            // 
            // button_sair
            // 
            this.button_sair.Location = new System.Drawing.Point(12, 145);
            this.button_sair.Name = "button_sair";
            this.button_sair.Size = new System.Drawing.Size(142, 23);
            this.button_sair.TabIndex = 3;
            this.button_sair.Text = "SAIR";
            this.button_sair.UseVisualStyleBackColor = true;
            this.button_sair.Click += new System.EventHandler(this.button_sair_Click);
            // 
            // button_deletar
            // 
            this.button_deletar.Location = new System.Drawing.Point(12, 87);
            this.button_deletar.Name = "button_deletar";
            this.button_deletar.Size = new System.Drawing.Size(142, 23);
            this.button_deletar.TabIndex = 2;
            this.button_deletar.Text = "Deletar";
            this.button_deletar.UseVisualStyleBackColor = true;
            this.button_deletar.Click += new System.EventHandler(this.button_deletar_Click);
            // 
            // button_atualizar
            // 
            this.button_atualizar.Location = new System.Drawing.Point(12, 58);
            this.button_atualizar.Name = "button_atualizar";
            this.button_atualizar.Size = new System.Drawing.Size(142, 23);
            this.button_atualizar.TabIndex = 1;
            this.button_atualizar.Text = "Atualizar";
            this.button_atualizar.UseVisualStyleBackColor = true;
            this.button_atualizar.Click += new System.EventHandler(this.button_atualizar_Click);
            // 
            // button_salvar
            // 
            this.button_salvar.Location = new System.Drawing.Point(12, 29);
            this.button_salvar.Name = "button_salvar";
            this.button_salvar.Size = new System.Drawing.Size(142, 23);
            this.button_salvar.TabIndex = 0;
            this.button_salvar.Text = "Salvar";
            this.button_salvar.UseVisualStyleBackColor = true;
            this.button_salvar.Click += new System.EventHandler(this.button_salvar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label_id_inventario);
            this.groupBox2.Controls.Add(this.checkBox_mes_fechado);
            this.groupBox2.Controls.Add(this.rich_observacao);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.text_qtd_fardos);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.text_qtd_kg);
            this.groupBox2.Controls.Add(this.label_fator_padrao);
            this.groupBox2.Controls.Add(this.combo_unidade_medida);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.date_referencia_mes_contagem);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.date_contagem);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.checkBox_mes_aberto);
            this.groupBox2.Controls.Add(this.combo_local_destino);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.combo_categoria);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.combo_descricao_item);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(160, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(770, 287);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações basicas";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(459, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Observação";
            // 
            // label_id_inventario
            // 
            this.label_id_inventario.AutoSize = true;
            this.label_id_inventario.Location = new System.Drawing.Point(647, 257);
            this.label_id_inventario.Name = "label_id_inventario";
            this.label_id_inventario.Size = new System.Drawing.Size(13, 13);
            this.label_id_inventario.TabIndex = 18;
            this.label_id_inventario.Text = "0";
            // 
            // checkBox_mes_fechado
            // 
            this.checkBox_mes_fechado.AutoSize = true;
            this.checkBox_mes_fechado.Location = new System.Drawing.Point(80, 253);
            this.checkBox_mes_fechado.Name = "checkBox_mes_fechado";
            this.checkBox_mes_fechado.Size = new System.Drawing.Size(68, 17);
            this.checkBox_mes_fechado.TabIndex = 11;
            this.checkBox_mes_fechado.Text = "Fechado";
            this.checkBox_mes_fechado.UseVisualStyleBackColor = true;
            this.checkBox_mes_fechado.CheckedChanged += new System.EventHandler(this.checkBox_mes_fechado_CheckedChanged);
            // 
            // rich_observacao
            // 
            this.rich_observacao.Location = new System.Drawing.Point(330, 126);
            this.rich_observacao.Name = "rich_observacao";
            this.rich_observacao.Size = new System.Drawing.Size(311, 102);
            this.rich_observacao.TabIndex = 9;
            this.rich_observacao.Text = "...";
            this.rich_observacao.Click += new System.EventHandler(this.rich_observacao_Click);
            this.rich_observacao.Leave += new System.EventHandler(this.rich_observacao_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Quantidade Und/ FD:";
            // 
            // text_qtd_fardos
            // 
            this.text_qtd_fardos.Location = new System.Drawing.Point(139, 209);
            this.text_qtd_fardos.Name = "text_qtd_fardos";
            this.text_qtd_fardos.Size = new System.Drawing.Size(112, 20);
            this.text_qtd_fardos.TabIndex = 8;
            this.text_qtd_fardos.Text = "0";
            this.text_qtd_fardos.TextChanged += new System.EventHandler(this.text_qtd_fardos_TextChanged);
            this.text_qtd_fardos.Leave += new System.EventHandler(this.text_qtd_fardos_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Quantidade KG:";
            // 
            // text_qtd_kg
            // 
            this.text_qtd_kg.Location = new System.Drawing.Point(139, 184);
            this.text_qtd_kg.Name = "text_qtd_kg";
            this.text_qtd_kg.Size = new System.Drawing.Size(112, 20);
            this.text_qtd_kg.TabIndex = 7;
            this.text_qtd_kg.Text = "0";
            // 
            // label_fator_padrao
            // 
            this.label_fator_padrao.AutoSize = true;
            this.label_fator_padrao.Location = new System.Drawing.Point(647, 79);
            this.label_fator_padrao.Name = "label_fator_padrao";
            this.label_fator_padrao.Size = new System.Drawing.Size(67, 13);
            this.label_fator_padrao.TabIndex = 13;
            this.label_fator_padrao.Text = "Fator padrão";
            // 
            // combo_unidade_medida
            // 
            this.combo_unidade_medida.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_unidade_medida.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_unidade_medida.FormattingEnabled = true;
            this.combo_unidade_medida.Location = new System.Drawing.Point(139, 130);
            this.combo_unidade_medida.Name = "combo_unidade_medida";
            this.combo_unidade_medida.Size = new System.Drawing.Size(112, 21);
            this.combo_unidade_medida.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Unidade Medida:";
            // 
            // date_referencia_mes_contagem
            // 
            this.date_referencia_mes_contagem.CustomFormat = "MM/yyyy";
            this.date_referencia_mes_contagem.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_referencia_mes_contagem.Location = new System.Drawing.Point(139, 52);
            this.date_referencia_mes_contagem.Name = "date_referencia_mes_contagem";
            this.date_referencia_mes_contagem.Size = new System.Drawing.Size(112, 20);
            this.date_referencia_mes_contagem.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Referencia da contagem:";
            // 
            // date_contagem
            // 
            this.date_contagem.CustomFormat = "MM/yyyy";
            this.date_contagem.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_contagem.Location = new System.Drawing.Point(139, 24);
            this.date_contagem.Name = "date_contagem";
            this.date_contagem.Size = new System.Drawing.Size(112, 20);
            this.date_contagem.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data da contagem:";
            // 
            // checkBox_mes_aberto
            // 
            this.checkBox_mes_aberto.AutoSize = true;
            this.checkBox_mes_aberto.Location = new System.Drawing.Point(6, 253);
            this.checkBox_mes_aberto.Name = "checkBox_mes_aberto";
            this.checkBox_mes_aberto.Size = new System.Drawing.Size(57, 17);
            this.checkBox_mes_aberto.TabIndex = 10;
            this.checkBox_mes_aberto.Text = "Aberto";
            this.checkBox_mes_aberto.UseVisualStyleBackColor = true;
            this.checkBox_mes_aberto.CheckedChanged += new System.EventHandler(this.checkBox_mes_aberto_CheckedChanged);
            // 
            // combo_local_destino
            // 
            this.combo_local_destino.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_local_destino.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_local_destino.FormattingEnabled = true;
            this.combo_local_destino.Location = new System.Drawing.Point(139, 157);
            this.combo_local_destino.Name = "combo_local_destino";
            this.combo_local_destino.Size = new System.Drawing.Size(185, 21);
            this.combo_local_destino.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Local Destino:";
            // 
            // combo_categoria
            // 
            this.combo_categoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_categoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_categoria.FormattingEnabled = true;
            this.combo_categoria.Location = new System.Drawing.Point(139, 103);
            this.combo_categoria.Name = "combo_categoria";
            this.combo_categoria.Size = new System.Drawing.Size(181, 21);
            this.combo_categoria.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Categoria:";
            // 
            // combo_descricao_item
            // 
            this.combo_descricao_item.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_descricao_item.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_descricao_item.FormattingEnabled = true;
            this.combo_descricao_item.Location = new System.Drawing.Point(139, 76);
            this.combo_descricao_item.Name = "combo_descricao_item";
            this.combo_descricao_item.Size = new System.Drawing.Size(502, 21);
            this.combo_descricao_item.TabIndex = 3;
            this.combo_descricao_item.SelectedIndexChanged += new System.EventHandler(this.combo_descricao_item_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item / Descrição:";
            // 
            // grid_movi_estoque
            // 
            this.grid_movi_estoque.AllowUserToAddRows = false;
            this.grid_movi_estoque.AllowUserToDeleteRows = false;
            this.grid_movi_estoque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_movi_estoque.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grid_movi_estoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_movi_estoque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_movi_estoque.Location = new System.Drawing.Point(160, 287);
            this.grid_movi_estoque.Name = "grid_movi_estoque";
            this.grid_movi_estoque.ReadOnly = true;
            this.grid_movi_estoque.Size = new System.Drawing.Size(770, 308);
            this.grid_movi_estoque.TabIndex = 8;
            this.grid_movi_estoque.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_movi_estoque_CellDoubleClick);
            // 
            // Form_janela_inven_geral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 595);
            this.Controls.Add(this.grid_movi_estoque);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_janela_inven_geral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inventário Geral";
            this.groupBox1.ResumeLayout(false);
            this.panel_fechamento_mes.ResumeLayout(false);
            this.panel_fechamento_mes.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_movi_estoque)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grid_movi_estoque;
        private System.Windows.Forms.Button button_deletar;
        private System.Windows.Forms.Button button_atualizar;
        private System.Windows.Forms.Button button_salvar;
        private System.Windows.Forms.Button button_sair;
        private System.Windows.Forms.ComboBox combo_descricao_item;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_local_destino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_categoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date_contagem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox_mes_aberto;
        private System.Windows.Forms.DateTimePicker date_referencia_mes_contagem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_fechar_mes_op;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox text_qtd_fardos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox text_qtd_kg;
        private System.Windows.Forms.Label label_fator_padrao;
        private System.Windows.Forms.ComboBox combo_unidade_medida;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rich_observacao;
        private System.Windows.Forms.CheckBox checkBox_mes_fechado;
        private System.Windows.Forms.Label label_id_inventario;
        private System.Windows.Forms.Panel panel_fechamento_mes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_ano_referencia;
        private System.Windows.Forms.ComboBox combo_mes_referencia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_fechar;
        private System.Windows.Forms.Label label12;
    }
}