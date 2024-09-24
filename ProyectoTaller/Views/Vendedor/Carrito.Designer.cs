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
            this.BLimpiarCarrito = new System.Windows.Forms.Button();
            this.PBImagenCarrito = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TTotalCarrito = new System.Windows.Forms.Label();
            this.BQuitar = new System.Windows.Forms.Button();
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
            this.Precio});
            this.DGCarrito.Location = new System.Drawing.Point(11, 123);
            this.DGCarrito.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGCarrito.Name = "DGCarrito";
            this.DGCarrito.RowHeadersWidth = 51;
            this.DGCarrito.RowTemplate.Height = 24;
            this.DGCarrito.Size = new System.Drawing.Size(865, 305);
            this.DGCarrito.TabIndex = 50;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(720, 448);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 70;
            this.label1.Text = "Total:";
            // 
            // TTotalCarrito
            // 
            this.TTotalCarrito.AutoSize = true;
            this.TTotalCarrito.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TTotalCarrito.Location = new System.Drawing.Point(781, 448);
            this.TTotalCarrito.Name = "TTotalCarrito";
            this.TTotalCarrito.Size = new System.Drawing.Size(0, 23);
            this.TTotalCarrito.TabIndex = 71;
            // 
            // BQuitar
            // 
            this.BQuitar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BQuitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BQuitar.Image = global::ProyectoTaller.Properties.Resources.Quitar;
            this.BQuitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BQuitar.Location = new System.Drawing.Point(615, 60);
            this.BQuitar.Name = "BQuitar";
            this.BQuitar.Size = new System.Drawing.Size(123, 52);
            this.BQuitar.TabIndex = 72;
            this.BQuitar.Text = "Quitar       ";
            this.BQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BQuitar.UseVisualStyleBackColor = true;
            // 
            // Carrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(887, 507);
            this.Controls.Add(this.BQuitar);
            this.Controls.Add(this.TTotalCarrito);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BLimpiarCarrito);
            this.Controls.Add(this.PBImagenCarrito);
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
        private System.Windows.Forms.Button BLimpiarCarrito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TTotalCarrito;
        private System.Windows.Forms.Button BQuitar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}