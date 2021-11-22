
namespace JP4.Config
{
    partial class Form_janela_cad_usuario
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_id_cad_usuario = new System.Windows.Forms.Label();
            this.combo_empresa = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.combo_tipo_user = new System.Windows.Forms.ComboBox();
            this.text_dica_senha = new System.Windows.Forms.TextBox();
            this.text_senha_user = new System.Windows.Forms.TextBox();
            this.text_nome_user = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grid_cad_usuario = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_cad_usuario)).BeginInit();
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
            this.groupBox2.Size = new System.Drawing.Size(142, 563);
            this.groupBox2.TabIndex = 16;
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
            this.button_filtrar.Click += new System.EventHandler(this.button_filtrar_Click);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_id_cad_usuario);
            this.groupBox1.Controls.Add(this.combo_empresa);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.combo_tipo_user);
            this.groupBox1.Controls.Add(this.text_dica_senha);
            this.groupBox1.Controls.Add(this.text_senha_user);
            this.groupBox1.Controls.Add(this.text_nome_user);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(142, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 158);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informação";
            // 
            // label_id_cad_usuario
            // 
            this.label_id_cad_usuario.AutoSize = true;
            this.label_id_cad_usuario.Location = new System.Drawing.Point(6, 130);
            this.label_id_cad_usuario.Name = "label_id_cad_usuario";
            this.label_id_cad_usuario.Size = new System.Drawing.Size(15, 13);
            this.label_id_cad_usuario.TabIndex = 10;
            this.label_id_cad_usuario.Text = "id";
            // 
            // combo_empresa
            // 
            this.combo_empresa.FormattingEnabled = true;
            this.combo_empresa.Location = new System.Drawing.Point(286, 62);
            this.combo_empresa.Name = "combo_empresa";
            this.combo_empresa.Size = new System.Drawing.Size(137, 21);
            this.combo_empresa.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Empresa:";
            // 
            // combo_tipo_user
            // 
            this.combo_tipo_user.AutoCompleteCustomSource.AddRange(new string[] {
            "admin",
            "prod"});
            this.combo_tipo_user.FormattingEnabled = true;
            this.combo_tipo_user.Items.AddRange(new object[] {
            "admin",
            "prod",
            "visitante"});
            this.combo_tipo_user.Location = new System.Drawing.Point(86, 64);
            this.combo_tipo_user.Name = "combo_tipo_user";
            this.combo_tipo_user.Size = new System.Drawing.Size(137, 21);
            this.combo_tipo_user.TabIndex = 7;
            // 
            // text_dica_senha
            // 
            this.text_dica_senha.Location = new System.Drawing.Point(524, 36);
            this.text_dica_senha.Name = "text_dica_senha";
            this.text_dica_senha.Size = new System.Drawing.Size(123, 20);
            this.text_dica_senha.TabIndex = 6;
            // 
            // text_senha_user
            // 
            this.text_senha_user.Location = new System.Drawing.Point(286, 36);
            this.text_senha_user.Name = "text_senha_user";
            this.text_senha_user.Size = new System.Drawing.Size(137, 20);
            this.text_senha_user.TabIndex = 5;
            // 
            // text_nome_user
            // 
            this.text_nome_user.Location = new System.Drawing.Point(86, 36);
            this.text_nome_user.Name = "text_nome_user";
            this.text_nome_user.Size = new System.Drawing.Size(137, 20);
            this.text_nome_user.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(452, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dica Senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo user:";
            // 
            // grid_cad_usuario
            // 
            this.grid_cad_usuario.AllowUserToAddRows = false;
            this.grid_cad_usuario.AllowUserToDeleteRows = false;
            this.grid_cad_usuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_cad_usuario.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grid_cad_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_cad_usuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_cad_usuario.Location = new System.Drawing.Point(142, 158);
            this.grid_cad_usuario.Name = "grid_cad_usuario";
            this.grid_cad_usuario.ReadOnly = true;
            this.grid_cad_usuario.Size = new System.Drawing.Size(757, 405);
            this.grid_cad_usuario.TabIndex = 20;
            this.grid_cad_usuario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_cad_usuario_CellDoubleClick);
            // 
            // Form_janela_cad_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 563);
            this.Controls.Add(this.grid_cad_usuario);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_janela_cad_usuario";
            this.Text = "Form_janela_cad_usuario";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_cad_usuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_sair;
        private System.Windows.Forms.Button button_limpar_controles;
        private System.Windows.Forms.Button button_atualizar;
        private System.Windows.Forms.Button button_salvar;
        private System.Windows.Forms.Button button_deletar;
        private System.Windows.Forms.Button button_filtrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView grid_cad_usuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_tipo_user;
        private System.Windows.Forms.TextBox text_dica_senha;
        private System.Windows.Forms.TextBox text_senha_user;
        private System.Windows.Forms.TextBox text_nome_user;
        private System.Windows.Forms.ComboBox combo_empresa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_id_cad_usuario;
    }
}