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
        
        public ReporteProductos()
        {
            InitializeComponent();
            CargarGrafico();
            CargarGraficoVentasMensuales();

            

        }
        

        private void CargarGrafico()
        {
            // Datos de ejemplo de las marcas más vendidas
            string[] marcas = { "Marca A", "Marca B", "Marca C", "Marca D" };
            int[] ventas = { 30, 25, 20, 25 };

            // Configuración del gráfico
            chart1.Series.Clear();
            var serie = new Series
            {
                Name = "Ventas",
                Color = System.Drawing.Color.Blue,
                IsValueShownAsLabel = true,
                ChartType = SeriesChartType.Pie
            };
            chart1.Series.Add(serie);

            // Agregar los puntos al gráfico
            for (int i = 0; i < marcas.Length; i++)
            {
                serie.Points.AddXY(marcas[i], ventas[i]);
            }

            // Opcional: Títulos y leyendas
            chart1.Titles.Add("Marcas Más Vendidas");
            chart1.Legends.Add(new Legend("Leyenda"));
        }

        private void CargarGraficoVentasMensuales()
        {
            // Datos de ejemplo de ventas mensuales
            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            int[] ventas = { 100, 150, 120, 180, 220, 300, 250, 350, 400, 450, 500, 600 };

            // Configuración del gráfico
            chart2.Series.Clear();
            var serie = new Series
            {
                Color = System.Drawing.Color.Green,
                IsValueShownAsLabel = true,
                ChartType = SeriesChartType.Line
            };
            chart2.Series.Add(serie);

            // Agregar los puntos al gráfico
            for (int i = 0; i < meses.Length; i++)
            {
                serie.Points.AddXY(meses[i], ventas[i]);
            }

            // Configuración de los ejes
            chart2.ChartAreas[0].AxisX.Title = "Meses";
            chart2.ChartAreas[0].AxisY.Title = "Ventas";
            chart2.Titles.Add("Ventas Realizadas por Mes");

            chart2.Legends[0].Enabled = false;
        }

        

        
    }
}
