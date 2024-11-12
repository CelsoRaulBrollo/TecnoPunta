namespace ProyectoTaller.Views.Vendedor
{
    partial class TConsultarProducto
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
            this.LTituloProductos = new System.Windows.Forms.Label();
            this.DGProductos = new System.Windows.Forms.DataGridView();
            this.CBPrecioDesc = new System.Windows.Forms.CheckBox();
            this.CBPrecioAsc = new System.Windows.Forms.CheckBox();
            this.CBMarca = new System.Windows.Forms.ComboBox();
            this.LMarca = new System.Windows.Forms.Label();
            this.LNombreProducto = new System.Windows.Forms.Label();
            this.TNombreProducto = new System.Windows.Forms.TextBox();
            this.LModelo = new System.Windows.Forms.Label();
            this.TModelo = new System.Windows.Forms.TextBox();
            this.LRam = new System.Windows.Forms.Label();
            this.TMemoriaRam = new System.Windows.Forms.TextBox();
            this.LSistemaOperativo = new System.Windows.Forms.Label();
            this.TSistemaOperativo = new System.Windows.Forms.TextBox();
            this.LValiMarca = new System.Windows.Forms.Label();
            this.LValiNombreP = new System.Windows.Forms.Label();
            this.LValiModeloP = new System.Windows.Forms.Label();
            this.LValiSistOpe = new System.Windows.Forms.Label();
            this.TAlmacenamiento = new System.Windows.Forms.TextBox();
            this.LValiAllmac = new System.Windows.Forms.Label();
            this.LValiRamp = new System.Windows.Forms.Label();
            this.LAlmacenamiento = new System.Windows.Forms.Label();
            this.BBuscarProducto = new System.Windows.Forms.Button();
            this.BLimpiarFiltros = new System.Windows.Forms.Button();
            this.PBImagenProductos = new System.Windows.Forms.PictureBox();
            this.BAgregarProductoACarrito = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // LTituloProductos
            // 
            this.LTituloProductos.AutoSize = true;
            this.LTituloProductos.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloProductos.Location = new System.Drawing.Point(113, 10);
            this.LTituloProductos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTituloProductos.Name = "LTituloProductos";
            this.LTituloProductos.Size = new System.Drawing.Size(197, 44);
            this.LTituloProductos.TabIndex = 37;
            this.LTituloProductos.Text = "Productos";
            // 
            // DGProductos
            // 
            this.DGProductos.AllowUserToAddRows = false;
            this.DGProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGProductos.Location = new System.Drawing.Point(15, 345);
            this.DGProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGProductos.Name = "DGProductos";
            this.DGProductos.RowHeadersWidth = 51;
            this.DGProductos.RowTemplate.Height = 24;
            this.DGProductos.Size = new System.Drawing.Size(1153, 266);
            this.DGProductos.TabIndex = 49;
            this.DGProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGProductos_CellContentClick);
            // 
            // CBPrecioDesc
            // 
            this.CBPrecioDesc.AutoSize = true;
            this.CBPrecioDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBPrecioDesc.Location = new System.Drawing.Point(121, 313);
            this.CBPrecioDesc.Margin = new System.Windows.Forms.Padding(4);
            this.CBPrecioDesc.Name = "CBPrecioDesc";
            this.CBPrecioDesc.Size = new System.Drawing.Size(112, 22);
            this.CBPrecioDesc.TabIndex = 51;
            this.CBPrecioDesc.Text = "Precio Desc";
            this.CBPrecioDesc.UseVisualStyleBackColor = true;
            this.CBPrecioDesc.CheckedChanged += new System.EventHandler(this.CBPrecioDesc_CheckedChanged);
            // 
            // CBPrecioAsc
            // 
            this.CBPrecioAsc.AutoSize = true;
            this.CBPrecioAsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBPrecioAsc.Location = new System.Drawing.Point(273, 313);
            this.CBPrecioAsc.Margin = new System.Windows.Forms.Padding(4);
            this.CBPrecioAsc.Name = "CBPrecioAsc";
            this.CBPrecioAsc.Size = new System.Drawing.Size(102, 22);
            this.CBPrecioAsc.TabIndex = 52;
            this.CBPrecioAsc.Text = "Precio Asc";
            this.CBPrecioAsc.UseVisualStyleBackColor = true;
            this.CBPrecioAsc.CheckedChanged += new System.EventHandler(this.CBPrecioAsc_CheckedChanged);
            // 
            // CBMarca
            // 
            this.CBMarca.FormattingEnabled = true;
            this.CBMarca.Location = new System.Drawing.Point(244, 96);
            this.CBMarca.Margin = new System.Windows.Forms.Padding(4);
            this.CBMarca.Name = "CBMarca";
            this.CBMarca.Size = new System.Drawing.Size(237, 24);
            this.CBMarca.TabIndex = 73;
            this.CBMarca.Text = "Seleccione la Marca";
            this.CBMarca.SelectedIndexChanged += new System.EventHandler(this.CBMarca_SelectedIndexChanged_1);
            // 
            // LMarca
            // 
            this.LMarca.AutoSize = true;
            this.LMarca.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LMarca.Location = new System.Drawing.Point(131, 98);
            this.LMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LMarca.Name = "LMarca";
            this.LMarca.Size = new System.Drawing.Size(67, 21);
            this.LMarca.TabIndex = 71;
            this.LMarca.Text = "Marca";
            // 
            // LNombreProducto
            // 
            this.LNombreProducto.AutoSize = true;
            this.LNombreProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreProducto.Location = new System.Drawing.Point(131, 151);
            this.LNombreProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LNombreProducto.Name = "LNombreProducto";
            this.LNombreProducto.Size = new System.Drawing.Size(77, 21);
            this.LNombreProducto.TabIndex = 75;
            this.LNombreProducto.Text = "Nombre";
            this.LNombreProducto.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // TNombreProducto
            // 
            this.TNombreProducto.Location = new System.Drawing.Point(245, 146);
            this.TNombreProducto.Margin = new System.Windows.Forms.Padding(4);
            this.TNombreProducto.Name = "TNombreProducto";
            this.TNombreProducto.Size = new System.Drawing.Size(235, 22);
            this.TNombreProducto.TabIndex = 74;
            this.TNombreProducto.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // LModelo
            // 
            this.LModelo.AutoSize = true;
            this.LModelo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LModelo.Location = new System.Drawing.Point(131, 203);
            this.LModelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LModelo.Name = "LModelo";
            this.LModelo.Size = new System.Drawing.Size(75, 21);
            this.LModelo.TabIndex = 77;
            this.LModelo.Text = "Modelo";
            // 
            // TModelo
            // 
            this.TModelo.Location = new System.Drawing.Point(245, 196);
            this.TModelo.Margin = new System.Windows.Forms.Padding(4);
            this.TModelo.Name = "TModelo";
            this.TModelo.Size = new System.Drawing.Size(235, 22);
            this.TModelo.TabIndex = 76;
            // 
            // LRam
            // 
            this.LRam.AutoSize = true;
            this.LRam.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRam.Location = new System.Drawing.Point(567, 98);
            this.LRam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LRam.Name = "LRam";
            this.LRam.Size = new System.Drawing.Size(126, 21);
            this.LRam.TabIndex = 79;
            this.LRam.Text = "Memoria Ram";
            this.LRam.Click += new System.EventHandler(this.label3_Click);
            // 
            // TMemoriaRam
            // 
            this.TMemoriaRam.Location = new System.Drawing.Point(739, 96);
            this.TMemoriaRam.Margin = new System.Windows.Forms.Padding(4);
            this.TMemoriaRam.Name = "TMemoriaRam";
            this.TMemoriaRam.Size = new System.Drawing.Size(235, 22);
            this.TMemoriaRam.TabIndex = 78;
            // 
            // LSistemaOperativo
            // 
            this.LSistemaOperativo.AutoSize = true;
            this.LSistemaOperativo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSistemaOperativo.Location = new System.Drawing.Point(567, 199);
            this.LSistemaOperativo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LSistemaOperativo.Name = "LSistemaOperativo";
            this.LSistemaOperativo.Size = new System.Drawing.Size(165, 21);
            this.LSistemaOperativo.TabIndex = 83;
            this.LSistemaOperativo.Text = "Sistema Operativo";
            // 
            // TSistemaOperativo
            // 
            this.TSistemaOperativo.Location = new System.Drawing.Point(739, 197);
            this.TSistemaOperativo.Margin = new System.Windows.Forms.Padding(4);
            this.TSistemaOperativo.Name = "TSistemaOperativo";
            this.TSistemaOperativo.Size = new System.Drawing.Size(235, 22);
            this.TSistemaOperativo.TabIndex = 82;
            // 
            // LValiMarca
            // 
            this.LValiMarca.AutoSize = true;
            this.LValiMarca.Location = new System.Drawing.Point(244, 126);
            this.LValiMarca.Name = "LValiMarca";
            this.LValiMarca.Size = new System.Drawing.Size(0, 16);
            this.LValiMarca.TabIndex = 87;
            // 
            // LValiNombreP
            // 
            this.LValiNombreP.AutoSize = true;
            this.LValiNombreP.ForeColor = System.Drawing.Color.Red;
            this.LValiNombreP.Location = new System.Drawing.Point(244, 177);
            this.LValiNombreP.Name = "LValiNombreP";
            this.LValiNombreP.Size = new System.Drawing.Size(0, 16);
            this.LValiNombreP.TabIndex = 88;
            // 
            // LValiModeloP
            // 
            this.LValiModeloP.AutoSize = true;
            this.LValiModeloP.ForeColor = System.Drawing.Color.Red;
            this.LValiModeloP.Location = new System.Drawing.Point(244, 228);
            this.LValiModeloP.Name = "LValiModeloP";
            this.LValiModeloP.Size = new System.Drawing.Size(0, 16);
            this.LValiModeloP.TabIndex = 89;
            // 
            // LValiSistOpe
            // 
            this.LValiSistOpe.AutoSize = true;
            this.LValiSistOpe.ForeColor = System.Drawing.Color.Red;
            this.LValiSistOpe.Location = new System.Drawing.Point(740, 224);
            this.LValiSistOpe.Name = "LValiSistOpe";
            this.LValiSistOpe.Size = new System.Drawing.Size(0, 16);
            this.LValiSistOpe.TabIndex = 90;
            // 
            // TAlmacenamiento
            // 
            this.TAlmacenamiento.Location = new System.Drawing.Point(739, 146);
            this.TAlmacenamiento.Margin = new System.Windows.Forms.Padding(4);
            this.TAlmacenamiento.Name = "TAlmacenamiento";
            this.TAlmacenamiento.Size = new System.Drawing.Size(235, 22);
            this.TAlmacenamiento.TabIndex = 80;
            // 
            // LValiAllmac
            // 
            this.LValiAllmac.AutoSize = true;
            this.LValiAllmac.ForeColor = System.Drawing.Color.Red;
            this.LValiAllmac.Location = new System.Drawing.Point(740, 172);
            this.LValiAllmac.Name = "LValiAllmac";
            this.LValiAllmac.Size = new System.Drawing.Size(0, 16);
            this.LValiAllmac.TabIndex = 85;
            // 
            // LValiRamp
            // 
            this.LValiRamp.AutoSize = true;
            this.LValiRamp.ForeColor = System.Drawing.Color.Red;
            this.LValiRamp.Location = new System.Drawing.Point(740, 122);
            this.LValiRamp.Name = "LValiRamp";
            this.LValiRamp.Size = new System.Drawing.Size(0, 16);
            this.LValiRamp.TabIndex = 84;
            // 
            // LAlmacenamiento
            // 
            this.LAlmacenamiento.AutoSize = true;
            this.LAlmacenamiento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAlmacenamiento.Location = new System.Drawing.Point(567, 148);
            this.LAlmacenamiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LAlmacenamiento.Name = "LAlmacenamiento";
            this.LAlmacenamiento.Size = new System.Drawing.Size(154, 21);
            this.LAlmacenamiento.TabIndex = 81;
            this.LAlmacenamiento.Text = "Almacenamiento";
            // 
            // BBuscarProducto
            // 
            this.BBuscarProducto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscarProducto.Image = global::ProyectoTaller.Properties.Resources.buscar;
            this.BBuscarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BBuscarProducto.Location = new System.Drawing.Point(1003, 128);
            this.BBuscarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.BBuscarProducto.Name = "BBuscarProducto";
            this.BBuscarProducto.Size = new System.Drawing.Size(164, 64);
            this.BBuscarProducto.TabIndex = 91;
            this.BBuscarProducto.Text = "          Buscar";
            this.BBuscarProducto.UseVisualStyleBackColor = true;
            this.BBuscarProducto.Click += new System.EventHandler(this.BBuscarProducto_Click);
            // 
            // BLimpiarFiltros
            // 
            this.BLimpiarFiltros.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BLimpiarFiltros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BLimpiarFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLimpiarFiltros.Image = global::ProyectoTaller.Properties.Resources.Limpiar;
            this.BLimpiarFiltros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BLimpiarFiltros.Location = new System.Drawing.Point(771, 271);
            this.BLimpiarFiltros.Margin = new System.Windows.Forms.Padding(4);
            this.BLimpiarFiltros.Name = "BLimpiarFiltros";
            this.BLimpiarFiltros.Size = new System.Drawing.Size(164, 64);
            this.BLimpiarFiltros.TabIndex = 70;
            this.BLimpiarFiltros.Text = "Limpiar Filtros";
            this.BLimpiarFiltros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BLimpiarFiltros.UseVisualStyleBackColor = true;
            this.BLimpiarFiltros.Click += new System.EventHandler(this.BLimpiarFiltros_Click);
            // 
            // PBImagenProductos
            // 
            this.PBImagenProductos.Image = global::ProyectoTaller.Properties.Resources.CelularesTitulo;
            this.PBImagenProductos.Location = new System.Drawing.Point(15, 11);
            this.PBImagenProductos.Margin = new System.Windows.Forms.Padding(4);
            this.PBImagenProductos.Name = "PBImagenProductos";
            this.PBImagenProductos.Size = new System.Drawing.Size(87, 82);
            this.PBImagenProductos.TabIndex = 68;
            this.PBImagenProductos.TabStop = false;
            // 
            // BAgregarProductoACarrito
            // 
            this.BAgregarProductoACarrito.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BAgregarProductoACarrito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BAgregarProductoACarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAgregarProductoACarrito.Image = global::ProyectoTaller.Properties.Resources.Carrito;
            this.BAgregarProductoACarrito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BAgregarProductoACarrito.Location = new System.Drawing.Point(1003, 271);
            this.BAgregarProductoACarrito.Margin = new System.Windows.Forms.Padding(4);
            this.BAgregarProductoACarrito.Name = "BAgregarProductoACarrito";
            this.BAgregarProductoACarrito.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BAgregarProductoACarrito.Size = new System.Drawing.Size(164, 64);
            this.BAgregarProductoACarrito.TabIndex = 92;
            this.BAgregarProductoACarrito.Text = "Agregar    ";
            this.BAgregarProductoACarrito.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BAgregarProductoACarrito.UseVisualStyleBackColor = true;
            this.BAgregarProductoACarrito.Click += new System.EventHandler(this.BAgregarProductoACarrito_Click);
            // 
            // TConsultarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1183, 624);
            this.Controls.Add(this.BAgregarProductoACarrito);
            this.Controls.Add(this.BBuscarProducto);
            this.Controls.Add(this.LValiSistOpe);
            this.Controls.Add(this.LValiModeloP);
            this.Controls.Add(this.LValiNombreP);
            this.Controls.Add(this.LValiMarca);
            this.Controls.Add(this.LValiAllmac);
            this.Controls.Add(this.LValiRamp);
            this.Controls.Add(this.LSistemaOperativo);
            this.Controls.Add(this.TSistemaOperativo);
            this.Controls.Add(this.LAlmacenamiento);
            this.Controls.Add(this.TAlmacenamiento);
            this.Controls.Add(this.LRam);
            this.Controls.Add(this.TMemoriaRam);
            this.Controls.Add(this.LModelo);
            this.Controls.Add(this.TModelo);
            this.Controls.Add(this.LNombreProducto);
            this.Controls.Add(this.TNombreProducto);
            this.Controls.Add(this.CBMarca);
            this.Controls.Add(this.LMarca);
            this.Controls.Add(this.BLimpiarFiltros);
            this.Controls.Add(this.PBImagenProductos);
            this.Controls.Add(this.CBPrecioAsc);
            this.Controls.Add(this.CBPrecioDesc);
            this.Controls.Add(this.DGProductos);
            this.Controls.Add(this.LTituloProductos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TConsultarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarProducto";
            this.Load += new System.EventHandler(this.ConsultarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LTituloProductos;
        private System.Windows.Forms.DataGridView DGProductos;
        private System.Windows.Forms.CheckBox CBPrecioDesc;
        private System.Windows.Forms.CheckBox CBPrecioAsc;
        private System.Windows.Forms.PictureBox PBImagenProductos;
        private System.Windows.Forms.Button BLimpiarFiltros;
        private System.Windows.Forms.ComboBox CBMarca;
        private System.Windows.Forms.Label LMarca;
        private System.Windows.Forms.Label LNombreProducto;
        private System.Windows.Forms.TextBox TNombreProducto;
        private System.Windows.Forms.Label LModelo;
        private System.Windows.Forms.TextBox TModelo;
        private System.Windows.Forms.Label LRam;
        private System.Windows.Forms.TextBox TMemoriaRam;
        private System.Windows.Forms.Label LSistemaOperativo;
        private System.Windows.Forms.TextBox TSistemaOperativo;
        private System.Windows.Forms.Label LValiMarca;
        private System.Windows.Forms.Label LValiNombreP;
        private System.Windows.Forms.Label LValiModeloP;
        private System.Windows.Forms.Label LValiSistOpe;
        private System.Windows.Forms.TextBox TAlmacenamiento;
        private System.Windows.Forms.Label LValiAllmac;
        private System.Windows.Forms.Label LValiRamp;
        private System.Windows.Forms.Label LAlmacenamiento;
        private System.Windows.Forms.Button BBuscarProducto;
        private System.Windows.Forms.Button BAgregarProductoACarrito;
    }
}