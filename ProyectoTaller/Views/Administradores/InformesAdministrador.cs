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
            inicializarGraficoTorta();
            inicializarGraficoUsuario();
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

        }

      

      

        private void DTPHastaCantidadUsuarios_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DTPDesdeCantidadUsuarios_ValueChanged(object sender, EventArgs e)
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
    }
}
