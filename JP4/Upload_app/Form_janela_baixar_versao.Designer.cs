
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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label_status = new System.Windows.Forms.Label();
            this.button_verifica_atualizacao = new System.Windows.Forms.Button();
            this.button_baixar = new System.Windows.Forms.Button();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelPerc = new System.Windows.Forms.Label();
            this.labelDownloaded = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(9, 48);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(420, 23);
            this.progressBar.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.Location = new System.Drawing.Point(12, 9);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(32, 17);
            this.label_status.TabIndex = 1;
            this.label_status.Text = "......";
            // 
            // button_verifica_atualizacao
            // 
            this.button_verifica_atualizacao.Location = new System.Drawing.Point(9, 112);
            this.button_verifica_atualizacao.Name = "button_verifica_atualizacao";
            this.button_verifica_atualizacao.Size = new System.Drawing.Size(153, 23);
            this.button_verifica_atualizacao.TabIndex = 2;
            this.button_verifica_atualizacao.Text = "Verificar Atualização";
            this.button_verifica_atualizacao.UseVisualStyleBackColor = true;
            this.button_verifica_atualizacao.Click += new System.EventHandler(this.button_verifica_atualizacao_Click);
            // 
            // button_baixar
            // 
            this.button_baixar.Location = new System.Drawing.Point(354, 112);
            this.button_baixar.Name = "button_baixar";
            this.button_baixar.Size = new System.Drawing.Size(75, 23);
            this.button_baixar.TabIndex = 4;
            this.button_baixar.Text = "Baixar!";
            this.button_baixar.UseVisualStyleBackColor = true;
            this.button_baixar.Visible = false;
            this.button_baixar.Click += new System.EventHandler(this.button_baixar_Click);
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(324, 74);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(16, 13);
            this.labelSpeed.TabIndex = 5;
            this.labelSpeed.Text = "---";
            // 
            // labelPerc
            // 
            this.labelPerc.AutoSize = true;
            this.labelPerc.Location = new System.Drawing.Point(394, 74);
            this.labelPerc.Name = "labelPerc";
            this.labelPerc.Size = new System.Drawing.Size(16, 13);
            this.labelPerc.TabIndex = 6;
            this.labelPerc.Text = "---";
            // 
            // labelDownloaded
            // 
            this.labelDownloaded.AutoSize = true;
            this.labelDownloaded.Location = new System.Drawing.Point(12, 74);
            this.labelDownloaded.Name = "labelDownloaded";
            this.labelDownloaded.Size = new System.Drawing.Size(16, 13);
            this.labelDownloaded.TabIndex = 7;
            this.labelDownloaded.Text = "---";
            // 
            // CONFI02_UP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 140);
            this.Controls.Add(this.labelDownloaded);
            this.Controls.Add(this.labelPerc);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.button_baixar);
            this.Controls.Add(this.button_verifica_atualizacao);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.progressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "CONFI02_UP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Janela de atualização";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Button button_verifica_atualizacao;
        private System.Windows.Forms.Button button_baixar;
        private System.Windows.Forms.Label labelPerc;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelDownloaded;
    }
}