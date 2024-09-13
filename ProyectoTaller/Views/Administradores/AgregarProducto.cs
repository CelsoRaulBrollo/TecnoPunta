using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller.Views.Administradores
{
    public partial class AgregarProducto : Form
    {
        public AgregarProducto()
        {
            InitializeComponent();
        }

        // Evento del botón "Agregar"
        private void BAgregar_Click(object sender, EventArgs e)
        {
            string nombreProducto = TNombreProducto.Text;
            string precioTexto = TPrecio.Text;
            string stockTexto = TStock.Text;
            string categoria = CBCategoria.SelectedItem?.ToString();

            // Validaciones
            bool valido = true;

            if (string.IsNullOrWhiteSpace(nombreProducto))
            {
                LValiNombre.Text = "Ingrese el nombre del producto.";
                valido = false;
            }

            if (string.IsNullOrWhiteSpace(precioTexto) || !decimal.TryParse(precioTexto, out decimal precio) || precio <= 0)
            {
                LValiPrecio.Text = "Ingrese un precio válido.";
                LValiPrecio.ForeColor = Color.Red;
                valido = false;
            }

            if (string.IsNullOrWhiteSpace(stockTexto) || !int.TryParse(stockTexto, out int stock) || stock < 0)
            {
                LValiStock.Text = "Ingrese un stock válido.";
                LValiStock.ForeColor = Color.Red;
                valido = false;
            }

            if (string.IsNullOrEmpty(categoria))
            {
                LValiCate.Text = "Seleccione una categoría.";
                LValiCate.ForeColor = Color.Red;
                valido = false;
            }

            // Validación de la imagen en el PictureBox
            if (PBImagen.Image == null)
            {
                LValiImagen.Text = "Por favor, agregue una imagen.";
                LValiImagen.ForeColor = Color.Red;
                valido = false;
            }

            if (valido)
            {
                LValido.Text = "Producto agregado exitosamente.";
                LValido.ForeColor = Color.Green;
            }
        }

        private void BBorrar_Click(object sender, EventArgs e)
        {
            TNombreProducto.Clear();
            TPrecio.Clear();
            TStock.Clear();
            CBCategoria.SelectedIndex = -1;
            PBImagen.Image = null;

            LValido.Text = string.Empty;
            LimpiarMensajesDeValidacion();
        }

        private void LimpiarMensajesDeValidacion()
        {
            LValiNombre.Text = string.Empty;
            LValiPrecio.Text = string.Empty;
            LValiStock.Text = string.Empty;
            LValiCate.Text = string.Empty;
            LValiImagen.Text = string.Empty;
        }

        private void TNombreProducto_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TNombreProducto.Text))
            {
                LValiNombre.Text = string.Empty;
            }
        }

        private void TPrecio_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(TPrecio.Text, out decimal precio) && precio > 0)
            {
                LValiPrecio.Text = string.Empty;
            }
        }

        private void TStock_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(TStock.Text, out int stock) && stock >= 0)
            {
                LValiStock.Text = string.Empty;
            }
        }

        private void CBCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBCategoria.SelectedIndex != -1)
            {
                LValiCate.Text = string.Empty;
            }
        }

        private void PBImagen_Click(object sender, EventArgs e)
        {
        }

        // Evento del botón "Salir"
        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Evento del botón "Agregar Imagen"
        private void BAgregarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Seleccione una imagen",
                Filter = "Archivos de imagen (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg;*.jpeg;*.png;*.bmp"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PBImagen.Image = Image.FromFile(openFileDialog.FileName);

                PBImagen.SizeMode = PictureBoxSizeMode.Zoom;

                LValiImagen.Text = string.Empty;
            }
        }
    }
}