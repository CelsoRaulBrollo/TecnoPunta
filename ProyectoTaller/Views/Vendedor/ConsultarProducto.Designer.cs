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
            this.LTituloAgregar = new System.Windows.Forms.Label();
            this.LCodigoProducto = new System.Windows.Forms.Label();
            this.TCodigoProducto = new System.Windows.Forms.TextBox();
            this.DGProductos = new System.Windows.Forms.DataGridView();
            this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemoriaRam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SistemaOperativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Agregar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CBPrecioDesc = new System.Windows.Forms.CheckBox();
            this.CBEnStock = new System.Windows.Forms.CheckBox();
            this.CBPrecioAsc = new System.Windows.Forms.CheckBox();
            this.PBImagenProductos = new System.Windows.Forms.PictureBox();
            this.BLimpiarFiltros = new System.Windows.Forms.Button();
            this.CBMarca = new System.Windows.Forms.ComboBox();
            this.LValiMarca = new System.Windows.Forms.Label();
            this.LMarca = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TNombreProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TModelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TMemoriaRam = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TSistemaOperativo = new System.Windows.Forms.TextBox();
            this.LValiCodigoProd = new System.Windows.Forms.Label();
            this.LValiMarcaP = new System.Windows.Forms.Label();
            this.LValiNombreP = new System.Windows.Forms.Label();
            this.LValiModeloP = new System.Windows.Forms.Label();
            this.LValiSistOpe = new System.Windows.Forms.Label();
            this.TAlmacenamiento = new System.Windows.Forms.TextBox();
            this.LValiAllmac = new System.Windows.Forms.Label();
            this.LValiRamp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BBuscarProducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // LTituloAgregar
            // 
            this.LTituloAgregar.AutoSize = true;
            this.LTituloAgregar.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloAgregar.Location = new System.Drawing.Point(113, 10);
            this.LTituloAgregar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTituloAgregar.Name = "LTituloAgregar";
            this.LTituloAgregar.Size = new System.Drawing.Size(197, 44);
            this.LTituloAgregar.TabIndex = 37;
            this.LTituloAgregar.Text = "Productos";
            // 
            // LCodigoProducto
            // 
            this.LCodigoProducto.AutoSize = true;
            this.LCodigoProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCodigoProducto.Location = new System.Drawing.Point(149, 99);
            this.LCodigoProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LCodigoProducto.Name = "LCodigoProducto";
            this.LCodigoProducto.Size = new System.Drawing.Size(149, 21);
            this.LCodigoProducto.TabIndex = 46;
            this.LCodigoProducto.Text = "CodigoProducto";
            this.LCodigoProducto.Click += new System.EventHandler(this.label1_Click);
            // 
            // TCodigoProducto
            // 
            this.TCodigoProducto.Location = new System.Drawing.Point(306, 98);
            this.TCodigoProducto.Margin = new System.Windows.Forms.Padding(4);
            this.TCodigoProducto.Name = "TCodigoProducto";
            this.TCodigoProducto.Size = new System.Drawing.Size(235, 22);
            this.TCodigoProducto.TabIndex = 45;
            this.TCodigoProducto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DGProductos
            // 
            this.DGProductos.AllowUserToAddRows = false;
            this.DGProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoProducto,
            this.Marca,
            this.Nombre,
            this.Modelo,
            this.MemoriaRam,
            this.SistemaOperativo,
            this.Stock,
            this.Precio,
            this.Agregar});
            this.DGProductos.Location = new System.Drawing.Point(15, 345);
            this.DGProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGProductos.Name = "DGProductos";
            this.DGProductos.RowHeadersWidth = 51;
            this.DGProductos.RowTemplate.Height = 24;
            this.DGProductos.Size = new System.Drawing.Size(1153, 266);
            this.DGProductos.TabIndex = 49;
            // 
            // CodigoProducto
            // 
            this.CodigoProducto.FillWeight = 1F;
            this.CodigoProducto.HeaderText = "Codigo Producto";
            this.CodigoProducto.MinimumWidth = 6;
            this.CodigoProducto.Name = "CodigoProducto";
            this.CodigoProducto.Width = 120;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.MinimumWidth = 6;
            this.Marca.Name = "Marca";
            this.Marca.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.MinimumWidth = 6;
            this.Modelo.Name = "Modelo";
            this.Modelo.Width = 125;
            // 
            // MemoriaRam
            // 
            this.MemoriaRam.HeaderText = "Memoria Ram";
            this.MemoriaRam.MinimumWidth = 6;
            this.MemoriaRam.Name = "MemoriaRam";
            this.MemoriaRam.Width = 125;
            // 
            // SistemaOperativo
            // 
            this.SistemaOperativo.HeaderText = "Sistema Operativo";
            this.SistemaOperativo.MinimumWidth = 6;
            this.SistemaOperativo.Name = "SistemaOperativo";
            this.SistemaOperativo.Width = 125;
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
            // CBPrecioDesc
            // 
            this.CBPrecioDesc.AutoSize = true;
            this.CBPrecioDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBPrecioDesc.Location = new System.Drawing.Point(205, 314);
            this.CBPrecioDesc.Margin = new System.Windows.Forms.Padding(4);
            this.CBPrecioDesc.Name = "CBPrecioDesc";
            this.CBPrecioDesc.Size = new System.Drawing.Size(112, 22);
            this.CBPrecioDesc.TabIndex = 51;
            this.CBPrecioDesc.Text = "Precio Desc";
            this.CBPrecioDesc.UseVisualStyleBackColor = true;
            this.CBPrecioDesc.CheckedChanged += new System.EventHandler(this.CBPrecioDesc_CheckedChanged);
            // 
            // CBEnStock
            // 
            this.CBEnStock.AutoSize = true;
            this.CBEnStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBEnStock.Location = new System.Drawing.Point(93, 313);
            this.CBEnStock.Margin = new System.Windows.Forms.Padding(4);
            this.CBEnStock.Name = "CBEnStock";
            this.CBEnStock.Size = new System.Drawing.Size(91, 22);
            this.CBEnStock.TabIndex = 50;
            this.CBEnStock.Text = "En Stock";
            this.CBEnStock.UseVisualStyleBackColor = true;
            this.CBEnStock.CheckedChanged += new System.EventHandler(this.CBEnStock_CheckedChanged);
            // 
            // CBPrecioAsc
            // 
            this.CBPrecioAsc.AutoSize = true;
            this.CBPrecioAsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBPrecioAsc.Location = new System.Drawing.Point(325, 313);
            this.CBPrecioAsc.Margin = new System.Windows.Forms.Padding(4);
            this.CBPrecioAsc.Name = "CBPrecioAsc";
            this.CBPrecioAsc.Size = new System.Drawing.Size(102, 22);
            this.CBPrecioAsc.TabIndex = 52;
            this.CBPrecioAsc.Text = "Precio Asc";
            this.CBPrecioAsc.UseVisualStyleBackColor = true;
            this.CBPrecioAsc.CheckedChanged += new System.EventHandler(this.CBPrecioAsc_CheckedChanged);
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
            // BLimpiarFiltros
            // 
            this.BLimpiarFiltros.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BLimpiarFiltros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BLimpiarFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLimpiarFiltros.Image = global::ProyectoTaller.Properties.Resources.Limpiar;
            this.BLimpiarFiltros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BLimpiarFiltros.Location = new System.Drawing.Point(1004, 271);
            this.BLimpiarFiltros.Margin = new System.Windows.Forms.Padding(4);
            this.BLimpiarFiltros.Name = "BLimpiarFiltros";
            this.BLimpiarFiltros.Size = new System.Drawing.Size(164, 64);
            this.BLimpiarFiltros.TabIndex = 70;
            this.BLimpiarFiltros.Text = "Limpiar Filtros";
            this.BLimpiarFiltros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BLimpiarFiltros.UseVisualStyleBackColor = true;
            this.BLimpiarFiltros.Click += new System.EventHandler(this.BLimpiarFiltros_Click);
            // 
            // CBMarca
            // 
            this.CBMarca.FormattingEnabled = true;
            this.CBMarca.Items.AddRange(new object[] {
            "Apple",
            "Samsung",
            "Xiaomi",
            "Huawei",
            "Motorola"});
            this.CBMarca.Location = new System.Drawing.Point(306, 145);
            this.CBMarca.Margin = new System.Windows.Forms.Padding(4);
            this.CBMarca.Name = "CBMarca";
            this.CBMarca.Size = new System.Drawing.Size(235, 24);
            this.CBMarca.TabIndex = 73;
            this.CBMarca.Text = "Seleccione la Marca";
            // 
            // LValiMarca
            // 
            this.LValiMarca.AutoSize = true;
            this.LValiMarca.ForeColor = System.Drawing.Color.Red;
            this.LValiMarca.Location = new System.Drawing.Point(509, 319);
            this.LValiMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LValiMarca.Name = "LValiMarca";
            this.LValiMarca.Size = new System.Drawing.Size(0, 16);
            this.LValiMarca.TabIndex = 72;
            // 
            // LMarca
            // 
            this.LMarca.AutoSize = true;
            this.LMarca.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LMarca.Location = new System.Drawing.Point(149, 148);
            this.LMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LMarca.Name = "LMarca";
            this.LMarca.Size = new System.Drawing.Size(67, 21);
            this.LMarca.TabIndex = 71;
            this.LMarca.Text = "Marca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 201);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 75;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // TNombreProducto
            // 
            this.TNombreProducto.Location = new System.Drawing.Point(306, 200);
            this.TNombreProducto.Margin = new System.Windows.Forms.Padding(4);
            this.TNombreProducto.Name = "TNombreProducto";
            this.TNombreProducto.Size = new System.Drawing.Size(235, 22);
            this.TNombreProducto.TabIndex = 74;
            this.TNombreProducto.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 252);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 77;
            this.label2.Text = "Modelo";
            // 
            // TModelo
            // 
            this.TModelo.Location = new System.Drawing.Point(306, 251);
            this.TModelo.Margin = new System.Windows.Forms.Padding(4);
            this.TModelo.Name = "TModelo";
            this.TModelo.Size = new System.Drawing.Size(235, 22);
            this.TModelo.TabIndex = 76;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(642, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 21);
            this.label3.TabIndex = 79;
            this.label3.Text = "Memoria Ram";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TMemoriaRam
            // 
            this.TMemoriaRam.Location = new System.Drawing.Point(815, 98);
            this.TMemoriaRam.Margin = new System.Windows.Forms.Padding(4);
            this.TMemoriaRam.Name = "TMemoriaRam";
            this.TMemoriaRam.Size = new System.Drawing.Size(235, 22);
            this.TMemoriaRam.TabIndex = 78;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(642, 199);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 21);
            this.label5.TabIndex = 83;
            this.label5.Text = "Sistema Operativo";
            // 
            // TSistemaOperativo
            // 
            this.TSistemaOperativo.Location = new System.Drawing.Point(815, 200);
            this.TSistemaOperativo.Margin = new System.Windows.Forms.Padding(4);
            this.TSistemaOperativo.Name = "TSistemaOperativo";
            this.TSistemaOperativo.Size = new System.Drawing.Size(235, 22);
            this.TSistemaOperativo.TabIndex = 82;
            // 
            // LValiCodigoProd
            // 
            this.LValiCodigoProd.AutoSize = true;
            this.LValiCodigoProd.ForeColor = System.Drawing.Color.Red;
            this.LValiCodigoProd.Location = new System.Drawing.Point(305, 124);
            this.LValiCodigoProd.Name = "LValiCodigoProd";
            this.LValiCodigoProd.Size = new System.Drawing.Size(0, 16);
            this.LValiCodigoProd.TabIndex = 86;
            // 
            // LValiMarcaP
            // 
            this.LValiMarcaP.AutoSize = true;
            this.LValiMarcaP.Location = new System.Drawing.Point(305, 175);
            this.LValiMarcaP.Name = "LValiMarcaP";
            this.LValiMarcaP.Size = new System.Drawing.Size(0, 16);
            this.LValiMarcaP.TabIndex = 87;
            // 
            // LValiNombreP
            // 
            this.LValiNombreP.AutoSize = true;
            this.LValiNombreP.ForeColor = System.Drawing.Color.Red;
            this.LValiNombreP.Location = new System.Drawing.Point(305, 226);
            this.LValiNombreP.Name = "LValiNombreP";
            this.LValiNombreP.Size = new System.Drawing.Size(0, 16);
            this.LValiNombreP.TabIndex = 88;
            // 
            // LValiModeloP
            // 
            this.LValiModeloP.AutoSize = true;
            this.LValiModeloP.ForeColor = System.Drawing.Color.Red;
            this.LValiModeloP.Location = new System.Drawing.Point(305, 277);
            this.LValiModeloP.Name = "LValiModeloP";
            this.LValiModeloP.Size = new System.Drawing.Size(0, 16);
            this.LValiModeloP.TabIndex = 89;
            // 
            // LValiSistOpe
            // 
            this.LValiSistOpe.AutoSize = true;
            this.LValiSistOpe.ForeColor = System.Drawing.Color.Red;
            this.LValiSistOpe.Location = new System.Drawing.Point(816, 226);
            this.LValiSistOpe.Name = "LValiSistOpe";
            this.LValiSistOpe.Size = new System.Drawing.Size(0, 16);
            this.LValiSistOpe.TabIndex = 90;
            // 
            // TAlmacenamiento
            // 
            this.TAlmacenamiento.Location = new System.Drawing.Point(815, 149);
            this.TAlmacenamiento.Margin = new System.Windows.Forms.Padding(4);
            this.TAlmacenamiento.Name = "TAlmacenamiento";
            this.TAlmacenamiento.Size = new System.Drawing.Size(235, 22);
            this.TAlmacenamiento.TabIndex = 80;
            // 
            // LValiAllmac
            // 
            this.LValiAllmac.AutoSize = true;
            this.LValiAllmac.ForeColor = System.Drawing.Color.Red;
            this.LValiAllmac.Location = new System.Drawing.Point(816, 175);
            this.LValiAllmac.Name = "LValiAllmac";
            this.LValiAllmac.Size = new System.Drawing.Size(0, 16);
            this.LValiAllmac.TabIndex = 85;
            // 
            // LValiRamp
            // 
            this.LValiRamp.AutoSize = true;
            this.LValiRamp.ForeColor = System.Drawing.Color.Red;
            this.LValiRamp.Location = new System.Drawing.Point(816, 124);
            this.LValiRamp.Name = "LValiRamp";
            this.LValiRamp.Size = new System.Drawing.Size(0, 16);
            this.LValiRamp.TabIndex = 84;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(642, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 21);
            this.label4.TabIndex = 81;
            this.label4.Text = "Almacenamiento";
            // 
            // BBuscarProducto
            // 
            this.BBuscarProducto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscarProducto.Image = global::ProyectoTaller.Properties.Resources.Limpiar;
            this.BBuscarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BBuscarProducto.Location = new System.Drawing.Point(815, 271);
            this.BBuscarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.BBuscarProducto.Name = "BBuscarProducto";
            this.BBuscarProducto.Size = new System.Drawing.Size(164, 64);
            this.BBuscarProducto.TabIndex = 91;
            this.BBuscarProducto.Text = "Buscar";
            this.BBuscarProducto.UseVisualStyleBackColor = true;
            this.BBuscarProducto.Click += new System.EventHandler(this.BBuscarProducto_Click);
            // 
            // TConsultarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1183, 624);
            this.Controls.Add(this.BBuscarProducto);
            this.Controls.Add(this.LValiSistOpe);
            this.Controls.Add(this.LValiModeloP);
            this.Controls.Add(this.LValiNombreP);
            this.Controls.Add(this.LValiMarcaP);
            this.Controls.Add(this.LValiCodigoProd);
            this.Controls.Add(this.LValiAllmac);
            this.Controls.Add(this.LValiRamp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TSistemaOperativo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TAlmacenamiento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TMemoriaRam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TModelo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TNombreProducto);
            this.Controls.Add(this.CBMarca);
            this.Controls.Add(this.LValiMarca);
            this.Controls.Add(this.LMarca);
            this.Controls.Add(this.BLimpiarFiltros);
            this.Controls.Add(this.PBImagenProductos);
            this.Controls.Add(this.CBPrecioAsc);
            this.Controls.Add(this.CBPrecioDesc);
            this.Controls.Add(this.CBEnStock);
            this.Controls.Add(this.DGProductos);
            this.Controls.Add(this.LCodigoProducto);
            this.Controls.Add(this.TCodigoProducto);
            this.Controls.Add(this.LTituloAgregar);
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

        private System.Windows.Forms.Label LTituloAgregar;
        private System.Windows.Forms.Label LCodigoProducto;
        private System.Windows.Forms.TextBox TCodigoProducto;
        private System.Windows.Forms.DataGridView DGProductos;
        private System.Windows.Forms.CheckBox CBPrecioDesc;
        private System.Windows.Forms.CheckBox CBEnStock;
        private System.Windows.Forms.CheckBox CBPrecioAsc;
        private System.Windows.Forms.PictureBox PBImagenProductos;
        private System.Windows.Forms.Button BLimpiarFiltros;
        private System.Windows.Forms.ComboBox CBMarca;
        private System.Windows.Forms.Label LValiMarca;
        private System.Windows.Forms.Label LMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TNombreProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TMemoriaRam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TSistemaOperativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemoriaRam;
        private System.Windows.Forms.DataGridViewTextBoxColumn SistemaOperativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewButtonColumn Agregar;
        private System.Windows.Forms.Label LValiCodigoProd;
        private System.Windows.Forms.Label LValiMarcaP;
        private System.Windows.Forms.Label LValiNombreP;
        private System.Windows.Forms.Label LValiModeloP;
        private System.Windows.Forms.Label LValiSistOpe;
        private System.Windows.Forms.TextBox TAlmacenamiento;
        private System.Windows.Forms.Label LValiAllmac;
        private System.Windows.Forms.Label LValiRamp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BBuscarProducto;
    }
}