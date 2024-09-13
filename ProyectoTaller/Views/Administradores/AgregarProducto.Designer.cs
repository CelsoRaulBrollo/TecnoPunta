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
            ((System.ComponentModel.ISupportInitialize)(this.PBImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // LTituloAgregar
            // 
            this.LTituloAgregar.AutoSize = true;
            this.LTituloAgregar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloAgregar.Location = new System.Drawing.Point(281, 23);
            this.LTituloAgregar.Name = "LTituloAgregar";
            this.LTituloAgregar.Size = new System.Drawing.Size(219, 28);
            this.LTituloAgregar.TabIndex = 0;
            this.LTituloAgregar.Text = "Agregar Producto";
            // 
            // TNombreProducto
            // 
            this.TNombreProducto.Location = new System.Drawing.Point(153, 73);
            this.TNombreProducto.Name = "TNombreProducto";
            this.TNombreProducto.Size = new System.Drawing.Size(205, 20);
            this.TNombreProducto.TabIndex = 1;
            this.TNombreProducto.TextChanged += new System.EventHandler(this.TNombreProducto_TextChanged);
            // 
            // LNombreProducto
            // 
            this.LNombreProducto.AutoSize = true;
            this.LNombreProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreProducto.Location = new System.Drawing.Point(72, 76);
            this.LNombreProducto.Name = "LNombreProducto";
            this.LNombreProducto.Size = new System.Drawing.Size(61, 17);
            this.LNombreProducto.TabIndex = 2;
            this.LNombreProducto.Text = "Nombre";
            // 
            // LPrecio
            // 
            this.LPrecio.AutoSize = true;
            this.LPrecio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPrecio.Location = new System.Drawing.Point(72, 129);
            this.LPrecio.Name = "LPrecio";
            this.LPrecio.Size = new System.Drawing.Size(48, 17);
            this.LPrecio.TabIndex = 3;
            this.LPrecio.Text = "Precio";
            // 
            // LCategoria
            // 
            this.LCategoria.AutoSize = true;
            this.LCategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCategoria.Location = new System.Drawing.Point(72, 181);
            this.LCategoria.Name = "LCategoria";
            this.LCategoria.Size = new System.Drawing.Size(75, 17);
            this.LCategoria.TabIndex = 4;
            this.LCategoria.Text = "Categoría";
            // 
            // LStock
            // 
            this.LStock.AutoSize = true;
            this.LStock.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LStock.Location = new System.Drawing.Point(72, 232);
            this.LStock.Name = "LStock";
            this.LStock.Size = new System.Drawing.Size(43, 17);
            this.LStock.TabIndex = 5;
            this.LStock.Text = "Stock";
            // 
            // TPrecio
            // 
            this.TPrecio.Location = new System.Drawing.Point(153, 126);
            this.TPrecio.Name = "TPrecio";
            this.TPrecio.Size = new System.Drawing.Size(205, 20);
            this.TPrecio.TabIndex = 6;
            this.TPrecio.TextChanged += new System.EventHandler(this.TPrecio_TextChanged);
            // 
            // CBCategoria
            // 
            this.CBCategoria.FormattingEnabled = true;
            this.CBCategoria.Location = new System.Drawing.Point(153, 177);
            this.CBCategoria.Name = "CBCategoria";
            this.CBCategoria.Size = new System.Drawing.Size(205, 21);
            this.CBCategoria.TabIndex = 7;
            this.CBCategoria.SelectedIndexChanged += new System.EventHandler(this.CBCategoria_SelectedIndexChanged);
            // 
            // TStock
            // 
            this.TStock.Location = new System.Drawing.Point(153, 229);
            this.TStock.Name = "TStock";
            this.TStock.Size = new System.Drawing.Size(205, 20);
            this.TStock.TabIndex = 8;
            this.TStock.TextChanged += new System.EventHandler(this.TStock_TextChanged);
            // 
            // LImagen
            // 
            this.LImagen.AutoSize = true;
            this.LImagen.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LImagen.Location = new System.Drawing.Point(72, 284);
            this.LImagen.Name = "LImagen";
            this.LImagen.Size = new System.Drawing.Size(58, 17);
            this.LImagen.TabIndex = 9;
            this.LImagen.Text = "Imagen";
            // 
            // BSalir
            // 
            this.BSalir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BSalir.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSalir.Image = global::ProyectoTaller.Properties.Resources.Salir;
            this.BSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BSalir.Location = new System.Drawing.Point(543, 392);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(114, 52);
            this.BSalir.TabIndex = 13;
            this.BSalir.Text = "Salir       ";
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
            this.BBorrar.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBorrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BBorrar.Image = global::ProyectoTaller.Properties.Resources.Eliminar;
            this.BBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BBorrar.Location = new System.Drawing.Point(543, 251);
            this.BBorrar.Name = "BBorrar";
            this.BBorrar.Size = new System.Drawing.Size(114, 52);
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
            this.BAgregar.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAgregar.Image = global::ProyectoTaller.Properties.Resources.Disco;
            this.BAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BAgregar.Location = new System.Drawing.Point(543, 321);
            this.BAgregar.Name = "BAgregar";
            this.BAgregar.Size = new System.Drawing.Size(114, 52);
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
            this.PBImagen.Image = global::ProyectoTaller.Properties.Resources.SubirImg;
            this.PBImagen.Location = new System.Drawing.Point(153, 284);
            this.PBImagen.Name = "PBImagen";
            this.PBImagen.Size = new System.Drawing.Size(205, 152);
            this.PBImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBImagen.TabIndex = 10;
            this.PBImagen.TabStop = false;
            this.PBImagen.Click += new System.EventHandler(this.PBImagen_Click);
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 501);
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
    }
}