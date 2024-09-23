using System;
using System.Collections;
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
            string marca = CBMarca.SelectedItem?.ToString();
            string nombreProducto = TNombreProducto.Text;
            string modelo = TModelo.Text;
            string sistemaOperativo = TSo.Text;
            string almacenamientoTexto = TAlmacenamiento.Text;
            string ramTexto = TRam.Text;
            string estado = CBEstado.SelectedItem?.ToString();
            string stockTexto = TStock.Text;
            string precioTexto = TPrecio.Text;

            // Validaciones
            bool valido = true;

            if (string.IsNullOrEmpty(marca))
            {
                LValiMarca.ForeColor = Color.Red;
                LValiMarca.Text = "Seleccione una Marca.";
                valido = false;
            }
            else
            {
                LValiMarca.Text = string.Empty;
            }

            if (string.IsNullOrWhiteSpace(nombreProducto))
            {
                LValiNombre.ForeColor = Color.Red;
                LValiNombre.Text = "Ingrese el nombre del producto.";
                valido = false;
            }
            else if (nombreProducto.Length < 5)
            {
                LValiNombre.ForeColor = Color.Red;
                LValiNombre.Text = "Al menos 5 caracteres.";
                valido = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(nombreProducto, @"^[a-zA-Z0-9]"))
            {
                LValiNombre.ForeColor = Color.Red;
                LValiNombre.Text = "El Nombre debe contener solo letras y números.";
                valido = false;
            }
            else
            {
                LValiNombre.Text = string.Empty;
            }

            if (string.IsNullOrWhiteSpace(modelo))
            {
                LValiModelo.ForeColor = Color.Red;
                LValiModelo.Text = "Ingrese un modelo.";
                valido = false;
            }
            else if (modelo.Length < 3 || modelo.Length > 12)
            {
                LValiModelo.ForeColor = Color.Red;
                LValiModelo.Text = "Modelo de 3 a 12 caracteres.";
                valido = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(modelo, @"^[a-zA-Z0-9]"))
            {
                LValiModelo.ForeColor = Color.Red;
                LValiModelo.Text = "El modelo debe contener solo letras y números.";
                valido = false;
            }
            else
            {
                LValiModelo.Text = string.Empty;
            }

            if (string.IsNullOrWhiteSpace(sistemaOperativo))
            {
                LValiSo.ForeColor = Color.Red;
                LValiSo.Text = "Ingrese un Sistema Operativo.";
                valido = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(sistemaOperativo, @"^[a-zA-Z0-9]"))
            {
                LValiSo.ForeColor = Color.Red;
                LValiSo.Text = "El S.O debe contener solo letras y números.";
                valido = false;
            }
            else if (sistemaOperativo.Length < 2 || sistemaOperativo.Length > 20)
            {
                LValiSo.ForeColor = Color.Red;
                LValiSo.Text = "S.O de 2 a 20 caracteres.";
                valido = false;
            }
            else
            {
                LValiSo.Text = string.Empty;
            }

            if (string.IsNullOrWhiteSpace(almacenamientoTexto))
            {
                LValiAlmacenamiento.ForeColor = Color.Red;
                LValiAlmacenamiento.Text = "Ingrese un almacenamiento.";
                valido = false;
            }
            else if (!int.TryParse(almacenamientoTexto, out int almacenamiento))
            {
                LValiAlmacenamiento.ForeColor = Color.Red;
                LValiAlmacenamiento.Text = "El almacenamiento debe ser un número entero.";
                valido = false;
            }
            else if (almacenamiento <= 32 || almacenamiento > 1024)
            {
                LValiAlmacenamiento.ForeColor = Color.Red;
                LValiAlmacenamiento.Text = "El almacenamiento debe estar entre 32 y 1024 GB.";
                valido = false;
            }
            else
            {
                LValiAlmacenamiento.Text = string.Empty;
            }

            if (string.IsNullOrWhiteSpace(ramTexto))
            {
                LValiRam.ForeColor = Color.Red;
                LValiRam.Text = "Ingrese una Ram";
                valido = false;
            }
            else if (!int.TryParse(ramTexto, out int ram))
            {
                LValiRam.ForeColor = Color.Red;
                LValiRam.Text = "La Ram debe ser un número entero.";
                valido = false;
            }
            else if (ram <= 1 || ram > 32)
            {
                LValiRam.ForeColor = Color.Red;
                LValiRam.Text = "La Ram debe estar entre 1 y 32 GB.";
                valido = false;
            }
            else
            {
                LValiRam.Text = string.Empty;
            }

            if (string.IsNullOrWhiteSpace(stockTexto))
            {
                LValiStock.ForeColor = Color.Red;
                LValiStock.Text = "Ingrese un stock.";
                valido = false;
            }
            else if (!int.TryParse(stockTexto, out int stock))
            {
                LValiStock.ForeColor = Color.Red;
                LValiStock.Text = "El Stock debe ser un número entero.";
                valido = false;
            }
            else if (stock <= 1 || stock > 1500)
            {
                LValiStock.ForeColor = Color.Red;
                LValiStock.Text = "Stock hasta 1500 unidades.";
                valido = false;
            }
            else
            {
                LValiStock.Text = string.Empty;
            }

            if (string.IsNullOrWhiteSpace(precioTexto))
            {
                LValiPrecio.ForeColor = Color.Red;
                LValiPrecio.Text = "Ingrese un precio.";
                valido = false;
            }
            else if (!decimal.TryParse(precioTexto, out decimal precio))
            {
                LValiPrecio.ForeColor = Color.Red;
                LValiPrecio.Text = "El Precio debe ser un número decimal.";
                valido = false;
            }
            else
            {
                LValiPrecio.Text = string.Empty;
            }

            if (string.IsNullOrEmpty(estado))
            {
                LValiEstado.ForeColor = Color.Red;
                LValiEstado.Text = "Seleccione un Estado.";
                valido = false;
            }
            else
            {
                LValiEstado.Text = string.Empty;
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
                    filaSeleccionada.Cells["CMarca"].Value = CBMarca.SelectedItem.ToString();
                    filaSeleccionada.Cells["CNombre"].Value = TNombreProducto.Text;
                    filaSeleccionada.Cells["CModelo"].Value = TModelo.Text;
                    filaSeleccionada.Cells["CSistemaOperativo"].Value = TSo.Text;
                    filaSeleccionada.Cells["CAlmacenamiento"].Value = TAlmacenamiento.Text;
                    filaSeleccionada.Cells["CRam"].Value = TRam.Text;
                    filaSeleccionada.Cells["CEstado"].Value = CBEstado.SelectedItem.ToString();
                    filaSeleccionada.Cells["CStock"].Value = TStock.Text;
                    filaSeleccionada.Cells["CPrecio"].Value = TPrecio.Text;
                    filaSeleccionada.Cells["CImagen"].Value = PBImagen.Image;

                    LValido.Text = "Producto editado exitosamente.";

                    editando = false;
                }
                else
                {
                    DGProductos.Rows.Add(CBMarca.SelectedItem.ToString(), TNombreProducto.Text, TModelo.Text, TSo.Text, TAlmacenamiento.Text, TRam.Text, TStock.Text, TPrecio.Text, CBEstado.SelectedItem.ToString(), TPrecio.Text, PBImagen.Image);

                    LValido.Text = "Producto agregado exitosamente.";
                }

                CBMarca.SelectedIndex = -1;
                TNombreProducto.Clear();
                TModelo.Clear();
                TAlmacenamiento.Clear();
                TRam.Clear();
                TStock.Clear();
                CBEstado.SelectedIndex = -1;
                TSo.Clear();
                TPrecio.Clear();
                PBImagen.Image = null;
            }
        }

        private void BBorrar_Click(object sender, EventArgs e)
        {
            CBMarca.SelectedIndex = -1;
            TNombreProducto.Clear();
            TModelo.Clear();
            TSo.Clear();
            TAlmacenamiento.Clear();
            TRam.Clear();
            CBEstado.SelectedIndex = -1;
            TStock.Clear();
            TPrecio.Clear();
            PBImagen.Image = null;

            LValido.Text = string.Empty;
            LimpiarMensajesDeValidacion();
        }

        private void LimpiarMensajesDeValidacion()
        {
            LValiMarca.Text = string.Empty;
            LValiNombre.Text = string.Empty;
            LValiModelo.Text = string.Empty;
            LValiSo.Text = string.Empty;
            LValiAlmacenamiento.Text = string.Empty;
            LValiRam.Text = string.Empty;
            LValiEstado.Text = string.Empty;
            LValiStock.Text = string.Empty;
            LValiPrecio.Text = string.Empty;
            LValiImagen.Text = string.Empty;
        }

        private void CBMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBMarca.SelectedIndex != -1)
            {
                LValiMarca.Text = string.Empty;
            }
        }

        private void TNombreProducto_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TNombreProducto.Text))
            {
                LValiNombre.Text = string.Empty;
            }
        }

        private void TModeloTextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TModelo.Text))
            {
                LModelo.Text = string.Empty;
            }
        }

        private void TSo_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TSo.Text))
            {
                LSo.Text = string.Empty;
            }
        }

        private void TAlmacenamiento_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TAlmacenamiento.Text))
            {
                LAlmacenamiento.Text = string.Empty;
            }
        }

        private void TRam_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TRam.Text))
            {
                LRam.Text = string.Empty;
            }
        }

        private void TPrecio_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(TModelo.Text, out decimal precio) && precio > 0)
            {
                LValiModelo.Text = string.Empty;
            }
        }

        private void TStock_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(TSo.Text, out int stock) && stock >= 0)
            {
                LValiStock.Text = string.Empty;
            }
        }

        private void CBEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBEstado.SelectedIndex != -1)
            {
                LValiEstado.Text = string.Empty;
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

                CBMarca.SelectedItem = filaSeleccionada.Cells["CMarca"].Value.ToString();
                TNombreProducto.Text = filaSeleccionada.Cells["CNombre"].Value.ToString();
                TModelo.Text = filaSeleccionada.Cells["CModelo"].Value.ToString();
                TSo.Text = filaSeleccionada.Cells["CSistemaOperativo"].Value.ToString();
                TAlmacenamiento.Text = filaSeleccionada.Cells["CAlmacenamiento"].Value.ToString();
                TRam.Text = filaSeleccionada.Cells["CRam"].Value.ToString();
                TStock.Text = filaSeleccionada.Cells["CStock"].Value.ToString();
                TPrecio.Text = filaSeleccionada.Cells["CPrecio"].Value.ToString();
                CBEstado.SelectedItem = filaSeleccionada.Cells["CEstado"].Value.ToString();

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

        private void AgregarProducto_Load(object sender, EventArgs e)
        {

        }
    }
}