
namespace JP4
{
    partial class CONF01
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
            this.button_buscar_local = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.text_endereco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_salvar_endereco = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label_status_con = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_mostrar_modelo = new System.Windows.Forms.Button();
            this.text_local_arquivo_ordem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_salva_local_os = new System.Windows.Forms.Button();
            this.button_busca_loca_arquivo_os = new System.Windows.Forms.Button();
            this.button_janela_update = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_buscar_local
            // 
            this.button_buscar_local.Location = new System.Drawing.Point(11, 89);
            this.button_buscar_local.Name = "button_buscar_local";
            this.button_buscar_local.Size = new System.Drawing.Size(75, 23);
            this.button_buscar_local.TabIndex = 0;
            this.button_buscar_local.Text = "Busca";
            this.button_buscar_local.UseVisualStyleBackColor = true;
            this.button_buscar_local.Click += new System.EventHandler(this.button_procurar_pasta_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(744, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_janela_update);
            this.groupBox1.Controls.Add(this.text_endereco);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_salvar_endereco);
            this.groupBox1.Controls.Add(this.button_buscar_local);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 130);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // text_endereco
            // 
            this.text_endereco.Location = new System.Drawing.Point(6, 63);
            this.text_endereco.Name = "text_endereco";
            this.text_endereco.Size = new System.Drawing.Size(639, 20);
            this.text_endereco.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Endereço banco de dados Access";
            // 
            // button_salvar_endereco
            // 
            this.button_salvar_endereco.Location = new System.Drawing.Point(92, 89);
            this.button_salvar_endereco.Name = "button_salvar_endereco";
            this.button_salvar_endereco.Size = new System.Drawing.Size(75, 23);
            this.button_salvar_endereco.TabIndex = 3;
            this.button_salvar_endereco.Text = "Salvar Local";
            this.button_salvar_endereco.UseVisualStyleBackColor = true;
            this.button_salvar_endereco.Click += new System.EventHandler(this.button_salvar_endereco_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.label_status_con});
            this.statusStrip1.Location = new System.Drawing.Point(0, 292);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(744, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label_status_con
            // 
            this.label_status_con.Name = "label_status_con";
            this.label_status_con.Size = new System.Drawing.Size(22, 17);
            this.label_status_con.Text = "---";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_mostrar_modelo);
            this.groupBox2.Controls.Add(this.text_local_arquivo_ordem);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button_salva_local_os);
            this.groupBox2.Controls.Add(this.button_busca_loca_arquivo_os);
            this.groupBox2.Location = new System.Drawing.Point(11, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(721, 130);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu";
            // 
            // button_mostrar_modelo
            // 
            this.button_mostrar_modelo.Location = new System.Drawing.Point(527, 89);
            this.button_mostrar_modelo.Name = "button_mostrar_modelo";
            this.button_mostrar_modelo.Size = new System.Drawing.Size(118, 23);
            this.button_mostrar_modelo.TabIndex = 6;
            this.button_mostrar_modelo.Text = "Modelo de arquivo";
            this.button_mostrar_modelo.UseVisualStyleBackColor = true;
            // 
            // text_local_arquivo_ordem
            // 
            this.text_local_arquivo_ordem.Location = new System.Drawing.Point(6, 63);
            this.text_local_arquivo_ordem.Name = "text_local_arquivo_ordem";
            this.text_local_arquivo_ordem.Size = new System.Drawing.Size(639, 20);
            this.text_local_arquivo_ordem.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(441, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pasta local - Importação ordem de produção";
            // 
            // button_salva_local_os
            // 
            this.button_salva_local_os.Location = new System.Drawing.Point(92, 89);
            this.button_salva_local_os.Name = "button_salva_local_os";
            this.button_salva_local_os.Size = new System.Drawing.Size(75, 23);
            this.button_salva_local_os.TabIndex = 3;
            this.button_salva_local_os.Text = "Salvar Local";
            this.button_salva_local_os.UseVisualStyleBackColor = true;
            this.button_salva_local_os.Click += new System.EventHandler(this.button_salva_local_os_Click);
            // 
            // button_busca_loca_arquivo_os
            // 
            this.button_busca_loca_arquivo_os.Location = new System.Drawing.Point(11, 89);
            this.button_busca_loca_arquivo_os.Name = "button_busca_loca_arquivo_os";
            this.button_busca_loca_arquivo_os.Size = new System.Drawing.Size(75, 23);
            this.button_busca_loca_arquivo_os.TabIndex = 0;
            this.button_busca_loca_arquivo_os.Text = "Busca";
            this.button_busca_loca_arquivo_os.UseVisualStyleBackColor = true;
            this.button_busca_loca_arquivo_os.Click += new System.EventHandler(this.button_busca_loca_arquivo_os_Click);
            // 
            // button_janela_update
            // 
            this.button_janela_update.Location = new System.Drawing.Point(640, 89);
            this.button_janela_update.Name = "button_janela_update";
            this.button_janela_update.Size = new System.Drawing.Size(75, 23);
            this.button_janela_update.TabIndex = 6;
            this.button_janela_update.Text = "Verificar atualização";
            this.button_janela_update.UseVisualStyleBackColor = true;
            this.button_janela_update.Click += new System.EventHandler(this.button_janela_update_Click);
            // 
            // CONF01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 314);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CONF01";
            this.Text = "Form_janela_config";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button_buscar_local;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox text_endereco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_salvar_endereco;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel label_status_con;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_mostrar_modelo;
        private System.Windows.Forms.TextBox text_local_arquivo_ordem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_salva_local_os;
        private System.Windows.Forms.Button button_busca_loca_arquivo_os;
        private System.Windows.Forms.Button button_janela_update;
    }
}