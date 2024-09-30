namespace ProyectoTaller.Views.Gerentes
{
    partial class ReporteProductos
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
            this.LTituloReporteProductos = new System.Windows.Forms.Label();
            this.PBImagenReporteProductos = new System.Windows.Forms.PictureBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CBMarca = new System.Windows.Forms.ComboBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CBMarcaProductoReporte = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenReporteProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // LTituloReporteProductos
            // 
            this.LTituloReporteProductos.AutoSize = true;
            this.LTituloReporteProductos.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloReporteProductos.Location = new System.Drawing.Point(79, 14);
            this.LTituloReporteProductos.Name = "LTituloReporteProductos";
            this.LTituloReporteProductos.Size = new System.Drawing.Size(274, 36);
            this.LTituloReporteProductos.TabIndex = 35;
            this.LTituloReporteProductos.Text = "Reporte Productos";
            // 
            // PBImagenReporteProductos
            // 
            this.PBImagenReporteProductos.Image = global::ProyectoTaller.Properties.Resources.CelularesTitulo;
            this.PBImagenReporteProductos.Location = new System.Drawing.Point(12, 12);
            this.PBImagenReporteProductos.Name = "PBImagenReporteProductos";
            this.PBImagenReporteProductos.Size = new System.Drawing.Size(65, 67);
            this.PBImagenReporteProductos.TabIndex = 34;
            this.PBImagenReporteProductos.TabStop = false;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(51, 135);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(254, 244);
            this.chart1.TabIndex = 36;
            this.chart1.Text = "chart1";
            // 
            // CBMarca
            // 
            this.CBMarca.FormattingEnabled = true;
            this.CBMarca.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.CBMarca.Location = new System.Drawing.Point(86, 385);
            this.CBMarca.Name = "CBMarca";
            this.CBMarca.Size = new System.Drawing.Size(177, 21);
            this.CBMarca.TabIndex = 74;
            this.CBMarca.Text = "Seleccione el Mes";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(340, 135);
            this.chart2.Margin = new System.Windows.Forms.Padding(2);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "VentasMensuales";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(483, 244);
            this.chart2.TabIndex = 75;
            this.chart2.Text = "chart2";
            // 
            // CBMarcaProductoReporte
            // 
            this.CBMarcaProductoReporte.FormattingEnabled = true;
            this.CBMarcaProductoReporte.Items.AddRange(new object[] {
            "Ventas Totales",
            "Samsung",
            "Motorola",
            "Apple",
            "Xiaomi",
            "Huawei"});
            this.CBMarcaProductoReporte.Location = new System.Drawing.Point(502, 385);
            this.CBMarcaProductoReporte.Name = "CBMarcaProductoReporte";
            this.CBMarcaProductoReporte.Size = new System.Drawing.Size(177, 21);
            this.CBMarcaProductoReporte.TabIndex = 76;
            this.CBMarcaProductoReporte.Text = "Seleccione una opción";
            // 
            // ReporteProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(887, 507);
            this.Controls.Add(this.CBMarcaProductoReporte);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.CBMarca);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.LTituloReporteProductos);
            this.Controls.Add(this.PBImagenReporteProductos);
            this.Name = "ReporteProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteProductos";
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenReporteProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LTituloReporteProductos;
        private System.Windows.Forms.PictureBox PBImagenReporteProductos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox CBMarca;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.ComboBox CBMarcaProductoReporte;
    }
}