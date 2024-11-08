using ProyectoTaller.CModelos;
using ProyectoTaller.CNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProyectoTaller.Views.Gerentes
{
    public partial class ReporteProductos : Form
    {
        private VentaNegocio ventaNegocio;
        private MarcaNegocio marcaNegocio;
        
        public ReporteProductos()
        {
            InitializeComponent();
            this.CBMarca.SelectedIndexChanged += new System.EventHandler(this.CBMarca_SelectedIndexChanged);
           
            ConfigurarComboBoxMeses();
            CargarGrafico(DateTime.Now.Month, DateTime.Now.Year);
            CargarGraficoVentasTotales();




        }
        private void ConfigurarComboBoxMeses()
        {

            CBMarca.Items.Add("Seleccione el Mes");
            CBMarca.Items.Add("Enero");
            CBMarca.Items.Add("Febrero");
            CBMarca.Items.Add("Marzo");
            CBMarca.Items.Add("Abril");
            CBMarca.Items.Add("Mayo");
            CBMarca.Items.Add("Junio");
            CBMarca.Items.Add("Julio");
            CBMarca.Items.Add("Agosto");
            CBMarca.Items.Add("Septiembre");
            CBMarca.Items.Add("Octubre");
            CBMarca.Items.Add("Noviembre");
            CBMarca.Items.Add("Diciembre");


            CBMarca.SelectedIndex = 0;


            marcaNegocio = new MarcaNegocio();
            List<Marca> marcas = marcaNegocio.ListarMarca();

            List<string> nombresMarcas = new List<string>();

            nombresMarcas.Add("Ventas Totales");

            foreach (var marca in marcas)
            {
                nombresMarcas.Add(marca.Nombre_Marca);
            }
            CBMarcaProductoReporte.DataSource = nombresMarcas;

        }

       

        private void CBMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (CBMarca.SelectedIndex > 0)  
            {
                
                int mesSeleccionado = CBMarca.SelectedIndex;  
                mesSeleccionado++;  
               
                int añoActual = DateTime.Now.Year;

            
                CargarGrafico(mesSeleccionado, añoActual);
            }
            else
            {
                
                chart1.Series.Clear();
            }
        }

        private void CargarGrafico(int mes, int año)
        {
           
            VentaNegocio ventaNegocio = new VentaNegocio();
            var marcasVendidas = ventaNegocio.ObtenerMarcasMasVendidasPorMes(mes, año);

            chart1.Series.Clear();
            chart1.Legends.Clear(); 

            var serie = new Series
            {
                Name = "Ventas",
                Color = System.Drawing.Color.Blue,
                IsValueShownAsLabel = true,
                ChartType = SeriesChartType.Pie
            };
            chart1.Series.Add(serie);

      
            foreach (var marca in marcasVendidas)
            {
                serie.Points.AddXY(marca.Marca, marca.TotalVentas);
            }

      
            chart1.Titles.Clear();
            chart1.Titles.Add("Marcas Más Vendidas en " + new DateTime(año, mes, 1).ToString("MMMM yyyy"));

           
            chart1.Legends.Add(new Legend("Leyenda"));

         
            chart1.Invalidate();
        }

        private void CargarGraficoVentasTotales()
        {
           
            int añoActual = DateTime.Now.Year;

           
            ventaNegocio = new VentaNegocio();
            var ventasMensualesPorMarca = ventaNegocio.ObtenerVentasMensualesPorMarca(añoActual);

 
            chart2.Series.Clear();
            chart2.Legends.Clear();

        
            var marcas = ventasMensualesPorMarca
                .GroupBy(v => v.NombreMarca)
                .ToList();

    
            foreach (var marca in marcas)
            {
                var serie = new Series
                {
                    Name = marca.Key,  
                  
                    IsValueShownAsLabel = true,
                    ChartType = SeriesChartType.Line
                };

   
                foreach (var venta in marca)
                {
                    serie.Points.AddXY(venta.Mes, venta.CantidadVendida);
                }

            
                chart2.Series.Add(serie);
            }

           
            chart2.Titles.Clear();
            chart2.Titles.Add($"Evolución de Ventas por Marca - {añoActual}");

      
            chart2.Legends.Add(new Legend("Leyenda"));

       
            chart2.Invalidate(); 
        }

        private void ToggleSeriesVisibility(string marcaSeleccionada)
        {
   
            foreach (var serie in chart2.Series)
            {
                if (marcaSeleccionada == "Ventas Totales")
                {
          
                    serie.IsVisibleInLegend = true;
                    serie.Enabled = true;
                    serie.BorderWidth = 3;
                }
                else
                {
                    if (serie.Name == marcaSeleccionada)
                    {
                  
                        serie.IsVisibleInLegend = true;
                        serie.Enabled = true;
                        serie.BorderWidth = 3;
                    }
                    else
                    {
            
                        serie.IsVisibleInLegend = false;
                        serie.Enabled = false;
                        serie.BorderWidth = 0;
                    }
                }
            }

            // Refrescar el gráfico
            chart2.Invalidate();
        }

        private void CBMarcaProductoReporte_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string marcaSeleccionada = CBMarcaProductoReporte.SelectedItem.ToString();
          
            if (marcaSeleccionada == "Ventas Totales")
            {
                CargarGraficoVentasTotales();
            }
            else
            {
                ToggleSeriesVisibility(marcaSeleccionada);
            }
        }
    }
}
