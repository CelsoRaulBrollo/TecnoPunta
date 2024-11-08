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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.LTituloInformeGerente = new System.Windows.Forms.Label();
            this.CHVentasRealizadas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CHRecaudacion = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PBImagenReporteVentas = new System.Windows.Forms.PictureBox();
            this.CAAnualReporteVentas = new System.Windows.Forms.CheckBox();
            this.CAMensualReporteVentas = new System.Windows.Forms.CheckBox();
            this.CADiarioReporteVentas = new System.Windows.Forms.CheckBox();
            this.DTMDesdeReporteDeVentas = new System.Windows.Forms.DateTimePicker();
            this.DTMHastaReporteDeVentas = new System.Windows.Forms.DateTimePicker();
            this.LDesdeReporteDeVentas = new System.Windows.Forms.Label();
            this.LHastaReporteDeVentas = new System.Windows.Forms.Label();
            this.BReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CHVentasRealizadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHRecaudacion)).BeginInit();
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
            // CHVentasRealizadas
            // 
            chartArea3.Name = "ChartArea1";
            this.CHVentasRealizadas.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.CHVentasRealizadas.Legends.Add(legend3);
            this.CHVentasRealizadas.Location = new System.Drawing.Point(36, 158);
            this.CHVentasRealizadas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CHVentasRealizadas.Name = "CHVentasRealizadas";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Ventas";
            this.CHVentasRealizadas.Series.Add(series3);
            this.CHVentasRealizadas.Size = new System.Drawing.Size(547, 300);
            this.CHVentasRealizadas.TabIndex = 33;
            this.CHVentasRealizadas.Text = "chart1";
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
            // CHRecaudacion
            // 
            chartArea4.Name = "ChartArea1";
            this.CHRecaudacion.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.CHRecaudacion.Legends.Add(legend4);
            this.CHRecaudacion.Location = new System.Drawing.Point(599, 158);
            this.CHRecaudacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CHRecaudacion.Name = "CHRecaudacion";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Ventas";
            this.CHRecaudacion.Series.Add(series4);
            this.CHRecaudacion.Size = new System.Drawing.Size(547, 300);
            this.CHRecaudacion.TabIndex = 69;
            // 
            // PBImagenReporteVentas
            // 
            this.PBImagenReporteVentas.Image = global::ProyectoTaller.Properties.Resources.VentasTitulo;
            this.PBImagenReporteVentas.Location = new System.Drawing.Point(13, 14);
            this.PBImagenReporteVentas.Margin = new System.Windows.Forms.Padding(4);
            this.PBImagenReporteVentas.Name = "PBImagenReporteVentas";
            this.PBImagenReporteVentas.Size = new System.Drawing.Size(87, 82);
            this.PBImagenReporteVentas.TabIndex = 70;
            this.PBImagenReporteVentas.TabStop = false;
            // 
            // CAAnualReporteVentas
            // 
            this.CAAnualReporteVentas.AutoSize = true;
            this.CAAnualReporteVentas.Location = new System.Drawing.Point(470, 560);
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
            this.CAMensualReporteVentas.Location = new System.Drawing.Point(558, 560);
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
            this.CADiarioReporteVentas.Location = new System.Drawing.Point(661, 560);
            this.CADiarioReporteVentas.Name = "CADiarioReporteVentas";
            this.CADiarioReporteVentas.Size = new System.Drawing.Size(65, 20);
            this.CADiarioReporteVentas.TabIndex = 73;
            this.CADiarioReporteVentas.Text = "Diario";
            this.CADiarioReporteVentas.UseVisualStyleBackColor = true;
            this.CADiarioReporteVentas.CheckedChanged += new System.EventHandler(this.CADiarioReporteVentas_CheckedChanged);
            // 
            // DTMDesdeReporteDeVentas
            // 
            this.DTMDesdeReporteDeVentas.Location = new System.Drawing.Point(370, 514);
            this.DTMDesdeReporteDeVentas.Name = "DTMDesdeReporteDeVentas";
            this.DTMDesdeReporteDeVentas.Size = new System.Drawing.Size(200, 22);
            this.DTMDesdeReporteDeVentas.TabIndex = 76;
            this.DTMDesdeReporteDeVentas.Value = new System.DateTime(2024, 1, 1, 23, 45, 0, 0);
            // 
            // DTMHastaReporteDeVentas
            // 
            this.DTMHastaReporteDeVentas.Location = new System.Drawing.Point(614, 514);
            this.DTMHastaReporteDeVentas.Name = "DTMHastaReporteDeVentas";
            this.DTMHastaReporteDeVentas.Size = new System.Drawing.Size(200, 22);
            this.DTMHastaReporteDeVentas.TabIndex = 77;
            this.DTMHastaReporteDeVentas.Value = new System.DateTime(2024, 11, 8, 0, 0, 0, 0);
            // 
            // LDesdeReporteDeVentas
            // 
            this.LDesdeReporteDeVentas.AutoSize = true;
            this.LDesdeReporteDeVentas.Location = new System.Drawing.Point(440, 484);
            this.LDesdeReporteDeVentas.Name = "LDesdeReporteDeVentas";
            this.LDesdeReporteDeVentas.Size = new System.Drawing.Size(48, 16);
            this.LDesdeReporteDeVentas.TabIndex = 78;
            this.LDesdeReporteDeVentas.Text = "Desde";
            // 
            // LHastaReporteDeVentas
            // 
            this.LHastaReporteDeVentas.AutoSize = true;
            this.LHastaReporteDeVentas.Location = new System.Drawing.Point(688, 484);
            this.LHastaReporteDeVentas.Name = "LHastaReporteDeVentas";
            this.LHastaReporteDeVentas.Size = new System.Drawing.Size(43, 16);
            this.LHastaReporteDeVentas.TabIndex = 79;
            this.LHastaReporteDeVentas.Text = "Hasta";
            this.LHastaReporteDeVentas.Click += new System.EventHandler(this.LHastaReporteDeVentas_Click);
            // 
            // BReset
            // 
            this.BReset.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BReset.Image = global::ProyectoTaller.Properties.Resources.buscar;
            this.BReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BReset.Location = new System.Drawing.Point(916, 494);
            this.BReset.Margin = new System.Windows.Forms.Padding(4);
            this.BReset.Name = "BReset";
            this.BReset.Size = new System.Drawing.Size(133, 60);
            this.BReset.TabIndex = 80;
            this.BReset.Text = "   Reset      ";
            this.BReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BReset.UseVisualStyleBackColor = true;
            // 
            // ReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1183, 624);
            this.Controls.Add(this.BReset);
            this.Controls.Add(this.LHastaReporteDeVentas);
            this.Controls.Add(this.LDesdeReporteDeVentas);
            this.Controls.Add(this.DTMHastaReporteDeVentas);
            this.Controls.Add(this.DTMDesdeReporteDeVentas);
            this.Controls.Add(this.CADiarioReporteVentas);
            this.Controls.Add(this.CAMensualReporteVentas);
            this.Controls.Add(this.CAAnualReporteVentas);
            this.Controls.Add(this.PBImagenReporteVentas);
            this.Controls.Add(this.CHRecaudacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CHVentasRealizadas);
            this.Controls.Add(this.LTituloInformeGerente);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReporteVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InformesGerente";
            ((System.ComponentModel.ISupportInitialize)(this.CHVentasRealizadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHRecaudacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenReporteVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LTituloInformeGerente;
        private System.Windows.Forms.DataVisualization.Charting.Chart CHVentasRealizadas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart CHRecaudacion;
        private System.Windows.Forms.PictureBox PBImagenReporteVentas;
        private System.Windows.Forms.CheckBox CAAnualReporteVentas;
        private System.Windows.Forms.CheckBox CAMensualReporteVentas;
        private System.Windows.Forms.CheckBox CADiarioReporteVentas;
        private System.Windows.Forms.DateTimePicker DTMDesdeReporteDeVentas;
        private System.Windows.Forms.DateTimePicker DTMHastaReporteDeVentas;
        private System.Windows.Forms.Label LDesdeReporteDeVentas;
        private System.Windows.Forms.Label LHastaReporteDeVentas;
        private System.Windows.Forms.Button BReset;
    }
}