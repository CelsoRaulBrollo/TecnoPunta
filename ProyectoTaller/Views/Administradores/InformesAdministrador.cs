using System;
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

        private void CHCantidadUsuarios_Click(object sender, EventArgs e)
        {
            CHCantidadUsuarios.Series.Clear();

            var series = new Series("Cantidad de Usuarios");
            series.ChartType = SeriesChartType.Column;

            series.Points.AddXY("Administradores", 200);
            series.Points.AddXY("Gerentes", 50);
            series.Points.AddXY("Vendedores", 350);

            CHCantidadUsuarios.Series.Add(series);
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

            CHCantidadUsuarios.Series.Clear();

            var seriesCantidadUsuarios = new Series("Cantidad de Usuarios");
            seriesCantidadUsuarios.ChartType = SeriesChartType.Column;

            seriesCantidadUsuarios.Points.AddXY("Administradores", 200);
            seriesCantidadUsuarios.Points.AddXY("Gerentes", 50);
            seriesCantidadUsuarios.Points.AddXY("Vendedores", 350);

            CHCantidadUsuarios.Series.Add(seriesCantidadUsuarios);
        }
    }
}
