using System;
using System.Drawing;
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
            LimpiarMensajesDeValidacion();
            BAgregar.Text = "Agregar";

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

            if (valido)
            {
                LimpiarMensajesDeValidacion();

                if (editando)
                {
                    if (filaSeleccionadaIndex >= 0)
                    {
                        DGProductos.Rows[filaSeleccionadaIndex].Cells["CMarca"].Value = CBMarca.SelectedItem.ToString();
                        DGProductos.Rows[filaSeleccionadaIndex].Cells["CNombre"].Value = TNombreProducto.Text;
                        DGProductos.Rows[filaSeleccionadaIndex].Cells["CModelo"].Value = TModelo.Text;
                        DGProductos.Rows[filaSeleccionadaIndex].Cells["CSistemaOperativo"].Value = TSo.Text;
                        DGProductos.Rows[filaSeleccionadaIndex].Cells["CAlmacenamiento"].Value = TAlmacenamiento.Text;
                        DGProductos.Rows[filaSeleccionadaIndex].Cells["CRam"].Value = TRam.Text;
                        DGProductos.Rows[filaSeleccionadaIndex].Cells["CEstado"].Value = CBEstado.SelectedItem.ToString();
                        DGProductos.Rows[filaSeleccionadaIndex].Cells["CStock"].Value = TStock.Text;
                        DGProductos.Rows[filaSeleccionadaIndex].Cells["CPrecio"].Value = TPrecio.Text;

                        LimpiarMensajesDeValidacion();
                        LValido.Text = "Producto editado exitosamente.";

                        editando = false;
                        filaSeleccionadaIndex = -1;
                    }
                }
                else
                {
                    if (!ValidarModelo(TModelo.Text))
                    {
                        return;
                    }

                    DGProductos.Rows.Add(CBMarca.SelectedItem.ToString(), TNombreProducto.Text, TModelo.Text, TSo.Text, TAlmacenamiento.Text, TRam.Text, TStock.Text, TPrecio.Text, CBEstado.SelectedItem.ToString(), TPrecio.Text);

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
            }
        }

        private bool ValidarModelo(string modelo)
        {
            int filaSeleccionadaIndex = DGProductos.SelectedCells.Count > 0
                ? DGProductos.SelectedCells[0].RowIndex
                : -1;

            foreach (DataGridViewRow fila in DGProductos.Rows)
            {
                if (fila.Index != filaSeleccionadaIndex &&
                    fila.Cells["CModelo"].Value != null &&
                    fila.Cells["CModelo"].Value.ToString() == modelo)
                {
                    LValiModelo.ForeColor = Color.Red;
                    LValiModelo.Text = "El Modelo ya está registrado.";
                    return false;
                }
            }

            LValiModelo.Text = string.Empty;
            return true;
        }

        private void BBorrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea borrar todos los datos?", "Confirmar Borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                if (editando)
                {
                    CBMarca.SelectedIndex = -1;
                    TNombreProducto.Clear();
                    TSo.Clear();
                    TAlmacenamiento.Clear();
                    TRam.Clear();
                    CBEstado.SelectedIndex = -1;
                    TStock.Clear();
                    TPrecio.Clear();
                }
                else
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
                }

                LValido.Text = string.Empty;
                LimpiarMensajesDeValidacion();
            }
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

        private void CBEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBEstado.SelectedIndex != -1)
            {
                LValiEstado.Text = string.Empty;
            }
        }

        // Evento del botón "Salir"
        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BEditar_Click(object sender, EventArgs e)
        {
            LimpiarMensajesDeValidacion();

            if (DGProductos.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea editar el producto seleccionado?", "Confirmar edición", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (result == DialogResult.Yes)
                {
                    filaSeleccionadaIndex = DGProductos.SelectedRows[0].Index;

                    CBMarca.SelectedItem = DGProductos.Rows[filaSeleccionadaIndex].Cells["CMarca"].Value.ToString();
                    TNombreProducto.Text = DGProductos.Rows[filaSeleccionadaIndex].Cells["CNombre"].Value.ToString();
                    TModelo.Text = DGProductos.Rows[filaSeleccionadaIndex].Cells["CModelo"].Value.ToString();
                    TSo.Text = DGProductos.Rows[filaSeleccionadaIndex].Cells["CSistemaOperativo"].Value.ToString();
                    TAlmacenamiento.Text = DGProductos.Rows[filaSeleccionadaIndex].Cells["CAlmacenamiento"].Value.ToString();
                    TRam.Text = DGProductos.Rows[filaSeleccionadaIndex].Cells["CRam"].Value.ToString();
                    TStock.Text = DGProductos.Rows[filaSeleccionadaIndex].Cells["CStock"].Value.ToString();
                    TPrecio.Text = DGProductos.Rows[filaSeleccionadaIndex].Cells["CPrecio"].Value.ToString();
                    CBEstado.SelectedItem = DGProductos.Rows[filaSeleccionadaIndex].Cells["CEstado"].Value.ToString();

                    TModelo.ReadOnly = true;
                    TModelo.BackColor = Color.LightGray;
                    editando = true;

                    BAgregar.Text = "Modificar";
                }
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
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar el producto seleccionado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in DGProductos.SelectedRows)
                    {
                        if (!row.IsNewRow)
                        {
                            MessageBox.Show("Producto eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void TBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            string filtro = TBuscarProducto.Text.ToLower();
            foreach (DataGridViewRow fila in DGProductos.Rows)
            {
                if (fila.Cells["CNombre"].Value != null)
                {
                    string nombreProducto = fila.Cells["CNombre"].Value.ToString().ToLower();
                    string modeloProducto = fila.Cells["CModelo"].Value.ToString().ToLower();
                    string marcaProducto = fila.Cells["CMarca"].Value.ToString().ToLower();
                    string soProducto = fila.Cells["CSistemaOperativo"].Value.ToString().ToLower();

                    if (nombreProducto.Contains(filtro) || modeloProducto.Contains(filtro) || marcaProducto.Contains(filtro) || soProducto.Contains(filtro))
                    {
                        fila.Visible = true;
                    }
                    else
                    {
                        fila.Visible = false;
                    }
                }
            }
        }

        private void AgregarProducto_Load(object sender, EventArgs e)
        {
            DGProductos.Rows.Add("Samsung", "Galaxy S21", "SM-G991B", "Android 14", "128", "8", "50", "799.99", "Nuevo");
            DGProductos.Rows.Add("Apple", "iPhone 13", "A2633", "iOS 16", "256", "4", "30", "1099.99", "Nuevo");
            DGProductos.Rows.Add("Xiaomi", "Mi 11", "M2011K2C", "Android 11", "128", "8", "20", "699.99", "Nuevo");
            DGProductos.Rows.Add("LG", "V60", "LM-V600", "Android", "128", "8", "10", "599.99", "Usado");
            DGProductos.Rows.Add("Motorola", "G7", "XT1962", "Android", "64", "4", "15", "399.99", "Usado");
            DGProductos.Rows.Add("Apple", "iPhone 12", "A2255", "iOS 15", "256", "4", "30", "1099.99", "Reacondicionado");
        }

        private void CBNuevo_CheckedChanged(object sender, EventArgs e)
        {
            // Desmarcar otros CheckBoxes si CBNuevo está seleccionado
            if (CBNuevo.Checked)
            {
                CBReacondicionado.Checked = false;
                CBUsado.Checked = false;
            }

            FiltrarPorEstado();
        }

        private void CBReacondicionado_CheckedChanged(object sender, EventArgs e)
        {
            // Desmarcar otros CheckBoxes si CBReacondicionado está seleccionado
            if (CBReacondicionado.Checked)
            {
                CBNuevo.Checked = false;
                CBUsado.Checked = false;
            }

            FiltrarPorEstado();
        }

        private void CBUsado_CheckedChanged(object sender, EventArgs e)
        {
            // Desmarcar otros CheckBoxes si CBUsado está seleccionado
            if (CBUsado.Checked)
            {
                CBNuevo.Checked = false;
                CBReacondicionado.Checked = false;
            }

            FiltrarPorEstado();
        }

        private void FiltrarPorEstado()
        {
            bool hayFiltroActivo = CBNuevo.Checked || CBReacondicionado.Checked || CBUsado.Checked;

            foreach (DataGridViewRow fila in DGProductos.Rows)
            {
                if (!fila.IsNewRow)
                {
                    if (!hayFiltroActivo)
                    {
                        fila.Visible = true;
                    }
                    else if (CBNuevo.Checked && fila.Cells["CEstado"].Value.ToString() == "Nuevo")
                    {
                        fila.Visible = true;
                    }
                    else if (CBReacondicionado.Checked && fila.Cells["CEstado"].Value.ToString() == "Reacondicionado")
                    {
                        fila.Visible = true;
                    }
                    else if (CBUsado.Checked && fila.Cells["CEstado"].Value.ToString() == "Usado")
                    {
                        fila.Visible = true;
                    }
                    else
                    {
                        fila.Visible = false;
                    }
                }
            }
        }
    }
}