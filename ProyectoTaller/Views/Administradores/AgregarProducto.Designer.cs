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
            this.BSalir = new System.Windows.Forms.Button();
            this.BBorrar = new System.Windows.Forms.Button();
            this.BAgregar = new System.Windows.Forms.Button();
            this.PBImagen = new System.Windows.Forms.PictureBox();
            this.LValiNombre = new System.Windows.Forms.TextBox();
            this.LValiPrecio = new System.Windows.Forms.TextBox();
            this.LValiCate = new System.Windows.Forms.TextBox();
            this.LValiStock = new System.Windows.Forms.TextBox();
            this.LValido = new System.Windows.Forms.TextBox();
            this.BAgregarImagen = new System.Windows.Forms.Button();
            this.LValiImagen = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // LTituloAgregar
            // 
            this.LTituloAgregar.AutoSize = true;
            this.LTituloAgregar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloAgregar.Location = new System.Drawing.Point(296, 25);
            this.LTituloAgregar.Name = "LTituloAgregar";
            this.LTituloAgregar.Size = new System.Drawing.Size(219, 28);
            this.LTituloAgregar.TabIndex = 0;
            this.LTituloAgregar.Text = "Agregar Producto";
            // 
            // TNombreProducto
            // 
            this.TNombreProducto.Location = new System.Drawing.Point(160, 96);
            this.TNombreProducto.Name = "TNombreProducto";
            this.TNombreProducto.Size = new System.Drawing.Size(205, 20);
            this.TNombreProducto.TabIndex = 1;
            this.TNombreProducto.TextChanged += new System.EventHandler(this.TNombreProducto_TextChanged);
            // 
            // LNombreProducto
            // 
            this.LNombreProducto.AutoSize = true;
            this.LNombreProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreProducto.Location = new System.Drawing.Point(79, 99);
            this.LNombreProducto.Name = "LNombreProducto";
            this.LNombreProducto.Size = new System.Drawing.Size(61, 17);
            this.LNombreProducto.TabIndex = 2;
            this.LNombreProducto.Text = "Nombre";
            // 
            // LPrecio
            // 
            this.LPrecio.AutoSize = true;
            this.LPrecio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPrecio.Location = new System.Drawing.Point(79, 152);
            this.LPrecio.Name = "LPrecio";
            this.LPrecio.Size = new System.Drawing.Size(48, 17);
            this.LPrecio.TabIndex = 3;
            this.LPrecio.Text = "Precio";
            // 
            // LCategoria
            // 
            this.LCategoria.AutoSize = true;
            this.LCategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCategoria.Location = new System.Drawing.Point(79, 204);
            this.LCategoria.Name = "LCategoria";
            this.LCategoria.Size = new System.Drawing.Size(75, 17);
            this.LCategoria.TabIndex = 4;
            this.LCategoria.Text = "Categoría";
            // 
            // LStock
            // 
            this.LStock.AutoSize = true;
            this.LStock.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LStock.Location = new System.Drawing.Point(79, 255);
            this.LStock.Name = "LStock";
            this.LStock.Size = new System.Drawing.Size(43, 17);
            this.LStock.TabIndex = 5;
            this.LStock.Text = "Stock";
            // 
            // TPrecio
            // 
            this.TPrecio.Location = new System.Drawing.Point(160, 149);
            this.TPrecio.Name = "TPrecio";
            this.TPrecio.Size = new System.Drawing.Size(205, 20);
            this.TPrecio.TabIndex = 6;
            this.TPrecio.TextChanged += new System.EventHandler(this.TPrecio_TextChanged);
            // 
            // CBCategoria
            // 
            this.CBCategoria.FormattingEnabled = true;
            this.CBCategoria.Location = new System.Drawing.Point(160, 200);
            this.CBCategoria.Name = "CBCategoria";
            this.CBCategoria.Size = new System.Drawing.Size(205, 21);
            this.CBCategoria.TabIndex = 7;
            this.CBCategoria.SelectedIndexChanged += new System.EventHandler(this.CBCategoria_SelectedIndexChanged);
            // 
            // TStock
            // 
            this.TStock.Location = new System.Drawing.Point(160, 252);
            this.TStock.Name = "TStock";
            this.TStock.Size = new System.Drawing.Size(205, 20);
            this.TStock.TabIndex = 8;
            this.TStock.TextChanged += new System.EventHandler(this.TStock_TextChanged);
            // 
            // LImagen
            // 
            this.LImagen.AutoSize = true;
            this.LImagen.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LImagen.Location = new System.Drawing.Point(79, 307);
            this.LImagen.Name = "LImagen";
            this.LImagen.Size = new System.Drawing.Size(58, 17);
            this.LImagen.TabIndex = 9;
            this.LImagen.Text = "Imagen";
            // 
            // BSalir
            // 
            this.BSalir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSalir.Image = global::ProyectoTaller.Properties.Resources.Salir;
            this.BSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BSalir.Location = new System.Drawing.Point(550, 415);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(123, 52);
            this.BSalir.TabIndex = 13;
            this.BSalir.Text = "Salir         ";
            this.BSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BSalir.UseVisualStyleBackColor = true;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
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
            this.BBorrar.Location = new System.Drawing.Point(550, 274);
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
            this.BAgregar.Location = new System.Drawing.Point(550, 344);
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
            this.PBImagen.Location = new System.Drawing.Point(160, 307);
            this.PBImagen.Name = "PBImagen";
            this.PBImagen.Size = new System.Drawing.Size(205, 152);
            this.PBImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBImagen.TabIndex = 10;
            this.PBImagen.TabStop = false;
            this.PBImagen.Click += new System.EventHandler(this.PBImagen_Click);
            // 
            // LValiNombre
            // 
            this.LValiNombre.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LValiNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LValiNombre.Enabled = false;
            this.LValiNombre.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LValiNombre.ForeColor = System.Drawing.Color.Firebrick;
            this.LValiNombre.Location = new System.Drawing.Point(160, 122);
            this.LValiNombre.Multiline = true;
            this.LValiNombre.Name = "LValiNombre";
            this.LValiNombre.ReadOnly = true;
            this.LValiNombre.Size = new System.Drawing.Size(205, 21);
            this.LValiNombre.TabIndex = 20;
            this.LValiNombre.TabStop = false;
            this.LValiNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LValiPrecio
            // 
            this.LValiPrecio.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LValiPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LValiPrecio.Enabled = false;
            this.LValiPrecio.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LValiPrecio.ForeColor = System.Drawing.Color.Firebrick;
            this.LValiPrecio.Location = new System.Drawing.Point(160, 175);
            this.LValiPrecio.Multiline = true;
            this.LValiPrecio.Name = "LValiPrecio";
            this.LValiPrecio.ReadOnly = true;
            this.LValiPrecio.Size = new System.Drawing.Size(205, 21);
            this.LValiPrecio.TabIndex = 21;
            this.LValiPrecio.TabStop = false;
            this.LValiPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LValiCate
            // 
            this.LValiCate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LValiCate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LValiCate.Enabled = false;
            this.LValiCate.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LValiCate.ForeColor = System.Drawing.Color.Firebrick;
            this.LValiCate.Location = new System.Drawing.Point(160, 227);
            this.LValiCate.Multiline = true;
            this.LValiCate.Name = "LValiCate";
            this.LValiCate.ReadOnly = true;
            this.LValiCate.Size = new System.Drawing.Size(205, 21);
            this.LValiCate.TabIndex = 22;
            this.LValiCate.TabStop = false;
            this.LValiCate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LValiStock
            // 
            this.LValiStock.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LValiStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LValiStock.Enabled = false;
            this.LValiStock.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LValiStock.ForeColor = System.Drawing.Color.Firebrick;
            this.LValiStock.Location = new System.Drawing.Point(160, 280);
            this.LValiStock.Multiline = true;
            this.LValiStock.Name = "LValiStock";
            this.LValiStock.ReadOnly = true;
            this.LValiStock.Size = new System.Drawing.Size(205, 21);
            this.LValiStock.TabIndex = 23;
            this.LValiStock.TabStop = false;
            this.LValiStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LValido
            // 
            this.LValido.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LValido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LValido.Enabled = false;
            this.LValido.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.LValido.ForeColor = System.Drawing.Color.Chartreuse;
            this.LValido.Location = new System.Drawing.Point(285, 56);
            this.LValido.Multiline = true;
            this.LValido.Name = "LValido";
            this.LValido.ReadOnly = true;
            this.LValido.Size = new System.Drawing.Size(230, 34);
            this.LValido.TabIndex = 24;
            this.LValido.TabStop = false;
            this.LValido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BAgregarImagen
            // 
            this.BAgregarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAgregarImagen.Location = new System.Drawing.Point(371, 307);
            this.BAgregarImagen.Name = "BAgregarImagen";
            this.BAgregarImagen.Size = new System.Drawing.Size(113, 34);
            this.BAgregarImagen.TabIndex = 25;
            this.BAgregarImagen.Text = "Agregar Imagen";
            this.BAgregarImagen.UseVisualStyleBackColor = true;
            this.BAgregarImagen.Click += new System.EventHandler(this.BAgregarImagen_Click);
            // 
            // LValiImagen
            // 
            this.LValiImagen.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LValiImagen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LValiImagen.Enabled = false;
            this.LValiImagen.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LValiImagen.ForeColor = System.Drawing.Color.Firebrick;
            this.LValiImagen.Location = new System.Drawing.Point(160, 465);
            this.LValiImagen.Multiline = true;
            this.LValiImagen.Name = "LValiImagen";
            this.LValiImagen.ReadOnly = true;
            this.LValiImagen.Size = new System.Drawing.Size(205, 21);
            this.LValiImagen.TabIndex = 26;
            this.LValiImagen.TabStop = false;
            this.LValiImagen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.LValiImagen);
            this.Controls.Add(this.BAgregarImagen);
            this.Controls.Add(this.LValido);
            this.Controls.Add(this.LValiStock);
            this.Controls.Add(this.LValiCate);
            this.Controls.Add(this.LValiPrecio);
            this.Controls.Add(this.LValiNombre);
            this.Controls.Add(this.BSalir);
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
        private System.Windows.Forms.Button BSalir;
        private System.Windows.Forms.TextBox LValiNombre;
        private System.Windows.Forms.TextBox LValiPrecio;
        private System.Windows.Forms.TextBox LValiCate;
        private System.Windows.Forms.TextBox LValiStock;
        private System.Windows.Forms.TextBox LValido;
        private System.Windows.Forms.Button BAgregarImagen;
        private System.Windows.Forms.TextBox LValiImagen;
    }
}