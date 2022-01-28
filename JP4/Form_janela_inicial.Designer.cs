
namespace JP4
{
    partial class WINSTART
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WINSTART));
            this.panel_titulo_menu = new System.Windows.Forms.Panel();
            this.label_hora_digital = new System.Windows.Forms.Label();
            this.label_data_inicial = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_nome_usuario = new System.Windows.Forms.Label();
            this.botao_restor = new System.Windows.Forms.PictureBox();
            this.botao_mini = new System.Windows.Forms.PictureBox();
            this.botao_maxm = new System.Windows.Forms.PictureBox();
            this.botao_fechar = new System.Windows.Forms.PictureBox();
            this.panel_menu_vertical = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label_inicial_ultimo_backup = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel_sub_menu_cadastro = new System.Windows.Forms.Panel();
            this.button_cad_mistura = new System.Windows.Forms.Button();
            this.button_cadastro_user = new System.Windows.Forms.Button();
            this.button_cad_paradas = new System.Windows.Forms.Button();
            this.button_cad_turno = new System.Windows.Forms.Button();
            this.button_tipo_material = new System.Windows.Forms.Button();
            this.button_cad_operador = new System.Windows.Forms.Button();
            this.button_cad_operacao = new System.Windows.Forms.Button();
            this.button_cad_origem_apara = new System.Windows.Forms.Button();
            this.button_cadastro_defeitos = new System.Windows.Forms.Button();
            this.button_cad_grupo_estoque = new System.Windows.Forms.Button();
            this.button_cad_equipamento = new System.Windows.Forms.Button();
            this.button_cad_clientes = new System.Windows.Forms.Button();
            this.button_cad_local_aplica = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_cad_local_estoque = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button_report = new System.Windows.Forms.Button();
            this.label_status = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button_mov_estoque = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.button_area_cadastro = new System.Windows.Forms.Button();
            this.label_inicio_versao_prog = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button_config = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button_abrir_op = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_estrutura = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_cadastro_material = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_apontamento = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_estoque_atual = new System.Windows.Forms.Button();
            this.button_exportar_dados = new System.Windows.Forms.Button();
            this.button_invent_geral = new System.Windows.Forms.Button();
            this.panel_central = new System.Windows.Forms.Panel();
            this.db_aplicativo_kpiDataSet = new JP4.db_aplicativo_kpiDataSet();
            this.db_configTableAdapter1 = new JP4.db_aplicativo_kpiDataSetTableAdapters.db_configTableAdapter();
            this.timer_digital = new System.Windows.Forms.Timer(this.components);
            this.progressBar_inicial = new System.Windows.Forms.ProgressBar();
            this.panel_titulo_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botao_restor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botao_mini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botao_maxm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botao_fechar)).BeginInit();
            this.panel_menu_vertical.SuspendLayout();
            this.panel_sub_menu_cadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_aplicativo_kpiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_titulo_menu
            // 
            this.panel_titulo_menu.BackColor = System.Drawing.Color.Black;
            this.panel_titulo_menu.Controls.Add(this.label_hora_digital);
            this.panel_titulo_menu.Controls.Add(this.label_data_inicial);
            this.panel_titulo_menu.Controls.Add(this.label2);
            this.panel_titulo_menu.Controls.Add(this.label_nome_usuario);
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
            // label_hora_digital
            // 
            this.label_hora_digital.AutoSize = true;
            this.label_hora_digital.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_hora_digital.Location = new System.Drawing.Point(850, 9);
            this.label_hora_digital.Name = "label_hora_digital";
            this.label_hora_digital.Size = new System.Drawing.Size(31, 13);
            this.label_hora_digital.TabIndex = 6;
            this.label_hora_digital.Text = "hora:";
            // 
            // label_data_inicial
            // 
            this.label_data_inicial.AutoSize = true;
            this.label_data_inicial.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_data_inicial.Location = new System.Drawing.Point(661, 11);
            this.label_data_inicial.Name = "label_data_inicial";
            this.label_data_inicial.Size = new System.Drawing.Size(33, 13);
            this.label_data_inicial.TabIndex = 5;
            this.label_data_inicial.Text = "Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuário:";
            // 
            // label_nome_usuario
            // 
            this.label_nome_usuario.AutoSize = true;
            this.label_nome_usuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_nome_usuario.Location = new System.Drawing.Point(56, 9);
            this.label_nome_usuario.Name = "label_nome_usuario";
            this.label_nome_usuario.Size = new System.Drawing.Size(10, 13);
            this.label_nome_usuario.TabIndex = 3;
            this.label_nome_usuario.Text = ".";
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
            this.panel_menu_vertical.Controls.Add(this.progressBar_inicial);
            this.panel_menu_vertical.Controls.Add(this.panel10);
            this.panel_menu_vertical.Controls.Add(this.panel9);
            this.panel_menu_vertical.Controls.Add(this.label_inicial_ultimo_backup);
            this.panel_menu_vertical.Controls.Add(this.panel8);
            this.panel_menu_vertical.Controls.Add(this.panel_sub_menu_cadastro);
            this.panel_menu_vertical.Controls.Add(this.panel7);
            this.panel_menu_vertical.Controls.Add(this.button_report);
            this.panel_menu_vertical.Controls.Add(this.label_status);
            this.panel_menu_vertical.Controls.Add(this.panel5);
            this.panel_menu_vertical.Controls.Add(this.button_mov_estoque);
            this.panel_menu_vertical.Controls.Add(this.panel14);
            this.panel_menu_vertical.Controls.Add(this.button_area_cadastro);
            this.panel_menu_vertical.Controls.Add(this.label_inicio_versao_prog);
            this.panel_menu_vertical.Controls.Add(this.label1);
            this.panel_menu_vertical.Controls.Add(this.panel6);
            this.panel_menu_vertical.Controls.Add(this.button_config);
            this.panel_menu_vertical.Controls.Add(this.panel4);
            this.panel_menu_vertical.Controls.Add(this.button_abrir_op);
            this.panel_menu_vertical.Controls.Add(this.panel3);
            this.panel_menu_vertical.Controls.Add(this.button_estrutura);
            this.panel_menu_vertical.Controls.Add(this.panel2);
            this.panel_menu_vertical.Controls.Add(this.button_cadastro_material);
            this.panel_menu_vertical.Controls.Add(this.panel1);
            this.panel_menu_vertical.Controls.Add(this.button_apontamento);
            this.panel_menu_vertical.Controls.Add(this.pictureBox1);
            this.panel_menu_vertical.Controls.Add(this.button_estoque_atual);
            this.panel_menu_vertical.Controls.Add(this.button_exportar_dados);
            this.panel_menu_vertical.Controls.Add(this.button_invent_geral);
            this.panel_menu_vertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu_vertical.Location = new System.Drawing.Point(0, 35);
            this.panel_menu_vertical.Name = "panel_menu_vertical";
            this.panel_menu_vertical.Size = new System.Drawing.Size(200, 719);
            this.panel_menu_vertical.TabIndex = 4;
            this.panel_menu_vertical.Click += new System.EventHandler(this.panel_menu_vertical_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Black;
            this.panel10.Location = new System.Drawing.Point(3, 301);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(5, 32);
            this.panel10.TabIndex = 39;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Black;
            this.panel9.Location = new System.Drawing.Point(5, 491);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(5, 32);
            this.panel9.TabIndex = 37;
            // 
            // label_inicial_ultimo_backup
            // 
            this.label_inicial_ultimo_backup.AutoSize = true;
            this.label_inicial_ultimo_backup.Location = new System.Drawing.Point(99, 639);
            this.label_inicial_ultimo_backup.Name = "label_inicial_ultimo_backup";
            this.label_inicial_ultimo_backup.Size = new System.Drawing.Size(16, 13);
            this.label_inicial_ultimo_backup.TabIndex = 1;
            this.label_inicial_ultimo_backup.Text = "...";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Location = new System.Drawing.Point(3, 225);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(5, 32);
            this.panel8.TabIndex = 35;
            // 
            // panel_sub_menu_cadastro
            // 
            this.panel_sub_menu_cadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(205)))));
            this.panel_sub_menu_cadastro.Controls.Add(this.button_cad_mistura);
            this.panel_sub_menu_cadastro.Controls.Add(this.button_cadastro_user);
            this.panel_sub_menu_cadastro.Controls.Add(this.button_cad_paradas);
            this.panel_sub_menu_cadastro.Controls.Add(this.button_cad_turno);
            this.panel_sub_menu_cadastro.Controls.Add(this.button_tipo_material);
            this.panel_sub_menu_cadastro.Controls.Add(this.button_cad_operador);
            this.panel_sub_menu_cadastro.Controls.Add(this.button_cad_operacao);
            this.panel_sub_menu_cadastro.Controls.Add(this.button_cad_origem_apara);
            this.panel_sub_menu_cadastro.Controls.Add(this.button_cadastro_defeitos);
            this.panel_sub_menu_cadastro.Controls.Add(this.button_cad_grupo_estoque);
            this.panel_sub_menu_cadastro.Controls.Add(this.button_cad_equipamento);
            this.panel_sub_menu_cadastro.Controls.Add(this.button_cad_clientes);
            this.panel_sub_menu_cadastro.Controls.Add(this.button_cad_local_aplica);
            this.panel_sub_menu_cadastro.Controls.Add(this.button1);
            this.panel_sub_menu_cadastro.Controls.Add(this.button_cad_local_estoque);
            this.panel_sub_menu_cadastro.Location = new System.Drawing.Point(59, 3);
            this.panel_sub_menu_cadastro.Name = "panel_sub_menu_cadastro";
            this.panel_sub_menu_cadastro.Size = new System.Drawing.Size(146, 572);
            this.panel_sub_menu_cadastro.TabIndex = 27;
            this.panel_sub_menu_cadastro.Visible = false;
            // 
            // button_cad_mistura
            // 
            this.button_cad_mistura.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_cad_mistura.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button_cad_mistura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button_cad_mistura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cad_mistura.ForeColor = System.Drawing.Color.White;
            this.button_cad_mistura.Location = new System.Drawing.Point(3, 535);
            this.button_cad_mistura.Name = "button_cad_mistura";
            this.button_cad_mistura.Size = new System.Drawing.Size(139, 32);
            this.button_cad_mistura.TabIndex = 33;
            this.button_cad_mistura.Text = "Cadastro de Mistura";
            this.button_cad_mistura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cad_mistura.UseVisualStyleBackColor = false;
            this.button_cad_mistura.Click += new System.EventHandler(this.button_cad_mistura_Click);
            // 
            // button_cadastro_user
            // 
            this.button_cadastro_user.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_cadastro_user.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button_cadastro_user.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button_cadastro_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cadastro_user.ForeColor = System.Drawing.Color.White;
            this.button_cadastro_user.Location = new System.Drawing.Point(3, 497);
            this.button_cadastro_user.Name = "button_cadastro_user";
            this.button_cadastro_user.Size = new System.Drawing.Size(139, 32);
            this.button_cadastro_user.TabIndex = 32;
            this.button_cadastro_user.Text = "Cadastro Usuarios";
            this.button_cadastro_user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cadastro_user.UseVisualStyleBackColor = false;
            this.button_cadastro_user.Click += new System.EventHandler(this.button_cadastro_user_Click);
            // 
            // button_cad_paradas
            // 
            this.button_cad_paradas.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_cad_paradas.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button_cad_paradas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button_cad_paradas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cad_paradas.ForeColor = System.Drawing.Color.White;
            this.button_cad_paradas.Location = new System.Drawing.Point(3, 459);
            this.button_cad_paradas.Name = "button_cad_paradas";
            this.button_cad_paradas.Size = new System.Drawing.Size(139, 32);
            this.button_cad_paradas.TabIndex = 31;
            this.button_cad_paradas.Text = "Cadastro Paradas";
            this.button_cad_paradas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cad_paradas.UseVisualStyleBackColor = false;
            this.button_cad_paradas.Click += new System.EventHandler(this.button_cad_paradas_Click);
            // 
            // button_cad_turno
            // 
            this.button_cad_turno.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_cad_turno.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button_cad_turno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button_cad_turno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cad_turno.ForeColor = System.Drawing.Color.White;
            this.button_cad_turno.Location = new System.Drawing.Point(3, 421);
            this.button_cad_turno.Name = "button_cad_turno";
            this.button_cad_turno.Size = new System.Drawing.Size(139, 32);
            this.button_cad_turno.TabIndex = 30;
            this.button_cad_turno.Text = "Cadastro Turnos";
            this.button_cad_turno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cad_turno.UseVisualStyleBackColor = false;
            this.button_cad_turno.Click += new System.EventHandler(this.button_cad_turno_Click);
            // 
            // button_tipo_material
            // 
            this.button_tipo_material.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_tipo_material.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button_tipo_material.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button_tipo_material.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_tipo_material.ForeColor = System.Drawing.Color.White;
            this.button_tipo_material.Location = new System.Drawing.Point(4, 383);
            this.button_tipo_material.Name = "button_tipo_material";
            this.button_tipo_material.Size = new System.Drawing.Size(139, 32);
            this.button_tipo_material.TabIndex = 29;
            this.button_tipo_material.Text = "Cadastro Tipo Material";
            this.button_tipo_material.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_tipo_material.UseVisualStyleBackColor = false;
            this.button_tipo_material.Click += new System.EventHandler(this.button_tipo_material_Click);
            // 
            // button_cad_operador
            // 
            this.button_cad_operador.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_cad_operador.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button_cad_operador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button_cad_operador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cad_operador.ForeColor = System.Drawing.Color.White;
            this.button_cad_operador.Location = new System.Drawing.Point(3, 345);
            this.button_cad_operador.Name = "button_cad_operador";
            this.button_cad_operador.Size = new System.Drawing.Size(139, 32);
            this.button_cad_operador.TabIndex = 28;
            this.button_cad_operador.Text = "Cadastro Operador";
            this.button_cad_operador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cad_operador.UseVisualStyleBackColor = false;
            this.button_cad_operador.Click += new System.EventHandler(this.button_cad_operador_Click);
            // 
            // button_cad_operacao
            // 
            this.button_cad_operacao.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_cad_operacao.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button_cad_operacao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button_cad_operacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cad_operacao.ForeColor = System.Drawing.Color.White;
            this.button_cad_operacao.Location = new System.Drawing.Point(3, 307);
            this.button_cad_operacao.Name = "button_cad_operacao";
            this.button_cad_operacao.Size = new System.Drawing.Size(139, 32);
            this.button_cad_operacao.TabIndex = 27;
            this.button_cad_operacao.Text = "Cadastro Operação";
            this.button_cad_operacao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cad_operacao.UseVisualStyleBackColor = false;
            this.button_cad_operacao.Click += new System.EventHandler(this.button_cad_operacao_Click);
            // 
            // button_cad_origem_apara
            // 
            this.button_cad_origem_apara.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_cad_origem_apara.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button_cad_origem_apara.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button_cad_origem_apara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cad_origem_apara.ForeColor = System.Drawing.Color.White;
            this.button_cad_origem_apara.Location = new System.Drawing.Point(3, 269);
            this.button_cad_origem_apara.Name = "button_cad_origem_apara";
            this.button_cad_origem_apara.Size = new System.Drawing.Size(139, 32);
            this.button_cad_origem_apara.TabIndex = 26;
            this.button_cad_origem_apara.Text = "Cadastro Origem Apara";
            this.button_cad_origem_apara.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cad_origem_apara.UseVisualStyleBackColor = false;
            this.button_cad_origem_apara.Click += new System.EventHandler(this.button_cad_origem_apara_Click);
            // 
            // button_cadastro_defeitos
            // 
            this.button_cadastro_defeitos.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_cadastro_defeitos.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button_cadastro_defeitos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button_cadastro_defeitos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cadastro_defeitos.ForeColor = System.Drawing.Color.White;
            this.button_cadastro_defeitos.Location = new System.Drawing.Point(3, 3);
            this.button_cadastro_defeitos.Name = "button_cadastro_defeitos";
            this.button_cadastro_defeitos.Size = new System.Drawing.Size(139, 32);
            this.button_cadastro_defeitos.TabIndex = 10;
            this.button_cadastro_defeitos.Text = "Cadastro Defeitos";
            this.button_cadastro_defeitos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cadastro_defeitos.UseVisualStyleBackColor = false;
            this.button_cadastro_defeitos.Click += new System.EventHandler(this.button_cadastro_defeitos_Click);
            // 
            // button_cad_grupo_estoque
            // 
            this.button_cad_grupo_estoque.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_cad_grupo_estoque.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button_cad_grupo_estoque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button_cad_grupo_estoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cad_grupo_estoque.ForeColor = System.Drawing.Color.White;
            this.button_cad_grupo_estoque.Location = new System.Drawing.Point(3, 41);
            this.button_cad_grupo_estoque.Name = "button_cad_grupo_estoque";
            this.button_cad_grupo_estoque.Size = new System.Drawing.Size(139, 32);
            this.button_cad_grupo_estoque.TabIndex = 15;
            this.button_cad_grupo_estoque.Text = "Cadastro Grupo Estoque";
            this.button_cad_grupo_estoque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cad_grupo_estoque.UseVisualStyleBackColor = false;
            this.button_cad_grupo_estoque.Click += new System.EventHandler(this.button_cad_grupo_estoque_Click);
            // 
            // button_cad_equipamento
            // 
            this.button_cad_equipamento.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_cad_equipamento.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button_cad_equipamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button_cad_equipamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cad_equipamento.ForeColor = System.Drawing.Color.White;
            this.button_cad_equipamento.Location = new System.Drawing.Point(3, 231);
            this.button_cad_equipamento.Name = "button_cad_equipamento";
            this.button_cad_equipamento.Size = new System.Drawing.Size(139, 32);
            this.button_cad_equipamento.TabIndex = 25;
            this.button_cad_equipamento.Text = "Cadastro Equipamento";
            this.button_cad_equipamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cad_equipamento.UseVisualStyleBackColor = false;
            this.button_cad_equipamento.Click += new System.EventHandler(this.button_cad_equipamento_Click);
            // 
            // button_cad_clientes
            // 
            this.button_cad_clientes.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_cad_clientes.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button_cad_clientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button_cad_clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cad_clientes.ForeColor = System.Drawing.Color.White;
            this.button_cad_clientes.Location = new System.Drawing.Point(3, 79);
            this.button_cad_clientes.Name = "button_cad_clientes";
            this.button_cad_clientes.Size = new System.Drawing.Size(139, 32);
            this.button_cad_clientes.TabIndex = 17;
            this.button_cad_clientes.Text = "Cadastro Clientes";
            this.button_cad_clientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cad_clientes.UseVisualStyleBackColor = false;
            this.button_cad_clientes.Click += new System.EventHandler(this.button_cad_clientes_Click);
            // 
            // button_cad_local_aplica
            // 
            this.button_cad_local_aplica.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_cad_local_aplica.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button_cad_local_aplica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button_cad_local_aplica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cad_local_aplica.ForeColor = System.Drawing.Color.White;
            this.button_cad_local_aplica.Location = new System.Drawing.Point(3, 117);
            this.button_cad_local_aplica.Name = "button_cad_local_aplica";
            this.button_cad_local_aplica.Size = new System.Drawing.Size(139, 32);
            this.button_cad_local_aplica.TabIndex = 19;
            this.button_cad_local_aplica.Text = "Cadastro Lcal Aplicação";
            this.button_cad_local_aplica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cad_local_aplica.UseVisualStyleBackColor = false;
            this.button_cad_local_aplica.Click += new System.EventHandler(this.button_cad_local_aplica_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 32);
            this.button1.TabIndex = 23;
            this.button1.Text = "Cadastro Empresa";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_cad_local_estoque
            // 
            this.button_cad_local_estoque.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_cad_local_estoque.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button_cad_local_estoque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button_cad_local_estoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cad_local_estoque.ForeColor = System.Drawing.Color.White;
            this.button_cad_local_estoque.Location = new System.Drawing.Point(3, 155);
            this.button_cad_local_estoque.Name = "button_cad_local_estoque";
            this.button_cad_local_estoque.Size = new System.Drawing.Size(139, 32);
            this.button_cad_local_estoque.TabIndex = 21;
            this.button_cad_local_estoque.Text = "Cadastro Lcal Estoque";
            this.button_cad_local_estoque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cad_local_estoque.UseVisualStyleBackColor = false;
            this.button_cad_local_estoque.Click += new System.EventHandler(this.button_cad_local_estoque_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(4, 453);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 32);
            this.panel7.TabIndex = 33;
            // 
            // button_report
            // 
            this.button_report.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button_report.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_report.ForeColor = System.Drawing.Color.White;
            this.button_report.Location = new System.Drawing.Point(15, 453);
            this.button_report.Name = "button_report";
            this.button_report.Size = new System.Drawing.Size(180, 32);
            this.button_report.TabIndex = 32;
            this.button_report.Text = "Report";
            this.button_report.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_report.UseVisualStyleBackColor = true;
            this.button_report.Click += new System.EventHandler(this.button_report_Click);
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(12, 639);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(16, 13);
            this.label_status.TabIndex = 0;
            this.label_status.Text = "...";
            this.label_status.Click += new System.EventHandler(this.label_status_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(3, 263);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 32);
            this.panel5.TabIndex = 30;
            // 
            // button_mov_estoque
            // 
            this.button_mov_estoque.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button_mov_estoque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button_mov_estoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_mov_estoque.ForeColor = System.Drawing.Color.White;
            this.button_mov_estoque.Location = new System.Drawing.Point(14, 263);
            this.button_mov_estoque.Name = "button_mov_estoque";
            this.button_mov_estoque.Size = new System.Drawing.Size(180, 32);
            this.button_mov_estoque.TabIndex = 29;
            this.button_mov_estoque.Text = "Movimenta Estoque";
            this.button_mov_estoque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_mov_estoque.UseVisualStyleBackColor = true;
            this.button_mov_estoque.Click += new System.EventHandler(this.button_mov_estoque_Click);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Black;
            this.panel14.Location = new System.Drawing.Point(3, 111);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(5, 32);
            this.panel14.TabIndex = 28;
            // 
            // button_area_cadastro
            // 
            this.button_area_cadastro.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button_area_cadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button_area_cadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_area_cadastro.ForeColor = System.Drawing.Color.White;
            this.button_area_cadastro.Location = new System.Drawing.Point(14, 111);
            this.button_area_cadastro.Name = "button_area_cadastro";
            this.button_area_cadastro.Size = new System.Drawing.Size(180, 32);
            this.button_area_cadastro.TabIndex = 27;
            this.button_area_cadastro.Text = "Area de Cadastro";
            this.button_area_cadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_area_cadastro.UseVisualStyleBackColor = true;
            this.button_area_cadastro.Click += new System.EventHandler(this.button_area_cadastro_Click);
            this.button_area_cadastro.MouseLeave += new System.EventHandler(this.button_area_cadastro_MouseLeave);
            this.button_area_cadastro.MouseHover += new System.EventHandler(this.button_area_cadastro_MouseHover);
            // 
            // label_inicio_versao_prog
            // 
            this.label_inicio_versao_prog.AutoSize = true;
            this.label_inicio_versao_prog.Location = new System.Drawing.Point(72, 667);
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
            this.panel6.Location = new System.Drawing.Point(4, 415);
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
            this.button_config.Location = new System.Drawing.Point(15, 415);
            this.button_config.Name = "button_config";
            this.button_config.Size = new System.Drawing.Size(180, 32);
            this.button_config.TabIndex = 12;
            this.button_config.Text = "Configuração";
            this.button_config.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_config.UseVisualStyleBackColor = true;
            this.button_config.Click += new System.EventHandler(this.button_config_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(3, 149);
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
            this.button_abrir_op.Location = new System.Drawing.Point(14, 149);
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
            this.panel3.Location = new System.Drawing.Point(4, 377);
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
            this.button_estrutura.Location = new System.Drawing.Point(15, 377);
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
            this.panel2.Location = new System.Drawing.Point(4, 339);
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
            this.button_cadastro_material.Location = new System.Drawing.Point(15, 339);
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
            this.panel1.Location = new System.Drawing.Point(3, 187);
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
            this.button_apontamento.Location = new System.Drawing.Point(14, 187);
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
            // button_estoque_atual
            // 
            this.button_estoque_atual.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button_estoque_atual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button_estoque_atual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_estoque_atual.ForeColor = System.Drawing.Color.White;
            this.button_estoque_atual.Location = new System.Drawing.Point(14, 225);
            this.button_estoque_atual.Name = "button_estoque_atual";
            this.button_estoque_atual.Size = new System.Drawing.Size(180, 32);
            this.button_estoque_atual.TabIndex = 34;
            this.button_estoque_atual.Text = "Relatorio Estoque";
            this.button_estoque_atual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_estoque_atual.UseVisualStyleBackColor = true;
            // 
            // button_exportar_dados
            // 
            this.button_exportar_dados.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button_exportar_dados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button_exportar_dados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exportar_dados.ForeColor = System.Drawing.Color.White;
            this.button_exportar_dados.Location = new System.Drawing.Point(16, 491);
            this.button_exportar_dados.Name = "button_exportar_dados";
            this.button_exportar_dados.Size = new System.Drawing.Size(180, 32);
            this.button_exportar_dados.TabIndex = 36;
            this.button_exportar_dados.Text = "Exportar Dados";
            this.button_exportar_dados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_exportar_dados.UseVisualStyleBackColor = true;
            this.button_exportar_dados.Click += new System.EventHandler(this.button_exportar_dados_Click);
            // 
            // button_invent_geral
            // 
            this.button_invent_geral.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button_invent_geral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button_invent_geral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_invent_geral.ForeColor = System.Drawing.Color.White;
            this.button_invent_geral.Location = new System.Drawing.Point(14, 301);
            this.button_invent_geral.Name = "button_invent_geral";
            this.button_invent_geral.Size = new System.Drawing.Size(180, 32);
            this.button_invent_geral.TabIndex = 38;
            this.button_invent_geral.Text = "Inventário Geral";
            this.button_invent_geral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_invent_geral.UseVisualStyleBackColor = true;
            this.button_invent_geral.Click += new System.EventHandler(this.button_invent_geral_Click);
            // 
            // panel_central
            // 
            this.panel_central.AutoSize = true;
            this.panel_central.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_central.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_central.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_central.Location = new System.Drawing.Point(200, 35);
            this.panel_central.Name = "panel_central";
            this.panel_central.Size = new System.Drawing.Size(1169, 719);
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
            // timer_digital
            // 
            this.timer_digital.Enabled = true;
            this.timer_digital.Tick += new System.EventHandler(this.timer_digital_Tick);
            // 
            // progressBar_inicial
            // 
            this.progressBar_inicial.BackColor = System.Drawing.SystemColors.Highlight;
            this.progressBar_inicial.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar_inicial.Location = new System.Drawing.Point(0, 706);
            this.progressBar_inicial.Name = "progressBar_inicial";
            this.progressBar_inicial.Size = new System.Drawing.Size(200, 13);
            this.progressBar_inicial.TabIndex = 0;
            // 
            // WINSTART
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1369, 754);
            this.Controls.Add(this.panel_central);
            this.Controls.Add(this.panel_menu_vertical);
            this.Controls.Add(this.panel_titulo_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(972, 646);
            this.Name = "WINSTART";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WINSTART_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WINSTART_FormClosed);
            this.panel_titulo_menu.ResumeLayout(false);
            this.panel_titulo_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botao_restor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botao_mini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botao_maxm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botao_fechar)).EndInit();
            this.panel_menu_vertical.ResumeLayout(false);
            this.panel_menu_vertical.PerformLayout();
            this.panel_sub_menu_cadastro.ResumeLayout(false);
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
        private System.Windows.Forms.Button button_cadastro_defeitos;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button_config;
        private db_aplicativo_kpiDataSetTableAdapters.db_configTableAdapter db_configTableAdapter1;
        private System.Windows.Forms.Label label_inicio_versao_prog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_cad_grupo_estoque;
        private System.Windows.Forms.Button button_cad_clientes;
        private System.Windows.Forms.Button button_cad_local_aplica;
        private System.Windows.Forms.Button button_cad_local_estoque;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_cad_equipamento;
        private System.Windows.Forms.Panel panel_sub_menu_cadastro;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button button_area_cadastro;
        private System.Windows.Forms.Button button_cad_origem_apara;
        private System.Windows.Forms.Button button_cad_operacao;
        private System.Windows.Forms.Button button_cad_operador;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button_mov_estoque;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Button button_tipo_material;
        private System.Windows.Forms.Button button_cad_turno;
        public System.Windows.Forms.Label label_nome_usuario;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_cad_paradas;
        private System.Windows.Forms.Button button_cadastro_user;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button_report;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button_estoque_atual;
        public System.Windows.Forms.Label label_hora_digital;
        public System.Windows.Forms.Label label_data_inicial;
        private System.Windows.Forms.Timer timer_digital;
        public System.Windows.Forms.Label label_inicial_ultimo_backup;
        private System.Windows.Forms.Button button_cad_mistura;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button_exportar_dados;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button button_invent_geral;
        public System.Windows.Forms.ProgressBar progressBar_inicial;
    }
}

