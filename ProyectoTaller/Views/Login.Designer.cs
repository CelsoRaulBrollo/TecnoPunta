namespace ProyectoTaller
{
    partial class FormularioInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PBImagenLogin = new System.Windows.Forms.PictureBox();
            this.LTitulo = new System.Windows.Forms.Label();
            this.LSubtitulo = new System.Windows.Forms.Label();
            this.LBienvenido = new System.Windows.Forms.Label();
            this.LDatos = new System.Windows.Forms.Label();
            this.LUsuario = new System.Windows.Forms.Label();
            this.LContraseña = new System.Windows.Forms.Label();
            this.TUsuario = new System.Windows.Forms.TextBox();
            this.TContraseña = new System.Windows.Forms.TextBox();
            this.BInicioSesion = new System.Windows.Forms.Button();
            this.BSalir = new System.Windows.Forms.Button();
            this.LSub = new System.Windows.Forms.Label();
            this.LValidaciones = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // PBImagenLogin
            // 
            this.PBImagenLogin.Image = global::ProyectoTaller.Properties.Resources.Weekend_Reading_06292017;
            this.PBImagenLogin.Location = new System.Drawing.Point(-1, -3);
            this.PBImagenLogin.Name = "PBImagenLogin";
            this.PBImagenLogin.Size = new System.Drawing.Size(414, 516);
            this.PBImagenLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBImagenLogin.TabIndex = 1;
            this.PBImagenLogin.TabStop = false;
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.Font = new System.Drawing.Font("Century Gothic", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.Location = new System.Drawing.Point(480, 39);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(213, 39);
            this.LTitulo.TabIndex = 2;
            this.LTitulo.Text = "Tecno Punta";
            // 
            // LSubtitulo
            // 
            this.LSubtitulo.AutoSize = true;
            this.LSubtitulo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSubtitulo.Location = new System.Drawing.Point(565, 78);
            this.LSubtitulo.Name = "LSubtitulo";
            this.LSubtitulo.Size = new System.Drawing.Size(118, 17);
            this.LSubtitulo.TabIndex = 3;
            this.LSubtitulo.Text = "Sistema de ventas";
            // 
            // LBienvenido
            // 
            this.LBienvenido.AutoSize = true;
            this.LBienvenido.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBienvenido.Location = new System.Drawing.Point(448, 177);
            this.LBienvenido.Name = "LBienvenido";
            this.LBienvenido.Size = new System.Drawing.Size(147, 27);
            this.LBienvenido.TabIndex = 4;
            this.LBienvenido.Text = "Bienvenido!";
            // 
            // LDatos
            // 
            this.LDatos.AutoSize = true;
            this.LDatos.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDatos.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.LDatos.Location = new System.Drawing.Point(459, 204);
            this.LDatos.Name = "LDatos";
            this.LDatos.Size = new System.Drawing.Size(97, 16);
            this.LDatos.TabIndex = 5;
            this.LDatos.Text = "Ingrese sus datos";
            // 
            // LUsuario
            // 
            this.LUsuario.AutoSize = true;
            this.LUsuario.Location = new System.Drawing.Point(449, 236);
            this.LUsuario.Name = "LUsuario";
            this.LUsuario.Size = new System.Drawing.Size(158, 21);
            this.LUsuario.TabIndex = 6;
            this.LUsuario.Text = "Nombre de Usuario";
            // 
            // LContraseña
            // 
            this.LContraseña.AutoSize = true;
            this.LContraseña.Location = new System.Drawing.Point(449, 312);
            this.LContraseña.Name = "LContraseña";
            this.LContraseña.Size = new System.Drawing.Size(103, 21);
            this.LContraseña.TabIndex = 7;
            this.LContraseña.Text = "Contraseña";
            // 
            // TUsuario
            // 
            this.TUsuario.Location = new System.Drawing.Point(453, 260);
            this.TUsuario.Name = "TUsuario";
            this.TUsuario.Size = new System.Drawing.Size(272, 27);
            this.TUsuario.TabIndex = 8;
            this.TUsuario.TextChanged += new System.EventHandler(this.TUsuario_TextChanged);
            // 
            // TContraseña
            // 
            this.TContraseña.Location = new System.Drawing.Point(453, 336);
            this.TContraseña.MaxLength = 20;
            this.TContraseña.Name = "TContraseña";
            this.TContraseña.Size = new System.Drawing.Size(272, 27);
            this.TContraseña.TabIndex = 7;
            this.TContraseña.UseSystemPasswordChar = true;
            this.TContraseña.TextChanged += new System.EventHandler(this.TContraseña_TextChanged);
            // 
            // BInicioSesion
            // 
            this.BInicioSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(190)))), ((int)(((byte)(37)))));
            this.BInicioSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BInicioSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BInicioSesion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BInicioSesion.FlatAppearance.BorderSize = 0;
            this.BInicioSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BInicioSesion.Location = new System.Drawing.Point(502, 408);
            this.BInicioSesion.Name = "BInicioSesion";
            this.BInicioSesion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BInicioSesion.Size = new System.Drawing.Size(172, 31);
            this.BInicioSesion.TabIndex = 16;
            this.BInicioSesion.Text = "Iniciar Sesion";
            this.BInicioSesion.UseVisualStyleBackColor = false;
            this.BInicioSesion.Click += new System.EventHandler(this.BInicioSesion_Click);
            // 
            // BSalir
            // 
            this.BSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(24)))), ((int)(((byte)(86)))));
            this.BSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BSalir.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BSalir.FlatAppearance.BorderSize = 0;
            this.BSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BSalir.Location = new System.Drawing.Point(667, 471);
            this.BSalir.Name = "BSalir";
            this.BSalir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BSalir.Size = new System.Drawing.Size(74, 28);
            this.BSalir.TabIndex = 17;
            this.BSalir.Text = "Salir";
            this.BSalir.UseVisualStyleBackColor = false;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // LSub
            // 
            this.LSub.AutoSize = true;
            this.LSub.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.LSub.Location = new System.Drawing.Point(419, 487);
            this.LSub.Name = "LSub";
            this.LSub.Size = new System.Drawing.Size(119, 15);
            this.LSub.TabIndex = 18;
            this.LSub.Text = "© 2024 Brollo | Capay";
            // 
            // LValidaciones
            // 
            this.LValidaciones.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LValidaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LValidaciones.Enabled = false;
            this.LValidaciones.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.LValidaciones.ForeColor = System.Drawing.Color.Firebrick;
            this.LValidaciones.Location = new System.Drawing.Point(435, 371);
            this.LValidaciones.Multiline = true;
            this.LValidaciones.Name = "LValidaciones";
            this.LValidaciones.ReadOnly = true;
            this.LValidaciones.Size = new System.Drawing.Size(306, 31);
            this.LValidaciones.TabIndex = 19;
            this.LValidaciones.TabStop = false;
            this.LValidaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormularioInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(753, 511);
            this.Controls.Add(this.LValidaciones);
            this.Controls.Add(this.LSub);
            this.Controls.Add(this.BSalir);
            this.Controls.Add(this.BInicioSesion);
            this.Controls.Add(this.TContraseña);
            this.Controls.Add(this.TUsuario);
            this.Controls.Add(this.LContraseña);
            this.Controls.Add(this.LUsuario);
            this.Controls.Add(this.LDatos);
            this.Controls.Add(this.LBienvenido);
            this.Controls.Add(this.LSubtitulo);
            this.Controls.Add(this.LTitulo);
            this.Controls.Add(this.PBImagenLogin);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormularioInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio Sesión";
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBImagenLogin;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Label LSubtitulo;
        private System.Windows.Forms.Label LBienvenido;
        private System.Windows.Forms.Label LDatos;
        private System.Windows.Forms.Label LUsuario;
        private System.Windows.Forms.Label LContraseña;
        private System.Windows.Forms.TextBox TUsuario;
        private System.Windows.Forms.TextBox TContraseña;
        private System.Windows.Forms.Button BInicioSesion;
        private System.Windows.Forms.Button BSalir;
        private System.Windows.Forms.Label LSub;
        private System.Windows.Forms.TextBox LValidaciones;
    }
}

