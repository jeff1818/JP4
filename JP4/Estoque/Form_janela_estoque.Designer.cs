
namespace JP4
{
    partial class Form_janela_estoque
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_consulta_estoque = new System.Windows.Forms.TabPage();
            this.grid_consulta_estoque = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_inventario_geral = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tab_consulta_estoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_consulta_estoque)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_consulta_estoque);
            this.tabControl1.Controls.Add(this.tab_inventario_geral);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1078, 580);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_consulta_estoque
            // 
            this.tab_consulta_estoque.Controls.Add(this.grid_consulta_estoque);
            this.tab_consulta_estoque.Controls.Add(this.groupBox1);
            this.tab_consulta_estoque.Location = new System.Drawing.Point(4, 22);
            this.tab_consulta_estoque.Name = "tab_consulta_estoque";
            this.tab_consulta_estoque.Padding = new System.Windows.Forms.Padding(3);
            this.tab_consulta_estoque.Size = new System.Drawing.Size(1070, 554);
            this.tab_consulta_estoque.TabIndex = 0;
            this.tab_consulta_estoque.Text = "Consulta Estoque";
            this.tab_consulta_estoque.UseVisualStyleBackColor = true;
            // 
            // grid_consulta_estoque
            // 
            this.grid_consulta_estoque.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.grid_consulta_estoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_consulta_estoque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_consulta_estoque.Location = new System.Drawing.Point(3, 103);
            this.grid_consulta_estoque.Name = "grid_consulta_estoque";
            this.grid_consulta_estoque.Size = new System.Drawing.Size(1064, 448);
            this.grid_consulta_estoque.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1064, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Consulta";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(230, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Limpar filtro";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(639, 16);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(207, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(556, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Local estoque:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(118, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(432, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição Material:";
            // 
            // tab_inventario_geral
            // 
            this.tab_inventario_geral.Location = new System.Drawing.Point(4, 22);
            this.tab_inventario_geral.Name = "tab_inventario_geral";
            this.tab_inventario_geral.Padding = new System.Windows.Forms.Padding(3);
            this.tab_inventario_geral.Size = new System.Drawing.Size(1070, 554);
            this.tab_inventario_geral.TabIndex = 1;
            this.tab_inventario_geral.Text = "Inventário Geral";
            this.tab_inventario_geral.UseVisualStyleBackColor = true;
            // 
            // Form_janela_estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 580);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form_janela_estoque";
            this.Text = "Relatorio de Estoque";
            this.tabControl1.ResumeLayout(false);
            this.tab_consulta_estoque.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_consulta_estoque)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_consulta_estoque;
        private System.Windows.Forms.TabPage tab_inventario_geral;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid_consulta_estoque;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}