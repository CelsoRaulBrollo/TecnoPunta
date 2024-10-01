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
            this.LTituloReporteVentas.Location = new System.Drawing.Point(78, 14);
            this.LTituloReporteVentas.Name = "LTituloReporteVentas";
            this.LTituloReporteVentas.Size = new System.Drawing.Size(135, 36);
            this.LTituloReporteVentas.TabIndex = 37;
            this.LTituloReporteVentas.Text = "Informes";
            this.LTituloReporteVentas.Click += new System.EventHandler(this.LTituloReporteVentas_Click);
            // 
            // PBImagenInformeGerente
            // 
            this.PBImagenInformeGerente.Image = global::ProyectoTaller.Properties.Resources.informe_titulo;
            this.PBImagenInformeGerente.Location = new System.Drawing.Point(10, 11);
            this.PBImagenInformeGerente.Name = "PBImagenInformeGerente";
            this.PBImagenInformeGerente.Size = new System.Drawing.Size(65, 67);
            this.PBImagenInformeGerente.TabIndex = 38;
            this.PBImagenInformeGerente.TabStop = false;
            // 
            // CBReporteCliente
            // 
            this.CBReporteCliente.AutoSize = true;
            this.CBReporteCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBReporteCliente.Location = new System.Drawing.Point(132, 136);
            this.CBReporteCliente.Name = "CBReporteCliente";
            this.CBReporteCliente.Size = new System.Drawing.Size(177, 24);
            this.CBReporteCliente.TabIndex = 71;
            this.CBReporteCliente.Text = "Reportes de Clientes";
            this.CBReporteCliente.UseVisualStyleBackColor = true;
            this.CBReporteCliente.CheckedChanged += new System.EventHandler(this.CBReporteCliente_CheckedChanged);
            // 
            // CBReporteVentas
            // 
            this.CBReporteVentas.AutoSize = true;
            this.CBReporteVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBReporteVentas.Location = new System.Drawing.Point(132, 179);
            this.CBReporteVentas.Name = "CBReporteVentas";
            this.CBReporteVentas.Size = new System.Drawing.Size(171, 24);
            this.CBReporteVentas.TabIndex = 72;
            this.CBReporteVentas.Text = "Reportes de Ventas";
            this.CBReporteVentas.UseVisualStyleBackColor = true;
            this.CBReporteVentas.CheckedChanged += new System.EventHandler(this.CBReporteVentas_CheckedChanged);
            // 
            // CBReporteProducto
            // 
            this.CBReporteProducto.AutoSize = true;
            this.CBReporteProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBReporteProducto.Location = new System.Drawing.Point(132, 223);
            this.CBReporteProducto.Name = "CBReporteProducto";
            this.CBReporteProducto.Size = new System.Drawing.Size(192, 24);
            this.CBReporteProducto.TabIndex = 73;
            this.CBReporteProducto.Text = "Reportes de Productos";
            this.CBReporteProducto.UseVisualStyleBackColor = true;
            this.CBReporteProducto.CheckedChanged += new System.EventHandler(this.CBReporteProducto_CheckedChanged);
            // 
            // BLimpiar
            // 
            this.BLimpiar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLimpiar.Image = global::ProyectoTaller.Properties.Resources.Limpiar;
            this.BLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BLimpiar.Location = new System.Drawing.Point(326, 356);
            this.BLimpiar.Name = "BLimpiar";
            this.BLimpiar.Size = new System.Drawing.Size(123, 52);
            this.BLimpiar.TabIndex = 74;
            this.BLimpiar.Text = "Limpiar       ";
            this.BLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BLimpiar.UseVisualStyleBackColor = true;
            this.BLimpiar.Click += new System.EventHandler(this.BLimpiar_Click);
            // 
            // BImprimir
            // 
            this.BImprimir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BImprimir.Image = global::ProyectoTaller.Properties.Resources.GuardarProducto;
            this.BImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BImprimir.Location = new System.Drawing.Point(472, 356);
            this.BImprimir.Name = "BImprimir";
            this.BImprimir.Size = new System.Drawing.Size(123, 52);
            this.BImprimir.TabIndex = 75;
            this.BImprimir.Text = "Imprimir  ";
            this.BImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BImprimir.UseVisualStyleBackColor = true;
            this.BImprimir.Click += new System.EventHandler(this.BImprimir_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(478, 142);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 76;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(670, 142);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker2.TabIndex = 77;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // LDesde
            // 
            this.LDesde.AutoSize = true;
            this.LDesde.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDesde.Location = new System.Drawing.Point(525, 108);
            this.LDesde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LDesde.Name = "LDesde";
            this.LDesde.Size = new System.Drawing.Size(56, 20);
            this.LDesde.TabIndex = 78;
            this.LDesde.Text = "Desde";
            // 
            // LHasta
            // 
            this.LHasta.AutoSize = true;
            this.LHasta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LHasta.Location = new System.Drawing.Point(722, 108);
            this.LHasta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LHasta.Name = "LHasta";
            this.LHasta.Size = new System.Drawing.Size(50, 20);
            this.LHasta.TabIndex = 79;
            this.LHasta.Text = "Hasta";
            // 
            // CBOXMensual
            // 
            this.CBOXMensual.AutoSize = true;
            this.CBOXMensual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBOXMensual.Location = new System.Drawing.Point(478, 197);
            this.CBOXMensual.Name = "CBOXMensual";
            this.CBOXMensual.Size = new System.Drawing.Size(80, 21);
            this.CBOXMensual.TabIndex = 80;
            this.CBOXMensual.Text = "Mensual";
            this.CBOXMensual.UseVisualStyleBackColor = true;
            this.CBOXMensual.CheckedChanged += new System.EventHandler(this.CBOXMensual_CheckedChanged);
            // 
            // CBOXDiario
            // 
            this.CBOXDiario.AutoSize = true;
            this.CBOXDiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBOXDiario.Location = new System.Drawing.Point(478, 223);
            this.CBOXDiario.Name = "CBOXDiario";
            this.CBOXDiario.Size = new System.Drawing.Size(64, 21);
            this.CBOXDiario.TabIndex = 81;
            this.CBOXDiario.Text = "Diario";
            this.CBOXDiario.UseVisualStyleBackColor = true;
            this.CBOXDiario.CheckedChanged += new System.EventHandler(this.CBOXDiario_CheckedChanged);
            // 
            // CBOXAnual
            // 
            this.CBOXAnual.AutoSize = true;
            this.CBOXAnual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBOXAnual.Location = new System.Drawing.Point(478, 171);
            this.CBOXAnual.Name = "CBOXAnual";
            this.CBOXAnual.Size = new System.Drawing.Size(63, 21);
            this.CBOXAnual.TabIndex = 82;
            this.CBOXAnual.Text = "Anual";
            this.CBOXAnual.UseVisualStyleBackColor = true;
            this.CBOXAnual.CheckedChanged += new System.EventHandler(this.CBOXAnual_CheckedChanged);
            // 
            // CBReporteStock
            // 
            this.CBReporteStock.AutoSize = true;
            this.CBReporteStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBReporteStock.Location = new System.Drawing.Point(132, 262);
            this.CBReporteStock.Name = "CBReporteStock";
            this.CBReporteStock.Size = new System.Drawing.Size(161, 24);
            this.CBReporteStock.TabIndex = 83;
            this.CBReporteStock.Text = "Reportes de Stock";
            this.CBReporteStock.UseVisualStyleBackColor = true;
            this.CBReporteStock.CheckedChanged += new System.EventHandler(this.CBReporteStock_CheckedChanged);
            // 
            // ReporteInformeGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(887, 507);
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