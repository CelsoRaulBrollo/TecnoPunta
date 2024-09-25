namespace ProyectoTaller.Views.Vendedor
{
    partial class InformesVendedor
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
            this.PBImagenInformeVendedor = new System.Windows.Forms.PictureBox();
            this.LTituloInformeVendedor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenInformeVendedor)).BeginInit();
            this.SuspendLayout();
            // 
            // PBImagenInformeVendedor
            // 
            this.PBImagenInformeVendedor.Image = global::ProyectoTaller.Properties.Resources.informe_titulo;
            this.PBImagenInformeVendedor.Location = new System.Drawing.Point(12, 12);
            this.PBImagenInformeVendedor.Name = "PBImagenInformeVendedor";
            this.PBImagenInformeVendedor.Size = new System.Drawing.Size(65, 67);
            this.PBImagenInformeVendedor.TabIndex = 30;
            this.PBImagenInformeVendedor.TabStop = false;
            // 
            // LTituloInformeVendedor
            // 
            this.LTituloInformeVendedor.AutoSize = true;
            this.LTituloInformeVendedor.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloInformeVendedor.Location = new System.Drawing.Point(80, 13);
            this.LTituloInformeVendedor.Name = "LTituloInformeVendedor";
            this.LTituloInformeVendedor.Size = new System.Drawing.Size(284, 36);
            this.LTituloInformeVendedor.TabIndex = 31;
            this.LTituloInformeVendedor.Text = "Informes Vendedor";
            // 
            // InformesVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(887, 507);
            this.Controls.Add(this.LTituloInformeVendedor);
            this.Controls.Add(this.PBImagenInformeVendedor);
            this.Name = "InformesVendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InformesVendedor";
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenInformeVendedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBImagenInformeVendedor;
        private System.Windows.Forms.Label LTituloInformeVendedor;
    }
}