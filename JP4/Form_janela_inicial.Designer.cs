
namespace JP4
{
    partial class Form_tela_inicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_tela_inicial));
            this.panel_titulo_menu = new System.Windows.Forms.Panel();
            this.botao_restor = new System.Windows.Forms.PictureBox();
            this.botao_mini = new System.Windows.Forms.PictureBox();
            this.botao_maxm = new System.Windows.Forms.PictureBox();
            this.botao_fechar = new System.Windows.Forms.PictureBox();
            this.panel_menu_vertical = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button_cad_grupo_estoque = new System.Windows.Forms.Button();
            this.label_inicio_versao_prog = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button_config = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button_cadastro_defeitos = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button_abrir_op = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_estrutura = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_cadastro_material = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_apontamento = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_central = new System.Windows.Forms.Panel();
            this.db_aplicativo_kpiDataSet = new JP4.db_aplicativo_kpiDataSet();
            this.db_configTableAdapter1 = new JP4.db_aplicativo_kpiDataSetTableAdapters.db_configTableAdapter();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button_cad_clientes = new System.Windows.Forms.Button();
            this.panel_titulo_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botao_restor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botao_mini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botao_maxm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botao_fechar)).BeginInit();
            this.panel_menu_vertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_aplicativo_kpiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_titulo_menu
            // 
            this.panel_titulo_menu.BackColor = System.Drawing.Color.Black;
            this.panel_titulo_menu.Controls.Add(this.botao_restor);
            this.panel_titulo_menu.Controls.Add(this.botao_mini);
            this.panel_titulo_menu.Controls.Add(this.botao_maxm);
            this.panel_titulo_menu.Controls.Add(this.botao_fechar);
            this.panel_titulo_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_titulo_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_titulo_menu.Name = "panel_titulo_menu";
            this.panel_titulo_menu.Size = new System.Drawing.Size(1369, 35);
            this.panel_titulo_menu.TabIndex = 3;
            this.panel_titulo_menu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_titulo_menu_MouseDown);
            // 
            // botao_restor
            // 
            this.botao_restor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botao_restor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botao_restor.Image = ((System.Drawing.Image)(resources.GetObject("botao_restor.Image")));
            this.botao_restor.Location = new System.Drawing.Point(1301, 4);
            this.botao_restor.Name = "botao_restor";
            this.botao_restor.Size = new System.Drawing.Size(25, 25);
            this.botao_restor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.botao_restor.TabIndex = 2;
            this.botao_restor.TabStop = false;
            this.botao_restor.Visible = false;
            this.botao_restor.Click += new System.EventHandler(this.botao_restor_Click);
            // 
            // botao_mini
            // 
            this.botao_mini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botao_mini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botao_mini.Image = ((System.Drawing.Image)(resources.GetObject("botao_mini.Image")));
            this.botao_mini.Location = new System.Drawing.Point(1270, 4);
            this.botao_mini.Name = "botao_mini";
            this.botao_mini.Size = new System.Drawing.Size(25, 25);
            this.botao_mini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.botao_mini.TabIndex = 1;
            this.botao_mini.TabStop = false;
            this.botao_mini.Click += new System.EventHandler(this.botao_mini_Click);
            // 
            // botao_maxm
            // 
            this.botao_maxm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botao_maxm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botao_maxm.Image = ((System.Drawing.Image)(resources.GetObject("botao_maxm.Image")));
            this.botao_maxm.Location = new System.Drawing.Point(1301, 4);
            this.botao_maxm.Name = "botao_maxm";
            this.botao_maxm.Size = new System.Drawing.Size(25, 25);
            this.botao_maxm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.botao_maxm.TabIndex = 1;
            this.botao_maxm.TabStop = false;
            this.botao_maxm.Click += new System.EventHandler(this.botao_maxm_Click);
            // 
            // botao_fechar
            // 
            this.botao_fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botao_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botao_fechar.Image = ((System.Drawing.Image)(resources.GetObject("botao_fechar.Image")));
            this.botao_fechar.Location = new System.Drawing.Point(1332, 4);
            this.botao_fechar.Name = "botao_fechar";
            this.botao_fechar.Size = new System.Drawing.Size(25, 25);
            this.botao_fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.botao_fechar.TabIndex = 0;
            this.botao_fechar.TabStop = false;
            this.botao_fechar.Click += new System.EventHandler(this.botao_fechar_Click);
            // 
            // panel_menu_vertical
            // 
            this.panel_menu_vertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel_menu_vertical.Controls.Add(this.panel8);
            this.panel_menu_vertical.Controls.Add(this.button_cad_clientes);
            this.panel_menu_vertical.Controls.Add(this.panel7);
            this.panel_menu_vertical.Controls.Add(this.button_cad_grupo_estoque);
            this.panel_menu_vertical.Controls.Add(this.label_inicio_versao_prog);
            this.panel_menu_vertical.Controls.Add(this.label1);
            this.panel_menu_vertical.Controls.Add(this.panel6);
            this.panel_menu_vertical.Controls.Add(this.button_config);
            this.panel_menu_vertical.Controls.Add(this.panel5);
            this.panel_menu_vertical.Controls.Add(this.button_cadastro_defeitos);
            this.panel_menu_vertical.Controls.Add(this.panel4);
            this.panel_menu_vertical.Controls.Add(this.button_abrir_op);
            this.panel_menu_vertical.Controls.Add(this.panel3);
            this.panel_menu_vertical.Controls.Add(this.button_estrutura);
            this.panel_menu_vertical.Controls.Add(this.panel2);
            this.panel_menu_vertical.Controls.Add(this.button_cadastro_material);
            this.panel_menu_vertical.Controls.Add(this.panel1);
            this.panel_menu_vertical.Controls.Add(this.button_apontamento);
            this.panel_menu_vertical.Controls.Add(this.pictureBox1);
            this.panel_menu_vertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu_vertical.Location = new System.Drawing.Point(0, 35);
            this.panel_menu_vertical.Name = "panel_menu_vertical";
            this.panel_menu_vertical.Size = new System.Drawing.Size(200, 689);
            this.panel_menu_vertical.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(3, 339);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 32);
            this.panel7.TabIndex = 16;
            // 
            // button_cad_grupo_estoque
            // 
            this.button_cad_grupo_estoque.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button_cad_grupo_estoque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button_cad_grupo_estoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cad_grupo_estoque.ForeColor = System.Drawing.Color.White;
            this.button_cad_grupo_estoque.Location = new System.Drawing.Point(14, 339);
            this.button_cad_grupo_estoque.Name = "button_cad_grupo_estoque";
            this.button_cad_grupo_estoque.Size = new System.Drawing.Size(180, 32);
            this.button_cad_grupo_estoque.TabIndex = 15;
            this.button_cad_grupo_estoque.Text = "Cadastro Grupo Estoque";
            this.button_cad_grupo_estoque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cad_grupo_estoque.UseVisualStyleBackColor = true;
            this.button_cad_grupo_estoque.Click += new System.EventHandler(this.button_cad_grupo_estoque_Click);
            // 
            // label_inicio_versao_prog
            // 
            this.label_inicio_versao_prog.AutoSize = true;
            this.label_inicio_versao_prog.Location = new System.Drawing.Point(99, 667);
            this.label_inicio_versao_prog.Name = "label_inicio_versao_prog";
            this.label_inicio_versao_prog.Size = new System.Drawing.Size(13, 13);
            this.label_inicio_versao_prog.TabIndex = 14;
            this.label_inicio_versao_prog.Text = "..";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 667);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Versão >>";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(3, 263);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 32);
            this.panel6.TabIndex = 13;
            // 
            // button_config
            // 
            this.button_config.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button_config.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button_config.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_config.ForeColor = System.Drawing.Color.White;
            this.button_config.Location = new System.Drawing.Point(14, 263);
            this.button_config.Name = "button_config";
            this.button_config.Size = new System.Drawing.Size(180, 32);
            this.button_config.TabIndex = 12;
            this.button_config.Text = "Configuração";
            this.button_config.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_config.UseVisualStyleBackColor = true;
            this.button_config.Click += new System.EventHandler(this.button_config_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(3, 301);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 32);
            this.panel5.TabIndex = 11;
            // 
            // button_cadastro_defeitos
            // 
            this.button_cadastro_defeitos.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button_cadastro_defeitos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button_cadastro_defeitos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cadastro_defeitos.ForeColor = System.Drawing.Color.White;
            this.button_cadastro_defeitos.Location = new System.Drawing.Point(14, 301);
            this.button_cadastro_defeitos.Name = "button_cadastro_defeitos";
            this.button_cadastro_defeitos.Size = new System.Drawing.Size(180, 32);
            this.button_cadastro_defeitos.TabIndex = 10;
            this.button_cadastro_defeitos.Text = "Cadastro Defeitos";
            this.button_cadastro_defeitos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cadastro_defeitos.UseVisualStyleBackColor = true;
            this.button_cadastro_defeitos.Click += new System.EventHandler(this.button_cadastro_defeitos_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(3, 111);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 32);
            this.panel4.TabIndex = 9;
            // 
            // button_abrir_op
            // 
            this.button_abrir_op.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button_abrir_op.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button_abrir_op.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_abrir_op.ForeColor = System.Drawing.Color.White;
            this.button_abrir_op.Location = new System.Drawing.Point(14, 111);
            this.button_abrir_op.Name = "button_abrir_op";
            this.button_abrir_op.Size = new System.Drawing.Size(180, 32);
            this.button_abrir_op.TabIndex = 8;
            this.button_abrir_op.Text = "Abrir ordem";
            this.button_abrir_op.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_abrir_op.UseVisualStyleBackColor = true;
            this.button_abrir_op.Click += new System.EventHandler(this.button_abrir_op_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(3, 225);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 32);
            this.panel3.TabIndex = 7;
            // 
            // button_estrutura
            // 
            this.button_estrutura.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button_estrutura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button_estrutura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_estrutura.ForeColor = System.Drawing.Color.White;
            this.button_estrutura.Location = new System.Drawing.Point(14, 225);
            this.button_estrutura.Name = "button_estrutura";
            this.button_estrutura.Size = new System.Drawing.Size(180, 32);
            this.button_estrutura.TabIndex = 6;
            this.button_estrutura.Text = "Estrutura Material";
            this.button_estrutura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_estrutura.UseVisualStyleBackColor = true;
            this.button_estrutura.Click += new System.EventHandler(this.button_estrutura_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(3, 187);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 32);
            this.panel2.TabIndex = 5;
            // 
            // button_cadastro_material
            // 
            this.button_cadastro_material.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button_cadastro_material.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button_cadastro_material.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cadastro_material.ForeColor = System.Drawing.Color.White;
            this.button_cadastro_material.Location = new System.Drawing.Point(14, 187);
            this.button_cadastro_material.Name = "button_cadastro_material";
            this.button_cadastro_material.Size = new System.Drawing.Size(180, 32);
            this.button_cadastro_material.TabIndex = 4;
            this.button_cadastro_material.Text = "Cadastro Material";
            this.button_cadastro_material.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cadastro_material.UseVisualStyleBackColor = true;
            this.button_cadastro_material.Click += new System.EventHandler(this.button_cadastro_material_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(3, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 32);
            this.panel1.TabIndex = 3;
            // 
            // button_apontamento
            // 
            this.button_apontamento.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button_apontamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button_apontamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_apontamento.ForeColor = System.Drawing.Color.White;
            this.button_apontamento.Location = new System.Drawing.Point(14, 149);
            this.button_apontamento.Name = "button_apontamento";
            this.button_apontamento.Size = new System.Drawing.Size(180, 32);
            this.button_apontamento.TabIndex = 2;
            this.button_apontamento.Text = "Apontamento";
            this.button_apontamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_apontamento.UseVisualStyleBackColor = true;
            this.button_apontamento.Click += new System.EventHandler(this.button_apontamento_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel_central
            // 
            this.panel_central.AutoSize = true;
            this.panel_central.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_central.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_central.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_central.Location = new System.Drawing.Point(200, 35);
            this.panel_central.Name = "panel_central";
            this.panel_central.Size = new System.Drawing.Size(1169, 689);
            this.panel_central.TabIndex = 5;
            // 
            // db_aplicativo_kpiDataSet
            // 
            this.db_aplicativo_kpiDataSet.DataSetName = "db_aplicativo_kpiDataSet";
            this.db_aplicativo_kpiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // db_configTableAdapter1
            // 
            this.db_configTableAdapter1.ClearBeforeFill = true;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Location = new System.Drawing.Point(3, 377);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(5, 32);
            this.panel8.TabIndex = 18;
            // 
            // button_cad_clientes
            // 
            this.button_cad_clientes.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button_cad_clientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button_cad_clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cad_clientes.ForeColor = System.Drawing.Color.White;
            this.button_cad_clientes.Location = new System.Drawing.Point(14, 377);
            this.button_cad_clientes.Name = "button_cad_clientes";
            this.button_cad_clientes.Size = new System.Drawing.Size(180, 32);
            this.button_cad_clientes.TabIndex = 17;
            this.button_cad_clientes.Text = "Cadastro Clientes";
            this.button_cad_clientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cad_clientes.UseVisualStyleBackColor = true;
            this.button_cad_clientes.Click += new System.EventHandler(this.button_cad_clientes_Click);
            // 
            // Form_tela_inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1369, 724);
            this.Controls.Add(this.panel_central);
            this.Controls.Add(this.panel_menu_vertical);
            this.Controls.Add(this.panel_titulo_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(972, 646);
            this.Name = "Form_tela_inicial";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.panel_titulo_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.botao_restor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botao_mini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botao_maxm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botao_fechar)).EndInit();
            this.panel_menu_vertical.ResumeLayout(false);
            this.panel_menu_vertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_aplicativo_kpiDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_titulo_menu;
        private System.Windows.Forms.PictureBox botao_mini;
        private System.Windows.Forms.PictureBox botao_maxm;
        private System.Windows.Forms.PictureBox botao_fechar;
        private System.Windows.Forms.Panel panel_menu_vertical;
        private System.Windows.Forms.Panel panel_central;
        private System.Windows.Forms.PictureBox botao_restor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_apontamento;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button_abrir_op;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_estrutura;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_cadastro_material;
        private db_aplicativo_kpiDataSet db_aplicativo_kpiDataSet;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button_cadastro_defeitos;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button_config;
        private db_aplicativo_kpiDataSetTableAdapters.db_configTableAdapter db_configTableAdapter1;
        private System.Windows.Forms.Label label_inicio_versao_prog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button_cad_grupo_estoque;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button_cad_clientes;
    }
}

