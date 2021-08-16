
namespace JP4
{
    partial class Form_janela_report01
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_dia_atual = new System.Windows.Forms.Label();
            this.label_report_dia_semana = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label_report_total_prod = new System.Windows.Forms.Label();
            this.label_report_total_apara = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label_report_perct_apara = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chart_producao_pico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_producao_extrusora = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_producao_pico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_producao_extrusora)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label_report_dia_semana);
            this.panel1.Controls.Add(this.label_dia_atual);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 79);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label_report_total_prod);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(336, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 79);
            this.panel2.TabIndex = 1;
            // 
            // label_dia_atual
            // 
            this.label_dia_atual.AutoSize = true;
            this.label_dia_atual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dia_atual.Location = new System.Drawing.Point(185, 23);
            this.label_dia_atual.Name = "label_dia_atual";
            this.label_dia_atual.Size = new System.Drawing.Size(131, 29);
            this.label_dia_atual.TabIndex = 0;
            this.label_dia_atual.Text = "13/08/2021";
            // 
            // label_report_dia_semana
            // 
            this.label_report_dia_semana.AutoSize = true;
            this.label_report_dia_semana.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_report_dia_semana.Location = new System.Drawing.Point(3, 23);
            this.label_report_dia_semana.Name = "label_report_dia_semana";
            this.label_report_dia_semana.Size = new System.Drawing.Size(149, 29);
            this.label_report_dia_semana.TabIndex = 1;
            this.label_report_dia_semana.Text = "Sexta - Feira";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Produção Total";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label_report_total_apara);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(676, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 79);
            this.panel3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Apara Total";
            // 
            // label_report_total_prod
            // 
            this.label_report_total_prod.AutoSize = true;
            this.label_report_total_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_report_total_prod.Location = new System.Drawing.Point(187, 23);
            this.label_report_total_prod.Name = "label_report_total_prod";
            this.label_report_total_prod.Size = new System.Drawing.Size(97, 29);
            this.label_report_total_prod.TabIndex = 3;
            this.label_report_total_prod.Text = "100,000";
            // 
            // label_report_total_apara
            // 
            this.label_report_total_apara.AutoSize = true;
            this.label_report_total_apara.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_report_total_apara.Location = new System.Drawing.Point(146, 26);
            this.label_report_total_apara.Name = "label_report_total_apara";
            this.label_report_total_apara.Size = new System.Drawing.Size(97, 29);
            this.label_report_total_apara.TabIndex = 4;
            this.label_report_total_apara.Text = "100,000";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label_report_perct_apara);
            this.panel4.Location = new System.Drawing.Point(949, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(179, 79);
            this.panel4.TabIndex = 3;
            // 
            // label_report_perct_apara
            // 
            this.label_report_perct_apara.AutoSize = true;
            this.label_report_perct_apara.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_report_perct_apara.Location = new System.Drawing.Point(115, 19);
            this.label_report_perct_apara.Name = "label_report_perct_apara";
            this.label_report_perct_apara.Size = new System.Drawing.Size(61, 29);
            this.label_report_perct_apara.TabIndex = 4;
            this.label_report_perct_apara.Text = "10%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 29);
            this.label8.TabIndex = 5;
            this.label8.Text = "%Apara";
            // 
            // chart_producao_pico
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_producao_pico.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_producao_pico.Legends.Add(legend1);
            this.chart_producao_pico.Location = new System.Drawing.Point(12, 97);
            this.chart_producao_pico.Name = "chart_producao_pico";
            this.chart_producao_pico.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_producao_pico.Series.Add(series1);
            this.chart_producao_pico.Size = new System.Drawing.Size(1116, 243);
            this.chart_producao_pico.TabIndex = 4;
            this.chart_producao_pico.Text = "chart1";
            // 
            // chart_producao_extrusora
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_producao_extrusora.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_producao_extrusora.Legends.Add(legend2);
            this.chart_producao_extrusora.Location = new System.Drawing.Point(12, 346);
            this.chart_producao_extrusora.Name = "chart_producao_extrusora";
            this.chart_producao_extrusora.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart_producao_extrusora.Series.Add(series2);
            this.chart_producao_extrusora.Size = new System.Drawing.Size(1116, 243);
            this.chart_producao_extrusora.TabIndex = 5;
            this.chart_producao_extrusora.Text = "chart1";
            // 
            // Form_janela_report01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 635);
            this.Controls.Add(this.chart_producao_extrusora);
            this.Controls.Add(this.chart_producao_pico);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_janela_report01";
            this.Text = "Relatório";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_producao_pico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_producao_extrusora)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_report_dia_semana;
        private System.Windows.Forms.Label label_dia_atual;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_report_total_prod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_report_total_apara;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_report_perct_apara;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_producao_pico;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_producao_extrusora;
    }
}