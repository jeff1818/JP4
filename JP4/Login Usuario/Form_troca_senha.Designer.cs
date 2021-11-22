
namespace JP4.Login_Usuario
{
    partial class Form_troca_senha
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_senha = new System.Windows.Forms.TextBox();
            this.textBox_confirma_senha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_salvar = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.label_troca_senha_usuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Troca de senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nova Senha:";
            // 
            // textBox_senha
            // 
            this.textBox_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_senha.Location = new System.Drawing.Point(12, 122);
            this.textBox_senha.Name = "textBox_senha";
            this.textBox_senha.Size = new System.Drawing.Size(217, 23);
            this.textBox_senha.TabIndex = 2;
            // 
            // textBox_confirma_senha
            // 
            this.textBox_confirma_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_confirma_senha.Location = new System.Drawing.Point(12, 188);
            this.textBox_confirma_senha.Name = "textBox_confirma_senha";
            this.textBox_confirma_senha.Size = new System.Drawing.Size(217, 23);
            this.textBox_confirma_senha.TabIndex = 4;
            this.textBox_confirma_senha.UseSystemPasswordChar = true;
            this.textBox_confirma_senha.TextChanged += new System.EventHandler(this.textBox_confirma_senha_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Confirme a Senha:";
            // 
            // button_salvar
            // 
            this.button_salvar.Location = new System.Drawing.Point(12, 232);
            this.button_salvar.Name = "button_salvar";
            this.button_salvar.Size = new System.Drawing.Size(217, 33);
            this.button_salvar.TabIndex = 5;
            this.button_salvar.Text = "Salvar Senha";
            this.button_salvar.UseVisualStyleBackColor = true;
            this.button_salvar.Click += new System.EventHandler(this.button_salvar_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(12, 271);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(217, 33);
            this.button_cancelar.TabIndex = 6;
            this.button_cancelar.Text = "SAIR";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // label_troca_senha_usuario
            // 
            this.label_troca_senha_usuario.AutoSize = true;
            this.label_troca_senha_usuario.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_troca_senha_usuario.Location = new System.Drawing.Point(20, 60);
            this.label_troca_senha_usuario.Name = "label_troca_senha_usuario";
            this.label_troca_senha_usuario.Size = new System.Drawing.Size(34, 18);
            this.label_troca_senha_usuario.TabIndex = 7;
            this.label_troca_senha_usuario.Text = "user";
            // 
            // Form_troca_senha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(241, 329);
            this.Controls.Add(this.label_troca_senha_usuario);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.button_salvar);
            this.Controls.Add(this.textBox_confirma_senha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_senha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_troca_senha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_troca_senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_senha;
        private System.Windows.Forms.TextBox textBox_confirma_senha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_salvar;
        private System.Windows.Forms.Button button_cancelar;
        public System.Windows.Forms.Label label_troca_senha_usuario;
    }
}