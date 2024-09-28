namespace ProyectoTaller.Views.Gerentes
{
    partial class ReporteClientes
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.PBImagenReporteCliente = new System.Windows.Forms.PictureBox();
            this.LTituloReporteCliente = new System.Windows.Forms.Label();
            this.CBNuevoClientes = new System.Windows.Forms.ComboBox();
            this.ChartNuevosClientes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CBGeneroReporte = new System.Windows.Forms.ComboBox();
            this.ChartGeneroCliente = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenReporteCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartNuevosClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartGeneroCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // PBImagenReporteCliente
            // 
            this.PBImagenReporteCliente.Image = global::ProyectoTaller.Properties.Resources.NuevoCliente;
            this.PBImagenReporteCliente.Location = new System.Drawing.Point(16, 15);
            this.PBImagenReporteCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PBImagenReporteCliente.Name = "PBImagenReporteCliente";
            this.PBImagenReporteCliente.Size = new System.Drawing.Size(87, 82);
            this.PBImagenReporteCliente.TabIndex = 32;
            this.PBImagenReporteCliente.TabStop = false;
            // 
            // LTituloReporteCliente
            // 
            this.LTituloReporteCliente.AutoSize = true;
            this.LTituloReporteCliente.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloReporteCliente.Location = new System.Drawing.Point(105, 17);
            this.LTituloReporteCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTituloReporteCliente.Name = "LTituloReporteCliente";
            this.LTituloReporteCliente.Size = new System.Drawing.Size(297, 44);
            this.LTituloReporteCliente.TabIndex = 33;
            this.LTituloReporteCliente.Text = "Reporte Cliente";
            // 
            // CBNuevoClientes
            // 
            this.CBNuevoClientes.FormattingEnabled = true;
            this.CBNuevoClientes.Items.AddRange(new object[] {
            ""});
            this.CBNuevoClientes.Location = new System.Drawing.Point(179, 426);
            this.CBNuevoClientes.Margin = new System.Windows.Forms.Padding(4);
            this.CBNuevoClientes.Name = "CBNuevoClientes";
            this.CBNuevoClientes.Size = new System.Drawing.Size(208, 24);
            this.CBNuevoClientes.TabIndex = 78;
            this.CBNuevoClientes.SelectedIndexChanged += new System.EventHandler(this.CBNuevoClientes_SelectedIndexChanged_1);
            // 
            // ChartNuevosClientes
            // 
            chartArea5.Name = "ChartArea1";
            this.ChartNuevosClientes.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.ChartNuevosClientes.Legends.Add(legend5);
            this.ChartNuevosClientes.Location = new System.Drawing.Point(72, 133);
            this.ChartNuevosClientes.Name = "ChartNuevosClientes";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "VentasMensuales";
            this.ChartNuevosClientes.Series.Add(series5);
            this.ChartNuevosClientes.Size = new System.Drawing.Size(494, 286);
            this.ChartNuevosClientes.TabIndex = 77;
            this.ChartNuevosClientes.Text = "chart2";
            // 
            // CBGeneroReporte
            // 
            this.CBGeneroReporte.FormattingEnabled = true;
            this.CBGeneroReporte.Items.AddRange(new object[] {
            ""});
            this.CBGeneroReporte.Location = new System.Drawing.Point(798, 426);
            this.CBGeneroReporte.Margin = new System.Windows.Forms.Padding(4);
            this.CBGeneroReporte.Name = "CBGeneroReporte";
            this.CBGeneroReporte.Size = new System.Drawing.Size(218, 24);
            this.CBGeneroReporte.TabIndex = 80;
            // 
            // ChartGeneroCliente
            // 
            chartArea6.Name = "ChartArea1";
            this.ChartGeneroCliente.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.ChartGeneroCliente.Legends.Add(legend6);
            this.ChartGeneroCliente.Location = new System.Drawing.Point(652, 133);
            this.ChartGeneroCliente.Name = "ChartGeneroCliente";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "VentasMensuales";
            this.ChartGeneroCliente.Series.Add(series6);
            this.ChartGeneroCliente.Size = new System.Drawing.Size(494, 286);
            this.ChartGeneroCliente.TabIndex = 79;
            this.ChartGeneroCliente.Text = "ChartGenero";
            // 
            // ReporteClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1183, 624);
            this.Controls.Add(this.CBGeneroReporte);
            this.Controls.Add(this.ChartGeneroCliente);
            this.Controls.Add(this.CBNuevoClientes);
            this.Controls.Add(this.ChartNuevosClientes);
            this.Controls.Add(this.LTituloReporteCliente);
            this.Controls.Add(this.PBImagenReporteCliente);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReporteClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteClientes";
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenReporteCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartNuevosClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartGeneroCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBImagenReporteCliente;
        private System.Windows.Forms.Label LTituloReporteCliente;
        private System.Windows.Forms.ComboBox CBNuevoClientes;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartNuevosClientes;
        private System.Windows.Forms.ComboBox CBGeneroReporte;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartGeneroCliente;
    }
}