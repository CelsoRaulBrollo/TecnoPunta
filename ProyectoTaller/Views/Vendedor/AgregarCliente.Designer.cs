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
            this.LValiStock = new System.Windows.Forms.Label();
            this.LValiPrecio = new System.Windows.Forms.Label();
            this.LValiNombre = new System.Windows.Forms.Label();
            this.TCorreoCliente = new System.Windows.Forms.TextBox();
            this.TDNICliente = new System.Windows.Forms.TextBox();
            this.LCorreoCliente = new System.Windows.Forms.Label();
            this.LDni = new System.Windows.Forms.Label();
            this.LNombreCliente = new System.Windows.Forms.Label();
            this.TNombreCliente = new System.Windows.Forms.TextBox();
            this.LTituloCliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TApellidosCliente = new System.Windows.Forms.TextBox();
            this.LApellidoCliente = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TTelefonoCliente = new System.Windows.Forms.TextBox();
            this.LTelefonoCliente = new System.Windows.Forms.Label();
            this.LDatosClientes = new System.Windows.Forms.Label();
            this.PBImagenCliente = new System.Windows.Forms.PictureBox();
            this.BBorrar = new System.Windows.Forms.Button();
            this.BAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // LValido
            // 
            this.LValido.AutoSize = true;
            this.LValido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LValido.ForeColor = System.Drawing.Color.Green;
            this.LValido.Location = new System.Drawing.Point(243, 40);
            this.LValido.Name = "LValido";
            this.LValido.Size = new System.Drawing.Size(0, 21);
            this.LValido.TabIndex = 55;
            // 
            // LValiStock
            // 
            this.LValiStock.AutoSize = true;
            this.LValiStock.ForeColor = System.Drawing.Color.Red;
            this.LValiStock.Location = new System.Drawing.Point(525, 242);
            this.LValiStock.Name = "LValiStock";
            this.LValiStock.Size = new System.Drawing.Size(0, 13);
            this.LValiStock.TabIndex = 53;
            // 
            // LValiPrecio
            // 
            this.LValiPrecio.AutoSize = true;
            this.LValiPrecio.ForeColor = System.Drawing.Color.Red;
            this.LValiPrecio.Location = new System.Drawing.Point(207, 238);
            this.LValiPrecio.Name = "LValiPrecio";
            this.LValiPrecio.Size = new System.Drawing.Size(0, 13);
            this.LValiPrecio.TabIndex = 51;
            // 
            // LValiNombre
            // 
            this.LValiNombre.AutoSize = true;
            this.LValiNombre.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.LValiNombre.ForeColor = System.Drawing.Color.Red;
            this.LValiNombre.Location = new System.Drawing.Point(207, 200);
            this.LValiNombre.Name = "LValiNombre";
            this.LValiNombre.Size = new System.Drawing.Size(0, 13);
            this.LValiNombre.TabIndex = 50;
            // 
            // TCorreoCliente
            // 
            this.TCorreoCliente.Location = new System.Drawing.Point(525, 219);
            this.TCorreoCliente.Name = "TCorreoCliente";
            this.TCorreoCliente.Size = new System.Drawing.Size(205, 20);
            this.TCorreoCliente.TabIndex = 44;
            // 
            // TDNICliente
            // 
            this.TDNICliente.Location = new System.Drawing.Point(207, 221);
            this.TDNICliente.Name = "TDNICliente";
            this.TDNICliente.Size = new System.Drawing.Size(205, 20);
            this.TDNICliente.TabIndex = 42;
            // 
            // LCorreoCliente
            // 
            this.LCorreoCliente.AutoSize = true;
            this.LCorreoCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCorreoCliente.Location = new System.Drawing.Point(444, 222);
            this.LCorreoCliente.Name = "LCorreoCliente";
            this.LCorreoCliente.Size = new System.Drawing.Size(53, 17);
            this.LCorreoCliente.TabIndex = 41;
            this.LCorreoCliente.Text = "Correo";
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDni.Location = new System.Drawing.Point(126, 224);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(31, 17);
            this.LDni.TabIndex = 39;
            this.LDni.Text = "DNI";
            // 
            // LNombreCliente
            // 
            this.LNombreCliente.AutoSize = true;
            this.LNombreCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreCliente.Location = new System.Drawing.Point(126, 180);
            this.LNombreCliente.Name = "LNombreCliente";
            this.LNombreCliente.Size = new System.Drawing.Size(66, 17);
            this.LNombreCliente.TabIndex = 38;
            this.LNombreCliente.Text = "Nombres";
            this.LNombreCliente.Click += new System.EventHandler(this.LNombreProducto_Click);
            // 
            // TNombreCliente
            // 
            this.TNombreCliente.Location = new System.Drawing.Point(207, 177);
            this.TNombreCliente.Name = "TNombreCliente";
            this.TNombreCliente.Size = new System.Drawing.Size(205, 20);
            this.TNombreCliente.TabIndex = 37;
            // 
            // LTituloCliente
            // 
            this.LTituloCliente.AutoSize = true;
            this.LTituloCliente.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloCliente.Location = new System.Drawing.Point(77, 13);
            this.LTituloCliente.Name = "LTituloCliente";
            this.LTituloCliente.Size = new System.Drawing.Size(216, 36);
            this.LTituloCliente.TabIndex = 36;
            this.LTituloCliente.Text = "Nuevo Cliente";
            this.LTituloCliente.Click += new System.EventHandler(this.LTituloAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(525, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(525, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 60;
            // 
            // TApellidosCliente
            // 
            this.TApellidosCliente.Location = new System.Drawing.Point(525, 177);
            this.TApellidosCliente.Name = "TApellidosCliente";
            this.TApellidosCliente.Size = new System.Drawing.Size(205, 20);
            this.TApellidosCliente.TabIndex = 59;
            // 
            // LApellidoCliente
            // 
            this.LApellidoCliente.AutoSize = true;
            this.LApellidoCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellidoCliente.Location = new System.Drawing.Point(444, 180);
            this.LApellidoCliente.Name = "LApellidoCliente";
            this.LApellidoCliente.Size = new System.Drawing.Size(66, 17);
            this.LApellidoCliente.TabIndex = 58;
            this.LApellidoCliente.Text = "Apellidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(207, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(207, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 64;
            // 
            // TTelefonoCliente
            // 
            this.TTelefonoCliente.Location = new System.Drawing.Point(207, 265);
            this.TTelefonoCliente.Name = "TTelefonoCliente";
            this.TTelefonoCliente.Size = new System.Drawing.Size(205, 20);
            this.TTelefonoCliente.TabIndex = 63;
            // 
            // LTelefonoCliente
            // 
            this.LTelefonoCliente.AutoSize = true;
            this.LTelefonoCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTelefonoCliente.Location = new System.Drawing.Point(126, 268);
            this.LTelefonoCliente.Name = "LTelefonoCliente";
            this.LTelefonoCliente.Size = new System.Drawing.Size(62, 17);
            this.LTelefonoCliente.TabIndex = 62;
            this.LTelefonoCliente.Text = "Telefono";
            // 
            // LDatosClientes
            // 
            this.LDatosClientes.AutoSize = true;
            this.LDatosClientes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDatosClientes.Location = new System.Drawing.Point(125, 105);
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
            this.BBorrar.Location = new System.Drawing.Point(607, 360);
            this.BBorrar.Name = "BBorrar";
            this.BBorrar.Size = new System.Drawing.Size(123, 52);
            this.BBorrar.TabIndex = 48;
            this.BBorrar.Text = "Borrar Todo";
            this.BBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BBorrar.UseVisualStyleBackColor = true;
            // 
            // BAgregar
            // 
            this.BAgregar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAgregar.Image = global::ProyectoTaller.Properties.Resources.GuardarProducto;
            this.BAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BAgregar.Location = new System.Drawing.Point(468, 360);
            this.BAgregar.Name = "BAgregar";
            this.BAgregar.Size = new System.Drawing.Size(123, 52);
            this.BAgregar.TabIndex = 47;
            this.BAgregar.Text = "Agregar    ";
            this.BAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BAgregar.UseVisualStyleBackColor = true;
            // 
            // AgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(887, 507);
            this.Controls.Add(this.LDatosClientes);
            this.Controls.Add(this.PBImagenCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TTelefonoCliente);
            this.Controls.Add(this.LTelefonoCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TApellidosCliente);
            this.Controls.Add(this.LApellidoCliente);
            this.Controls.Add(this.LValido);
            this.Controls.Add(this.LValiStock);
            this.Controls.Add(this.LValiPrecio);
            this.Controls.Add(this.LValiNombre);
            this.Controls.Add(this.BBorrar);
            this.Controls.Add(this.BAgregar);
            this.Controls.Add(this.TCorreoCliente);
            this.Controls.Add(this.TDNICliente);
            this.Controls.Add(this.LCorreoCliente);
            this.Controls.Add(this.LDni);
            this.Controls.Add(this.LNombreCliente);
            this.Controls.Add(this.TNombreCliente);
            this.Controls.Add(this.LTituloCliente);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AgregarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarCliente";
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LValido;
        private System.Windows.Forms.Label LValiStock;
        private System.Windows.Forms.Label LValiPrecio;
        private System.Windows.Forms.Label LValiNombre;
        private System.Windows.Forms.Button BBorrar;
        private System.Windows.Forms.Button BAgregar;
        private System.Windows.Forms.TextBox TCorreoCliente;
        private System.Windows.Forms.TextBox TDNICliente;
        private System.Windows.Forms.Label LCorreoCliente;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.Label LNombreCliente;
        private System.Windows.Forms.TextBox TNombreCliente;
        private System.Windows.Forms.Label LTituloCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TApellidosCliente;
        private System.Windows.Forms.Label LApellidoCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TTelefonoCliente;
        private System.Windows.Forms.Label LTelefonoCliente;
        private System.Windows.Forms.PictureBox PBImagenCliente;
        private System.Windows.Forms.Label LDatosClientes;
    }
}