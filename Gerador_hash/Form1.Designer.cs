namespace Gerador_hash
{
    partial class Form_gerador_md5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_gerador_md5));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combo_nome_pc = new System.Windows.Forms.ComboBox();
            this.button_gerar_md5 = new System.Windows.Forms.Button();
            this.textBox_md05 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_liberar_pc = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.combo_cad_liberar_pc = new System.Windows.Forms.ComboBox();
            this.textBox_cad_hash_produto = new System.Windows.Forms.TextBox();
            this.textBox_cad_nome_pc = new System.Windows.Forms.TextBox();
            this.textBox_cad_nome_cliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tab_area_relatorio_computadores = new System.Windows.Forms.TabControl();
            this.tab_cadastro = new System.Windows.Forms.TabPage();
            this.tab_lista = new System.Windows.Forms.TabPage();
            this.grid_lista_pc_conectado = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_atualizar_tabela = new System.Windows.Forms.Button();
            this.tabPage_pc_liberado = new System.Windows.Forms.TabPage();
            this.dataGrid_computadores_liberados = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_atualizar_pc_liberados = new System.Windows.Forms.Button();
            this.dataSet1 = new Gerador_hash.DataSet1();
            this.button_atualizar = new System.Windows.Forms.Button();
            this.button_deletar = new System.Windows.Forms.Button();
            this.label_id_computadores = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tab_area_relatorio_computadores.SuspendLayout();
            this.tab_cadastro.SuspendLayout();
            this.tab_lista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_lista_pc_conectado)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabPage_pc_liberado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_computadores_liberados)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.combo_nome_pc);
            this.groupBox1.Controls.Add(this.button_gerar_md5);
            this.groupBox1.Controls.Add(this.textBox_md05);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MD05";
            // 
            // combo_nome_pc
            // 
            this.combo_nome_pc.FormattingEnabled = true;
            this.combo_nome_pc.Location = new System.Drawing.Point(209, 52);
            this.combo_nome_pc.Name = "combo_nome_pc";
            this.combo_nome_pc.Size = new System.Drawing.Size(396, 21);
            this.combo_nome_pc.TabIndex = 6;
            // 
            // button_gerar_md5
            // 
            this.button_gerar_md5.Location = new System.Drawing.Point(209, 105);
            this.button_gerar_md5.Name = "button_gerar_md5";
            this.button_gerar_md5.Size = new System.Drawing.Size(143, 23);
            this.button_gerar_md5.TabIndex = 5;
            this.button_gerar_md5.Text = "Gerar MD5";
            this.button_gerar_md5.UseVisualStyleBackColor = true;
            this.button_gerar_md5.Click += new System.EventHandler(this.button_gerar_md5_Click);
            // 
            // textBox_md05
            // 
            this.textBox_md05.Location = new System.Drawing.Point(209, 79);
            this.textBox_md05.Name = "textBox_md05";
            this.textBox_md05.Size = new System.Drawing.Size(396, 20);
            this.textBox_md05.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(289, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "MD5 Hash Generator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "MD 05";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome PC:";
            // 
            // button_liberar_pc
            // 
            this.button_liberar_pc.Location = new System.Drawing.Point(209, 181);
            this.button_liberar_pc.Name = "button_liberar_pc";
            this.button_liberar_pc.Size = new System.Drawing.Size(112, 23);
            this.button_liberar_pc.TabIndex = 6;
            this.button_liberar_pc.Text = "Liberar PC";
            this.button_liberar_pc.UseVisualStyleBackColor = true;
            this.button_liberar_pc.Click += new System.EventHandler(this.button_liberar_pc_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_id_computadores);
            this.groupBox2.Controls.Add(this.button_deletar);
            this.groupBox2.Controls.Add(this.button_atualizar);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.combo_cad_liberar_pc);
            this.groupBox2.Controls.Add(this.textBox_cad_hash_produto);
            this.groupBox2.Controls.Add(this.textBox_cad_nome_pc);
            this.groupBox2.Controls.Add(this.textBox_cad_nome_cliente);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button_liberar_pc);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 257);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Area Cadastro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(228, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(336, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Cadastro de novos computadores";
            // 
            // combo_cad_liberar_pc
            // 
            this.combo_cad_liberar_pc.FormattingEnabled = true;
            this.combo_cad_liberar_pc.Items.AddRange(new object[] {
            "S",
            "N"});
            this.combo_cad_liberar_pc.Location = new System.Drawing.Point(209, 143);
            this.combo_cad_liberar_pc.Name = "combo_cad_liberar_pc";
            this.combo_cad_liberar_pc.Size = new System.Drawing.Size(61, 21);
            this.combo_cad_liberar_pc.TabIndex = 13;
            // 
            // textBox_cad_hash_produto
            // 
            this.textBox_cad_hash_produto.Location = new System.Drawing.Point(209, 117);
            this.textBox_cad_hash_produto.Name = "textBox_cad_hash_produto";
            this.textBox_cad_hash_produto.Size = new System.Drawing.Size(396, 20);
            this.textBox_cad_hash_produto.TabIndex = 12;
            // 
            // textBox_cad_nome_pc
            // 
            this.textBox_cad_nome_pc.Location = new System.Drawing.Point(209, 91);
            this.textBox_cad_nome_pc.Name = "textBox_cad_nome_pc";
            this.textBox_cad_nome_pc.Size = new System.Drawing.Size(396, 20);
            this.textBox_cad_nome_pc.TabIndex = 11;
            // 
            // textBox_cad_nome_cliente
            // 
            this.textBox_cad_nome_cliente.Location = new System.Drawing.Point(209, 65);
            this.textBox_cad_nome_cliente.Name = "textBox_cad_nome_cliente";
            this.textBox_cad_nome_cliente.Size = new System.Drawing.Size(396, 20);
            this.textBox_cad_nome_cliente.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(161, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Liberar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(134, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Hash Produto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nome PC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nome Cliente:";
            // 
            // tab_area_relatorio_computadores
            // 
            this.tab_area_relatorio_computadores.Controls.Add(this.tab_cadastro);
            this.tab_area_relatorio_computadores.Controls.Add(this.tab_lista);
            this.tab_area_relatorio_computadores.Controls.Add(this.tabPage_pc_liberado);
            this.tab_area_relatorio_computadores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_area_relatorio_computadores.Location = new System.Drawing.Point(0, 0);
            this.tab_area_relatorio_computadores.Name = "tab_area_relatorio_computadores";
            this.tab_area_relatorio_computadores.SelectedIndex = 0;
            this.tab_area_relatorio_computadores.Size = new System.Drawing.Size(814, 434);
            this.tab_area_relatorio_computadores.TabIndex = 2;
            // 
            // tab_cadastro
            // 
            this.tab_cadastro.Controls.Add(this.groupBox2);
            this.tab_cadastro.Controls.Add(this.groupBox1);
            this.tab_cadastro.Location = new System.Drawing.Point(4, 22);
            this.tab_cadastro.Name = "tab_cadastro";
            this.tab_cadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tab_cadastro.Size = new System.Drawing.Size(806, 408);
            this.tab_cadastro.TabIndex = 0;
            this.tab_cadastro.Text = "Area de Cadastro";
            this.tab_cadastro.UseVisualStyleBackColor = true;
            // 
            // tab_lista
            // 
            this.tab_lista.Controls.Add(this.grid_lista_pc_conectado);
            this.tab_lista.Controls.Add(this.groupBox3);
            this.tab_lista.Location = new System.Drawing.Point(4, 22);
            this.tab_lista.Name = "tab_lista";
            this.tab_lista.Padding = new System.Windows.Forms.Padding(3);
            this.tab_lista.Size = new System.Drawing.Size(806, 408);
            this.tab_lista.TabIndex = 1;
            this.tab_lista.Text = "Relatorio";
            this.tab_lista.UseVisualStyleBackColor = true;
            // 
            // grid_lista_pc_conectado
            // 
            this.grid_lista_pc_conectado.AllowUserToAddRows = false;
            this.grid_lista_pc_conectado.AllowUserToDeleteRows = false;
            this.grid_lista_pc_conectado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_lista_pc_conectado.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grid_lista_pc_conectado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_lista_pc_conectado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_lista_pc_conectado.Location = new System.Drawing.Point(3, 60);
            this.grid_lista_pc_conectado.Name = "grid_lista_pc_conectado";
            this.grid_lista_pc_conectado.ReadOnly = true;
            this.grid_lista_pc_conectado.Size = new System.Drawing.Size(800, 345);
            this.grid_lista_pc_conectado.TabIndex = 20;
            this.grid_lista_pc_conectado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_lista_pc_conectado_CellDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_atualizar_tabela);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(800, 57);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informação basica";
            // 
            // button_atualizar_tabela
            // 
            this.button_atualizar_tabela.Location = new System.Drawing.Point(6, 19);
            this.button_atualizar_tabela.Name = "button_atualizar_tabela";
            this.button_atualizar_tabela.Size = new System.Drawing.Size(168, 23);
            this.button_atualizar_tabela.TabIndex = 0;
            this.button_atualizar_tabela.Text = "Atualizar";
            this.button_atualizar_tabela.UseVisualStyleBackColor = true;
            this.button_atualizar_tabela.Click += new System.EventHandler(this.button_atualizar_tabela_Click);
            // 
            // tabPage_pc_liberado
            // 
            this.tabPage_pc_liberado.Controls.Add(this.dataGrid_computadores_liberados);
            this.tabPage_pc_liberado.Controls.Add(this.groupBox4);
            this.tabPage_pc_liberado.Location = new System.Drawing.Point(4, 22);
            this.tabPage_pc_liberado.Name = "tabPage_pc_liberado";
            this.tabPage_pc_liberado.Size = new System.Drawing.Size(806, 408);
            this.tabPage_pc_liberado.TabIndex = 2;
            this.tabPage_pc_liberado.Text = "Computadores Liberados";
            this.tabPage_pc_liberado.UseVisualStyleBackColor = true;
            // 
            // dataGrid_computadores_liberados
            // 
            this.dataGrid_computadores_liberados.AllowUserToAddRows = false;
            this.dataGrid_computadores_liberados.AllowUserToDeleteRows = false;
            this.dataGrid_computadores_liberados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_computadores_liberados.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid_computadores_liberados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_computadores_liberados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid_computadores_liberados.Location = new System.Drawing.Point(0, 57);
            this.dataGrid_computadores_liberados.Name = "dataGrid_computadores_liberados";
            this.dataGrid_computadores_liberados.ReadOnly = true;
            this.dataGrid_computadores_liberados.Size = new System.Drawing.Size(806, 351);
            this.dataGrid_computadores_liberados.TabIndex = 22;
            this.dataGrid_computadores_liberados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_computadores_liberados_CellDoubleClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_atualizar_pc_liberados);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(806, 57);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Informação basica";
            // 
            // button_atualizar_pc_liberados
            // 
            this.button_atualizar_pc_liberados.Location = new System.Drawing.Point(6, 19);
            this.button_atualizar_pc_liberados.Name = "button_atualizar_pc_liberados";
            this.button_atualizar_pc_liberados.Size = new System.Drawing.Size(168, 23);
            this.button_atualizar_pc_liberados.TabIndex = 0;
            this.button_atualizar_pc_liberados.Text = "Atualizar";
            this.button_atualizar_pc_liberados.UseVisualStyleBackColor = true;
            this.button_atualizar_pc_liberados.Click += new System.EventHandler(this.button_atualizar_pc_liberados_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button_atualizar
            // 
            this.button_atualizar.Location = new System.Drawing.Point(355, 181);
            this.button_atualizar.Name = "button_atualizar";
            this.button_atualizar.Size = new System.Drawing.Size(112, 23);
            this.button_atualizar.TabIndex = 15;
            this.button_atualizar.Text = "Atualizar Acesso";
            this.button_atualizar.UseVisualStyleBackColor = true;
            this.button_atualizar.Click += new System.EventHandler(this.button_atualizar_Click);
            // 
            // button_deletar
            // 
            this.button_deletar.Location = new System.Drawing.Point(493, 181);
            this.button_deletar.Name = "button_deletar";
            this.button_deletar.Size = new System.Drawing.Size(112, 23);
            this.button_deletar.TabIndex = 16;
            this.button_deletar.Text = "Deletar PC";
            this.button_deletar.UseVisualStyleBackColor = true;
            this.button_deletar.Click += new System.EventHandler(this.button_deletar_Click);
            // 
            // label_id_computadores
            // 
            this.label_id_computadores.AutoSize = true;
            this.label_id_computadores.Location = new System.Drawing.Point(566, 146);
            this.label_id_computadores.Name = "label_id_computadores";
            this.label_id_computadores.Size = new System.Drawing.Size(15, 13);
            this.label_id_computadores.TabIndex = 17;
            this.label_id_computadores.Text = "id";
            // 
            // Form_gerador_md5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 434);
            this.Controls.Add(this.tab_area_relatorio_computadores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_gerador_md5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MD5 Hash Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tab_area_relatorio_computadores.ResumeLayout(false);
            this.tab_cadastro.ResumeLayout(false);
            this.tab_lista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_lista_pc_conectado)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.tabPage_pc_liberado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_computadores_liberados)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_md05;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_gerar_md5;
        private System.Windows.Forms.Button button_liberar_pc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_cad_nome_cliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combo_cad_liberar_pc;
        private System.Windows.Forms.TextBox textBox_cad_hash_produto;
        private System.Windows.Forms.TextBox textBox_cad_nome_pc;
        private System.Windows.Forms.ComboBox combo_nome_pc;
        private DataSet1 dataSet1;
        private System.Windows.Forms.TabControl tab_area_relatorio_computadores;
        private System.Windows.Forms.TabPage tab_cadastro;
        private System.Windows.Forms.TabPage tab_lista;
        private System.Windows.Forms.DataGridView grid_lista_pc_conectado;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_atualizar_tabela;
        private System.Windows.Forms.TabPage tabPage_pc_liberado;
        private System.Windows.Forms.DataGridView dataGrid_computadores_liberados;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_atualizar_pc_liberados;
        private System.Windows.Forms.Button button_deletar;
        private System.Windows.Forms.Button button_atualizar;
        private System.Windows.Forms.Label label_id_computadores;
    }
}

