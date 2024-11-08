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


            DateTime fechaInicio = new DateTime(2024, 1, 1);  // 1 de enero de 2024
            DateTime fechaFin = new DateTime(2024, 12, 31);  // 31 de diciembre de 2024

            MostrarVentaMediaPorClientePorMes(fechaInicio, fechaFin);

            CBGeneroReporte.SelectedIndex = 0;

            CBGeneroReporte.SelectedIndexChanged += CBGeneroReporte_SelectedIndexChanged;

        }

        private void CBGeneroReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBGeneroReporte.SelectedItem.ToString() == "Clientes según género")
            {
             
            }
            else if (CBGeneroReporte.SelectedItem.ToString() == "Ventas anuales según género")
            {
               
            }
        }

        

        private void CBNuevoClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica qué opción se seleccionó en el ComboBox
            if (CBNuevoClientes.SelectedItem.ToString() == "Nuevos Clientes")
            {
             
            }
            else if (CBNuevoClientes.SelectedItem.ToString() == "Nuevos Clientes Según Género")
            {
              
            }
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

            // Configurar el gráfico
            ChartReporteClientes.Series.Clear();
            ChartReporteClientes.Titles.Clear();
            ChartReporteClientes.Legends.Clear();

            var serie = new Series
            {
                Name = "Venta Media por Cliente",
                ChartType = SeriesChartType.Line,
                IsValueShownAsLabel = true
            };

            // Agregar los puntos al gráfico mes por mes
            foreach (var venta in ventasMensuales)
            {
                serie.Points.AddXY($"{venta.Año}-{venta.Mes:D2}", venta.VentaMediaPorCliente);
            }

            // Añadir la serie al gráfico
            ChartReporteClientes.Series.Add(serie);

            // Agregar el título y la leyenda
            ChartReporteClientes.Titles.Add($"Venta Media por Cliente ({fechaInicio.Year}-{fechaFin.Year})");
            ChartReporteClientes.Legends.Add(new Legend("Leyenda"));

            // Redibujar el gráfico
            ChartReporteClientes.Invalidate();
        }


    }
}
