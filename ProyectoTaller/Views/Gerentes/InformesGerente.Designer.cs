namespace ProyectoTaller.Views.Gerentes
{
    partial class InformesGerente
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
            this.PBImagenInformeGerente = new System.Windows.Forms.PictureBox();
            this.LTituloInformeGerente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenInformeGerente)).BeginInit();
            this.SuspendLayout();
            // 
            // PBImagenInformeGerente
            // 
            this.PBImagenInformeGerente.Image = global::ProyectoTaller.Properties.Resources.informe_titulo;
            this.PBImagenInformeGerente.Location = new System.Drawing.Point(12, 12);
            this.PBImagenInformeGerente.Name = "PBImagenInformeGerente";
            this.PBImagenInformeGerente.Size = new System.Drawing.Size(65, 67);
            this.PBImagenInformeGerente.TabIndex = 31;
            this.PBImagenInformeGerente.TabStop = false;
            // 
            // LTituloInformeGerente
            // 
            this.LTituloInformeGerente.AutoSize = true;
            this.LTituloInformeGerente.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloInformeGerente.Location = new System.Drawing.Point(79, 13);
            this.LTituloInformeGerente.Name = "LTituloInformeGerente";
            this.LTituloInformeGerente.Size = new System.Drawing.Size(259, 36);
            this.LTituloInformeGerente.TabIndex = 32;
            this.LTituloInformeGerente.Text = "Informes Gerente";
            // 
            // InformesGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(887, 507);
            this.Controls.Add(this.LTituloInformeGerente);
            this.Controls.Add(this.PBImagenInformeGerente);
            this.Name = "InformesGerente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InformesGerente";
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenInformeGerente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBImagenInformeGerente;
        private System.Windows.Forms.Label LTituloInformeGerente;
    }
}