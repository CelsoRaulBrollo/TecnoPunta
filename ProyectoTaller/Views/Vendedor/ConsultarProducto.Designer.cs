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
            this.BBuscarVentas = new System.Windows.Forms.Button();
            this.TVentas = new System.Windows.Forms.TextBox();
            this.LNombreProducto = new System.Windows.Forms.Label();
            this.LValiCate = new System.Windows.Forms.Label();
            this.CBCategoria = new System.Windows.Forms.ComboBox();
            this.LCategoria = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Agregar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CBNoLeidas = new System.Windows.Forms.CheckBox();
            this.CBLeidas = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LTituloAgregar
            // 
            this.LTituloAgregar.AutoSize = true;
            this.LTituloAgregar.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloAgregar.Location = new System.Drawing.Point(105, 39);
            this.LTituloAgregar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTituloAgregar.Name = "LTituloAgregar";
            this.LTituloAgregar.Size = new System.Drawing.Size(197, 44);
            this.LTituloAgregar.TabIndex = 37;
            this.LTituloAgregar.Text = "Productos";
            // 
            // BBuscarVentas
            // 
            this.BBuscarVentas.Location = new System.Drawing.Point(826, 245);
            this.BBuscarVentas.Margin = new System.Windows.Forms.Padding(4);
            this.BBuscarVentas.Name = "BBuscarVentas";
            this.BBuscarVentas.Size = new System.Drawing.Size(100, 28);
            this.BBuscarVentas.TabIndex = 39;
            this.BBuscarVentas.Text = "Buscar";
            this.BBuscarVentas.UseVisualStyleBackColor = true;
            // 
            // TVentas
            // 
            this.TVentas.Location = new System.Drawing.Point(436, 249);
            this.TVentas.Margin = new System.Windows.Forms.Padding(4);
            this.TVentas.Name = "TVentas";
            this.TVentas.Size = new System.Drawing.Size(368, 22);
            this.TVentas.TabIndex = 38;
            // 
            // LNombreProducto
            // 
            this.LNombreProducto.AutoSize = true;
            this.LNombreProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreProducto.Location = new System.Drawing.Point(563, 224);
            this.LNombreProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LNombreProducto.Name = "LNombreProducto";
            this.LNombreProducto.Size = new System.Drawing.Size(107, 21);
            this.LNombreProducto.TabIndex = 40;
            this.LNombreProducto.Text = "Descripcion";
            // 
            // LValiCate
            // 
            this.LValiCate.AutoSize = true;
            this.LValiCate.ForeColor = System.Drawing.Color.Red;
            this.LValiCate.Location = new System.Drawing.Point(914, 171);
            this.LValiCate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LValiCate.Name = "LValiCate";
            this.LValiCate.Size = new System.Drawing.Size(0, 16);
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
            this.CBCategoria.Location = new System.Drawing.Point(860, 172);
            this.CBCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.CBCategoria.Name = "CBCategoria";
            this.CBCategoria.Size = new System.Drawing.Size(272, 24);
            this.CBCategoria.TabIndex = 42;
            this.CBCategoria.Text = "Seleccione una categoría";
            // 
            // LCategoria
            // 
            this.LCategoria.AutoSize = true;
            this.LCategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCategoria.Location = new System.Drawing.Point(941, 146);
            this.LCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LCategoria.Name = "LCategoria";
            this.LCategoria.Size = new System.Drawing.Size(96, 21);
            this.LCategoria.TabIndex = 41;
            this.LCategoria.Text = "Categoría";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1050, 309);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 44;
            this.button1.Text = "Limpiar Filtros";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 21);
            this.label1.TabIndex = 46;
            this.label1.Text = "CodigoProducto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 171);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 22);
            this.textBox1.TabIndex = 45;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(591, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 48;
            this.label2.Text = "Precio";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(503, 171);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(235, 22);
            this.textBox2.TabIndex = 47;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoProducto,
            this.Descripcion,
            this.Stock,
            this.Precio,
            this.Agregar});
            this.dataGridView1.Location = new System.Drawing.Point(113, 344);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1052, 131);
            this.dataGridView1.TabIndex = 49;
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
            this.Descripcion.Width = 500;
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
            // CBNoLeidas
            // 
            this.CBNoLeidas.AutoSize = true;
            this.CBNoLeidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBNoLeidas.Location = new System.Drawing.Point(276, 315);
            this.CBNoLeidas.Margin = new System.Windows.Forms.Padding(4);
            this.CBNoLeidas.Name = "CBNoLeidas";
            this.CBNoLeidas.Size = new System.Drawing.Size(65, 22);
            this.CBNoLeidas.TabIndex = 51;
            this.CBNoLeidas.Text = "Desc";
            this.CBNoLeidas.UseVisualStyleBackColor = true;
            // 
            // CBLeidas
            // 
            this.CBLeidas.AutoSize = true;
            this.CBLeidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBLeidas.Location = new System.Drawing.Point(184, 315);
            this.CBLeidas.Margin = new System.Windows.Forms.Padding(4);
            this.CBLeidas.Name = "CBLeidas";
            this.CBLeidas.Size = new System.Drawing.Size(91, 22);
            this.CBLeidas.TabIndex = 50;
            this.CBLeidas.Text = "En Stock";
            this.CBLeidas.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(349, 315);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(55, 22);
            this.checkBox1.TabIndex = 52;
            this.checkBox1.Text = "Asc";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // ConsultarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1263, 537);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.CBNoLeidas);
            this.Controls.Add(this.CBLeidas);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LValiCate);
            this.Controls.Add(this.CBCategoria);
            this.Controls.Add(this.LCategoria);
            this.Controls.Add(this.LNombreProducto);
            this.Controls.Add(this.BBuscarVentas);
            this.Controls.Add(this.TVentas);
            this.Controls.Add(this.LTituloAgregar);
            this.Name = "ConsultarProducto";
            this.Text = "ConsultarProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LTituloAgregar;
        private System.Windows.Forms.Button BBuscarVentas;
        private System.Windows.Forms.TextBox TVentas;
        private System.Windows.Forms.Label LNombreProducto;
        private System.Windows.Forms.Label LValiCate;
        private System.Windows.Forms.ComboBox CBCategoria;
        private System.Windows.Forms.Label LCategoria;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewButtonColumn Agregar;
        private System.Windows.Forms.CheckBox CBNoLeidas;
        private System.Windows.Forms.CheckBox CBLeidas;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}