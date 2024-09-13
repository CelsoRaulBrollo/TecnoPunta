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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MMenuOpciones = new System.Windows.Forms.MenuStrip();
            this.BEditar = new System.Windows.Forms.ToolStripMenuItem();
            BAgregar = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.MMenuOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // BAgregar
            // 
            BAgregar.AutoSize = false;
            BAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            BAgregar.Image = global::ProyectoTaller.Properties.Resources.Agregar;
            BAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            BAgregar.Margin = new System.Windows.Forms.Padding(0, 20, 5, 0);
            BAgregar.MergeIndex = 0;
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new System.Drawing.Size(60, 60);
            BAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            BAgregar.Click += new System.EventHandler(this.BAgregar_Click);
            // 
            // Menu
            // 
            this.Menu.AutoSize = false;
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(187)))), ((int)(((byte)(38)))));
            this.Menu.Dock = System.Windows.Forms.DockStyle.None;
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(894, 95);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "Menu";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Image = global::ProyectoTaller.Properties.Resources.smartPho;
            this.menuToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuToolStripMenuItem.Margin = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(76, 91);
            this.menuToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MMenuOpciones
            // 
            this.MMenuOpciones.AutoSize = false;
            this.MMenuOpciones.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.MMenuOpciones.Dock = System.Windows.Forms.DockStyle.None;
            this.MMenuOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            BAgregar,
            this.BEditar});
            this.MMenuOpciones.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.MMenuOpciones.Location = new System.Drawing.Point(0, 95);
            this.MMenuOpciones.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.MMenuOpciones.Name = "MMenuOpciones";
            this.MMenuOpciones.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MMenuOpciones.Size = new System.Drawing.Size(141, 416);
            this.MMenuOpciones.TabIndex = 0;
            this.MMenuOpciones.Text = "MenuOpciones";
            // 
            // BEditar
            // 
            this.BEditar.AutoSize = false;
            this.BEditar.Image = global::ProyectoTaller.Properties.Resources.editar2;
            this.BEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BEditar.Margin = new System.Windows.Forms.Padding(0, 20, 5, 0);
            this.BEditar.Name = "BEditar";
            this.BEditar.Size = new System.Drawing.Size(60, 60);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 511);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.MMenuOpciones);
            this.MainMenuStrip = this.Menu;
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.MMenuOpciones.ResumeLayout(false);
            this.MMenuOpciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.MenuStrip MMenuOpciones;
        private System.Windows.Forms.ToolStripMenuItem BEditar;
    }
}