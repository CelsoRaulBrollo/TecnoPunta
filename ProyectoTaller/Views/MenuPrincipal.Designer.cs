using System.Windows.Forms;

namespace ProyectoTaller.Views
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.MenuTitulo = new System.Windows.Forms.MenuStrip();
            this.BInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.MMenuOpciones = new System.Windows.Forms.MenuStrip();
            this.BProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.BConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.BCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.BCarrito = new System.Windows.Forms.ToolStripMenuItem();
            this.BUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.BVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.BStock = new System.Windows.Forms.ToolStripMenuItem();
            this.BInformes = new System.Windows.Forms.ToolStripMenuItem();
            this.BBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.DragControl = new System.Windows.Forms.Panel();
            this.BMinimizar = new System.Windows.Forms.Button();
            this.BCerrar = new System.Windows.Forms.Button();
            this.LTitulo = new System.Windows.Forms.Label();
            this.LSubtitulo = new System.Windows.Forms.Label();
            this.PContenedor = new System.Windows.Forms.Panel();
            this.LBienvenido = new System.Windows.Forms.Label();
            this.BCerrarSesion = new System.Windows.Forms.Button();
            this.LNombreUsuario = new System.Windows.Forms.Label();
            this.LRolUsuario = new System.Windows.Forms.Label();
            this.MenuTitulo.SuspendLayout();
            this.MMenuOpciones.SuspendLayout();
            this.DragControl.SuspendLayout();
            this.PContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuTitulo
            // 
            this.MenuTitulo.AutoSize = false;
            this.MenuTitulo.BackColor = System.Drawing.Color.Teal;
            this.MenuTitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuTitulo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BInicio});
            this.MenuTitulo.Location = new System.Drawing.Point(0, 54);
            this.MenuTitulo.Name = "MenuTitulo";
            this.MenuTitulo.Size = new System.Drawing.Size(1369, 146);
            this.MenuTitulo.TabIndex = 1;
            this.MenuTitulo.Text = "Menu";
            // 
            // BInicio
            // 
            this.BInicio.AutoSize = false;
            this.BInicio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BInicio.Image = global::ProyectoTaller.Properties.Resources.smartPho;
            this.BInicio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BInicio.Margin = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BInicio.Name = "BInicio";
            this.BInicio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BInicio.Size = new System.Drawing.Size(75, 75);
            this.BInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BInicio.Click += new System.EventHandler(this.BInicio_Click);
            // 
            // MMenuOpciones
            // 
            this.MMenuOpciones.AutoSize = false;
            this.MMenuOpciones.BackColor = System.Drawing.Color.LightSlateGray;
            this.MMenuOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.MMenuOpciones.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MMenuOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BProductos,
            this.BConsultas,
            this.BCliente,
            this.BCarrito,
            this.BUsuarios,
            this.BVentas,
            this.BStock,
            this.BInformes,
            this.BBackup});
            this.MMenuOpciones.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.MMenuOpciones.Location = new System.Drawing.Point(0, 200);
            this.MMenuOpciones.Margin = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.MMenuOpciones.Name = "MMenuOpciones";
            this.MMenuOpciones.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MMenuOpciones.Size = new System.Drawing.Size(188, 625);
            this.MMenuOpciones.TabIndex = 0;
            this.MMenuOpciones.Text = "MenuOpciones";
            // 
            // BProductos
            // 
            this.BProductos.AutoSize = false;
            this.BProductos.Image = global::ProyectoTaller.Properties.Resources.Celulares;
            this.BProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BProductos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BProductos.Margin = new System.Windows.Forms.Padding(0, 10, 5, 0);
            this.BProductos.Name = "BProductos";
            this.BProductos.Size = new System.Drawing.Size(110, 55);
            this.BProductos.Text = "   Productos";
            this.BProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BProductos.Click += new System.EventHandler(this.BProductos_Click);
            // 
            // BConsultas
            // 
            this.BConsultas.AutoSize = false;
            this.BConsultas.Image = global::ProyectoTaller.Properties.Resources.Consulta;
            this.BConsultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BConsultas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BConsultas.Margin = new System.Windows.Forms.Padding(0, 10, 5, 0);
            this.BConsultas.Name = "BConsultas";
            this.BConsultas.Size = new System.Drawing.Size(110, 55);
            this.BConsultas.Text = "Consultas";
            this.BConsultas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BCliente
            // 
            this.BCliente.AutoSize = false;
            this.BCliente.Image = global::ProyectoTaller.Properties.Resources.AgregarCliente;
            this.BCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BCliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BCliente.Margin = new System.Windows.Forms.Padding(0, 10, 5, 0);
            this.BCliente.Name = "BCliente";
            this.BCliente.Size = new System.Drawing.Size(110, 55);
            this.BCliente.Text = " Clientes";
            this.BCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BCliente.Click += new System.EventHandler(this.BCliente_Click);
            // 
            // BCarrito
            // 
            this.BCarrito.AutoSize = false;
            this.BCarrito.Image = global::ProyectoTaller.Properties.Resources.Carrito;
            this.BCarrito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BCarrito.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BCarrito.Margin = new System.Windows.Forms.Padding(0, 10, 5, 0);
            this.BCarrito.Name = "BCarrito";
            this.BCarrito.Size = new System.Drawing.Size(110, 55);
            this.BCarrito.Text = "  Carrito";
            this.BCarrito.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BCarrito.Click += new System.EventHandler(this.BCarrito_Click);
            // 
            // BUsuarios
            // 
            this.BUsuarios.AutoSize = false;
            this.BUsuarios.Image = global::ProyectoTaller.Properties.Resources.Usuarios;
            this.BUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BUsuarios.Margin = new System.Windows.Forms.Padding(0, 10, 5, 0);
            this.BUsuarios.Name = "BUsuarios";
            this.BUsuarios.Size = new System.Drawing.Size(110, 55);
            this.BUsuarios.Text = "Usuarios";
            this.BUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BUsuarios.Click += new System.EventHandler(this.BUsuarios_Click);
            // 
            // BVentas
            // 
            this.BVentas.AutoSize = false;
            this.BVentas.Image = global::ProyectoTaller.Properties.Resources.Ventas;
            this.BVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BVentas.Margin = new System.Windows.Forms.Padding(0, 10, 5, 0);
            this.BVentas.Name = "BVentas";
            this.BVentas.Size = new System.Drawing.Size(110, 55);
            this.BVentas.Text = " Ventas";
            this.BVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BVentas.Click += new System.EventHandler(this.BVentas_Click);
            // 
            // BStock
            // 
            this.BStock.AutoSize = false;
            this.BStock.Image = global::ProyectoTaller.Properties.Resources.graficos_estadisticas;
            this.BStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BStock.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BStock.Margin = new System.Windows.Forms.Padding(0, 10, 5, 0);
            this.BStock.Name = "BStock";
            this.BStock.Size = new System.Drawing.Size(110, 55);
            this.BStock.Text = "   Stock";
            this.BStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BStock.Click += new System.EventHandler(this.BGraficos_Click);
            // 
            // BInformes
            // 
            this.BInformes.AutoSize = false;
            this.BInformes.Image = global::ProyectoTaller.Properties.Resources.informe_icon;
            this.BInformes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BInformes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BInformes.Margin = new System.Windows.Forms.Padding(0, 10, 5, 0);
            this.BInformes.Name = "BInformes";
            this.BInformes.Size = new System.Drawing.Size(110, 55);
            this.BInformes.Text = " Informes";
            this.BInformes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BInformes.Click += new System.EventHandler(this.BInformes_Click);
            // 
            // BBackup
            // 
            this.BBackup.AutoSize = false;
            this.BBackup.Image = global::ProyectoTaller.Properties.Resources.Backup;
            this.BBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BBackup.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BBackup.Margin = new System.Windows.Forms.Padding(0, 10, 5, 0);
            this.BBackup.Name = "BBackup";
            this.BBackup.Size = new System.Drawing.Size(110, 55);
            this.BBackup.Text = "  Backup";
            this.BBackup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BBackup.Click += new System.EventHandler(this.BBackup_Click);
            // 
            // DragControl
            // 
            this.DragControl.BackColor = System.Drawing.Color.LightSlateGray;
            this.DragControl.Controls.Add(this.BMinimizar);
            this.DragControl.Controls.Add(this.BCerrar);
            this.DragControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.DragControl.Location = new System.Drawing.Point(0, 0);
            this.DragControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DragControl.Name = "DragControl";
            this.DragControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DragControl.Size = new System.Drawing.Size(1369, 54);
            this.DragControl.TabIndex = 9;
            this.DragControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown_event);
            this.DragControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove_event);
            this.DragControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp_event);
            // 
            // BMinimizar
            // 
            this.BMinimizar.BackColor = System.Drawing.Color.LightSlateGray;
            this.BMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.BMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BMinimizar.Image = global::ProyectoTaller.Properties.Resources.minimizar_ventana;
            this.BMinimizar.Location = new System.Drawing.Point(1260, 1);
            this.BMinimizar.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.BMinimizar.Name = "BMinimizar";
            this.BMinimizar.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.BMinimizar.Size = new System.Drawing.Size(53, 49);
            this.BMinimizar.TabIndex = 8;
            this.BMinimizar.UseVisualStyleBackColor = false;
            this.BMinimizar.Click += new System.EventHandler(this.BMinimizar_Click);
            // 
            // BCerrar
            // 
            this.BCerrar.BackColor = System.Drawing.Color.LightSlateGray;
            this.BCerrar.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.BCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCerrar.Image = global::ProyectoTaller.Properties.Resources.cerrar_ventana;
            this.BCerrar.Location = new System.Drawing.Point(1312, 1);
            this.BCerrar.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.BCerrar.Name = "BCerrar";
            this.BCerrar.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.BCerrar.Size = new System.Drawing.Size(53, 49);
            this.BCerrar.TabIndex = 7;
            this.BCerrar.UseVisualStyleBackColor = false;
            this.BCerrar.Click += new System.EventHandler(this.BCerrar_Click);
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.BackColor = System.Drawing.Color.Teal;
            this.LTitulo.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.Location = new System.Drawing.Point(493, 81);
            this.LTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(386, 70);
            this.LTitulo.TabIndex = 10;
            this.LTitulo.Text = "Tecno Punta";
            // 
            // LSubtitulo
            // 
            this.LSubtitulo.AutoSize = true;
            this.LSubtitulo.BackColor = System.Drawing.Color.Teal;
            this.LSubtitulo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSubtitulo.Location = new System.Drawing.Point(707, 150);
            this.LSubtitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LSubtitulo.Name = "LSubtitulo";
            this.LSubtitulo.Size = new System.Drawing.Size(231, 30);
            this.LSubtitulo.TabIndex = 11;
            this.LSubtitulo.Text = "Sistema de ventas";
            // 
            // PContenedor
            // 
            this.PContenedor.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PContenedor.Controls.Add(this.LBienvenido);
            this.PContenedor.Location = new System.Drawing.Point(188, 201);
            this.PContenedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PContenedor.Name = "PContenedor";
            this.PContenedor.Size = new System.Drawing.Size(1181, 624);
            this.PContenedor.TabIndex = 12;
            // 
            // LBienvenido
            // 
            this.LBienvenido.AutoSize = true;
            this.LBienvenido.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LBienvenido.Font = new System.Drawing.Font("Century Gothic", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBienvenido.Location = new System.Drawing.Point(300, 249);
            this.LBienvenido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBienvenido.Name = "LBienvenido";
            this.LBienvenido.Size = new System.Drawing.Size(543, 99);
            this.LBienvenido.TabIndex = 13;
            this.LBienvenido.Text = "Bienvenido!!";
            // 
            // BCerrarSesion
            // 
            this.BCerrarSesion.BackColor = System.Drawing.Color.LightSlateGray;
            this.BCerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.BCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCerrarSesion.Image = global::ProyectoTaller.Properties.Resources.Salir;
            this.BCerrarSesion.Location = new System.Drawing.Point(8, 775);
            this.BCerrarSesion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BCerrarSesion.Name = "BCerrarSesion";
            this.BCerrarSesion.Size = new System.Drawing.Size(44, 43);
            this.BCerrarSesion.TabIndex = 3;
            this.BCerrarSesion.UseVisualStyleBackColor = false;
            this.BCerrarSesion.Click += new System.EventHandler(this.BCerrarSesion_Click);
            // 
            // LNombreUsuario
            // 
            this.LNombreUsuario.AutoSize = true;
            this.LNombreUsuario.BackColor = System.Drawing.Color.Teal;
            this.LNombreUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreUsuario.Location = new System.Drawing.Point(1098, 121);
            this.LNombreUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LNombreUsuario.Name = "LNombreUsuario";
            this.LNombreUsuario.Size = new System.Drawing.Size(189, 30);
            this.LNombreUsuario.TabIndex = 13;
            this.LNombreUsuario.Text = "Gabriel Capay";
            // 
            // LRolUsuario
            // 
            this.LRolUsuario.AutoSize = true;
            this.LRolUsuario.BackColor = System.Drawing.Color.Teal;
            this.LRolUsuario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRolUsuario.Location = new System.Drawing.Point(1179, 151);
            this.LRolUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LRolUsuario.Name = "LRolUsuario";
            this.LRolUsuario.Size = new System.Drawing.Size(125, 21);
            this.LRolUsuario.TabIndex = 14;
            this.LRolUsuario.Text = "Administrador";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 825);
            this.Controls.Add(this.LRolUsuario);
            this.Controls.Add(this.LNombreUsuario);
            this.Controls.Add(this.PContenedor);
            this.Controls.Add(this.LSubtitulo);
            this.Controls.Add(this.LTitulo);
            this.Controls.Add(this.BCerrarSesion);
            this.Controls.Add(this.MMenuOpciones);
            this.Controls.Add(this.MenuTitulo);
            this.Controls.Add(this.DragControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuTitulo;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.MenuTitulo.ResumeLayout(false);
            this.MenuTitulo.PerformLayout();
            this.MMenuOpciones.ResumeLayout(false);
            this.MMenuOpciones.PerformLayout();
            this.DragControl.ResumeLayout(false);
            this.PContenedor.ResumeLayout(false);
            this.PContenedor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuTitulo;
        private System.Windows.Forms.ToolStripMenuItem BInicio;
        private System.Windows.Forms.MenuStrip MMenuOpciones;
        private System.Windows.Forms.ToolStripMenuItem BVentas;
        private System.Windows.Forms.ToolStripMenuItem BConsultas;
        private System.Windows.Forms.ToolStripMenuItem BUsuarios;
        private System.Windows.Forms.Button BCerrarSesion;
        private System.Windows.Forms.Button BMinimizar;
        private System.Windows.Forms.Button BCerrar;
        private System.Windows.Forms.Panel DragControl;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Label LSubtitulo;
        private Panel PContenedor;
        private ToolStripMenuItem BProductos;
        private Label LBienvenido;
        private ToolStripMenuItem BCliente;
        private ToolStripMenuItem BCarrito;
        private ToolStripMenuItem BStock;
        private ToolStripMenuItem BInformes;
        private ToolStripMenuItem BBackup;
        private Label LNombreUsuario;
        private Label LRolUsuario;
    }
}