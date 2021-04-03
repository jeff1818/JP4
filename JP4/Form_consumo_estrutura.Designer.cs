
namespace JP4
{
    partial class Form_consumo_estrutura
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.text_descri_item = new System.Windows.Forms.TextBox();
            this.text__cod_item = new System.Windows.Forms.TextBox();
            this.text_qtd_saldo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.db_aplicativo_kpiDataSet = new JP4.db_aplicativo_kpiDataSet();
            this.Grid_estrutura_item = new System.Windows.Forms.DataGridView();
            this.dbaplicativokpiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroEstruturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_aplicativo_kpiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_estrutura_item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbaplicativokpiDataSetBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.text_descri_item);
            this.groupBox1.Controls.Add(this.text__cod_item);
            this.groupBox1.Controls.Add(this.text_qtd_saldo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(9, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 94);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informação de Ordem";
            // 
            // text_descri_item
            // 
            this.text_descri_item.Location = new System.Drawing.Point(276, 22);
            this.text_descri_item.Name = "text_descri_item";
            this.text_descri_item.Size = new System.Drawing.Size(341, 20);
            this.text_descri_item.TabIndex = 11;
            this.text_descri_item.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_descri_item_KeyPress);
            // 
            // text__cod_item
            // 
            this.text__cod_item.Location = new System.Drawing.Point(127, 22);
            this.text__cod_item.Name = "text__cod_item";
            this.text__cod_item.Size = new System.Drawing.Size(143, 20);
            this.text__cod_item.TabIndex = 10;
            // 
            // text_qtd_saldo
            // 
            this.text_qtd_saldo.Location = new System.Drawing.Point(127, 51);
            this.text_qtd_saldo.Name = "text_qtd_saldo";
            this.text_qtd_saldo.Size = new System.Drawing.Size(143, 20);
            this.text_qtd_saldo.TabIndex = 9;
            this.text_qtd_saldo.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Qtd, Apontada:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Item:";
            // 
            // db_aplicativo_kpiDataSet
            // 
            this.db_aplicativo_kpiDataSet.DataSetName = "db_aplicativo_kpiDataSet";
            this.db_aplicativo_kpiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Grid_estrutura_item
            // 
            this.Grid_estrutura_item.AllowUserToAddRows = false;
            this.Grid_estrutura_item.AllowUserToDeleteRows = false;
            this.Grid_estrutura_item.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_estrutura_item.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Grid_estrutura_item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_estrutura_item.Location = new System.Drawing.Point(9, 127);
            this.Grid_estrutura_item.Name = "Grid_estrutura_item";
            this.Grid_estrutura_item.ReadOnly = true;
            this.Grid_estrutura_item.Size = new System.Drawing.Size(703, 217);
            this.Grid_estrutura_item.TabIndex = 6;
            // 
            // dbaplicativokpiDataSetBindingSource
            // 
            this.dbaplicativokpiDataSetBindingSource.DataSource = this.db_aplicativo_kpiDataSet;
            this.dbaplicativokpiDataSetBindingSource.Position = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroEstruturaToolStripMenuItem,
            this.sAIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(727, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroEstruturaToolStripMenuItem
            // 
            this.cadastroEstruturaToolStripMenuItem.Name = "cadastroEstruturaToolStripMenuItem";
            this.cadastroEstruturaToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.cadastroEstruturaToolStripMenuItem.Text = "Cadastro Estrutura";
            // 
            // sAIRToolStripMenuItem
            // 
            this.sAIRToolStripMenuItem.Name = "sAIRToolStripMenuItem";
            this.sAIRToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.sAIRToolStripMenuItem.Text = "SAIR";
            this.sAIRToolStripMenuItem.Click += new System.EventHandler(this.sAIRToolStripMenuItem_Click);
            // 
            // Form_consumo_estrutura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 357);
            this.Controls.Add(this.Grid_estrutura_item);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_consumo_estrutura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_consumo_estrutura";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_consumo_estrutura_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_aplicativo_kpiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_estrutura_item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbaplicativokpiDataSetBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox text_qtd_saldo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_descri_item;
        private System.Windows.Forms.TextBox text__cod_item;
        private db_aplicativo_kpiDataSet db_aplicativo_kpiDataSet;
        private System.Windows.Forms.DataGridView Grid_estrutura_item;
        private System.Windows.Forms.BindingSource dbaplicativokpiDataSetBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroEstruturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAIRToolStripMenuItem;
    }
}