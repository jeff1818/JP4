
namespace JP4
{
    partial class Form_janela_cad_equipamentos
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
            this.grid_cad_empresa = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.text_velocidade_padrao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.text_descri_equipamento = new System.Windows.Forms.TextBox();
            this.text_fator = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.combo_situacao_aquipamento = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_cod_equipamento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_id_cad_equipamento = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.text_hr_trabalhada = new System.Windows.Forms.TextBox();
            this.text_quilo_hora = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.text_prod_minuto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.text_patriponio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.text_comprimento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.text_altura = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.text_largura = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.combo_eq_empresa = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_cad_empresa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_limpar_controles);
            this.groupBox2.Controls.Add(this.button_atualizar);
            this.groupBox2.Controls.Add(this.button_filtrar);
            this.groupBox2.Controls.Add(this.button_salvar);
            this.groupBox2.Controls.Add(this.button_deletar);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(142, 188);
            this.groupBox2.TabIndex = 17;
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
            // grid_cad_empresa
            // 
            this.grid_cad_empresa.AllowUserToAddRows = false;
            this.grid_cad_empresa.AllowUserToDeleteRows = false;
            this.grid_cad_empresa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_cad_empresa.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grid_cad_empresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_cad_empresa.Location = new System.Drawing.Point(0, 194);
            this.grid_cad_empresa.Name = "grid_cad_empresa";
            this.grid_cad_empresa.ReadOnly = true;
            this.grid_cad_empresa.Size = new System.Drawing.Size(1052, 418);
            this.grid_cad_empresa.TabIndex = 19;
            this.grid_cad_empresa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_cad_empresa_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.combo_eq_empresa);
            this.groupBox1.Controls.Add(this.text_largura);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.text_altura);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.text_comprimento);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.text_patriponio);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.text_prod_minuto);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.text_quilo_hora);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.text_hr_trabalhada);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.text_velocidade_padrao);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.text_descri_equipamento);
            this.groupBox1.Controls.Add(this.text_fator);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.combo_situacao_aquipamento);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.text_cod_equipamento);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label_id_cad_equipamento);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(142, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(910, 188);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informação basica";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Horas Trabalhadas";
            // 
            // text_velocidade_padrao
            // 
            this.text_velocidade_padrao.Location = new System.Drawing.Point(129, 79);
            this.text_velocidade_padrao.Name = "text_velocidade_padrao";
            this.text_velocidade_padrao.Size = new System.Drawing.Size(139, 20);
            this.text_velocidade_padrao.TabIndex = 6;
            this.text_velocidade_padrao.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Velocidade Padrão:";
            // 
            // text_descri_equipamento
            // 
            this.text_descri_equipamento.Location = new System.Drawing.Point(129, 53);
            this.text_descri_equipamento.Name = "text_descri_equipamento";
            this.text_descri_equipamento.Size = new System.Drawing.Size(387, 20);
            this.text_descri_equipamento.TabIndex = 4;
            // 
            // text_fator
            // 
            this.text_fator.Location = new System.Drawing.Point(587, 50);
            this.text_fator.Name = "text_fator";
            this.text_fator.Size = new System.Drawing.Size(139, 20);
            this.text_fator.TabIndex = 5;
            this.text_fator.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(547, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Fator:";
            // 
            // combo_situacao_aquipamento
            // 
            this.combo_situacao_aquipamento.FormattingEnabled = true;
            this.combo_situacao_aquipamento.Items.AddRange(new object[] {
            "Ativo",
            "Inativo",
            "Ocioso",
            ""});
            this.combo_situacao_aquipamento.Location = new System.Drawing.Point(377, 23);
            this.combo_situacao_aquipamento.Name = "combo_situacao_aquipamento";
            this.combo_situacao_aquipamento.Size = new System.Drawing.Size(139, 21);
            this.combo_situacao_aquipamento.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Situação:";
            // 
            // text_cod_equipamento
            // 
            this.text_cod_equipamento.Location = new System.Drawing.Point(129, 24);
            this.text_cod_equipamento.Name = "text_cod_equipamento";
            this.text_cod_equipamento.Size = new System.Drawing.Size(139, 20);
            this.text_cod_equipamento.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Descr. Equipamento:";
            // 
            // label_id_cad_equipamento
            // 
            this.label_id_cad_equipamento.AutoSize = true;
            this.label_id_cad_equipamento.Location = new System.Drawing.Point(806, 27);
            this.label_id_cad_equipamento.Name = "label_id_cad_equipamento";
            this.label_id_cad_equipamento.Size = new System.Drawing.Size(15, 13);
            this.label_id_cad_equipamento.TabIndex = 8;
            this.label_id_cad_equipamento.Text = "id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cod. Equipamento:";
            // 
            // text_hr_trabalhada
            // 
            this.text_hr_trabalhada.Location = new System.Drawing.Point(377, 79);
            this.text_hr_trabalhada.Name = "text_hr_trabalhada";
            this.text_hr_trabalhada.Size = new System.Drawing.Size(139, 20);
            this.text_hr_trabalhada.TabIndex = 7;
            // 
            // text_quilo_hora
            // 
            this.text_quilo_hora.Location = new System.Drawing.Point(587, 79);
            this.text_quilo_hora.Name = "text_quilo_hora";
            this.text_quilo_hora.Size = new System.Drawing.Size(139, 20);
            this.text_quilo_hora.TabIndex = 8;
            this.text_quilo_hora.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(522, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Quilo/Hora";
            // 
            // text_prod_minuto
            // 
            this.text_prod_minuto.Location = new System.Drawing.Point(795, 79);
            this.text_prod_minuto.Name = "text_prod_minuto";
            this.text_prod_minuto.Size = new System.Drawing.Size(103, 20);
            this.text_prod_minuto.TabIndex = 9;
            this.text_prod_minuto.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(732, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Prod / Min";
            // 
            // text_patriponio
            // 
            this.text_patriponio.Location = new System.Drawing.Point(587, 24);
            this.text_patriponio.Name = "text_patriponio";
            this.text_patriponio.Size = new System.Drawing.Size(139, 20);
            this.text_patriponio.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(525, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Patrimonio";
            // 
            // text_comprimento
            // 
            this.text_comprimento.Location = new System.Drawing.Point(129, 105);
            this.text_comprimento.Name = "text_comprimento";
            this.text_comprimento.Size = new System.Drawing.Size(139, 20);
            this.text_comprimento.TabIndex = 10;
            this.text_comprimento.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Comprimento:";
            // 
            // text_altura
            // 
            this.text_altura.Location = new System.Drawing.Point(377, 105);
            this.text_altura.Name = "text_altura";
            this.text_altura.Size = new System.Drawing.Size(139, 20);
            this.text_altura.TabIndex = 11;
            this.text_altura.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(337, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Altura";
            // 
            // text_largura
            // 
            this.text_largura.Location = new System.Drawing.Point(587, 105);
            this.text_largura.Name = "text_largura";
            this.text_largura.Size = new System.Drawing.Size(139, 20);
            this.text_largura.TabIndex = 12;
            this.text_largura.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(537, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Largura";
            // 
            // combo_eq_empresa
            // 
            this.combo_eq_empresa.FormattingEnabled = true;
            this.combo_eq_empresa.Location = new System.Drawing.Point(129, 131);
            this.combo_eq_empresa.Name = "combo_eq_empresa";
            this.combo_eq_empresa.Size = new System.Drawing.Size(139, 21);
            this.combo_eq_empresa.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(61, 134);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Empresa:";
            // 
            // Form_janela_cad_equipamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 612);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grid_cad_empresa);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form_janela_cad_equipamentos";
            this.Text = "Cadastro de Equipamentos";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_cad_empresa)).EndInit();
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
        private System.Windows.Forms.DataGridView grid_cad_empresa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_id_cad_equipamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_descri_equipamento;
        private System.Windows.Forms.TextBox text_fator;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combo_situacao_aquipamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_cod_equipamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_velocidade_padrao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox combo_eq_empresa;
        private System.Windows.Forms.TextBox text_largura;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox text_altura;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox text_comprimento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox text_patriponio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox text_prod_minuto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox text_quilo_hora;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox text_hr_trabalhada;
    }
}