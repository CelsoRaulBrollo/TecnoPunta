namespace ProyectoTaller.Views.Vendedor
{
    partial class ConfirmarVenta
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
            this.LTituloCarrito = new System.Windows.Forms.Label();
            this.LNombreCliente = new System.Windows.Forms.Label();
            this.TDNIClienteFinalizarCompra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LNombreCompraFinCompra = new System.Windows.Forms.Label();
            this.LApellidosCompraFinCompra = new System.Windows.Forms.Label();
            this.LDNICompraFinCompra = new System.Windows.Forms.Label();
            this.LCorreoCompraFinCompra = new System.Windows.Forms.Label();
            this.LDireccionCompraFinCompra = new System.Windows.Forms.Label();
            this.LTelefonoCompraFinCompra = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CBBilleteraVirtual = new System.Windows.Forms.CheckBox();
            this.CBTarjetaDeDebito = new System.Windows.Forms.CheckBox();
            this.CBTarjetaDeCredito = new System.Windows.Forms.CheckBox();
            this.CBEfectivo = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DGCarrito = new System.Windows.Forms.DataGridView();
            this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.LTotalFinalizarCompra = new System.Windows.Forms.Label();
            this.BBuscarClienteFinalizarCompra = new System.Windows.Forms.Button();
            this.BConfirmarCompraFinalizarCompra = new System.Windows.Forms.Button();
            this.BValiBuscarCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGCarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // LTituloCarrito
            // 
            this.LTituloCarrito.AutoSize = true;
            this.LTituloCarrito.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloCarrito.Location = new System.Drawing.Point(36, 29);
            this.LTituloCarrito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTituloCarrito.Name = "LTituloCarrito";
            this.LTituloCarrito.Size = new System.Drawing.Size(321, 44);
            this.LTituloCarrito.TabIndex = 2;
            this.LTituloCarrito.Text = "Finalizar Compra";
            // 
            // LNombreCliente
            // 
            this.LNombreCliente.AutoSize = true;
            this.LNombreCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreCliente.Location = new System.Drawing.Point(221, 132);
            this.LNombreCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LNombreCliente.Name = "LNombreCliente";
            this.LNombreCliente.Size = new System.Drawing.Size(136, 21);
            this.LNombreCliente.TabIndex = 52;
            this.LNombreCliente.Text = "DNI del Cliente";
            // 
            // TDNIClienteFinalizarCompra
            // 
            this.TDNIClienteFinalizarCompra.Location = new System.Drawing.Point(388, 131);
            this.TDNIClienteFinalizarCompra.Margin = new System.Windows.Forms.Padding(4);
            this.TDNIClienteFinalizarCompra.Name = "TDNIClienteFinalizarCompra";
            this.TDNIClienteFinalizarCompra.Size = new System.Drawing.Size(272, 22);
            this.TDNIClienteFinalizarCompra.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 191);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 54;
            this.label1.Text = "Nombres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 223);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "Apellidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(588, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 56;
            this.label3.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(588, 223);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 57;
            this.label4.Text = "Direccion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(223, 254);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 58;
            this.label5.Text = "DNI:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(588, 254);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 59;
            this.label6.Text = "Correo:";
            // 
            // LNombreCompraFinCompra
            // 
            this.LNombreCompraFinCompra.AutoSize = true;
            this.LNombreCompraFinCompra.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreCompraFinCompra.ForeColor = System.Drawing.Color.MediumBlue;
            this.LNombreCompraFinCompra.Location = new System.Drawing.Point(319, 191);
            this.LNombreCompraFinCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LNombreCompraFinCompra.Name = "LNombreCompraFinCompra";
            this.LNombreCompraFinCompra.Size = new System.Drawing.Size(50, 20);
            this.LNombreCompraFinCompra.TabIndex = 60;
            this.LNombreCompraFinCompra.Text = "Julian";
            // 
            // LApellidosCompraFinCompra
            // 
            this.LApellidosCompraFinCompra.AutoSize = true;
            this.LApellidosCompraFinCompra.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellidosCompraFinCompra.ForeColor = System.Drawing.Color.MediumBlue;
            this.LApellidosCompraFinCompra.Location = new System.Drawing.Point(319, 223);
            this.LApellidosCompraFinCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LApellidosCompraFinCompra.Name = "LApellidosCompraFinCompra";
            this.LApellidosCompraFinCompra.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LApellidosCompraFinCompra.Size = new System.Drawing.Size(49, 20);
            this.LApellidosCompraFinCompra.TabIndex = 61;
            this.LApellidosCompraFinCompra.Text = "Perez";
            // 
            // LDNICompraFinCompra
            // 
            this.LDNICompraFinCompra.AutoSize = true;
            this.LDNICompraFinCompra.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDNICompraFinCompra.ForeColor = System.Drawing.Color.MediumBlue;
            this.LDNICompraFinCompra.Location = new System.Drawing.Point(319, 254);
            this.LDNICompraFinCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LDNICompraFinCompra.Name = "LDNICompraFinCompra";
            this.LDNICompraFinCompra.Size = new System.Drawing.Size(73, 20);
            this.LDNICompraFinCompra.TabIndex = 62;
            this.LDNICompraFinCompra.Text = "37890275";
            // 
            // LCorreoCompraFinCompra
            // 
            this.LCorreoCompraFinCompra.AutoSize = true;
            this.LCorreoCompraFinCompra.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCorreoCompraFinCompra.ForeColor = System.Drawing.Color.MediumBlue;
            this.LCorreoCompraFinCompra.Location = new System.Drawing.Point(685, 254);
            this.LCorreoCompraFinCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LCorreoCompraFinCompra.Name = "LCorreoCompraFinCompra";
            this.LCorreoCompraFinCompra.Size = new System.Drawing.Size(172, 20);
            this.LCorreoCompraFinCompra.TabIndex = 65;
            this.LCorreoCompraFinCompra.Text = "correo@example.com";
            // 
            // LDireccionCompraFinCompra
            // 
            this.LDireccionCompraFinCompra.AutoSize = true;
            this.LDireccionCompraFinCompra.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDireccionCompraFinCompra.ForeColor = System.Drawing.Color.MediumBlue;
            this.LDireccionCompraFinCompra.Location = new System.Drawing.Point(685, 223);
            this.LDireccionCompraFinCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LDireccionCompraFinCompra.Name = "LDireccionCompraFinCompra";
            this.LDireccionCompraFinCompra.Size = new System.Drawing.Size(119, 20);
            this.LDireccionCompraFinCompra.TabIndex = 64;
            this.LDireccionCompraFinCompra.Text = "Calle Falsa; 123";
            // 
            // LTelefonoCompraFinCompra
            // 
            this.LTelefonoCompraFinCompra.AutoSize = true;
            this.LTelefonoCompraFinCompra.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTelefonoCompraFinCompra.ForeColor = System.Drawing.Color.MediumBlue;
            this.LTelefonoCompraFinCompra.Location = new System.Drawing.Point(685, 191);
            this.LTelefonoCompraFinCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTelefonoCompraFinCompra.Name = "LTelefonoCompraFinCompra";
            this.LTelefonoCompraFinCompra.Size = new System.Drawing.Size(89, 20);
            this.LTelefonoCompraFinCompra.TabIndex = 63;
            this.LTelefonoCompraFinCompra.Text = "3794097654";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(87, 302);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 23);
            this.label7.TabIndex = 66;
            this.label7.Text = "Metodo de pago";
            // 
            // CBBilleteraVirtual
            // 
            this.CBBilleteraVirtual.AutoSize = true;
            this.CBBilleteraVirtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBBilleteraVirtual.Location = new System.Drawing.Point(530, 347);
            this.CBBilleteraVirtual.Margin = new System.Windows.Forms.Padding(4);
            this.CBBilleteraVirtual.Name = "CBBilleteraVirtual";
            this.CBBilleteraVirtual.Size = new System.Drawing.Size(126, 22);
            this.CBBilleteraVirtual.TabIndex = 69;
            this.CBBilleteraVirtual.Text = "Billetera Virtual";
            this.CBBilleteraVirtual.UseVisualStyleBackColor = true;
            // 
            // CBTarjetaDeDebito
            // 
            this.CBTarjetaDeDebito.AutoSize = true;
            this.CBTarjetaDeDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBTarjetaDeDebito.Location = new System.Drawing.Point(380, 347);
            this.CBTarjetaDeDebito.Margin = new System.Windows.Forms.Padding(4);
            this.CBTarjetaDeDebito.Name = "CBTarjetaDeDebito";
            this.CBTarjetaDeDebito.Size = new System.Drawing.Size(142, 22);
            this.CBTarjetaDeDebito.TabIndex = 68;
            this.CBTarjetaDeDebito.Text = "Tarjeta de Debito";
            this.CBTarjetaDeDebito.UseVisualStyleBackColor = true;
            // 
            // CBTarjetaDeCredito
            // 
            this.CBTarjetaDeCredito.AutoSize = true;
            this.CBTarjetaDeCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBTarjetaDeCredito.Location = new System.Drawing.Point(225, 347);
            this.CBTarjetaDeCredito.Margin = new System.Windows.Forms.Padding(4);
            this.CBTarjetaDeCredito.Name = "CBTarjetaDeCredito";
            this.CBTarjetaDeCredito.Size = new System.Drawing.Size(147, 22);
            this.CBTarjetaDeCredito.TabIndex = 67;
            this.CBTarjetaDeCredito.Text = "Tarjeta de Credito";
            this.CBTarjetaDeCredito.UseVisualStyleBackColor = true;
            // 
            // CBEfectivo
            // 
            this.CBEfectivo.AutoSize = true;
            this.CBEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBEfectivo.Location = new System.Drawing.Point(664, 347);
            this.CBEfectivo.Margin = new System.Windows.Forms.Padding(4);
            this.CBEfectivo.Name = "CBEfectivo";
            this.CBEfectivo.Size = new System.Drawing.Size(83, 22);
            this.CBEfectivo.TabIndex = 70;
            this.CBEfectivo.Text = "Efectivo";
            this.CBEfectivo.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(87, 96);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 23);
            this.label8.TabIndex = 71;
            this.label8.Text = "Cliente";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(87, 390);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 23);
            this.label9.TabIndex = 72;
            this.label9.Text = "DetalleFactura";
            // 
            // DGCarrito
            // 
            this.DGCarrito.AllowUserToAddRows = false;
            this.DGCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoProducto,
            this.Descripcion,
            this.Cantidad,
            this.Precio});
            this.DGCarrito.Location = new System.Drawing.Point(91, 429);
            this.DGCarrito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGCarrito.Name = "DGCarrito";
            this.DGCarrito.RowHeadersWidth = 51;
            this.DGCarrito.RowTemplate.Height = 24;
            this.DGCarrito.Size = new System.Drawing.Size(874, 139);
            this.DGCarrito.TabIndex = 73;
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(87, 601);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 39);
            this.label10.TabIndex = 74;
            this.label10.Text = "Total:";
            // 
            // LTotalFinalizarCompra
            // 
            this.LTotalFinalizarCompra.AutoSize = true;
            this.LTotalFinalizarCompra.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTotalFinalizarCompra.Location = new System.Drawing.Point(197, 601);
            this.LTotalFinalizarCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTotalFinalizarCompra.Name = "LTotalFinalizarCompra";
            this.LTotalFinalizarCompra.Size = new System.Drawing.Size(0, 39);
            this.LTotalFinalizarCompra.TabIndex = 75;
            // 
            // BBuscarClienteFinalizarCompra
            // 
            this.BBuscarClienteFinalizarCompra.Location = new System.Drawing.Point(689, 128);
            this.BBuscarClienteFinalizarCompra.Name = "BBuscarClienteFinalizarCompra";
            this.BBuscarClienteFinalizarCompra.Size = new System.Drawing.Size(101, 28);
            this.BBuscarClienteFinalizarCompra.TabIndex = 76;
            this.BBuscarClienteFinalizarCompra.Text = "Buscar";
            this.BBuscarClienteFinalizarCompra.UseVisualStyleBackColor = true;
            // 
            // BConfirmarCompraFinalizarCompra
            // 
            this.BConfirmarCompraFinalizarCompra.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BConfirmarCompraFinalizarCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BConfirmarCompraFinalizarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BConfirmarCompraFinalizarCompra.Image = global::ProyectoTaller.Properties.Resources.Check;
            this.BConfirmarCompraFinalizarCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BConfirmarCompraFinalizarCompra.Location = new System.Drawing.Point(714, 596);
            this.BConfirmarCompraFinalizarCompra.Margin = new System.Windows.Forms.Padding(4);
            this.BConfirmarCompraFinalizarCompra.Name = "BConfirmarCompraFinalizarCompra";
            this.BConfirmarCompraFinalizarCompra.Size = new System.Drawing.Size(219, 64);
            this.BConfirmarCompraFinalizarCompra.TabIndex = 77;
            this.BConfirmarCompraFinalizarCompra.Text = "Confirmar Compra";
            this.BConfirmarCompraFinalizarCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BConfirmarCompraFinalizarCompra.UseVisualStyleBackColor = true;
            this.BConfirmarCompraFinalizarCompra.Click += new System.EventHandler(this.BConfirmarCompraFinalizarCompra_Click);
            // 
            // BValiBuscarCliente
            // 
            this.BValiBuscarCliente.AutoSize = true;
            this.BValiBuscarCliente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BValiBuscarCliente.ForeColor = System.Drawing.Color.Red;
            this.BValiBuscarCliente.Location = new System.Drawing.Point(384, 157);
            this.BValiBuscarCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BValiBuscarCliente.Name = "BValiBuscarCliente";
            this.BValiBuscarCliente.Size = new System.Drawing.Size(0, 20);
            this.BValiBuscarCliente.TabIndex = 78;
            // 
            // ConfirmarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1012, 690);
            this.Controls.Add(this.BValiBuscarCliente);
            this.Controls.Add(this.BConfirmarCompraFinalizarCompra);
            this.Controls.Add(this.BBuscarClienteFinalizarCompra);
            this.Controls.Add(this.LTotalFinalizarCompra);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DGCarrito);
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
            this.Controls.Add(this.LNombreCliente);
            this.Controls.Add(this.TDNIClienteFinalizarCompra);
            this.Controls.Add(this.LTituloCarrito);
            this.Name = "ConfirmarVenta";
            this.Text = "ConfirmarVenta";
            this.Load += new System.EventHandler(this.ConfirmarVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGCarrito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LTituloCarrito;
        private System.Windows.Forms.Label LNombreCliente;
        private System.Windows.Forms.TextBox TDNIClienteFinalizarCompra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LNombreCompraFinCompra;
        private System.Windows.Forms.Label LApellidosCompraFinCompra;
        private System.Windows.Forms.Label LDNICompraFinCompra;
        private System.Windows.Forms.Label LCorreoCompraFinCompra;
        private System.Windows.Forms.Label LDireccionCompraFinCompra;
        private System.Windows.Forms.Label LTelefonoCompraFinCompra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox CBBilleteraVirtual;
        private System.Windows.Forms.CheckBox CBTarjetaDeDebito;
        private System.Windows.Forms.CheckBox CBTarjetaDeCredito;
        private System.Windows.Forms.CheckBox CBEfectivo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView DGCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LTotalFinalizarCompra;
        private System.Windows.Forms.Button BBuscarClienteFinalizarCompra;
        private System.Windows.Forms.Button BConfirmarCompraFinalizarCompra;
        private System.Windows.Forms.Label BValiBuscarCliente;
    }
}