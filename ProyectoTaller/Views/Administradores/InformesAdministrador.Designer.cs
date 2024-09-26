namespace ProyectoTaller.Views.Administradores
{
    partial class InformesAdministrador
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
            this.PBImagenInformeAdmin = new System.Windows.Forms.PictureBox();
            this.LTituloInformeAdmin = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LMarcasVendidas = new System.Windows.Forms.Label();
            this.LVentaMes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenInformeAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // PBImagenInformeAdmin
            // 
            this.PBImagenInformeAdmin.Image = global::ProyectoTaller.Properties.Resources.informe_titulo;
            this.PBImagenInformeAdmin.Location = new System.Drawing.Point(12, 12);
            this.PBImagenInformeAdmin.Name = "PBImagenInformeAdmin";
            this.PBImagenInformeAdmin.Size = new System.Drawing.Size(65, 67);
            this.PBImagenInformeAdmin.TabIndex = 31;
            this.PBImagenInformeAdmin.TabStop = false;
            // 
            // LTituloInformeAdmin
            // 
            this.LTituloInformeAdmin.AutoSize = true;
            this.LTituloInformeAdmin.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloInformeAdmin.Location = new System.Drawing.Point(80, 13);
            this.LTituloInformeAdmin.Name = "LTituloInformeAdmin";
            this.LTituloInformeAdmin.Size = new System.Drawing.Size(305, 36);
            this.LTituloInformeAdmin.TabIndex = 32;
            this.LTituloInformeAdmin.Text = "Informes Estadisticos";
            this.LTituloInformeAdmin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.Control;
            this.chart1.BorderlineColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(479, 142);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(396, 288);
            this.chart1.TabIndex = 33;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.SystemColors.Control;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(12, 142);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(396, 288);
            this.chart2.TabIndex = 34;
            this.chart2.Text = "chart2";
            // 
            // LMarcasVendidas
            // 
            this.LMarcasVendidas.AutoSize = true;
            this.LMarcasVendidas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LMarcasVendidas.Location = new System.Drawing.Point(475, 116);
            this.LMarcasVendidas.Name = "LMarcasVendidas";
            this.LMarcasVendidas.Size = new System.Drawing.Size(206, 23);
            this.LMarcasVendidas.TabIndex = 35;
            this.LMarcasVendidas.Text = "Marca mas vendidas";
            // 
            // LVentaMes
            // 
            this.LVentaMes.AutoSize = true;
            this.LVentaMes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVentaMes.Location = new System.Drawing.Point(12, 116);
            this.LVentaMes.Name = "LVentaMes";
            this.LVentaMes.Size = new System.Drawing.Size(116, 23);
            this.LVentaMes.TabIndex = 36;
            this.LVentaMes.Text = "Ventas mes";
            // 
            // InformesAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(887, 507);
            this.Controls.Add(this.LVentaMes);
            this.Controls.Add(this.LMarcasVendidas);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.LTituloInformeAdmin);
            this.Controls.Add(this.PBImagenInformeAdmin);
            this.Name = "InformesAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InformesAdministrador";
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenInformeAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBImagenInformeAdmin;
        private System.Windows.Forms.Label LTituloInformeAdmin;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label LMarcasVendidas;
        private System.Windows.Forms.Label LVentaMes;
    }
}