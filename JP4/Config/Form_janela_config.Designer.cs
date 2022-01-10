
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.verificarAtualizaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_config_local = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_config_local.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.text_endereco);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_salvar_endereco);
            this.groupBox1.Controls.Add(this.button_buscar_local);
            this.groupBox1.Location = new System.Drawing.Point(7, 11);
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
            this.label1.Size = new System.Drawing.Size(316, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Endereço planilhas exportadas.";
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 506);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(969, 22);
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
            this.groupBox2.Location = new System.Drawing.Point(7, 147);
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
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verificarAtualizaçãoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(969, 24);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // verificarAtualizaçãoToolStripMenuItem
            // 
            this.verificarAtualizaçãoToolStripMenuItem.Name = "verificarAtualizaçãoToolStripMenuItem";
            this.verificarAtualizaçãoToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.verificarAtualizaçãoToolStripMenuItem.Text = "Verificar Atualização";
            this.verificarAtualizaçãoToolStripMenuItem.Click += new System.EventHandler(this.verificarAtualizaçãoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_config_local);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(969, 482);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage_config_local
            // 
            this.tabPage_config_local.Controls.Add(this.groupBox1);
            this.tabPage_config_local.Controls.Add(this.groupBox2);
            this.tabPage_config_local.Location = new System.Drawing.Point(4, 22);
            this.tabPage_config_local.Name = "tabPage_config_local";
            this.tabPage_config_local.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_config_local.Size = new System.Drawing.Size(961, 456);
            this.tabPage_config_local.TabIndex = 0;
            this.tabPage_config_local.Text = "Config. Locais";
            this.tabPage_config_local.UseVisualStyleBackColor = true;
            // 
            // CONF01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 528);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CONF01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_janela_config";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage_config_local.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem verificarAtualizaçãoToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_config_local;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}