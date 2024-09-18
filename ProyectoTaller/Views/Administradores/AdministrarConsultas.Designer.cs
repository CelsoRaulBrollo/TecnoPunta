namespace ProyectoTaller.Views.Administradores
{
    partial class AdministrarConsultas
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
            this.LTituloConsultas = new System.Windows.Forms.Label();
            this.LConsultas = new System.Windows.Forms.Label();
            this.TConsultas = new System.Windows.Forms.TextBox();
            this.BBuscarConsultas = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CIdConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTipoConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBLeidas = new System.Windows.Forms.CheckBox();
            this.CBNoLeidas = new System.Windows.Forms.CheckBox();
            this.BMarcarLeida = new System.Windows.Forms.Button();
            this.PBImagenConsultas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // LTituloConsultas
            // 
            this.LTituloConsultas.AutoSize = true;
            this.LTituloConsultas.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloConsultas.Location = new System.Drawing.Point(84, 12);
            this.LTituloConsultas.Name = "LTituloConsultas";
            this.LTituloConsultas.Size = new System.Drawing.Size(152, 36);
            this.LTituloConsultas.TabIndex = 29;
            this.LTituloConsultas.Text = "Consultas";
            // 
            // LConsultas
            // 
            this.LConsultas.AutoSize = true;
            this.LConsultas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LConsultas.Location = new System.Drawing.Point(335, 43);
            this.LConsultas.Name = "LConsultas";
            this.LConsultas.Size = new System.Drawing.Size(209, 23);
            this.LConsultas.TabIndex = 33;
            this.LConsultas.Text = "Administrar Consultas";
            // 
            // TConsultas
            // 
            this.TConsultas.Location = new System.Drawing.Point(293, 79);
            this.TConsultas.Name = "TConsultas";
            this.TConsultas.Size = new System.Drawing.Size(277, 20);
            this.TConsultas.TabIndex = 34;
            // 
            // BBuscarConsultas
            // 
            this.BBuscarConsultas.Location = new System.Drawing.Point(576, 77);
            this.BBuscarConsultas.Name = "BBuscarConsultas";
            this.BBuscarConsultas.Size = new System.Drawing.Size(75, 23);
            this.BBuscarConsultas.TabIndex = 35;
            this.BBuscarConsultas.Text = "Buscar";
            this.BBuscarConsultas.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIdConsulta,
            this.CUsuario,
            this.CTipoConsulta,
            this.CConsulta,
            this.CEstado,
            this.CFecha});
            this.dataGridView1.Location = new System.Drawing.Point(12, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(863, 375);
            this.dataGridView1.TabIndex = 36;
            // 
            // CIdConsulta
            // 
            this.CIdConsulta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CIdConsulta.HeaderText = "ID Consulta";
            this.CIdConsulta.Name = "CIdConsulta";
            // 
            // CUsuario
            // 
            this.CUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CUsuario.HeaderText = "Usuario";
            this.CUsuario.Name = "CUsuario";
            this.CUsuario.Width = 150;
            // 
            // CTipoConsulta
            // 
            this.CTipoConsulta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CTipoConsulta.HeaderText = "Tipo de Consulta";
            this.CTipoConsulta.Name = "CTipoConsulta";
            this.CTipoConsulta.Width = 130;
            // 
            // CConsulta
            // 
            this.CConsulta.HeaderText = "Consulta";
            this.CConsulta.Name = "CConsulta";
            this.CConsulta.Width = 230;
            // 
            // CEstado
            // 
            this.CEstado.HeaderText = "Estado";
            this.CEstado.Name = "CEstado";
            // 
            // CFecha
            // 
            this.CFecha.HeaderText = "Fecha";
            this.CFecha.Name = "CFecha";
            this.CFecha.Width = 110;
            // 
            // CBLeidas
            // 
            this.CBLeidas.AutoSize = true;
            this.CBLeidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBLeidas.Location = new System.Drawing.Point(91, 95);
            this.CBLeidas.Name = "CBLeidas";
            this.CBLeidas.Size = new System.Drawing.Size(63, 19);
            this.CBLeidas.TabIndex = 37;
            this.CBLeidas.Text = "Leídas";
            this.CBLeidas.UseVisualStyleBackColor = true;
            // 
            // CBNoLeidas
            // 
            this.CBNoLeidas.AutoSize = true;
            this.CBNoLeidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBNoLeidas.Location = new System.Drawing.Point(160, 95);
            this.CBNoLeidas.Name = "CBNoLeidas";
            this.CBNoLeidas.Size = new System.Drawing.Size(78, 19);
            this.CBNoLeidas.TabIndex = 38;
            this.CBNoLeidas.Text = "No leídas";
            this.CBNoLeidas.UseVisualStyleBackColor = true;
            // 
            // BMarcarLeida
            // 
            this.BMarcarLeida.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BMarcarLeida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BMarcarLeida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMarcarLeida.Image = global::ProyectoTaller.Properties.Resources.Check;
            this.BMarcarLeida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BMarcarLeida.Location = new System.Drawing.Point(752, 62);
            this.BMarcarLeida.Name = "BMarcarLeida";
            this.BMarcarLeida.Size = new System.Drawing.Size(123, 52);
            this.BMarcarLeida.TabIndex = 39;
            this.BMarcarLeida.Text = "Marcar Leida";
            this.BMarcarLeida.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BMarcarLeida.UseVisualStyleBackColor = true;
            // 
            // PBImagenConsultas
            // 
            this.PBImagenConsultas.Image = global::ProyectoTaller.Properties.Resources.ConsultasTitulo;
            this.PBImagenConsultas.Location = new System.Drawing.Point(5, 3);
            this.PBImagenConsultas.Name = "PBImagenConsultas";
            this.PBImagenConsultas.Size = new System.Drawing.Size(80, 80);
            this.PBImagenConsultas.TabIndex = 28;
            this.PBImagenConsultas.TabStop = false;
            // 
            // AdministrarConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(887, 507);
            this.Controls.Add(this.BMarcarLeida);
            this.Controls.Add(this.CBNoLeidas);
            this.Controls.Add(this.CBLeidas);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BBuscarConsultas);
            this.Controls.Add(this.TConsultas);
            this.Controls.Add(this.LConsultas);
            this.Controls.Add(this.LTituloConsultas);
            this.Controls.Add(this.PBImagenConsultas);
            this.Name = "AdministrarConsultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdministrarConsultas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenConsultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBImagenConsultas;
        private System.Windows.Forms.Label LTituloConsultas;
        private System.Windows.Forms.Label LConsultas;
        private System.Windows.Forms.TextBox TConsultas;
        private System.Windows.Forms.Button BBuscarConsultas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox CBLeidas;
        private System.Windows.Forms.CheckBox CBNoLeidas;
        private System.Windows.Forms.Button BMarcarLeida;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIdConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTipoConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFecha;
    }
}