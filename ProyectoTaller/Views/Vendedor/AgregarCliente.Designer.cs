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
            this.BBorrar = new System.Windows.Forms.Button();
            this.BAgregar = new System.Windows.Forms.Button();
            this.LValidDNI = new System.Windows.Forms.Label();
            this.LDireccionCliente = new System.Windows.Forms.Label();
            this.LRespuestaNuevoCliente = new System.Windows.Forms.Label();
            this.LValiDireccionCliente = new System.Windows.Forms.Label();
            this.BEditarCliente = new System.Windows.Forms.Button();
            this.DGClientes = new System.Windows.Forms.DataGridView();
            this.CDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CApellidoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTelefonoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCorreoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDireccionCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LValiBuscarCliente = new System.Windows.Forms.Label();
            this.LBuscarCliente = new System.Windows.Forms.Label();
            this.TBuscarCliente = new System.Windows.Forms.TextBox();
            this.TNombreCliente = new System.Windows.Forms.TextBox();
            this.TApellidoCliente = new System.Windows.Forms.TextBox();
            this.TDNICliente = new System.Windows.Forms.TextBox();
            this.TTelefonoCliente = new System.Windows.Forms.TextBox();
            this.TCorreoCliente = new System.Windows.Forms.TextBox();
            this.TDireccionCliente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // LValido
            // 
            this.LValido.AutoSize = true;
            this.LValido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LValido.ForeColor = System.Drawing.Color.Green;
            this.LValido.Location = new System.Drawing.Point(262, 26);
            this.LValido.Name = "LValido";
            this.LValido.Size = new System.Drawing.Size(0, 21);
            this.LValido.TabIndex = 55;
            // 
            // LValiCorreo
            // 
            this.LValiCorreo.AutoSize = true;
            this.LValiCorreo.ForeColor = System.Drawing.Color.Red;
            this.LValiCorreo.Location = new System.Drawing.Point(489, 173);
            this.LValiCorreo.Name = "LValiCorreo";
            this.LValiCorreo.Size = new System.Drawing.Size(0, 13);
            this.LValiCorreo.TabIndex = 53;
            // 
            // LValiNombre
            // 
            this.LValiNombre.AutoSize = true;
            this.LValiNombre.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.LValiNombre.ForeColor = System.Drawing.Color.Red;
            this.LValiNombre.Location = new System.Drawing.Point(172, 129);
            this.LValiNombre.Name = "LValiNombre";
            this.LValiNombre.Size = new System.Drawing.Size(0, 13);
            this.LValiNombre.TabIndex = 50;
            // 
            // LCorreoCliente
            // 
            this.LCorreoCliente.AutoSize = true;
            this.LCorreoCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCorreoCliente.Location = new System.Drawing.Point(409, 154);
            this.LCorreoCliente.Name = "LCorreoCliente";
            this.LCorreoCliente.Size = new System.Drawing.Size(53, 17);
            this.LCorreoCliente.TabIndex = 41;
            this.LCorreoCliente.Text = "Correo";
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDni.Location = new System.Drawing.Point(90, 197);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(31, 17);
            this.LDni.TabIndex = 39;
            this.LDni.Text = "DNI";
            // 
            // LNombreCliente
            // 
            this.LNombreCliente.AutoSize = true;
            this.LNombreCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreCliente.Location = new System.Drawing.Point(90, 110);
            this.LNombreCliente.Name = "LNombreCliente";
            this.LNombreCliente.Size = new System.Drawing.Size(66, 17);
            this.LNombreCliente.TabIndex = 38;
            this.LNombreCliente.Text = "Nombres";
            this.LNombreCliente.Click += new System.EventHandler(this.LNombreProducto_Click);
            // 
            // LTituloCliente
            // 
            this.LTituloCliente.AutoSize = true;
            this.LTituloCliente.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloCliente.Location = new System.Drawing.Point(77, 13);
            this.LTituloCliente.Name = "LTituloCliente";
            this.LTituloCliente.Size = new System.Drawing.Size(129, 36);
            this.LTituloCliente.TabIndex = 36;
            this.LTituloCliente.Text = "Clientes";
            this.LTituloCliente.Click += new System.EventHandler(this.LTituloAgregar_Click);
            // 
            // LValiApellidoCliente
            // 
            this.LValiApellidoCliente.AutoSize = true;
            this.LValiApellidoCliente.ForeColor = System.Drawing.Color.Red;
            this.LValiApellidoCliente.Location = new System.Drawing.Point(172, 174);
            this.LValiApellidoCliente.Name = "LValiApellidoCliente";
            this.LValiApellidoCliente.Size = new System.Drawing.Size(0, 13);
            this.LValiApellidoCliente.TabIndex = 61;
            // 
            // LApellidoCliente
            // 
            this.LApellidoCliente.AutoSize = true;
            this.LApellidoCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellidoCliente.Location = new System.Drawing.Point(90, 155);
            this.LApellidoCliente.Name = "LApellidoCliente";
            this.LApellidoCliente.Size = new System.Drawing.Size(66, 17);
            this.LApellidoCliente.TabIndex = 58;
            this.LApellidoCliente.Text = "Apellidos";
            // 
            // LValiTelefono
            // 
            this.LValiTelefono.AutoSize = true;
            this.LValiTelefono.ForeColor = System.Drawing.Color.Red;
            this.LValiTelefono.Location = new System.Drawing.Point(489, 129);
            this.LValiTelefono.Name = "LValiTelefono";
            this.LValiTelefono.Size = new System.Drawing.Size(0, 13);
            this.LValiTelefono.TabIndex = 65;
            // 
            // LTelefonoCliente
            // 
            this.LTelefonoCliente.AutoSize = true;
            this.LTelefonoCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTelefonoCliente.Location = new System.Drawing.Point(408, 110);
            this.LTelefonoCliente.Name = "LTelefonoCliente";
            this.LTelefonoCliente.Size = new System.Drawing.Size(62, 17);
            this.LTelefonoCliente.TabIndex = 62;
            this.LTelefonoCliente.Text = "Telefono";
            // 
            // LDatosClientes
            // 
            this.LDatosClientes.AutoSize = true;
            this.LDatosClientes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDatosClientes.Location = new System.Drawing.Point(89, 70);
            this.LDatosClientes.Name = "LDatosClientes";
            this.LDatosClientes.Size = new System.Drawing.Size(173, 23);
            this.LDatosClientes.TabIndex = 67;
            this.LDatosClientes.Text = "Datos del Cliente:";
            // 
            // PBImagenCliente
            // 
            this.PBImagenCliente.Image = global::ProyectoTaller.Properties.Resources.NuevoCliente;
            this.PBImagenCliente.Location = new System.Drawing.Point(11, 11);
            this.PBImagenCliente.Name = "PBImagenCliente";
            this.PBImagenCliente.Size = new System.Drawing.Size(65, 67);
            this.PBImagenCliente.TabIndex = 66;
            this.PBImagenCliente.TabStop = false;
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
            this.BBorrar.Location = new System.Drawing.Point(729, 77);
            this.BBorrar.Name = "BBorrar";
            this.BBorrar.Size = new System.Drawing.Size(123, 52);
            this.BBorrar.TabIndex = 48;
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
            this.BAgregar.Image = global::ProyectoTaller.Properties.Resources.GuardarProducto;
            this.BAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BAgregar.Location = new System.Drawing.Point(729, 135);
            this.BAgregar.Name = "BAgregar";
            this.BAgregar.Size = new System.Drawing.Size(123, 52);
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
            this.LValidDNI.Location = new System.Drawing.Point(172, 216);
            this.LValidDNI.Name = "LValidDNI";
            this.LValidDNI.Size = new System.Drawing.Size(0, 13);
            this.LValidDNI.TabIndex = 68;
            // 
            // LDireccionCliente
            // 
            this.LDireccionCliente.AutoSize = true;
            this.LDireccionCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDireccionCliente.Location = new System.Drawing.Point(408, 197);
            this.LDireccionCliente.Name = "LDireccionCliente";
            this.LDireccionCliente.Size = new System.Drawing.Size(69, 17);
            this.LDireccionCliente.TabIndex = 69;
            this.LDireccionCliente.Text = "Direccion";
            // 
            // LRespuestaNuevoCliente
            // 
            this.LRespuestaNuevoCliente.AutoSize = true;
            this.LRespuestaNuevoCliente.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRespuestaNuevoCliente.ForeColor = System.Drawing.Color.ForestGreen;
            this.LRespuestaNuevoCliente.Location = new System.Drawing.Point(262, 72);
            this.LRespuestaNuevoCliente.Name = "LRespuestaNuevoCliente";
            this.LRespuestaNuevoCliente.Size = new System.Drawing.Size(0, 22);
            this.LRespuestaNuevoCliente.TabIndex = 72;
            // 
            // LValiDireccionCliente
            // 
            this.LValiDireccionCliente.AutoSize = true;
            this.LValiDireccionCliente.ForeColor = System.Drawing.Color.Red;
            this.LValiDireccionCliente.Location = new System.Drawing.Point(489, 216);
            this.LValiDireccionCliente.Name = "LValiDireccionCliente";
            this.LValiDireccionCliente.Size = new System.Drawing.Size(0, 13);
            this.LValiDireccionCliente.TabIndex = 73;
            // 
            // BEditarCliente
            // 
            this.BEditarCliente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BEditarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BEditarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEditarCliente.Image = global::ProyectoTaller.Properties.Resources.editar2;
            this.BEditarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BEditarCliente.Location = new System.Drawing.Point(729, 193);
            this.BEditarCliente.Name = "BEditarCliente";
            this.BEditarCliente.Size = new System.Drawing.Size(123, 52);
            this.BEditarCliente.TabIndex = 74;
            this.BEditarCliente.Text = "Editar   ";
            this.BEditarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BEditarCliente.UseVisualStyleBackColor = true;
            this.BEditarCliente.Click += new System.EventHandler(this.BEditarCliente_Click);
            // 
            // DGClientes
            // 
            this.DGClientes.AllowUserToAddRows = false;
            this.DGClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CDNI,
            this.CNombreCliente,
            this.CApellidoCliente,
            this.CTelefonoCliente,
            this.CCorreoCliente,
            this.CDireccionCliente});
            this.DGClientes.Location = new System.Drawing.Point(11, 273);
            this.DGClientes.Margin = new System.Windows.Forms.Padding(2);
            this.DGClientes.Name = "DGClientes";
            this.DGClientes.RowHeadersWidth = 51;
            this.DGClientes.RowTemplate.Height = 24;
            this.DGClientes.Size = new System.Drawing.Size(865, 223);
            this.DGClientes.TabIndex = 75;
            // 
            // CDNI
            // 
            this.CDNI.HeaderText = "DNI";
            this.CDNI.MinimumWidth = 6;
            this.CDNI.Name = "CDNI";
            this.CDNI.Width = 125;
            // 
            // CNombreCliente
            // 
            this.CNombreCliente.HeaderText = "Nombre";
            this.CNombreCliente.MinimumWidth = 6;
            this.CNombreCliente.Name = "CNombreCliente";
            this.CNombreCliente.Width = 200;
            // 
            // CApellidoCliente
            // 
            this.CApellidoCliente.HeaderText = "Apellido";
            this.CApellidoCliente.MinimumWidth = 6;
            this.CApellidoCliente.Name = "CApellidoCliente";
            this.CApellidoCliente.Width = 200;
            // 
            // CTelefonoCliente
            // 
            this.CTelefonoCliente.HeaderText = "Telefono";
            this.CTelefonoCliente.MinimumWidth = 6;
            this.CTelefonoCliente.Name = "CTelefonoCliente";
            this.CTelefonoCliente.Width = 125;
            // 
            // CCorreoCliente
            // 
            this.CCorreoCliente.HeaderText = "Correo";
            this.CCorreoCliente.MinimumWidth = 6;
            this.CCorreoCliente.Name = "CCorreoCliente";
            this.CCorreoCliente.Width = 260;
            // 
            // CDireccionCliente
            // 
            this.CDireccionCliente.HeaderText = "Direccion";
            this.CDireccionCliente.MinimumWidth = 6;
            this.CDireccionCliente.Name = "CDireccionCliente";
            this.CDireccionCliente.Width = 200;
            // 
            // LValiBuscarCliente
            // 
            this.LValiBuscarCliente.AutoSize = true;
            this.LValiBuscarCliente.ForeColor = System.Drawing.Color.Red;
            this.LValiBuscarCliente.Location = new System.Drawing.Point(440, 252);
            this.LValiBuscarCliente.Name = "LValiBuscarCliente";
            this.LValiBuscarCliente.Size = new System.Drawing.Size(0, 13);
            this.LValiBuscarCliente.TabIndex = 80;
            // 
            // LBuscarCliente
            // 
            this.LBuscarCliente.AutoSize = true;
            this.LBuscarCliente.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBuscarCliente.Location = new System.Drawing.Point(11, 245);
            this.LBuscarCliente.Name = "LBuscarCliente";
            this.LBuscarCliente.Size = new System.Drawing.Size(142, 23);
            this.LBuscarCliente.TabIndex = 134;
            this.LBuscarCliente.Text = "Buscar Cliente";
            // 
            // TBuscarCliente
            // 
            this.TBuscarCliente.Location = new System.Drawing.Point(156, 248);
            this.TBuscarCliente.Name = "TBuscarCliente";
            this.TBuscarCliente.Size = new System.Drawing.Size(277, 20);
            this.TBuscarCliente.TabIndex = 135;
            // 
            // TNombreCliente
            // 
            this.TNombreCliente.Location = new System.Drawing.Point(174, 107);
            this.TNombreCliente.Name = "TNombreCliente";
            this.TNombreCliente.Size = new System.Drawing.Size(205, 20);
            this.TNombreCliente.TabIndex = 136;
            // 
            // TApellidoCliente
            // 
            this.TApellidoCliente.Location = new System.Drawing.Point(174, 152);
            this.TApellidoCliente.Name = "TApellidoCliente";
            this.TApellidoCliente.Size = new System.Drawing.Size(205, 20);
            this.TApellidoCliente.TabIndex = 137;
            // 
            // TDNICliente
            // 
            this.TDNICliente.Location = new System.Drawing.Point(174, 194);
            this.TDNICliente.Name = "TDNICliente";
            this.TDNICliente.Size = new System.Drawing.Size(205, 20);
            this.TDNICliente.TabIndex = 138;
            // 
            // TTelefonoCliente
            // 
            this.TTelefonoCliente.Location = new System.Drawing.Point(492, 106);
            this.TTelefonoCliente.Name = "TTelefonoCliente";
            this.TTelefonoCliente.Size = new System.Drawing.Size(205, 20);
            this.TTelefonoCliente.TabIndex = 139;
            // 
            // TCorreoCliente
            // 
            this.TCorreoCliente.Location = new System.Drawing.Point(492, 152);
            this.TCorreoCliente.Name = "TCorreoCliente";
            this.TCorreoCliente.Size = new System.Drawing.Size(205, 20);
            this.TCorreoCliente.TabIndex = 140;
            // 
            // TDireccionCliente
            // 
            this.TDireccionCliente.Location = new System.Drawing.Point(492, 194);
            this.TDireccionCliente.Name = "TDireccionCliente";
            this.TDireccionCliente.Size = new System.Drawing.Size(205, 20);
            this.TDireccionCliente.TabIndex = 141;
            // 
            // AgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(887, 507);
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
            this.Controls.Add(this.LRespuestaNuevoCliente);
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
            this.Controls.Add(this.BBorrar);
            this.Controls.Add(this.BAgregar);
            this.Controls.Add(this.LCorreoCliente);
            this.Controls.Add(this.LDni);
            this.Controls.Add(this.LNombreCliente);
            this.Controls.Add(this.LTituloCliente);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AgregarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarCliente";
            this.Load += new System.EventHandler(this.AgregarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LValido;
        private System.Windows.Forms.Label LValiCorreo;
        private System.Windows.Forms.Label LValiNombre;
        private System.Windows.Forms.Button BBorrar;
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
        private System.Windows.Forms.Label LRespuestaNuevoCliente;
        private System.Windows.Forms.Label LValiDireccionCliente;
        private System.Windows.Forms.Button BEditarCliente;
        private System.Windows.Forms.DataGridView DGClientes;
        private System.Windows.Forms.Label LValiBuscarCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CApellidoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTelefonoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCorreoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDireccionCliente;
        private System.Windows.Forms.Label LBuscarCliente;
        private System.Windows.Forms.TextBox TBuscarCliente;
        private System.Windows.Forms.TextBox TNombreCliente;
        private System.Windows.Forms.TextBox TApellidoCliente;
        private System.Windows.Forms.TextBox TDNICliente;
        private System.Windows.Forms.TextBox TTelefonoCliente;
        private System.Windows.Forms.TextBox TCorreoCliente;
        private System.Windows.Forms.TextBox TDireccionCliente;
    }
}