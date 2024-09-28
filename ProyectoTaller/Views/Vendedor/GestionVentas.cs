using System;
using System.Windows.Forms;

namespace ProyectoTaller.Views.Vendedor
{
    public partial class GestionVentas : Form
    {
        public GestionVentas()
        {
            InitializeComponent();
        }

        private void BVerDetalle_Click(object sender, EventArgs e)
        {
            VentaDetalle ventana = new VentaDetalle();
            ventana.Show();
        }
    }
}
