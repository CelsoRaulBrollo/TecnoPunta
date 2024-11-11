using ProyectoTaller.CNegocio;
using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProyectoTaller.Views.Gerentes
{
    public partial class ReporteVentas : Form
    {
        private VentaNegocio ventaNegocio;

        private string[] nombresMeses = new string[]
            {
                "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio",
                "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"
            };

        public ReporteVentas()
        {
            InitializeComponent();
            cargarGraficos(); cargarFechas();
        }

        public void cargarFechas()
        {
            DateTime inicioAño = new DateTime(DateTime.Now.Year, 1, 1);
            DateTime fechaActual = DateTime.Now;

            DTMDesdeReporteDeVentas.Value = inicioAño;  
            DTMHastaReporteDeVentas.Value = fechaActual;
        }


        public void cargarGraficos()
        {
            CargarDatosGraficoRecaudacion();
            CargarDatosGraficoCantidad();
        }

        private void CargarDatosGraficoRecaudacion()
        {
            DateTime inicioAño = new DateTime(DateTime.Now.Year, 1, 1);
            DateTime fechaActual = DateTime.Now;

         

            ventaNegocio = new VentaNegocio();
            var ventasPorMes = ventaNegocio.ObtenerVentasMensuales(inicioAño, fechaActual);

        
            CHRecaudacion.Series.Clear();
            CHRecaudacion.ChartAreas.Clear();

            ChartArea chartArea = new ChartArea();
            CHRecaudacion.ChartAreas.Add(chartArea);

         
            Series ventasSeries = new Series
            {
                Name = "Ventas Totales", 
                IsVisibleInLegend = false, 
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.String, 
                YValueType = ChartValueType.Double 
            };

            // Añadir la serie al gráfico
            CHRecaudacion.Series.Add(ventasSeries);

         
            foreach (var venta in ventasPorMes)
            {
                
                string mesAnio = $"{venta.MesNombre}"; 

             
                ventasSeries.Points.AddXY(mesAnio, venta.TotalVentas);
            }

       
            CHRecaudacion.ChartAreas[0].AxisY.Title = "Total Ventas (en $)";

     
            CHRecaudacion.Invalidate();
        }

        private void CargarDatosGraficoCantidad()
        {
            DateTime inicioAño = new DateTime(DateTime.Now.Year, 1, 1);
            DateTime fechaActual = DateTime.Now;

           

            ventaNegocio = new VentaNegocio();
            var ventasPorMes = ventaNegocio.ObtenerCantidadVentasMensuales(inicioAño, fechaActual);

          
            CHVentasRealizadas.Series.Clear();
            CHVentasRealizadas.ChartAreas.Clear();

        
            ChartArea chartArea = new ChartArea();
            CHVentasRealizadas.ChartAreas.Add(chartArea);

     
            Series cantidadSeries = new Series
            {
                Name = "Cantidad Vendida", 
                IsVisibleInLegend = false, 
                ChartType = SeriesChartType.Column,  
                XValueType = ChartValueType.String, 
                YValueType = ChartValueType.Int32  
            };

         
            CHVentasRealizadas.Series.Add(cantidadSeries);

           
            foreach (var venta in ventasPorMes)
            {
                string mesNombre = nombresMeses[venta.Mes - 1];  
                string mesAnio = $"{mesNombre}";  

                cantidadSeries.Points.AddXY(mesAnio, venta.TotalCantidad); 
            }

            
            CHVentasRealizadas.ChartAreas[0].AxisY.Title = "Cantidad Vendida (Productos)";

          
            CHVentasRealizadas.Invalidate();  
        }




        private void UpdateControls()
        {
        
            bool isAnualChecked = CAAnualReporteVentas.Checked;
            bool isMensualChecked = CAMensualReporteVentas.Checked;
            bool isDiarioChecked = CADiarioReporteVentas.Checked;

            

            if (isAnualChecked)
            {
                CAMensualReporteVentas.Enabled = false;
                CADiarioReporteVentas.Enabled = false;
            }
            else if (isMensualChecked)
            {
                CAAnualReporteVentas.Enabled = false;
                CADiarioReporteVentas.Enabled = false;
            }
            else if (isDiarioChecked)
            {
                CAAnualReporteVentas.Enabled = false;
                CAMensualReporteVentas.Enabled = false;
            }
            else
            {
            
                CAMensualReporteVentas.Enabled = true;
                CAAnualReporteVentas.Enabled = true;
                CADiarioReporteVentas.Enabled = true;
            }
        }

        private void UpdateChartRecaudacion()
        {
            
            CHRecaudacion.Series.Clear();
            CHRecaudacion.ChartAreas[0].AxisX.Title = "";
            CHRecaudacion.ChartAreas[0].AxisY.Title = "";

          
            if (CAAnualReporteVentas.Checked)
            {
                ventaNegocio = new VentaNegocio();
                var ventasAnuales = ventaNegocio.ObtenerVentasAnuales(DTMDesdeReporteDeVentas.Value, DTMHastaReporteDeVentas.Value);

                if (ventasAnuales.Count == 0)
                {
                    
                    MessageBox.Show("No se encontraron ventas anuales para el rango seleccionado.");
                    cargarGraficos();
                    return;
                }

                var serieAnual = new Series("Ventas Anuales")
                {
                    ChartType = SeriesChartType.Column,  
                    BorderWidth = 2
                };
                serieAnual.IsVisibleInLegend = false;
              
                foreach (var venta in ventasAnuales)
                {
                    serieAnual.Points.AddXY(venta.Año, venta.TotalVentas); 
                }

                CHRecaudacion.Series.Add(serieAnual);

            
                CHRecaudacion.ChartAreas[0].AxisX.Title = "Año";
                CHRecaudacion.ChartAreas[0].AxisY.Title = "Total Ventas";

            }
            else if (CAMensualReporteVentas.Checked)
            {
                ventaNegocio = new VentaNegocio();
                var ventasMensuales = ventaNegocio.ObtenerVentasMensuales(DTMDesdeReporteDeVentas.Value, DTMHastaReporteDeVentas.Value);

                if (ventasMensuales.Count == 0)
                {
                    MessageBox.Show("No se encontraron ventas mensuales para el rango seleccionado.");
                    cargarGraficos();
                    return;
                }

                var serieMensual = new Series("Ventas Mensuales")
                {
                    ChartType = SeriesChartType.Line, 
                    BorderWidth = 3
                };
                serieMensual.IsVisibleInLegend = false;

     
                foreach (var venta in ventasMensuales)
                {
                    serieMensual.Points.AddXY(venta.MesNombre, venta.TotalVentas);  
                }

                CHRecaudacion.Series.Add(serieMensual);

                // Configurar los ejes
                CHRecaudacion.ChartAreas[0].AxisX.Title = "Mes";
                CHRecaudacion.ChartAreas[0].AxisY.Title = "Total Ventas";
            }
            else if (CADiarioReporteVentas.Checked)
            {
                ventaNegocio = new VentaNegocio();
                var ventasDiarias = ventaNegocio.ObtenerVentasDiarias(DTMDesdeReporteDeVentas.Value, DTMHastaReporteDeVentas.Value);

                if (ventasDiarias.Count == 0)
                {
                    MessageBox.Show("No se encontraron ventas diarias para el rango seleccionado.");
                    cargarGraficos();
                    return;
                }


                
                var serieDiaria = new Series("Ventas Diarias")
                {
                    ChartType = SeriesChartType.Line,  
                    BorderWidth = 3
                };

                serieDiaria.IsVisibleInLegend = false;

                
                foreach (var venta in ventasDiarias)
                {
                    serieDiaria.Points.AddXY(venta.Fecha.ToString("dd/MM"), venta.TotalVentas);  
                }

                CHRecaudacion.Series.Add(serieDiaria);

               
                CHRecaudacion.ChartAreas[0].AxisX.Title = "Fecha";
                CHRecaudacion.ChartAreas[0].AxisY.Title = "Total Ventas";
            }

           
            CHRecaudacion.Invalidate();
        }

        private void UpdateChartCantidad()
        {
            
            CHVentasRealizadas.Series.Clear();
            CHVentasRealizadas.ChartAreas[0].AxisX.Title = "";
            CHVentasRealizadas.ChartAreas[0].AxisY.Title = "";

            if (CAAnualReporteVentas.Checked)
            {
                ventaNegocio = new VentaNegocio();
                var ventasAnuales = ventaNegocio.ObtenerCantidadVentasAnuales(DTMDesdeReporteDeVentas.Value, DTMHastaReporteDeVentas.Value); 

                if (ventasAnuales.Count == 0)
                {
                    MessageBox.Show("No se encontraron ventas anuales para el rango seleccionado.");
                    cargarGraficos();
                    return;
                }

                
                var serieAnual = new Series("Cantidad Vendida Anual")
                {
                    ChartType = SeriesChartType.Column,  
                    BorderWidth = 2
                };

                serieAnual.IsVisibleInLegend = false;

                foreach (var venta in ventasAnuales)
                {
                    serieAnual.Points.AddXY(venta.Año, venta.TotalCantidad); 
                }

                CHVentasRealizadas.Series.Add(serieAnual);

                CHVentasRealizadas.ChartAreas[0].AxisX.Title = "Año";
                CHVentasRealizadas.ChartAreas[0].AxisY.Title = "Cantidad Vendida";

            }
            else if (CAMensualReporteVentas.Checked)
            {
                ventaNegocio = new VentaNegocio();
                var ventasMensuales = ventaNegocio.ObtenerCantidadVentasMensuales(DTMDesdeReporteDeVentas.Value, DTMHastaReporteDeVentas.Value);  // Obtener cantidades mensuales

                if (ventasMensuales.Count == 0)
                {
                    MessageBox.Show("No se encontraron ventas mensuales para el rango seleccionado.");
                    cargarGraficos();
                    return;
                }

               
                var serieMensual = new Series("Cantidad Vendida Mensual")
                {
                    ChartType = SeriesChartType.Line, 
                    BorderWidth = 3
                };
                serieMensual.IsVisibleInLegend = false;

                foreach (var venta in ventasMensuales)
                {
                    serieMensual.Points.AddXY(venta.MesNombre, venta.TotalCantidad); 
                }

                CHVentasRealizadas.Series.Add(serieMensual);

           
                CHVentasRealizadas.ChartAreas[0].AxisX.Title = "Mes";
                CHVentasRealizadas.ChartAreas[0].AxisY.Title = "Cantidad Vendida";
            }
            else if (CADiarioReporteVentas.Checked)
            {
                ventaNegocio = new VentaNegocio();
                var ventasDiarias = ventaNegocio.ObtenerCantidadVentasDiarias(DTMDesdeReporteDeVentas.Value, DTMHastaReporteDeVentas.Value);  

                if (ventasDiarias.Count == 0)
                {
                    MessageBox.Show("No se encontraron ventas diarias para el rango seleccionado.");
                    cargarGraficos();
                    return;
                }

           
                var serieDiaria = new Series("Cantidad Vendida Diaria")
                {
                    ChartType = SeriesChartType.Line,  
                    BorderWidth = 3
                };

                serieDiaria.IsVisibleInLegend = false;

               
                foreach (var venta in ventasDiarias)
                {
                    serieDiaria.Points.AddXY(venta.Fecha.ToString("dd/MM"), venta.TotalCantidad);  
                }

                CHVentasRealizadas.Series.Add(serieDiaria);

          
                CHVentasRealizadas.ChartAreas[0].AxisX.Title = "Fecha";
                CHVentasRealizadas.ChartAreas[0].AxisY.Title = "Cantidad Vendida";
            }

            CHVentasRealizadas.Invalidate();
        }

        private void CAAnualReporteVentas_CheckedChanged(object sender, System.EventArgs e)
        {
            UpdateChartRecaudacion();
            UpdateChartCantidad();
            UpdateControls();
        }

        private void CAMensualReporteVentas_CheckedChanged(object sender, System.EventArgs e)
        {
            UpdateChartRecaudacion();
            UpdateChartCantidad();
            UpdateControls();
        }

        private void CADiarioReporteVentas_CheckedChanged(object sender, System.EventArgs e)
        {
            UpdateChartRecaudacion();
            UpdateChartCantidad();
            UpdateControls();
        }

        private void LHastaReporteDeVentas_Click(object sender, System.EventArgs e)
        {

        }
    }
}
