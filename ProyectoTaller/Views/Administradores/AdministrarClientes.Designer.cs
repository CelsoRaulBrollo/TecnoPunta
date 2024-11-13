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
            this.BActivarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // PBImagenCliente
            // 
            this.PBImagenCliente.Image = global::ProyectoTaller.Properties.Resources.NuevoCliente;
            this.PBImagenCliente.Location = new System.Drawing.Point(12, 12);
            this.PBImagenCliente.Name = "PBImagenCliente";
            this.PBImagenCliente.Size = new System.Drawing.Size(65, 67);
            this.PBImagenCliente.TabIndex = 68;
            this.PBImagenCliente.TabStop = false;
            // 
            // LTituloCliente
            // 
            this.LTituloCliente.AutoSize = true;
            this.LTituloCliente.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloCliente.Location = new System.Drawing.Point(78, 15);
            this.LTituloCliente.Name = "LTituloCliente";
            this.LTituloCliente.Size = new System.Drawing.Size(129, 36);
            this.LTituloCliente.TabIndex = 67;
            this.LTituloCliente.Text = "Clientes";
            // 
            // DGClientes
            // 
            this.DGClientes.AllowUserToAddRows = false;
            this.DGClientes.AllowUserToDeleteRows = false;
            this.DGClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGClientes.Location = new System.Drawing.Point(11, 117);
            this.DGClientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGClientes.Name = "DGClientes";
            this.DGClientes.ReadOnly = true;
            this.DGClientes.RowHeadersWidth = 51;
            this.DGClientes.RowTemplate.Height = 24;
            this.DGClientes.Size = new System.Drawing.Size(865, 379);
            this.DGClientes.TabIndex = 76;
            this.DGClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGClientes_CellContentClick);
            // 
            // TBuscarCliente
            // 
            this.TBuscarCliente.Location = new System.Drawing.Point(351, 77);
            this.TBuscarCliente.Name = "TBuscarCliente";
            this.TBuscarCliente.Size = new System.Drawing.Size(205, 20);
            this.TBuscarCliente.TabIndex = 80;
            this.TBuscarCliente.TextChanged += new System.EventHandler(this.TBuscarCliente_TextChanged);
            // 
            // LBuscarClientes
            // 
            this.LBuscarClientes.AutoSize = true;
            this.LBuscarClientes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBuscarClientes.Location = new System.Drawing.Point(380, 42);
            this.LBuscarClientes.Name = "LBuscarClientes";
            this.LBuscarClientes.Size = new System.Drawing.Size(147, 23);
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
            this.BBorrarCliente.Location = new System.Drawing.Point(735, 60);
            this.BBorrarCliente.Name = "BBorrarCliente";
            this.BBorrarCliente.Size = new System.Drawing.Size(141, 52);
            this.BBorrarCliente.TabIndex = 83;
            this.BBorrarCliente.Text = "Baja Cliente";
            this.BBorrarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BBorrarCliente.UseVisualStyleBackColor = true;
            this.BBorrarCliente.Click += new System.EventHandler(this.BBorrarCliente_Click);
            // 
            // BActivarCliente
            // 
            this.BActivarCliente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BActivarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BActivarCliente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BActivarCliente.FlatAppearance.BorderSize = 0;
            this.BActivarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BActivarCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BActivarCliente.Image = global::ProyectoTaller.Properties.Resources.Usuarios;
            this.BActivarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BActivarCliente.Location = new System.Drawing.Point(590, 60);
            this.BActivarCliente.Name = "BActivarCliente";
            this.BActivarCliente.Size = new System.Drawing.Size(140, 52);
            this.BActivarCliente.TabIndex = 84;
            this.BActivarCliente.Text = "Activar Cliente";
            this.BActivarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BActivarCliente.UseVisualStyleBackColor = true;
            this.BActivarCliente.Click += new System.EventHandler(this.BActivarCliente_Click);
            // 
            // AdministrarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(887, 507);
            this.Controls.Add(this.BActivarCliente);
            this.Controls.Add(this.BBorrarCliente);
            this.Controls.Add(this.LBuscarClientes);
            this.Controls.Add(this.TBuscarCliente);
            this.Controls.Add(this.DGClientes);
            this.Controls.Add(this.PBImagenCliente);
            this.Controls.Add(this.LTituloCliente);
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
        private System.Windows.Forms.Button BActivarCliente;
    }
}