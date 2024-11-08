using ProyectoTaller.CNegocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProyectoTaller.Views.Gerentes
{
    public partial class ReporteClientes : Form
    {
        private VentaNegocio ventaNegocio;
        public ReporteClientes()
        {
            InitializeComponent();
            cargarDTP();
            DateTime fechaInicio = DTPDesde.Value.Date;  
            DateTime fechaFin = DTPHasta.Value.Date;

            MostrarVentaMediaPorClientePorMes(fechaInicio, fechaFin);

        }

        public void cargarDTP()
        {
            DateTime inicioAño = new DateTime(DateTime.Now.Year, 1, 1);
            DateTime fechaActual = DateTime.Now;

            DTPDesde.Value = inicioAño;
            DTPHasta.Value = fechaActual;
        }


        private void DTPDesde_ValueChanged(object sender, EventArgs e)
        {
            ActualizarGrafico();
        }

        private void DTPHasta_ValueChanged(object sender, EventArgs e)
        {
            ActualizarGrafico();
        }

      
        private void ActualizarGrafico()
        {
           
            DateTime fechaInicio = DTPDesde.Value.Date;  
            DateTime fechaFin = DTPHasta.Value.Date;

           
            if (fechaInicio > fechaFin)
            {
                MessageBox.Show("La fecha de inicio no puede ser posterior a la fecha de fin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            MostrarVentaMediaPorClientePorMes(fechaInicio, fechaFin);
        }


        private void CBNuevoClientes_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (CBNuevoClientes.SelectedItem.ToString() == "Nuevos Clientes")
            {
              
            }
            else if (CBNuevoClientes.SelectedItem.ToString() == "Nuevos Clientes Según Género")
            {
                
            }
        }

        private void MostrarVentaMediaPorClientePorMes(DateTime fechaInicio, DateTime fechaFin)
        {
            ventaNegocio = new VentaNegocio();
            var ventasMensuales = ventaNegocio.ObtenerVentaMediaPorClientePorMes(fechaInicio, fechaFin);

       
            ChartReporteClientes.Series.Clear();
            ChartReporteClientes.Titles.Clear();
            ChartReporteClientes.Legends.Clear();

            var serie = new Series
            {
                Name = "Venta Media",
                ChartType = SeriesChartType.Line,
                IsValueShownAsLabel = true
            };

         
            foreach (var venta in ventasMensuales)
            {
                serie.Points.AddXY($"{venta.Año}-{venta.Mes:D2}", venta.VentaMediaPorCliente);
            }

       
            ChartReporteClientes.Series.Add(serie);

            
            ChartReporteClientes.Titles.Add($"Venta Media por Cliente");
            ChartReporteClientes.Legends.Add(new Legend("Leyenda"));

         
            ChartReporteClientes.Invalidate();
        }

        private void DTPDesde_ValueChanged_1(object sender, EventArgs e)
        {
            ActualizarGrafico();
        }

        private void DTPHasta_ValueChanged_1(object sender, EventArgs e)
        {
            ActualizarGrafico();
        }
    }
}
