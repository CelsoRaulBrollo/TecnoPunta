using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProyectoTaller.Views.Gerentes
{
    public partial class ReporteVentas : Form
    {
        public ReporteVentas()
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

            chart2.Series.Add(serieVentas);
            chart1.Legends[0].Enabled = false;
            chart2.Legends[0].Enabled = false;

            chart1.ChartAreas[0].AxisX.Title = "Meses";
            chart1.ChartAreas[0].AxisY.Title = "Cantidad";

            chart2.ChartAreas[0].AxisX.Title = "Meses";
            chart2.ChartAreas[0].AxisY.Title = "Monto ($)";


        }



        private void UpdateControls()
        {
            // Habilitar/Deshabilitar controles según los CheckBoxes
            bool isAnualChecked = CAAnualReporteVentas.Checked;
            bool isMensualChecked = CAMensualReporteVentas.Checked;
            bool isDiarioChecked = CADiarioReporteVentas.Checked;

            // Habilitar solo el ComboBox y DateTimePickers relacionados
            CBOXAnualReporteVentas.Enabled = isAnualChecked;
            CBOXMensualReporteVentas.Enabled = isMensualChecked;
            DTMDesdeReporteDeVentas.Enabled = isDiarioChecked;
            DTMHastaReporteDeVentas.Enabled = isDiarioChecked;

            // Deshabilitar los controles no relacionados
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
                // Si no hay CheckBox seleccionado, habilitar todos los CheckBoxes
                CAMensualReporteVentas.Enabled = true;
                CAAnualReporteVentas.Enabled = true;
                CADiarioReporteVentas.Enabled = true;
            }
        }

        private void CAAnualReporteVentas_CheckedChanged(object sender, System.EventArgs e)
        {
            UpdateControls();
        }

        private void CAMensualReporteVentas_CheckedChanged(object sender, System.EventArgs e)
        {
            UpdateControls();
        }

        private void CADiarioReporteVentas_CheckedChanged(object sender, System.EventArgs e)
        {
            UpdateControls();
        }
    }
}
