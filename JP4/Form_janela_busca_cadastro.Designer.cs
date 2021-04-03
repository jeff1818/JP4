
namespace JP4
{
    partial class FIND_CAD
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_descri_grupo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.combo_grupo_estoque = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_status = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_descri_completa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_cod_item = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grid_cadastro = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_limpar_filtro = new System.Windows.Forms.Button();
            this.button_editar = new System.Windows.Forms.Button();
            this.button_filtrar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.text_id_componente_envia = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_cadastro)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_descri_grupo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.combo_grupo_estoque);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.combo_status);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.combo_descri_completa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.combo_cod_item);
            this.groupBox1.Location = new System.Drawing.Point(162, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(896, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item";
            // 
            // label_descri_grupo
            // 
            this.label_descri_grupo.AutoSize = true;
            this.label_descri_grupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_descri_grupo.Location = new System.Drawing.Point(769, 19);
            this.label_descri_grupo.Name = "label_descri_grupo";
            this.label_descri_grupo.Size = new System.Drawing.Size(15, 13);
            this.label_descri_grupo.TabIndex = 8;
            this.label_descri_grupo.Text = "--";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(509, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Grupo Estoque";
            // 
            // combo_grupo_estoque
            // 
            this.combo_grupo_estoque.FormattingEnabled = true;
            this.combo_grupo_estoque.Location = new System.Drawing.Point(593, 15);
            this.combo_grupo_estoque.Name = "combo_grupo_estoque";
            this.combo_grupo_estoque.Size = new System.Drawing.Size(170, 21);
            this.combo_grupo_estoque.TabIndex = 6;
            this.combo_grupo_estoque.SelectedIndexChanged += new System.EventHandler(this.combo_grupo_estoque_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Status:";
            // 
            // combo_status
            // 
            this.combo_status.FormattingEnabled = true;
            this.combo_status.Location = new System.Drawing.Point(331, 15);
            this.combo_status.Name = "combo_status";
            this.combo_status.Size = new System.Drawing.Size(170, 21);
            this.combo_status.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descrição item:";
            // 
            // combo_descri_completa
            // 
            this.combo_descri_completa.FormattingEnabled = true;
            this.combo_descri_completa.Location = new System.Drawing.Point(109, 54);
            this.combo_descri_completa.Name = "combo_descri_completa";
            this.combo_descri_completa.Size = new System.Drawing.Size(483, 21);
            this.combo_descri_completa.TabIndex = 2;
            this.combo_descri_completa.SelectedIndexChanged += new System.EventHandler(this.combo_descri_completa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cod. Item:";
            // 
            // combo_cod_item
            // 
            this.combo_cod_item.FormattingEnabled = true;
            this.combo_cod_item.Location = new System.Drawing.Point(109, 15);
            this.combo_cod_item.Name = "combo_cod_item";
            this.combo_cod_item.Size = new System.Drawing.Size(170, 21);
            this.combo_cod_item.TabIndex = 0;
            // 
            // grid_cadastro
            // 
            this.grid_cadastro.AllowUserToAddRows = false;
            this.grid_cadastro.AllowUserToDeleteRows = false;
            this.grid_cadastro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_cadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_cadastro.Location = new System.Drawing.Point(162, 134);
            this.grid_cadastro.Name = "grid_cadastro";
            this.grid_cadastro.ReadOnly = true;
            this.grid_cadastro.Size = new System.Drawing.Size(896, 342);
            this.grid_cadastro.TabIndex = 1;
            this.grid_cadastro.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_cadastro_CellDoubleClick);
            this.grid_cadastro.DoubleClick += new System.EventHandler(this.grid_cadastro_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.text_id_componente_envia);
            this.groupBox2.Controls.Add(this.button_limpar_filtro);
            this.groupBox2.Controls.Add(this.button_editar);
            this.groupBox2.Controls.Add(this.button_filtrar);
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 449);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu";
            // 
            // button_limpar_filtro
            // 
            this.button_limpar_filtro.Location = new System.Drawing.Point(6, 48);
            this.button_limpar_filtro.Name = "button_limpar_filtro";
            this.button_limpar_filtro.Size = new System.Drawing.Size(132, 23);
            this.button_limpar_filtro.TabIndex = 9;
            this.button_limpar_filtro.Text = "Limpar Filtro";
            this.button_limpar_filtro.UseVisualStyleBackColor = true;
            this.button_limpar_filtro.Click += new System.EventHandler(this.button_limpar_filtro_Click);
            // 
            // button_editar
            // 
            this.button_editar.Location = new System.Drawing.Point(6, 78);
            this.button_editar.Name = "button_editar";
            this.button_editar.Size = new System.Drawing.Size(132, 23);
            this.button_editar.TabIndex = 1;
            this.button_editar.Text = "Editar";
            this.button_editar.UseVisualStyleBackColor = true;
            this.button_editar.Click += new System.EventHandler(this.button_editar_Click);
            // 
            // button_filtrar
            // 
            this.button_filtrar.Location = new System.Drawing.Point(6, 19);
            this.button_filtrar.Name = "button_filtrar";
            this.button_filtrar.Size = new System.Drawing.Size(132, 23);
            this.button_filtrar.TabIndex = 0;
            this.button_filtrar.Text = "Filtrar";
            this.button_filtrar.UseVisualStyleBackColor = true;
            this.button_filtrar.Click += new System.EventHandler(this.button_filtrar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1079, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // text_id_componente_envia
            // 
            this.text_id_componente_envia.Location = new System.Drawing.Point(6, 423);
            this.text_id_componente_envia.Name = "text_id_componente_envia";
            this.text_id_componente_envia.Size = new System.Drawing.Size(113, 20);
            this.text_id_componente_envia.TabIndex = 9;
            this.text_id_componente_envia.TextChanged += new System.EventHandler(this.text_id_componente_envia_TextChanged);
            // 
            // FIND_CAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 507);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grid_cadastro);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FIND_CAD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_janela_busca_cadastro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_cadastro)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView grid_cadastro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_descri_completa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_cod_item;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_filtrar;
        private System.Windows.Forms.Button button_editar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combo_grupo_estoque;
        private System.Windows.Forms.Label label_descri_grupo;
        private System.Windows.Forms.Button button_limpar_filtro;
        public System.Windows.Forms.TextBox text_id_componente_envia;
    }
}