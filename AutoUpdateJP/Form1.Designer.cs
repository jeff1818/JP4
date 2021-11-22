
namespace AutoUpdateJP
{
    partial class AutoUpdate_JP
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoUpdate_JP));
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label_baixar_status = new System.Windows.Forms.Label();
            this.button_baixar = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelDownloaded = new System.Windows.Forms.Label();
            this.labelPerc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 60);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(708, 23);
            this.progressBar.TabIndex = 0;
            // 
            // label_baixar_status
            // 
            this.label_baixar_status.AutoSize = true;
            this.label_baixar_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_baixar_status.Location = new System.Drawing.Point(283, 23);
            this.label_baixar_status.Name = "label_baixar_status";
            this.label_baixar_status.Size = new System.Drawing.Size(183, 22);
            this.label_baixar_status.TabIndex = 1;
            this.label_baixar_status.Text = "Atualizando aplicativo";
            // 
            // button_baixar
            // 
            this.button_baixar.Location = new System.Drawing.Point(15, 109);
            this.button_baixar.Name = "button_baixar";
            this.button_baixar.Size = new System.Drawing.Size(75, 23);
            this.button_baixar.TabIndex = 2;
            this.button_baixar.Text = "Baixar";
            this.button_baixar.UseVisualStyleBackColor = true;
            this.button_baixar.Visible = false;
            this.button_baixar.Click += new System.EventHandler(this.button_baixar_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(312, 109);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_cancelar.TabIndex = 3;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Visible = false;
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(705, 86);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(15, 13);
            this.labelSpeed.TabIndex = 4;
            this.labelSpeed.Text = "%";
            // 
            // labelDownloaded
            // 
            this.labelDownloaded.AutoSize = true;
            this.labelDownloaded.Location = new System.Drawing.Point(101, 86);
            this.labelDownloaded.Name = "labelDownloaded";
            this.labelDownloaded.Size = new System.Drawing.Size(15, 13);
            this.labelDownloaded.TabIndex = 5;
            this.labelDownloaded.Text = "%";
            // 
            // labelPerc
            // 
            this.labelPerc.AutoSize = true;
            this.labelPerc.Location = new System.Drawing.Point(12, 86);
            this.labelPerc.Name = "labelPerc";
            this.labelPerc.Size = new System.Drawing.Size(15, 13);
            this.labelPerc.TabIndex = 6;
            this.labelPerc.Text = "%";
            // 
            // AutoUpdate_JP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 144);
            this.Controls.Add(this.labelPerc);
            this.Controls.Add(this.labelDownloaded);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.button_baixar);
            this.Controls.Add(this.label_baixar_status);
            this.Controls.Add(this.progressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AutoUpdate_JP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AutoUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label_baixar_status;
        private System.Windows.Forms.Button button_baixar;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelDownloaded;
        private System.Windows.Forms.Label labelPerc;
    }
}

