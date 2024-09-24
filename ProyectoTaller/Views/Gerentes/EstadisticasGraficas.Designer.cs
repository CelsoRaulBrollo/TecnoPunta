namespace ProyectoTaller.Views.Gerentes
{
    partial class EstadisticasGraficas
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
            this.LTituloEstadisticas = new System.Windows.Forms.Label();
            this.PBImagenEstadisticas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenEstadisticas)).BeginInit();
            this.SuspendLayout();
            // 
            // LTituloEstadisticas
            // 
            this.LTituloEstadisticas.AutoSize = true;
            this.LTituloEstadisticas.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloEstadisticas.Location = new System.Drawing.Point(80, 13);
            this.LTituloEstadisticas.Name = "LTituloEstadisticas";
            this.LTituloEstadisticas.Size = new System.Drawing.Size(177, 36);
            this.LTituloEstadisticas.TabIndex = 30;
            this.LTituloEstadisticas.Text = "Estadisticas";
            // 
            // PBImagenEstadisticas
            // 
            this.PBImagenEstadisticas.Image = global::ProyectoTaller.Properties.Resources.Estadisticas;
            this.PBImagenEstadisticas.Location = new System.Drawing.Point(12, 12);
            this.PBImagenEstadisticas.Name = "PBImagenEstadisticas";
            this.PBImagenEstadisticas.Size = new System.Drawing.Size(65, 67);
            this.PBImagenEstadisticas.TabIndex = 29;
            this.PBImagenEstadisticas.TabStop = false;
            // 
            // EstadisticasGraficas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(887, 507);
            this.Controls.Add(this.LTituloEstadisticas);
            this.Controls.Add(this.PBImagenEstadisticas);
            this.Name = "EstadisticasGraficas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EstadisticasGraficas";
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenEstadisticas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBImagenEstadisticas;
        private System.Windows.Forms.Label LTituloEstadisticas;
    }
}