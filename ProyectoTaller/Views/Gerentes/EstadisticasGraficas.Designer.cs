namespace ProyectoTaller.Views.Gerentes
{
    partial class EstadisticasGraficas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.LTituloEstadisticas = new System.Windows.Forms.Label();
            this.PBImagenEstadisticas = new System.Windows.Forms.PictureBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LTelefonosStock = new System.Windows.Forms.Label();
            this.LMarcasValoradas = new System.Windows.Forms.Label();
            this.LMesesVentas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenEstadisticas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.SuspendLayout();
            // 
            // LTituloEstadisticas
            // 
            this.LTituloEstadisticas.AutoSize = true;
            this.LTituloEstadisticas.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloEstadisticas.Location = new System.Drawing.Point(80, 13);
            this.LTituloEstadisticas.Name = "LTituloEstadisticas";
            this.LTituloEstadisticas.Size = new System.Drawing.Size(177, 36);
            this.LTituloEstadisticas.TabIndex = 30;
            this.LTituloEstadisticas.Text = "Estadisticas";
            // 
            // PBImagenEstadisticas
            // 
            this.PBImagenEstadisticas.Image = global::ProyectoTaller.Properties.Resources.Estadisticas;
            this.PBImagenEstadisticas.Location = new System.Drawing.Point(12, 12);
            this.PBImagenEstadisticas.Name = "PBImagenEstadisticas";
            this.PBImagenEstadisticas.Size = new System.Drawing.Size(65, 67);
            this.PBImagenEstadisticas.TabIndex = 29;
            this.PBImagenEstadisticas.TabStop = false;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(105, 89);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(293, 189);
            this.chart1.TabIndex = 31;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(12, 328);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(863, 167);
            this.chart2.TabIndex = 32;
            this.chart2.Text = "chart2";
            // 
            // chart3
            // 
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(506, 89);
            this.chart3.Name = "chart3";
            this.chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart3.Series.Add(series3);
            this.chart3.Size = new System.Drawing.Size(293, 189);
            this.chart3.TabIndex = 33;
            this.chart3.Text = "chart3";
            // 
            // LTelefonosStock
            // 
            this.LTelefonosStock.AutoSize = true;
            this.LTelefonosStock.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTelefonosStock.Location = new System.Drawing.Point(101, 63);
            this.LTelefonosStock.Name = "LTelefonosStock";
            this.LTelefonosStock.Size = new System.Drawing.Size(177, 23);
            this.LTelefonosStock.TabIndex = 36;
            this.LTelefonosStock.Text = "Telefonos en stock";
            // 
            // LMarcasValoradas
            // 
            this.LMarcasValoradas.AutoSize = true;
            this.LMarcasValoradas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LMarcasValoradas.Location = new System.Drawing.Point(502, 63);
            this.LMarcasValoradas.Name = "LMarcasValoradas";
            this.LMarcasValoradas.Size = new System.Drawing.Size(178, 23);
            this.LMarcasValoradas.TabIndex = 37;
            this.LMarcasValoradas.Text = "Marcas valoradas";
            // 
            // LMesesVentas
            // 
            this.LMesesVentas.AutoSize = true;
            this.LMesesVentas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LMesesVentas.Location = new System.Drawing.Point(366, 302);
            this.LMesesVentas.Name = "LMesesVentas";
            this.LMesesVentas.Size = new System.Drawing.Size(164, 23);
            this.LMesesVentas.TabIndex = 38;
            this.LMesesVentas.Text = "Ventas en meses";
            // 
            // EstadisticasGraficas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(887, 507);
            this.Controls.Add(this.LMesesVentas);
            this.Controls.Add(this.LMarcasValoradas);
            this.Controls.Add(this.LTelefonosStock);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.LTituloEstadisticas);
            this.Controls.Add(this.PBImagenEstadisticas);
            this.Name = "EstadisticasGraficas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EstadisticasGraficas";
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenEstadisticas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBImagenEstadisticas;
        private System.Windows.Forms.Label LTituloEstadisticas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.Label LTelefonosStock;
        private System.Windows.Forms.Label LMarcasValoradas;
        private System.Windows.Forms.Label LMesesVentas;
    }
}