namespace ProyectoTaller.Views.Administradores
{
    partial class VerVentas
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
            this.LTituloVentas = new System.Windows.Forms.Label();
            this.TBuscarVentas = new System.Windows.Forms.TextBox();
            this.DGVentas = new System.Windows.Forms.DataGridView();
            this.CIdVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMedioPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProductosComprados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.BVerDetalle = new System.Windows.Forms.Button();
            this.BVerFactura = new System.Windows.Forms.Button();
            this.PBImagenTitulo = new System.Windows.Forms.PictureBox();
            this.DTPDesde = new System.Windows.Forms.DateTimePicker();
            this.LDesde = new System.Windows.Forms.Label();
            this.DTPHasta = new System.Windows.Forms.DateTimePicker();
            this.LHasta = new System.Windows.Forms.Label();
            this.CBEfectivo = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CBTarjeta = new System.Windows.Forms.CheckBox();
            this.CBTransferencia = new System.Windows.Forms.CheckBox();
            this.BReiniciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenTitulo)).BeginInit();
            this.SuspendLayout();
            // 
            // LTituloVentas
            // 
            this.LTituloVentas.AutoSize = true;
            this.LTituloVentas.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloVentas.Location = new System.Drawing.Point(82, 12);
            this.LTituloVentas.Name = "LTituloVentas";
            this.LTituloVentas.Size = new System.Drawing.Size(112, 36);
            this.LTituloVentas.TabIndex = 1;
            this.LTituloVentas.Text = "Ventas";
            // 
            // TBuscarVentas
            // 
            this.TBuscarVentas.Location = new System.Drawing.Point(320, 85);
            this.TBuscarVentas.Name = "TBuscarVentas";
            this.TBuscarVentas.Size = new System.Drawing.Size(277, 20);
            this.TBuscarVentas.TabIndex = 29;
            this.TBuscarVentas.TextChanged += new System.EventHandler(this.TBuscarVentas_TextChanged);
            // 
            // DGVentas
            // 
            this.DGVentas.AllowUserToAddRows = false;
            this.DGVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIdVenta,
            this.CNombreCliente,
            this.CFecha,
            this.CMedioPago,
            this.CProductosComprados,
            this.CSubtotal});
            this.DGVentas.Location = new System.Drawing.Point(12, 162);
            this.DGVentas.Name = "DGVentas";
            this.DGVentas.Size = new System.Drawing.Size(863, 333);
            this.DGVentas.TabIndex = 31;
            this.DGVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVentas_CellContentClick);
            // 
            // CIdVenta
            // 
            this.CIdVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CIdVenta.HeaderText = "ID Venta";
            this.CIdVenta.Name = "CIdVenta";
            this.CIdVenta.Width = 110;
            // 
            // CNombreCliente
            // 
            this.CNombreCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CNombreCliente.HeaderText = "Nombre Cliente";
            this.CNombreCliente.Name = "CNombreCliente";
            this.CNombreCliente.Width = 180;
            // 
            // CFecha
            // 
            this.CFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CFecha.HeaderText = "Fecha";
            this.CFecha.Name = "CFecha";
            this.CFecha.Width = 120;
            // 
            // CMedioPago
            // 
            this.CMedioPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CMedioPago.HeaderText = "Medio de Pago";
            this.CMedioPago.Name = "CMedioPago";
            this.CMedioPago.Width = 110;
            // 
            // CProductosComprados
            // 
            this.CProductosComprados.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CProductosComprados.HeaderText = "Productos Comprados";
            this.CProductosComprados.Name = "CProductosComprados";
            this.CProductosComprados.Width = 200;
            // 
            // CSubtotal
            // 
            this.CSubtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CSubtotal.HeaderText = "Subtotal";
            this.CSubtotal.Name = "CSubtotal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(389, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 23);
            this.label1.TabIndex = 32;
            this.label1.Text = "Buscar Venta";
            // 
            // BVerDetalle
            // 
            this.BVerDetalle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BVerDetalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BVerDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BVerDetalle.Image = global::ProyectoTaller.Properties.Resources.Ver_detalle;
            this.BVerDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BVerDetalle.Location = new System.Drawing.Point(727, 98);
            this.BVerDetalle.Name = "BVerDetalle";
            this.BVerDetalle.Size = new System.Drawing.Size(123, 52);
            this.BVerDetalle.TabIndex = 34;
            this.BVerDetalle.Text = "Ver Detalle ";
            this.BVerDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BVerDetalle.UseVisualStyleBackColor = true;
            this.BVerDetalle.Click += new System.EventHandler(this.BVerDetalle_Click);
            // 
            // BVerFactura
            // 
            this.BVerFactura.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BVerFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BVerFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BVerFactura.Image = global::ProyectoTaller.Properties.Resources.factura;
            this.BVerFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BVerFactura.Location = new System.Drawing.Point(727, 35);
            this.BVerFactura.Name = "BVerFactura";
            this.BVerFactura.Size = new System.Drawing.Size(123, 52);
            this.BVerFactura.TabIndex = 33;
            this.BVerFactura.Text = "Factura     ";
            this.BVerFactura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BVerFactura.UseVisualStyleBackColor = true;
            this.BVerFactura.Click += new System.EventHandler(this.BVerFactura_Click);
            // 
            // PBImagenTitulo
            // 
            this.PBImagenTitulo.Image = global::ProyectoTaller.Properties.Resources.VentasTitulo;
            this.PBImagenTitulo.Location = new System.Drawing.Point(12, 7);
            this.PBImagenTitulo.Name = "PBImagenTitulo";
            this.PBImagenTitulo.Size = new System.Drawing.Size(65, 67);
            this.PBImagenTitulo.TabIndex = 28;
            this.PBImagenTitulo.TabStop = false;
            // 
            // DTPDesde
            // 
            this.DTPDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPDesde.Location = new System.Drawing.Point(70, 87);
            this.DTPDesde.Name = "DTPDesde";
            this.DTPDesde.Size = new System.Drawing.Size(97, 20);
            this.DTPDesde.TabIndex = 36;
            this.DTPDesde.ValueChanged += new System.EventHandler(this.DTPDesde_ValueChanged);
            // 
            // LDesde
            // 
            this.LDesde.AutoSize = true;
            this.LDesde.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDesde.Location = new System.Drawing.Point(19, 88);
            this.LDesde.Name = "LDesde";
            this.LDesde.Size = new System.Drawing.Size(48, 17);
            this.LDesde.TabIndex = 64;
            this.LDesde.Text = "Desde";
            // 
            // DTPHasta
            // 
            this.DTPHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPHasta.Location = new System.Drawing.Point(70, 128);
            this.DTPHasta.Name = "DTPHasta";
            this.DTPHasta.Size = new System.Drawing.Size(97, 20);
            this.DTPHasta.TabIndex = 65;
            this.DTPHasta.ValueChanged += new System.EventHandler(this.DTPHasta_ValueChanged);
            // 
            // LHasta
            // 
            this.LHasta.AutoSize = true;
            this.LHasta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LHasta.Location = new System.Drawing.Point(19, 130);
            this.LHasta.Name = "LHasta";
            this.LHasta.Size = new System.Drawing.Size(45, 17);
            this.LHasta.TabIndex = 66;
            this.LHasta.Text = "Hasta";
            // 
            // CBEfectivo
            // 
            this.CBEfectivo.AutoSize = true;
            this.CBEfectivo.Location = new System.Drawing.Point(407, 137);
            this.CBEfectivo.Name = "CBEfectivo";
            this.CBEfectivo.Size = new System.Drawing.Size(65, 17);
            this.CBEfectivo.TabIndex = 67;
            this.CBEfectivo.Text = "Efectivo";
            this.CBEfectivo.UseVisualStyleBackColor = true;
            this.CBEfectivo.CheckedChanged += new System.EventHandler(this.CBEfectivo_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(293, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 68;
            this.label2.Text = "Medio de Pago:";
            // 
            // CBTarjeta
            // 
            this.CBTarjeta.AutoSize = true;
            this.CBTarjeta.Location = new System.Drawing.Point(471, 137);
            this.CBTarjeta.Name = "CBTarjeta";
            this.CBTarjeta.Size = new System.Drawing.Size(59, 17);
            this.CBTarjeta.TabIndex = 69;
            this.CBTarjeta.Text = "Tarjeta";
            this.CBTarjeta.UseVisualStyleBackColor = true;
            this.CBTarjeta.CheckedChanged += new System.EventHandler(this.CBTarjeta_CheckedChanged);
            // 
            // CBTransferencia
            // 
            this.CBTransferencia.AutoSize = true;
            this.CBTransferencia.Location = new System.Drawing.Point(532, 137);
            this.CBTransferencia.Name = "CBTransferencia";
            this.CBTransferencia.Size = new System.Drawing.Size(91, 17);
            this.CBTransferencia.TabIndex = 70;
            this.CBTransferencia.Text = "Transferencia";
            this.CBTransferencia.UseVisualStyleBackColor = true;
            this.CBTransferencia.CheckedChanged += new System.EventHandler(this.CBTransferencia_CheckedChanged);
            // 
            // BReiniciar
            // 
            this.BReiniciar.Location = new System.Drawing.Point(173, 86);
            this.BReiniciar.Name = "BReiniciar";
            this.BReiniciar.Size = new System.Drawing.Size(60, 23);
            this.BReiniciar.TabIndex = 71;
            this.BReiniciar.Text = "Reiniciar";
            this.BReiniciar.UseVisualStyleBackColor = true;
            this.BReiniciar.Click += new System.EventHandler(this.BReiniciar_Click);
            // 
            // VerVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(887, 507);
            this.Controls.Add(this.BReiniciar);
            this.Controls.Add(this.CBTransferencia);
            this.Controls.Add(this.CBTarjeta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBEfectivo);
            this.Controls.Add(this.LHasta);
            this.Controls.Add(this.DTPHasta);
            this.Controls.Add(this.LDesde);
            this.Controls.Add(this.DTPDesde);
            this.Controls.Add(this.BVerDetalle);
            this.Controls.Add(this.BVerFactura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVentas);
            this.Controls.Add(this.TBuscarVentas);
            this.Controls.Add(this.PBImagenTitulo);
            this.Controls.Add(this.LTituloVentas);
            this.Name = "VerVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerVentas";
            this.Load += new System.EventHandler(this.VerVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenTitulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LTituloVentas;
        private System.Windows.Forms.PictureBox PBImagenTitulo;
        private System.Windows.Forms.TextBox TBuscarVentas;
        private System.Windows.Forms.DataGridView DGVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BVerFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIdVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMedioPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProductosComprados;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSubtotal;
        private System.Windows.Forms.Button BVerDetalle;
        private System.Windows.Forms.DateTimePicker DTPDesde;
        private System.Windows.Forms.Label LDesde;
        private System.Windows.Forms.DateTimePicker DTPHasta;
        private System.Windows.Forms.Label LHasta;
        private System.Windows.Forms.CheckBox CBEfectivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CBTarjeta;
        private System.Windows.Forms.CheckBox CBTransferencia;
        private System.Windows.Forms.Button BReiniciar;
    }
}