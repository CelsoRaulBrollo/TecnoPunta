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
            CargarGrafico();
            ChartEvolucionDelStockIncializar();
        }

        private void CargarGrafico()
        {

         
            var marcas = new string[] { "Apple", "Motorola", "Samsung", "Xiaomi", "Huawei" };
            var stock = new int[] { 50, 30, 70, 40, 20 }; 

          
            ChartTelefonosStock.Series.Clear();
            ChartTelefonosStock.ChartAreas.Clear();

        
            ChartArea chartArea = new ChartArea();
            ChartTelefonosStock.ChartAreas.Add(chartArea);

            Series series = new Series
            {
                Name = "Stock",
                Color = System.Drawing.Color.Green,
                ChartType = SeriesChartType.Column,
                IsVisibleInLegend = false
            };

     
            for (int i = 0; i < marcas.Length; i++)
            {
                series.Points.AddXY(marcas[i], stock[i]);
            }

            ChartTelefonosStock.Series.Add(series);
           


            ChartTelefonosStock.Titles.Clear();
          


        }

        private void ChartEvolucionDelStockIncializar()
        {
       
            ChartEvolucionDelStock.ChartAreas.Clear();
            ChartArea chartArea = new ChartArea();
            ChartEvolucionDelStock.ChartAreas.Add(chartArea);

            ChartEvolucionDelStock.Series.Clear();
            AddSeries("Apple", new double[] { 20, 30, 25, 40, 35, 50, 45, 60, 55, 70, 65, 80 });
            AddSeries("Motorola", new double[] { 15, 25, 20, 30, 25, 35, 30, 45, 40, 50, 45, 55 });
            AddSeries("Samsung", new double[] { 25, 35, 30, 50, 45, 60, 55, 70, 65, 80, 75, 90 });
            AddSeries("Xiaomi", new double[] { 10, 20, 15, 25, 20, 30, 25, 35, 30, 45, 40, 50 });
            AddSeries("Huawei", new double[] { 5, 15, 10, 20, 15, 25, 20, 30, 25, 35, 30, 40 });

        
            ChartEvolucionDelStock.Titles.Add("Evolución del Stock de Marcas");
            ChartEvolucionDelStock.Legends.Add(new Legend("Marcas"));
            ChartEvolucionDelStock.Legends[0].Docking = Docking.Top;

       
            ChartEvolucionDelStock.ChartAreas[0].AxisX.Title = "Día del Mes";
            ChartEvolucionDelStock.ChartAreas[0].AxisY.Title = "Stock";
        }

        private void AddSeries(string seriesName, double[] data)
        {
            Series series = new Series(seriesName)
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = 3,
                Color = GetSeriesColor(seriesName)
            };

            for (int i = 0; i < data.Length; i++)
            {
                series.Points.AddXY(i + 1, data[i]);
            }

            ChartEvolucionDelStock.Series.Add(series);
        }

        private System.Drawing.Color GetSeriesColor(string seriesName)
        {
            switch (seriesName)
            {
                case "Apple": return System.Drawing.Color.Red;
                case "Motorola": return System.Drawing.Color.Green;
                case "Samsung": return System.Drawing.Color.Blue;
                case "Xiaomi": return System.Drawing.Color.Orange;
                case "Huawei": return System.Drawing.Color.Purple;
                default: return System.Drawing.Color.Black;
            }
        }
    }



   
 }

