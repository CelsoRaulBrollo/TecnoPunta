namespace ProyectoTaller.Views.Administradores
{
    partial class AgregarProducto
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
            this.components = new System.ComponentModel.Container();
            this.LTituloAgregar = new System.Windows.Forms.Label();
            this.TNombreProducto = new System.Windows.Forms.TextBox();
            this.LNombreProducto = new System.Windows.Forms.Label();
            this.LPrecio = new System.Windows.Forms.Label();
            this.LCategoria = new System.Windows.Forms.Label();
            this.LStock = new System.Windows.Forms.Label();
            this.TPrecio = new System.Windows.Forms.TextBox();
            this.CBCategoria = new System.Windows.Forms.ComboBox();
            this.TStock = new System.Windows.Forms.TextBox();
            this.LImagen = new System.Windows.Forms.Label();
            this.BAgregarImagen = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.LValiNombre = new System.Windows.Forms.Label();
            this.LValiPrecio = new System.Windows.Forms.Label();
            this.LValiCate = new System.Windows.Forms.Label();
            this.LValiStock = new System.Windows.Forms.Label();
            this.LValiImagen = new System.Windows.Forms.Label();
            this.LValido = new System.Windows.Forms.Label();
            this.DGProductos = new System.Windows.Forms.DataGridView();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CImagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.BEliminar = new System.Windows.Forms.Button();
            this.BEditar = new System.Windows.Forms.Button();
            this.PBImagenTitulo = new System.Windows.Forms.PictureBox();
            this.BBorrar = new System.Windows.Forms.Button();
            this.BAgregar = new System.Windows.Forms.Button();
            this.PBImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // LTituloAgregar
            // 
            this.LTituloAgregar.AutoSize = true;
            this.LTituloAgregar.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloAgregar.Location = new System.Drawing.Point(83, 11);
            this.LTituloAgregar.Name = "LTituloAgregar";
            this.LTituloAgregar.Size = new System.Drawing.Size(155, 36);
            this.LTituloAgregar.TabIndex = 0;
            this.LTituloAgregar.Text = "Productos";
            // 
            // TNombreProducto
            // 
            this.TNombreProducto.Location = new System.Drawing.Point(221, 66);
            this.TNombreProducto.Name = "TNombreProducto";
            this.TNombreProducto.Size = new System.Drawing.Size(205, 20);
            this.TNombreProducto.TabIndex = 1;
            this.TNombreProducto.TextChanged += new System.EventHandler(this.TNombreProducto_TextChanged);
            // 
            // LNombreProducto
            // 
            this.LNombreProducto.AutoSize = true;
            this.LNombreProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreProducto.Location = new System.Drawing.Point(140, 69);
            this.LNombreProducto.Name = "LNombreProducto";
            this.LNombreProducto.Size = new System.Drawing.Size(61, 17);
            this.LNombreProducto.TabIndex = 2;
            this.LNombreProducto.Text = "Nombre";
            // 
            // LPrecio
            // 
            this.LPrecio.AutoSize = true;
            this.LPrecio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPrecio.Location = new System.Drawing.Point(140, 113);
            this.LPrecio.Name = "LPrecio";
            this.LPrecio.Size = new System.Drawing.Size(48, 17);
            this.LPrecio.TabIndex = 3;
            this.LPrecio.Text = "Precio";
            // 
            // LCategoria
            // 
            this.LCategoria.AutoSize = true;
            this.LCategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCategoria.Location = new System.Drawing.Point(458, 69);
            this.LCategoria.Name = "LCategoria";
            this.LCategoria.Size = new System.Drawing.Size(75, 17);
            this.LCategoria.TabIndex = 4;
            this.LCategoria.Text = "Categoría";
            // 
            // LStock
            // 
            this.LStock.AutoSize = true;
            this.LStock.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LStock.Location = new System.Drawing.Point(458, 111);
            this.LStock.Name = "LStock";
            this.LStock.Size = new System.Drawing.Size(43, 17);
            this.LStock.TabIndex = 5;
            this.LStock.Text = "Stock";
            // 
            // TPrecio
            // 
            this.TPrecio.Location = new System.Drawing.Point(221, 110);
            this.TPrecio.Name = "TPrecio";
            this.TPrecio.Size = new System.Drawing.Size(205, 20);
            this.TPrecio.TabIndex = 6;
            this.TPrecio.TextChanged += new System.EventHandler(this.TPrecio_TextChanged);
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
            this.CBCategoria.Location = new System.Drawing.Point(539, 65);
            this.CBCategoria.Name = "CBCategoria";
            this.CBCategoria.Size = new System.Drawing.Size(205, 21);
            this.CBCategoria.TabIndex = 7;
            this.CBCategoria.Text = "Seleccione una categoría";
            this.CBCategoria.SelectedIndexChanged += new System.EventHandler(this.CBCategoria_SelectedIndexChanged);
            // 
            // TStock
            // 
            this.TStock.Location = new System.Drawing.Point(539, 108);
            this.TStock.Name = "TStock";
            this.TStock.Size = new System.Drawing.Size(205, 20);
            this.TStock.TabIndex = 8;
            this.TStock.TextChanged += new System.EventHandler(this.TStock_TextChanged);
            // 
            // LImagen
            // 
            this.LImagen.AutoSize = true;
            this.LImagen.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LImagen.Location = new System.Drawing.Point(140, 157);
            this.LImagen.Name = "LImagen";
            this.LImagen.Size = new System.Drawing.Size(58, 17);
            this.LImagen.TabIndex = 9;
            this.LImagen.Text = "Imagen";
            // 
            // BAgregarImagen
            // 
            this.BAgregarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAgregarImagen.Location = new System.Drawing.Point(143, 177);
            this.BAgregarImagen.Name = "BAgregarImagen";
            this.BAgregarImagen.Size = new System.Drawing.Size(113, 34);
            this.BAgregarImagen.TabIndex = 25;
            this.BAgregarImagen.Text = "Agregar Imagen";
            this.BAgregarImagen.UseVisualStyleBackColor = true;
            this.BAgregarImagen.Click += new System.EventHandler(this.BAgregarImagen_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // LValiNombre
            // 
            this.LValiNombre.AutoSize = true;
            this.LValiNombre.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.LValiNombre.ForeColor = System.Drawing.Color.Red;
            this.LValiNombre.Location = new System.Drawing.Point(221, 89);
            this.LValiNombre.Name = "LValiNombre";
            this.LValiNombre.Size = new System.Drawing.Size(0, 13);
            this.LValiNombre.TabIndex = 28;
            // 
            // LValiPrecio
            // 
            this.LValiPrecio.AutoSize = true;
            this.LValiPrecio.ForeColor = System.Drawing.Color.Red;
            this.LValiPrecio.Location = new System.Drawing.Point(221, 133);
            this.LValiPrecio.Name = "LValiPrecio";
            this.LValiPrecio.Size = new System.Drawing.Size(0, 13);
            this.LValiPrecio.TabIndex = 29;
            // 
            // LValiCate
            // 
            this.LValiCate.AutoSize = true;
            this.LValiCate.ForeColor = System.Drawing.Color.Red;
            this.LValiCate.Location = new System.Drawing.Point(539, 89);
            this.LValiCate.Name = "LValiCate";
            this.LValiCate.Size = new System.Drawing.Size(0, 13);
            this.LValiCate.TabIndex = 30;
            // 
            // LValiStock
            // 
            this.LValiStock.AutoSize = true;
            this.LValiStock.ForeColor = System.Drawing.Color.Red;
            this.LValiStock.Location = new System.Drawing.Point(539, 131);
            this.LValiStock.Name = "LValiStock";
            this.LValiStock.Size = new System.Drawing.Size(0, 13);
            this.LValiStock.TabIndex = 31;
            // 
            // LValiImagen
            // 
            this.LValiImagen.AutoSize = true;
            this.LValiImagen.ForeColor = System.Drawing.Color.Red;
            this.LValiImagen.Location = new System.Drawing.Point(273, 276);
            this.LValiImagen.Name = "LValiImagen";
            this.LValiImagen.Size = new System.Drawing.Size(0, 13);
            this.LValiImagen.TabIndex = 32;
            // 
            // LValido
            // 
            this.LValido.AutoSize = true;
            this.LValido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LValido.ForeColor = System.Drawing.Color.Green;
            this.LValido.Location = new System.Drawing.Point(295, 24);
            this.LValido.Name = "LValido";
            this.LValido.Size = new System.Drawing.Size(0, 21);
            this.LValido.TabIndex = 33;
            // 
            // DGProductos
            // 
            this.DGProductos.AllowUserToAddRows = false;
            this.DGProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CNombre,
            this.CPrecio,
            this.CCategoria,
            this.CStock,
            this.CImagen});
            this.DGProductos.Location = new System.Drawing.Point(12, 332);
            this.DGProductos.Name = "DGProductos";
            this.DGProductos.Size = new System.Drawing.Size(863, 163);
            this.DGProductos.TabIndex = 36;
            // 
            // CNombre
            // 
            this.CNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CNombre.HeaderText = "Nombre";
            this.CNombre.MinimumWidth = 15;
            this.CNombre.Name = "CNombre";
            this.CNombre.Width = 220;
            // 
            // CPrecio
            // 
            this.CPrecio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CPrecio.HeaderText = "Precio";
            this.CPrecio.MinimumWidth = 25;
            this.CPrecio.Name = "CPrecio";
            this.CPrecio.Width = 150;
            // 
            // CCategoria
            // 
            this.CCategoria.HeaderText = "Categoría";
            this.CCategoria.Name = "CCategoria";
            this.CCategoria.Width = 200;
            // 
            // CStock
            // 
            this.CStock.HeaderText = "Stock";
            this.CStock.Name = "CStock";
            this.CStock.Width = 115;
            // 
            // CImagen
            // 
            this.CImagen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CImagen.HeaderText = "Imagen";
            this.CImagen.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.CImagen.Name = "CImagen";
            this.CImagen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CImagen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CImagen.Width = 135;
            // 
            // BEliminar
            // 
            this.BEliminar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BEliminar.FlatAppearance.BorderSize = 0;
            this.BEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BEliminar.Image = global::ProyectoTaller.Properties.Resources.Borrar;
            this.BEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BEliminar.Location = new System.Drawing.Point(719, 221);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(123, 52);
            this.BEliminar.TabIndex = 35;
            this.BEliminar.Text = "Eliminar";
            this.BEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BEliminar.UseVisualStyleBackColor = true;
            this.BEliminar.Click += new System.EventHandler(this.BEliminar_Click);
            // 
            // BEditar
            // 
            this.BEditar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEditar.Image = global::ProyectoTaller.Properties.Resources.editar2;
            this.BEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BEditar.Location = new System.Drawing.Point(590, 221);
            this.BEditar.Name = "BEditar";
            this.BEditar.Size = new System.Drawing.Size(123, 52);
            this.BEditar.TabIndex = 34;
            this.BEditar.Text = "Editar    ";
            this.BEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BEditar.UseVisualStyleBackColor = true;
            this.BEditar.Click += new System.EventHandler(this.BEditar_Click);
            // 
            // PBImagenTitulo
            // 
            this.PBImagenTitulo.Image = global::ProyectoTaller.Properties.Resources.AgregarMenu;
            this.PBImagenTitulo.Location = new System.Drawing.Point(12, 12);
            this.PBImagenTitulo.Name = "PBImagenTitulo";
            this.PBImagenTitulo.Size = new System.Drawing.Size(65, 67);
            this.PBImagenTitulo.TabIndex = 27;
            this.PBImagenTitulo.TabStop = false;
            // 
            // BBorrar
            // 
            this.BBorrar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BBorrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BBorrar.FlatAppearance.BorderSize = 0;
            this.BBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBorrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BBorrar.Image = global::ProyectoTaller.Properties.Resources.Eliminar;
            this.BBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BBorrar.Location = new System.Drawing.Point(461, 157);
            this.BBorrar.Name = "BBorrar";
            this.BBorrar.Size = new System.Drawing.Size(123, 52);
            this.BBorrar.TabIndex = 12;
            this.BBorrar.Text = "Borrar Todo";
            this.BBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BBorrar.UseVisualStyleBackColor = true;
            this.BBorrar.Click += new System.EventHandler(this.BBorrar_Click);
            // 
            // BAgregar
            // 
            this.BAgregar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAgregar.Image = global::ProyectoTaller.Properties.Resources.GuardarProducto;
            this.BAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BAgregar.Location = new System.Drawing.Point(461, 221);
            this.BAgregar.Name = "BAgregar";
            this.BAgregar.Size = new System.Drawing.Size(123, 52);
            this.BAgregar.TabIndex = 11;
            this.BAgregar.Text = "Agregar    ";
            this.BAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BAgregar.UseVisualStyleBackColor = true;
            this.BAgregar.Click += new System.EventHandler(this.BAgregar_Click);
            // 
            // PBImagen
            // 
            this.PBImagen.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PBImagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PBImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBImagen.Location = new System.Drawing.Point(287, 157);
            this.PBImagen.Name = "PBImagen";
            this.PBImagen.Size = new System.Drawing.Size(139, 116);
            this.PBImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBImagen.TabIndex = 10;
            this.PBImagen.TabStop = false;
            this.PBImagen.Click += new System.EventHandler(this.PBImagen_Click);
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(887, 507);
            this.Controls.Add(this.DGProductos);
            this.Controls.Add(this.BEliminar);
            this.Controls.Add(this.BEditar);
            this.Controls.Add(this.LValido);
            this.Controls.Add(this.LValiImagen);
            this.Controls.Add(this.LValiStock);
            this.Controls.Add(this.LValiCate);
            this.Controls.Add(this.LValiPrecio);
            this.Controls.Add(this.LValiNombre);
            this.Controls.Add(this.PBImagenTitulo);
            this.Controls.Add(this.BAgregarImagen);
            this.Controls.Add(this.BBorrar);
            this.Controls.Add(this.BAgregar);
            this.Controls.Add(this.PBImagen);
            this.Controls.Add(this.LImagen);
            this.Controls.Add(this.TStock);
            this.Controls.Add(this.CBCategoria);
            this.Controls.Add(this.TPrecio);
            this.Controls.Add(this.LStock);
            this.Controls.Add(this.LCategoria);
            this.Controls.Add(this.LPrecio);
            this.Controls.Add(this.LNombreProducto);
            this.Controls.Add(this.TNombreProducto);
            this.Controls.Add(this.LTituloAgregar);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "AgregarProducto";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarProducto";
            ((System.ComponentModel.ISupportInitialize)(this.DGProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LTituloAgregar;
        private System.Windows.Forms.TextBox TNombreProducto;
        private System.Windows.Forms.Label LNombreProducto;
        private System.Windows.Forms.Label LPrecio;
        private System.Windows.Forms.Label LCategoria;
        private System.Windows.Forms.Label LStock;
        private System.Windows.Forms.TextBox TPrecio;
        private System.Windows.Forms.ComboBox CBCategoria;
        private System.Windows.Forms.TextBox TStock;
        private System.Windows.Forms.Label LImagen;
        private System.Windows.Forms.PictureBox PBImagen;
        private System.Windows.Forms.Button BAgregar;
        private System.Windows.Forms.Button BBorrar;
        private System.Windows.Forms.Button BAgregarImagen;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox PBImagenTitulo;
        private System.Windows.Forms.Label LValiNombre;
        private System.Windows.Forms.Label LValiPrecio;
        private System.Windows.Forms.Label LValiCate;
        private System.Windows.Forms.Label LValiStock;
        private System.Windows.Forms.Label LValiImagen;
        private System.Windows.Forms.Label LValido;
        private System.Windows.Forms.Button BEditar;
        private System.Windows.Forms.Button BEliminar;
        private System.Windows.Forms.DataGridView DGProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn CStock;
        private System.Windows.Forms.DataGridViewImageColumn CImagen;
    }
}