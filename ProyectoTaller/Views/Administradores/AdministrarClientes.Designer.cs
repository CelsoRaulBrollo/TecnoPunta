namespace ProyectoTaller.Views.Administradores
{
    partial class AdministrarClientes
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
            this.PBImagenCliente = new System.Windows.Forms.PictureBox();
            this.LTituloCliente = new System.Windows.Forms.Label();
            this.DGClientes = new System.Windows.Forms.DataGridView();
            this.TBuscarCliente = new System.Windows.Forms.TextBox();
            this.LBuscarClientes = new System.Windows.Forms.Label();
            this.BBorrarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // PBImagenCliente
            // 
            this.PBImagenCliente.Image = global::ProyectoTaller.Properties.Resources.NuevoCliente;
            this.PBImagenCliente.Location = new System.Drawing.Point(16, 15);
            this.PBImagenCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PBImagenCliente.Name = "PBImagenCliente";
            this.PBImagenCliente.Size = new System.Drawing.Size(87, 82);
            this.PBImagenCliente.TabIndex = 68;
            this.PBImagenCliente.TabStop = false;
            // 
            // LTituloCliente
            // 
            this.LTituloCliente.AutoSize = true;
            this.LTituloCliente.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloCliente.Location = new System.Drawing.Point(104, 18);
            this.LTituloCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTituloCliente.Name = "LTituloCliente";
            this.LTituloCliente.Size = new System.Drawing.Size(163, 44);
            this.LTituloCliente.TabIndex = 67;
            this.LTituloCliente.Text = "Clientes";
            // 
            // DGClientes
            // 
            this.DGClientes.AllowUserToAddRows = false;
            this.DGClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGClientes.Location = new System.Drawing.Point(15, 144);
            this.DGClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGClientes.Name = "DGClientes";
            this.DGClientes.RowHeadersWidth = 51;
            this.DGClientes.RowTemplate.Height = 24;
            this.DGClientes.Size = new System.Drawing.Size(1153, 466);
            this.DGClientes.TabIndex = 76;
            this.DGClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGClientes_CellContentClick);
            // 
            // TBuscarCliente
            // 
            this.TBuscarCliente.Location = new System.Drawing.Point(468, 95);
            this.TBuscarCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBuscarCliente.Name = "TBuscarCliente";
            this.TBuscarCliente.Size = new System.Drawing.Size(272, 22);
            this.TBuscarCliente.TabIndex = 80;
            this.TBuscarCliente.TextChanged += new System.EventHandler(this.TBuscarCliente_TextChanged);
            // 
            // LBuscarClientes
            // 
            this.LBuscarClientes.AutoSize = true;
            this.LBuscarClientes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBuscarClientes.Location = new System.Drawing.Point(507, 52);
            this.LBuscarClientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBuscarClientes.Name = "LBuscarClientes";
            this.LBuscarClientes.Size = new System.Drawing.Size(186, 28);
            this.LBuscarClientes.TabIndex = 82;
            this.LBuscarClientes.Text = "Buscar Cliente:";
            // 
            // BBorrarCliente
            // 
            this.BBorrarCliente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BBorrarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BBorrarCliente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BBorrarCliente.FlatAppearance.BorderSize = 0;
            this.BBorrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBorrarCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BBorrarCliente.Image = global::ProyectoTaller.Properties.Resources.Eliminar;
            this.BBorrarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BBorrarCliente.Location = new System.Drawing.Point(993, 74);
            this.BBorrarCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BBorrarCliente.Name = "BBorrarCliente";
            this.BBorrarCliente.Size = new System.Drawing.Size(175, 64);
            this.BBorrarCliente.TabIndex = 83;
            this.BBorrarCliente.Text = "Borrar Cliente";
            this.BBorrarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BBorrarCliente.UseVisualStyleBackColor = true;
            this.BBorrarCliente.Click += new System.EventHandler(this.BBorrarCliente_Click);
            // 
            // AdministrarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1183, 624);
            this.Controls.Add(this.BBorrarCliente);
            this.Controls.Add(this.LBuscarClientes);
            this.Controls.Add(this.TBuscarCliente);
            this.Controls.Add(this.DGClientes);
            this.Controls.Add(this.PBImagenCliente);
            this.Controls.Add(this.LTituloCliente);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdministrarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdministrarClientes";
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBImagenCliente;
        private System.Windows.Forms.Label LTituloCliente;
        private System.Windows.Forms.DataGridView DGClientes;
        private System.Windows.Forms.TextBox TBuscarCliente;
        private System.Windows.Forms.Label LBuscarClientes;
        private System.Windows.Forms.Button BBorrarCliente;
    }
}