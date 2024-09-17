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
        private bool editando = false;
        private int filaSeleccionadaIndex = -1;

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
                LValiNombre.ForeColor = Color.Red;
                LValiNombre.Text = "Ingrese el nombre del producto.";
                valido = false;
            }
            else
            {
                LValiNombre.Text = string.Empty;
            }

            if (string.IsNullOrWhiteSpace(precioTexto) || !decimal.TryParse(precioTexto, out decimal precio) || precio <= 0)
            {
                LValiPrecio.ForeColor = Color.Red;
                LValiPrecio.Text = "Ingrese un precio válido.";
                valido = false;
            }
            else
            {
                LValiPrecio.Text = string.Empty;
            }

            if (string.IsNullOrWhiteSpace(stockTexto) || !int.TryParse(stockTexto, out int stock) || stock < 0)
            {
                LValiStock.ForeColor = Color.Red;
                LValiStock.Text = "Ingrese un stock válido.";
                valido = false;
            }
            else
            {
                LValiStock.Text = string.Empty;
            }

            if (string.IsNullOrEmpty(categoria))
            {
                LValiCate.ForeColor = Color.Red;
                LValiCate.Text = "Seleccione una categoría.";
                valido = false;
            }
            else
            {
                LValiCate.Text = string.Empty;
            }

            if (PBImagen.Image == null)
            {
                LValiImagen.ForeColor = Color.Red;
                LValiImagen.Text = "Por favor, agregue una imagen.";
                valido = false;
            }
            else
            {
                LValiImagen.Text = string.Empty;
            }

            if (valido)
            {
                LimpiarMensajesDeValidacion();

                if (editando)
                {
                    DataGridViewRow filaSeleccionada = DGProductos.Rows[filaSeleccionadaIndex];
                    filaSeleccionada.Cells["CNombre"].Value = TNombreProducto.Text;
                    filaSeleccionada.Cells["CPrecio"].Value = TPrecio.Text;
                    filaSeleccionada.Cells["CStock"].Value = TStock.Text;
                    filaSeleccionada.Cells["CCategoria"].Value = CBCategoria.SelectedItem.ToString();
                    filaSeleccionada.Cells["CImagen"].Value = PBImagen.Image;

                    LValido.Text = "Producto editado exitosamente.";

                    editando = false;
                }
                else
                {
                    DGProductos.Rows.Add(TNombreProducto.Text, TPrecio.Text, CBCategoria.SelectedItem.ToString(), TStock.Text, PBImagen.Image);

                    LValido.Text = "Producto agregado exitosamente.";
                }

                TNombreProducto.Clear();
                TPrecio.Clear();
                TStock.Clear();
                CBCategoria.SelectedIndex = -1;
                PBImagen.Image = null;
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

        private void BEditar_Click(object sender, EventArgs e)
        {
            if (DGProductos.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = DGProductos.SelectedRows[0];
                filaSeleccionadaIndex = filaSeleccionada.Index;

                TNombreProducto.Text = filaSeleccionada.Cells["CNombre"].Value.ToString();
                TPrecio.Text = filaSeleccionada.Cells["CPrecio"].Value.ToString();
                TStock.Text = filaSeleccionada.Cells["CStock"].Value.ToString();
                CBCategoria.SelectedItem = filaSeleccionada.Cells["CCategoria"].Value.ToString();

                if (filaSeleccionada.Cells["CImagen"].Value is Image imagen)
                {
                    PBImagen.Image = imagen;
                }

                editando = true;
            }
            else
            {
                MessageBox.Show("Seleccione una fila para editar.", "Error de edición", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            if (DGProductos.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar la fila seleccionada?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in DGProductos.SelectedRows)
                    {
                        if (!row.IsNewRow)
                        {
                            DGProductos.Rows.Remove(row);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar.", "Error de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}