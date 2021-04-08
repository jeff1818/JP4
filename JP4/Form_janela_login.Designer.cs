
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // check_lembra_senha
            // 
            this.check_lembra_senha.AutoSize = true;
            this.check_lembra_senha.Location = new System.Drawing.Point(241, 69);
            this.check_lembra_senha.Name = "check_lembra_senha";
            this.check_lembra_senha.Size = new System.Drawing.Size(104, 17);
            this.check_lembra_senha.TabIndex = 14;
            this.check_lembra_senha.Text = "Lembrar Senha?";
            this.check_lembra_senha.UseVisualStyleBackColor = true;
            // 
            // button_entrar
            // 
            this.button_entrar.Location = new System.Drawing.Point(270, 123);
            this.button_entrar.Name = "button_entrar";
            this.button_entrar.Size = new System.Drawing.Size(95, 23);
            this.button_entrar.TabIndex = 13;
            this.button_entrar.Text = "Entrar";
            this.button_entrar.UseVisualStyleBackColor = true;
            this.button_entrar.Click += new System.EventHandler(this.button_entrar_Click);
            // 
            // button_troca_senha
            // 
            this.button_troca_senha.Location = new System.Drawing.Point(169, 123);
            this.button_troca_senha.Name = "button_troca_senha";
            this.button_troca_senha.Size = new System.Drawing.Size(95, 23);
            this.button_troca_senha.TabIndex = 12;
            this.button_troca_senha.Text = "Trocar Senha";
            this.button_troca_senha.UseVisualStyleBackColor = true;
            // 
            // text_senha
            // 
            this.text_senha.Location = new System.Drawing.Point(241, 43);
            this.text_senha.Name = "text_senha";
            this.text_senha.PasswordChar = '*';
            this.text_senha.Size = new System.Drawing.Size(124, 20);
            this.text_senha.TabIndex = 11;
            // 
            // text_usuario
            // 
            this.text_usuario.Location = new System.Drawing.Point(241, 12);
            this.text_usuario.Name = "text_usuario";
            this.text_usuario.Size = new System.Drawing.Size(124, 20);
            this.text_usuario.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Usuario:";
            // 
            // label_dica_senha
            // 
            this.label_dica_senha.AutoSize = true;
            this.label_dica_senha.Location = new System.Drawing.Point(238, 89);
            this.label_dica_senha.Name = "label_dica_senha";
            this.label_dica_senha.Size = new System.Drawing.Size(13, 13);
            this.label_dica_senha.TabIndex = 16;
            this.label_dica_senha.Text = "--";
            this.label_dica_senha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_janela_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(402, 161);
            this.Controls.Add(this.label_dica_senha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.check_lembra_senha);
            this.Controls.Add(this.button_entrar);
            this.Controls.Add(this.button_troca_senha);
            this.Controls.Add(this.text_senha);
            this.Controls.Add(this.text_usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_janela_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_janela_login";
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
    }
}