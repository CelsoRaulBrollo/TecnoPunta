namespace ProyectoTaller.Views.Vendedor
{
    partial class VentaDetalle
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
            this.BImprimirDetalle = new System.Windows.Forms.Button();
            this.LTotalFinalizarCompra = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DGVentaDetalle = new System.Windows.Forms.DataGridView();
            this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CBEfectivo = new System.Windows.Forms.CheckBox();
            this.CBBilleteraVirtual = new System.Windows.Forms.CheckBox();
            this.CBTarjetaDeDebito = new System.Windows.Forms.CheckBox();
            this.CBTarjetaDeCredito = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LCorreoCompraFinCompra = new System.Windows.Forms.Label();
            this.LDireccionCompraFinCompra = new System.Windows.Forms.Label();
            this.LTelefonoCompraFinCompra = new System.Windows.Forms.Label();
            this.LDNICompraFinCompra = new System.Windows.Forms.Label();
            this.LApellidosCompraFinCompra = new System.Windows.Forms.Label();
            this.LNombreCompraFinCompra = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LVenta = new System.Windows.Forms.Label();
            this.LIDCompra = new System.Windows.Forms.Label();
            this.LIDCompraValorVentaDetalle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVentaDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // BImprimirDetalle
            // 
            this.BImprimirDetalle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BImprimirDetalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BImprimirDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BImprimirDetalle.Image = global::ProyectoTaller.Properties.Resources.informe_icon;
            this.BImprimirDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BImprimirDetalle.Location = new System.Drawing.Point(788, 508);
            this.BImprimirDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.BImprimirDetalle.Name = "BImprimirDetalle";
            this.BImprimirDetalle.Size = new System.Drawing.Size(169, 64);
            this.BImprimirDetalle.TabIndex = 105;
            this.BImprimirDetalle.Text = "Imprimir  ";
            this.BImprimirDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BImprimirDetalle.UseVisualStyleBackColor = true;
            this.BImprimirDetalle.Click += new System.EventHandler(this.BImprimirDetalle_Click);
            // 
            // LTotalFinalizarCompra
            // 
            this.LTotalFinalizarCompra.AutoSize = true;
            this.LTotalFinalizarCompra.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTotalFinalizarCompra.Location = new System.Drawing.Point(189, 586);
            this.LTotalFinalizarCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTotalFinalizarCompra.Name = "LTotalFinalizarCompra";
            this.LTotalFinalizarCompra.Size = new System.Drawing.Size(0, 39);
            this.LTotalFinalizarCompra.TabIndex = 103;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(76, 513);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 39);
            this.label10.TabIndex = 102;
            this.label10.Text = "Total:";
            // 
            // DGVentaDetalle
            // 
            this.DGVentaDetalle.AllowUserToAddRows = false;
            this.DGVentaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVentaDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoProducto,
            this.Descripcion,
            this.Cantidad,
            this.Precio});
            this.DGVentaDetalle.Location = new System.Drawing.Point(83, 342);
            this.DGVentaDetalle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVentaDetalle.Name = "DGVentaDetalle";
            this.DGVentaDetalle.RowHeadersWidth = 51;
            this.DGVentaDetalle.RowTemplate.Height = 24;
            this.DGVentaDetalle.Size = new System.Drawing.Size(874, 139);
            this.DGVentaDetalle.TabIndex = 101;
            // 
            // CodigoProducto
            // 
            this.CodigoProducto.FillWeight = 1F;
            this.CodigoProducto.HeaderText = "Codigo Producto";
            this.CodigoProducto.MinimumWidth = 6;
            this.CodigoProducto.Name = "CodigoProducto";
            this.CodigoProducto.Width = 400;
            // 
            // Descripcion
            // 
            this.Descripcion.FillWeight = 1000F;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 315;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 125;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.Width = 125;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(79, 303);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 23);
            this.label9.TabIndex = 100;
            this.label9.Text = "DetalleFactura";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(79, 81);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 23);
            this.label8.TabIndex = 99;
            this.label8.Text = "Cliente";
            // 
            // CBEfectivo
            // 
            this.CBEfectivo.AutoSize = true;
            this.CBEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBEfectivo.Location = new System.Drawing.Point(788, 237);
            this.CBEfectivo.Margin = new System.Windows.Forms.Padding(4);
            this.CBEfectivo.Name = "CBEfectivo";
            this.CBEfectivo.Size = new System.Drawing.Size(83, 22);
            this.CBEfectivo.TabIndex = 98;
            this.CBEfectivo.Text = "Efectivo";
            this.CBEfectivo.UseVisualStyleBackColor = true;
            // 
            // CBBilleteraVirtual
            // 
            this.CBBilleteraVirtual.AutoSize = true;
            this.CBBilleteraVirtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBBilleteraVirtual.Location = new System.Drawing.Point(640, 237);
            this.CBBilleteraVirtual.Margin = new System.Windows.Forms.Padding(4);
            this.CBBilleteraVirtual.Name = "CBBilleteraVirtual";
            this.CBBilleteraVirtual.Size = new System.Drawing.Size(126, 22);
            this.CBBilleteraVirtual.TabIndex = 97;
            this.CBBilleteraVirtual.Text = "Billetera Virtual";
            this.CBBilleteraVirtual.UseVisualStyleBackColor = true;
            this.CBBilleteraVirtual.CheckedChanged += new System.EventHandler(this.CBBilleteraVirtual_CheckedChanged);
            // 
            // CBTarjetaDeDebito
            // 
            this.CBTarjetaDeDebito.AutoSize = true;
            this.CBTarjetaDeDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBTarjetaDeDebito.Location = new System.Drawing.Point(471, 237);
            this.CBTarjetaDeDebito.Margin = new System.Windows.Forms.Padding(4);
            this.CBTarjetaDeDebito.Name = "CBTarjetaDeDebito";
            this.CBTarjetaDeDebito.Size = new System.Drawing.Size(142, 22);
            this.CBTarjetaDeDebito.TabIndex = 96;
            this.CBTarjetaDeDebito.Text = "Tarjeta de Debito";
            this.CBTarjetaDeDebito.UseVisualStyleBackColor = true;
            // 
            // CBTarjetaDeCredito
            // 
            this.CBTarjetaDeCredito.AutoSize = true;
            this.CBTarjetaDeCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBTarjetaDeCredito.Location = new System.Drawing.Point(294, 237);
            this.CBTarjetaDeCredito.Margin = new System.Windows.Forms.Padding(4);
            this.CBTarjetaDeCredito.Name = "CBTarjetaDeCredito";
            this.CBTarjetaDeCredito.Size = new System.Drawing.Size(147, 22);
            this.CBTarjetaDeCredito.TabIndex = 95;
            this.CBTarjetaDeCredito.Text = "Tarjeta de Credito";
            this.CBTarjetaDeCredito.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(79, 234);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 23);
            this.label7.TabIndex = 94;
            this.label7.Text = "Metodo de pago";
            // 
            // LCorreoCompraFinCompra
            // 
            this.LCorreoCompraFinCompra.AutoSize = true;
            this.LCorreoCompraFinCompra.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCorreoCompraFinCompra.ForeColor = System.Drawing.Color.MediumBlue;
            this.LCorreoCompraFinCompra.Location = new System.Drawing.Point(677, 183);
            this.LCorreoCompraFinCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LCorreoCompraFinCompra.Name = "LCorreoCompraFinCompra";
            this.LCorreoCompraFinCompra.Size = new System.Drawing.Size(172, 20);
            this.LCorreoCompraFinCompra.TabIndex = 93;
            this.LCorreoCompraFinCompra.Text = "correo@example.com";
            // 
            // LDireccionCompraFinCompra
            // 
            this.LDireccionCompraFinCompra.AutoSize = true;
            this.LDireccionCompraFinCompra.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDireccionCompraFinCompra.ForeColor = System.Drawing.Color.MediumBlue;
            this.LDireccionCompraFinCompra.Location = new System.Drawing.Point(677, 152);
            this.LDireccionCompraFinCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LDireccionCompraFinCompra.Name = "LDireccionCompraFinCompra";
            this.LDireccionCompraFinCompra.Size = new System.Drawing.Size(119, 20);
            this.LDireccionCompraFinCompra.TabIndex = 92;
            this.LDireccionCompraFinCompra.Text = "Calle Falsa; 123";
            // 
            // LTelefonoCompraFinCompra
            // 
            this.LTelefonoCompraFinCompra.AutoSize = true;
            this.LTelefonoCompraFinCompra.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTelefonoCompraFinCompra.ForeColor = System.Drawing.Color.MediumBlue;
            this.LTelefonoCompraFinCompra.Location = new System.Drawing.Point(677, 120);
            this.LTelefonoCompraFinCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTelefonoCompraFinCompra.Name = "LTelefonoCompraFinCompra";
            this.LTelefonoCompraFinCompra.Size = new System.Drawing.Size(89, 20);
            this.LTelefonoCompraFinCompra.TabIndex = 91;
            this.LTelefonoCompraFinCompra.Text = "3794097654";
            // 
            // LDNICompraFinCompra
            // 
            this.LDNICompraFinCompra.AutoSize = true;
            this.LDNICompraFinCompra.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDNICompraFinCompra.ForeColor = System.Drawing.Color.MediumBlue;
            this.LDNICompraFinCompra.Location = new System.Drawing.Point(311, 183);
            this.LDNICompraFinCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LDNICompraFinCompra.Name = "LDNICompraFinCompra";
            this.LDNICompraFinCompra.Size = new System.Drawing.Size(73, 20);
            this.LDNICompraFinCompra.TabIndex = 90;
            this.LDNICompraFinCompra.Text = "37890275";
            // 
            // LApellidosCompraFinCompra
            // 
            this.LApellidosCompraFinCompra.AutoSize = true;
            this.LApellidosCompraFinCompra.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellidosCompraFinCompra.ForeColor = System.Drawing.Color.MediumBlue;
            this.LApellidosCompraFinCompra.Location = new System.Drawing.Point(311, 152);
            this.LApellidosCompraFinCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LApellidosCompraFinCompra.Name = "LApellidosCompraFinCompra";
            this.LApellidosCompraFinCompra.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LApellidosCompraFinCompra.Size = new System.Drawing.Size(49, 20);
            this.LApellidosCompraFinCompra.TabIndex = 89;
            this.LApellidosCompraFinCompra.Text = "Perez";
            // 
            // LNombreCompraFinCompra
            // 
            this.LNombreCompraFinCompra.AutoSize = true;
            this.LNombreCompraFinCompra.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreCompraFinCompra.ForeColor = System.Drawing.Color.MediumBlue;
            this.LNombreCompraFinCompra.Location = new System.Drawing.Point(311, 120);
            this.LNombreCompraFinCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LNombreCompraFinCompra.Name = "LNombreCompraFinCompra";
            this.LNombreCompraFinCompra.Size = new System.Drawing.Size(50, 20);
            this.LNombreCompraFinCompra.TabIndex = 88;
            this.LNombreCompraFinCompra.Text = "Julian";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(580, 183);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 87;
            this.label6.Text = "Correo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(215, 183);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 86;
            this.label5.Text = "DNI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(580, 152);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 85;
            this.label4.Text = "Direccion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(580, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 84;
            this.label3.Text = "Telefono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(213, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 83;
            this.label2.Text = "Apellidos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 82;
            this.label1.Text = "Nombres:";
            // 
            // LVenta
            // 
            this.LVenta.AutoSize = true;
            this.LVenta.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVenta.Location = new System.Drawing.Point(40, 20);
            this.LVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LVenta.Name = "LVenta";
            this.LVenta.Size = new System.Drawing.Size(126, 44);
            this.LVenta.TabIndex = 79;
            this.LVenta.Text = "Venta";
            // 
            // LIDCompra
            // 
            this.LIDCompra.AutoSize = true;
            this.LIDCompra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LIDCompra.Location = new System.Drawing.Point(745, 36);
            this.LIDCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LIDCompra.Name = "LIDCompra";
            this.LIDCompra.Size = new System.Drawing.Size(104, 23);
            this.LIDCompra.TabIndex = 106;
            this.LIDCompra.Text = "ID VENTA:";
            // 
            // LIDCompraValorVentaDetalle
            // 
            this.LIDCompraValorVentaDetalle.AutoSize = true;
            this.LIDCompraValorVentaDetalle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LIDCompraValorVentaDetalle.ForeColor = System.Drawing.Color.Blue;
            this.LIDCompraValorVentaDetalle.Location = new System.Drawing.Point(857, 36);
            this.LIDCompraValorVentaDetalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LIDCompraValorVentaDetalle.Name = "LIDCompraValorVentaDetalle";
            this.LIDCompraValorVentaDetalle.Size = new System.Drawing.Size(43, 23);
            this.LIDCompraValorVentaDetalle.TabIndex = 107;
            this.LIDCompraValorVentaDetalle.Text = "231";
            // 
            // VentaDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1031, 598);
            this.Controls.Add(this.LIDCompraValorVentaDetalle);
            this.Controls.Add(this.LIDCompra);
            this.Controls.Add(this.BImprimirDetalle);
            this.Controls.Add(this.LTotalFinalizarCompra);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DGVentaDetalle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CBEfectivo);
            this.Controls.Add(this.CBBilleteraVirtual);
            this.Controls.Add(this.CBTarjetaDeDebito);
            this.Controls.Add(this.CBTarjetaDeCredito);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LCorreoCompraFinCompra);
            this.Controls.Add(this.LDireccionCompraFinCompra);
            this.Controls.Add(this.LTelefonoCompraFinCompra);
            this.Controls.Add(this.LDNICompraFinCompra);
            this.Controls.Add(this.LApellidosCompraFinCompra);
            this.Controls.Add(this.LNombreCompraFinCompra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LVenta);
            this.Name = "VentaDetalle";
            this.Text = "VentaDetalle";
            ((System.ComponentModel.ISupportInitialize)(this.DGVentaDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BImprimirDetalle;
        private System.Windows.Forms.Label LTotalFinalizarCompra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView DGVentaDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox CBEfectivo;
        private System.Windows.Forms.CheckBox CBBilleteraVirtual;
        private System.Windows.Forms.CheckBox CBTarjetaDeDebito;
        private System.Windows.Forms.CheckBox CBTarjetaDeCredito;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LCorreoCompraFinCompra;
        private System.Windows.Forms.Label LDireccionCompraFinCompra;
        private System.Windows.Forms.Label LTelefonoCompraFinCompra;
        private System.Windows.Forms.Label LDNICompraFinCompra;
        private System.Windows.Forms.Label LApellidosCompraFinCompra;
        private System.Windows.Forms.Label LNombreCompraFinCompra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LVenta;
        private System.Windows.Forms.Label LIDCompra;
        private System.Windows.Forms.Label LIDCompraValorVentaDetalle;
    }
}