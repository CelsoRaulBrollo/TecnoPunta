namespace ProyectoTaller.Views.Gerentes
{
    partial class ReporteVentas
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
            this.LTituloInformeGerente = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PBImagenReporteVentas = new System.Windows.Forms.PictureBox();
            this.CAAnualReporteVentas = new System.Windows.Forms.CheckBox();
            this.CAMensualReporteVentas = new System.Windows.Forms.CheckBox();
            this.CADiarioReporteVentas = new System.Windows.Forms.CheckBox();
            this.CBOXMensualReporteVentas = new System.Windows.Forms.ComboBox();
            this.CBOXAnualReporteVentas = new System.Windows.Forms.ComboBox();
            this.DTMDesdeReporteDeVentas = new System.Windows.Forms.DateTimePicker();
            this.DTMHastaReporteDeVentas = new System.Windows.Forms.DateTimePicker();
            this.LDesdeReporteDeVentas = new System.Windows.Forms.Label();
            this.LHastaReporteDeVentas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenReporteVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // LTituloInformeGerente
            // 
            this.LTituloInformeGerente.AutoSize = true;
            this.LTituloInformeGerente.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloInformeGerente.Location = new System.Drawing.Point(105, 17);
            this.LTituloInformeGerente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTituloInformeGerente.Name = "LTituloInformeGerente";
            this.LTituloInformeGerente.Size = new System.Drawing.Size(292, 44);
            this.LTituloInformeGerente.TabIndex = 32;
            this.LTituloInformeGerente.Text = "Reporte Ventas";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(36, 158);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Ventas";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(547, 300);
            this.chart1.TabIndex = 33;
            this.chart1.Text = "chart1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(205, 132);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 23);
            this.label7.TabIndex = 67;
            this.label7.Text = "Ventas Realizadas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(771, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 68;
            this.label1.Text = "Recaudacion";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(599, 158);
            this.chart2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Ventas";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(547, 300);
            this.chart2.TabIndex = 69;
            this.chart2.Text = "chart2";
            // 
            // PBImagenReporteVentas
            // 
            this.PBImagenReporteVentas.Image = global::ProyectoTaller.Properties.Resources.VentasTitulo;
            this.PBImagenReporteVentas.Location = new System.Drawing.Point(13, 14);
            this.PBImagenReporteVentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PBImagenReporteVentas.Name = "PBImagenReporteVentas";
            this.PBImagenReporteVentas.Size = new System.Drawing.Size(87, 82);
            this.PBImagenReporteVentas.TabIndex = 70;
            this.PBImagenReporteVentas.TabStop = false;
            // 
            // CAAnualReporteVentas
            // 
            this.CAAnualReporteVentas.AutoSize = true;
            this.CAAnualReporteVentas.Location = new System.Drawing.Point(215, 521);
            this.CAAnualReporteVentas.Name = "CAAnualReporteVentas";
            this.CAAnualReporteVentas.Size = new System.Drawing.Size(63, 20);
            this.CAAnualReporteVentas.TabIndex = 71;
            this.CAAnualReporteVentas.Text = "Anual";
            this.CAAnualReporteVentas.UseVisualStyleBackColor = true;
            this.CAAnualReporteVentas.CheckedChanged += new System.EventHandler(this.CAAnualReporteVentas_CheckedChanged);
            // 
            // CAMensualReporteVentas
            // 
            this.CAMensualReporteVentas.AutoSize = true;
            this.CAMensualReporteVentas.Location = new System.Drawing.Point(465, 521);
            this.CAMensualReporteVentas.Name = "CAMensualReporteVentas";
            this.CAMensualReporteVentas.Size = new System.Drawing.Size(80, 20);
            this.CAMensualReporteVentas.TabIndex = 72;
            this.CAMensualReporteVentas.Text = "Mensual";
            this.CAMensualReporteVentas.UseVisualStyleBackColor = true;
            this.CAMensualReporteVentas.CheckedChanged += new System.EventHandler(this.CAMensualReporteVentas_CheckedChanged);
            // 
            // CADiarioReporteVentas
            // 
            this.CADiarioReporteVentas.AutoSize = true;
            this.CADiarioReporteVentas.Location = new System.Drawing.Point(723, 521);
            this.CADiarioReporteVentas.Name = "CADiarioReporteVentas";
            this.CADiarioReporteVentas.Size = new System.Drawing.Size(65, 20);
            this.CADiarioReporteVentas.TabIndex = 73;
            this.CADiarioReporteVentas.Text = "Diario";
            this.CADiarioReporteVentas.UseVisualStyleBackColor = true;
            this.CADiarioReporteVentas.CheckedChanged += new System.EventHandler(this.CADiarioReporteVentas_CheckedChanged);
            // 
            // CBOXMensualReporteVentas
            // 
            this.CBOXMensualReporteVentas.FormattingEnabled = true;
            this.CBOXMensualReporteVentas.Items.AddRange(new object[] {
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
            this.CBOXMensualReporteVentas.Location = new System.Drawing.Point(551, 517);
            this.CBOXMensualReporteVentas.Name = "CBOXMensualReporteVentas";
            this.CBOXMensualReporteVentas.Size = new System.Drawing.Size(145, 24);
            this.CBOXMensualReporteVentas.TabIndex = 74;
            this.CBOXMensualReporteVentas.Text = "Seleccione un mes";
            // 
            // CBOXAnualReporteVentas
            // 
            this.CBOXAnualReporteVentas.FormattingEnabled = true;
            this.CBOXAnualReporteVentas.Location = new System.Drawing.Point(284, 517);
            this.CBOXAnualReporteVentas.Name = "CBOXAnualReporteVentas";
            this.CBOXAnualReporteVentas.Size = new System.Drawing.Size(145, 24);
            this.CBOXAnualReporteVentas.TabIndex = 75;
            this.CBOXAnualReporteVentas.Text = "Seleccione el Año";
            // 
            // DTMDesdeReporteDeVentas
            // 
            this.DTMDesdeReporteDeVentas.Location = new System.Drawing.Point(798, 493);
            this.DTMDesdeReporteDeVentas.Name = "DTMDesdeReporteDeVentas";
            this.DTMDesdeReporteDeVentas.Size = new System.Drawing.Size(200, 22);
            this.DTMDesdeReporteDeVentas.TabIndex = 76;
            // 
            // DTMHastaReporteDeVentas
            // 
            this.DTMHastaReporteDeVentas.Location = new System.Drawing.Point(798, 547);
            this.DTMHastaReporteDeVentas.Name = "DTMHastaReporteDeVentas";
            this.DTMHastaReporteDeVentas.Size = new System.Drawing.Size(200, 22);
            this.DTMHastaReporteDeVentas.TabIndex = 77;
            // 
            // LDesdeReporteDeVentas
            // 
            this.LDesdeReporteDeVentas.AutoSize = true;
            this.LDesdeReporteDeVentas.Location = new System.Drawing.Point(878, 474);
            this.LDesdeReporteDeVentas.Name = "LDesdeReporteDeVentas";
            this.LDesdeReporteDeVentas.Size = new System.Drawing.Size(48, 16);
            this.LDesdeReporteDeVentas.TabIndex = 78;
            this.LDesdeReporteDeVentas.Text = "Desde";
            // 
            // LHastaReporteDeVentas
            // 
            this.LHastaReporteDeVentas.AutoSize = true;
            this.LHastaReporteDeVentas.Location = new System.Drawing.Point(878, 528);
            this.LHastaReporteDeVentas.Name = "LHastaReporteDeVentas";
            this.LHastaReporteDeVentas.Size = new System.Drawing.Size(43, 16);
            this.LHastaReporteDeVentas.TabIndex = 79;
            this.LHastaReporteDeVentas.Text = "Hasta";
            // 
            // ReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1183, 624);
            this.Controls.Add(this.LHastaReporteDeVentas);
            this.Controls.Add(this.LDesdeReporteDeVentas);
            this.Controls.Add(this.DTMHastaReporteDeVentas);
            this.Controls.Add(this.DTMDesdeReporteDeVentas);
            this.Controls.Add(this.CBOXAnualReporteVentas);
            this.Controls.Add(this.CBOXMensualReporteVentas);
            this.Controls.Add(this.CADiarioReporteVentas);
            this.Controls.Add(this.CAMensualReporteVentas);
            this.Controls.Add(this.CAAnualReporteVentas);
            this.Controls.Add(this.PBImagenReporteVentas);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.LTituloInformeGerente);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReporteVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InformesGerente";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenReporteVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LTituloInformeGerente;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.PictureBox PBImagenReporteVentas;
        private System.Windows.Forms.CheckBox CAAnualReporteVentas;
        private System.Windows.Forms.CheckBox CAMensualReporteVentas;
        private System.Windows.Forms.CheckBox CADiarioReporteVentas;
        private System.Windows.Forms.ComboBox CBOXMensualReporteVentas;
        private System.Windows.Forms.ComboBox CBOXAnualReporteVentas;
        private System.Windows.Forms.DateTimePicker DTMDesdeReporteDeVentas;
        private System.Windows.Forms.DateTimePicker DTMHastaReporteDeVentas;
        private System.Windows.Forms.Label LDesdeReporteDeVentas;
        private System.Windows.Forms.Label LHastaReporteDeVentas;
    }
}