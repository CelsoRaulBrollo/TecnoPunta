using ProyectoTaller.CNegocio;
using System;
using System.Windows.Forms;

namespace ProyectoTaller.Views.Vendedor
{
    public partial class Carrito : Form
    {

        private CarritoNegocio carritoNegocio;
        private int _dniUsuario;
        public Carrito(int dniUsuario)
        {
            InitializeComponent();
            _dniUsuario = dniUsuario;
            cargarCarrito();

        }

        private ConfirmarVenta confirmarVenta;



        public void cargarCarrito()
        {
            carritoNegocio = new CarritoNegocio();
            DGCarrito.DataSource = carritoNegocio.cargarCarito(_dniUsuario).detalles;
            decimal totalFinalizarCompra = carritoNegocio.cargarCarito(_dniUsuario).total;
            TTotalCarrito.Text = totalFinalizarCompra.ToString() + " $";
            DGCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void BFinalizarCompra_Click(object sender, EventArgs e)
        {
            if (confirmarVenta == null || confirmarVenta.IsDisposed)
            {
                confirmarVenta = new ConfirmarVenta(_dniUsuario);
                confirmarVenta.Show();
            }
            else
            {
                confirmarVenta.BringToFront();
            }
        }

        private void DGCarrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            bool eliminado = carritoNegocio.eliminarProducto(selectedRow.Cells["Modelo"].Value.ToString(), _dniUsuario);
            if (eliminado)
            {
                MessageBox.Show("Elemento quitado del carrito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al eliminar el producto al carrito.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cargarCarrito();

        }

        private void BLimpiarCarrito_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Está seguro de que desea limpiar todo el carrito?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                carritoNegocio = new CarritoNegocio();
                bool vaciado = carritoNegocio.vaciarCarrito(_dniUsuario);
                if (vaciado)
                {
                    MessageBox.Show("El carrito ha sido limpiado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarCarrito();
                }

            }
            else
            {
                return;
            }
        }

        private void Carrito_Load(object sender, EventArgs e)
        {

        }
    }
}