
namespace JP4
{
    partial class Form_janela_cad_clientes
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
            this.button_limpar_controles = new System.Windows.Forms.Button();
            this.button_atualizar = new System.Windows.Forms.Button();
            this.button_filtrar = new System.Windows.Forms.Button();
            this.button_salvar = new System.Windows.Forms.Button();
            this.button_deletar = new System.Windows.Forms.Button();
            this.grid_cad_clientes = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combo_local_destino = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.richText_observacao = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.date_modificacao = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.text_nome_fantasia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.text_razao_social = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.text_nome_reduzido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_cod_cliente = new System.Windows.Forms.TextBox();
            this.combo_status_cliente = new System.Windows.Forms.ComboBox();
            this.date_cadastro = new System.Windows.Forms.DateTimePicker();
            this.label_id_clientes = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_cad_clientes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_sair);
            this.groupBox2.Controls.Add(this.button_limpar_controles);
            this.groupBox2.Controls.Add(this.button_atualizar);
            this.groupBox2.Controls.Add(this.button_filtrar);
            this.groupBox2.Controls.Add(this.button_salvar);
            this.groupBox2.Controls.Add(this.button_deletar);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(142, 612);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu";
            // 
            // button_sair
            // 
            this.button_sair.Location = new System.Drawing.Point(12, 178);
            this.button_sair.Name = "button_sair";
            this.button_sair.Size = new System.Drawing.Size(114, 23);
            this.button_sair.TabIndex = 12;
            this.button_sair.Text = "Sair";
            this.button_sair.UseVisualStyleBackColor = true;
            this.button_sair.Click += new System.EventHandler(this.button_sair_Click);
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
            // grid_cad_clientes
            // 
            this.grid_cad_clientes.AllowUserToAddRows = false;
            this.grid_cad_clientes.AllowUserToDeleteRows = false;
            this.grid_cad_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_cad_clientes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grid_cad_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_cad_clientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_cad_clientes.Location = new System.Drawing.Point(142, 172);
            this.grid_cad_clientes.Name = "grid_cad_clientes";
            this.grid_cad_clientes.ReadOnly = true;
            this.grid_cad_clientes.Size = new System.Drawing.Size(910, 440);
            this.grid_cad_clientes.TabIndex = 12;
            this.grid_cad_clientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_cad_clientes_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.combo_local_destino);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.richText_observacao);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.date_modificacao);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.text_nome_fantasia);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.text_razao_social);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.text_nome_reduzido);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.text_cod_cliente);
            this.groupBox1.Controls.Add(this.combo_status_cliente);
            this.groupBox1.Controls.Add(this.date_cadastro);
            this.groupBox1.Controls.Add(this.label_id_clientes);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(142, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(910, 172);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informação basica:";
            // 
            // combo_local_destino
            // 
            this.combo_local_destino.FormattingEnabled = true;
            this.combo_local_destino.Items.AddRange(new object[] {
            "Ativo",
            "Desativado"});
            this.combo_local_destino.Location = new System.Drawing.Point(550, 75);
            this.combo_local_destino.Name = "combo_local_destino";
            this.combo_local_destino.Size = new System.Drawing.Size(196, 21);
            this.combo_local_destino.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(469, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Local Destino:";
            // 
            // richText_observacao
            // 
            this.richText_observacao.Location = new System.Drawing.Point(96, 102);
            this.richText_observacao.Name = "richText_observacao";
            this.richText_observacao.Size = new System.Drawing.Size(575, 58);
            this.richText_observacao.TabIndex = 6;
            this.richText_observacao.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Observação:";
            // 
            // date_modificacao
            // 
            this.date_modificacao.Enabled = false;
            this.date_modificacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_modificacao.Location = new System.Drawing.Point(298, 74);
            this.date_modificacao.Name = "date_modificacao";
            this.date_modificacao.Size = new System.Drawing.Size(106, 20);
            this.date_modificacao.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(208, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Ult. Modificação";
            // 
            // text_nome_fantasia
            // 
            this.text_nome_fantasia.Location = new System.Drawing.Point(550, 49);
            this.text_nome_fantasia.Name = "text_nome_fantasia";
            this.text_nome_fantasia.Size = new System.Drawing.Size(348, 20);
            this.text_nome_fantasia.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(466, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Nome Fantasia:";
            // 
            // text_razao_social
            // 
            this.text_razao_social.Location = new System.Drawing.Point(96, 50);
            this.text_razao_social.Name = "text_razao_social";
            this.text_razao_social.Size = new System.Drawing.Size(324, 20);
            this.text_razao_social.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Razão Social";
            // 
            // text_nome_reduzido
            // 
            this.text_nome_reduzido.Location = new System.Drawing.Point(550, 23);
            this.text_nome_reduzido.Name = "text_nome_reduzido";
            this.text_nome_reduzido.Size = new System.Drawing.Size(196, 20);
            this.text_nome_reduzido.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nome Cliente Reduzido:";
            // 
            // text_cod_cliente
            // 
            this.text_cod_cliente.Location = new System.Drawing.Point(293, 24);
            this.text_cod_cliente.Name = "text_cod_cliente";
            this.text_cod_cliente.Size = new System.Drawing.Size(127, 20);
            this.text_cod_cliente.TabIndex = 2;
            // 
            // combo_status_cliente
            // 
            this.combo_status_cliente.FormattingEnabled = true;
            this.combo_status_cliente.Items.AddRange(new object[] {
            "Ativo",
            "Desativado"});
            this.combo_status_cliente.Location = new System.Drawing.Point(96, 23);
            this.combo_status_cliente.Name = "combo_status_cliente";
            this.combo_status_cliente.Size = new System.Drawing.Size(121, 21);
            this.combo_status_cliente.TabIndex = 1;
            // 
            // date_cadastro
            // 
            this.date_cadastro.Enabled = false;
            this.date_cadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_cadastro.Location = new System.Drawing.Point(96, 76);
            this.date_cadastro.Name = "date_cadastro";
            this.date_cadastro.Size = new System.Drawing.Size(106, 20);
            this.date_cadastro.TabIndex = 9;
            // 
            // label_id_clientes
            // 
            this.label_id_clientes.AutoSize = true;
            this.label_id_clientes.Location = new System.Drawing.Point(767, 26);
            this.label_id_clientes.Name = "label_id_clientes";
            this.label_id_clientes.Size = new System.Drawing.Size(15, 13);
            this.label_id_clientes.TabIndex = 8;
            this.label_id_clientes.Text = "id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dt. Cadastro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cod. Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status";
            // 
            // Form_janela_cad_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 612);
            this.Controls.Add(this.grid_cad_clientes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_janela_cad_clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Clientes";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_cad_clientes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_limpar_controles;
        private System.Windows.Forms.Button button_atualizar;
        private System.Windows.Forms.Button button_filtrar;
        private System.Windows.Forms.Button button_salvar;
        private System.Windows.Forms.Button button_deletar;
        private System.Windows.Forms.DataGridView grid_cad_clientes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_id_clientes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date_cadastro;
        private System.Windows.Forms.DateTimePicker date_modificacao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox text_nome_fantasia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_razao_social;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_nome_reduzido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_cod_cliente;
        private System.Windows.Forms.ComboBox combo_status_cliente;
        private System.Windows.Forms.RichTextBox richText_observacao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox combo_local_destino;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_sair;
    }
}