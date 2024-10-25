using ProyectoTaller.CModelos;
using ProyectoTaller.CNegocio;
using ProyectoTaller.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static ProyectoTaller.CNegocio.CarritoNegocio;

namespace ProyectoTaller.Views.Vendedor
{
    public partial class Carrito : Form
    {
        private CarritoNegocio carritoNegocio;
        private ProductoDatos productoDatos;
        private List<CarritoDetalleDTO> detallesCarrito;
        private int _dniVendedor;

        public Carrito(int dniVendedor)
        {
            InitializeComponent();
            _dniVendedor = dniVendedor;
            detallesCarrito = new List<CarritoDetalleDTO>();
            productoDatos = new ProductoDatos();
            cargarCarrito();
            this.Load += new EventHandler(Carrito_Load);
        }

        private void Carrito_Load(object sender, EventArgs e)
        {
            cargarCarrito();
        }

        public void cargarCarrito()
        {
            carritoNegocio = new CarritoNegocio();
            CarritoDTO carritoRespuesta = carritoNegocio.cargarCarrito(_dniVendedor);

            detallesCarrito = carritoRespuesta.detalles;

            ActualizarDataGridView();
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            string modeloSeleccionado = txtModelo.Text.Trim();
            int cantidad = (int)numericUpDownCantidad.Value;

            Producto productoSeleccionado = productoDatos.ObtenerProductoPorModelo(modeloSeleccionado);

            if (productoSeleccionado == null)
            {
                MessageBox.Show("El modelo ingresado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool agregado = carritoNegocio.agregarProducto(productoSeleccionado, cantidad, _dniVendedor);

            if (agregado)
            {
                MessageBox.Show("Producto agregado al carrito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarCarrito();
            }
            else
            {
                MessageBox.Show("Error al agregar el producto al carrito.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ActualizarDataGridView()
        {
            DGCarrito.DataSource = null;
            DGCarrito.DataSource = detallesCarrito;

            DGCarrito.Columns["Modelo"].HeaderText = "Modelo";
            DGCarrito.Columns["Descripcion"].HeaderText = "Descripción";
            DGCarrito.Columns["Cantidad"].HeaderText = "Cantidad";
            DGCarrito.Columns["Precio"].HeaderText = "Precio";

            if (!DGCarrito.Columns.Contains("Subtotal"))
            {
                DataGridViewTextBoxColumn columnaSubtotal = new DataGridViewTextBoxColumn
                {
                    Name = "Subtotal",
                    HeaderText = "Subtotal",
                    ReadOnly = true
                };
                DGCarrito.Columns.Add(columnaSubtotal);
            }

            foreach (DataGridViewRow fila in DGCarrito.Rows)
            {
                CarritoDetalleDTO producto = (CarritoDetalleDTO)fila.DataBoundItem;
                fila.Cells["Subtotal"].Value = producto.Subtotal;
            }
        }

        private void BFinalizarCompra_Click(object sender, EventArgs e)
        {
            ConfirmarVenta confirmarVenta = new ConfirmarVenta();
            confirmarVenta.Show();
        }

        private void DGCarrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (DGCarrito.DataSource != null && DGCarrito.DataSource is List<CarritoDetalleDTO>)
                {
                    CarritoDetalleDTO productoSeleccionado = detallesCarrito[e.RowIndex];

                    MessageBox.Show($"Modelo: {productoSeleccionado.Modelo}\nDescripción: {productoSeleccionado.Descripcion}\nCantidad: {productoSeleccionado.cantidad}\nPrecio: {productoSeleccionado.precio:C}\nSubtotal: {productoSeleccionado.Subtotal:C}", "Detalles del Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BQuitar_Click(object sender, EventArgs e)
        {
            if (DGCarrito.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una fila para poder quitar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataGridViewRow selectedRow = DGCarrito.SelectedRows[0];

            carritoNegocio = new CarritoNegocio();
            bool eliminado = carritoNegocio.eliminarProducto(selectedRow.Cells["Modelo"].Value.ToString(), _dniVendedor);
            if (eliminado)
            {
                MessageBox.Show("Elemento quitado del carrito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al eliminar el producto del carrito.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cargarCarrito();
        }

        private void BLimpiarCarrito_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Está seguro de que desea limpiar todo el carrito?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                carritoNegocio = new CarritoNegocio();
                bool vaciado = carritoNegocio.vaciarCarrito(_dniVendedor);
                if (vaciado)
                {
                    MessageBox.Show("El carrito ha sido limpiado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarCarrito();
                }
            }
        }
    }
}
