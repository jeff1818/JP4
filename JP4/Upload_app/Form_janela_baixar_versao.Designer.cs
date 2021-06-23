
namespace JP4.Upload_app
{
    partial class CONFI02_UP
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
            this.components = new System.ComponentModel.Container();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label_status = new System.Windows.Forms.Label();
            this.button_verifica_atualizacao = new System.Windows.Forms.Button();
            this.label_link = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(420, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.Location = new System.Drawing.Point(157, 44);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(32, 17);
            this.label_status.TabIndex = 1;
            this.label_status.Text = "......";
            // 
            // button_verifica_atualizacao
            // 
            this.button_verifica_atualizacao.Location = new System.Drawing.Point(9, 41);
            this.button_verifica_atualizacao.Name = "button_verifica_atualizacao";
            this.button_verifica_atualizacao.Size = new System.Drawing.Size(75, 23);
            this.button_verifica_atualizacao.TabIndex = 2;
            this.button_verifica_atualizacao.Text = "Verificar Atualização";
            this.button_verifica_atualizacao.UseVisualStyleBackColor = true;
            this.button_verifica_atualizacao.Click += new System.EventHandler(this.button_verifica_atualizacao_Click);
            // 
            // label_link
            // 
            this.label_link.AutoSize = true;
            this.label_link.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_link.Location = new System.Drawing.Point(12, 87);
            this.label_link.Name = "label_link";
            this.label_link.Size = new System.Drawing.Size(32, 17);
            this.label_link.TabIndex = 3;
            this.label_link.Text = "......";
            // 
            // CONFI02_UP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 147);
            this.Controls.Add(this.label_link);
            this.Controls.Add(this.button_verifica_atualizacao);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "CONFI02_UP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Janela de atualização";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Button button_verifica_atualizacao;
        private System.Windows.Forms.Label label_link;
    }
}