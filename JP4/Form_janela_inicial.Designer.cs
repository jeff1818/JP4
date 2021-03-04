
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_apontamento = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_central = new System.Windows.Forms.Panel();
            this.panel_titulo_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botao_restor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botao_mini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botao_maxm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botao_fechar)).BeginInit();
            this.panel_menu_vertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel_titulo_menu.Size = new System.Drawing.Size(1300, 35);
            this.panel_titulo_menu.TabIndex = 3;
            this.panel_titulo_menu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_titulo_menu_MouseDown);
            // 
            // botao_restor
            // 
            this.botao_restor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botao_restor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botao_restor.Image = ((System.Drawing.Image)(resources.GetObject("botao_restor.Image")));
            this.botao_restor.Location = new System.Drawing.Point(1232, 4);
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
            this.botao_mini.Location = new System.Drawing.Point(1201, 4);
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
            this.botao_maxm.Location = new System.Drawing.Point(1232, 4);
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
            this.botao_fechar.Location = new System.Drawing.Point(1263, 4);
            this.botao_fechar.Name = "botao_fechar";
            this.botao_fechar.Size = new System.Drawing.Size(25, 25);
            this.botao_fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.botao_fechar.TabIndex = 0;
            this.botao_fechar.TabStop = false;
            this.botao_fechar.Click += new System.EventHandler(this.botao_fechar_Click);
            // 
            // panel_menu_vertical
            // 
            this.panel_menu_vertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(46)))));
            this.panel_menu_vertical.Controls.Add(this.panel4);
            this.panel_menu_vertical.Controls.Add(this.button3);
            this.panel_menu_vertical.Controls.Add(this.panel3);
            this.panel_menu_vertical.Controls.Add(this.button2);
            this.panel_menu_vertical.Controls.Add(this.panel2);
            this.panel_menu_vertical.Controls.Add(this.button1);
            this.panel_menu_vertical.Controls.Add(this.panel1);
            this.panel_menu_vertical.Controls.Add(this.button_apontamento);
            this.panel_menu_vertical.Controls.Add(this.pictureBox1);
            this.panel_menu_vertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu_vertical.Location = new System.Drawing.Point(0, 35);
            this.panel_menu_vertical.Name = "panel_menu_vertical";
            this.panel_menu_vertical.Size = new System.Drawing.Size(200, 615);
            this.panel_menu_vertical.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel4.Location = new System.Drawing.Point(1, 225);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 32);
            this.panel4.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(12, 225);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 32);
            this.button3.TabIndex = 8;
            this.button3.Text = "Apontamento";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel3.Location = new System.Drawing.Point(1, 187);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 32);
            this.panel3.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 32);
            this.button2.TabIndex = 6;
            this.button2.Text = "Apontamento";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(1, 149);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 32);
            this.panel2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cadastro Material";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(3, 111);
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
            this.button_apontamento.Location = new System.Drawing.Point(14, 111);
            this.button_apontamento.Name = "button_apontamento";
            this.button_apontamento.Size = new System.Drawing.Size(180, 32);
            this.button_apontamento.TabIndex = 2;
            this.button_apontamento.Text = "Apontamento";
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
            this.panel_central.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_central.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panel_central.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_central.Location = new System.Drawing.Point(200, 35);
            this.panel_central.Name = "panel_central";
            this.panel_central.Size = new System.Drawing.Size(1100, 615);
            this.panel_central.TabIndex = 5;
            // 
            // Form_tela_inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1300, 650);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}

