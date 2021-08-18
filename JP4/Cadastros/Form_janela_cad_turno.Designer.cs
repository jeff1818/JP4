
namespace JP4.Cadastros
{
    partial class Form_janela_cad_turno
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
            this.label_id_cad_turno = new System.Windows.Forms.Label();
            this.text_descri_turno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hr_inicial = new System.Windows.Forms.DateTimePicker();
            this.hr_final = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grid_cad_turno = new System.Windows.Forms.DataGridView();
            this.rich_observacao = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_cad_turno)).BeginInit();
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
            this.groupBox2.Size = new System.Drawing.Size(142, 450);
            this.groupBox2.TabIndex = 16;
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
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rich_observacao);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.hr_final);
            this.groupBox1.Controls.Add(this.hr_inicial);
            this.groupBox1.Controls.Add(this.label_id_cad_turno);
            this.groupBox1.Controls.Add(this.text_descri_turno);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(142, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(683, 143);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informação basica";
            // 
            // label_id_cad_turno
            // 
            this.label_id_cad_turno.AutoSize = true;
            this.label_id_cad_turno.Location = new System.Drawing.Point(626, 33);
            this.label_id_cad_turno.Name = "label_id_cad_turno";
            this.label_id_cad_turno.Size = new System.Drawing.Size(15, 13);
            this.label_id_cad_turno.TabIndex = 8;
            this.label_id_cad_turno.Text = "id";
            // 
            // text_descri_turno
            // 
            this.text_descri_turno.Location = new System.Drawing.Point(84, 30);
            this.text_descri_turno.Name = "text_descri_turno";
            this.text_descri_turno.Size = new System.Drawing.Size(203, 20);
            this.text_descri_turno.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cad. Turno:";
            // 
            // hr_inicial
            // 
            this.hr_inicial.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.hr_inicial.Location = new System.Drawing.Point(360, 30);
            this.hr_inicial.Name = "hr_inicial";
            this.hr_inicial.Size = new System.Drawing.Size(87, 20);
            this.hr_inicial.TabIndex = 13;
            // 
            // hr_final
            // 
            this.hr_final.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.hr_final.Location = new System.Drawing.Point(517, 30);
            this.hr_final.Name = "hr_final";
            this.hr_final.Size = new System.Drawing.Size(87, 20);
            this.hr_final.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Hora Inicio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Hora Final:";
            // 
            // grid_cad_turno
            // 
            this.grid_cad_turno.AllowUserToAddRows = false;
            this.grid_cad_turno.AllowUserToDeleteRows = false;
            this.grid_cad_turno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_cad_turno.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grid_cad_turno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_cad_turno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_cad_turno.Location = new System.Drawing.Point(142, 143);
            this.grid_cad_turno.Name = "grid_cad_turno";
            this.grid_cad_turno.ReadOnly = true;
            this.grid_cad_turno.Size = new System.Drawing.Size(683, 307);
            this.grid_cad_turno.TabIndex = 19;
            this.grid_cad_turno.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_cad_turno_CellDoubleClick);
            // 
            // rich_observacao
            // 
            this.rich_observacao.Location = new System.Drawing.Point(84, 62);
            this.rich_observacao.Name = "rich_observacao";
            this.rich_observacao.Size = new System.Drawing.Size(520, 41);
            this.rich_observacao.TabIndex = 17;
            this.rich_observacao.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Observação:";
            // 
            // Form_janela_cad_turno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 450);
            this.Controls.Add(this.grid_cad_turno);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_janela_cad_turno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_janela_cad_turno";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_cad_turno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_atualizar;
        private System.Windows.Forms.Button button_salvar;
        private System.Windows.Forms.Button button_deletar;
        private System.Windows.Forms.Button button_sair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_id_cad_turno;
        private System.Windows.Forms.TextBox text_descri_turno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker hr_final;
        private System.Windows.Forms.DateTimePicker hr_inicial;
        private System.Windows.Forms.DataGridView grid_cad_turno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rich_observacao;
    }
}