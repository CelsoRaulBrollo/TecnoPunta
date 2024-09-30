using System;
using System.Windows.Forms;

namespace ProyectoTaller.Views.Vendedor
{
    public partial class Carrito : Form
    {
        public Carrito()
        {
            InitializeComponent();
        }

        private ConfirmarVenta confirmarVenta;

        private void BFinalizarCompra_Click(object sender, EventArgs e)
        {
            if (confirmarVenta == null || confirmarVenta.IsDisposed)
            {
                confirmarVenta = new ConfirmarVenta();
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

            foreach (DataGridViewRow row in DGCarrito.SelectedRows)
            {
                DGCarrito.Rows.Remove(row);
            }

            MessageBox.Show("Elemento quitado del carrito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BLimpiarCarrito_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Está seguro de que desea limpiar todo el carrito?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                DGCarrito.Rows.Clear();

                MessageBox.Show("El carrito ha sido limpiado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return;
            }
        }
    }
}
