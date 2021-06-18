
namespace JP4
{
    partial class Form_janela_cad_origem_apara
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
            this.button_limpar_controles = new System.Windows.Forms.Button();
            this.button_atualizar = new System.Windows.Forms.Button();
            this.button_filtrar = new System.Windows.Forms.Button();
            this.button_salvar = new System.Windows.Forms.Button();
            this.button_deletar = new System.Windows.Forms.Button();
            this.grid_cad_local_estoque_origem = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combo_empresa = new System.Windows.Forms.ComboBox();
            this.label_id_local_estoque = new System.Windows.Forms.Label();
            this.text_local_estoque = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_observa = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_cad_local_estoque_origem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox2.TabIndex = 14;
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
            // grid_cad_local_estoque_origem
            // 
            this.grid_cad_local_estoque_origem.AllowUserToAddRows = false;
            this.grid_cad_local_estoque_origem.AllowUserToDeleteRows = false;
            this.grid_cad_local_estoque_origem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_cad_local_estoque_origem.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grid_cad_local_estoque_origem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_cad_local_estoque_origem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_cad_local_estoque_origem.Location = new System.Drawing.Point(142, 106);
            this.grid_cad_local_estoque_origem.Name = "grid_cad_local_estoque_origem";
            this.grid_cad_local_estoque_origem.ReadOnly = true;
            this.grid_cad_local_estoque_origem.Size = new System.Drawing.Size(910, 506);
            this.grid_cad_local_estoque_origem.TabIndex = 16;
            this.grid_cad_local_estoque_origem.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_cad_local_estoque_origem_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.text_observa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.combo_empresa);
            this.groupBox1.Controls.Add(this.label_id_local_estoque);
            this.groupBox1.Controls.Add(this.text_local_estoque);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(142, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(910, 106);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informação basica";
            // 
            // combo_empresa
            // 
            this.combo_empresa.FormattingEnabled = true;
            this.combo_empresa.Location = new System.Drawing.Point(103, 19);
            this.combo_empresa.Name = "combo_empresa";
            this.combo_empresa.Size = new System.Drawing.Size(185, 21);
            this.combo_empresa.TabIndex = 1;
            // 
            // label_id_local_estoque
            // 
            this.label_id_local_estoque.AutoSize = true;
            this.label_id_local_estoque.Location = new System.Drawing.Point(856, 16);
            this.label_id_local_estoque.Name = "label_id_local_estoque";
            this.label_id_local_estoque.Size = new System.Drawing.Size(15, 13);
            this.label_id_local_estoque.TabIndex = 8;
            this.label_id_local_estoque.Text = "id";
            // 
            // text_local_estoque
            // 
            this.text_local_estoque.Location = new System.Drawing.Point(103, 50);
            this.text_local_estoque.Name = "text_local_estoque";
            this.text_local_estoque.Size = new System.Drawing.Size(352, 20);
            this.text_local_estoque.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Local de Estoque";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Observação";
            // 
            // text_observa
            // 
            this.text_observa.Location = new System.Drawing.Point(103, 76);
            this.text_observa.Name = "text_observa";
            this.text_observa.Size = new System.Drawing.Size(564, 20);
            this.text_observa.TabIndex = 10;
            // 
            // Form_janela_cad_origem_apara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 612);
            this.Controls.Add(this.grid_cad_local_estoque_origem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form_janela_cad_origem_apara";
            this.Text = "Cadastro de Local Origem Apara";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_cad_local_estoque_origem)).EndInit();
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
        private System.Windows.Forms.DataGridView grid_cad_local_estoque_origem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox combo_empresa;
        private System.Windows.Forms.Label label_id_local_estoque;
        private System.Windows.Forms.TextBox text_local_estoque;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_observa;
        private System.Windows.Forms.Label label3;
    }
}