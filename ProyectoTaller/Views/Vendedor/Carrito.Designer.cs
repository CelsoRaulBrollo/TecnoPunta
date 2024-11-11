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
            this.LTotal = new System.Windows.Forms.Label();
            this.TTotalCarrito = new System.Windows.Forms.Label();
            this.BFinalizarCompra = new System.Windows.Forms.Button();
            this.BQuitar = new System.Windows.Forms.Button();
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
            this.DGCarrito.AllowUserToDeleteRows = false;
            this.DGCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGCarrito.Location = new System.Drawing.Point(11, 123);
            this.DGCarrito.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGCarrito.Name = "DGCarrito";
            this.DGCarrito.ReadOnly = true;
            this.DGCarrito.RowHeadersWidth = 51;
            this.DGCarrito.RowTemplate.Height = 24;
            this.DGCarrito.Size = new System.Drawing.Size(865, 305);
            this.DGCarrito.TabIndex = 50;
            this.DGCarrito.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGCarrito_CellContentClick);
            // 
            // LTotal
            // 
            this.LTotal.AutoSize = true;
            this.LTotal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTotal.Location = new System.Drawing.Point(690, 457);
            this.LTotal.Name = "LTotal";
            this.LTotal.Size = new System.Drawing.Size(59, 23);
            this.LTotal.TabIndex = 70;
            this.LTotal.Text = "Total:";
            // 
            // TTotalCarrito
            // 
            this.TTotalCarrito.AutoSize = true;
            this.TTotalCarrito.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TTotalCarrito.Location = new System.Drawing.Point(751, 457);
            this.TTotalCarrito.Name = "TTotalCarrito";
            this.TTotalCarrito.Size = new System.Drawing.Size(0, 23);
            this.TTotalCarrito.TabIndex = 71;
            // 
            // BFinalizarCompra
            // 
            this.BFinalizarCompra.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BFinalizarCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BFinalizarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BFinalizarCompra.Image = global::ProyectoTaller.Properties.Resources.Check;
            this.BFinalizarCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BFinalizarCompra.Location = new System.Drawing.Point(700, 544);
            this.BFinalizarCompra.Margin = new System.Windows.Forms.Padding(4);
            this.BFinalizarCompra.Name = "BFinalizarCompra";
            this.BFinalizarCompra.Size = new System.Drawing.Size(154, 52);
            this.BFinalizarCompra.TabIndex = 73;
            this.BFinalizarCompra.Text = "Finalizar Compra ";
            this.BFinalizarCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BFinalizarCompra.UseVisualStyleBackColor = true;
            this.BFinalizarCompra.Click += new System.EventHandler(this.BFinalizarCompra_Click);
            // 
            // BQuitar
            // 
            this.BQuitar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BQuitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BQuitar.Image = global::ProyectoTaller.Properties.Resources.Quitar;
            this.BQuitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BQuitar.Location = new System.Drawing.Point(820, 74);
            this.BQuitar.Margin = new System.Windows.Forms.Padding(4);
            this.BQuitar.Name = "BQuitar";
            this.BQuitar.Size = new System.Drawing.Size(123, 52);
            this.BQuitar.TabIndex = 72;
            this.BQuitar.Text = "Quitar       ";
            this.BQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BQuitar.UseVisualStyleBackColor = true;
            this.BQuitar.Click += new System.EventHandler(this.BQuitar_Click);
            // 
            // BLimpiarCarrito
            // 
            this.BLimpiarCarrito.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BLimpiarCarrito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BLimpiarCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLimpiarCarrito.Image = global::ProyectoTaller.Properties.Resources.Limpiar;
            this.BLimpiarCarrito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BLimpiarCarrito.Location = new System.Drawing.Point(1004, 74);
            this.BLimpiarCarrito.Margin = new System.Windows.Forms.Padding(4);
            this.BLimpiarCarrito.Name = "BLimpiarCarrito";
            this.BLimpiarCarrito.Size = new System.Drawing.Size(123, 52);
            this.BLimpiarCarrito.TabIndex = 69;
            this.BLimpiarCarrito.Text = "Limpiar Carro";
            this.BLimpiarCarrito.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BLimpiarCarrito.UseVisualStyleBackColor = true;
            this.BLimpiarCarrito.Click += new System.EventHandler(this.BLimpiarCarrito_Click);
            // 
            // PBImagenCarrito
            // 
            this.PBImagenCarrito.Image = global::ProyectoTaller.Properties.Resources.Carro;
            this.PBImagenCarrito.Location = new System.Drawing.Point(16, 11);
            this.PBImagenCarrito.Margin = new System.Windows.Forms.Padding(4);
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
            this.Controls.Add(this.BFinalizarCompra);
            this.Controls.Add(this.BQuitar);
            this.Controls.Add(this.TTotalCarrito);
            this.Controls.Add(this.LTotal);
            this.Controls.Add(this.BLimpiarCarrito);
            this.Controls.Add(this.PBImagenCarrito);
            this.Controls.Add(this.DGCarrito);
            this.Controls.Add(this.LTituloCarrito);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Carrito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Carrito_Load);
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
        private System.Windows.Forms.Label LTotal;
        private System.Windows.Forms.Label TTotalCarrito;
        private System.Windows.Forms.Button BQuitar;
        private System.Windows.Forms.Button BFinalizarCompra;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.NumericUpDown numericUpDownCantidad;
        private System.Windows.Forms.Button BAgregar;
    }
}