﻿namespace ProyectoTaller.Views.Gerentes
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.PBImagenReporteCliente = new System.Windows.Forms.PictureBox();
            this.LTituloReporteCliente = new System.Windows.Forms.Label();
            this.CBNuevoClientes = new System.Windows.Forms.ComboBox();
            this.ChartReporteClientes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DTPDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DTPHasta = new System.Windows.Forms.DateTimePicker();
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
            this.CBNuevoClientes.Location = new System.Drawing.Point(493, 448);
            this.CBNuevoClientes.Margin = new System.Windows.Forms.Padding(4);
            this.CBNuevoClientes.Name = "CBNuevoClientes";
            this.CBNuevoClientes.Size = new System.Drawing.Size(208, 24);
            this.CBNuevoClientes.TabIndex = 78;
            this.CBNuevoClientes.Text = "Seleccione una opción";
            this.CBNuevoClientes.SelectedIndexChanged += new System.EventHandler(this.CBNuevoClientes_SelectedIndexChanged_1);
            // 
            // ChartReporteClientes
            // 
            chartArea3.Name = "ChartArea1";
            this.ChartReporteClientes.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.ChartReporteClientes.Legends.Add(legend3);
            this.ChartReporteClientes.Location = new System.Drawing.Point(86, 103);
            this.ChartReporteClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChartReporteClientes.Name = "ChartReporteClientes";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "VentasMensuales";
            this.ChartReporteClientes.Series.Add(series3);
            this.ChartReporteClientes.Size = new System.Drawing.Size(1056, 326);
            this.ChartReporteClientes.TabIndex = 77;
            this.ChartReporteClientes.Text = "chart2";
            // 
            // DTPDesde
            // 
            this.DTPDesde.Location = new System.Drawing.Point(350, 514);
            this.DTPDesde.Name = "DTPDesde";
            this.DTPDesde.Size = new System.Drawing.Size(200, 22);
            this.DTPDesde.TabIndex = 81;
            this.DTPDesde.ValueChanged += new System.EventHandler(this.DTPDesde_ValueChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(422, 485);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 82;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(709, 485);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 84;
            this.label2.Text = "Hasta";
            // 
            // DTPHasta
            // 
            this.DTPHasta.Location = new System.Drawing.Point(637, 514);
            this.DTPHasta.Name = "DTPHasta";
            this.DTPHasta.Size = new System.Drawing.Size(200, 22);
            this.DTPHasta.TabIndex = 83;
            this.DTPHasta.ValueChanged += new System.EventHandler(this.DTPHasta_ValueChanged_1);
            // 
            // ReporteClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1183, 624);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DTPHasta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DTPDesde);
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
        private System.Windows.Forms.DateTimePicker DTPDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTPHasta;
    }
}