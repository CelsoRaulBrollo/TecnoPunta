namespace ProyectoTaller.Views.Administradores
{
    partial class Backup
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
            this.PBImagenBackUp = new System.Windows.Forms.PictureBox();
            this.LTituloBackup = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenBackUp)).BeginInit();
            this.SuspendLayout();
            // 
            // PBImagenBackUp
            // 
            this.PBImagenBackUp.Image = global::ProyectoTaller.Properties.Resources.BackUpTitulo;
            this.PBImagenBackUp.Location = new System.Drawing.Point(12, 12);
            this.PBImagenBackUp.Name = "PBImagenBackUp";
            this.PBImagenBackUp.Size = new System.Drawing.Size(65, 67);
            this.PBImagenBackUp.TabIndex = 28;
            this.PBImagenBackUp.TabStop = false;
            // 
            // LTituloBackup
            // 
            this.LTituloBackup.AutoSize = true;
            this.LTituloBackup.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloBackup.Location = new System.Drawing.Point(77, 13);
            this.LTituloBackup.Name = "LTituloBackup";
            this.LTituloBackup.Size = new System.Drawing.Size(123, 36);
            this.LTituloBackup.TabIndex = 29;
            this.LTituloBackup.Text = "Backup";
            // 
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(887, 507);
            this.Controls.Add(this.LTituloBackup);
            this.Controls.Add(this.PBImagenBackUp);
            this.Name = "Backup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup";
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenBackUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBImagenBackUp;
        private System.Windows.Forms.Label LTituloBackup;
    }
}