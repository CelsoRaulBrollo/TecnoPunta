using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProyectoTaller.Views.Gerentes
{
    public partial class EstadisticasGraficas : Form
    {
        public EstadisticasGraficas()
        {
            InitializeComponent();
        }

        private void CHMarcasValoradas_Click(object sender, EventArgs e)
        {
            CHMarcasValoradas.Series.Clear();

            var series = new Series("Marcas Valoradas");
            series.ChartType = SeriesChartType.Doughnut;

            series.Points.AddXY("Samsung", 45);
            series.Points.AddXY("Apple", 50);
            series.Points.AddXY("Xiaomi", 20);
            series.Points.AddXY("Huawei", 10);
            series.Points.AddXY("Motorola", 25);

            CHMarcasValoradas.Series.Add(series);
        }

        private void CHTelefonosStock_Click(object sender, EventArgs e)
        {
            CHTelefonosStock.Series.Clear();

            var series = new Series("Telefonos en Stock");
            series.ChartType = SeriesChartType.Column;

            series.Points.AddXY("Samsung", 10);
            series.Points.AddXY("Apple", 20);
            series.Points.AddXY("Xiaomi", 45);
            series.Points.AddXY("Huawei", 25);
            series.Points.AddXY("Motorola", 45);

            CHTelefonosStock.Series.Add(series);
        }

        private void CHMesesVentas_Click(object sender, EventArgs e)
        {
            CHMesesVentas.Series.Clear();

            var series = new Series("Ventas Últimos 6 Meses");
            series.ChartType = SeriesChartType.Bar;

            series.Points.AddXY("Abril", 120);
            series.Points.AddXY("Mayo", 150);
            series.Points.AddXY("Junio", 180);
            series.Points.AddXY("Julio", 140);
            series.Points.AddXY("Agosto", 200);
            series.Points.AddXY("Septiembre", 170);

            CHMesesVentas.Series.Add(series);
        }

        private void EstadisticasGraficas_Load(object sender, EventArgs e)
        {
            CHMarcasValoradas.Series.Clear();

            var seriesMarcas = new Series("Marcas Valoradas");
            seriesMarcas.ChartType = SeriesChartType.Doughnut;

            seriesMarcas.Points.AddXY("Samsung", 45);
            seriesMarcas.Points.AddXY("Apple", 50);
            seriesMarcas.Points.AddXY("Xiaomi", 20);
            seriesMarcas.Points.AddXY("Huawei", 10);
            seriesMarcas.Points.AddXY("Motorola", 25);

            CHMarcasValoradas.Series.Add(seriesMarcas);

            CHTelefonosStock.Series.Clear();

            var seriesStock = new Series("Marcas en Stock");
            seriesStock.ChartType = SeriesChartType.Column;

            seriesStock.Points.AddXY("Samsung", 10);
            seriesStock.Points.AddXY("Apple", 20);
            seriesStock.Points.AddXY("Xiaomi", 45);
            seriesStock.Points.AddXY("Huawei", 25);
            seriesStock.Points.AddXY("Motorola", 45);

            CHTelefonosStock.Series.Add(seriesStock);

            CHMesesVentas.Series.Clear();

            var seriesMeses = new Series("Ventas ultimos 6 meses");
            seriesMeses.ChartType = SeriesChartType.Bar;

            seriesMeses.Points.AddXY("Abril", 120);
            seriesMeses.Points.AddXY("Mayo", 150);
            seriesMeses.Points.AddXY("Junio", 180);
            seriesMeses.Points.AddXY("Julio", 140);
            seriesMeses.Points.AddXY("Agosto", 200);
            seriesMeses.Points.AddXY("Septiembre", 170);

            CHMesesVentas.Series.Add(seriesMeses);
        }
    }
}
