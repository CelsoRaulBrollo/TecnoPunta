namespace ProyectoTaller.Views.Vendedor
{
    partial class GestionVentas
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
            this.PBImagenVentas = new System.Windows.Forms.PictureBox();
            this.LTituloGestionVentas = new System.Windows.Forms.Label();
            this.LVentaDelDia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CIdVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMedioPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BVerDetalle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PBImagenVentas
            // 
            this.PBImagenVentas.Image = global::ProyectoTaller.Properties.Resources.VentasTitulo;
            this.PBImagenVentas.Location = new System.Drawing.Point(16, 15);
            this.PBImagenVentas.Margin = new System.Windows.Forms.Padding(4);
            this.PBImagenVentas.Name = "PBImagenVentas";
            this.PBImagenVentas.Size = new System.Drawing.Size(87, 82);
            this.PBImagenVentas.TabIndex = 29;
            this.PBImagenVentas.TabStop = false;
            // 
            // LTituloGestionVentas
            // 
            this.LTituloGestionVentas.AutoSize = true;
            this.LTituloGestionVentas.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloGestionVentas.Location = new System.Drawing.Point(111, 30);
            this.LTituloGestionVentas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTituloGestionVentas.Name = "LTituloGestionVentas";
            this.LTituloGestionVentas.Size = new System.Drawing.Size(358, 44);
            this.LTituloGestionVentas.TabIndex = 30;
            this.LTituloGestionVentas.Text = "Informes de ventas";
            // 
            // LVentaDelDia
            // 
            this.LVentaDelDia.AutoSize = true;
            this.LVentaDelDia.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVentaDelDia.Location = new System.Drawing.Point(149, 108);
            this.LVentaDelDia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LVentaDelDia.Name = "LVentaDelDia";
            this.LVentaDelDia.Size = new System.Drawing.Size(286, 44);
            this.LVentaDelDia.TabIndex = 38;
            this.LVentaDelDia.Text = "Ventas del dia:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(632, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 44);
            this.label1.TabIndex = 39;
            this.label1.Text = "Importe Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(424, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 44);
            this.label2.TabIndex = 40;
            this.label2.Text = "Ventas realizadas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIdVenta,
            this.CNombreCliente,
            this.CFecha,
            this.CMedioPago,
            this.CSubtotal});
            this.dataGridView1.Location = new System.Drawing.Point(35, 258);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1098, 297);
            this.dataGridView1.TabIndex = 41;
            // 
            // CIdVenta
            // 
            this.CIdVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CIdVenta.HeaderText = "ID Venta";
            this.CIdVenta.MinimumWidth = 6;
            this.CIdVenta.Name = "CIdVenta";
            this.CIdVenta.Width = 120;
            // 
            // CNombreCliente
            // 
            this.CNombreCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CNombreCliente.HeaderText = "Nombre Cliente";
            this.CNombreCliente.MinimumWidth = 6;
            this.CNombreCliente.Name = "CNombreCliente";
            this.CNombreCliente.Width = 180;
            // 
            // CFecha
            // 
            this.CFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CFecha.HeaderText = "Fecha de Facturacion";
            this.CFecha.MinimumWidth = 6;
            this.CFecha.Name = "CFecha";
            this.CFecha.Width = 200;
            // 
            // CMedioPago
            // 
            this.CMedioPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CMedioPago.HeaderText = "Medio de Pago";
            this.CMedioPago.MinimumWidth = 6;
            this.CMedioPago.Name = "CMedioPago";
            this.CMedioPago.Width = 200;
            // 
            // CSubtotal
            // 
            this.CSubtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CSubtotal.HeaderText = "Total";
            this.CSubtotal.MinimumWidth = 6;
            this.CSubtotal.Name = "CSubtotal";
            this.CSubtotal.Width = 125;
            // 
            // BVerDetalle
            // 
            this.BVerDetalle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BVerDetalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BVerDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BVerDetalle.Image = global::ProyectoTaller.Properties.Resources.Ver_detalle;
            this.BVerDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BVerDetalle.Location = new System.Drawing.Point(969, 180);
            this.BVerDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.BVerDetalle.Name = "BVerDetalle";
            this.BVerDetalle.Size = new System.Drawing.Size(164, 64);
            this.BVerDetalle.TabIndex = 42;
            this.BVerDetalle.Text = "Ver Detalle ";
            this.BVerDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BVerDetalle.UseVisualStyleBackColor = true;
            this.BVerDetalle.Click += new System.EventHandler(this.BVerDetalle_Click);
            // 
            // GestionVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1183, 624);
            this.Controls.Add(this.BVerDetalle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LVentaDelDia);
            this.Controls.Add(this.LTituloGestionVentas);
            this.Controls.Add(this.PBImagenVentas);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GestionVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionVentas";
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBImagenVentas;
        private System.Windows.Forms.Label LTituloGestionVentas;
        private System.Windows.Forms.Label LVentaDelDia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIdVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMedioPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSubtotal;
        private System.Windows.Forms.Button BVerDetalle;
    }
}