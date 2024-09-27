namespace ProyectoTaller.Views.Gerentes
{
    partial class ReporteProductos
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
            this.LTituloReporteProductos = new System.Windows.Forms.Label();
            this.PBImagenReporteProductos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenReporteProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // LTituloReporteProductos
            // 
            this.LTituloReporteProductos.AutoSize = true;
            this.LTituloReporteProductos.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloReporteProductos.Location = new System.Drawing.Point(79, 14);
            this.LTituloReporteProductos.Name = "LTituloReporteProductos";
            this.LTituloReporteProductos.Size = new System.Drawing.Size(274, 36);
            this.LTituloReporteProductos.TabIndex = 35;
            this.LTituloReporteProductos.Text = "Reporte Productos";
            // 
            // PBImagenReporteProductos
            // 
            this.PBImagenReporteProductos.Image = global::ProyectoTaller.Properties.Resources.CelularesTitulo;
            this.PBImagenReporteProductos.Location = new System.Drawing.Point(12, 12);
            this.PBImagenReporteProductos.Name = "PBImagenReporteProductos";
            this.PBImagenReporteProductos.Size = new System.Drawing.Size(65, 67);
            this.PBImagenReporteProductos.TabIndex = 34;
            this.PBImagenReporteProductos.TabStop = false;
            // 
            // ReporteProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(887, 507);
            this.Controls.Add(this.LTituloReporteProductos);
            this.Controls.Add(this.PBImagenReporteProductos);
            this.Name = "ReporteProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteProductos";
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenReporteProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LTituloReporteProductos;
        private System.Windows.Forms.PictureBox PBImagenReporteProductos;
    }
}