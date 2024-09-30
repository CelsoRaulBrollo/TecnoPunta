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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.LTituloStock = new System.Windows.Forms.Label();
            this.ChartTelefonosStock = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LTelefonosStock = new System.Windows.Forms.Label();
            this.PBImagenEstadisticas = new System.Windows.Forms.PictureBox();
            this.ChartEvolucionDelStock = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LEvoluciondelStock = new System.Windows.Forms.Label();
            this.CBOXEvolucionDelStock = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ChartTelefonosStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenEstadisticas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartEvolucionDelStock)).BeginInit();
            this.SuspendLayout();
            // 
            // LTituloStock
            // 
            this.LTituloStock.AutoSize = true;
            this.LTituloStock.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloStock.Location = new System.Drawing.Point(107, 16);
            this.LTituloStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTituloStock.Name = "LTituloStock";
            this.LTituloStock.Size = new System.Drawing.Size(118, 44);
            this.LTituloStock.TabIndex = 30;
            this.LTituloStock.Text = "Stock";
            // 
            // ChartTelefonosStock
            // 
            this.ChartTelefonosStock.BackColor = System.Drawing.SystemColors.ButtonFace;
            chartArea3.Name = "ChartArea1";
            this.ChartTelefonosStock.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.ChartTelefonosStock.Legends.Add(legend3);
            this.ChartTelefonosStock.Location = new System.Drawing.Point(97, 148);
            this.ChartTelefonosStock.Margin = new System.Windows.Forms.Padding(4);
            this.ChartTelefonosStock.Name = "ChartTelefonosStock";
            this.ChartTelefonosStock.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.ChartTelefonosStock.Series.Add(series3);
            this.ChartTelefonosStock.Size = new System.Drawing.Size(391, 322);
            this.ChartTelefonosStock.TabIndex = 31;
            this.ChartTelefonosStock.Text = "chart1";
            // 
            // LTelefonosStock
            // 
            this.LTelefonosStock.AutoSize = true;
            this.LTelefonosStock.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTelefonosStock.Location = new System.Drawing.Point(180, 116);
            this.LTelefonosStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTelefonosStock.Name = "LTelefonosStock";
            this.LTelefonosStock.Size = new System.Drawing.Size(225, 28);
            this.LTelefonosStock.TabIndex = 36;
            this.LTelefonosStock.Text = "Telefonos en stock";
            // 
            // PBImagenEstadisticas
            // 
            this.PBImagenEstadisticas.Image = global::ProyectoTaller.Properties.Resources.Estadisticas;
            this.PBImagenEstadisticas.Location = new System.Drawing.Point(16, 15);
            this.PBImagenEstadisticas.Margin = new System.Windows.Forms.Padding(4);
            this.PBImagenEstadisticas.Name = "PBImagenEstadisticas";
            this.PBImagenEstadisticas.Size = new System.Drawing.Size(87, 82);
            this.PBImagenEstadisticas.TabIndex = 29;
            this.PBImagenEstadisticas.TabStop = false;
            // 
            // ChartEvolucionDelStock
            // 
            chartArea4.Name = "ChartArea1";
            this.ChartEvolucionDelStock.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.ChartEvolucionDelStock.Legends.Add(legend4);
            this.ChartEvolucionDelStock.Location = new System.Drawing.Point(574, 148);
            this.ChartEvolucionDelStock.Name = "ChartEvolucionDelStock";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.ChartEvolucionDelStock.Series.Add(series4);
            this.ChartEvolucionDelStock.Size = new System.Drawing.Size(550, 315);
            this.ChartEvolucionDelStock.TabIndex = 37;
            this.ChartEvolucionDelStock.Text = "chart1";
            // 
            // LEvoluciondelStock
            // 
            this.LEvoluciondelStock.AutoSize = true;
            this.LEvoluciondelStock.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEvoluciondelStock.Location = new System.Drawing.Point(726, 117);
            this.LEvoluciondelStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LEvoluciondelStock.Name = "LEvoluciondelStock";
            this.LEvoluciondelStock.Size = new System.Drawing.Size(236, 28);
            this.LEvoluciondelStock.TabIndex = 38;
            this.LEvoluciondelStock.Text = "Evolucion del Stock";
            // 
            // CBOXEvolucionDelStock
            // 
            this.CBOXEvolucionDelStock.FormattingEnabled = true;
            this.CBOXEvolucionDelStock.Items.AddRange(new object[] {
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
            this.CBOXEvolucionDelStock.Location = new System.Drawing.Point(731, 469);
            this.CBOXEvolucionDelStock.Name = "CBOXEvolucionDelStock";
            this.CBOXEvolucionDelStock.Size = new System.Drawing.Size(247, 24);
            this.CBOXEvolucionDelStock.TabIndex = 39;
            this.CBOXEvolucionDelStock.Text = "Selecciones el Mes";
            // 
            // EstadisticasGraficas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1183, 624);
            this.Controls.Add(this.CBOXEvolucionDelStock);
            this.Controls.Add(this.LEvoluciondelStock);
            this.Controls.Add(this.ChartEvolucionDelStock);
            this.Controls.Add(this.LTelefonosStock);
            this.Controls.Add(this.ChartTelefonosStock);
            this.Controls.Add(this.LTituloStock);
            this.Controls.Add(this.PBImagenEstadisticas);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EstadisticasGraficas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EstadisticasGraficas";
            ((System.ComponentModel.ISupportInitialize)(this.ChartTelefonosStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenEstadisticas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartEvolucionDelStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBImagenEstadisticas;
        private System.Windows.Forms.Label LTituloStock;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartTelefonosStock;
        private System.Windows.Forms.Label LTelefonosStock;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartEvolucionDelStock;
        private System.Windows.Forms.Label LEvoluciondelStock;
        private System.Windows.Forms.ComboBox CBOXEvolucionDelStock;
    }
}