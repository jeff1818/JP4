
namespace JP4
{
    partial class Form_janela_retrabalho
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
            this.button_apontamento = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.origem_text_qtd_fardo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.origem_combo_operador = new System.Windows.Forms.ComboBox();
            this.origem_combo_maquina = new System.Windows.Forms.ComboBox();
            this.origem_dt_apontameno = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.origem_combo_local_destino = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.origem_text_descri_item = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.origem_combo_ordem_prod = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grid_retrabalho = new System.Windows.Forms.DataGridView();
            this.origem_combo_mes = new System.Windows.Forms.ComboBox();
            this.combo_ano = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_retrabalho)).BeginInit();
            this.SuspendLayout();
            // 
            // button_apontamento
            // 
            this.button_apontamento.Location = new System.Drawing.Point(746, 127);
            this.button_apontamento.Name = "button_apontamento";
            this.button_apontamento.Size = new System.Drawing.Size(158, 23);
            this.button_apontamento.TabIndex = 0;
            this.button_apontamento.Text = "Efetivar";
            this.button_apontamento.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.combo_ano);
            this.groupBox1.Controls.Add(this.origem_combo_mes);
            this.groupBox1.Controls.Add(this.button_apontamento);
            this.groupBox1.Controls.Add(this.origem_text_qtd_fardo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.origem_combo_operador);
            this.groupBox1.Controls.Add(this.origem_combo_maquina);
            this.groupBox1.Controls.Add(this.origem_dt_apontameno);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.origem_combo_local_destino);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.origem_text_descri_item);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.origem_combo_ordem_prod);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(916, 156);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Origem";
            // 
            // origem_text_qtd_fardo
            // 
            this.origem_text_qtd_fardo.Location = new System.Drawing.Point(101, 99);
            this.origem_text_qtd_fardo.Name = "origem_text_qtd_fardo";
            this.origem_text_qtd_fardo.Size = new System.Drawing.Size(113, 20);
            this.origem_text_qtd_fardo.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Qtd. Fardo";
            // 
            // origem_combo_operador
            // 
            this.origem_combo_operador.FormattingEnabled = true;
            this.origem_combo_operador.Location = new System.Drawing.Point(277, 72);
            this.origem_combo_operador.Name = "origem_combo_operador";
            this.origem_combo_operador.Size = new System.Drawing.Size(113, 21);
            this.origem_combo_operador.TabIndex = 14;
            // 
            // origem_combo_maquina
            // 
            this.origem_combo_maquina.FormattingEnabled = true;
            this.origem_combo_maquina.Location = new System.Drawing.Point(101, 72);
            this.origem_combo_maquina.Name = "origem_combo_maquina";
            this.origem_combo_maquina.Size = new System.Drawing.Size(113, 21);
            this.origem_combo_maquina.TabIndex = 13;
            this.origem_combo_maquina.SelectedIndexChanged += new System.EventHandler(this.origem_combo_maquina_SelectedIndexChanged);
            // 
            // origem_dt_apontameno
            // 
            this.origem_dt_apontameno.CustomFormat = "dd/MM/yyyy";
            this.origem_dt_apontameno.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.origem_dt_apontameno.Location = new System.Drawing.Point(101, 19);
            this.origem_dt_apontameno.Name = "origem_dt_apontameno";
            this.origem_dt_apontameno.Size = new System.Drawing.Size(113, 20);
            this.origem_dt_apontameno.TabIndex = 12;
            this.origem_dt_apontameno.ValueChanged += new System.EventHandler(this.origem_dt_apontameno_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Dt Apontamento.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(220, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Operador";
            // 
            // origem_combo_local_destino
            // 
            this.origem_combo_local_destino.FormattingEnabled = true;
            this.origem_combo_local_destino.Location = new System.Drawing.Point(474, 72);
            this.origem_combo_local_destino.Name = "origem_combo_local_destino";
            this.origem_combo_local_destino.Size = new System.Drawing.Size(149, 21);
            this.origem_combo_local_destino.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Local Destino";
            // 
            // origem_text_descri_item
            // 
            this.origem_text_descri_item.Location = new System.Drawing.Point(220, 46);
            this.origem_text_descri_item.Name = "origem_text_descri_item";
            this.origem_text_descri_item.Size = new System.Drawing.Size(463, 20);
            this.origem_text_descri_item.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Maquina";
            // 
            // origem_combo_ordem_prod
            // 
            this.origem_combo_ordem_prod.FormattingEnabled = true;
            this.origem_combo_ordem_prod.Location = new System.Drawing.Point(101, 45);
            this.origem_combo_ordem_prod.Name = "origem_combo_ordem_prod";
            this.origem_combo_ordem_prod.Size = new System.Drawing.Size(113, 21);
            this.origem_combo_ordem_prod.TabIndex = 2;
            this.origem_combo_ordem_prod.SelectedIndexChanged += new System.EventHandler(this.origem_combo_ordem_prod_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ordem Prod.";
            // 
            // grid_retrabalho
            // 
            this.grid_retrabalho.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grid_retrabalho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_retrabalho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_retrabalho.Location = new System.Drawing.Point(0, 156);
            this.grid_retrabalho.Name = "grid_retrabalho";
            this.grid_retrabalho.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.grid_retrabalho.Size = new System.Drawing.Size(916, 413);
            this.grid_retrabalho.TabIndex = 9;
            // 
            // origem_combo_mes
            // 
            this.origem_combo_mes.FormattingEnabled = true;
            this.origem_combo_mes.Items.AddRange(new object[] {
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
            this.origem_combo_mes.Location = new System.Drawing.Point(821, 40);
            this.origem_combo_mes.Name = "origem_combo_mes";
            this.origem_combo_mes.Size = new System.Drawing.Size(74, 21);
            this.origem_combo_mes.TabIndex = 17;
            this.origem_combo_mes.SelectedIndexChanged += new System.EventHandler(this.origem_combo_mes_SelectedIndexChanged);
            // 
            // combo_ano
            // 
            this.combo_ano.FormattingEnabled = true;
            this.combo_ano.Items.AddRange(new object[] {
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
            this.combo_ano.Location = new System.Drawing.Point(821, 72);
            this.combo_ano.Name = "combo_ano";
            this.combo_ano.Size = new System.Drawing.Size(74, 21);
            this.combo_ano.TabIndex = 18;
            this.combo_ano.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(785, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Mês:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(786, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Ano:";
            // 
            // Form_janela_retrabalho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 569);
            this.Controls.Add(this.grid_retrabalho);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_janela_retrabalho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Aplicativo de retrabalho";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_retrabalho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_apontamento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox origem_combo_ordem_prod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox origem_text_descri_item;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox origem_combo_local_destino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker origem_dt_apontameno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox origem_combo_maquina;
        private System.Windows.Forms.ComboBox origem_combo_operador;
        private System.Windows.Forms.TextBox origem_text_qtd_fardo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView grid_retrabalho;
        private System.Windows.Forms.ComboBox combo_ano;
        private System.Windows.Forms.ComboBox origem_combo_mes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}