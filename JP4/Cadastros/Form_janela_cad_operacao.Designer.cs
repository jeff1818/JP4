
namespace JP4
{
    partial class Form_janela_cad_operacao
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_sair = new System.Windows.Forms.Button();
            this.button_limpar_controles = new System.Windows.Forms.Button();
            this.button_atualizar = new System.Windows.Forms.Button();
            this.button_filtrar = new System.Windows.Forms.Button();
            this.button_salvar = new System.Windows.Forms.Button();
            this.button_deletar = new System.Windows.Forms.Button();
            this.grid_cad_operacao = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combo_programa_destino = new System.Windows.Forms.ComboBox();
            this.combo_tipo_operacao = new System.Windows.Forms.ComboBox();
            this.text_descri_operacao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_id_cad_operacao = new System.Windows.Forms.Label();
            this.text_cod_operacao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_cad_operacao)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_sair);
            this.groupBox2.Controls.Add(this.button_limpar_controles);
            this.groupBox2.Controls.Add(this.button_atualizar);
            this.groupBox2.Controls.Add(this.button_filtrar);
            this.groupBox2.Controls.Add(this.button_salvar);
            this.groupBox2.Controls.Add(this.button_deletar);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(142, 612);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu";
            // 
            // button_sair
            // 
            this.button_sair.Location = new System.Drawing.Point(12, 178);
            this.button_sair.Name = "button_sair";
            this.button_sair.Size = new System.Drawing.Size(114, 23);
            this.button_sair.TabIndex = 14;
            this.button_sair.Text = "Sair";
            this.button_sair.UseVisualStyleBackColor = true;
            this.button_sair.Click += new System.EventHandler(this.button_sair_Click);
            // 
            // button_limpar_controles
            // 
            this.button_limpar_controles.Location = new System.Drawing.Point(12, 120);
            this.button_limpar_controles.Name = "button_limpar_controles";
            this.button_limpar_controles.Size = new System.Drawing.Size(114, 23);
            this.button_limpar_controles.TabIndex = 11;
            this.button_limpar_controles.Text = "Limpar Controles";
            this.button_limpar_controles.UseVisualStyleBackColor = true;
            this.button_limpar_controles.Click += new System.EventHandler(this.button_limpar_controles_Click);
            // 
            // button_atualizar
            // 
            this.button_atualizar.Location = new System.Drawing.Point(12, 62);
            this.button_atualizar.Name = "button_atualizar";
            this.button_atualizar.Size = new System.Drawing.Size(114, 23);
            this.button_atualizar.TabIndex = 10;
            this.button_atualizar.Text = "Atualizar";
            this.button_atualizar.UseVisualStyleBackColor = true;
            this.button_atualizar.Click += new System.EventHandler(this.button_atualizar_Click);
            // 
            // button_filtrar
            // 
            this.button_filtrar.Location = new System.Drawing.Point(12, 149);
            this.button_filtrar.Name = "button_filtrar";
            this.button_filtrar.Size = new System.Drawing.Size(114, 23);
            this.button_filtrar.TabIndex = 9;
            this.button_filtrar.Text = "Filtrar";
            this.button_filtrar.UseVisualStyleBackColor = true;
            // 
            // button_salvar
            // 
            this.button_salvar.Location = new System.Drawing.Point(12, 33);
            this.button_salvar.Name = "button_salvar";
            this.button_salvar.Size = new System.Drawing.Size(114, 23);
            this.button_salvar.TabIndex = 7;
            this.button_salvar.Text = "Salvar";
            this.button_salvar.UseVisualStyleBackColor = true;
            this.button_salvar.Click += new System.EventHandler(this.button_salvar_Click);
            // 
            // button_deletar
            // 
            this.button_deletar.Location = new System.Drawing.Point(12, 91);
            this.button_deletar.Name = "button_deletar";
            this.button_deletar.Size = new System.Drawing.Size(114, 23);
            this.button_deletar.TabIndex = 8;
            this.button_deletar.Text = "Excluir";
            this.button_deletar.UseVisualStyleBackColor = true;
            this.button_deletar.Click += new System.EventHandler(this.button_deletar_Click);
            // 
            // grid_cad_operacao
            // 
            this.grid_cad_operacao.AllowUserToAddRows = false;
            this.grid_cad_operacao.AllowUserToDeleteRows = false;
            this.grid_cad_operacao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_cad_operacao.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grid_cad_operacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_cad_operacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_cad_operacao.Location = new System.Drawing.Point(142, 106);
            this.grid_cad_operacao.Name = "grid_cad_operacao";
            this.grid_cad_operacao.ReadOnly = true;
            this.grid_cad_operacao.Size = new System.Drawing.Size(910, 506);
            this.grid_cad_operacao.TabIndex = 18;
            this.grid_cad_operacao.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_cad_operacao_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.combo_programa_destino);
            this.groupBox1.Controls.Add(this.combo_tipo_operacao);
            this.groupBox1.Controls.Add(this.text_descri_operacao);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label_id_cad_operacao);
            this.groupBox1.Controls.Add(this.text_cod_operacao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(142, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(910, 106);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informação basica";
            // 
            // combo_programa_destino
            // 
            this.combo_programa_destino.FormattingEnabled = true;
            this.combo_programa_destino.Items.AddRange(new object[] {
            "AP01",
            "STOQ01"});
            this.combo_programa_destino.Location = new System.Drawing.Point(340, 44);
            this.combo_programa_destino.Name = "combo_programa_destino";
            this.combo_programa_destino.Size = new System.Drawing.Size(121, 21);
            this.combo_programa_destino.TabIndex = 13;
            // 
            // combo_tipo_operacao
            // 
            this.combo_tipo_operacao.FormattingEnabled = true;
            this.combo_tipo_operacao.Items.AddRange(new object[] {
            "Entrada",
            "Saida"});
            this.combo_tipo_operacao.Location = new System.Drawing.Point(97, 44);
            this.combo_tipo_operacao.Name = "combo_tipo_operacao";
            this.combo_tipo_operacao.Size = new System.Drawing.Size(121, 21);
            this.combo_tipo_operacao.TabIndex = 12;
            // 
            // text_descri_operacao
            // 
            this.text_descri_operacao.Location = new System.Drawing.Point(340, 19);
            this.text_descri_operacao.Name = "text_descri_operacao";
            this.text_descri_operacao.Size = new System.Drawing.Size(352, 20);
            this.text_descri_operacao.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Programa Destino";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tipo Operação";
            // 
            // label_id_cad_operacao
            // 
            this.label_id_cad_operacao.AutoSize = true;
            this.label_id_cad_operacao.Location = new System.Drawing.Point(856, 16);
            this.label_id_cad_operacao.Name = "label_id_cad_operacao";
            this.label_id_cad_operacao.Size = new System.Drawing.Size(15, 13);
            this.label_id_cad_operacao.TabIndex = 8;
            this.label_id_cad_operacao.Text = "id";
            // 
            // text_cod_operacao
            // 
            this.text_cod_operacao.Location = new System.Drawing.Point(97, 19);
            this.text_cod_operacao.Name = "text_cod_operacao";
            this.text_cod_operacao.Size = new System.Drawing.Size(121, 20);
            this.text_cod_operacao.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // Form_janela_cad_operacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 612);
            this.Controls.Add(this.grid_cad_operacao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_janela_cad_operacao";
            this.Text = "Cadastro Operação";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_cad_operacao)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_limpar_controles;
        private System.Windows.Forms.Button button_atualizar;
        private System.Windows.Forms.Button button_filtrar;
        private System.Windows.Forms.Button button_salvar;
        private System.Windows.Forms.Button button_deletar;
        private System.Windows.Forms.DataGridView grid_cad_operacao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_id_cad_operacao;
        private System.Windows.Forms.TextBox text_cod_operacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combo_programa_destino;
        private System.Windows.Forms.ComboBox combo_tipo_operacao;
        private System.Windows.Forms.TextBox text_descri_operacao;
        private System.Windows.Forms.Button button_sair;
    }
}