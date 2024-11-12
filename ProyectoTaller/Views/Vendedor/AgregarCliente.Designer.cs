namespace ProyectoTaller.Views.Vendedor
{
    partial class AgregarCliente
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
            this.LValido = new System.Windows.Forms.Label();
            this.LValiCorreo = new System.Windows.Forms.Label();
            this.LValiNombre = new System.Windows.Forms.Label();
            this.LCorreoCliente = new System.Windows.Forms.Label();
            this.LDni = new System.Windows.Forms.Label();
            this.LNombreCliente = new System.Windows.Forms.Label();
            this.LTituloCliente = new System.Windows.Forms.Label();
            this.LValiApellidoCliente = new System.Windows.Forms.Label();
            this.LApellidoCliente = new System.Windows.Forms.Label();
            this.LValiTelefono = new System.Windows.Forms.Label();
            this.LTelefonoCliente = new System.Windows.Forms.Label();
            this.LDatosClientes = new System.Windows.Forms.Label();
            this.PBImagenCliente = new System.Windows.Forms.PictureBox();
            this.BAgregar = new System.Windows.Forms.Button();
            this.LValidDNI = new System.Windows.Forms.Label();
            this.LDireccionCliente = new System.Windows.Forms.Label();
            this.LValiDireccionCliente = new System.Windows.Forms.Label();
            this.BEditarCliente = new System.Windows.Forms.Button();
            this.DGClientes = new System.Windows.Forms.DataGridView();
            this.LValiBuscarCliente = new System.Windows.Forms.Label();
            this.LBuscarCliente = new System.Windows.Forms.Label();
            this.TBuscarCliente = new System.Windows.Forms.TextBox();
            this.TNombreCliente = new System.Windows.Forms.TextBox();
            this.TApellidoCliente = new System.Windows.Forms.TextBox();
            this.TDNICliente = new System.Windows.Forms.TextBox();
            this.TTelefonoCliente = new System.Windows.Forms.TextBox();
            this.TCorreoCliente = new System.Windows.Forms.TextBox();
            this.TDireccionCliente = new System.Windows.Forms.TextBox();
            this.LGeneroCliente = new System.Windows.Forms.Label();
            this.CBGeneroCliente = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // LValido
            // 
            this.LValido.AutoSize = true;
            this.LValido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LValido.ForeColor = System.Drawing.Color.Green;
            this.LValido.Location = new System.Drawing.Point(425, 38);
            this.LValido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LValido.Name = "LValido";
            this.LValido.Size = new System.Drawing.Size(0, 23);
            this.LValido.TabIndex = 55;
            // 
            // LValiCorreo
            // 
            this.LValiCorreo.AutoSize = true;
            this.LValiCorreo.ForeColor = System.Drawing.Color.Red;
            this.LValiCorreo.Location = new System.Drawing.Point(652, 213);
            this.LValiCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LValiCorreo.Name = "LValiCorreo";
            this.LValiCorreo.Size = new System.Drawing.Size(0, 16);
            this.LValiCorreo.TabIndex = 53;
            // 
            // LValiNombre
            // 
            this.LValiNombre.AutoSize = true;
            this.LValiNombre.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.LValiNombre.ForeColor = System.Drawing.Color.Red;
            this.LValiNombre.Location = new System.Drawing.Point(229, 159);
            this.LValiNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LValiNombre.Name = "LValiNombre";
            this.LValiNombre.Size = new System.Drawing.Size(0, 16);
            this.LValiNombre.TabIndex = 50;
            // 
            // LCorreoCliente
            // 
            this.LCorreoCliente.AutoSize = true;
            this.LCorreoCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCorreoCliente.Location = new System.Drawing.Point(545, 190);
            this.LCorreoCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LCorreoCliente.Name = "LCorreoCliente";
            this.LCorreoCliente.Size = new System.Drawing.Size(67, 21);
            this.LCorreoCliente.TabIndex = 41;
            this.LCorreoCliente.Text = "Correo";
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDni.Location = new System.Drawing.Point(120, 242);
            this.LDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(41, 21);
            this.LDni.TabIndex = 39;
            this.LDni.Text = "DNI";
            // 
            // LNombreCliente
            // 
            this.LNombreCliente.AutoSize = true;
            this.LNombreCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreCliente.Location = new System.Drawing.Point(120, 135);
            this.LNombreCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LNombreCliente.Name = "LNombreCliente";
            this.LNombreCliente.Size = new System.Drawing.Size(84, 21);
            this.LNombreCliente.TabIndex = 38;
            this.LNombreCliente.Text = "Nombres";
            // 
            // LTituloCliente
            // 
            this.LTituloCliente.AutoSize = true;
            this.LTituloCliente.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloCliente.Location = new System.Drawing.Point(103, 16);
            this.LTituloCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTituloCliente.Name = "LTituloCliente";
            this.LTituloCliente.Size = new System.Drawing.Size(163, 44);
            this.LTituloCliente.TabIndex = 36;
            this.LTituloCliente.Text = "Clientes";
            // 
            // LValiApellidoCliente
            // 
            this.LValiApellidoCliente.AutoSize = true;
            this.LValiApellidoCliente.ForeColor = System.Drawing.Color.Red;
            this.LValiApellidoCliente.Location = new System.Drawing.Point(229, 214);
            this.LValiApellidoCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LValiApellidoCliente.Name = "LValiApellidoCliente";
            this.LValiApellidoCliente.Size = new System.Drawing.Size(0, 16);
            this.LValiApellidoCliente.TabIndex = 61;
            // 
            // LApellidoCliente
            // 
            this.LApellidoCliente.AutoSize = true;
            this.LApellidoCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellidoCliente.Location = new System.Drawing.Point(120, 191);
            this.LApellidoCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LApellidoCliente.Name = "LApellidoCliente";
            this.LApellidoCliente.Size = new System.Drawing.Size(85, 21);
            this.LApellidoCliente.TabIndex = 58;
            this.LApellidoCliente.Text = "Apellidos";
            // 
            // LValiTelefono
            // 
            this.LValiTelefono.AutoSize = true;
            this.LValiTelefono.ForeColor = System.Drawing.Color.Red;
            this.LValiTelefono.Location = new System.Drawing.Point(652, 159);
            this.LValiTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LValiTelefono.Name = "LValiTelefono";
            this.LValiTelefono.Size = new System.Drawing.Size(0, 16);
            this.LValiTelefono.TabIndex = 65;
            // 
            // LTelefonoCliente
            // 
            this.LTelefonoCliente.AutoSize = true;
            this.LTelefonoCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTelefonoCliente.Location = new System.Drawing.Point(544, 135);
            this.LTelefonoCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTelefonoCliente.Name = "LTelefonoCliente";
            this.LTelefonoCliente.Size = new System.Drawing.Size(80, 21);
            this.LTelefonoCliente.TabIndex = 62;
            this.LTelefonoCliente.Text = "Telefono";
            // 
            // LDatosClientes
            // 
            this.LDatosClientes.AutoSize = true;
            this.LDatosClientes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDatosClientes.Location = new System.Drawing.Point(121, 86);
            this.LDatosClientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LDatosClientes.Name = "LDatosClientes";
            this.LDatosClientes.Size = new System.Drawing.Size(218, 28);
            this.LDatosClientes.TabIndex = 67;
            this.LDatosClientes.Text = "Datos del Cliente:";
            // 
            // PBImagenCliente
            // 
            this.PBImagenCliente.Image = global::ProyectoTaller.Properties.Resources.NuevoCliente;
            this.PBImagenCliente.Location = new System.Drawing.Point(15, 14);
            this.PBImagenCliente.Margin = new System.Windows.Forms.Padding(4);
            this.PBImagenCliente.Name = "PBImagenCliente";
            this.PBImagenCliente.Size = new System.Drawing.Size(87, 82);
            this.PBImagenCliente.TabIndex = 66;
            this.PBImagenCliente.TabStop = false;
            // 
            // BAgregar
            // 
            this.BAgregar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAgregar.Image = global::ProyectoTaller.Properties.Resources.GuardarProducto;
            this.BAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BAgregar.Location = new System.Drawing.Point(982, 92);
            this.BAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.BAgregar.Name = "BAgregar";
            this.BAgregar.Size = new System.Drawing.Size(164, 64);
            this.BAgregar.TabIndex = 47;
            this.BAgregar.Text = "Agregar    ";
            this.BAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BAgregar.UseVisualStyleBackColor = true;
            this.BAgregar.Click += new System.EventHandler(this.BAgregar_Click);
            // 
            // LValidDNI
            // 
            this.LValidDNI.AutoSize = true;
            this.LValidDNI.ForeColor = System.Drawing.Color.Red;
            this.LValidDNI.Location = new System.Drawing.Point(229, 266);
            this.LValidDNI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LValidDNI.Name = "LValidDNI";
            this.LValidDNI.Size = new System.Drawing.Size(0, 16);
            this.LValidDNI.TabIndex = 68;
            // 
            // LDireccionCliente
            // 
            this.LDireccionCliente.AutoSize = true;
            this.LDireccionCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDireccionCliente.Location = new System.Drawing.Point(544, 242);
            this.LDireccionCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LDireccionCliente.Name = "LDireccionCliente";
            this.LDireccionCliente.Size = new System.Drawing.Size(88, 21);
            this.LDireccionCliente.TabIndex = 69;
            this.LDireccionCliente.Text = "Direccion";
            // 
            // LValiDireccionCliente
            // 
            this.LValiDireccionCliente.AutoSize = true;
            this.LValiDireccionCliente.ForeColor = System.Drawing.Color.Red;
            this.LValiDireccionCliente.Location = new System.Drawing.Point(652, 266);
            this.LValiDireccionCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LValiDireccionCliente.Name = "LValiDireccionCliente";
            this.LValiDireccionCliente.Size = new System.Drawing.Size(0, 16);
            this.LValiDireccionCliente.TabIndex = 73;
            // 
            // BEditarCliente
            // 
            this.BEditarCliente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BEditarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BEditarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEditarCliente.Image = global::ProyectoTaller.Properties.Resources.editar2;
            this.BEditarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BEditarCliente.Location = new System.Drawing.Point(982, 195);
            this.BEditarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.BEditarCliente.Name = "BEditarCliente";
            this.BEditarCliente.Size = new System.Drawing.Size(164, 64);
            this.BEditarCliente.TabIndex = 74;
            this.BEditarCliente.Text = "Editar   ";
            this.BEditarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BEditarCliente.UseVisualStyleBackColor = true;
            this.BEditarCliente.Click += new System.EventHandler(this.BEditarCliente_Click);
            // 
            // DGClientes
            // 
            this.DGClientes.AllowUserToAddRows = false;
            this.DGClientes.AllowUserToDeleteRows = false;
            this.DGClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGClientes.Location = new System.Drawing.Point(15, 391);
            this.DGClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGClientes.Name = "DGClientes";
            this.DGClientes.ReadOnly = true;
            this.DGClientes.RowHeadersWidth = 51;
            this.DGClientes.RowTemplate.Height = 24;
            this.DGClientes.Size = new System.Drawing.Size(1153, 219);
            this.DGClientes.TabIndex = 75;
            // 
            // LValiBuscarCliente
            // 
            this.LValiBuscarCliente.AutoSize = true;
            this.LValiBuscarCliente.ForeColor = System.Drawing.Color.Red;
            this.LValiBuscarCliente.Location = new System.Drawing.Point(587, 310);
            this.LValiBuscarCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LValiBuscarCliente.Name = "LValiBuscarCliente";
            this.LValiBuscarCliente.Size = new System.Drawing.Size(0, 16);
            this.LValiBuscarCliente.TabIndex = 80;
            // 
            // LBuscarCliente
            // 
            this.LBuscarCliente.AutoSize = true;
            this.LBuscarCliente.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBuscarCliente.Location = new System.Drawing.Point(10, 350);
            this.LBuscarCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBuscarCliente.Name = "LBuscarCliente";
            this.LBuscarCliente.Size = new System.Drawing.Size(179, 28);
            this.LBuscarCliente.TabIndex = 134;
            this.LBuscarCliente.Text = "Buscar Cliente";
            // 
            // TBuscarCliente
            // 
            this.TBuscarCliente.Location = new System.Drawing.Point(203, 353);
            this.TBuscarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.TBuscarCliente.Name = "TBuscarCliente";
            this.TBuscarCliente.Size = new System.Drawing.Size(368, 22);
            this.TBuscarCliente.TabIndex = 135;
            this.TBuscarCliente.TextChanged += new System.EventHandler(this.TBuscarCliente_TextChanged);
            // 
            // TNombreCliente
            // 
            this.TNombreCliente.Location = new System.Drawing.Point(232, 132);
            this.TNombreCliente.Margin = new System.Windows.Forms.Padding(4);
            this.TNombreCliente.Name = "TNombreCliente";
            this.TNombreCliente.Size = new System.Drawing.Size(272, 22);
            this.TNombreCliente.TabIndex = 136;
            // 
            // TApellidoCliente
            // 
            this.TApellidoCliente.Location = new System.Drawing.Point(232, 187);
            this.TApellidoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.TApellidoCliente.Name = "TApellidoCliente";
            this.TApellidoCliente.Size = new System.Drawing.Size(272, 22);
            this.TApellidoCliente.TabIndex = 137;
            // 
            // TDNICliente
            // 
            this.TDNICliente.Location = new System.Drawing.Point(232, 239);
            this.TDNICliente.Margin = new System.Windows.Forms.Padding(4);
            this.TDNICliente.Name = "TDNICliente";
            this.TDNICliente.Size = new System.Drawing.Size(272, 22);
            this.TDNICliente.TabIndex = 138;
            // 
            // TTelefonoCliente
            // 
            this.TTelefonoCliente.Location = new System.Drawing.Point(656, 130);
            this.TTelefonoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.TTelefonoCliente.Name = "TTelefonoCliente";
            this.TTelefonoCliente.Size = new System.Drawing.Size(272, 22);
            this.TTelefonoCliente.TabIndex = 139;
            // 
            // TCorreoCliente
            // 
            this.TCorreoCliente.Location = new System.Drawing.Point(656, 187);
            this.TCorreoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.TCorreoCliente.Name = "TCorreoCliente";
            this.TCorreoCliente.Size = new System.Drawing.Size(272, 22);
            this.TCorreoCliente.TabIndex = 140;
            // 
            // TDireccionCliente
            // 
            this.TDireccionCliente.Location = new System.Drawing.Point(656, 239);
            this.TDireccionCliente.Margin = new System.Windows.Forms.Padding(4);
            this.TDireccionCliente.Name = "TDireccionCliente";
            this.TDireccionCliente.Size = new System.Drawing.Size(272, 22);
            this.TDireccionCliente.TabIndex = 141;
            // 
            // LGeneroCliente
            // 
            this.LGeneroCliente.AutoSize = true;
            this.LGeneroCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LGeneroCliente.Location = new System.Drawing.Point(120, 290);
            this.LGeneroCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LGeneroCliente.Name = "LGeneroCliente";
            this.LGeneroCliente.Size = new System.Drawing.Size(73, 21);
            this.LGeneroCliente.TabIndex = 142;
            this.LGeneroCliente.Text = "Genero";
            // 
            // CBGeneroCliente
            // 
            this.CBGeneroCliente.FormattingEnabled = true;
            this.CBGeneroCliente.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Otro"});
            this.CBGeneroCliente.Location = new System.Drawing.Point(232, 290);
            this.CBGeneroCliente.Name = "CBGeneroCliente";
            this.CBGeneroCliente.Size = new System.Drawing.Size(272, 24);
            this.CBGeneroCliente.TabIndex = 143;
            // 
            // AgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1183, 624);
            this.Controls.Add(this.CBGeneroCliente);
            this.Controls.Add(this.LGeneroCliente);
            this.Controls.Add(this.TDireccionCliente);
            this.Controls.Add(this.TCorreoCliente);
            this.Controls.Add(this.TTelefonoCliente);
            this.Controls.Add(this.TDNICliente);
            this.Controls.Add(this.TApellidoCliente);
            this.Controls.Add(this.TNombreCliente);
            this.Controls.Add(this.TBuscarCliente);
            this.Controls.Add(this.LBuscarCliente);
            this.Controls.Add(this.LValiBuscarCliente);
            this.Controls.Add(this.DGClientes);
            this.Controls.Add(this.BEditarCliente);
            this.Controls.Add(this.LValiDireccionCliente);
            this.Controls.Add(this.LDireccionCliente);
            this.Controls.Add(this.LValidDNI);
            this.Controls.Add(this.LDatosClientes);
            this.Controls.Add(this.PBImagenCliente);
            this.Controls.Add(this.LValiTelefono);
            this.Controls.Add(this.LTelefonoCliente);
            this.Controls.Add(this.LValiApellidoCliente);
            this.Controls.Add(this.LApellidoCliente);
            this.Controls.Add(this.LValido);
            this.Controls.Add(this.LValiCorreo);
            this.Controls.Add(this.LValiNombre);
            this.Controls.Add(this.BAgregar);
            this.Controls.Add(this.LCorreoCliente);
            this.Controls.Add(this.LDni);
            this.Controls.Add(this.LNombreCliente);
            this.Controls.Add(this.LTituloCliente);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AgregarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarCliente";
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LValido;
        private System.Windows.Forms.Label LValiCorreo;
        private System.Windows.Forms.Label LValiNombre;
        private System.Windows.Forms.Button BAgregar;
        private System.Windows.Forms.Label LCorreoCliente;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.Label LNombreCliente;
        private System.Windows.Forms.Label LTituloCliente;
        private System.Windows.Forms.Label LValiApellidoCliente;
        private System.Windows.Forms.Label LApellidoCliente;
        private System.Windows.Forms.Label LValiTelefono;
        private System.Windows.Forms.Label LTelefonoCliente;
        private System.Windows.Forms.PictureBox PBImagenCliente;
        private System.Windows.Forms.Label LDatosClientes;
        private System.Windows.Forms.Label LValidDNI;
        private System.Windows.Forms.Label LDireccionCliente;
        private System.Windows.Forms.Label LValiDireccionCliente;
        private System.Windows.Forms.Button BEditarCliente;
        private System.Windows.Forms.DataGridView DGClientes;
        private System.Windows.Forms.Label LValiBuscarCliente;
        private System.Windows.Forms.Label LBuscarCliente;
        private System.Windows.Forms.TextBox TBuscarCliente;
        private System.Windows.Forms.TextBox TNombreCliente;
        private System.Windows.Forms.TextBox TApellidoCliente;
        private System.Windows.Forms.TextBox TDNICliente;
        private System.Windows.Forms.TextBox TTelefonoCliente;
        private System.Windows.Forms.TextBox TCorreoCliente;
        private System.Windows.Forms.TextBox TDireccionCliente;
        private System.Windows.Forms.Label LGeneroCliente;
        private System.Windows.Forms.ComboBox CBGeneroCliente;
    }
}