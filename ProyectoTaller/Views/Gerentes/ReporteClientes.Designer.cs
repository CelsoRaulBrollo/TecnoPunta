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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.PBImagenReporteCliente = new System.Windows.Forms.PictureBox();
            this.LTituloReporteCliente = new System.Windows.Forms.Label();
            this.CBNuevoClientes = new System.Windows.Forms.ComboBox();
            this.ChartReporteClientes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CBAÑOS = new System.Windows.Forms.ComboBox();
            this.LBReporteCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenReporteCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartReporteClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // PBImagenReporteCliente
            // 
            this.PBImagenReporteCliente.Image = global::ProyectoTaller.Properties.Resources.NuevoCliente;
            this.PBImagenReporteCliente.Location = new System.Drawing.Point(16, 15);
            this.PBImagenReporteCliente.Margin = new System.Windows.Forms.Padding(4);
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
            this.CBNuevoClientes.Location = new System.Drawing.Point(625, 502);
            this.CBNuevoClientes.Margin = new System.Windows.Forms.Padding(4);
            this.CBNuevoClientes.Name = "CBNuevoClientes";
            this.CBNuevoClientes.Size = new System.Drawing.Size(208, 24);
            this.CBNuevoClientes.TabIndex = 78;
            this.CBNuevoClientes.Text = "Seleccione una opción";
            this.CBNuevoClientes.SelectedIndexChanged += new System.EventHandler(this.CBNuevoClientes_SelectedIndexChanged_1);
            // 
            // ChartReporteClientes
            // 
            chartArea2.Name = "ChartArea1";
            this.ChartReporteClientes.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ChartReporteClientes.Legends.Add(legend2);
            this.ChartReporteClientes.Location = new System.Drawing.Point(81, 150);
            this.ChartReporteClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChartReporteClientes.Name = "ChartReporteClientes";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "VentasMensuales";
            this.ChartReporteClientes.Series.Add(series2);
            this.ChartReporteClientes.Size = new System.Drawing.Size(1056, 326);
            this.ChartReporteClientes.TabIndex = 77;
            this.ChartReporteClientes.Text = "chart2";
            // 
            // CBAÑOS
            // 
            this.CBAÑOS.FormattingEnabled = true;
            this.CBAÑOS.Items.AddRange(new object[] {
            ""});
            this.CBAÑOS.Location = new System.Drawing.Point(343, 502);
            this.CBAÑOS.Margin = new System.Windows.Forms.Padding(4);
            this.CBAÑOS.Name = "CBAÑOS";
            this.CBAÑOS.Size = new System.Drawing.Size(208, 24);
            this.CBAÑOS.TabIndex = 85;
            this.CBAÑOS.Text = "Seleccione una opción";
            // 
            // LBReporteCliente
            // 
            this.LBReporteCliente.AutoSize = true;
            this.LBReporteCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBReporteCliente.Location = new System.Drawing.Point(178, 107);
            this.LBReporteCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBReporteCliente.Name = "LBReporteCliente";
            this.LBReporteCliente.Size = new System.Drawing.Size(80, 23);
            this.LBReporteCliente.TabIndex = 100;
            this.LBReporteCliente.Text = "Cliente";
            // 
            // ReporteClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1183, 624);
            this.Controls.Add(this.LBReporteCliente);
            this.Controls.Add(this.CBAÑOS);
            this.Controls.Add(this.CBNuevoClientes);
            this.Controls.Add(this.ChartReporteClientes);
            this.Controls.Add(this.LTituloReporteCliente);
            this.Controls.Add(this.PBImagenReporteCliente);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReporteClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteClientes";
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenReporteCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartReporteClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBImagenReporteCliente;
        private System.Windows.Forms.Label LTituloReporteCliente;
        private System.Windows.Forms.ComboBox CBNuevoClientes;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartReporteClientes;
        private System.Windows.Forms.ComboBox CBAÑOS;
        private System.Windows.Forms.Label LBReporteCliente;
    }
}