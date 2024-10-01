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
            this.LTituloBackup = new System.Windows.Forms.Label();
            this.BBackup = new System.Windows.Forms.Button();
            this.BRestaurar = new System.Windows.Forms.Button();
            this.PBImagenBackUp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenBackUp)).BeginInit();
            this.SuspendLayout();
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
            // BBackup
            // 
            this.BBackup.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BBackup.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBackup.Image = global::ProyectoTaller.Properties.Resources.BackupButton;
            this.BBackup.Location = new System.Drawing.Point(495, 106);
            this.BBackup.Name = "BBackup";
            this.BBackup.Size = new System.Drawing.Size(304, 294);
            this.BBackup.TabIndex = 31;
            this.BBackup.Text = "Backup";
            this.BBackup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BBackup.UseVisualStyleBackColor = false;
            this.BBackup.Click += new System.EventHandler(this.BBackup_Click);
            // 
            // BRestaurar
            // 
            this.BRestaurar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BRestaurar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRestaurar.Image = global::ProyectoTaller.Properties.Resources.Restaurar;
            this.BRestaurar.Location = new System.Drawing.Point(99, 106);
            this.BRestaurar.Name = "BRestaurar";
            this.BRestaurar.Size = new System.Drawing.Size(304, 294);
            this.BRestaurar.TabIndex = 30;
            this.BRestaurar.Text = "Restaurar";
            this.BRestaurar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BRestaurar.UseVisualStyleBackColor = false;
            this.BRestaurar.Click += new System.EventHandler(this.BRestaurar_Click);
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
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(887, 507);
            this.Controls.Add(this.BBackup);
            this.Controls.Add(this.BRestaurar);
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
        private System.Windows.Forms.Button BRestaurar;
        private System.Windows.Forms.Button BBackup;
    }
}