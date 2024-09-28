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

        private void BFinalizarCompra_Click(object sender, EventArgs e)
        {
            ConfirmarVenta confirmarVenta = new ConfirmarVenta();

            confirmarVenta.Show();
        }
    }
}
