namespace ProyectoTaller.Views.Gerentes
{
    partial class GestionarContraseñas
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
            this.LTituloContraseñas = new System.Windows.Forms.Label();
            this.PBImagenContraseñas = new System.Windows.Forms.PictureBox();
            this.DGUsuarios = new System.Windows.Forms.DataGridView();
            this.CPuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CContraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LBuscarUsuario = new System.Windows.Forms.Label();
            this.TBuscarUsuarios = new System.Windows.Forms.TextBox();
            this.CBActiva = new System.Windows.Forms.CheckBox();
            this.CBInactiva = new System.Windows.Forms.CheckBox();
            this.LContraseñaEstado = new System.Windows.Forms.Label();
            this.LEscribirContraseña = new System.Windows.Forms.Label();
            this.TContraseña1 = new System.Windows.Forms.TextBox();
            this.TContraseña2 = new System.Windows.Forms.TextBox();
            this.LContraseña1 = new System.Windows.Forms.Label();
            this.LContraseña2 = new System.Windows.Forms.Label();
            this.LUsuarioActivo = new System.Windows.Forms.Label();
            this.LUsuario = new System.Windows.Forms.Label();
            this.BBorrar = new System.Windows.Forms.Button();
            this.BEditar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenContraseñas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // LTituloContraseñas
            // 
            this.LTituloContraseñas.AutoSize = true;
            this.LTituloContraseñas.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloContraseñas.Location = new System.Drawing.Point(80, 13);
            this.LTituloContraseñas.Name = "LTituloContraseñas";
            this.LTituloContraseñas.Size = new System.Drawing.Size(336, 36);
            this.LTituloContraseñas.TabIndex = 31;
            this.LTituloContraseñas.Text = "Gestionar Contraseñas";
            // 
            // PBImagenContraseñas
            // 
            this.PBImagenContraseñas.Image = global::ProyectoTaller.Properties.Resources.Contraseñas64;
            this.PBImagenContraseñas.Location = new System.Drawing.Point(12, 12);
            this.PBImagenContraseñas.Name = "PBImagenContraseñas";
            this.PBImagenContraseñas.Size = new System.Drawing.Size(65, 67);
            this.PBImagenContraseñas.TabIndex = 30;
            this.PBImagenContraseñas.TabStop = false;
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
            this.CSueldo,
            this.CContraseña});
            this.DGUsuarios.Location = new System.Drawing.Point(12, 280);
            this.DGUsuarios.Name = "DGUsuarios";
            this.DGUsuarios.Size = new System.Drawing.Size(863, 215);
            this.DGUsuarios.TabIndex = 95;
            // 
            // CPuesto
            // 
            this.CPuesto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CPuesto.HeaderText = "Puesto";
            this.CPuesto.Name = "CPuesto";
            // 
            // CDni
            // 
            this.CDni.HeaderText = "DNI";
            this.CDni.Name = "CDni";
            this.CDni.Width = 120;
            // 
            // CNombre
            // 
            this.CNombre.HeaderText = "Nombre";
            this.CNombre.Name = "CNombre";
            this.CNombre.Width = 150;
            // 
            // CApellido
            // 
            this.CApellido.HeaderText = "Apellido";
            this.CApellido.Name = "CApellido";
            this.CApellido.Width = 150;
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
            // CContraseña
            // 
            this.CContraseña.HeaderText = "Contraseña Activa";
            this.CContraseña.Name = "CContraseña";
            // 
            // LBuscarUsuario
            // 
            this.LBuscarUsuario.AutoSize = true;
            this.LBuscarUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBuscarUsuario.Location = new System.Drawing.Point(13, 251);
            this.LBuscarUsuario.Name = "LBuscarUsuario";
            this.LBuscarUsuario.Size = new System.Drawing.Size(144, 23);
            this.LBuscarUsuario.TabIndex = 106;
            this.LBuscarUsuario.Text = "Buscar Usuario";
            // 
            // TBuscarUsuarios
            // 
            this.TBuscarUsuarios.Location = new System.Drawing.Point(160, 254);
            this.TBuscarUsuarios.Name = "TBuscarUsuarios";
            this.TBuscarUsuarios.Size = new System.Drawing.Size(277, 20);
            this.TBuscarUsuarios.TabIndex = 105;
            // 
            // CBActiva
            // 
            this.CBActiva.AutoSize = true;
            this.CBActiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBActiva.Location = new System.Drawing.Point(675, 254);
            this.CBActiva.Name = "CBActiva";
            this.CBActiva.Size = new System.Drawing.Size(57, 19);
            this.CBActiva.TabIndex = 109;
            this.CBActiva.Text = "Activa";
            this.CBActiva.UseVisualStyleBackColor = true;
            // 
            // CBInactiva
            // 
            this.CBInactiva.AutoSize = true;
            this.CBInactiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBInactiva.Location = new System.Drawing.Point(742, 255);
            this.CBInactiva.Name = "CBInactiva";
            this.CBInactiva.Size = new System.Drawing.Size(67, 19);
            this.CBInactiva.TabIndex = 110;
            this.CBInactiva.Text = "Inactiva";
            this.CBInactiva.UseVisualStyleBackColor = true;
            // 
            // LContraseñaEstado
            // 
            this.LContraseñaEstado.AutoSize = true;
            this.LContraseñaEstado.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LContraseñaEstado.Location = new System.Drawing.Point(485, 251);
            this.LContraseñaEstado.Name = "LContraseñaEstado";
            this.LContraseñaEstado.Size = new System.Drawing.Size(184, 23);
            this.LContraseñaEstado.TabIndex = 111;
            this.LContraseñaEstado.Text = "Estado Contraseña";
            // 
            // LEscribirContraseña
            // 
            this.LEscribirContraseña.AutoSize = true;
            this.LEscribirContraseña.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEscribirContraseña.Location = new System.Drawing.Point(388, 56);
            this.LEscribirContraseña.Name = "LEscribirContraseña";
            this.LEscribirContraseña.Size = new System.Drawing.Size(117, 23);
            this.LEscribirContraseña.TabIndex = 112;
            this.LEscribirContraseña.Text = "Contraseña";
            // 
            // TContraseña1
            // 
            this.TContraseña1.Location = new System.Drawing.Point(407, 125);
            this.TContraseña1.Name = "TContraseña1";
            this.TContraseña1.Size = new System.Drawing.Size(205, 20);
            this.TContraseña1.TabIndex = 113;
            // 
            // TContraseña2
            // 
            this.TContraseña2.Location = new System.Drawing.Point(407, 163);
            this.TContraseña2.Name = "TContraseña2";
            this.TContraseña2.Size = new System.Drawing.Size(205, 20);
            this.TContraseña2.TabIndex = 114;
            // 
            // LContraseña1
            // 
            this.LContraseña1.AutoSize = true;
            this.LContraseña1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LContraseña1.Location = new System.Drawing.Point(256, 128);
            this.LContraseña1.Name = "LContraseña1";
            this.LContraseña1.Size = new System.Drawing.Size(145, 17);
            this.LContraseña1.TabIndex = 115;
            this.LContraseña1.Text = "Escribe la contraseña";
            // 
            // LContraseña2
            // 
            this.LContraseña2.AutoSize = true;
            this.LContraseña2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LContraseña2.Location = new System.Drawing.Point(256, 166);
            this.LContraseña2.Name = "LContraseña2";
            this.LContraseña2.Size = new System.Drawing.Size(142, 17);
            this.LContraseña2.TabIndex = 116;
            this.LContraseña2.Text = "Repite la contraseña";
            // 
            // LUsuarioActivo
            // 
            this.LUsuarioActivo.AutoSize = true;
            this.LUsuarioActivo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUsuarioActivo.Location = new System.Drawing.Point(414, 85);
            this.LUsuarioActivo.Name = "LUsuarioActivo";
            this.LUsuarioActivo.Size = new System.Drawing.Size(69, 19);
            this.LUsuarioActivo.TabIndex = 117;
            this.LUsuarioActivo.Text = "Usuario:";
            // 
            // LUsuario
            // 
            this.LUsuario.AutoSize = true;
            this.LUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUsuario.ForeColor = System.Drawing.Color.SeaGreen;
            this.LUsuario.Location = new System.Drawing.Point(488, 87);
            this.LUsuario.Name = "LUsuario";
            this.LUsuario.Size = new System.Drawing.Size(0, 18);
            this.LUsuario.TabIndex = 118;
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
            this.BBorrar.Location = new System.Drawing.Point(686, 56);
            this.BBorrar.Name = "BBorrar";
            this.BBorrar.Size = new System.Drawing.Size(123, 52);
            this.BBorrar.TabIndex = 119;
            this.BBorrar.Text = "Borrar Clave";
            this.BBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BBorrar.UseVisualStyleBackColor = true;
            // 
            // BEditar
            // 
            this.BEditar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEditar.Image = global::ProyectoTaller.Properties.Resources.Seleccionar;
            this.BEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BEditar.Location = new System.Drawing.Point(686, 116);
            this.BEditar.Name = "BEditar";
            this.BEditar.Size = new System.Drawing.Size(123, 52);
            this.BEditar.TabIndex = 120;
            this.BEditar.Text = "Editar      ";
            this.BEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BEditar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::ProyectoTaller.Properties.Resources.GuardarProducto;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(686, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 52);
            this.button1.TabIndex = 121;
            this.button1.Text = "Agregar ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // GestionarContraseñas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(887, 507);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BEditar);
            this.Controls.Add(this.BBorrar);
            this.Controls.Add(this.LUsuario);
            this.Controls.Add(this.LUsuarioActivo);
            this.Controls.Add(this.LContraseña2);
            this.Controls.Add(this.LContraseña1);
            this.Controls.Add(this.TContraseña2);
            this.Controls.Add(this.TContraseña1);
            this.Controls.Add(this.LEscribirContraseña);
            this.Controls.Add(this.LContraseñaEstado);
            this.Controls.Add(this.CBInactiva);
            this.Controls.Add(this.CBActiva);
            this.Controls.Add(this.LBuscarUsuario);
            this.Controls.Add(this.TBuscarUsuarios);
            this.Controls.Add(this.DGUsuarios);
            this.Controls.Add(this.LTituloContraseñas);
            this.Controls.Add(this.PBImagenContraseñas);
            this.Name = "GestionarContraseñas";
            this.Text = "GestionarContraseñas";
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenContraseñas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBImagenContraseñas;
        private System.Windows.Forms.Label LTituloContraseñas;
        private System.Windows.Forms.DataGridView DGUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSueldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CContraseña;
        private System.Windows.Forms.Label LBuscarUsuario;
        private System.Windows.Forms.TextBox TBuscarUsuarios;
        private System.Windows.Forms.CheckBox CBActiva;
        private System.Windows.Forms.CheckBox CBInactiva;
        private System.Windows.Forms.Label LContraseñaEstado;
        private System.Windows.Forms.Label LEscribirContraseña;
        private System.Windows.Forms.TextBox TContraseña1;
        private System.Windows.Forms.TextBox TContraseña2;
        private System.Windows.Forms.Label LContraseña1;
        private System.Windows.Forms.Label LContraseña2;
        private System.Windows.Forms.Label LUsuarioActivo;
        private System.Windows.Forms.Label LUsuario;
        private System.Windows.Forms.Button BBorrar;
        private System.Windows.Forms.Button BEditar;
        private System.Windows.Forms.Button button1;
    }
}