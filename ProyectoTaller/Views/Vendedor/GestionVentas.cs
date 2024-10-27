using ProyectoTaller.CNegocio;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoTaller.Views.Vendedor
{
    public partial class GestionVentas : Form
    {
        private VentaNegocio ventaNegocio;
        private int _dniUsuario;
        public GestionVentas(int dniUsuario)
        {
            _dniUsuario = dniUsuario;
            InitializeComponent();
            cargarVentas();
            cargarLabels();
        }

        public void cargarLabels()
        {
            ventaNegocio = new VentaNegocio();
            LBVentasDiaPrint.Text = ventaNegocio.cantidadDeVentasDelDia(_dniUsuario).ToString();
            LImporteTotalPrint.Text = ventaNegocio.montoRecaudadoDelDia(_dniUsuario).ToString();
        } 


        public void cargarVentas()
        {
            ventaNegocio = new VentaNegocio();
            DGVentasVendedor.DataSource = ventaNegocio.buscarVentaPorVendedor(_dniUsuario);
           
            DGVentasVendedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void BVerDetalle_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<VentaDetalles>().Any())
            {
                Application.OpenForms.OfType<VentaDetalles>().First().Activate();
            }
            else
            {
                VentaDetalles ventana = new VentaDetalles(2);
                ventana.Show();
            }
        }
    }
}
