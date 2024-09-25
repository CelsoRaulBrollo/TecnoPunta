namespace ProyectoTaller.Views.Administradores
{
    partial class InformesAdministrador
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
            this.PBImagenInformeAdmin = new System.Windows.Forms.PictureBox();
            this.LTituloInformeAdmin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenInformeAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // PBImagenInformeAdmin
            // 
            this.PBImagenInformeAdmin.Image = global::ProyectoTaller.Properties.Resources.informe_titulo;
            this.PBImagenInformeAdmin.Location = new System.Drawing.Point(12, 12);
            this.PBImagenInformeAdmin.Name = "PBImagenInformeAdmin";
            this.PBImagenInformeAdmin.Size = new System.Drawing.Size(65, 67);
            this.PBImagenInformeAdmin.TabIndex = 31;
            this.PBImagenInformeAdmin.TabStop = false;
            // 
            // LTituloInformeAdmin
            // 
            this.LTituloInformeAdmin.AutoSize = true;
            this.LTituloInformeAdmin.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloInformeAdmin.Location = new System.Drawing.Point(80, 13);
            this.LTituloInformeAdmin.Name = "LTituloInformeAdmin";
            this.LTituloInformeAdmin.Size = new System.Drawing.Size(338, 36);
            this.LTituloInformeAdmin.TabIndex = 32;
            this.LTituloInformeAdmin.Text = "Informes Administrador";
            // 
            // InformesAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(887, 507);
            this.Controls.Add(this.LTituloInformeAdmin);
            this.Controls.Add(this.PBImagenInformeAdmin);
            this.Name = "InformesAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InformesAdministrador";
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenInformeAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBImagenInformeAdmin;
        private System.Windows.Forms.Label LTituloInformeAdmin;
    }
}