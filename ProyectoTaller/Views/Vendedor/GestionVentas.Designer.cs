namespace ProyectoTaller.Views.Vendedor
{
    partial class GestionVentas
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
            this.PBImagenVentas = new System.Windows.Forms.PictureBox();
            this.LTituloGestionVentas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // PBImagenVentas
            // 
            this.PBImagenVentas.Image = global::ProyectoTaller.Properties.Resources.VentasTitulo;
            this.PBImagenVentas.Location = new System.Drawing.Point(12, 12);
            this.PBImagenVentas.Name = "PBImagenVentas";
            this.PBImagenVentas.Size = new System.Drawing.Size(65, 67);
            this.PBImagenVentas.TabIndex = 29;
            this.PBImagenVentas.TabStop = false;
            // 
            // LTituloGestionVentas
            // 
            this.LTituloGestionVentas.AutoSize = true;
            this.LTituloGestionVentas.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloGestionVentas.Location = new System.Drawing.Point(80, 14);
            this.LTituloGestionVentas.Name = "LTituloGestionVentas";
            this.LTituloGestionVentas.Size = new System.Drawing.Size(112, 36);
            this.LTituloGestionVentas.TabIndex = 30;
            this.LTituloGestionVentas.Text = "Ventas";
            // 
            // GestionVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(887, 507);
            this.Controls.Add(this.LTituloGestionVentas);
            this.Controls.Add(this.PBImagenVentas);
            this.Name = "GestionVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionVentas";
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBImagenVentas;
        private System.Windows.Forms.Label LTituloGestionVentas;
    }
}