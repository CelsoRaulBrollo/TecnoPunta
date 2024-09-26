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

namespace ProyectoTaller.Views.Administradores
{
    public partial class InformesAdministrador : Form
    {
        public InformesAdministrador()
        {
            InitializeComponent();
        }

        private void CHMarcasVendidas_Click(object sender, EventArgs e)
        {
            CHMarcasVendidas.Series.Clear();

            var series = new Series("Marcas Vendidas");
            series.ChartType = SeriesChartType.Doughnut;

            series.Points.AddXY("Samsung", 30);
            series.Points.AddXY("Apple", 20);
            series.Points.AddXY("Xiaomi", 15);
            series.Points.AddXY("Huawei", 10);
            series.Points.AddXY("Motorola", 20);

            CHMarcasVendidas.Series.Add(series);
        }

        private void CHVentasMes_Click(object sender, EventArgs e)
        {
            CHVentasMes.Series.Clear();

            var series = new Series("Ventas Últimos 6 Meses");
            series.ChartType = SeriesChartType.Column;

            series.Points.AddXY("Abril", 120);
            series.Points.AddXY("Mayo", 150);
            series.Points.AddXY("Junio", 180);
            series.Points.AddXY("Julio", 140);
            series.Points.AddXY("Agosto", 200);
            series.Points.AddXY("Septiembre", 170);

            CHVentasMes.Series.Add(series);
        }

        private void InformesAdministrador_Load(object sender, EventArgs e)
        {
            CHMarcasVendidas.Series.Clear();

            var seriesMarcas = new Series("Marcas Vendidas");
            seriesMarcas.ChartType = SeriesChartType.Doughnut;

            seriesMarcas.Points.AddXY("Samsung", 40);
            seriesMarcas.Points.AddXY("Apple", 30);
            seriesMarcas.Points.AddXY("Xiaomi", 10);
            seriesMarcas.Points.AddXY("Huawei", 8);
            seriesMarcas.Points.AddXY("Motorola", 20);

            CHMarcasVendidas.Series.Add(seriesMarcas);

            CHVentasMes.Series.Clear();

            var seriesVentasMes = new Series("Ventas Últimos 6 Meses");
            seriesVentasMes.ChartType = SeriesChartType.Column;

            seriesVentasMes.Points.AddXY("Abril", 120);
            seriesVentasMes.Points.AddXY("Mayo", 150);
            seriesVentasMes.Points.AddXY("Junio", 180);
            seriesVentasMes.Points.AddXY("Julio", 140);
            seriesVentasMes.Points.AddXY("Agosto", 200);
            seriesVentasMes.Points.AddXY("Septiembre", 170);

            CHVentasMes.Series.Add(seriesVentasMes);
        }
    }
}
