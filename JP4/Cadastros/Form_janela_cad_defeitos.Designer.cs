
namespace JP4
{
    partial class Form_janela_cad_defeitos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_id_defeitos = new System.Windows.Forms.Label();
            this.label_desc_origem_apara = new System.Windows.Forms.Label();
            this.text_observacao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_origem_apara = new System.Windows.Forms.ComboBox();
            this.text_descri_apara = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_cod_defeito = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grid_cad_defeitos = new System.Windows.Forms.DataGridView();
            this.button_salvar = new System.Windows.Forms.Button();
            this.button_deletar = new System.Windows.Forms.Button();
            this.button_filtrar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_limpar_controles = new System.Windows.Forms.Button();
            this.button_atualizar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_cad_defeitos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_id_defeitos);
            this.groupBox1.Controls.Add(this.label_desc_origem_apara);
            this.groupBox1.Controls.Add(this.text_observacao);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.combo_origem_apara);
            this.groupBox1.Controls.Add(this.text_descri_apara);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.text_cod_defeito);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(142, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(910, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informação basica";
            // 
            // label_id_defeitos
            // 
            this.label_id_defeitos.AutoSize = true;
            this.label_id_defeitos.Location = new System.Drawing.Point(6, 84);
            this.label_id_defeitos.Name = "label_id_defeitos";
            this.label_id_defeitos.Size = new System.Drawing.Size(15, 13);
            this.label_id_defeitos.TabIndex = 8;
            this.label_id_defeitos.Text = "id";
            // 
            // label_desc_origem_apara
            // 
            this.label_desc_origem_apara.AutoSize = true;
            this.label_desc_origem_apara.Location = new System.Drawing.Point(598, 31);
            this.label_desc_origem_apara.Name = "label_desc_origem_apara";
            this.label_desc_origem_apara.Size = new System.Drawing.Size(129, 13);
            this.label_desc_origem_apara.TabIndex = 7;
            this.label_desc_origem_apara.Text = "Descrição local de origem";
            // 
            // text_observacao
            // 
            this.text_observacao.Location = new System.Drawing.Point(427, 54);
            this.text_observacao.Name = "text_observacao";
            this.text_observacao.Size = new System.Drawing.Size(306, 20);
            this.text_observacao.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Observação";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Origem Apara";
            // 
            // combo_origem_apara
            // 
            this.combo_origem_apara.FormattingEnabled = true;
            this.combo_origem_apara.Location = new System.Drawing.Point(427, 27);
            this.combo_origem_apara.Name = "combo_origem_apara";
            this.combo_origem_apara.Size = new System.Drawing.Size(165, 21);
            this.combo_origem_apara.TabIndex = 2;
            this.combo_origem_apara.SelectedIndexChanged += new System.EventHandler(this.combo_origem_apara_SelectedIndexChanged);
            // 
            // text_descri_apara
            // 
            this.text_descri_apara.Location = new System.Drawing.Point(103, 50);
            this.text_descri_apara.Name = "text_descri_apara";
            this.text_descri_apara.Size = new System.Drawing.Size(231, 20);
            this.text_descri_apara.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição Apara";
            // 
            // text_cod_defeito
            // 
            this.text_cod_defeito.Location = new System.Drawing.Point(103, 24);
            this.text_cod_defeito.Name = "text_cod_defeito";
            this.text_cod_defeito.Size = new System.Drawing.Size(128, 20);
            this.text_cod_defeito.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // grid_cad_defeitos
            // 
            this.grid_cad_defeitos.AllowUserToAddRows = false;
            this.grid_cad_defeitos.AllowUserToDeleteRows = false;
            this.grid_cad_defeitos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_cad_defeitos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grid_cad_defeitos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_cad_defeitos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_cad_defeitos.Location = new System.Drawing.Point(142, 106);
            this.grid_cad_defeitos.Name = "grid_cad_defeitos";
            this.grid_cad_defeitos.ReadOnly = true;
            this.grid_cad_defeitos.Size = new System.Drawing.Size(910, 506);
            this.grid_cad_defeitos.TabIndex = 6;
            this.grid_cad_defeitos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_cad_defeitos_CellDoubleClick);
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
            // button_filtrar
            // 
            this.button_filtrar.Location = new System.Drawing.Point(12, 149);
            this.button_filtrar.Name = "button_filtrar";
            this.button_filtrar.Size = new System.Drawing.Size(114, 23);
            this.button_filtrar.TabIndex = 9;
            this.button_filtrar.Text = "Filtrar";
            this.button_filtrar.UseVisualStyleBackColor = true;
            this.button_filtrar.Click += new System.EventHandler(this.button_filtrar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_limpar_controles);
            this.groupBox2.Controls.Add(this.button_atualizar);
            this.groupBox2.Controls.Add(this.button_filtrar);
            this.groupBox2.Controls.Add(this.button_salvar);
            this.groupBox2.Controls.Add(this.button_deletar);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(142, 612);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu";
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
            // Form_janela_cad_defeitos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 612);
            this.Controls.Add(this.grid_cad_defeitos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form_janela_cad_defeitos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Defeitos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_cad_defeitos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox text_descri_apara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_cod_defeito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid_cad_defeitos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_origem_apara;
        private System.Windows.Forms.TextBox text_observacao;
        private System.Windows.Forms.Button button_salvar;
        private System.Windows.Forms.Button button_deletar;
        private System.Windows.Forms.Button button_filtrar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_desc_origem_apara;
        private System.Windows.Forms.Button button_atualizar;
        private System.Windows.Forms.Label label_id_defeitos;
        private System.Windows.Forms.Button button_limpar_controles;
    }
}