namespace ProyectoTaller.Views.Administradores
{
    partial class GestionUsuarios
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
            this.PBImagenUsuarios = new System.Windows.Forms.PictureBox();
            this.LTituloUsuarios = new System.Windows.Forms.Label();
            this.CBPuesto = new System.Windows.Forms.ComboBox();
            this.TEmail = new System.Windows.Forms.TextBox();
            this.LEmail = new System.Windows.Forms.Label();
            this.TTelefono = new System.Windows.Forms.TextBox();
            this.LValiEmail = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.LValiTelefono = new System.Windows.Forms.Label();
            this.LValiPuesto = new System.Windows.Forms.Label();
            this.LValiNombre = new System.Windows.Forms.Label();
            this.LValiDni = new System.Windows.Forms.Label();
            this.TApellido = new System.Windows.Forms.TextBox();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.LTelefono = new System.Windows.Forms.Label();
            this.LPuesto = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.LDni = new System.Windows.Forms.Label();
            this.TDni = new System.Windows.Forms.TextBox();
            this.LValiApellido = new System.Windows.Forms.Label();
            this.BAgregar = new System.Windows.Forms.Button();
            this.BEliminar = new System.Windows.Forms.Button();
            this.DGUsuarios = new System.Windows.Forms.DataGridView();
            this.BBorrar = new System.Windows.Forms.Button();
            this.LSexo = new System.Windows.Forms.Label();
            this.LValiSexo = new System.Windows.Forms.Label();
            this.TSueldo = new System.Windows.Forms.TextBox();
            this.LSueldo = new System.Windows.Forms.Label();
            this.LValiSueldo = new System.Windows.Forms.Label();
            this.CBSexo = new System.Windows.Forms.ComboBox();
            this.TBuscarUsuarios = new System.Windows.Forms.TextBox();
            this.LBuscarUsuario = new System.Windows.Forms.Label();
            this.CBGerente = new System.Windows.Forms.CheckBox();
            this.CBVendedor = new System.Windows.Forms.CheckBox();
            this.CBAdministrador = new System.Windows.Forms.CheckBox();
            this.BEditar = new System.Windows.Forms.Button();
            this.LValido = new System.Windows.Forms.Label();
            this.CPuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // PBImagenUsuarios
            // 
            this.PBImagenUsuarios.Image = global::ProyectoTaller.Properties.Resources.UsuarioGrande;
            this.PBImagenUsuarios.Location = new System.Drawing.Point(12, 12);
            this.PBImagenUsuarios.Name = "PBImagenUsuarios";
            this.PBImagenUsuarios.Size = new System.Drawing.Size(65, 67);
            this.PBImagenUsuarios.TabIndex = 30;
            this.PBImagenUsuarios.TabStop = false;
            // 
            // LTituloUsuarios
            // 
            this.LTituloUsuarios.AutoSize = true;
            this.LTituloUsuarios.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloUsuarios.Location = new System.Drawing.Point(79, 14);
            this.LTituloUsuarios.Name = "LTituloUsuarios";
            this.LTituloUsuarios.Size = new System.Drawing.Size(247, 36);
            this.LTituloUsuarios.TabIndex = 31;
            this.LTituloUsuarios.Text = "Gestion Usuarios";
            // 
            // CBPuesto
            // 
            this.CBPuesto.FormattingEnabled = true;
            this.CBPuesto.Items.AddRange(new object[] {
            "Gerente",
            "Vendedor"});
            this.CBPuesto.Location = new System.Drawing.Point(175, 72);
            this.CBPuesto.Name = "CBPuesto";
            this.CBPuesto.Size = new System.Drawing.Size(205, 21);
            this.CBPuesto.TabIndex = 90;
            this.CBPuesto.Text = "Seleccione el puesto";
            // 
            // TEmail
            // 
            this.TEmail.Location = new System.Drawing.Point(489, 117);
            this.TEmail.Name = "TEmail";
            this.TEmail.Size = new System.Drawing.Size(205, 20);
            this.TEmail.TabIndex = 84;
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEmail.Location = new System.Drawing.Point(408, 120);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(43, 17);
            this.LEmail.TabIndex = 83;
            this.LEmail.Text = "Email";
            // 
            // TTelefono
            // 
            this.TTelefono.Location = new System.Drawing.Point(489, 73);
            this.TTelefono.Name = "TTelefono";
            this.TTelefono.Size = new System.Drawing.Size(205, 20);
            this.TTelefono.TabIndex = 81;
            // 
            // LValiEmail
            // 
            this.LValiEmail.AutoSize = true;
            this.LValiEmail.ForeColor = System.Drawing.Color.Red;
            this.LValiEmail.Location = new System.Drawing.Point(491, 138);
            this.LValiEmail.Name = "LValiEmail";
            this.LValiEmail.Size = new System.Drawing.Size(0, 13);
            this.LValiEmail.TabIndex = 76;
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellido.Location = new System.Drawing.Point(94, 205);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(61, 17);
            this.LApellido.TabIndex = 74;
            this.LApellido.Text = "Apellido";
            // 
            // LValiTelefono
            // 
            this.LValiTelefono.AutoSize = true;
            this.LValiTelefono.ForeColor = System.Drawing.Color.Red;
            this.LValiTelefono.Location = new System.Drawing.Point(489, 95);
            this.LValiTelefono.Name = "LValiTelefono";
            this.LValiTelefono.Size = new System.Drawing.Size(0, 13);
            this.LValiTelefono.TabIndex = 72;
            // 
            // LValiPuesto
            // 
            this.LValiPuesto.AutoSize = true;
            this.LValiPuesto.ForeColor = System.Drawing.Color.Red;
            this.LValiPuesto.Location = new System.Drawing.Point(175, 96);
            this.LValiPuesto.Name = "LValiPuesto";
            this.LValiPuesto.Size = new System.Drawing.Size(0, 13);
            this.LValiPuesto.TabIndex = 71;
            // 
            // LValiNombre
            // 
            this.LValiNombre.AutoSize = true;
            this.LValiNombre.ForeColor = System.Drawing.Color.Red;
            this.LValiNombre.Location = new System.Drawing.Point(175, 184);
            this.LValiNombre.Name = "LValiNombre";
            this.LValiNombre.Size = new System.Drawing.Size(0, 13);
            this.LValiNombre.TabIndex = 70;
            // 
            // LValiDni
            // 
            this.LValiDni.AutoSize = true;
            this.LValiDni.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.LValiDni.ForeColor = System.Drawing.Color.Red;
            this.LValiDni.Location = new System.Drawing.Point(175, 140);
            this.LValiDni.Name = "LValiDni";
            this.LValiDni.Size = new System.Drawing.Size(0, 13);
            this.LValiDni.TabIndex = 69;
            // 
            // TApellido
            // 
            this.TApellido.Location = new System.Drawing.Point(175, 204);
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(205, 20);
            this.TApellido.TabIndex = 66;
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(175, 161);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(205, 20);
            this.TNombre.TabIndex = 65;
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTelefono.Location = new System.Drawing.Point(408, 76);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(81, 17);
            this.LTelefono.TabIndex = 64;
            this.LTelefono.Text = "N° Teléfono";
            // 
            // LPuesto
            // 
            this.LPuesto.AutoSize = true;
            this.LPuesto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPuesto.Location = new System.Drawing.Point(94, 76);
            this.LPuesto.Name = "LPuesto";
            this.LPuesto.Size = new System.Drawing.Size(51, 17);
            this.LPuesto.TabIndex = 63;
            this.LPuesto.Text = "Puesto";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.Location = new System.Drawing.Point(94, 164);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(61, 17);
            this.LNombre.TabIndex = 62;
            this.LNombre.Text = "Nombre";
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDni.Location = new System.Drawing.Point(94, 120);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(31, 17);
            this.LDni.TabIndex = 61;
            this.LDni.Text = "DNI";
            // 
            // TDni
            // 
            this.TDni.Location = new System.Drawing.Point(175, 117);
            this.TDni.Name = "TDni";
            this.TDni.Size = new System.Drawing.Size(205, 20);
            this.TDni.TabIndex = 60;
            // 
            // LValiApellido
            // 
            this.LValiApellido.AutoSize = true;
            this.LValiApellido.ForeColor = System.Drawing.Color.Red;
            this.LValiApellido.Location = new System.Drawing.Point(175, 227);
            this.LValiApellido.Name = "LValiApellido";
            this.LValiApellido.Size = new System.Drawing.Size(0, 13);
            this.LValiApellido.TabIndex = 91;
            // 
            // BAgregar
            // 
            this.BAgregar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAgregar.Image = global::ProyectoTaller.Properties.Resources.GuardarProducto;
            this.BAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BAgregar.Location = new System.Drawing.Point(732, 99);
            this.BAgregar.Name = "BAgregar";
            this.BAgregar.Size = new System.Drawing.Size(123, 52);
            this.BAgregar.TabIndex = 92;
            this.BAgregar.Text = "Agregar    ";
            this.BAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BAgregar.UseVisualStyleBackColor = true;
            this.BAgregar.Click += new System.EventHandler(this.BAgregar_Click);
            // 
            // BEliminar
            // 
            this.BEliminar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BEliminar.FlatAppearance.BorderSize = 0;
            this.BEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BEliminar.Image = global::ProyectoTaller.Properties.Resources.Borrar;
            this.BEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BEliminar.Location = new System.Drawing.Point(732, 215);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(123, 52);
            this.BEliminar.TabIndex = 93;
            this.BEliminar.Text = "Eliminar";
            this.BEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BEliminar.UseVisualStyleBackColor = true;
            // 
            // DGUsuarios
            // 
            this.DGUsuarios.AllowUserToAddRows = false;
            this.DGUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CPuesto,
            this.CDni,
            this.CNombre,
            this.CApellido,
            this.CTelefono,
            this.CEmail,
            this.CSexo,
            this.CSueldo});
            this.DGUsuarios.Location = new System.Drawing.Point(12, 280);
            this.DGUsuarios.Name = "DGUsuarios";
            this.DGUsuarios.Size = new System.Drawing.Size(863, 215);
            this.DGUsuarios.TabIndex = 94;
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
            this.BBorrar.Location = new System.Drawing.Point(732, 41);
            this.BBorrar.Name = "BBorrar";
            this.BBorrar.Size = new System.Drawing.Size(123, 52);
            this.BBorrar.TabIndex = 95;
            this.BBorrar.Text = "Borrar Todo";
            this.BBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BBorrar.UseVisualStyleBackColor = true;
            // 
            // LSexo
            // 
            this.LSexo.AutoSize = true;
            this.LSexo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSexo.Location = new System.Drawing.Point(408, 164);
            this.LSexo.Name = "LSexo";
            this.LSexo.Size = new System.Drawing.Size(37, 17);
            this.LSexo.TabIndex = 97;
            this.LSexo.Text = "Sexo";
            // 
            // LValiSexo
            // 
            this.LValiSexo.AutoSize = true;
            this.LValiSexo.ForeColor = System.Drawing.Color.Red;
            this.LValiSexo.Location = new System.Drawing.Point(491, 184);
            this.LValiSexo.Name = "LValiSexo";
            this.LValiSexo.Size = new System.Drawing.Size(0, 13);
            this.LValiSexo.TabIndex = 96;
            // 
            // TSueldo
            // 
            this.TSueldo.Location = new System.Drawing.Point(489, 205);
            this.TSueldo.Name = "TSueldo";
            this.TSueldo.Size = new System.Drawing.Size(205, 20);
            this.TSueldo.TabIndex = 101;
            // 
            // LSueldo
            // 
            this.LSueldo.AutoSize = true;
            this.LSueldo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSueldo.Location = new System.Drawing.Point(408, 205);
            this.LSueldo.Name = "LSueldo";
            this.LSueldo.Size = new System.Drawing.Size(51, 17);
            this.LSueldo.TabIndex = 100;
            this.LSueldo.Text = "Sueldo";
            // 
            // LValiSueldo
            // 
            this.LValiSueldo.AutoSize = true;
            this.LValiSueldo.ForeColor = System.Drawing.Color.Red;
            this.LValiSueldo.Location = new System.Drawing.Point(491, 226);
            this.LValiSueldo.Name = "LValiSueldo";
            this.LValiSueldo.Size = new System.Drawing.Size(0, 13);
            this.LValiSueldo.TabIndex = 99;
            // 
            // CBSexo
            // 
            this.CBSexo.FormattingEnabled = true;
            this.CBSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.CBSexo.Location = new System.Drawing.Point(489, 160);
            this.CBSexo.Name = "CBSexo";
            this.CBSexo.Size = new System.Drawing.Size(205, 21);
            this.CBSexo.TabIndex = 102;
            this.CBSexo.Text = "Seleccione el sexo";
            // 
            // TBuscarUsuarios
            // 
            this.TBuscarUsuarios.Location = new System.Drawing.Point(157, 256);
            this.TBuscarUsuarios.Name = "TBuscarUsuarios";
            this.TBuscarUsuarios.Size = new System.Drawing.Size(277, 20);
            this.TBuscarUsuarios.TabIndex = 103;
            // 
            // LBuscarUsuario
            // 
            this.LBuscarUsuario.AutoSize = true;
            this.LBuscarUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBuscarUsuario.Location = new System.Drawing.Point(10, 253);
            this.LBuscarUsuario.Name = "LBuscarUsuario";
            this.LBuscarUsuario.Size = new System.Drawing.Size(144, 23);
            this.LBuscarUsuario.TabIndex = 104;
            this.LBuscarUsuario.Text = "Buscar Usuario";
            // 
            // CBGerente
            // 
            this.CBGerente.AutoSize = true;
            this.CBGerente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBGerente.Location = new System.Drawing.Point(443, 257);
            this.CBGerente.Name = "CBGerente";
            this.CBGerente.Size = new System.Drawing.Size(70, 19);
            this.CBGerente.TabIndex = 105;
            this.CBGerente.Text = "Gerente";
            this.CBGerente.UseVisualStyleBackColor = true;
            // 
            // CBVendedor
            // 
            this.CBVendedor.AutoSize = true;
            this.CBVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBVendedor.Location = new System.Drawing.Point(519, 257);
            this.CBVendedor.Name = "CBVendedor";
            this.CBVendedor.Size = new System.Drawing.Size(79, 19);
            this.CBVendedor.TabIndex = 106;
            this.CBVendedor.Text = "Vendedor";
            this.CBVendedor.UseVisualStyleBackColor = true;
            // 
            // CBAdministrador
            // 
            this.CBAdministrador.AutoSize = true;
            this.CBAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBAdministrador.Location = new System.Drawing.Point(604, 257);
            this.CBAdministrador.Name = "CBAdministrador";
            this.CBAdministrador.Size = new System.Drawing.Size(64, 19);
            this.CBAdministrador.TabIndex = 107;
            this.CBAdministrador.Text = "Admin.";
            this.CBAdministrador.UseVisualStyleBackColor = true;
            // 
            // BEditar
            // 
            this.BEditar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEditar.Image = global::ProyectoTaller.Properties.Resources.editar2;
            this.BEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BEditar.Location = new System.Drawing.Point(732, 157);
            this.BEditar.Name = "BEditar";
            this.BEditar.Size = new System.Drawing.Size(123, 52);
            this.BEditar.TabIndex = 108;
            this.BEditar.Text = "Editar    ";
            this.BEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BEditar.UseVisualStyleBackColor = true;
            this.BEditar.Click += new System.EventHandler(this.BEditar_Click);
            // 
            // LValido
            // 
            this.LValido.AutoSize = true;
            this.LValido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LValido.ForeColor = System.Drawing.Color.Green;
            this.LValido.Location = new System.Drawing.Point(307, 48);
            this.LValido.Name = "LValido";
            this.LValido.Size = new System.Drawing.Size(0, 21);
            this.LValido.TabIndex = 109;
            // 
            // CPuesto
            // 
            this.CPuesto.HeaderText = "Puesto";
            this.CPuesto.Name = "CPuesto";
            // 
            // CDni
            // 
            this.CDni.HeaderText = "DNI";
            this.CDni.Name = "CDni";
            this.CDni.Width = 150;
            // 
            // CNombre
            // 
            this.CNombre.HeaderText = "Nombre";
            this.CNombre.Name = "CNombre";
            this.CNombre.Width = 130;
            // 
            // CApellido
            // 
            this.CApellido.HeaderText = "Apellido";
            this.CApellido.Name = "CApellido";
            this.CApellido.Width = 130;
            // 
            // CTelefono
            // 
            this.CTelefono.HeaderText = "Telefono";
            this.CTelefono.Name = "CTelefono";
            this.CTelefono.Width = 80;
            // 
            // CEmail
            // 
            this.CEmail.HeaderText = "Email";
            this.CEmail.Name = "CEmail";
            this.CEmail.Width = 140;
            // 
            // CSexo
            // 
            this.CSexo.HeaderText = "Sexo";
            this.CSexo.Name = "CSexo";
            // 
            // CSueldo
            // 
            this.CSueldo.HeaderText = "Sueldo";
            this.CSueldo.Name = "CSueldo";
            // 
            // GestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(887, 507);
            this.Controls.Add(this.LValido);
            this.Controls.Add(this.BEditar);
            this.Controls.Add(this.CBAdministrador);
            this.Controls.Add(this.CBVendedor);
            this.Controls.Add(this.CBGerente);
            this.Controls.Add(this.LBuscarUsuario);
            this.Controls.Add(this.TBuscarUsuarios);
            this.Controls.Add(this.CBSexo);
            this.Controls.Add(this.TSueldo);
            this.Controls.Add(this.LSueldo);
            this.Controls.Add(this.LValiSueldo);
            this.Controls.Add(this.LSexo);
            this.Controls.Add(this.LValiSexo);
            this.Controls.Add(this.BBorrar);
            this.Controls.Add(this.DGUsuarios);
            this.Controls.Add(this.BEliminar);
            this.Controls.Add(this.BAgregar);
            this.Controls.Add(this.LValiApellido);
            this.Controls.Add(this.CBPuesto);
            this.Controls.Add(this.TEmail);
            this.Controls.Add(this.LEmail);
            this.Controls.Add(this.TTelefono);
            this.Controls.Add(this.LValiEmail);
            this.Controls.Add(this.LApellido);
            this.Controls.Add(this.LValiTelefono);
            this.Controls.Add(this.LValiPuesto);
            this.Controls.Add(this.LValiNombre);
            this.Controls.Add(this.LValiDni);
            this.Controls.Add(this.TApellido);
            this.Controls.Add(this.TNombre);
            this.Controls.Add(this.LTelefono);
            this.Controls.Add(this.LPuesto);
            this.Controls.Add(this.LNombre);
            this.Controls.Add(this.LDni);
            this.Controls.Add(this.TDni);
            this.Controls.Add(this.LTituloUsuarios);
            this.Controls.Add(this.PBImagenUsuarios);
            this.Name = "GestionUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBImagenUsuarios;
        private System.Windows.Forms.Label LTituloUsuarios;
        private System.Windows.Forms.ComboBox CBPuesto;
        private System.Windows.Forms.TextBox TEmail;
        private System.Windows.Forms.Label LEmail;
        private System.Windows.Forms.TextBox TTelefono;
        private System.Windows.Forms.Label LValiEmail;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LValiTelefono;
        private System.Windows.Forms.Label LValiPuesto;
        private System.Windows.Forms.Label LValiNombre;
        private System.Windows.Forms.Label LValiDni;
        private System.Windows.Forms.TextBox TApellido;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.Label LTelefono;
        private System.Windows.Forms.Label LPuesto;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.TextBox TDni;
        private System.Windows.Forms.Label LValiApellido;
        private System.Windows.Forms.Button BAgregar;
        private System.Windows.Forms.Button BEliminar;
        private System.Windows.Forms.DataGridView DGUsuarios;
        private System.Windows.Forms.Button BBorrar;
        private System.Windows.Forms.Label LSexo;
        private System.Windows.Forms.Label LValiSexo;
        private System.Windows.Forms.TextBox TSueldo;
        private System.Windows.Forms.Label LSueldo;
        private System.Windows.Forms.Label LValiSueldo;
        private System.Windows.Forms.ComboBox CBSexo;
        private System.Windows.Forms.TextBox TBuscarUsuarios;
        private System.Windows.Forms.Label LBuscarUsuario;
        private System.Windows.Forms.CheckBox CBGerente;
        private System.Windows.Forms.CheckBox CBVendedor;
        private System.Windows.Forms.CheckBox CBAdministrador;
        private System.Windows.Forms.Button BEditar;
        private System.Windows.Forms.Label LValido;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSueldo;
    }
}