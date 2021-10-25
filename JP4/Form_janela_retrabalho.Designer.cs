
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.destino_text_qtd_fd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.destino_combo_operador = new System.Windows.Forms.ComboBox();
            this.destino_combo_maquina = new System.Windows.Forms.ComboBox();
            this.destino_dt_apontameno = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.destino_combo_local_destino = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.destino_text_descri_material = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.destino_combo_ordem_prod = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_apontamento
            // 
            this.button_apontamento.Location = new System.Drawing.Point(12, 342);
            this.button_apontamento.Name = "button_apontamento";
            this.button_apontamento.Size = new System.Drawing.Size(158, 23);
            this.button_apontamento.TabIndex = 0;
            this.button_apontamento.Text = "Efetivar";
            this.button_apontamento.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(890, 156);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.destino_text_qtd_fd);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.destino_combo_operador);
            this.groupBox2.Controls.Add(this.destino_combo_maquina);
            this.groupBox2.Controls.Add(this.destino_dt_apontameno);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.destino_combo_local_destino);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.destino_text_descri_material);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.destino_combo_ordem_prod);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(12, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(890, 156);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Destino";
            // 
            // destino_text_qtd_fd
            // 
            this.destino_text_qtd_fd.Location = new System.Drawing.Point(101, 99);
            this.destino_text_qtd_fd.Name = "destino_text_qtd_fd";
            this.destino_text_qtd_fd.Size = new System.Drawing.Size(113, 20);
            this.destino_text_qtd_fd.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Qtd. Fardo";
            // 
            // destino_combo_operador
            // 
            this.destino_combo_operador.FormattingEnabled = true;
            this.destino_combo_operador.Location = new System.Drawing.Point(277, 72);
            this.destino_combo_operador.Name = "destino_combo_operador";
            this.destino_combo_operador.Size = new System.Drawing.Size(113, 21);
            this.destino_combo_operador.TabIndex = 14;
            // 
            // destino_combo_maquina
            // 
            this.destino_combo_maquina.FormattingEnabled = true;
            this.destino_combo_maquina.Location = new System.Drawing.Point(101, 72);
            this.destino_combo_maquina.Name = "destino_combo_maquina";
            this.destino_combo_maquina.Size = new System.Drawing.Size(113, 21);
            this.destino_combo_maquina.TabIndex = 13;
            // 
            // destino_dt_apontameno
            // 
            this.destino_dt_apontameno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.destino_dt_apontameno.Location = new System.Drawing.Point(101, 19);
            this.destino_dt_apontameno.Name = "destino_dt_apontameno";
            this.destino_dt_apontameno.Size = new System.Drawing.Size(113, 20);
            this.destino_dt_apontameno.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Dt Apontamento.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(220, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Operador";
            // 
            // destino_combo_local_destino
            // 
            this.destino_combo_local_destino.FormattingEnabled = true;
            this.destino_combo_local_destino.Location = new System.Drawing.Point(474, 72);
            this.destino_combo_local_destino.Name = "destino_combo_local_destino";
            this.destino_combo_local_destino.Size = new System.Drawing.Size(149, 21);
            this.destino_combo_local_destino.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(396, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Local Destino";
            // 
            // destino_text_descri_material
            // 
            this.destino_text_descri_material.Location = new System.Drawing.Point(220, 46);
            this.destino_text_descri_material.Name = "destino_text_descri_material";
            this.destino_text_descri_material.Size = new System.Drawing.Size(463, 20);
            this.destino_text_descri_material.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Maquina";
            // 
            // destino_combo_ordem_prod
            // 
            this.destino_combo_ordem_prod.FormattingEnabled = true;
            this.destino_combo_ordem_prod.Location = new System.Drawing.Point(101, 45);
            this.destino_combo_ordem_prod.Name = "destino_combo_ordem_prod";
            this.destino_combo_ordem_prod.Size = new System.Drawing.Size(113, 21);
            this.destino_combo_ordem_prod.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Ordem Prod.";
            // 
            // Form_janela_retrabalho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 388);
            this.Controls.Add(this.button_apontamento);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_janela_retrabalho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_janela_retrabalho";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox destino_text_qtd_fd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox destino_combo_operador;
        private System.Windows.Forms.ComboBox destino_combo_maquina;
        private System.Windows.Forms.DateTimePicker destino_dt_apontameno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox destino_combo_local_destino;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox destino_text_descri_material;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox destino_combo_ordem_prod;
        private System.Windows.Forms.Label label12;
    }
}