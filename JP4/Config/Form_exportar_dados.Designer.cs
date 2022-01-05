namespace JP4.Config
{
    partial class Form_exportar_dados
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_buscar_local = new System.Windows.Forms.Button();
            this.text_local_export = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_sair = new System.Windows.Forms.Button();
            this.button_consumo_mp = new System.Windows.Forms.Button();
            this.button_defeitos = new System.Windows.Forms.Button();
            this.button_apontamento = new System.Windows.Forms.Button();
            this.button_paradas = new System.Windows.Forms.Button();
            this.button_salvar_local = new System.Windows.Forms.Button();
            this.label_titulo_tabela = new System.Windows.Forms.Label();
            this.button_exportar_todos = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button_exportar_cadastro = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_exportar_cadastro);
            this.groupBox1.Controls.Add(this.button_exportar_todos);
            this.groupBox1.Controls.Add(this.button_sair);
            this.groupBox1.Controls.Add(this.label_titulo_tabela);
            this.groupBox1.Controls.Add(this.button_consumo_mp);
            this.groupBox1.Controls.Add(this.button_defeitos);
            this.groupBox1.Controls.Add(this.button_paradas);
            this.groupBox1.Controls.Add(this.button_apontamento);
            this.groupBox1.Controls.Add(this.button_salvar_local);
            this.groupBox1.Controls.Add(this.button_buscar_local);
            this.groupBox1.Controls.Add(this.text_local_export);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 284);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informação basica";
            // 
            // button_buscar_local
            // 
            this.button_buscar_local.Location = new System.Drawing.Point(85, 59);
            this.button_buscar_local.Name = "button_buscar_local";
            this.button_buscar_local.Size = new System.Drawing.Size(114, 25);
            this.button_buscar_local.TabIndex = 12;
            this.button_buscar_local.Text = "Buscar local";
            this.button_buscar_local.UseVisualStyleBackColor = true;
            this.button_buscar_local.Click += new System.EventHandler(this.button_buscar_local_Click);
            // 
            // text_local_export
            // 
            this.text_local_export.Location = new System.Drawing.Point(85, 33);
            this.text_local_export.Name = "text_local_export";
            this.text_local_export.Size = new System.Drawing.Size(517, 20);
            this.text_local_export.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Local Padrão:";
            // 
            // button_sair
            // 
            this.button_sair.Location = new System.Drawing.Point(370, 216);
            this.button_sair.Name = "button_sair";
            this.button_sair.Size = new System.Drawing.Size(114, 23);
            this.button_sair.TabIndex = 14;
            this.button_sair.Text = "Sair";
            this.button_sair.UseVisualStyleBackColor = true;
            this.button_sair.Click += new System.EventHandler(this.button_sair_Click);
            // 
            // button_consumo_mp
            // 
            this.button_consumo_mp.Location = new System.Drawing.Point(370, 131);
            this.button_consumo_mp.Name = "button_consumo_mp";
            this.button_consumo_mp.Size = new System.Drawing.Size(114, 23);
            this.button_consumo_mp.TabIndex = 11;
            this.button_consumo_mp.Text = "Consumo - MP";
            this.button_consumo_mp.UseVisualStyleBackColor = true;
            this.button_consumo_mp.Click += new System.EventHandler(this.button_consumo_mp_Click);
            // 
            // button_defeitos
            // 
            this.button_defeitos.Location = new System.Drawing.Point(129, 131);
            this.button_defeitos.Name = "button_defeitos";
            this.button_defeitos.Size = new System.Drawing.Size(114, 23);
            this.button_defeitos.TabIndex = 10;
            this.button_defeitos.Text = "Defeitos";
            this.button_defeitos.UseVisualStyleBackColor = true;
            this.button_defeitos.Click += new System.EventHandler(this.button_defeitos_Click);
            // 
            // button_apontamento
            // 
            this.button_apontamento.Location = new System.Drawing.Point(9, 131);
            this.button_apontamento.Name = "button_apontamento";
            this.button_apontamento.Size = new System.Drawing.Size(114, 23);
            this.button_apontamento.TabIndex = 7;
            this.button_apontamento.Text = "Apontamento";
            this.button_apontamento.UseVisualStyleBackColor = true;
            this.button_apontamento.Click += new System.EventHandler(this.button_apontamento_Click);
            // 
            // button_paradas
            // 
            this.button_paradas.Location = new System.Drawing.Point(249, 131);
            this.button_paradas.Name = "button_paradas";
            this.button_paradas.Size = new System.Drawing.Size(114, 23);
            this.button_paradas.TabIndex = 8;
            this.button_paradas.Text = "Paradas";
            this.button_paradas.UseVisualStyleBackColor = true;
            this.button_paradas.Click += new System.EventHandler(this.button_paradas_Click);
            // 
            // button_salvar_local
            // 
            this.button_salvar_local.Location = new System.Drawing.Point(205, 59);
            this.button_salvar_local.Name = "button_salvar_local";
            this.button_salvar_local.Size = new System.Drawing.Size(114, 25);
            this.button_salvar_local.TabIndex = 13;
            this.button_salvar_local.Text = "Salvar Local";
            this.button_salvar_local.UseVisualStyleBackColor = true;
            this.button_salvar_local.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_titulo_tabela
            // 
            this.label_titulo_tabela.AutoSize = true;
            this.label_titulo_tabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo_tabela.Location = new System.Drawing.Point(80, 87);
            this.label_titulo_tabela.Name = "label_titulo_tabela";
            this.label_titulo_tabela.Size = new System.Drawing.Size(27, 25);
            this.label_titulo_tabela.TabIndex = 20;
            this.label_titulo_tabela.Text = "...";
            // 
            // button_exportar_todos
            // 
            this.button_exportar_todos.Location = new System.Drawing.Point(6, 216);
            this.button_exportar_todos.Name = "button_exportar_todos";
            this.button_exportar_todos.Size = new System.Drawing.Size(114, 23);
            this.button_exportar_todos.TabIndex = 21;
            this.button_exportar_todos.Text = "Exportar todos";
            this.button_exportar_todos.UseVisualStyleBackColor = true;
            this.button_exportar_todos.Click += new System.EventHandler(this.button_exportar_todos_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 249);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(596, 23);
            this.progressBar1.TabIndex = 21;
            // 
            // button_exportar_cadastro
            // 
            this.button_exportar_cadastro.Location = new System.Drawing.Point(490, 131);
            this.button_exportar_cadastro.Name = "button_exportar_cadastro";
            this.button_exportar_cadastro.Size = new System.Drawing.Size(114, 23);
            this.button_exportar_cadastro.TabIndex = 22;
            this.button_exportar_cadastro.Text = "Cadastro - Material";
            this.button_exportar_cadastro.UseVisualStyleBackColor = true;
            this.button_exportar_cadastro.Click += new System.EventHandler(this.button_exportar_cadastro_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // Form_exportar_dados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 284);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_exportar_dados";
            this.Text = "Form_exportar_dados";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox text_local_export;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_sair;
        private System.Windows.Forms.Button button_consumo_mp;
        private System.Windows.Forms.Button button_defeitos;
        private System.Windows.Forms.Button button_apontamento;
        private System.Windows.Forms.Button button_paradas;
        private System.Windows.Forms.Button button_buscar_local;
        private System.Windows.Forms.Button button_salvar_local;
        private System.Windows.Forms.Label label_titulo_tabela;
        private System.Windows.Forms.Button button_exportar_todos;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button_exportar_cadastro;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}