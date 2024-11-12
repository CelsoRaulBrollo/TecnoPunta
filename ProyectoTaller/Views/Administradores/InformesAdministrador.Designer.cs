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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.CBInformeUsuClient = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenInformeAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHMarcasVendidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHCantidadUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // PBImagenInformeAdmin
            // 
            this.PBImagenInformeAdmin.Image = global::ProyectoTaller.Properties.Resources.informe_titulo;
            this.PBImagenInformeAdmin.Location = new System.Drawing.Point(16, 15);
            this.PBImagenInformeAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.PBImagenInformeAdmin.Name = "PBImagenInformeAdmin";
            this.PBImagenInformeAdmin.Size = new System.Drawing.Size(87, 82);
            this.PBImagenInformeAdmin.TabIndex = 31;
            this.PBImagenInformeAdmin.TabStop = false;
            // 
            // LTituloInformeAdmin
            // 
            this.LTituloInformeAdmin.AutoSize = true;
            this.LTituloInformeAdmin.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloInformeAdmin.Location = new System.Drawing.Point(107, 16);
            this.LTituloInformeAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTituloInformeAdmin.Name = "LTituloInformeAdmin";
            this.LTituloInformeAdmin.Size = new System.Drawing.Size(385, 44);
            this.LTituloInformeAdmin.TabIndex = 32;
            this.LTituloInformeAdmin.Text = "Informes Estadisticos";
            this.LTituloInformeAdmin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CHMarcasVendidas
            // 
            this.CHMarcasVendidas.BackColor = System.Drawing.SystemColors.Control;
            this.CHMarcasVendidas.BorderlineColor = System.Drawing.SystemColors.Control;
            chartArea5.Name = "ChartArea1";
            this.CHMarcasVendidas.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.CHMarcasVendidas.Legends.Add(legend5);
            this.CHMarcasVendidas.Location = new System.Drawing.Point(639, 175);
            this.CHMarcasVendidas.Margin = new System.Windows.Forms.Padding(4);
            this.CHMarcasVendidas.Name = "CHMarcasVendidas";
            this.CHMarcasVendidas.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.CHMarcasVendidas.Series.Add(series5);
            this.CHMarcasVendidas.Size = new System.Drawing.Size(528, 354);
            this.CHMarcasVendidas.TabIndex = 33;
            this.CHMarcasVendidas.Text = "chart1";
            // 
            // CHCantidadUsuarios
            // 
            this.CHCantidadUsuarios.BackColor = System.Drawing.SystemColors.Control;
            chartArea6.Name = "ChartArea1";
            this.CHCantidadUsuarios.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.CHCantidadUsuarios.Legends.Add(legend6);
            this.CHCantidadUsuarios.Location = new System.Drawing.Point(16, 175);
            this.CHCantidadUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.CHCantidadUsuarios.Name = "CHCantidadUsuarios";
            this.CHCantidadUsuarios.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.CHCantidadUsuarios.Series.Add(series6);
            this.CHCantidadUsuarios.Size = new System.Drawing.Size(528, 354);
            this.CHCantidadUsuarios.TabIndex = 34;
            this.CHCantidadUsuarios.Text = "chart2";
            // 
            // LMarcasVendidas
            // 
            this.LMarcasVendidas.AutoSize = true;
            this.LMarcasVendidas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LMarcasVendidas.Location = new System.Drawing.Point(633, 143);
            this.LMarcasVendidas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LMarcasVendidas.Name = "LMarcasVendidas";
            this.LMarcasVendidas.Size = new System.Drawing.Size(260, 28);
            this.LMarcasVendidas.TabIndex = 35;
            this.LMarcasVendidas.Text = "Marca mas vendidas";
            // 
            // LCantidadUsuarios
            // 
            this.LCantidadUsuarios.AutoSize = true;
            this.LCantidadUsuarios.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCantidadUsuarios.Location = new System.Drawing.Point(16, 143);
            this.LCantidadUsuarios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LCantidadUsuarios.Name = "LCantidadUsuarios";
            this.LCantidadUsuarios.Size = new System.Drawing.Size(262, 28);
            this.LCantidadUsuarios.TabIndex = 36;
            this.LCantidadUsuarios.Text = "Cantidad de usuarios";
            // 
            // LHasta
            // 
            this.LHasta.AutoSize = true;
            this.LHasta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LHasta.Location = new System.Drawing.Point(348, 146);
            this.LHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LHasta.Name = "LHasta";
            this.LHasta.Size = new System.Drawing.Size(60, 21);
            this.LHasta.TabIndex = 75;
            this.LHasta.Text = "Hasta";
            // 
            // DTPHastaCantidadUsuarios
            // 
            this.DTPHastaCantidadUsuarios.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPHastaCantidadUsuarios.Location = new System.Drawing.Point(416, 144);
            this.DTPHastaCantidadUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.DTPHastaCantidadUsuarios.Name = "DTPHastaCantidadUsuarios";
            this.DTPHastaCantidadUsuarios.Size = new System.Drawing.Size(128, 22);
            this.DTPHastaCantidadUsuarios.TabIndex = 74;
            this.DTPHastaCantidadUsuarios.ValueChanged += new System.EventHandler(this.DTPHastaCantidadUsuarios_ValueChanged);
            // 
            // LDesde
            // 
            this.LDesde.AutoSize = true;
            this.LDesde.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDesde.Location = new System.Drawing.Point(348, 95);
            this.LDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LDesde.Name = "LDesde";
            this.LDesde.Size = new System.Drawing.Size(64, 21);
            this.LDesde.TabIndex = 73;
            this.LDesde.Text = "Desde";
            // 
            // DTPDesdeCantidadUsuarios
            // 
            this.DTPDesdeCantidadUsuarios.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPDesdeCantidadUsuarios.Location = new System.Drawing.Point(416, 94);
            this.DTPDesdeCantidadUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.DTPDesdeCantidadUsuarios.Name = "DTPDesdeCantidadUsuarios";
            this.DTPDesdeCantidadUsuarios.Size = new System.Drawing.Size(128, 22);
            this.DTPDesdeCantidadUsuarios.TabIndex = 72;
            this.DTPDesdeCantidadUsuarios.Value = new System.DateTime(2024, 10, 26, 0, 0, 0, 0);
            this.DTPDesdeCantidadUsuarios.ValueChanged += new System.EventHandler(this.DTPDesdeCantidadUsuarios_ValueChanged);
            // 
            // LHasta1
            // 
            this.LHasta1.AutoSize = true;
            this.LHasta1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LHasta1.Location = new System.Drawing.Point(969, 143);
            this.LHasta1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LHasta1.Name = "LHasta1";
            this.LHasta1.Size = new System.Drawing.Size(60, 21);
            this.LHasta1.TabIndex = 80;
            this.LHasta1.Text = "Hasta";
            // 
            // DTPHastaMarcas
            // 
            this.DTPHastaMarcas.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPHastaMarcas.Location = new System.Drawing.Point(1037, 140);
            this.DTPHastaMarcas.Margin = new System.Windows.Forms.Padding(4);
            this.DTPHastaMarcas.Name = "DTPHastaMarcas";
            this.DTPHastaMarcas.Size = new System.Drawing.Size(128, 22);
            this.DTPHastaMarcas.TabIndex = 79;
            this.DTPHastaMarcas.ValueChanged += new System.EventHandler(this.DTPHastaMarcas_ValueChanged);
            // 
            // LDesde1
            // 
            this.LDesde1.AutoSize = true;
            this.LDesde1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDesde1.Location = new System.Drawing.Point(969, 91);
            this.LDesde1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LDesde1.Name = "LDesde1";
            this.LDesde1.Size = new System.Drawing.Size(64, 21);
            this.LDesde1.TabIndex = 78;
            this.LDesde1.Text = "Desde";
            // 
            // DTPDesdeMarcas
            // 
            this.DTPDesdeMarcas.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPDesdeMarcas.Location = new System.Drawing.Point(1037, 90);
            this.DTPDesdeMarcas.Margin = new System.Windows.Forms.Padding(4);
            this.DTPDesdeMarcas.Name = "DTPDesdeMarcas";
            this.DTPDesdeMarcas.Size = new System.Drawing.Size(128, 22);
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
            this.BLimpiarFiltros.Location = new System.Drawing.Point(503, 545);
            this.BLimpiarFiltros.Margin = new System.Windows.Forms.Padding(4);
            this.BLimpiarFiltros.Name = "BLimpiarFiltros";
            this.BLimpiarFiltros.Size = new System.Drawing.Size(164, 64);
            this.BLimpiarFiltros.TabIndex = 81;
            this.BLimpiarFiltros.Text = "Limpiar Filtros";
            this.BLimpiarFiltros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BLimpiarFiltros.UseVisualStyleBackColor = true;
            this.BLimpiarFiltros.Click += new System.EventHandler(this.BLimpiarFiltros_Click);
            // 
            // CBInformeUsuClient
            // 
            this.CBInformeUsuClient.FormattingEnabled = true;
            this.CBInformeUsuClient.Location = new System.Drawing.Point(12, 545);
            this.CBInformeUsuClient.Name = "CBInformeUsuClient";
            this.CBInformeUsuClient.Size = new System.Drawing.Size(266, 24);
            this.CBInformeUsuClient.TabIndex = 82;
            this.CBInformeUsuClient.SelectedIndexChanged += new System.EventHandler(this.CBInformeUsuClient_SelectedIndexChanged);
            // 
            // InformesAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1183, 624);
            this.Controls.Add(this.CBInformeUsuClient);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InformesAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InformesAdministrador";
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
        private System.Windows.Forms.ComboBox CBInformeUsuClient;
    }
}