namespace ProyectoTaller.Views.Gerentes
{
    partial class VerUsuarios
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
            this.LTituloUsuarios = new System.Windows.Forms.Label();
            this.PBImagenUsuarios = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // LTituloUsuarios
            // 
            this.LTituloUsuarios.AutoSize = true;
            this.LTituloUsuarios.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloUsuarios.Location = new System.Drawing.Point(76, 15);
            this.LTituloUsuarios.Name = "LTituloUsuarios";
            this.LTituloUsuarios.Size = new System.Drawing.Size(247, 36);
            this.LTituloUsuarios.TabIndex = 31;
            this.LTituloUsuarios.Text = "Gestión Usuarios";
            // 
            // PBImagenUsuarios
            // 
            this.PBImagenUsuarios.Image = global::ProyectoTaller.Properties.Resources.UsuarioGrande;
            this.PBImagenUsuarios.Location = new System.Drawing.Point(12, 12);
            this.PBImagenUsuarios.Name = "PBImagenUsuarios";
            this.PBImagenUsuarios.Size = new System.Drawing.Size(65, 67);
            this.PBImagenUsuarios.TabIndex = 30;
            this.PBImagenUsuarios.TabStop = false;
            // 
            // VerUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(887, 507);
            this.Controls.Add(this.LTituloUsuarios);
            this.Controls.Add(this.PBImagenUsuarios);
            this.Name = "VerUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBImagenUsuarios;
        private System.Windows.Forms.Label LTituloUsuarios;
    }
}