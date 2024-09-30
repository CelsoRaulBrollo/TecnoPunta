using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProyectoTaller.Views.Gerentes
{
    public partial class InformesGerente : Form
    {
        public InformesGerente()
        {
            InitializeComponent();
            CargarDatosGrafico();
        }


        private void CargarDatosGrafico()
        {
            // Limpia cualquier serie existente
            chart1.Series.Clear();

            // Crea una nueva serie
            Series serie = new Series
            {
                Name = "Ventas Totales",
                Color = System.Drawing.Color.Blue,
                ChartType = SeriesChartType.Column
            };

            // Agrega puntos de datos para todos los meses
            serie.Points.AddXY("Enero", 30);
            serie.Points.AddXY("Febrero", 20);
            serie.Points.AddXY("Marzo", 50);
            serie.Points.AddXY("Abril", 40);
            serie.Points.AddXY("Mayo", 70);
            serie.Points.AddXY("Junio", 60);
            serie.Points.AddXY("Julio", 80);
            serie.Points.AddXY("Agosto", 55);
            serie.Points.AddXY("Septiembre", 45);
            serie.Points.AddXY("Octubre", 75);
            serie.Points.AddXY("Noviembre", 65);
            serie.Points.AddXY("Diciembre", 90);

            // Agrega la serie al gráfico
            chart1.Series.Add(serie);

            chart2.Series.Clear();

            // Crea una nueva serie para las ventas
            Series serieVentas = new Series
            {
                Name = "Recaudacion",
                Color = System.Drawing.Color.Green,
                ChartType = SeriesChartType.Column
            };

            // Agrega puntos de datos para los 12 meses (importes de ventas)
            serieVentas.Points.AddXY("Enero", 1200);
            serieVentas.Points.AddXY("Febrero", 950);
            serieVentas.Points.AddXY("Marzo", 1500);
            serieVentas.Points.AddXY("Abril", 1300);
            serieVentas.Points.AddXY("Mayo", 1700);
            serieVentas.Points.AddXY("Junio", 1600);
            serieVentas.Points.AddXY("Julio", 1800);
            serieVentas.Points.AddXY("Agosto", 1100);
            serieVentas.Points.AddXY("Septiembre", 1400);
            serieVentas.Points.AddXY("Octubre", 1900);
            serieVentas.Points.AddXY("Noviembre", 2000);
            serieVentas.Points.AddXY("Diciembre", 2200);

            // Agrega la serie al gráfico
            chart2.Series.Add(serieVentas);
        }

        private void LTituloInformeGerente_Click(object sender, System.EventArgs e)
        {

        }
    }
}
