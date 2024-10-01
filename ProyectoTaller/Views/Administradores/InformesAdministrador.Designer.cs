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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.PBImagenInformeAdmin = new System.Windows.Forms.PictureBox();
            this.LTituloInformeAdmin = new System.Windows.Forms.Label();
            this.CHMarcasVendidas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CHCantidadUsuarios = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LMarcasVendidas = new System.Windows.Forms.Label();
            this.LCantidadUsuarios = new System.Windows.Forms.Label();
            this.LHasta = new System.Windows.Forms.Label();
            this.DTPHastaCantidadUsuarios = new System.Windows.Forms.DateTimePicker();
            this.LDesde = new System.Windows.Forms.Label();
            this.DTPDesdeCantidadUsuarios = new System.Windows.Forms.DateTimePicker();
            this.LHasta1 = new System.Windows.Forms.Label();
            this.DTPHastaMarcas = new System.Windows.Forms.DateTimePicker();
            this.LDesde1 = new System.Windows.Forms.Label();
            this.DTPDesdeMarcas = new System.Windows.Forms.DateTimePicker();
            this.BLimpiarFiltros = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenInformeAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHMarcasVendidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHCantidadUsuarios)).BeginInit();
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
            // CHMarcasVendidas
            // 
            this.CHMarcasVendidas.BackColor = System.Drawing.SystemColors.Control;
            this.CHMarcasVendidas.BorderlineColor = System.Drawing.SystemColors.Control;
            chartArea3.Name = "ChartArea1";
            this.CHMarcasVendidas.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.CHMarcasVendidas.Legends.Add(legend3);
            this.CHMarcasVendidas.Location = new System.Drawing.Point(479, 142);
            this.CHMarcasVendidas.Name = "CHMarcasVendidas";
            this.CHMarcasVendidas.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.CHMarcasVendidas.Series.Add(series3);
            this.CHMarcasVendidas.Size = new System.Drawing.Size(396, 288);
            this.CHMarcasVendidas.TabIndex = 33;
            this.CHMarcasVendidas.Text = "chart1";
            this.CHMarcasVendidas.Click += new System.EventHandler(this.CHMarcasVendidas_Click);
            // 
            // CHCantidadUsuarios
            // 
            this.CHCantidadUsuarios.BackColor = System.Drawing.SystemColors.Control;
            chartArea4.Name = "ChartArea1";
            this.CHCantidadUsuarios.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.CHCantidadUsuarios.Legends.Add(legend4);
            this.CHCantidadUsuarios.Location = new System.Drawing.Point(12, 142);
            this.CHCantidadUsuarios.Name = "CHCantidadUsuarios";
            this.CHCantidadUsuarios.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.CHCantidadUsuarios.Series.Add(series4);
            this.CHCantidadUsuarios.Size = new System.Drawing.Size(396, 288);
            this.CHCantidadUsuarios.TabIndex = 34;
            this.CHCantidadUsuarios.Text = "chart2";
            this.CHCantidadUsuarios.Click += new System.EventHandler(this.CHCantidadUsuarios_Click);
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
            // LCantidadUsuarios
            // 
            this.LCantidadUsuarios.AutoSize = true;
            this.LCantidadUsuarios.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCantidadUsuarios.Location = new System.Drawing.Point(12, 116);
            this.LCantidadUsuarios.Name = "LCantidadUsuarios";
            this.LCantidadUsuarios.Size = new System.Drawing.Size(208, 23);
            this.LCantidadUsuarios.TabIndex = 36;
            this.LCantidadUsuarios.Text = "Cantidad de usuarios";
            // 
            // LHasta
            // 
            this.LHasta.AutoSize = true;
            this.LHasta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LHasta.Location = new System.Drawing.Point(261, 119);
            this.LHasta.Name = "LHasta";
            this.LHasta.Size = new System.Drawing.Size(45, 17);
            this.LHasta.TabIndex = 75;
            this.LHasta.Text = "Hasta";
            // 
            // DTPHastaCantidadUsuarios
            // 
            this.DTPHastaCantidadUsuarios.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPHastaCantidadUsuarios.Location = new System.Drawing.Point(312, 117);
            this.DTPHastaCantidadUsuarios.Name = "DTPHastaCantidadUsuarios";
            this.DTPHastaCantidadUsuarios.Size = new System.Drawing.Size(97, 20);
            this.DTPHastaCantidadUsuarios.TabIndex = 74;
            this.DTPHastaCantidadUsuarios.ValueChanged += new System.EventHandler(this.DTPHastaCantidadUsuarios_ValueChanged);
            // 
            // LDesde
            // 
            this.LDesde.AutoSize = true;
            this.LDesde.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDesde.Location = new System.Drawing.Point(261, 77);
            this.LDesde.Name = "LDesde";
            this.LDesde.Size = new System.Drawing.Size(48, 17);
            this.LDesde.TabIndex = 73;
            this.LDesde.Text = "Desde";
            // 
            // DTPDesdeCantidadUsuarios
            // 
            this.DTPDesdeCantidadUsuarios.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPDesdeCantidadUsuarios.Location = new System.Drawing.Point(312, 76);
            this.DTPDesdeCantidadUsuarios.Name = "DTPDesdeCantidadUsuarios";
            this.DTPDesdeCantidadUsuarios.Size = new System.Drawing.Size(97, 20);
            this.DTPDesdeCantidadUsuarios.TabIndex = 72;
            this.DTPDesdeCantidadUsuarios.ValueChanged += new System.EventHandler(this.DTPDesdeCantidadUsuarios_ValueChanged);
            // 
            // LHasta1
            // 
            this.LHasta1.AutoSize = true;
            this.LHasta1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LHasta1.Location = new System.Drawing.Point(727, 116);
            this.LHasta1.Name = "LHasta1";
            this.LHasta1.Size = new System.Drawing.Size(45, 17);
            this.LHasta1.TabIndex = 80;
            this.LHasta1.Text = "Hasta";
            // 
            // DTPHastaMarcas
            // 
            this.DTPHastaMarcas.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPHastaMarcas.Location = new System.Drawing.Point(778, 114);
            this.DTPHastaMarcas.Name = "DTPHastaMarcas";
            this.DTPHastaMarcas.Size = new System.Drawing.Size(97, 20);
            this.DTPHastaMarcas.TabIndex = 79;
            this.DTPHastaMarcas.ValueChanged += new System.EventHandler(this.DTPHastaMarcas_ValueChanged);
            // 
            // LDesde1
            // 
            this.LDesde1.AutoSize = true;
            this.LDesde1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDesde1.Location = new System.Drawing.Point(727, 74);
            this.LDesde1.Name = "LDesde1";
            this.LDesde1.Size = new System.Drawing.Size(48, 17);
            this.LDesde1.TabIndex = 78;
            this.LDesde1.Text = "Desde";
            // 
            // DTPDesdeMarcas
            // 
            this.DTPDesdeMarcas.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPDesdeMarcas.Location = new System.Drawing.Point(778, 73);
            this.DTPDesdeMarcas.Name = "DTPDesdeMarcas";
            this.DTPDesdeMarcas.Size = new System.Drawing.Size(97, 20);
            this.DTPDesdeMarcas.TabIndex = 77;
            this.DTPDesdeMarcas.ValueChanged += new System.EventHandler(this.DTPDesdeMarcas_ValueChanged);
            // 
            // BLimpiarFiltros
            // 
            this.BLimpiarFiltros.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BLimpiarFiltros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BLimpiarFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLimpiarFiltros.Image = global::ProyectoTaller.Properties.Resources.Limpiar;
            this.BLimpiarFiltros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BLimpiarFiltros.Location = new System.Drawing.Point(377, 443);
            this.BLimpiarFiltros.Name = "BLimpiarFiltros";
            this.BLimpiarFiltros.Size = new System.Drawing.Size(123, 52);
            this.BLimpiarFiltros.TabIndex = 81;
            this.BLimpiarFiltros.Text = "Limpiar Filtros";
            this.BLimpiarFiltros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BLimpiarFiltros.UseVisualStyleBackColor = true;
            this.BLimpiarFiltros.Click += new System.EventHandler(this.BLimpiarFiltros_Click);
            // 
            // InformesAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(887, 507);
            this.Controls.Add(this.BLimpiarFiltros);
            this.Controls.Add(this.LHasta1);
            this.Controls.Add(this.DTPHastaMarcas);
            this.Controls.Add(this.LDesde1);
            this.Controls.Add(this.DTPDesdeMarcas);
            this.Controls.Add(this.LHasta);
            this.Controls.Add(this.DTPHastaCantidadUsuarios);
            this.Controls.Add(this.LDesde);
            this.Controls.Add(this.DTPDesdeCantidadUsuarios);
            this.Controls.Add(this.LCantidadUsuarios);
            this.Controls.Add(this.LMarcasVendidas);
            this.Controls.Add(this.CHCantidadUsuarios);
            this.Controls.Add(this.CHMarcasVendidas);
            this.Controls.Add(this.LTituloInformeAdmin);
            this.Controls.Add(this.PBImagenInformeAdmin);
            this.Name = "InformesAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InformesAdministrador";
            this.Load += new System.EventHandler(this.InformesAdministrador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenInformeAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHMarcasVendidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHCantidadUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBImagenInformeAdmin;
        private System.Windows.Forms.Label LTituloInformeAdmin;
        private System.Windows.Forms.DataVisualization.Charting.Chart CHMarcasVendidas;
        private System.Windows.Forms.DataVisualization.Charting.Chart CHCantidadUsuarios;
        private System.Windows.Forms.Label LMarcasVendidas;
        private System.Windows.Forms.Label LCantidadUsuarios;
        private System.Windows.Forms.Label LHasta;
        private System.Windows.Forms.DateTimePicker DTPHastaCantidadUsuarios;
        private System.Windows.Forms.Label LDesde;
        private System.Windows.Forms.DateTimePicker DTPDesdeCantidadUsuarios;
        private System.Windows.Forms.Label LHasta1;
        private System.Windows.Forms.DateTimePicker DTPHastaMarcas;
        private System.Windows.Forms.Label LDesde1;
        private System.Windows.Forms.DateTimePicker DTPDesdeMarcas;
        private System.Windows.Forms.Button BLimpiarFiltros;
    }
}