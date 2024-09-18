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
            this.LTituloAgregar = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.LNombreProducto = new System.Windows.Forms.Label();
            this.BBuscarVentas = new System.Windows.Forms.Button();
            this.TVentas = new System.Windows.Forms.TextBox();
            this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Agregar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LTituloAgregar
            // 
            this.LTituloAgregar.AutoSize = true;
            this.LTituloAgregar.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloAgregar.Location = new System.Drawing.Point(88, 74);
            this.LTituloAgregar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTituloAgregar.Name = "LTituloAgregar";
            this.LTituloAgregar.Size = new System.Drawing.Size(140, 44);
            this.LTituloAgregar.TabIndex = 1;
            this.LTituloAgregar.Text = "Carrito";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoProducto,
            this.Descripcion,
            this.Cantidad,
            this.Precio,
            this.Agregar});
            this.dataGridView1.Location = new System.Drawing.Point(64, 271);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1062, 212);
            this.dataGridView1.TabIndex = 50;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(983, 236);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 28);
            this.button1.TabIndex = 51;
            this.button1.Text = "Limpiar Carrito";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // LNombreProducto
            // 
            this.LNombreProducto.AutoSize = true;
            this.LNombreProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreProducto.Location = new System.Drawing.Point(507, 159);
            this.LNombreProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LNombreProducto.Name = "LNombreProducto";
            this.LNombreProducto.Size = new System.Drawing.Size(107, 21);
            this.LNombreProducto.TabIndex = 54;
            this.LNombreProducto.Text = "Descripcion";
            // 
            // BBuscarVentas
            // 
            this.BBuscarVentas.Location = new System.Drawing.Point(770, 180);
            this.BBuscarVentas.Margin = new System.Windows.Forms.Padding(4);
            this.BBuscarVentas.Name = "BBuscarVentas";
            this.BBuscarVentas.Size = new System.Drawing.Size(100, 28);
            this.BBuscarVentas.TabIndex = 53;
            this.BBuscarVentas.Text = "Buscar";
            this.BBuscarVentas.UseVisualStyleBackColor = true;
            // 
            // TVentas
            // 
            this.TVentas.Location = new System.Drawing.Point(380, 184);
            this.TVentas.Margin = new System.Windows.Forms.Padding(4);
            this.TVentas.Name = "TVentas";
            this.TVentas.Size = new System.Drawing.Size(368, 22);
            this.TVentas.TabIndex = 52;
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
            // Agregar
            // 
            this.Agregar.HeaderText = "Accion";
            this.Agregar.MinimumWidth = 6;
            this.Agregar.Name = "Agregar";
            this.Agregar.Text = "Quitar";
            this.Agregar.ToolTipText = "Quitar";
            this.Agregar.UseColumnTextForButtonValue = true;
            this.Agregar.Width = 125;
            // 
            // Carrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1155, 495);
            this.Controls.Add(this.LNombreProducto);
            this.Controls.Add(this.BBuscarVentas);
            this.Controls.Add(this.TVentas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LTituloAgregar);
            this.Name = "Carrito";
            this.Text = "Carrito";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LTituloAgregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewButtonColumn Agregar;
        private System.Windows.Forms.Label LNombreProducto;
        private System.Windows.Forms.Button BBuscarVentas;
        private System.Windows.Forms.TextBox TVentas;
    }
}