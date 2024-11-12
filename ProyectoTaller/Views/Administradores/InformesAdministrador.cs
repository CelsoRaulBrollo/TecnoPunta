using ProyectoTaller.CDatos;
using ProyectoTaller.CNegocio;
using ProyectoTaller.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProyectoTaller.Views.Administradores
{
    public partial class InformesAdministrador : Form
    {
        private MarcaDatos marcaDatos;
        private RolNegocio rolNegocio;
        public InformesAdministrador()
        {
            InitializeComponent();
            inicializarGraficoTorta(); CargarCBInformeUsuClient();
            inicializarGraficoUsuario();
        }

        private void CargarCBInformeUsuClient()
        {
          
            CBInformeUsuClient.Items.Clear();

          
            CBInformeUsuClient.Items.Add("Cantidad de Usuario");
            CBInformeUsuClient.Items.Add("Cantidad de Clientes");

           
            CBInformeUsuClient.SelectedIndex = 0;
        }

        public void inicializarGraficoTorta()
        {
            DateTime fechaDesde = DTPDesdeMarcas.Value.Date;
            DateTime fechaHasta = DTPHastaMarcas.Value.Date;
            cargarGraficoTorta(fechaHasta, fechaDesde);
        }

        public void cargarGraficoTorta(DateTime fechaHasta, DateTime fechaDesde)
        {
            CHMarcasVendidas.Series.Clear();
            
            marcaDatos = new MarcaDatos();
            if (fechaHasta < fechaDesde)
            {
                MessageBox.Show("La fecha 'hasta' debe ser mayor o igual a la fecha 'desde'.");
                return; 
            }
            List<MarcaDTO> marcasVendidas = marcaDatos.buscarMarcasMasVendidaPorFecha(fechaDesde, fechaHasta);

            CHMarcasVendidas.Series.Clear();
            CHMarcasVendidas.Series.Add("MarcasVendidas");
            CHMarcasVendidas.Series["MarcasVendidas"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            CHMarcasVendidas.Series["MarcasVendidas"].Points.Clear();

            foreach (var marca in marcasVendidas)
            {
                CHMarcasVendidas.Series["MarcasVendidas"].Points.AddXY(marca.nombre, marca.cantidad);
            }

            CHMarcasVendidas.Legends[0].Enabled = true;
            

        }
        public void inicializarGraficoUsuario()
        {
            DateTime desde = DTPDesdeCantidadUsuarios.Value;
            DateTime hasta = DTPHastaCantidadUsuarios.Value;
            cargarDatosUsuarios(desde, hasta);
        }
        public void cargarDatosUsuarios(DateTime fechaDesde, DateTime fechaHasta) {
            

            rolNegocio = new RolNegocio();
            List<RolDTO> rolDatos = rolNegocio.generarInfomreUsuario(fechaDesde, fechaHasta);
            if (fechaHasta < fechaDesde)
            {
                MessageBox.Show("La fecha 'Desde' no puede ser mayor que la fecha 'Hasta'.");
                return;
            }
            CHCantidadUsuarios.Series.Clear();
            CHCantidadUsuarios.Legends.Clear();
            CHCantidadUsuarios.Titles.Clear();

            var serie = new Series("Cantidad de Usuarios")
            {
                ChartType = SeriesChartType.Column 
            };

            foreach (var rol in rolDatos)
            {
                serie.Points.AddXY(rol.nombre, rol.cantidad);
            }
            CHCantidadUsuarios.Series.Add(serie);
            LCantidadUsuarios.Text = "Cantidad de Usuarios";

        }

        public void cargarDatosClientes(DateTime fechaDesde, DateTime fechaHasta)
        {
            
            ClienteNegocio clienteNegocio = new ClienteNegocio();

            
            if (fechaHasta < fechaDesde)
            {
                MessageBox.Show("La fecha 'Desde' no puede ser mayor que la fecha 'Hasta'.");
                return;
            }

           
            List<Tuple<string, int>> clienteDatos = clienteNegocio.GenerarInformeClientes(fechaDesde, fechaHasta);

           
            CHCantidadUsuarios.Series.Clear();
            CHCantidadUsuarios.Legends.Clear();
            CHCantidadUsuarios.Titles.Clear();

            
            var serie = new Series("Cantidad de Clientes")
            {
                ChartType = SeriesChartType.Column 
            };

            
            foreach (var cliente in clienteDatos)
            {
                serie.Points.AddXY(cliente.Item1, cliente.Item2); 
            }

            
            CHCantidadUsuarios.Series.Add(serie);
            CHCantidadUsuarios.Titles.Add("Informe de Clientes por Estado");
            LCantidadUsuarios.Text = "Cantidad de Clientes";
        }

        public void cargarDatosClienteGenero(DateTime fechaDesde, DateTime fechaHasta)
        {

        }




        

        private void DTPDesdeMarcas_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaDesde = DTPDesdeMarcas.Value.Date;
            DateTime fechaHasta = DTPHastaMarcas.Value.Date;
            cargarGraficoTorta(fechaHasta, fechaDesde);
        }

        private void DTPHastaMarcas_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaDesde = DTPDesdeMarcas.Value.Date;
            DateTime fechaHasta = DTPHastaMarcas.Value.Date;
            cargarGraficoTorta(fechaHasta, fechaDesde);
        }

        private void BLimpiarFiltros_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Quieres quitar los filtros?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                LimpiarFiltros();

                MessageBox.Show("Filtros borrados.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LimpiarFiltros()
        {
            DTPDesdeCantidadUsuarios.Value = DateTime.Today;
            DTPHastaCantidadUsuarios.Value = DateTime.Today;
            DTPDesdeMarcas.Value = DateTime.Today;
            DTPHastaMarcas.Value = DateTime.Today;
        }

        private void CBInformeUsuClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            DateTime fechaDesde = DTPDesdeCantidadUsuarios.Value;
            DateTime fechaHasta = DTPHastaCantidadUsuarios.Value;

            string seleccion = CBInformeUsuClient.SelectedItem.ToString();
           

            if (seleccion == "Cantidad de Usuario")
            {
                cargarDatosUsuarios(fechaDesde, fechaHasta);
            }
            else if (seleccion == "Cantidad de Clientes")
            {
                cargarDatosClientes(fechaDesde, fechaHasta);
            }
        }

        private void DTPHastaCantidadUsuarios_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaDesde = DTPDesdeCantidadUsuarios.Value;
            DateTime fechaHasta = DTPHastaCantidadUsuarios.Value;
            if(LCantidadUsuarios.Text == "Cantidad de Clientes")
            {
                cargarDatosClientes(fechaDesde, fechaHasta);

            }
            else 
            {
                cargarDatosUsuarios(fechaDesde, fechaHasta);
                
            }

        }

        private void DTPDesdeCantidadUsuarios_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaDesde = DTPDesdeCantidadUsuarios.Value;
            DateTime fechaHasta = DTPHastaCantidadUsuarios.Value;
            if (LCantidadUsuarios.Text == "Cantidad de Clientes")
            {
                cargarDatosClientes(fechaDesde, fechaHasta);
            }
            else
            {
                
                cargarDatosUsuarios(fechaDesde, fechaHasta);
            }
        }



    }
}
