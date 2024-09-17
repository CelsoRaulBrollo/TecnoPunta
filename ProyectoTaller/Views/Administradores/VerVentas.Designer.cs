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
            this.TVentas = new System.Windows.Forms.TextBox();
            this.BBuscarVentas = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CNombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMedioPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProductosComprados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.BVerDetalle = new System.Windows.Forms.Button();
            this.PBImagenTitulo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenTitulo)).BeginInit();
            this.SuspendLayout();
            // 
            // LTituloVentas
            // 
            this.LTituloVentas.AutoSize = true;
            this.LTituloVentas.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloVentas.Location = new System.Drawing.Point(83, 12);
            this.LTituloVentas.Name = "LTituloVentas";
            this.LTituloVentas.Size = new System.Drawing.Size(112, 36);
            this.LTituloVentas.TabIndex = 1;
            this.LTituloVentas.Text = "Ventas";
            // 
            // TVentas
            // 
            this.TVentas.Location = new System.Drawing.Point(294, 78);
            this.TVentas.Name = "TVentas";
            this.TVentas.Size = new System.Drawing.Size(277, 20);
            this.TVentas.TabIndex = 29;
            // 
            // BBuscarVentas
            // 
            this.BBuscarVentas.Location = new System.Drawing.Point(577, 75);
            this.BBuscarVentas.Name = "BBuscarVentas";
            this.BBuscarVentas.Size = new System.Drawing.Size(75, 23);
            this.BBuscarVentas.TabIndex = 30;
            this.BBuscarVentas.Text = "Buscar";
            this.BBuscarVentas.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CNombreCliente,
            this.CFecha,
            this.CMedioPago,
            this.CProductosComprados,
            this.CSubtotal});
            this.dataGridView1.Location = new System.Drawing.Point(12, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(863, 374);
            this.dataGridView1.TabIndex = 31;
            // 
            // CNombreCliente
            // 
            this.CNombreCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CNombreCliente.HeaderText = "Nombre Cliente";
            this.CNombreCliente.Name = "CNombreCliente";
            this.CNombreCliente.Width = 210;
            // 
            // CFecha
            // 
            this.CFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CFecha.HeaderText = "Fecha";
            this.CFecha.Name = "CFecha";
            this.CFecha.Width = 150;
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
            this.CSubtotal.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 41);
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
            this.BVerDetalle.Location = new System.Drawing.Point(752, 60);
            this.BVerDetalle.Name = "BVerDetalle";
            this.BVerDetalle.Size = new System.Drawing.Size(123, 52);
            this.BVerDetalle.TabIndex = 33;
            this.BVerDetalle.Text = "Ver Detalle ";
            this.BVerDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BVerDetalle.UseVisualStyleBackColor = true;
            // 
            // PBImagenTitulo
            // 
            this.PBImagenTitulo.Image = global::ProyectoTaller.Properties.Resources.VentasTitulo;
            this.PBImagenTitulo.Location = new System.Drawing.Point(12, 12);
            this.PBImagenTitulo.Name = "PBImagenTitulo";
            this.PBImagenTitulo.Size = new System.Drawing.Size(65, 67);
            this.PBImagenTitulo.TabIndex = 28;
            this.PBImagenTitulo.TabStop = false;
            // 
            // VerVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(887, 507);
            this.Controls.Add(this.BVerDetalle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BBuscarVentas);
            this.Controls.Add(this.TVentas);
            this.Controls.Add(this.PBImagenTitulo);
            this.Controls.Add(this.LTituloVentas);
            this.Name = "VerVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerVentas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenTitulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LTituloVentas;
        private System.Windows.Forms.PictureBox PBImagenTitulo;
        private System.Windows.Forms.TextBox TVentas;
        private System.Windows.Forms.Button BBuscarVentas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMedioPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProductosComprados;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSubtotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BVerDetalle;
    }
}