using System;
using System.Linq;
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
            if (Application.OpenForms.OfType<VentaDetalle>().Any())
            {
                Application.OpenForms.OfType<VentaDetalle>().First().Activate();
            }
            else
            {
                VentaDetalle ventana = new VentaDetalle();
                ventana.Show();
            }
        }
    }
}
