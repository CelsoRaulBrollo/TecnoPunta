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
            this.MenuTitulo = new System.Windows.Forms.MenuStrip();
            this.BInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.MMenuOpciones = new System.Windows.Forms.MenuStrip();
            this.BAgregar = new System.Windows.Forms.ToolStripMenuItem();
            this.BEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.BEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.BVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.BConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.BUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.DragControl = new System.Windows.Forms.Panel();
            this.BMinimizar = new System.Windows.Forms.Button();
            this.BCerrar = new System.Windows.Forms.Button();
            this.BMaximizar = new System.Windows.Forms.Button();
            this.LTitulo = new System.Windows.Forms.Label();
            this.LSubtitulo = new System.Windows.Forms.Label();
            this.BCerrarSesion = new System.Windows.Forms.Button();
            this.PContenedor = new System.Windows.Forms.Panel();
            this.MenuTitulo.SuspendLayout();
            this.MMenuOpciones.SuspendLayout();
            this.DragControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuTitulo
            // 
            this.MenuTitulo.AutoSize = false;
            this.MenuTitulo.BackColor = System.Drawing.Color.Teal;
            this.MenuTitulo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BInicio});
            this.MenuTitulo.Location = new System.Drawing.Point(0, 44);
            this.MenuTitulo.Name = "MenuTitulo";
            this.MenuTitulo.Size = new System.Drawing.Size(1027, 102);
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
            // 
            // MMenuOpciones
            // 
            this.MMenuOpciones.AutoSize = false;
            this.MMenuOpciones.BackColor = System.Drawing.Color.LightSlateGray;
            this.MMenuOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.MMenuOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BAgregar,
            this.BEditar,
            this.BEliminar,
            this.BVentas,
            this.BConsultas,
            this.BUsuarios});
            this.MMenuOpciones.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.MMenuOpciones.Location = new System.Drawing.Point(0, 146);
            this.MMenuOpciones.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.MMenuOpciones.Name = "MMenuOpciones";
            this.MMenuOpciones.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MMenuOpciones.Size = new System.Drawing.Size(141, 476);
            this.MMenuOpciones.TabIndex = 0;
            this.MMenuOpciones.Text = "MenuOpciones";
            // 
            // BAgregar
            // 
            this.BAgregar.AutoSize = false;
            this.BAgregar.Image = global::ProyectoTaller.Properties.Resources.Agregar;
            this.BAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BAgregar.Margin = new System.Windows.Forms.Padding(0, 10, 5, 0);
            this.BAgregar.Name = "BAgregar";
            this.BAgregar.Size = new System.Drawing.Size(110, 55);
            this.BAgregar.Text = "Agregar";
            this.BAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BAgregar.Click += new System.EventHandler(this.BAgregar_Click);
            // 
            // BEditar
            // 
            this.BEditar.AutoSize = false;
            this.BEditar.Image = global::ProyectoTaller.Properties.Resources.editar2;
            this.BEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BEditar.Margin = new System.Windows.Forms.Padding(0, 10, 5, 0);
            this.BEditar.Name = "BEditar";
            this.BEditar.Size = new System.Drawing.Size(110, 55);
            this.BEditar.Text = "  Editar";
            this.BEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BEditar.Click += new System.EventHandler(this.BEditar_Click);
            // 
            // BEliminar
            // 
            this.BEliminar.AutoSize = false;
            this.BEliminar.Image = global::ProyectoTaller.Properties.Resources.Borrar;
            this.BEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BEliminar.Margin = new System.Windows.Forms.Padding(0, 10, 5, 0);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(110, 55);
            this.BEliminar.Text = "Eliminar";
            this.BEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // 
            // DragControl
            // 
            this.DragControl.BackColor = System.Drawing.Color.LightSlateGray;
            this.DragControl.Controls.Add(this.BMinimizar);
            this.DragControl.Controls.Add(this.BCerrar);
            this.DragControl.Controls.Add(this.BMaximizar);
            this.DragControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.DragControl.Location = new System.Drawing.Point(0, 0);
            this.DragControl.Name = "DragControl";
            this.DragControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DragControl.Size = new System.Drawing.Size(1027, 44);
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
            this.BMinimizar.Location = new System.Drawing.Point(898, 1);
            this.BMinimizar.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.BMinimizar.Name = "BMinimizar";
            this.BMinimizar.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.BMinimizar.Size = new System.Drawing.Size(40, 40);
            this.BMinimizar.TabIndex = 8;
            this.BMinimizar.UseVisualStyleBackColor = false;
            // 
            // BCerrar
            // 
            this.BCerrar.BackColor = System.Drawing.Color.LightSlateGray;
            this.BCerrar.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.BCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCerrar.Image = global::ProyectoTaller.Properties.Resources.cerrar_ventana;
            this.BCerrar.Location = new System.Drawing.Point(984, 1);
            this.BCerrar.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.BCerrar.Name = "BCerrar";
            this.BCerrar.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.BCerrar.Size = new System.Drawing.Size(40, 40);
            this.BCerrar.TabIndex = 7;
            this.BCerrar.UseVisualStyleBackColor = false;
            this.BCerrar.Click += new System.EventHandler(this.BCerrar_Click);
            // 
            // BMaximizar
            // 
            this.BMaximizar.BackColor = System.Drawing.Color.LightSlateGray;
            this.BMaximizar.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.BMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BMaximizar.Image = global::ProyectoTaller.Properties.Resources.Maximizar;
            this.BMaximizar.Location = new System.Drawing.Point(941, 1);
            this.BMaximizar.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.BMaximizar.Name = "BMaximizar";
            this.BMaximizar.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.BMaximizar.Size = new System.Drawing.Size(40, 40);
            this.BMaximizar.TabIndex = 6;
            this.BMaximizar.UseVisualStyleBackColor = false;
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.BackColor = System.Drawing.Color.Teal;
            this.LTitulo.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.Location = new System.Drawing.Point(375, 44);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(310, 56);
            this.LTitulo.TabIndex = 10;
            this.LTitulo.Text = "Tecno Punta";
            // 
            // LSubtitulo
            // 
            this.LSubtitulo.AutoSize = true;
            this.LSubtitulo.BackColor = System.Drawing.Color.Teal;
            this.LSubtitulo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSubtitulo.Location = new System.Drawing.Point(527, 100);
            this.LSubtitulo.Name = "LSubtitulo";
            this.LSubtitulo.Size = new System.Drawing.Size(177, 22);
            this.LSubtitulo.TabIndex = 11;
            this.LSubtitulo.Text = "Sistema de ventas";
            // 
            // BCerrarSesion
            // 
            this.BCerrarSesion.BackColor = System.Drawing.Color.LightSlateGray;
            this.BCerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.BCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCerrarSesion.Image = global::ProyectoTaller.Properties.Resources.Salir;
            this.BCerrarSesion.Location = new System.Drawing.Point(12, 575);
            this.BCerrarSesion.Name = "BCerrarSesion";
            this.BCerrarSesion.Size = new System.Drawing.Size(33, 35);
            this.BCerrarSesion.TabIndex = 3;
            this.BCerrarSesion.UseVisualStyleBackColor = false;
            this.BCerrarSesion.Click += new System.EventHandler(this.BCerrarSesion_Click);
            // 
            // PContenedor
            // 
            this.PContenedor.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PContenedor.Location = new System.Drawing.Point(141, 146);
            this.PContenedor.Name = "PContenedor";
            this.PContenedor.Size = new System.Drawing.Size(886, 476);
            this.PContenedor.TabIndex = 12;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 622);
            this.Controls.Add(this.PContenedor);
            this.Controls.Add(this.LSubtitulo);
            this.Controls.Add(this.LTitulo);
            this.Controls.Add(this.BCerrarSesion);
            this.Controls.Add(this.MMenuOpciones);
            this.Controls.Add(this.MenuTitulo);
            this.Controls.Add(this.DragControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.MainMenuStrip = this.MenuTitulo;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.MenuTitulo.ResumeLayout(false);
            this.MenuTitulo.PerformLayout();
            this.MMenuOpciones.ResumeLayout(false);
            this.MMenuOpciones.PerformLayout();
            this.DragControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuTitulo;
        private System.Windows.Forms.ToolStripMenuItem BInicio;
        private System.Windows.Forms.MenuStrip MMenuOpciones;
        private System.Windows.Forms.ToolStripMenuItem BEditar;
        private System.Windows.Forms.ToolStripMenuItem BEliminar;
        private System.Windows.Forms.ToolStripMenuItem BVentas;
        private System.Windows.Forms.ToolStripMenuItem BConsultas;
        private System.Windows.Forms.ToolStripMenuItem BUsuarios;
        private System.Windows.Forms.Button BCerrarSesion;
        private System.Windows.Forms.Button BMaximizar;
        private System.Windows.Forms.Button BMinimizar;
        private System.Windows.Forms.Button BCerrar;
        private System.Windows.Forms.Panel DragControl;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Label LSubtitulo;
        private ToolStripMenuItem BAgregar;
        private Panel PContenedor;
    }
}