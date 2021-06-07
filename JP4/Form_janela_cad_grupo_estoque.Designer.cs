
namespace JP4
{
    partial class Form_janela_cad_grupo_estoque
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
            this.grid_cad_grupo_estoque = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.text_cod_grupo_estoque = new System.Windows.Forms.TextBox();
            this.text_nome_grupo_estoque = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.text_descr_grupo_estoque = new System.Windows.Forms.TextBox();
            this.label_id_grupo_estoque = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_cad_grupo_estoque)).BeginInit();
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
            this.groupBox2.TabIndex = 8;
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
            // grid_cad_grupo_estoque
            // 
            this.grid_cad_grupo_estoque.AllowUserToAddRows = false;
            this.grid_cad_grupo_estoque.AllowUserToDeleteRows = false;
            this.grid_cad_grupo_estoque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_cad_grupo_estoque.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grid_cad_grupo_estoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_cad_grupo_estoque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_cad_grupo_estoque.Location = new System.Drawing.Point(142, 106);
            this.grid_cad_grupo_estoque.Name = "grid_cad_grupo_estoque";
            this.grid_cad_grupo_estoque.ReadOnly = true;
            this.grid_cad_grupo_estoque.Size = new System.Drawing.Size(910, 506);
            this.grid_cad_grupo_estoque.TabIndex = 10;
            this.grid_cad_grupo_estoque.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_cad_grupo_estoque_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Grupo ";
            // 
            // text_cod_grupo_estoque
            // 
            this.text_cod_grupo_estoque.Location = new System.Drawing.Point(178, 24);
            this.text_cod_grupo_estoque.Name = "text_cod_grupo_estoque";
            this.text_cod_grupo_estoque.Size = new System.Drawing.Size(128, 20);
            this.text_cod_grupo_estoque.TabIndex = 1;
            // 
            // text_nome_grupo_estoque
            // 
            this.text_nome_grupo_estoque.Location = new System.Drawing.Point(178, 52);
            this.text_nome_grupo_estoque.Name = "text_nome_grupo_estoque";
            this.text_nome_grupo_estoque.Size = new System.Drawing.Size(306, 20);
            this.text_nome_grupo_estoque.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descrição Grupo de estoque";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Descrição";
            // 
            // text_descr_grupo_estoque
            // 
            this.text_descr_grupo_estoque.Location = new System.Drawing.Point(178, 78);
            this.text_descr_grupo_estoque.Name = "text_descr_grupo_estoque";
            this.text_descr_grupo_estoque.Size = new System.Drawing.Size(306, 20);
            this.text_descr_grupo_estoque.TabIndex = 3;
            // 
            // label_id_grupo_estoque
            // 
            this.label_id_grupo_estoque.AutoSize = true;
            this.label_id_grupo_estoque.Location = new System.Drawing.Point(819, 81);
            this.label_id_grupo_estoque.Name = "label_id_grupo_estoque";
            this.label_id_grupo_estoque.Size = new System.Drawing.Size(15, 13);
            this.label_id_grupo_estoque.TabIndex = 8;
            this.label_id_grupo_estoque.Text = "id";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_id_grupo_estoque);
            this.groupBox1.Controls.Add(this.text_descr_grupo_estoque);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.text_nome_grupo_estoque);
            this.groupBox1.Controls.Add(this.text_cod_grupo_estoque);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(142, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(910, 106);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informação basica";
            // 
            // Form_janela_cad_grupo_estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 612);
            this.Controls.Add(this.grid_cad_grupo_estoque);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form_janela_cad_grupo_estoque";
            this.Text = "Cadastro de grupo de estoque";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_cad_grupo_estoque)).EndInit();
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
        private System.Windows.Forms.DataGridView grid_cad_grupo_estoque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_cod_grupo_estoque;
        private System.Windows.Forms.TextBox text_nome_grupo_estoque;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_descr_grupo_estoque;
        private System.Windows.Forms.Label label_id_grupo_estoque;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}