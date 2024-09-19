namespace ProyectoTaller.Views.Vendedor
{
    partial class ConsultarProducto
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
            this.LTituloAgregar = new System.Windows.Forms.Label();
            this.BBuscarProducto = new System.Windows.Forms.Button();
            this.TDescripcion = new System.Windows.Forms.TextBox();
            this.LDescipcion = new System.Windows.Forms.Label();
            this.LValiCate = new System.Windows.Forms.Label();
            this.CBCategoria = new System.Windows.Forms.ComboBox();
            this.LCategoriaProducto = new System.Windows.Forms.Label();
            this.LCodigoProducto = new System.Windows.Forms.Label();
            this.TCodigoProducto = new System.Windows.Forms.TextBox();
            this.LPrecioProducto = new System.Windows.Forms.Label();
            this.TPrecioProducto = new System.Windows.Forms.TextBox();
            this.DGProductos = new System.Windows.Forms.DataGridView();
            this.CBDesc = new System.Windows.Forms.CheckBox();
            this.CBEnStock = new System.Windows.Forms.CheckBox();
            this.CBAsc = new System.Windows.Forms.CheckBox();
            this.PBImagenProductos = new System.Windows.Forms.PictureBox();
            this.LDatosProducto = new System.Windows.Forms.Label();
            this.BLimpiarCarrito = new System.Windows.Forms.Button();
            this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Agregar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // LTituloAgregar
            // 
            this.LTituloAgregar.AutoSize = true;
            this.LTituloAgregar.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloAgregar.Location = new System.Drawing.Point(85, 8);
            this.LTituloAgregar.Name = "LTituloAgregar";
            this.LTituloAgregar.Size = new System.Drawing.Size(155, 36);
            this.LTituloAgregar.TabIndex = 37;
            this.LTituloAgregar.Text = "Productos";
            // 
            // BBuscarProducto
            // 
            this.BBuscarProducto.Location = new System.Drawing.Point(584, 201);
            this.BBuscarProducto.Name = "BBuscarProducto";
            this.BBuscarProducto.Size = new System.Drawing.Size(75, 23);
            this.BBuscarProducto.TabIndex = 39;
            this.BBuscarProducto.Text = "Buscar";
            this.BBuscarProducto.UseVisualStyleBackColor = true;
            // 
            // TDescripcion
            // 
            this.TDescripcion.Location = new System.Drawing.Point(291, 204);
            this.TDescripcion.Name = "TDescripcion";
            this.TDescripcion.Size = new System.Drawing.Size(277, 20);
            this.TDescripcion.TabIndex = 38;
            // 
            // LDescipcion
            // 
            this.LDescipcion.AutoSize = true;
            this.LDescipcion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDescipcion.Location = new System.Drawing.Point(396, 184);
            this.LDescipcion.Name = "LDescipcion";
            this.LDescipcion.Size = new System.Drawing.Size(83, 17);
            this.LDescipcion.TabIndex = 40;
            this.LDescipcion.Text = "Descripcion";
            // 
            // LValiCate
            // 
            this.LValiCate.AutoSize = true;
            this.LValiCate.ForeColor = System.Drawing.Color.Red;
            this.LValiCate.Location = new System.Drawing.Point(660, 141);
            this.LValiCate.Name = "LValiCate";
            this.LValiCate.Size = new System.Drawing.Size(0, 13);
            this.LValiCate.TabIndex = 43;
            // 
            // CBCategoria
            // 
            this.CBCategoria.FormattingEnabled = true;
            this.CBCategoria.Items.AddRange(new object[] {
            "Apple",
            "Samsung",
            "Xiaomi",
            "Huawei",
            "Motorola"});
            this.CBCategoria.Location = new System.Drawing.Point(619, 142);
            this.CBCategoria.Name = "CBCategoria";
            this.CBCategoria.Size = new System.Drawing.Size(205, 21);
            this.CBCategoria.TabIndex = 42;
            this.CBCategoria.Text = "Seleccione una categoría";
            // 
            // LCategoriaProducto
            // 
            this.LCategoriaProducto.AutoSize = true;
            this.LCategoriaProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCategoriaProducto.Location = new System.Drawing.Point(680, 121);
            this.LCategoriaProducto.Name = "LCategoriaProducto";
            this.LCategoriaProducto.Size = new System.Drawing.Size(75, 17);
            this.LCategoriaProducto.TabIndex = 41;
            this.LCategoriaProducto.Text = "Categoría";
            // 
            // LCodigoProducto
            // 
            this.LCodigoProducto.AutoSize = true;
            this.LCodigoProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCodigoProducto.Location = new System.Drawing.Point(98, 121);
            this.LCodigoProducto.Name = "LCodigoProducto";
            this.LCodigoProducto.Size = new System.Drawing.Size(118, 17);
            this.LCodigoProducto.TabIndex = 46;
            this.LCodigoProducto.Text = "CodigoProducto";
            this.LCodigoProducto.Click += new System.EventHandler(this.label1_Click);
            // 
            // TCodigoProducto
            // 
            this.TCodigoProducto.Location = new System.Drawing.Point(74, 141);
            this.TCodigoProducto.Name = "TCodigoProducto";
            this.TCodigoProducto.Size = new System.Drawing.Size(177, 20);
            this.TCodigoProducto.TabIndex = 45;
            this.TCodigoProducto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LPrecioProducto
            // 
            this.LPrecioProducto.AutoSize = true;
            this.LPrecioProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPrecioProducto.Location = new System.Drawing.Point(417, 121);
            this.LPrecioProducto.Name = "LPrecioProducto";
            this.LPrecioProducto.Size = new System.Drawing.Size(48, 17);
            this.LPrecioProducto.TabIndex = 48;
            this.LPrecioProducto.Text = "Precio";
            // 
            // TPrecioProducto
            // 
            this.TPrecioProducto.Location = new System.Drawing.Point(351, 141);
            this.TPrecioProducto.Name = "TPrecioProducto";
            this.TPrecioProducto.Size = new System.Drawing.Size(177, 20);
            this.TPrecioProducto.TabIndex = 47;
            // 
            // DGProductos
            // 
            this.DGProductos.AllowUserToAddRows = false;
            this.DGProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoProducto,
            this.Descripcion,
            this.Stock,
            this.Precio,
            this.Agregar});
            this.DGProductos.Location = new System.Drawing.Point(11, 280);
            this.DGProductos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGProductos.Name = "DGProductos";
            this.DGProductos.RowHeadersWidth = 51;
            this.DGProductos.RowTemplate.Height = 24;
            this.DGProductos.Size = new System.Drawing.Size(865, 216);
            this.DGProductos.TabIndex = 49;
            // 
            // CBDesc
            // 
            this.CBDesc.AutoSize = true;
            this.CBDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBDesc.Location = new System.Drawing.Point(154, 255);
            this.CBDesc.Name = "CBDesc";
            this.CBDesc.Size = new System.Drawing.Size(54, 19);
            this.CBDesc.TabIndex = 51;
            this.CBDesc.Text = "Desc";
            this.CBDesc.UseVisualStyleBackColor = true;
            // 
            // CBEnStock
            // 
            this.CBEnStock.AutoSize = true;
            this.CBEnStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBEnStock.Location = new System.Drawing.Point(74, 253);
            this.CBEnStock.Name = "CBEnStock";
            this.CBEnStock.Size = new System.Drawing.Size(74, 19);
            this.CBEnStock.TabIndex = 50;
            this.CBEnStock.Text = "En Stock";
            this.CBEnStock.UseVisualStyleBackColor = true;
            // 
            // CBAsc
            // 
            this.CBAsc.AutoSize = true;
            this.CBAsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBAsc.Location = new System.Drawing.Point(214, 256);
            this.CBAsc.Name = "CBAsc";
            this.CBAsc.Size = new System.Drawing.Size(45, 19);
            this.CBAsc.TabIndex = 52;
            this.CBAsc.Text = "Asc";
            this.CBAsc.UseVisualStyleBackColor = true;
            // 
            // PBImagenProductos
            // 
            this.PBImagenProductos.Image = global::ProyectoTaller.Properties.Resources.CelularesTitulo;
            this.PBImagenProductos.Location = new System.Drawing.Point(11, 9);
            this.PBImagenProductos.Name = "PBImagenProductos";
            this.PBImagenProductos.Size = new System.Drawing.Size(65, 67);
            this.PBImagenProductos.TabIndex = 68;
            this.PBImagenProductos.TabStop = false;
            // 
            // LDatosProducto
            // 
            this.LDatosProducto.AutoSize = true;
            this.LDatosProducto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDatosProducto.Location = new System.Drawing.Point(354, 69);
            this.LDatosProducto.Name = "LDatosProducto";
            this.LDatosProducto.Size = new System.Drawing.Size(169, 23);
            this.LDatosProducto.TabIndex = 69;
            this.LDatosProducto.Text = "Ingrese los Datos:";
            // 
            // BLimpiarCarrito
            // 
            this.BLimpiarCarrito.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BLimpiarCarrito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BLimpiarCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLimpiarCarrito.Image = global::ProyectoTaller.Properties.Resources.Limpiar;
            this.BLimpiarCarrito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BLimpiarCarrito.Location = new System.Drawing.Point(752, 220);
            this.BLimpiarCarrito.Name = "BLimpiarCarrito";
            this.BLimpiarCarrito.Size = new System.Drawing.Size(123, 52);
            this.BLimpiarCarrito.TabIndex = 70;
            this.BLimpiarCarrito.Text = "Limpiar Carro";
            this.BLimpiarCarrito.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BLimpiarCarrito.UseVisualStyleBackColor = true;
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
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.MinimumWidth = 6;
            this.Stock.Name = "Stock";
            this.Stock.Width = 125;
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
            this.Agregar.Width = 125;
            // 
            // ConsultarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(887, 507);
            this.Controls.Add(this.BLimpiarCarrito);
            this.Controls.Add(this.LDatosProducto);
            this.Controls.Add(this.PBImagenProductos);
            this.Controls.Add(this.CBAsc);
            this.Controls.Add(this.CBDesc);
            this.Controls.Add(this.CBEnStock);
            this.Controls.Add(this.DGProductos);
            this.Controls.Add(this.LPrecioProducto);
            this.Controls.Add(this.TPrecioProducto);
            this.Controls.Add(this.LCodigoProducto);
            this.Controls.Add(this.TCodigoProducto);
            this.Controls.Add(this.LValiCate);
            this.Controls.Add(this.CBCategoria);
            this.Controls.Add(this.LCategoriaProducto);
            this.Controls.Add(this.LDescipcion);
            this.Controls.Add(this.BBuscarProducto);
            this.Controls.Add(this.TDescripcion);
            this.Controls.Add(this.LTituloAgregar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ConsultarProducto";
            this.Text = "ConsultarProducto";
            ((System.ComponentModel.ISupportInitialize)(this.DGProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LTituloAgregar;
        private System.Windows.Forms.Button BBuscarProducto;
        private System.Windows.Forms.TextBox TDescripcion;
        private System.Windows.Forms.Label LDescipcion;
        private System.Windows.Forms.Label LValiCate;
        private System.Windows.Forms.ComboBox CBCategoria;
        private System.Windows.Forms.Label LCategoriaProducto;
        private System.Windows.Forms.Label LCodigoProducto;
        private System.Windows.Forms.TextBox TCodigoProducto;
        private System.Windows.Forms.Label LPrecioProducto;
        private System.Windows.Forms.TextBox TPrecioProducto;
        private System.Windows.Forms.DataGridView DGProductos;
        private System.Windows.Forms.CheckBox CBDesc;
        private System.Windows.Forms.CheckBox CBEnStock;
        private System.Windows.Forms.CheckBox CBAsc;
        private System.Windows.Forms.PictureBox PBImagenProductos;
        private System.Windows.Forms.Label LDatosProducto;
        private System.Windows.Forms.Button BLimpiarCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewButtonColumn Agregar;
    }
}