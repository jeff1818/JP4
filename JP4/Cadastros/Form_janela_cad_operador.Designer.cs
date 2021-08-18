
namespace JP4
{
    partial class Form_janela_cad_operador
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_limpar_controles = new System.Windows.Forms.Button();
            this.button_atualizar = new System.Windows.Forms.Button();
            this.button_filtrar = new System.Windows.Forms.Button();
            this.button_salvar = new System.Windows.Forms.Button();
            this.button_deletar = new System.Windows.Forms.Button();
            this.grid_cad_operador = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_descri_turno = new System.Windows.Forms.Label();
            this.text_funcao = new System.Windows.Forms.TextBox();
            this.combo_equipamento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_turno = new System.Windows.Forms.ComboBox();
            this.label_id_cad_operador = new System.Windows.Forms.Label();
            this.text_nome_operador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroTurnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroEquipamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_fechar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_cad_operador)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_fechar);
            this.groupBox2.Controls.Add(this.button_limpar_controles);
            this.groupBox2.Controls.Add(this.button_atualizar);
            this.groupBox2.Controls.Add(this.button_filtrar);
            this.groupBox2.Controls.Add(this.button_salvar);
            this.groupBox2.Controls.Add(this.button_deletar);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(142, 612);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu";
            // 
            // button_limpar_controles
            // 
            this.button_limpar_controles.Location = new System.Drawing.Point(12, 120);
            this.button_limpar_controles.Name = "button_limpar_controles";
            this.button_limpar_controles.Size = new System.Drawing.Size(114, 23);
            this.button_limpar_controles.TabIndex = 11;
            this.button_limpar_controles.Text = "Limpar Controles";
            this.button_limpar_controles.UseVisualStyleBackColor = true;
            this.button_limpar_controles.Click += new System.EventHandler(this.button_limpar_controles_Click);
            // 
            // button_atualizar
            // 
            this.button_atualizar.Location = new System.Drawing.Point(12, 62);
            this.button_atualizar.Name = "button_atualizar";
            this.button_atualizar.Size = new System.Drawing.Size(114, 23);
            this.button_atualizar.TabIndex = 10;
            this.button_atualizar.Text = "Atualizar";
            this.button_atualizar.UseVisualStyleBackColor = true;
            this.button_atualizar.Click += new System.EventHandler(this.button_atualizar_Click);
            // 
            // button_filtrar
            // 
            this.button_filtrar.Location = new System.Drawing.Point(12, 149);
            this.button_filtrar.Name = "button_filtrar";
            this.button_filtrar.Size = new System.Drawing.Size(114, 23);
            this.button_filtrar.TabIndex = 9;
            this.button_filtrar.Text = "Filtrar";
            this.button_filtrar.UseVisualStyleBackColor = true;
            // 
            // button_salvar
            // 
            this.button_salvar.Location = new System.Drawing.Point(12, 33);
            this.button_salvar.Name = "button_salvar";
            this.button_salvar.Size = new System.Drawing.Size(114, 23);
            this.button_salvar.TabIndex = 7;
            this.button_salvar.Text = "Salvar";
            this.button_salvar.UseVisualStyleBackColor = true;
            this.button_salvar.Click += new System.EventHandler(this.button_salvar_Click);
            // 
            // button_deletar
            // 
            this.button_deletar.Location = new System.Drawing.Point(12, 91);
            this.button_deletar.Name = "button_deletar";
            this.button_deletar.Size = new System.Drawing.Size(114, 23);
            this.button_deletar.TabIndex = 8;
            this.button_deletar.Text = "Excluir";
            this.button_deletar.UseVisualStyleBackColor = true;
            this.button_deletar.Click += new System.EventHandler(this.button_deletar_Click);
            // 
            // grid_cad_operador
            // 
            this.grid_cad_operador.AllowUserToAddRows = false;
            this.grid_cad_operador.AllowUserToDeleteRows = false;
            this.grid_cad_operador.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_cad_operador.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grid_cad_operador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_cad_operador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_cad_operador.Location = new System.Drawing.Point(142, 114);
            this.grid_cad_operador.Name = "grid_cad_operador";
            this.grid_cad_operador.ReadOnly = true;
            this.grid_cad_operador.Size = new System.Drawing.Size(910, 498);
            this.grid_cad_operador.TabIndex = 18;
            this.grid_cad_operador.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_cad_operador_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_descri_turno);
            this.groupBox1.Controls.Add(this.text_funcao);
            this.groupBox1.Controls.Add(this.combo_equipamento);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.combo_turno);
            this.groupBox1.Controls.Add(this.label_id_cad_operador);
            this.groupBox1.Controls.Add(this.text_nome_operador);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.menuStrip1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(142, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(910, 114);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informação basica";
            // 
            // label_descri_turno
            // 
            this.label_descri_turno.AutoSize = true;
            this.label_descri_turno.Location = new System.Drawing.Point(521, 50);
            this.label_descri_turno.Name = "label_descri_turno";
            this.label_descri_turno.Size = new System.Drawing.Size(16, 13);
            this.label_descri_turno.TabIndex = 13;
            this.label_descri_turno.Text = "...";
            // 
            // text_funcao
            // 
            this.text_funcao.Location = new System.Drawing.Point(100, 73);
            this.text_funcao.Name = "text_funcao";
            this.text_funcao.Size = new System.Drawing.Size(203, 20);
            this.text_funcao.TabIndex = 3;
            this.text_funcao.MouseHover += new System.EventHandler(this.text_funcao_MouseHover);
            // 
            // combo_equipamento
            // 
            this.combo_equipamento.FormattingEnabled = true;
            this.combo_equipamento.Location = new System.Drawing.Point(405, 73);
            this.combo_equipamento.Name = "combo_equipamento";
            this.combo_equipamento.Size = new System.Drawing.Size(203, 21);
            this.combo_equipamento.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Função:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Equipamento:";
            // 
            // combo_turno
            // 
            this.combo_turno.FormattingEnabled = true;
            this.combo_turno.Location = new System.Drawing.Point(405, 47);
            this.combo_turno.Name = "combo_turno";
            this.combo_turno.Size = new System.Drawing.Size(110, 21);
            this.combo_turno.TabIndex = 2;
            this.combo_turno.SelectedIndexChanged += new System.EventHandler(this.combo_turno_SelectedIndexChanged);
            // 
            // label_id_cad_operador
            // 
            this.label_id_cad_operador.AutoSize = true;
            this.label_id_cad_operador.Location = new System.Drawing.Point(654, 76);
            this.label_id_cad_operador.Name = "label_id_cad_operador";
            this.label_id_cad_operador.Size = new System.Drawing.Size(15, 13);
            this.label_id_cad_operador.TabIndex = 8;
            this.label_id_cad_operador.Text = "id";
            // 
            // text_nome_operador
            // 
            this.text_nome_operador.Location = new System.Drawing.Point(100, 47);
            this.text_nome_operador.Name = "text_nome_operador";
            this.text_nome_operador.Size = new System.Drawing.Size(203, 20);
            this.text_nome_operador.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Turno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Operador:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroTurnoToolStripMenuItem,
            this.cadastroEquipamentoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 16);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(904, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroTurnoToolStripMenuItem
            // 
            this.cadastroTurnoToolStripMenuItem.Name = "cadastroTurnoToolStripMenuItem";
            this.cadastroTurnoToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.cadastroTurnoToolStripMenuItem.Text = "Cadastro Turno";
            // 
            // cadastroEquipamentoToolStripMenuItem
            // 
            this.cadastroEquipamentoToolStripMenuItem.Name = "cadastroEquipamentoToolStripMenuItem";
            this.cadastroEquipamentoToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.cadastroEquipamentoToolStripMenuItem.Text = "Cadastro Equipamento";
            // 
            // button_fechar
            // 
            this.button_fechar.Location = new System.Drawing.Point(12, 178);
            this.button_fechar.Name = "button_fechar";
            this.button_fechar.Size = new System.Drawing.Size(114, 23);
            this.button_fechar.TabIndex = 12;
            this.button_fechar.Text = "Sair";
            this.button_fechar.UseVisualStyleBackColor = true;
            this.button_fechar.Click += new System.EventHandler(this.button_fechar_Click);
            // 
            // Form_janela_cad_operador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 612);
            this.Controls.Add(this.grid_cad_operador);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_janela_cad_operador";
            this.Text = "Cadastro Operadores";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_cad_operador)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_limpar_controles;
        private System.Windows.Forms.Button button_atualizar;
        private System.Windows.Forms.Button button_filtrar;
        private System.Windows.Forms.Button button_salvar;
        private System.Windows.Forms.Button button_deletar;
        private System.Windows.Forms.DataGridView grid_cad_operador;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_turno;
        private System.Windows.Forms.Label label_id_cad_operador;
        private System.Windows.Forms.TextBox text_nome_operador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combo_equipamento;
        private System.Windows.Forms.TextBox text_funcao;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroTurnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroEquipamentoToolStripMenuItem;
        private System.Windows.Forms.Label label_descri_turno;
        private System.Windows.Forms.Button button_fechar;
    }
}