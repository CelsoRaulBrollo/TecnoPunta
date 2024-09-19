namespace ProyectoTaller.Views.Vendedor
{
    partial class Carrito
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
            this.DGCarrito = new System.Windows.Forms.DataGridView();
            this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Agregar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TVentas = new System.Windows.Forms.TextBox();
            this.BBuscarCarrito = new System.Windows.Forms.Button();
            this.LDescripcion = new System.Windows.Forms.Label();
            this.BLimpiarCarrito = new System.Windows.Forms.Button();
            this.PBImagenCarrito = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGCarrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenCarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // LTituloCarrito
            // 
            this.LTituloCarrito.AutoSize = true;
            this.LTituloCarrito.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloCarrito.Location = new System.Drawing.Point(81, 10);
            this.LTituloCarrito.Name = "LTituloCarrito";
            this.LTituloCarrito.Size = new System.Drawing.Size(110, 36);
            this.LTituloCarrito.TabIndex = 1;
            this.LTituloCarrito.Text = "Carrito";
            // 
            // DGCarrito
            // 
            this.DGCarrito.AllowUserToAddRows = false;
            this.DGCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoProducto,
            this.Descripcion,
            this.Cantidad,
            this.Precio,
            this.Agregar});
            this.DGCarrito.Location = new System.Drawing.Point(11, 123);
            this.DGCarrito.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGCarrito.Name = "DGCarrito";
            this.DGCarrito.RowHeadersWidth = 51;
            this.DGCarrito.RowTemplate.Height = 24;
            this.DGCarrito.Size = new System.Drawing.Size(865, 373);
            this.DGCarrito.TabIndex = 50;
            // 
            // CodigoProducto
            // 
            this.CodigoProducto.FillWeight = 1F;
            this.CodigoProducto.HeaderText = "Codigo Producto";
            this.CodigoProducto.MinimumWidth = 6;
            this.CodigoProducto.Name = "CodigoProducto";
            this.CodigoProducto.Width = 120;
            // 
            // Descripcion
            // 
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
            // Agregar
            // 
            this.Agregar.HeaderText = "Accion";
            this.Agregar.MinimumWidth = 6;
            this.Agregar.Name = "Agregar";
            this.Agregar.Text = "Quitar";
            this.Agregar.ToolTipText = "Quitar";
            this.Agregar.UseColumnTextForButtonValue = true;
            this.Agregar.Width = 125;
            // 
            // TVentas
            // 
            this.TVentas.Location = new System.Drawing.Point(287, 79);
            this.TVentas.Name = "TVentas";
            this.TVentas.Size = new System.Drawing.Size(277, 20);
            this.TVentas.TabIndex = 52;
            // 
            // BBuscarCarrito
            // 
            this.BBuscarCarrito.Location = new System.Drawing.Point(580, 75);
            this.BBuscarCarrito.Name = "BBuscarCarrito";
            this.BBuscarCarrito.Size = new System.Drawing.Size(75, 23);
            this.BBuscarCarrito.TabIndex = 53;
            this.BBuscarCarrito.Text = "Buscar";
            this.BBuscarCarrito.UseVisualStyleBackColor = true;
            // 
            // LDescripcion
            // 
            this.LDescripcion.AutoSize = true;
            this.LDescripcion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDescripcion.Location = new System.Drawing.Point(366, 41);
            this.LDescripcion.Name = "LDescripcion";
            this.LDescripcion.Size = new System.Drawing.Size(124, 23);
            this.LDescripcion.TabIndex = 68;
            this.LDescripcion.Text = "Descripcion:";
            // 
            // BLimpiarCarrito
            // 
            this.BLimpiarCarrito.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BLimpiarCarrito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BLimpiarCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLimpiarCarrito.Image = global::ProyectoTaller.Properties.Resources.Limpiar;
            this.BLimpiarCarrito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BLimpiarCarrito.Location = new System.Drawing.Point(753, 60);
            this.BLimpiarCarrito.Name = "BLimpiarCarrito";
            this.BLimpiarCarrito.Size = new System.Drawing.Size(123, 52);
            this.BLimpiarCarrito.TabIndex = 69;
            this.BLimpiarCarrito.Text = "Limpiar Carro";
            this.BLimpiarCarrito.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BLimpiarCarrito.UseVisualStyleBackColor = true;
            // 
            // PBImagenCarrito
            // 
            this.PBImagenCarrito.Image = global::ProyectoTaller.Properties.Resources.Carro;
            this.PBImagenCarrito.Location = new System.Drawing.Point(12, 9);
            this.PBImagenCarrito.Name = "PBImagenCarrito";
            this.PBImagenCarrito.Size = new System.Drawing.Size(65, 67);
            this.PBImagenCarrito.TabIndex = 67;
            this.PBImagenCarrito.TabStop = false;
            // 
            // Carrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(887, 507);
            this.Controls.Add(this.BLimpiarCarrito);
            this.Controls.Add(this.LDescripcion);
            this.Controls.Add(this.PBImagenCarrito);
            this.Controls.Add(this.BBuscarCarrito);
            this.Controls.Add(this.TVentas);
            this.Controls.Add(this.DGCarrito);
            this.Controls.Add(this.LTituloCarrito);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Carrito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carrito";
            ((System.ComponentModel.ISupportInitialize)(this.DGCarrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenCarrito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LTituloCarrito;
        private System.Windows.Forms.DataGridView DGCarrito;
        private System.Windows.Forms.PictureBox PBImagenCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewButtonColumn Agregar;
        private System.Windows.Forms.TextBox TVentas;
        private System.Windows.Forms.Button BBuscarCarrito;
        private System.Windows.Forms.Label LDescripcion;
        private System.Windows.Forms.Button BLimpiarCarrito;
    }
}