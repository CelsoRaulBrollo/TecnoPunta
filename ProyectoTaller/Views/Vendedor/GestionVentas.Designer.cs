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
            this.DGVentasVendedor = new System.Windows.Forms.DataGridView();
            this.BVerDetalle = new System.Windows.Forms.Button();
            this.BImprimirInformeVentaVendedor = new System.Windows.Forms.Button();
            this.LBVentasDiaPrint = new System.Windows.Forms.Label();
            this.LImporteTotalPrint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVentasVendedor)).BeginInit();
            this.SuspendLayout();
            // 
            // PBImagenVentas
            // 
            this.PBImagenVentas.Image = global::ProyectoTaller.Properties.Resources.VentasTitulo;
            this.PBImagenVentas.Location = new System.Drawing.Point(16, 15);
            this.PBImagenVentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PBImagenVentas.Name = "PBImagenVentas";
            this.PBImagenVentas.Size = new System.Drawing.Size(87, 82);
            this.PBImagenVentas.TabIndex = 29;
            this.PBImagenVentas.TabStop = false;
            // 
            // LTituloGestionVentas
            // 
            this.LTituloGestionVentas.AutoSize = true;
            this.LTituloGestionVentas.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloGestionVentas.Location = new System.Drawing.Point(105, 17);
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
            this.LVentaDelDia.Location = new System.Drawing.Point(169, 97);
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
            this.label1.Location = new System.Drawing.Point(652, 97);
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
            this.label2.Location = new System.Drawing.Point(427, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 44);
            this.label2.TabIndex = 40;
            this.label2.Text = "Ventas realizadas";
            // 
            // DGVentasVendedor
            // 
            this.DGVentasVendedor.AllowUserToAddRows = false;
            this.DGVentasVendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVentasVendedor.Location = new System.Drawing.Point(37, 240);
            this.DGVentasVendedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGVentasVendedor.Name = "DGVentasVendedor";
            this.DGVentasVendedor.RowHeadersWidth = 51;
            this.DGVentasVendedor.Size = new System.Drawing.Size(1099, 297);
            this.DGVentasVendedor.TabIndex = 41;
            // 
            // BVerDetalle
            // 
            this.BVerDetalle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BVerDetalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BVerDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BVerDetalle.Image = global::ProyectoTaller.Properties.Resources.Ver_detalle;
            this.BVerDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BVerDetalle.Location = new System.Drawing.Point(972, 161);
            this.BVerDetalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BVerDetalle.Name = "BVerDetalle";
            this.BVerDetalle.Size = new System.Drawing.Size(164, 64);
            this.BVerDetalle.TabIndex = 42;
            this.BVerDetalle.Text = "Ver Detalle ";
            this.BVerDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BVerDetalle.UseVisualStyleBackColor = true;
            this.BVerDetalle.Click += new System.EventHandler(this.BVerDetalle_Click);
            // 
            // BImprimirInformeVentaVendedor
            // 
            this.BImprimirInformeVentaVendedor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BImprimirInformeVentaVendedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BImprimirInformeVentaVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BImprimirInformeVentaVendedor.Image = global::ProyectoTaller.Properties.Resources.GuardarProducto;
            this.BImprimirInformeVentaVendedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BImprimirInformeVentaVendedor.Location = new System.Drawing.Point(972, 545);
            this.BImprimirInformeVentaVendedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BImprimirInformeVentaVendedor.Name = "BImprimirInformeVentaVendedor";
            this.BImprimirInformeVentaVendedor.Size = new System.Drawing.Size(164, 64);
            this.BImprimirInformeVentaVendedor.TabIndex = 43;
            this.BImprimirInformeVentaVendedor.Text = "Imprimir";
            this.BImprimirInformeVentaVendedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BImprimirInformeVentaVendedor.UseVisualStyleBackColor = true;
            // 
            // LBVentasDiaPrint
            // 
            this.LBVentasDiaPrint.AutoSize = true;
            this.LBVentasDiaPrint.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBVentasDiaPrint.Location = new System.Drawing.Point(463, 97);
            this.LBVentasDiaPrint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBVentasDiaPrint.Name = "LBVentasDiaPrint";
            this.LBVentasDiaPrint.Size = new System.Drawing.Size(0, 44);
            this.LBVentasDiaPrint.TabIndex = 44;
            // 
            // LImporteTotalPrint
            // 
            this.LImporteTotalPrint.AutoSize = true;
            this.LImporteTotalPrint.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LImporteTotalPrint.Location = new System.Drawing.Point(923, 97);
            this.LImporteTotalPrint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LImporteTotalPrint.Name = "LImporteTotalPrint";
            this.LImporteTotalPrint.Size = new System.Drawing.Size(0, 44);
            this.LImporteTotalPrint.TabIndex = 45;
            // 
            // GestionVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1183, 624);
            this.Controls.Add(this.LImporteTotalPrint);
            this.Controls.Add(this.LBVentasDiaPrint);
            this.Controls.Add(this.BImprimirInformeVentaVendedor);
            this.Controls.Add(this.BVerDetalle);
            this.Controls.Add(this.DGVentasVendedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LVentaDelDia);
            this.Controls.Add(this.LTituloGestionVentas);
            this.Controls.Add(this.PBImagenVentas);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GestionVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionVentas";
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVentasVendedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBImagenVentas;
        private System.Windows.Forms.Label LTituloGestionVentas;
        private System.Windows.Forms.Label LVentaDelDia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGVentasVendedor;
        private System.Windows.Forms.Button BVerDetalle;
        private System.Windows.Forms.Button BImprimirInformeVentaVendedor;
        private System.Windows.Forms.Label LBVentasDiaPrint;
        private System.Windows.Forms.Label LImporteTotalPrint;
    }
}