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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolStripMenuItem BAgregar;
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MMenuOpciones = new System.Windows.Forms.MenuStrip();
            this.BEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.GunaDragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.GBordesRedondeados = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            BAgregar = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.MMenuOpciones.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BAgregar
            // 
            BAgregar.AutoSize = false;
            BAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            BAgregar.Image = global::ProyectoTaller.Properties.Resources.Agregar;
            BAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            BAgregar.Margin = new System.Windows.Forms.Padding(0, 10, 5, 0);
            BAgregar.MergeIndex = 0;
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new System.Drawing.Size(55, 55);
            BAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            BAgregar.Click += new System.EventHandler(this.BAgregar_Click);
            // 
            // Menu
            // 
            this.Menu.AutoSize = false;
            this.Menu.BackColor = System.Drawing.Color.Teal;
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 43);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1027, 129);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "Menu";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.AutoSize = false;
            this.menuToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuToolStripMenuItem.Image = global::ProyectoTaller.Properties.Resources.smartPho;
            this.menuToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuToolStripMenuItem.Margin = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(75, 75);
            this.menuToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // MMenuOpciones
            // 
            this.MMenuOpciones.AutoSize = false;
            this.MMenuOpciones.BackColor = System.Drawing.Color.LightSlateGray;
            this.MMenuOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.MMenuOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            BAgregar,
            this.BEditar,
            this.eliminarToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.MMenuOpciones.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.MMenuOpciones.Location = new System.Drawing.Point(0, 172);
            this.MMenuOpciones.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.MMenuOpciones.Name = "MMenuOpciones";
            this.MMenuOpciones.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MMenuOpciones.Size = new System.Drawing.Size(141, 450);
            this.MMenuOpciones.TabIndex = 0;
            this.MMenuOpciones.Text = "MenuOpciones";
            // 
            // BEditar
            // 
            this.BEditar.AutoSize = false;
            this.BEditar.Image = global::ProyectoTaller.Properties.Resources.editar2;
            this.BEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BEditar.Margin = new System.Windows.Forms.Padding(0, 10, 5, 0);
            this.BEditar.Name = "BEditar";
            this.BEditar.Size = new System.Drawing.Size(55, 55);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.AutoSize = false;
            this.eliminarToolStripMenuItem.Image = global::ProyectoTaller.Properties.Resources.Borrar;
            this.eliminarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.eliminarToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 10, 5, 0);
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(55, 55);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.AutoSize = false;
            this.ventasToolStripMenuItem.Image = global::ProyectoTaller.Properties.Resources.Ventas;
            this.ventasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ventasToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 10, 5, 0);
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(55, 55);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.AutoSize = false;
            this.consultasToolStripMenuItem.Image = global::ProyectoTaller.Properties.Resources.consultas;
            this.consultasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.consultasToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 10, 5, 0);
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(55, 55);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.AutoSize = false;
            this.usuariosToolStripMenuItem.Image = global::ProyectoTaller.Properties.Resources.Usuarios;
            this.usuariosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.usuariosToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 10, 5, 0);
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(55, 55);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSlateGray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::ProyectoTaller.Properties.Resources.Salir;
            this.button1.Location = new System.Drawing.Point(12, 572);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 38);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.guna2Panel1.Controls.Add(this.button3);
            this.guna2Panel1.Controls.Add(this.button2);
            this.guna2Panel1.Controls.Add(this.button4);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1027, 43);
            this.guna2Panel1.TabIndex = 4;
            // 
            // GunaDragControl
            // 
            this.GunaDragControl.DockIndicatorTransparencyValue = 0.6D;
            this.GunaDragControl.DragStartTransparencyValue = 1D;
            this.GunaDragControl.TargetControl = this.guna2Panel1;
            this.GunaDragControl.UseTransparentDrag = true;
            // 
            // GBordesRedondeados
            // 
            this.GBordesRedondeados.BorderRadius = 4;
            this.GBordesRedondeados.TargetControl = this;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSlateGray;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::ProyectoTaller.Properties.Resources.cerrar_ventana;
            this.button4.Location = new System.Drawing.Point(941, 3);
            this.button4.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.button4.Size = new System.Drawing.Size(40, 40);
            this.button4.TabIndex = 6;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSlateGray;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::ProyectoTaller.Properties.Resources.cerrar_ventana;
            this.button2.Location = new System.Drawing.Point(984, 3);
            this.button2.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSlateGray;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::ProyectoTaller.Properties.Resources.cerrar_ventana;
            this.button3.Location = new System.Drawing.Point(898, 3);
            this.button3.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.button3.Size = new System.Drawing.Size(40, 40);
            this.button3.TabIndex = 8;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 622);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MMenuOpciones);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.MainMenuStrip = this.Menu;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.MMenuOpciones.ResumeLayout(false);
            this.MMenuOpciones.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.MenuStrip MMenuOpciones;
        private System.Windows.Forms.ToolStripMenuItem BEditar;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DragControl GunaDragControl;
        private Guna.UI2.WinForms.Guna2Elipse GBordesRedondeados;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}