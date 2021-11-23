
namespace JP4
{
    partial class Form_janela_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_janela_login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.check_lembra_senha = new System.Windows.Forms.CheckBox();
            this.button_entrar = new System.Windows.Forms.Button();
            this.button_troca_senha = new System.Windows.Forms.Button();
            this.text_senha = new System.Windows.Forms.TextBox();
            this.text_usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_dica_senha = new System.Windows.Forms.Label();
            this.button_sair = new System.Windows.Forms.Button();
            this.button_config_db = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // check_lembra_senha
            // 
            this.check_lembra_senha.AutoSize = true;
            this.check_lembra_senha.Location = new System.Drawing.Point(17, 277);
            this.check_lembra_senha.Name = "check_lembra_senha";
            this.check_lembra_senha.Size = new System.Drawing.Size(104, 17);
            this.check_lembra_senha.TabIndex = 14;
            this.check_lembra_senha.Text = "Lembrar Senha?";
            this.check_lembra_senha.UseVisualStyleBackColor = true;
            this.check_lembra_senha.CheckedChanged += new System.EventHandler(this.check_lembra_senha_CheckedChanged);
            // 
            // button_entrar
            // 
            this.button_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_entrar.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_entrar.Location = new System.Drawing.Point(17, 329);
            this.button_entrar.Name = "button_entrar";
            this.button_entrar.Size = new System.Drawing.Size(205, 35);
            this.button_entrar.TabIndex = 13;
            this.button_entrar.Text = "Entrar";
            this.button_entrar.UseVisualStyleBackColor = true;
            this.button_entrar.Click += new System.EventHandler(this.button_entrar_Click);
            // 
            // button_troca_senha
            // 
            this.button_troca_senha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_troca_senha.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_troca_senha.Location = new System.Drawing.Point(17, 370);
            this.button_troca_senha.Name = "button_troca_senha";
            this.button_troca_senha.Size = new System.Drawing.Size(205, 32);
            this.button_troca_senha.TabIndex = 12;
            this.button_troca_senha.Text = "Trocar Senha";
            this.button_troca_senha.UseVisualStyleBackColor = true;
            this.button_troca_senha.Visible = false;
            this.button_troca_senha.Click += new System.EventHandler(this.button_troca_senha_Click);
            // 
            // text_senha
            // 
            this.text_senha.Location = new System.Drawing.Point(15, 251);
            this.text_senha.Name = "text_senha";
            this.text_senha.PasswordChar = '*';
            this.text_senha.Size = new System.Drawing.Size(207, 20);
            this.text_senha.TabIndex = 11;
            this.text_senha.Enter += new System.EventHandler(this.text_senha_Enter);
            // 
            // text_usuario
            // 
            this.text_usuario.Location = new System.Drawing.Point(15, 187);
            this.text_usuario.Name = "text_usuario";
            this.text_usuario.Size = new System.Drawing.Size(207, 20);
            this.text_usuario.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Usuario:";
            // 
            // label_dica_senha
            // 
            this.label_dica_senha.AutoSize = true;
            this.label_dica_senha.Location = new System.Drawing.Point(14, 297);
            this.label_dica_senha.Name = "label_dica_senha";
            this.label_dica_senha.Size = new System.Drawing.Size(13, 13);
            this.label_dica_senha.TabIndex = 16;
            this.label_dica_senha.Text = "--";
            this.label_dica_senha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_sair
            // 
            this.button_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sair.Font = new System.Drawing.Font("Maiandra GD", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sair.Location = new System.Drawing.Point(172, 445);
            this.button_sair.Name = "button_sair";
            this.button_sair.Size = new System.Drawing.Size(50, 23);
            this.button_sair.TabIndex = 17;
            this.button_sair.Text = "Sair";
            this.button_sair.UseVisualStyleBackColor = true;
            this.button_sair.Click += new System.EventHandler(this.button_sair_Click);
            // 
            // button_config_db
            // 
            this.button_config_db.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_config_db.Font = new System.Drawing.Font("Maiandra GD", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_config_db.Location = new System.Drawing.Point(17, 445);
            this.button_config_db.Name = "button_config_db";
            this.button_config_db.Size = new System.Drawing.Size(59, 23);
            this.button_config_db.TabIndex = 18;
            this.button_config_db.Text = "Config.";
            this.button_config_db.UseVisualStyleBackColor = true;
            this.button_config_db.Click += new System.EventHandler(this.button_config_db_Click);
            // 
            // Form_janela_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(249, 480);
            this.Controls.Add(this.button_config_db);
            this.Controls.Add(this.button_sair);
            this.Controls.Add(this.label_dica_senha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.check_lembra_senha);
            this.Controls.Add(this.button_entrar);
            this.Controls.Add(this.button_troca_senha);
            this.Controls.Add(this.text_senha);
            this.Controls.Add(this.text_usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_janela_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Integrado";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox check_lembra_senha;
        private System.Windows.Forms.Button button_entrar;
        private System.Windows.Forms.Button button_troca_senha;
        private System.Windows.Forms.TextBox text_senha;
        private System.Windows.Forms.TextBox text_usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_dica_senha;
        private System.Windows.Forms.Button button_sair;
        private System.Windows.Forms.Button button_config_db;
    }
}