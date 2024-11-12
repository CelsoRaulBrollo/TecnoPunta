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
            this.CBListaClientes = new System.Windows.Forms.CheckBox();
            this.CBReporteVentas = new System.Windows.Forms.CheckBox();
            this.CBListaPrecios = new System.Windows.Forms.CheckBox();
            this.BLimpiar = new System.Windows.Forms.Button();
            this.BImprimir = new System.Windows.Forms.Button();
            this.DTPDesde = new System.Windows.Forms.DateTimePicker();
            this.DTPHasta = new System.Windows.Forms.DateTimePicker();
            this.LDesde = new System.Windows.Forms.Label();
            this.LHasta = new System.Windows.Forms.Label();
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
            // CBListaClientes
            // 
            this.CBListaClientes.AutoSize = true;
            this.CBListaClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBListaClientes.Location = new System.Drawing.Point(185, 151);
            this.CBListaClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBListaClientes.Name = "CBListaClientes";
            this.CBListaClientes.Size = new System.Drawing.Size(178, 29);
            this.CBListaClientes.TabIndex = 71;
            this.CBListaClientes.Text = "Lista de Clientes";
            this.CBListaClientes.UseVisualStyleBackColor = true;
            this.CBListaClientes.CheckedChanged += new System.EventHandler(this.CBReporteCliente_CheckedChanged);
            // 
            // CBReporteVentas
            // 
            this.CBReporteVentas.AutoSize = true;
            this.CBReporteVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBReporteVentas.Location = new System.Drawing.Point(748, 151);
            this.CBReporteVentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBReporteVentas.Name = "CBReporteVentas";
            this.CBReporteVentas.Size = new System.Drawing.Size(206, 29);
            this.CBReporteVentas.TabIndex = 72;
            this.CBReporteVentas.Text = "Reportes de Ventas";
            this.CBReporteVentas.UseVisualStyleBackColor = true;
            this.CBReporteVentas.CheckedChanged += new System.EventHandler(this.CBReporteVentas_CheckedChanged);
            // 
            // CBListaPrecios
            // 
            this.CBListaPrecios.AutoSize = true;
            this.CBListaPrecios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBListaPrecios.Location = new System.Drawing.Point(185, 251);
            this.CBListaPrecios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBListaPrecios.Name = "CBListaPrecios";
            this.CBListaPrecios.Size = new System.Drawing.Size(172, 29);
            this.CBListaPrecios.TabIndex = 73;
            this.CBListaPrecios.Text = "Lista de Precios";
            this.CBListaPrecios.UseVisualStyleBackColor = true;
            this.CBListaPrecios.CheckedChanged += new System.EventHandler(this.CBReporteProducto_CheckedChanged);
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
            this.BLimpiar.Click += new System.EventHandler(this.BLimpiar_Click);
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
            this.BImprimir.Click += new System.EventHandler(this.BImprimir_Click);
            // 
            // DTPDesde
            // 
            this.DTPDesde.Location = new System.Drawing.Point(632, 258);
            this.DTPDesde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTPDesde.Name = "DTPDesde";
            this.DTPDesde.Size = new System.Drawing.Size(200, 22);
            this.DTPDesde.TabIndex = 76;
            this.DTPDesde.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // DTPHasta
            // 
            this.DTPHasta.Location = new System.Drawing.Point(888, 258);
            this.DTPHasta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTPHasta.Name = "DTPHasta";
            this.DTPHasta.Size = new System.Drawing.Size(200, 22);
            this.DTPHasta.TabIndex = 77;
            this.DTPHasta.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // LDesde
            // 
            this.LDesde.AutoSize = true;
            this.LDesde.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDesde.Location = new System.Drawing.Point(695, 216);
            this.LDesde.Name = "LDesde";
            this.LDesde.Size = new System.Drawing.Size(68, 22);
            this.LDesde.TabIndex = 78;
            this.LDesde.Text = "Desde";
            // 
            // LHasta
            // 
            this.LHasta.AutoSize = true;
            this.LHasta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LHasta.Location = new System.Drawing.Point(958, 216);
            this.LHasta.Name = "LHasta";
            this.LHasta.Size = new System.Drawing.Size(63, 22);
            this.LHasta.TabIndex = 79;
            this.LHasta.Text = "Hasta";
            // 
            // ReporteInformeGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1183, 624);
            this.Controls.Add(this.LHasta);
            this.Controls.Add(this.LDesde);
            this.Controls.Add(this.DTPHasta);
            this.Controls.Add(this.DTPDesde);
            this.Controls.Add(this.BImprimir);
            this.Controls.Add(this.BLimpiar);
            this.Controls.Add(this.CBListaPrecios);
            this.Controls.Add(this.CBReporteVentas);
            this.Controls.Add(this.CBListaClientes);
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
        private System.Windows.Forms.CheckBox CBListaClientes;
        private System.Windows.Forms.CheckBox CBReporteVentas;
        private System.Windows.Forms.CheckBox CBListaPrecios;
        private System.Windows.Forms.Button BLimpiar;
        private System.Windows.Forms.Button BImprimir;
        private System.Windows.Forms.DateTimePicker DTPDesde;
        private System.Windows.Forms.DateTimePicker DTPHasta;
        private System.Windows.Forms.Label LDesde;
        private System.Windows.Forms.Label LHasta;
    }
}