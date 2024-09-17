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
            this.BBorrar = new System.Windows.Forms.Button();
            this.BAgregar = new System.Windows.Forms.Button();
            this.PBImagen = new System.Windows.Forms.PictureBox();
            this.BAgregarImagen = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.PBImagenAgregar = new System.Windows.Forms.PictureBox();
            this.LValiNombre = new System.Windows.Forms.Label();
            this.LValiPrecio = new System.Windows.Forms.Label();
            this.LValiCate = new System.Windows.Forms.Label();
            this.LValiStock = new System.Windows.Forms.Label();
            this.LValiImagen = new System.Windows.Forms.Label();
            this.LValido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenAgregar)).BeginInit();
            this.SuspendLayout();
            // 
            // LTituloAgregar
            // 
            this.LTituloAgregar.AutoSize = true;
            this.LTituloAgregar.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloAgregar.Location = new System.Drawing.Point(276, 17);
            this.LTituloAgregar.Name = "LTituloAgregar";
            this.LTituloAgregar.Size = new System.Drawing.Size(265, 36);
            this.LTituloAgregar.TabIndex = 0;
            this.LTituloAgregar.Text = "Agregar Producto";
            // 
            // TNombreProducto
            // 
            this.TNombreProducto.Location = new System.Drawing.Point(185, 94);
            this.TNombreProducto.Name = "TNombreProducto";
            this.TNombreProducto.Size = new System.Drawing.Size(205, 20);
            this.TNombreProducto.TabIndex = 1;
            this.TNombreProducto.TextChanged += new System.EventHandler(this.TNombreProducto_TextChanged);
            // 
            // LNombreProducto
            // 
            this.LNombreProducto.AutoSize = true;
            this.LNombreProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreProducto.Location = new System.Drawing.Point(104, 97);
            this.LNombreProducto.Name = "LNombreProducto";
            this.LNombreProducto.Size = new System.Drawing.Size(61, 17);
            this.LNombreProducto.TabIndex = 2;
            this.LNombreProducto.Text = "Nombre";
            // 
            // LPrecio
            // 
            this.LPrecio.AutoSize = true;
            this.LPrecio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPrecio.Location = new System.Drawing.Point(104, 150);
            this.LPrecio.Name = "LPrecio";
            this.LPrecio.Size = new System.Drawing.Size(48, 17);
            this.LPrecio.TabIndex = 3;
            this.LPrecio.Text = "Precio";
            // 
            // LCategoria
            // 
            this.LCategoria.AutoSize = true;
            this.LCategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCategoria.Location = new System.Drawing.Point(104, 202);
            this.LCategoria.Name = "LCategoria";
            this.LCategoria.Size = new System.Drawing.Size(75, 17);
            this.LCategoria.TabIndex = 4;
            this.LCategoria.Text = "Categoría";
            // 
            // LStock
            // 
            this.LStock.AutoSize = true;
            this.LStock.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LStock.Location = new System.Drawing.Point(104, 253);
            this.LStock.Name = "LStock";
            this.LStock.Size = new System.Drawing.Size(43, 17);
            this.LStock.TabIndex = 5;
            this.LStock.Text = "Stock";
            // 
            // TPrecio
            // 
            this.TPrecio.Location = new System.Drawing.Point(185, 147);
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
            this.CBCategoria.Location = new System.Drawing.Point(185, 198);
            this.CBCategoria.Name = "CBCategoria";
            this.CBCategoria.Size = new System.Drawing.Size(205, 21);
            this.CBCategoria.TabIndex = 7;
            this.CBCategoria.Text = "Seleccione una categoría";
            this.CBCategoria.SelectedIndexChanged += new System.EventHandler(this.CBCategoria_SelectedIndexChanged);
            // 
            // TStock
            // 
            this.TStock.Location = new System.Drawing.Point(185, 250);
            this.TStock.Name = "TStock";
            this.TStock.Size = new System.Drawing.Size(205, 20);
            this.TStock.TabIndex = 8;
            this.TStock.TextChanged += new System.EventHandler(this.TStock_TextChanged);
            // 
            // LImagen
            // 
            this.LImagen.AutoSize = true;
            this.LImagen.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LImagen.Location = new System.Drawing.Point(104, 305);
            this.LImagen.Name = "LImagen";
            this.LImagen.Size = new System.Drawing.Size(58, 17);
            this.LImagen.TabIndex = 9;
            this.LImagen.Text = "Imagen";
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
            this.BBorrar.Location = new System.Drawing.Point(525, 287);
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
            this.BAgregar.Image = global::ProyectoTaller.Properties.Resources.Disco;
            this.BAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BAgregar.Location = new System.Drawing.Point(525, 357);
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
            this.PBImagen.Location = new System.Drawing.Point(240, 305);
            this.PBImagen.Name = "PBImagen";
            this.PBImagen.Size = new System.Drawing.Size(150, 116);
            this.PBImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBImagen.TabIndex = 10;
            this.PBImagen.TabStop = false;
            this.PBImagen.Click += new System.EventHandler(this.PBImagen_Click);
            // 
            // BAgregarImagen
            // 
            this.BAgregarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAgregarImagen.Location = new System.Drawing.Point(107, 325);
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
            // PBImagenAgregar
            // 
            this.PBImagenAgregar.Image = global::ProyectoTaller.Properties.Resources.AgregarMenu;
            this.PBImagenAgregar.Location = new System.Drawing.Point(559, 12);
            this.PBImagenAgregar.Name = "PBImagenAgregar";
            this.PBImagenAgregar.Size = new System.Drawing.Size(65, 67);
            this.PBImagenAgregar.TabIndex = 27;
            this.PBImagenAgregar.TabStop = false;
            // 
            // LValiNombre
            // 
            this.LValiNombre.AutoSize = true;
            this.LValiNombre.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.LValiNombre.ForeColor = System.Drawing.Color.Red;
            this.LValiNombre.Location = new System.Drawing.Point(185, 117);
            this.LValiNombre.Name = "LValiNombre";
            this.LValiNombre.Size = new System.Drawing.Size(0, 13);
            this.LValiNombre.TabIndex = 28;
            // 
            // LValiPrecio
            // 
            this.LValiPrecio.AutoSize = true;
            this.LValiPrecio.ForeColor = System.Drawing.Color.Red;
            this.LValiPrecio.Location = new System.Drawing.Point(185, 170);
            this.LValiPrecio.Name = "LValiPrecio";
            this.LValiPrecio.Size = new System.Drawing.Size(0, 13);
            this.LValiPrecio.TabIndex = 29;
            // 
            // LValiCate
            // 
            this.LValiCate.AutoSize = true;
            this.LValiCate.ForeColor = System.Drawing.Color.Red;
            this.LValiCate.Location = new System.Drawing.Point(185, 222);
            this.LValiCate.Name = "LValiCate";
            this.LValiCate.Size = new System.Drawing.Size(0, 13);
            this.LValiCate.TabIndex = 30;
            // 
            // LValiStock
            // 
            this.LValiStock.AutoSize = true;
            this.LValiStock.ForeColor = System.Drawing.Color.Red;
            this.LValiStock.Location = new System.Drawing.Point(185, 273);
            this.LValiStock.Name = "LValiStock";
            this.LValiStock.Size = new System.Drawing.Size(0, 13);
            this.LValiStock.TabIndex = 31;
            // 
            // LValiImagen
            // 
            this.LValiImagen.AutoSize = true;
            this.LValiImagen.ForeColor = System.Drawing.Color.Red;
            this.LValiImagen.Location = new System.Drawing.Point(237, 424);
            this.LValiImagen.Name = "LValiImagen";
            this.LValiImagen.Size = new System.Drawing.Size(0, 13);
            this.LValiImagen.TabIndex = 32;
            // 
            // LValido
            // 
            this.LValido.AutoSize = true;
            this.LValido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LValido.ForeColor = System.Drawing.Color.Green;
            this.LValido.Location = new System.Drawing.Point(269, 58);
            this.LValido.Name = "LValido";
            this.LValido.Size = new System.Drawing.Size(0, 21);
            this.LValido.TabIndex = 33;
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.LValido);
            this.Controls.Add(this.LValiImagen);
            this.Controls.Add(this.LValiStock);
            this.Controls.Add(this.LValiCate);
            this.Controls.Add(this.LValiPrecio);
            this.Controls.Add(this.LValiNombre);
            this.Controls.Add(this.PBImagenAgregar);
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
            ((System.ComponentModel.ISupportInitialize)(this.PBImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenAgregar)).EndInit();
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
        private System.Windows.Forms.PictureBox PBImagenAgregar;
        private System.Windows.Forms.Label LValiNombre;
        private System.Windows.Forms.Label LValiPrecio;
        private System.Windows.Forms.Label LValiCate;
        private System.Windows.Forms.Label LValiStock;
        private System.Windows.Forms.Label LValiImagen;
        private System.Windows.Forms.Label LValido;
    }
}