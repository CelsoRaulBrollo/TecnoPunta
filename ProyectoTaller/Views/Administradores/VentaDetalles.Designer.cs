namespace ProyectoTaller.Views.Vendedor
{
    partial class VentaDetalles
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
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CBEfectivo = new System.Windows.Forms.CheckBox();
            this.CBBilleteraVirtual = new System.Windows.Forms.CheckBox();
            this.CBTarjetaDeDebito = new System.Windows.Forms.CheckBox();
            this.CBTarjetaDeCredito = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LCorreoVenta = new System.Windows.Forms.Label();
            this.LDireccionVenta = new System.Windows.Forms.Label();
            this.LTelefonoVenta = new System.Windows.Forms.Label();
            this.LDNIVenta = new System.Windows.Forms.Label();
            this.LApellidosVenta = new System.Windows.Forms.Label();
            this.LNombreCompraVenta = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LVenta = new System.Windows.Forms.Label();
            this.LIDCompra = new System.Windows.Forms.Label();
            this.LIDVenta = new System.Windows.Forms.Label();
            this.LTotalVista = new System.Windows.Forms.Label();
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
            this.DGVentaDetalle.Location = new System.Drawing.Point(83, 342);
            this.DGVentaDetalle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVentaDetalle.Name = "DGVentaDetalle";
            this.DGVentaDetalle.RowHeadersWidth = 51;
            this.DGVentaDetalle.RowTemplate.Height = 24;
            this.DGVentaDetalle.Size = new System.Drawing.Size(874, 139);
            this.DGVentaDetalle.TabIndex = 101;
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
            // LCorreoVenta
            // 
            this.LCorreoVenta.AutoSize = true;
            this.LCorreoVenta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCorreoVenta.ForeColor = System.Drawing.Color.MediumBlue;
            this.LCorreoVenta.Location = new System.Drawing.Point(677, 183);
            this.LCorreoVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LCorreoVenta.Name = "LCorreoVenta";
            this.LCorreoVenta.Size = new System.Drawing.Size(0, 20);
            this.LCorreoVenta.TabIndex = 93;
            // 
            // LDireccionVenta
            // 
            this.LDireccionVenta.AutoSize = true;
            this.LDireccionVenta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDireccionVenta.ForeColor = System.Drawing.Color.MediumBlue;
            this.LDireccionVenta.Location = new System.Drawing.Point(677, 152);
            this.LDireccionVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LDireccionVenta.Name = "LDireccionVenta";
            this.LDireccionVenta.Size = new System.Drawing.Size(0, 20);
            this.LDireccionVenta.TabIndex = 92;
            // 
            // LTelefonoVenta
            // 
            this.LTelefonoVenta.AutoSize = true;
            this.LTelefonoVenta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTelefonoVenta.ForeColor = System.Drawing.Color.MediumBlue;
            this.LTelefonoVenta.Location = new System.Drawing.Point(677, 120);
            this.LTelefonoVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTelefonoVenta.Name = "LTelefonoVenta";
            this.LTelefonoVenta.Size = new System.Drawing.Size(0, 20);
            this.LTelefonoVenta.TabIndex = 91;
            // 
            // LDNIVenta
            // 
            this.LDNIVenta.AutoSize = true;
            this.LDNIVenta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDNIVenta.ForeColor = System.Drawing.Color.MediumBlue;
            this.LDNIVenta.Location = new System.Drawing.Point(311, 183);
            this.LDNIVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LDNIVenta.Name = "LDNIVenta";
            this.LDNIVenta.Size = new System.Drawing.Size(0, 20);
            this.LDNIVenta.TabIndex = 90;
            // 
            // LApellidosVenta
            // 
            this.LApellidosVenta.AutoSize = true;
            this.LApellidosVenta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellidosVenta.ForeColor = System.Drawing.Color.MediumBlue;
            this.LApellidosVenta.Location = new System.Drawing.Point(311, 152);
            this.LApellidosVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LApellidosVenta.Name = "LApellidosVenta";
            this.LApellidosVenta.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LApellidosVenta.Size = new System.Drawing.Size(0, 20);
            this.LApellidosVenta.TabIndex = 89;
            // 
            // LNombreCompraVenta
            // 
            this.LNombreCompraVenta.AutoSize = true;
            this.LNombreCompraVenta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreCompraVenta.ForeColor = System.Drawing.Color.MediumBlue;
            this.LNombreCompraVenta.Location = new System.Drawing.Point(311, 120);
            this.LNombreCompraVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LNombreCompraVenta.Name = "LNombreCompraVenta";
            this.LNombreCompraVenta.Size = new System.Drawing.Size(0, 20);
            this.LNombreCompraVenta.TabIndex = 88;
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
            // LIDVenta
            // 
            this.LIDVenta.AutoSize = true;
            this.LIDVenta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LIDVenta.ForeColor = System.Drawing.Color.Blue;
            this.LIDVenta.Location = new System.Drawing.Point(857, 36);
            this.LIDVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LIDVenta.Name = "LIDVenta";
            this.LIDVenta.Size = new System.Drawing.Size(0, 23);
            this.LIDVenta.TabIndex = 107;
            // 
            // LTotalVista
            // 
            this.LTotalVista.AutoSize = true;
            this.LTotalVista.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTotalVista.Location = new System.Drawing.Point(174, 513);
            this.LTotalVista.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTotalVista.Name = "LTotalVista";
            this.LTotalVista.Size = new System.Drawing.Size(0, 39);
            this.LTotalVista.TabIndex = 108;
            // 
            // VentaDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1031, 598);
            this.Controls.Add(this.LTotalVista);
            this.Controls.Add(this.LIDVenta);
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
            this.Controls.Add(this.LCorreoVenta);
            this.Controls.Add(this.LDireccionVenta);
            this.Controls.Add(this.LTelefonoVenta);
            this.Controls.Add(this.LDNIVenta);
            this.Controls.Add(this.LApellidosVenta);
            this.Controls.Add(this.LNombreCompraVenta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LVenta);
            this.Name = "VentaDetalles";
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox CBEfectivo;
        private System.Windows.Forms.CheckBox CBBilleteraVirtual;
        private System.Windows.Forms.CheckBox CBTarjetaDeDebito;
        private System.Windows.Forms.CheckBox CBTarjetaDeCredito;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LCorreoVenta;
        private System.Windows.Forms.Label LDireccionVenta;
        private System.Windows.Forms.Label LTelefonoVenta;
        private System.Windows.Forms.Label LDNIVenta;
        private System.Windows.Forms.Label LApellidosVenta;
        private System.Windows.Forms.Label LNombreCompraVenta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LVenta;
        private System.Windows.Forms.Label LIDCompra;
        private System.Windows.Forms.Label LIDVenta;
        private System.Windows.Forms.Label LTotalVista;
    }
}