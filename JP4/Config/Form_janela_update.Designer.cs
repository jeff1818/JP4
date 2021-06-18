
namespace JP4
{
    partial class Form_janela_update
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
            this.label_versao_app = new System.Windows.Forms.Label();
            this.label_nova_versao = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Atualizador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Versão  Atual:";
            // 
            // label_versao_app
            // 
            this.label_versao_app.AutoSize = true;
            this.label_versao_app.Location = new System.Drawing.Point(151, 45);
            this.label_versao_app.Name = "label_versao_app";
            this.label_versao_app.Size = new System.Drawing.Size(13, 13);
            this.label_versao_app.TabIndex = 2;
            this.label_versao_app.Text = "--";
            // 
            // label_nova_versao
            // 
            this.label_nova_versao.AutoSize = true;
            this.label_nova_versao.Location = new System.Drawing.Point(151, 72);
            this.label_nova_versao.Name = "label_nova_versao";
            this.label_nova_versao.Size = new System.Drawing.Size(13, 13);
            this.label_nova_versao.TabIndex = 4;
            this.label_nova_versao.Text = "--";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nova versão:";
            // 
            // Form_janela_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 117);
            this.Controls.Add(this.label_nova_versao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_versao_app);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form_janela_update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Auto update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_versao_app;
        private System.Windows.Forms.Label label_nova_versao;
        private System.Windows.Forms.Label label4;
    }
}