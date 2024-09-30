namespace ProyectoTaller.Views.Gerentes
{
    partial class ReporteInformeGeneral
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
            this.LTituloReporteVentas = new System.Windows.Forms.Label();
            this.PBImagenInformeGerente = new System.Windows.Forms.PictureBox();
            this.CBReporteCliente = new System.Windows.Forms.CheckBox();
            this.CBReporteVentas = new System.Windows.Forms.CheckBox();
            this.CBReporteProducto = new System.Windows.Forms.CheckBox();
            this.BLimpiar = new System.Windows.Forms.Button();
            this.BImprimir = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.LDesde = new System.Windows.Forms.Label();
            this.LHasta = new System.Windows.Forms.Label();
            this.CBOXMensual = new System.Windows.Forms.CheckBox();
            this.CBOXDiario = new System.Windows.Forms.CheckBox();
            this.CBOXAnual = new System.Windows.Forms.CheckBox();
            this.CBReporteStock = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenInformeGerente)).BeginInit();
            this.SuspendLayout();
            // 
            // LTituloReporteVentas
            // 
            this.LTituloReporteVentas.AutoSize = true;
            this.LTituloReporteVentas.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloReporteVentas.Location = new System.Drawing.Point(104, 17);
            this.LTituloReporteVentas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTituloReporteVentas.Name = "LTituloReporteVentas";
            this.LTituloReporteVentas.Size = new System.Drawing.Size(172, 44);
            this.LTituloReporteVentas.TabIndex = 37;
            this.LTituloReporteVentas.Text = "Informes";
            this.LTituloReporteVentas.Click += new System.EventHandler(this.LTituloReporteVentas_Click);
            // 
            // PBImagenInformeGerente
            // 
            this.PBImagenInformeGerente.Image = global::ProyectoTaller.Properties.Resources.informe_titulo;
            this.PBImagenInformeGerente.Location = new System.Drawing.Point(13, 14);
            this.PBImagenInformeGerente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PBImagenInformeGerente.Name = "PBImagenInformeGerente";
            this.PBImagenInformeGerente.Size = new System.Drawing.Size(87, 82);
            this.PBImagenInformeGerente.TabIndex = 38;
            this.PBImagenInformeGerente.TabStop = false;
            // 
            // CBReporteCliente
            // 
            this.CBReporteCliente.AutoSize = true;
            this.CBReporteCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBReporteCliente.Location = new System.Drawing.Point(176, 168);
            this.CBReporteCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBReporteCliente.Name = "CBReporteCliente";
            this.CBReporteCliente.Size = new System.Drawing.Size(215, 29);
            this.CBReporteCliente.TabIndex = 71;
            this.CBReporteCliente.Text = "Reportes de Clientes";
            this.CBReporteCliente.UseVisualStyleBackColor = true;
            // 
            // CBReporteVentas
            // 
            this.CBReporteVentas.AutoSize = true;
            this.CBReporteVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBReporteVentas.Location = new System.Drawing.Point(176, 220);
            this.CBReporteVentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBReporteVentas.Name = "CBReporteVentas";
            this.CBReporteVentas.Size = new System.Drawing.Size(206, 29);
            this.CBReporteVentas.TabIndex = 72;
            this.CBReporteVentas.Text = "Reportes de Ventas";
            this.CBReporteVentas.UseVisualStyleBackColor = true;
            // 
            // CBReporteProducto
            // 
            this.CBReporteProducto.AutoSize = true;
            this.CBReporteProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBReporteProducto.Location = new System.Drawing.Point(176, 274);
            this.CBReporteProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBReporteProducto.Name = "CBReporteProducto";
            this.CBReporteProducto.Size = new System.Drawing.Size(232, 29);
            this.CBReporteProducto.TabIndex = 73;
            this.CBReporteProducto.Text = "Reportes de Productos";
            this.CBReporteProducto.UseVisualStyleBackColor = true;
            // 
            // BLimpiar
            // 
            this.BLimpiar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLimpiar.Image = global::ProyectoTaller.Properties.Resources.Limpiar;
            this.BLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BLimpiar.Location = new System.Drawing.Point(435, 438);
            this.BLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BLimpiar.Name = "BLimpiar";
            this.BLimpiar.Size = new System.Drawing.Size(164, 64);
            this.BLimpiar.TabIndex = 74;
            this.BLimpiar.Text = "Limpiar       ";
            this.BLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BLimpiar.UseVisualStyleBackColor = true;
            // 
            // BImprimir
            // 
            this.BImprimir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BImprimir.Image = global::ProyectoTaller.Properties.Resources.GuardarProducto;
            this.BImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BImprimir.Location = new System.Drawing.Point(629, 438);
            this.BImprimir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BImprimir.Name = "BImprimir";
            this.BImprimir.Size = new System.Drawing.Size(164, 64);
            this.BImprimir.TabIndex = 75;
            this.BImprimir.Text = "Imprimir  ";
            this.BImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BImprimir.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(637, 175);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 76;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(893, 175);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 77;
            // 
            // LDesde
            // 
            this.LDesde.AutoSize = true;
            this.LDesde.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDesde.Location = new System.Drawing.Point(700, 133);
            this.LDesde.Name = "LDesde";
            this.LDesde.Size = new System.Drawing.Size(68, 22);
            this.LDesde.TabIndex = 78;
            this.LDesde.Text = "Desde";
            // 
            // LHasta
            // 
            this.LHasta.AutoSize = true;
            this.LHasta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LHasta.Location = new System.Drawing.Point(963, 133);
            this.LHasta.Name = "LHasta";
            this.LHasta.Size = new System.Drawing.Size(63, 22);
            this.LHasta.TabIndex = 79;
            this.LHasta.Text = "Hasta";
            // 
            // CBOXMensual
            // 
            this.CBOXMensual.AutoSize = true;
            this.CBOXMensual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBOXMensual.Location = new System.Drawing.Point(637, 242);
            this.CBOXMensual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBOXMensual.Name = "CBOXMensual";
            this.CBOXMensual.Size = new System.Drawing.Size(94, 24);
            this.CBOXMensual.TabIndex = 80;
            this.CBOXMensual.Text = "Mensual";
            this.CBOXMensual.UseVisualStyleBackColor = true;
            this.CBOXMensual.CheckedChanged += new System.EventHandler(this.CBOXMensual_CheckedChanged);
            // 
            // CBOXDiario
            // 
            this.CBOXDiario.AutoSize = true;
            this.CBOXDiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBOXDiario.Location = new System.Drawing.Point(637, 274);
            this.CBOXDiario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBOXDiario.Name = "CBOXDiario";
            this.CBOXDiario.Size = new System.Drawing.Size(76, 24);
            this.CBOXDiario.TabIndex = 81;
            this.CBOXDiario.Text = "Diario";
            this.CBOXDiario.UseVisualStyleBackColor = true;
            this.CBOXDiario.CheckedChanged += new System.EventHandler(this.CBOXDiario_CheckedChanged);
            // 
            // CBOXAnual
            // 
            this.CBOXAnual.AutoSize = true;
            this.CBOXAnual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBOXAnual.Location = new System.Drawing.Point(637, 210);
            this.CBOXAnual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBOXAnual.Name = "CBOXAnual";
            this.CBOXAnual.Size = new System.Drawing.Size(73, 24);
            this.CBOXAnual.TabIndex = 82;
            this.CBOXAnual.Text = "Anual";
            this.CBOXAnual.UseVisualStyleBackColor = true;
            this.CBOXAnual.CheckedChanged += new System.EventHandler(this.CBOXAnual_CheckedChanged);
            // 
            // CBReporteStock
            // 
            this.CBReporteStock.AutoSize = true;
            this.CBReporteStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBReporteStock.Location = new System.Drawing.Point(176, 323);
            this.CBReporteStock.Margin = new System.Windows.Forms.Padding(4);
            this.CBReporteStock.Name = "CBReporteStock";
            this.CBReporteStock.Size = new System.Drawing.Size(194, 29);
            this.CBReporteStock.TabIndex = 83;
            this.CBReporteStock.Text = "Reportes de Stock";
            this.CBReporteStock.UseVisualStyleBackColor = true;
            // 
            // ReporteInformeGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1183, 624);
            this.Controls.Add(this.CBReporteStock);
            this.Controls.Add(this.CBOXAnual);
            this.Controls.Add(this.CBOXDiario);
            this.Controls.Add(this.CBOXMensual);
            this.Controls.Add(this.LHasta);
            this.Controls.Add(this.LDesde);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.BImprimir);
            this.Controls.Add(this.BLimpiar);
            this.Controls.Add(this.CBReporteProducto);
            this.Controls.Add(this.CBReporteVentas);
            this.Controls.Add(this.CBReporteCliente);
            this.Controls.Add(this.PBImagenInformeGerente);
            this.Controls.Add(this.LTituloReporteVentas);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReporteInformeGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteVentas";
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenInformeGerente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LTituloReporteVentas;
        private System.Windows.Forms.PictureBox PBImagenInformeGerente;
        private System.Windows.Forms.CheckBox CBReporteCliente;
        private System.Windows.Forms.CheckBox CBReporteVentas;
        private System.Windows.Forms.CheckBox CBReporteProducto;
        private System.Windows.Forms.Button BLimpiar;
        private System.Windows.Forms.Button BImprimir;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label LDesde;
        private System.Windows.Forms.Label LHasta;
        private System.Windows.Forms.CheckBox CBOXMensual;
        private System.Windows.Forms.CheckBox CBOXDiario;
        private System.Windows.Forms.CheckBox CBOXAnual;
        private System.Windows.Forms.CheckBox CBReporteStock;
    }
}