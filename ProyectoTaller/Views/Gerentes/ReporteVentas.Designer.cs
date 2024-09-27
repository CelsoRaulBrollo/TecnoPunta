namespace ProyectoTaller.Views.Gerentes
{
    partial class ReporteVentas
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
            this.LTituloReporteVentas = new System.Windows.Forms.Label();
            this.PBImagenReporteVentas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenReporteVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // LTituloReporteVentas
            // 
            this.LTituloReporteVentas.AutoSize = true;
            this.LTituloReporteVentas.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloReporteVentas.Location = new System.Drawing.Point(79, 14);
            this.LTituloReporteVentas.Name = "LTituloReporteVentas";
            this.LTituloReporteVentas.Size = new System.Drawing.Size(231, 36);
            this.LTituloReporteVentas.TabIndex = 37;
            this.LTituloReporteVentas.Text = "Reporte Ventas";
            // 
            // PBImagenReporteVentas
            // 
            this.PBImagenReporteVentas.Image = global::ProyectoTaller.Properties.Resources.VentasTitulo;
            this.PBImagenReporteVentas.Location = new System.Drawing.Point(12, 12);
            this.PBImagenReporteVentas.Name = "PBImagenReporteVentas";
            this.PBImagenReporteVentas.Size = new System.Drawing.Size(65, 67);
            this.PBImagenReporteVentas.TabIndex = 36;
            this.PBImagenReporteVentas.TabStop = false;
            // 
            // ReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(887, 507);
            this.Controls.Add(this.LTituloReporteVentas);
            this.Controls.Add(this.PBImagenReporteVentas);
            this.Name = "ReporteVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteVentas";
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenReporteVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LTituloReporteVentas;
        private System.Windows.Forms.PictureBox PBImagenReporteVentas;
    }
}