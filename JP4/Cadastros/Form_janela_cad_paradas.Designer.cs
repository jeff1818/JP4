
namespace JP4.Cadastros
{
    partial class Form_janela_cad_paradas
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
            this.button_sair = new System.Windows.Forms.Button();
            this.button_atualizar = new System.Windows.Forms.Button();
            this.button_salvar = new System.Windows.Forms.Button();
            this.button_deletar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combo_origem_parada = new System.Windows.Forms.ComboBox();
            this.text_descri_parada = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rich_observacao = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_id_cad_parada = new System.Windows.Forms.Label();
            this.text_cod_paradas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grid_cad_paradas = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_cad_paradas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_sair);
            this.groupBox2.Controls.Add(this.button_atualizar);
            this.groupBox2.Controls.Add(this.button_salvar);
            this.groupBox2.Controls.Add(this.button_deletar);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(142, 546);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu";
            // 
            // button_sair
            // 
            this.button_sair.Location = new System.Drawing.Point(12, 120);
            this.button_sair.Name = "button_sair";
            this.button_sair.Size = new System.Drawing.Size(114, 23);
            this.button_sair.TabIndex = 12;
            this.button_sair.Text = "Sair";
            this.button_sair.UseVisualStyleBackColor = true;
            this.button_sair.Click += new System.EventHandler(this.button_sair_Click);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.combo_origem_parada);
            this.groupBox1.Controls.Add(this.text_descri_parada);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rich_observacao);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label_id_cad_parada);
            this.groupBox1.Controls.Add(this.text_cod_paradas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(142, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(836, 143);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informação basica";
            // 
            // combo_origem_parada
            // 
            this.combo_origem_parada.FormattingEnabled = true;
            this.combo_origem_parada.Location = new System.Drawing.Point(640, 30);
            this.combo_origem_parada.Name = "combo_origem_parada";
            this.combo_origem_parada.Size = new System.Drawing.Size(121, 21);
            this.combo_origem_parada.TabIndex = 21;
            // 
            // text_descri_parada
            // 
            this.text_descri_parada.Location = new System.Drawing.Point(345, 30);
            this.text_descri_parada.Name = "text_descri_parada";
            this.text_descri_parada.Size = new System.Drawing.Size(203, 20);
            this.text_descri_parada.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Descrição Parada:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Observação:";
            // 
            // rich_observacao
            // 
            this.rich_observacao.Location = new System.Drawing.Point(116, 73);
            this.rich_observacao.Name = "rich_observacao";
            this.rich_observacao.Size = new System.Drawing.Size(518, 41);
            this.rich_observacao.TabIndex = 17;
            this.rich_observacao.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(554, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Origem Parada:";
            // 
            // label_id_cad_parada
            // 
            this.label_id_cad_parada.AutoSize = true;
            this.label_id_cad_parada.Location = new System.Drawing.Point(809, 16);
            this.label_id_cad_parada.Name = "label_id_cad_parada";
            this.label_id_cad_parada.Size = new System.Drawing.Size(15, 13);
            this.label_id_cad_parada.TabIndex = 8;
            this.label_id_cad_parada.Text = "id";
            // 
            // text_cod_paradas
            // 
            this.text_cod_paradas.Location = new System.Drawing.Point(116, 30);
            this.text_cod_paradas.Name = "text_cod_paradas";
            this.text_cod_paradas.Size = new System.Drawing.Size(122, 20);
            this.text_cod_paradas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cad. Parada:";
            // 
            // grid_cad_paradas
            // 
            this.grid_cad_paradas.AllowUserToAddRows = false;
            this.grid_cad_paradas.AllowUserToDeleteRows = false;
            this.grid_cad_paradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_cad_paradas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grid_cad_paradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_cad_paradas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_cad_paradas.Location = new System.Drawing.Point(142, 143);
            this.grid_cad_paradas.Name = "grid_cad_paradas";
            this.grid_cad_paradas.ReadOnly = true;
            this.grid_cad_paradas.Size = new System.Drawing.Size(836, 403);
            this.grid_cad_paradas.TabIndex = 20;
            this.grid_cad_paradas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_cad_paradas_CellDoubleClick);
            // 
            // Form_janela_cad_paradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 546);
            this.Controls.Add(this.grid_cad_paradas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_janela_cad_paradas";
            this.Text = "Form_janela_cad_paradas";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_cad_paradas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_sair;
        private System.Windows.Forms.Button button_atualizar;
        private System.Windows.Forms.Button button_salvar;
        private System.Windows.Forms.Button button_deletar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rich_observacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_id_cad_parada;
        private System.Windows.Forms.TextBox text_cod_paradas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid_cad_paradas;
        private System.Windows.Forms.TextBox text_descri_parada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combo_origem_parada;
    }
}