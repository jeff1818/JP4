
namespace JP4
{
    partial class Form_janela_cad_local_aplicacao
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
            this.grid_cad_local_aplicacao = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_id_local_aplica = new System.Windows.Forms.Label();
            this.text_descri_local_aplic = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_local_aplic = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_limpar_controles = new System.Windows.Forms.Button();
            this.button_atualizar = new System.Windows.Forms.Button();
            this.button_filtrar = new System.Windows.Forms.Button();
            this.button_salvar = new System.Windows.Forms.Button();
            this.button_deletar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_cad_local_aplicacao)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid_cad_local_aplicacao
            // 
            this.grid_cad_local_aplicacao.AllowUserToAddRows = false;
            this.grid_cad_local_aplicacao.AllowUserToDeleteRows = false;
            this.grid_cad_local_aplicacao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_cad_local_aplicacao.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grid_cad_local_aplicacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_cad_local_aplicacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_cad_local_aplicacao.Location = new System.Drawing.Point(142, 106);
            this.grid_cad_local_aplicacao.Name = "grid_cad_local_aplicacao";
            this.grid_cad_local_aplicacao.ReadOnly = true;
            this.grid_cad_local_aplicacao.Size = new System.Drawing.Size(910, 506);
            this.grid_cad_local_aplicacao.TabIndex = 9;
            this.grid_cad_local_aplicacao.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_cad_local_aplicacao_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_id_local_aplica);
            this.groupBox1.Controls.Add(this.text_descri_local_aplic);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.text_local_aplic);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(142, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(910, 106);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informação basica";
            // 
            // label_id_local_aplica
            // 
            this.label_id_local_aplica.AutoSize = true;
            this.label_id_local_aplica.Location = new System.Drawing.Point(6, 84);
            this.label_id_local_aplica.Name = "label_id_local_aplica";
            this.label_id_local_aplica.Size = new System.Drawing.Size(15, 13);
            this.label_id_local_aplica.TabIndex = 8;
            this.label_id_local_aplica.Text = "id";
            // 
            // text_descri_local_aplic
            // 
            this.text_descri_local_aplic.Location = new System.Drawing.Point(103, 50);
            this.text_descri_local_aplic.Name = "text_descri_local_aplic";
            this.text_descri_local_aplic.Size = new System.Drawing.Size(352, 20);
            this.text_descri_local_aplic.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição:";
            // 
            // text_local_aplic
            // 
            this.text_local_aplic.Location = new System.Drawing.Point(103, 24);
            this.text_local_aplic.Name = "text_local_aplic";
            this.text_local_aplic.Size = new System.Drawing.Size(352, 20);
            this.text_local_aplic.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Local Aplicação";
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
            this.groupBox2.TabIndex = 10;
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
            // Form_janela_cad_local_aplicacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 612);
            this.Controls.Add(this.grid_cad_local_aplicacao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form_janela_cad_local_aplicacao";
            this.Text = "Cadastro de local de aplicação";
            ((System.ComponentModel.ISupportInitialize)(this.grid_cad_local_aplicacao)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_cad_local_aplicacao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_id_local_aplica;
        private System.Windows.Forms.TextBox text_descri_local_aplic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_local_aplic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_limpar_controles;
        private System.Windows.Forms.Button button_atualizar;
        private System.Windows.Forms.Button button_filtrar;
        private System.Windows.Forms.Button button_salvar;
        private System.Windows.Forms.Button button_deletar;
    }
}